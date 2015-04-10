Public Class Util
    Public NotInheritable Class Array
        ''' <summary>
        ''' Extract a specific row from a Double array.
        ''' </summary>
        ''' <param name="rowNumber">The row to extract.</param>
        ''' <param name="array">The array from which to extract the row.</param>
        ''' <returns>A Double array of the same second dimension as the original, containing a specific row's data.</returns>
        ''' <remarks></remarks>
        Public Shared Function GetRow(rowNumber As Integer, array As Double(,))
            Dim arrayParameterCount As Integer = array.GetLength(1)

            Dim returnArray(arrayParameterCount - 1) As Double

            For i = 0 To arrayParameterCount - 1
                returnArray(i) = array(rowNumber, i)
            Next

            Return returnArray
        End Function
    End Class

    Public NotInheritable Class Random
        Private Sub New()
        End Sub
        Private Shared gen As New System.Random()

        Public Shared Function Gaussian() As Double
            Return Gaussian(0.0, 1.0)
        End Function

        Public Shared Function Gaussian(mean As Double, stddev As Double) As Double
            Dim rVal1 As Double
            Dim rVal2 As Double

            Gaussian(mean, stddev, rVal1, rVal2)

            Return rVal1
        End Function

        Public Shared Sub Gaussian(mean As Double, stddev As Double, ByRef val1 As Double, ByRef val2 As Double)
            Dim u As Double, v As Double, s As Double, t As Double

            Do
                u = 2 * gen.NextDouble() - 1
                v = 2 * gen.NextDouble() - 1
            Loop While u * u + v * v > 1 OrElse (u = 0 AndAlso v = 0)

            s = u * u + v * v
            t = Math.Sqrt((-2.0 * Math.Log(s)) / s)

            val1 = stddev * u * t + mean
            val2 = stddev * v * t + mean
        End Sub
    End Class

    Public NotInheritable Class File

#Region "generic"
        ''' <summary>
        ''' Get the number of lines in a (text-based) file.
        ''' </summary>
        ''' <param name="filePath">Path of the file to be checked.</param>
        ''' <returns>The number of lines; -1 if check failed.</returns>
        ''' <remarks></remarks>
        Public Shared Function GetLineCount(filePath As String) As Integer
            If System.IO.Path.HasExtension(filePath) = False Then
                Return -1
            Else
                Return System.IO.File.ReadAllLines(filePath.ToString).Length
            End If
        End Function
#End Region

        Public NotInheritable Class CSV
            ''' <summary>
            ''' Checks if each line of a csv file is of the same lenght (same number of fields).
            ''' </summary>
            ''' <param name="csvPath">File path to the csv to be checked.</param>
            ''' <param name="delimeter">The delimiter used in the csv file. Default = ,</param>
            ''' <returns>True if all lines have the same number of fields, false if not.</returns>
            ''' <remarks></remarks>
            Public Shared Function HasConsistentFields(csvPath As String, Optional delimeter As String = ",") As Boolean
                Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(csvPath)
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(delimeter)

                    Dim numFields As Integer = MyReader.ReadFields().Length
                    Dim line As Integer = 1

                    While Not MyReader.EndOfData
                        Try
                            If numFields <> MyReader.ReadFields().Length Then
                                Debug.WriteLine("Line " & line & " has an inconsistent number of entries.")
                                Return False
                            Else
                                line += 1
                            End If
                        Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                            Debug.WriteLine("Line " & ex.Message & "is not valid and will be skipped.")
                        End Try
                    End While
                End Using

                Return True
            End Function

            ''' <summary>
            ''' Gets the number of fields (entries/rows) in a csv file.
            ''' </summary>
            ''' <param name="csvPath">File path to the csv to be checked.</param>
            ''' <param name="delimeter">The delimiter used in the csv file. Default = ,</param>
            ''' <returns>The number of fields (entries/rows) in a csv file.</returns>
            ''' <remarks></remarks>
            Public Shared Function GetFieldCount(csvPath As String, Optional delimeter As String = ",") As Integer
                Dim numEntries As Integer

                Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(csvPath)
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(delimeter)

                    numEntries = MyReader.ReadFields().Length
                    Dim line As Integer = 1

                    While Not MyReader.EndOfData
                        numEntries = MyReader.ReadFields().Length
                    End While
                End Using

                Return numEntries
            End Function
        End Class
    End Class
End Class
