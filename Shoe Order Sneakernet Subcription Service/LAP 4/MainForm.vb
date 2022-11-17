
'MIS 322
'Elena Kargopoltsev
'LAP 4
'05/06/2021

Option Explicit On
Option Strict On

Public Class MainForm
    'Declare variables
    Dim shoesize As Integer
    Dim errormessage, width, repeat, frequency, sizing, nsw, ctext, dtext, satext, sptext As String
    Dim shoecost, discount, subtotal, taxamount, totdue, cstyle, dstyle, sastyle, spstyle As Double

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Show the numbers for checkbox when form is load
        casCheckBox.Text += " " & casual.ToString("c2")
        dresCheckBox.Text += " " & dress.ToString("c2")
        sandCheckBox.Text += " " & sandals.ToString("c2")
        sportCheckBox.Text += " " & sports.ToString("c2")
    End Sub

    Private Sub submitformButton_Click(sender As Object, e As EventArgs) Handles submitformButton.Click
        'Check the errors and gives values for discount and frequency
        If monRadioButton.Checked = False And quartRadioButton.Checked = False And evsixRadioButton.Checked = False And annualRadioButton.Checked = False Then
            MessageBox.Show("Please choose the frequency", "Format Error")
            Exit Sub
        ElseIf monRadioButton.Checked = True Then
            discount = 0.2
            frequency = "Monthly "
        ElseIf quartRadioButton.Checked = True Then
            frequency = "Quarterly "
            discount = 0.15
        ElseIf evsixRadioButton.Checked = True Then
            frequency = "Every Six Months "
            discount = 0.1
        ElseIf annualRadioButton.Checked = True Then
            frequency = "Anually "
            discount = 0
        End If
        If casCheckBox.Checked = False And dresCheckBox.Checked = False And sandCheckBox.Checked = False And sportCheckBox.Checked = False Then
            MessageBox.Show("Choose the shoe style", "Choice Error")
            Exit Sub
        End If
        'Check the errors and gives values for variables
        If casCheckBox.Checked = True Then
            cstyle = casual
        Else
            cstyle = 0
        End If

        If dresCheckBox.Checked = True Then
            dstyle = dress
        Else
            dstyle = 0
        End If

        If sandCheckBox.Checked = True Then
            sastyle = sandals
        Else
            sastyle = 0
        End If

        If sportCheckBox.Checked = True Then
            spstyle = sports
        Else
            spstyle = 0
        End If
        'Check the errors and gives values for variables
        shoecost = cstyle + dstyle + sastyle + spstyle
        Try
            shoesize = Convert.ToInt32(shoesizeTextBox.Text)
            If shoesize < 5 Or shoesize > 15 Then
                MessageBox.Show("Minimum size is 5 - Maximum size is 15")
                Exit Sub
            End If
        Catch fe As FormatException
            errormessage = "Shoe size must be a number"
            MessageBox.Show(errormessage, "Format Error")
            Exit Sub
        Catch ex As Exception
            errormessage = ex.Message
            MessageBox.Show(errormessage, "System Error")
            Exit Sub
        End Try

        width = widTextBox.Text
        '
        Select Case width.ToUpper
            Case "NARROW"
                nsw = " Narrow"
            Case "STANDARD"
                nsw = " Standard"
            Case "WIDE"
                nsw = " Wide"
            Case Else
                MessageBox.Show("Please choose widths")
                Exit Sub
        End Select

        If menRadioButton.Checked = False And womenRadioButton.Checked = False Then
            MessageBox.Show("Please choose men's or women's")
            Exit Sub
        ElseIf womenRadioButton.Checked Then
            sizing = "Size: Women's " & shoesize & nsw & vbNewLine
        ElseIf menRadioButton.Checked Then
            sizing = "Size: Men's " & shoesize & nsw & vbNewLine
        End If

        If shoesizeTextBox.Text = "" Then
            MessageBox.Show("Please enter shoe size")
            Exit Sub
        ElseIf widTextBox.Text = "" Then
            MessageBox.Show("Please enter the width")
            Exit Sub
        End If

        If casCheckBox.Checked Then
            ctext = "*" & casCheckBox.Text & vbNewLine
        Else
            ctext = ""
        End If

        If dresCheckBox.Checked Then
            dtext = "*" & dresCheckBox.Text & vbNewLine
        Else
            dtext = ""
        End If

        If sandCheckBox.Checked Then
            satext = "*" & sandCheckBox.Text & vbNewLine
        Else
            satext = ""
        End If


        If sportCheckBox.Checked Then
            sptext = "*" & sportCheckBox.Text & vbNewLine
        Else
            sptext = ""
        End If
        'Calculate and give value for report variable
        repeat = frequency & " Order Delivery" & vbNewLine & ctext + dtext + satext + sptext
        subtotal = shoecost - shoecost * discount
        taxamount = shoecost * 0.1
        totdue = subtotal + taxamount

        report = repeat & vbNewLine & sizing & "Shoe Cost: " & shoecost.ToString("c2") & vbNewLine
        report += "Discount: " & (shoecost * discount).ToString("c2") & vbNewLine
        report += "Subtotal: " & subtotal.ToString("c2") & vbNewLine
        report += "Tax Amount: " & taxamount.ToString("c2") & vbNewLine
        report += "========================" & vbNewLine
        report += "Total Due: " & totdue.ToString("c2")

        SummaryForm.ShowDialog()
    End Sub

    Private Sub resetformButton_Click(sender As Object, e As EventArgs) Handles resetformButton.Click
        'Clear the form
        monRadioButton.Checked = False
        quartRadioButton.Checked = False
        evsixRadioButton.Checked = False
        annualRadioButton.Checked = False
        casCheckBox.Checked = False
        dresCheckBox.Checked = False
        sandCheckBox.Checked = False
        sportCheckBox.Checked = False
        shoesizeTextBox.Clear()
        widTextBox.Clear()
        menRadioButton.Checked = False
        womenRadioButton.Checked = False
    End Sub

    Private Sub closeformButton_Click(sender As Object, e As EventArgs) Handles closeformButton.Click
        'Close the form
        Me.Close()
    End Sub

End Class
