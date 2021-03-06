﻿Imports NeuralNetwork.Activation

Public Interface ILayer
    Enum LayerType_
        Input
        Hidden
        Output
    End Enum

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value>The number of neurons in this layer.</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property NeuronCount As Integer

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value>The activation function used in this layer.</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property ActivationFunction As ActivationFunction

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value>The type of layer this is.</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property LayerType As LayerType_

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value>The network this layer is attached to.</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property Network As BackpropagationNetwork

    ''' <summary>
    ''' Input into each neuron i in the current layer, from the previous layer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property Inputs As Double()
    Property Weights As Double(,)
    Property Bias As Double()
    Property Outputs As Double()
    Property Deltas As Double()
    Property WeightDeltas As Double(,)
    Property PreviousWeightDeltas As Double(,)
    Property BiasDeltas As Double()
    Property PreviousBiasDeltas As Double()
End Interface

Public Class Layer
    Implements ILayer

    Private network_ As BackpropagationNetwork
    Private _inputs As Double()
    Private _weights As Double(,)
    Private _bias As Double()
    Private _outputs As Double()
    Private _activationFunction As ActivationFunction
    Private _layerType As ILayer.LayerType_
    Private _neuronCount As Integer
    Private _deltas As Double()
    Private _weightDeltas As Double(,)
    Private _previousWeightDeltas As Double(,)
    Private _biasDeltas As Double()
    Private _previousBiasDeltas As Double()

#Region "Properties"
    Public Overridable ReadOnly Property ActivationFunction As ActivationFunction Implements ILayer.ActivationFunction
        Get
            Return _activationFunction
        End Get
    End Property

    Public ReadOnly Property LayerType As ILayer.LayerType_ Implements ILayer.LayerType
        Get
            Return _layerType
        End Get
    End Property

    Public Overridable ReadOnly Property NeuronCount As Integer Implements ILayer.NeuronCount
        Get
            Return _neuronCount
        End Get
    End Property

    Public Overridable Property Network As BackpropagationNetwork
        Get
            Return _network
        End Get
        Set(value As BackpropagationNetwork)
            _network = value
        End Set
    End Property

    Public Overridable Property Weights As Double(,) Implements ILayer.Weights
        Get
            Return _weights
        End Get
        Set(value As Double(,))
            _weights = value
        End Set
    End Property

    Public Overridable Overloads Property Bias As Double() Implements ILayer.Bias
        Get
            Return _bias
        End Get
        Set(value As Double())
            _bias = value
        End Set
    End Property

    Public Overridable Overloads Property Bias(index As Integer) As Double
        Get
            Return _bias(index)
        End Get
        Set(value As Double)
            _bias(index) = value
        End Set
    End Property

    Public Overridable Property Outputs As Double() Implements ILayer.Outputs
        Get
            Return _outputs
        End Get
        Set(value As Double())
            _outputs = value
        End Set
    End Property

    Public Overridable Property Inputs As Double() Implements ILayer.Inputs
        Get
            Return _inputs
        End Get
        Set(value As Double())
            _inputs = value
        End Set
    End Property

    Public Overridable Overloads Property Deltas As Double() Implements ILayer.Deltas
        Get
            Return _deltas
        End Get
        Set(value As Double())
            _deltas = value
        End Set
    End Property

    Public Overridable Overloads Property Deltas(index As Integer) As Double
        Get
            Return _deltas(index)
        End Get
        Set(value As Double)
            _deltas(index) = value
        End Set
    End Property

    Public Overridable Property WeightDeltas As Double(,) Implements ILayer.WeightDeltas
        Get
            Return _weightDeltas
        End Get
        Set(value As Double(,))
            _weightDeltas = value
        End Set
    End Property

    Public Overridable Property PreviousWeightDeltas As Double(,) Implements ILayer.PreviousWeightDeltas
        Get
            Return _previousWeightDeltas
        End Get
        Set(value As Double(,))
            _previousWeightDeltas = value
        End Set
    End Property

    Public Overridable Property BiasDeltas As Double() Implements ILayer.BiasDeltas
        Get
            Return _biasDeltas
        End Get
        Set(value As Double())
            _biasDeltas = value
        End Set
    End Property

    Public Overridable Property PreviousBiasDeltas As Double() Implements ILayer.PreviousBiasDeltas
        Get
            Return _previousBiasDeltas
        End Get
        Set(value As Double())
            _previousBiasDeltas = value
        End Set
    End Property
