'MIS 322
'Elena Kargopoltsev
'LAP 4
'05/06/2021

Option Explicit On
Option Strict On


Public Class SummaryForm
    Private Sub SummaryForm_Activate(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Display all report detailes
        summTextBox.Text = report
    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        'Show massage confirmation and close the form
        MessageBox.Show("Your order has been confirmed", "Confirmation")
        Me.Close()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        'Close the form
        Me.Close()
    End Sub
End Class