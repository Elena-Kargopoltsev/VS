
'MIS 322
'Elena Kargopoltsev W01493806
'LAP 5
'05/18/2021

Option Explicit On
Option Strict On
Public Class MainForm
    Private Sub RunSimToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunSimToolStripMenuItem.Click
        'Make several error traps
        Try
            attemt = Convert.ToInt32(numberTextBox.Text)
            defect = Convert.ToDouble(defectTextBox.Text)
            precision = Convert.ToDouble(testTextBox.Text)
        Catch fe As FormatException
            MessageBox.Show("Please enter the number according to the requirements", "Format Error")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error")
            Exit Sub
        End Try

        If defect < 0 Or precision < 0 Or defect > 100 Or precision > 100 Then
            MessageBox.Show("Enter a percentage from 0 to 100", "Format Error")
            Exit Sub
        End If
        OutputForm.ShowDialog()
    End Sub

    Private Sub ResetSimToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetSimToolStripMenuItem.Click
        'Reset form
        numberTextBox.Clear()
        defectTextBox.Clear()
        testTextBox.Clear()
        attemt = 0
        defect = 0
        precision = 0
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Close form
        Me.Close()
    End Sub
End Class
