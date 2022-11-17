
'MIS 322
'Elena Kargopoltsev W01493806
'Final 
'06/04/2021


Option Explicit On
Option Strict Off

Public Class Form1
    'Declare variables
    Public line, calculation As Integer
    Public reorder As Double
    Public zone As String = "{0,-40}{1,15}{2,15}"
    Private Sub TblProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductListDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Assign values to combo boxes
        'TODO: This line of code loads data into the 'ProductListDataSet.tblProducts' table. You can move, or remove it, as needed.
        serviceComboBox.Items.Add("50%")
        serviceComboBox.Items.Add("60%")
        serviceComboBox.Items.Add("70%")
        serviceComboBox.Items.Add("80%")
        serviceComboBox.Items.Add("90%")
        serviceComboBox.Items.Add("95%")
        serviceComboBox.Items.Add("99%")
        leadComboBox.Items.Add("1")
        leadComboBox.Items.Add("2")
        leadComboBox.Items.Add("3")
        leadComboBox.Items.Add("4")
        leadComboBox.Items.Add("5")
        leadComboBox.Items.Add("6")
        leadComboBox.Items.Add("7")
        Me.TblProductsTableAdapter.Fill(Me.ProductListDataSet.tblProducts)

    End Sub

    Private Sub previousButton_Click(sender As Object, e As EventArgs) Handles previousButton.Click
        'Assign values to the following buttons and text boxes
        line = ProductListDataSet.tblProducts.Count
        If calculation < line And calculation > 0 Then
            productTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("ProductName")
            unitTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("UnitsInStock")
            unitorderTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("UnitsOnOrder")
            reorderTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("ReorderLevel")
            averageTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("AverageDemandLT")
            stdTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("StandardDevLT")
            calculation -= 1
        Else
            calculation = 0
        End If
    End Sub

    Private Sub firstButton_Click(sender As Object, e As EventArgs) Handles firstButton.Click
        'Assign values to the following buttons and text boxes
        line = ProductListDataSet.tblProducts.Count
        If calculation < line Then
            calculation = 0
            productTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("ProductName")
            unitTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("UnitsInStock")
            unitorderTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("UnitsOnOrder")
            reorderTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("ReorderLevel")
            averageTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("AverageDemandLT")
            stdTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("StandardDevLT")
        End If
    End Sub

    Private Sub lastButton_Click(sender As Object, e As EventArgs) Handles lastButton.Click
        'Assign values to the lastButton and text boxes
        line = ProductListDataSet.tblProducts.Count
        If calculation < line Then
            calculation = 76
            productTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("ProductName")
            unitTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("UnitsInStock")
            unitorderTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("UnitsOnOrder")
            reorderTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("ReorderLevel")
            averageTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("AverageDemandLT")
            stdTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("StandardDevLT")
        End If
    End Sub

    Private Sub transferproductButton_Click(sender As Object, e As EventArgs) Handles transferproductButton.Click
        'Move data to destination
        averTextBox.Text = averageTextBox.Text
        standartTextBox.Text = stdTextBox.Text
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        'Counting and checking setpoint errors
        If serviceComboBox.SelectedItem = "50%" Then
            z = 0.0
        ElseIf serviceComboBox.SelectedItem = "60%" Then
            z = 0.2533
        ElseIf serviceComboBox.SelectedItem = "70%" Then
            z = 0.5244
        ElseIf serviceComboBox.SelectedItem = "80%" Then
            z = 0.8416
        ElseIf serviceComboBox.SelectedItem = "90%" Then
            z = 1.2816
        ElseIf serviceComboBox.SelectedItem = "95%" Then
            z = 1.6449
        ElseIf serviceComboBox.SelectedItem = "99%" Then
            z = 2.3263
        End If
        serviceComboBox.Text = serviceComboBox.Text.Replace("%", "")
        Try
            If averTextBox.Text = "" Or standartTextBox.Text = "" Or serviceComboBox.Text = "" Or leadComboBox.Text = "" Then
                MessageBox.Show("Please enter the right number")
            ElseIf averTextBox.Text < 0 Or standartTextBox.Text < 0 Or serviceComboBox.Text < 0 Or leadComboBox.Text < 0 Then
                MessageBox.Show("Please enter positive number")
            End If
        Catch fe As FormatException
            MessageBox.Show("Please enter the right number", "Format Error")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Please enter the right number", "System Error")
            Exit Sub
        End Try
        reorder = averTextBox.Text * leadComboBox.Text + z * standartTextBox.Text * (Math.Sqrt(leadComboBox.Text))
        reorderpoLabel.Text = reorder.ToString("N0")
    End Sub

    Private Sub ClearFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearFormToolStripMenuItem.Click
        'Clear the form
        productTextBox.Clear()
        unitTextBox.Clear()
        unitorderTextBox.Clear()
        reorderTextBox.Clear()
        averageTextBox.Clear()
        stdTextBox.Clear()
        averTextBox.Clear()
        standartTextBox.Clear()
        serviceComboBox.Text = ""
        leadComboBox.Text = ""
        reorderpoLabel.Text = ""
    End Sub

    Private Sub RunROPReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunROPReportToolStripMenuItem.Click
        'Give values to z, error checking and calculation for next form
        If serviceComboBox.SelectedItem = "50%" Then
            z = 0.0
        ElseIf serviceComboBox.SelectedItem = "60%" Then
            z = 0.2533
        ElseIf serviceComboBox.SelectedItem = "70%" Then
            z = 0.5244
        ElseIf serviceComboBox.SelectedItem = "80%" Then
            z = 0.8416
        ElseIf serviceComboBox.SelectedItem = "90%" Then
            z = 1.2816
        ElseIf serviceComboBox.SelectedItem = "95%" Then
            z = 1.6449
        ElseIf serviceComboBox.SelectedItem = "99%" Then
            z = 2.3263
        End If
        serviceComboBox.Text = serviceComboBox.Text.Replace("%", "")
        Try
            If averTextBox.Text = "" Or standartTextBox.Text = "" Or serviceComboBox.Text = "" Or leadComboBox.Text = "" Then
                MessageBox.Show("Please enter the right number")
            ElseIf averTextBox.Text < 0 Or standartTextBox.Text < 0 Or serviceComboBox.Text < 0 Or leadComboBox.Text < 0 Then
                MessageBox.Show("Please enter positive number")
            End If
        Catch fe As FormatException
            MessageBox.Show("Please enter the right number", "Format Error")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Please enter the right number", "System Error")
            Exit Sub
        End Try
        report = String.Format(zone, "Product", "Current ROP", "Calculated ROP") & vbNewLine
        report += String.Format(zone, "========", "============", "=============") & vbNewLine
        For Each myRow In ProductListDataSet.tblProducts.Rows
            If calculation < line Then
                reorder = myRow.item("AverageDemandLT") * leadComboBox.Text + z * myRow.item("StandardDevLT") * (Math.Sqrt(leadComboBox.Text))
                report += String.Format(zone, myRow.item("ProductName"), myRow.item("ReorderLevel"), reorder.ToString("n0")) & vbNewLine
                calculation += 1
            End If
        Next
        Reorder_Point_Report.ShowDialog()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        'Assign values to the next Button and text boxes
        line = ProductListDataSet.tblProducts.Count
        If calculation < line Then
            productTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("ProductName")
            unitTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("UnitsInStock")
            unitorderTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("UnitsOnOrder")
            reorderTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("ReorderLevel")
            averageTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("AverageDemandLT")
            stdTextBox.Text = ProductListDataSet.tblProducts.Rows(calculation).Item("StandardDevLT")
            calculation += 1
        Else
            calculation = 0
        End If
    End Sub
End Class
