'MIS 322
'Elena Kargopoltsev W01493806
'LAP 5
'05/18/2021

Option Explicit On
Option Strict On
Module Module1
    Public attemt As Integer
    Public count As Integer = 0
    Public defect, precision, digit As Double
    Public random As New Random
    Public status As Boolean
    Public condition As String
    Public Function ProductDefect(ByVal digit As Double) As Boolean
        If digit <= defect Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function ProductInspection(ByVal digit As Double, ByVal status As Boolean) As String
        If status = True Then
            If precision >= digit Then
                Return "found defect"
            Else
                Return "missed defect"
            End If
        Else
            If precision <= digit Then
                Return "false positive"
            Else
                Return "no defect"
            End If
        End If
    End Function
End Module
