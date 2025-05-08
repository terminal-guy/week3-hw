Imports System.Security.Cryptography

Public Class Form1


    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
'1. Declare Variables and Constants
'Note: Variable names use 'Camel Casing'
Dim productName As String
Dim price As Double
Dim quantity As Integer
Dim subTotal, tax, total As Double
Const taxRate As Double = 0.1 ' 10% Consumption Tax

'2. Perform Data Input
'Note the implicit String conversions
productName = txtName.Text
price = txtPrice.Text
quantity = txtQuantity.Text
        ' 3. Perform Calculations subTotal - quantity * price
        subTotal = quantity * price
        tax = subTotal * taxRate
        total = subTotal + tax
        ' 4. Formatted Output
        ' For efficiency, we define a single format string for all outputs
        Dim myFormat As String = "$#,##0.00"
        ' This format string specifies:
        '(1) A leading dollar sign,
        '(2) Commas every 3rd digit,
        '(3) At least one leading digit, And
        '(4) Two trazling digits after the decimal place.
        'Now, we apply it to all 3 outputs
        lblsubttl.Text = Format(subTotal, myFormat)
        lbltax.Text = Format(tax, myFormat)
        lblttl.Text = Format(total, myFormat)
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End

    End Sub
End Class
