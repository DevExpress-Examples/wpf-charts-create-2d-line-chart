Imports System
Imports System.Collections.Generic
Imports System.Windows

Namespace Line2DChart

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class ChartViewModel

        Private dataPointsField As List(Of DataPoint)

        Public ReadOnly Property DataPoints As List(Of DataPoint)
            Get
                If dataPointsField Is Nothing Then
                    dataPointsField = New List(Of DataPoint) From {New DataPoint(New DateTime(2021, 1, 1), 7.2), New DataPoint(New DateTime(2021, 2, 1), 8.3), New DataPoint(New DateTime(2021, 3, 1), 12.2), New DataPoint(New DateTime(2021, 4, 1), 15.6), New DataPoint(New DateTime(2021, 5, 1), 19.6), New DataPoint(New DateTime(2021, 6, 1), 22.7), New DataPoint(New DateTime(2021, 7, 1), 25.2), New DataPoint(New DateTime(2021, 8, 1), 25), New DataPoint(New DateTime(2021, 9, 1), 21.1), New DataPoint(New DateTime(2021, 10, 1), 16.3), New DataPoint(New DateTime(2021, 11, 1), 10.8), New DataPoint(New DateTime(2021, 12, 1), 7.5)}
                End If

                Return dataPointsField
            End Get
        End Property
    End Class

    Public Class DataPoint

        Public Property Time As Date

        Public Property Value As Double

        Public Sub New(ByVal time As Date, ByVal value As Double)
            Me.Time = time
            Me.Value = value
        End Sub
    End Class
End Namespace
