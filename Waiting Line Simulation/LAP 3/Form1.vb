'MIS 322
'Elena Kargopoltsev
'LAP - 3
'04/22/2021

Option Explicit On
Option Strict On
Public Class Form1
    'Declaring an error message and a variable to retry
    Dim errormessage, numcus As String

    Private Sub simulateButton_Click(sender As Object, e As EventArgs) Handles simulateButton.Click
        'Cleaning the working area
        bigTextBox.Clear()
        'Variable declaration for counting
        Dim avgline, probab, arrate, serate As Double
        Dim simulate, counter, system As Integer
        Dim random As New Random
        'Creation of conditions for catching all possible mistakes
        Try
            If arrivalTextBox.Text = "" Then
                errormessage = "Please enter an arrival rate"
                MessageBox.Show(errormessage, "Format Error")
                Exit Sub
            ElseIf Convert.ToDouble(arrivalTextBox.Text) < 0 Then
                errormessage = "Please enter a positive arrival rate"
                MessageBox.Show(errormessage, "Format Error")
            End If

            If serviceTextBox.Text = "" Then
                errormessage = "Please enter a service rate"
                MessageBox.Show(errormessage, "Format Error")
                Exit Sub
            ElseIf Convert.ToDouble(serviceTextBox.Text) < 0 Then
                errormessage = "Please enter a positive service rate"
                MessageBox.Show(errormessage, "Format Error")
            End If
        Catch fe As FormatException
            errormessage = "Please enter a number in the arrival or service rate"
            MessageBox.Show(errormessage, "Format Error")
            Exit Sub
        End Try
        Try
            simulate = Convert.ToInt32(InputBox("Enter the number of periods for the simulation",
                                                "Simulation Duration", "8"))
            If simulate < 0 Then
                errormessage = "Please enter the positive duration"
                MessageBox.Show(errormessage, "Format Error")
                Exit Sub
            End If
        Catch fe As FormatException
            errormessage = "Please enter a number in the duration field"
            MessageBox.Show(errormessage, "Format Error")
            Exit Sub
        End Try
        'Сounting all data and variables
        arrate = Convert.ToDouble(arrivalTextBox.Text)
        serate = Convert.ToDouble(serviceTextBox.Text)
        avgline = arrate ^ 2 / (serate * (serate - arrate))
        probab = 1 - (arrate / serate)

        'Displays a report
        bigTextBox.Text = "***Line Analysis***" & vbNewLine & "- Average Line Lingth = " &
        avgline.ToString("N3") & vbNewLine &
        bigTextBox.Text + "- Probability No Customers = " & probab.ToString("P3") & vbNewLine & vbNewLine &
        bigTextBox.Text + "=== Customer Simulation ===" & vbNewLine
        'Repeating the process
        Do While counter < simulate
            counter = counter + 1

            If systemTextBox.Text = "" Then
                errormessage = "Please enter correct service load"
                MessageBox.Show(errormessage, "Format Error")
                Exit Sub
            ElseIf systemTextBox.Text.ToUpper = "LIGHT" Then
                system = random.Next(0, 6)
            ElseIf systemTextBox.Text.ToUpper = "MEDIUM" Then
                system = random.Next(6, 11)
            ElseIf systemTextBox.Text.ToUpper = "HEAVY" Then
                system = random.Next(11, 16)
            End If
            numcus = "Period " & counter & " Number of Customer: " & system & vbNewLine
            bigTextBox.Text += numcus
        Loop
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        'Clearing text boxes
        arrivalTextBox.Clear()
        serviceTextBox.Clear()
        systemTextBox.Clear()
        bigTextBox.Clear()
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        'Close the programm
        Me.Close()
    End Sub

End Class
