﻿Imports ANNForBeginners.Activation

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
End Interface

Public Class Layer
    Implements ILayer

    Private network_ As BackpropagationNetwork

#Region "Properties"
    Public Overridable ReadOnly Property ActivationFunction As ActivationFunction Implements ILayer.ActivationFunction
        Get
            Return ActivationFunction
        End Get
    End Property

    Public ReadOnly Property LayerType As ILayer.LayerType_ Implements ILayer.LayerType
        Get
            Return LayerType
        End Get
    End Property

    Public Overridable ReadOnly Property NeuronCount As Integer Implements ILayer.NeuronCount
        Get
            Return NeuronCount
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
#End Region

    Public Sub New(NeuronCount As Integer, activationFunction As ActivationFunction, Optional LayerType As ILayer.LayerType_ = ILayer.LayerType_.Hidden)

        'MyBase.new
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

End Class