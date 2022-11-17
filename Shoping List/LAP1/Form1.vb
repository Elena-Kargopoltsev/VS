'MIS 322
'Elena Kargopoltsev
'LAP 1
'04/06/2021
Public Class Form1

    Private Sub addtolistButton_Click(sender As Object, e As EventArgs) Handles addtolistButton.Click
        'In this procedure, enter your purchase, and the program will add it to the general list and
        'increase the number of purchases 
        shoppinglist2Label.Text = shoppinglist2Label.Text & " " & descriptionTextBox.Text

        Dim count As Integer

        count = CountLabel.Text
        count = count + 1
        CountLabel.Text = count
    End Sub

    Private Sub yellowButton_Click(sender As Object, e As EventArgs) Handles yellowButton.Click
        'This procedure changes the color of the shopping list to yellow and the color of the text to black.
        shoppinglist2Label.BackColor = Color.Yellow
        shoppinglist2Label.ForeColor = Color.Black
    End Sub

    Private Sub blueButton_Click(sender As Object, e As EventArgs) Handles blueButton.Click
        'This procedure changes the color of the shopping list to blue and the color of the text to white.
        shoppinglist2Label.BackColor = Color.Blue
        shoppinglist2Label.ForeColor = Color.White
    End Sub

    Private Sub redButton_Click(sender As Object, e As EventArgs) Handles redButton.Click

        'This procedure changes the color of the shopping list to red and the color of the text to white.

        shoppinglist2Label.BackColor = Color.Red
        shoppinglist2Label.ForeColor = Color.White
    End Sub

    Private Sub resetformButton_Click(sender As Object, e As EventArgs) Handles resetformButton.Click
        'This procedure returns the program to its original form.
        descriptionTextBox.Text = " "
        CountLabel.Text = "0"
        shoppinglist2Label.Text = ""
        shoppinglist2Label.BackColor = Color.Gray
        shoppinglist2Label.ForeColor = Color.Black
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'This procedure closes and exits the application.
        Me.Close()
    End Sub
End Class