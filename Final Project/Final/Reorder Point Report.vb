
'MIS 322
'Elena Kargopoltsev W01493806
'Final 
'06/04/2021

Option Explicit On
Option Strict Off

Public Class Reorder_Point_Report
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'Close application
        Me.Close()
    End Sub

    Private Sub Reorder_Point_Report_Activat(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Show up data
        bigTextBox.Clear()
        bigTextBox.Text = report.ToString
    End Sub
End Class