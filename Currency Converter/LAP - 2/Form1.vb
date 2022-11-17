'MIS 322
'Elena Kargopoltsev
'LAP 2
'04/15/2021

Option Explicit On
Option Strict On

Public Class Form1
    'Declaring constants and variables

    Const Euro As Double = 0.85
    Const Pound As Double = 0.722
    Const Yen As Double = 110.63
    Const Bitcoin As Double = 0.00002
    Dim errorMessage As String
    Dim Currency As Double
    Dim Conversion As Double


    Private Sub plasButton_Click(sender As Object, e As EventArgs) Handles plasButton.Click
        'This line defines the operating conditions for this button.
        'If the data is incorrect, error messages will appear.
        Try
            If amountTextBox.Text = "" Or conversionTextBox.Text = "" Then
                errorMessage = "Please enter amount or conversion"
                MessageBox.Show(errorMessage, "Format Error")
                Exit Sub
            ElseIf Convert.ToDouble(amountTextBox.Text) < 0 Then
                errorMessage = "Amount must be greater than or equal to zero"
                MessageBox.Show(errorMessage, "Negative Amount Error")
                Exit Sub
            ElseIf Convert.ToDouble(amountTextBox.Text) > 0 Then
                Currency = Convert.ToDouble(amountTextBox.Text)
                Currency = Currency + 100
                amountTextBox.Text = Currency.ToString
            End If
        Catch fe As FormatException
            errorMessage = "Currency not entered as a number. Be certain to omit any symbols."
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End Try
    End Sub

    Private Sub minusButton_Click(sender As Object, e As EventArgs) Handles minusButton.Click
        'This line defines the operating conditions for this button.
        'If the data is incorrect, error messages will appear.
        Try
            If amountTextBox.Text = "" Or conversionTextBox.Text = "" Then
                errorMessage = "Please enter amount or conversion"
                MessageBox.Show(errorMessage, "Format Error")
                Exit Sub
            ElseIf Convert.ToDouble(amountTextBox.Text) < 100 Then
                errorMessage = "Amount must be greater than or equal to zero"
                MessageBox.Show(errorMessage, "Negative Amount Error")
                Exit Sub
            ElseIf Convert.ToDouble(amountTextBox.Text) > 100 Then
                Currency = Convert.ToDouble(amountTextBox.Text)
                Currency = Currency - 100
                amountTextBox.Text = Currency.ToString
            End If
        Catch fe As FormatException
            errorMessage = "Currency not entered as a number. Be certain to omit any symbols."
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End Try
    End Sub

    Private Sub convertcurrencyButton_Click(sender As Object, e As EventArgs) Handles convertcurrencyButton.Click
        'Declaration of new variables for filling textboxes.
        'Assigning a new value to variables.
        Dim amounteuros, amountpounds, amountyen, amountbitcoin, exfeeuros, exfeepounds, exfeeyen, exfeebitcoin As Double
        Conversion = Convert.ToDouble(conversionTextBox.Text)
        Currency = Convert.ToDouble(amountTextBox.Text)
        amountTextBox.Text = Currency.ToString

        'Creation of conditions of functions for correct currency valuation.
        Try
            If amountTextBox.Text = "" Or conversionTextBox.Text = "" Then
                errorMessage = "Please enter amount or conversion"
                MessageBox.Show(errorMessage, "Format Error")
                Exit Sub
            ElseIf Convert.ToDouble(amountTextBox.Text) > 0 Then

                exfeeuros = (Currency * Euro) * (Conversion / 100)
                eurosexchangfeeTextBox.Text = exfeeuros.ToString("N2")
                eurosexchangerateTextBox.Text = Euro.ToString("P3")
                amounteuros = (Currency * Euro) - exfeeuros
                eurosamountTextBox.Text = amounteuros.ToString("N2")

                exfeepounds = (Currency * Pound) * (Conversion / 100)
                poundexchangefeeTextBox.Text = exfeepounds.ToString("N2")
                poundexchangerateTextBox.Text = Pound.ToString("P3")
                amountpounds = (Currency * Pound) - exfeepounds
                poundsamountTextBox.Text = amountpounds.ToString("N2")

                exfeeyen = (Currency * Yen) * (Conversion / 100)
                yenexchangefeeTextBox.Text = exfeeyen.ToString("N2")
                yenexchangerateTextBox.Text = Yen.ToString("P3")
                amountyen = (Currency * Yen) - exfeeyen
                yenamountTextBox.Text = amountyen.ToString("N2")

                exfeebitcoin = (Currency * Bitcoin) * (Conversion / 100)
                bitcoinexchangefeeTextBox.Text = exfeebitcoin.ToString("N2")
                bitcoinexchangerateTextBox.Text = Bitcoin.ToString("P3")
                exfeebitcoin = (Currency * Bitcoin) - amountbitcoin
                bitcoinamountTextBox.Text = amountbitcoin.ToString("N2")
            End If
        Catch fe As FormatException
            errorMessage = "Currency not entered as a number. Be certain to omit any symbols."
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End Try
    End Sub

    Private Sub resetformButton_Click(sender As Object, e As EventArgs) Handles resetformButton.Click

        'Cleaning textboxes.
        amountTextBox.Clear()
        conversionTextBox.Clear()
        eurosamountTextBox.Clear()
        eurosexchangerateTextBox.Clear()
        eurosexchangfeeTextBox.Clear()
        poundsamountTextBox.Clear()
        poundexchangerateTextBox.Clear()
        poundexchangefeeTextBox.Clear()
        yenamountTextBox.Clear()
        yenexchangerateTextBox.Clear()
        yenexchangefeeTextBox.Clear()
        bitcoinamountTextBox.Clear()
        bitcoinexchangerateTextBox.Clear()
        bitcoinexchangefeeTextBox.Clear()
    End Sub

    Private Sub exitapplicationButton_Click(sender As Object, e As EventArgs) Handles exitapplicationButton.Click
        'Exit the application
        Me.Close()
    End Sub
End Class
