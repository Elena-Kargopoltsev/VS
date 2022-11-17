'MIS 322
'Elena Kargopoltsev
'Midterm exam
'04/29/2021

Option Explicit On
Option Strict On

Public Class Form1
    'Declaring variables for calculations
    Dim quantity As Integer = 1
    Dim errormessage As String
    Dim sol As String = "NEW"
    Dim lotnum As Integer
    Dim adfactor As Double
    Dim totalcost, baseprice, shipmet, adprice As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Quantitative variable declaration
        quantity = 1
        quantityTextBox.Text = quantity.ToString
    End Sub

    Private Sub plusButton_Click(sender As Object, e As EventArgs) Handles plusButton.Click
        'Checking for errors for a button
        If quantity > 0 And quantity < 12 Then
            quantity += 1
            quantityTextBox.Text = quantity.ToString
        ElseIf quantity = 12 Then
            errormessage = "Quantity should be less than 12"
            MessageBox.Show(errormessage, "Format Error")
            Exit Sub
        End If
    End Sub

    Private Sub minusButton_Click(sender As Object, e As EventArgs) Handles minusButton.Click
        'Checking for errors for a button
        If quantity <= 1 Then
            errormessage = "Quantity must be greater than 1"
            MessageBox.Show(errormessage, "Format Error")
            Exit Sub
        ElseIf quantity >= 1 Then
            quantity -= 1
            quantityTextBox.Text = quantity.ToString
        End If
    End Sub

    Private Sub addlistButton_Click(sender As Object, e As EventArgs) Handles addlistButton.Click
        'Variable declaration
        Dim shipping, durability, summary As String
        durability = Convert.ToString(InputBox("Enter the condition of the items as NEW, USED or SALVAGE", "Item Condition", sol))
        shipping = shippingTextBox.Text
        baseprice = Convert.ToDouble(basepTextBox.Text)

        If itemTextBox.Text = "" Then
            errormessage = "Please enter the item description"
            MessageBox.Show(errormessage, "Format Error")
            Exit Sub
        End If
        Try
            If baseprice.ToString = "" Then
                errormessage = "Base prise text box can not be empty"
                MessageBox.Show(errormessage, "Format Error")
                Exit Sub
            ElseIf baseprice <= 0 Then
                errormessage = "Base price should be more than 0"
                MessageBox.Show(errormessage, "Format Error")
                Exit Sub
            End If
        Catch oe As OverflowException
            errormessage = "The base price is too large."
            MessageBox.Show(errormessage, "Overflow Error")
            Exit Sub
        Catch fe As FormatException
            errormessage = "Please enter a number for the base price"
            MessageBox.Show(errormessage, "Format Error")
            Exit Sub
        Catch ex As Exception
            errormessage = ex.Message
            MessageBox.Show(errormessage, "System Error")
            Exit Sub
        End Try
        'Creating conditions for new variables
        shipping = shippingTextBox.Text
        If shipping.ToString = "" Then
            errormessage = "Please input a shipping method"
            MessageBox.Show(errormessage, "Format Error")
            Exit Sub
        ElseIf shipping.ToUpper = "STANDARD" Then
            shipmet = 5.95
            shipping = "Standard"
        ElseIf shipping.ToUpper = "PRIORITY" Then
            shipmet = 8.95
            shipping = "Priority"
        ElseIf shipping.ToUpper = "EXPRESS" Then
            shipmet = 12.95
            shipping = "Express"
        Else
            errormessage = "Please input the correct shipping method"
            MessageBox.Show(errormessage, "Format Error")
            Exit Sub
        End If

        If durability = "" Then
            errormessage = "Please input the correct item condition"
            MessageBox.Show(errormessage, "Format Error")
            Exit Sub
        ElseIf durability.ToUpper = "NEW" Then
            sol = "New"
            adfactor = 1
        ElseIf durability.ToUpper = "USED" Then
            sol = "Used"
            adfactor = 0.75
        ElseIf durability.ToUpper = "SALVAGE" Then
            sol = "Salvage"
            adfactor = 0.25
        Else
            errormessage = "Please input the correct item condition"
            MessageBox.Show(errormessage, "Format Error")
            Exit Sub
        End If
        'Calculate and show summary to user
        adprice = adfactor * baseprice
        totalcost = adprice * quantity * shipmet
        lotnum += 1
        summary = "* Lot " & lotnum.ToString & vbNewLine
        summary += itemTextBox.Text & vbNewLine
        summary += basepriceLabel.Text & " " & baseprice.ToString("C2") & vbNewLine
        summary += "Adjusted Price: " & adprice.ToString("C2") & vbNewLine
        summary += quantityLabel.Text & " " & quantityTextBox.Text & vbNewLine
        summary += shippingLabel.Text & " " & shipping.ToString & vbNewLine
        summary += "Shipping Cost: " & shipmet.ToString("C2") & vbNewLine
        summary += "Total Cost: " & totalcost.ToString("C2") & vbNewLine
        summary += "---------------------------------" & vbNewLine & vbNewLine
        auctionTextBox.AppendText(summary)
    End Sub
    Private Sub resetformButton_Click(sender As Object, e As EventArgs) Handles resetformButton.Click
        'Clear the form
        itemTextBox.Clear()
        quantityTextBox.Clear()
        basepTextBox.Clear()
        shippingTextBox.Clear()
        auctionTextBox.Clear()
        lotnum = 0
        itemTextBox.Focus()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'Close programm
        Me.Close()
    End Sub
End Class