#End Region

    Public Sub New(NeuronCount As Integer, activationFunction As ActivationFunction, Optional LayerType As ILayer.LayerType_ = ILayer.LayerType_.Hidden)

        _neuronCount = NeuronCount
        _activationFunction = activationFunction
        _layerType = LayerType

        'dimensionalize outputs
        ReDim _outputs(0 To NeuronCount - 1)
        'MyBase.new
    End Sub

    Public Sub GenerateWeights(network As BackpropagationNetwork, currentLayerIndex As Integer)
        'set weights = 1 if input layer (it has no weight and activation function), and to random if other type
        'NOTE:  These are the weights going from THIS layer to the next, so they will only be used in the next layers' calculation
        ReDim _weights(0 To NeuronCount - 1, 0 To network.Layers(currentLayerIndex + 1).NeuronCount - 1)

        For i = 0 To NeuronCount - 1
            For j = 0 To network.Layers(currentLayerIndex + 1).NeuronCount - 1
                If LayerType = ILayer.LayerType_.Input Then
                    _weights(i, j) = 1
                Else
                    _weights(i, j) = Util.Random.Gaussian()
                End If
            Next
        Next
    End Sub

    Public Sub GenerateBias(network As BackpropagationNetwork)
        ReDim _bias(0 To NeuronCount - 1)

        For i = 0 To NeuronCount - 1
            If LayerType = ILayer.LayerType_.Input Then
                _bias(i) = 0
            Else
                If form_main.chk_updateBias.Checked = False Then _bias(i) = 1 Else _bias(i) = Util.Random.Gaussian()
            End If
        Next
    End Sub

    Public Sub InitialiseDeltas(network As BackpropagationNetwork, currentLayerIndex As Integer)
        'generate empty deltas
        ReDim _deltas(0 To NeuronCount - 1)
        ReDim _biasDeltas(0 To NeuronCount - 1)
        ReDim _previousBiasDeltas(0 To NeuronCount - 1)

        If currentLayerIndex = network.LayerCount - 1 Then
            Exit Sub
        End If

        ReDim _weightDeltas(0 To NeuronCount - 1, 0 To network.Layers(currentLayerIndex + 1).NeuronCount - 1)
        ReDim _previousWeightDeltas(0 To NeuronCount - 1, 0 To network.Layers(currentLayerIndex + 1).NeuronCount - 1)
    End Sub

    Public Property Network1 As BackpropagationNetwork Implements ILayer.Network

    Private Property _network As BackpropagationNetwork

End Class

Public Class NetworkStructure
    Private ReadOnly _layers As List(Of ILayer)
    Private ReadOnly _network As BackpropagationNetwork

    'constructor
    Public Sub New(network_ As BackpropagationNetwork)
        _layers = New List(Of ILayer) '()
        _network = network_
    End Sub

#Region "Properties"
    Public ReadOnly Property Layers As IList(Of ILayer)
        Get
            Return _layers
        End Get
    End Property

    Public ReadOnly Property Network As BackpropagationNetwork
        Get
            Return _network
        End Get
    End Property
#End Region
End Class

Public Class BackpropagationNetwork
    Private ReadOnly networkStructure_ As NetworkStructure
    'constructor
    Public Sub New()
        networkStructure_ = New NetworkStructure(Me)
    End Sub

    Public Sub AddLayer(layer As ILayer)
        layer.Network = Me
        networkStructure_.Layers.Add(layer)
    End Sub

    Public Overloads Function Layers(index As Integer) As ILayer
        Return networkStructure_.Layers(index)
    End Function

    Public Overloads Function Layers() As List(Of ILayer)
        Return networkStructure_.Layers()
    End Function

    Public Function LayerCount()
        Return networkStructure_.Layers.Count
    End Function

    Public Function LastLayer() As ILayer
        Return networkStructure_.Layers(networkStructure_.Layers.Count - 1)
    End Function
End Class
