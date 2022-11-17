
'MIS 322
'Elena Kargopoltsev W01493806
'LAP 6
'06/01/2021

Option Explicit On
Option Strict Off
Option Infer On
Public Class Form1
    Private Sub TblGamesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblGamesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblGamesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GamesDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GamesDataSet.tblGames' table. You can move, or remove it, as needed.
        'Me.TblGamesTableAdapter.Fill(Me.GamesDataSet.tblGames)'

    End Sub

    Private Sub GameApp()
        'Declare Variables and clear the textbox
        summaryTextBox.Clear()
        Dim minimum, maximum As Integer
        Dim type, genre As String
        Dim zones As String = "{0,-35}{1,-20}{2,-20}{3,-10}{4,-15}{5,-15}"
        Dim culc As Integer = 0
        'Give value to variables
        If minimumComboBox.SelectedIndex = -1 Then
            minimum = 0
        Else
            minimum = minimumComboBox.SelectedItem
        End If

        If maximumComboBox.SelectedIndex = -1 Then
            maximum = 20
        Else
            maximum = maximumComboBox.SelectedItem
        End If

        type = typeComboBox.SelectedItem
        genre = genreComboBox.SelectedItem

        summaryTextBox.Text = String.Format(zones, "Title", "Type", "Genre", "Year", "Min Players", "Max Players") & vbNewLine
        summaryTextBox.Text += String.Format(zones, "-----", "----", "-----", "----", "-----------", "-----------") & vbNewLine
        'Make condition for line checker
        For Each myRow In GamesDataSet.tblGames.Rows
            If myRow.item("Type") = type Or myRow.item("Genre") = genre Or myRow.item("NumMinPlayers") = minimum Or myRow.item("NumMaxPlayers") = maximum Then
                summaryTextBox.Text += String.Format(zones, myRow.item("Title"), myRow.item("Type"),
                                                            myRow.item("Genre"), myRow.item("YearRelease"),
                                                            myRow.item("NumMinPlayers"), myRow.item("NumMaxPlayers")) & vbNewLine
                culc += 1
            End If
        Next

        If culc = 0 Then
            summaryTextBox.Text = " - No games match criteria - "
        Else
            summaryTextBox.Text += "Number of game matching criteria: " & culc
        End If
    End Sub

    Private Sub minimumComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles minimumComboBox.SelectedIndexChanged
        'Clear text box and call the procedure
        summaryTextBox.Clear()
        GameApp()
    End Sub

    Private Sub maximumComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles maximumComboBox.SelectedIndexChanged
        summaryTextBox.Clear()
        GameApp()
    End Sub

    Private Sub typeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles typeComboBox.SelectedIndexChanged
        summaryTextBox.Clear()
        GameApp()
    End Sub

    Private Sub genreComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles genreComboBox.SelectedIndexChanged
        summaryTextBox.Clear()
        GameApp()
    End Sub
    Private Sub minimumComboBox_TextChanged(sender As Object, e As EventArgs) Handles minimumComboBox.TextChanged
        summaryTextBox.Clear()
        GameApp()
    End Sub

    Private Sub maximumComboBox_TextChanged(sender As Object, e As EventArgs) Handles maximumComboBox.TextChanged
        summaryTextBox.Clear()
        GameApp()
    End Sub

    Private Sub typeComboBox_TextChanged(sender As Object, e As EventArgs) Handles typeComboBox.TextChanged
        summaryTextBox.Clear()
        GameApp()
    End Sub

    Private Sub genreComboBox_TextChanged(sender As Object, e As EventArgs) Handles genreComboBox.TextChanged
        summaryTextBox.Clear()
        GameApp()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Close app
        Me.Close()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        'Reset App 
        minimumComboBox.SelectedIndex = -1
        maximumComboBox.SelectedIndex = -1
        typeComboBox.SelectedIndex = -1
        genreComboBox.SelectedIndex = -1
        summaryTextBox.Clear()
    End Sub
End Class
