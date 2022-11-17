
'MIS 322
'Elena Kargopoltsev W01493806
'LAP 5
'05/18/2021

Option Explicit On
Option Strict On
Public Class OutputForm
    'Declare variables
    Private godprod, defectpr, iddefect, falspositive As Integer


    Private Sub OutputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Give a starting value
        godprod = 0
        iddefect = 0
        defectpr = 0
        falspositive = 0
        MonteCarloSim()
    End Sub

    Private Sub RerunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RerunToolStripMenuItem.Click
        'Run the process
        MonteCarloSim()
    End Sub
    Private Sub MonteCarloSim()
        'Set up checking process
        Do While count < attemt
            digit = random.Next(1, 1001)
            digit = digit / 10
            status = ProductDefect(digit)
            condition = ProductInspection(digit, status)
            Select Case condition
                Case "found defect"
                    iddefect = iddefect + 1
                Case "missed defect"
                    defectpr = defectpr + 1
                Case "false positive"
                    falspositive = falspositive + 1
                Case "no defect"
                    godprod = godprod + 1
            End Select
            count = count + 1
        Loop
        productsTextBox.Text = attemt.ToString
        goodTextBox.Text = godprod.ToString
        defectiveTextBox.Text = defectpr.ToString
        identifiedTextBox.Text = iddefect.ToString
        falseTextBox.Text = falspositive.ToString
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'Close the program
        Me.Close()
    End Sub
End Class