Public Class CalculationForm
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblNumber1 As Double
        Dim dblnumber2 As Double

        Dim dblResult As Double

        dblNumber1 = txtNumber1.Text
        dblnumber2 = txtNumber2.Text

        dblResult = dblNumber1 + dblnumber2
        MsgBox(dblResult)

        dblResult = dblNumber1 - dblnumber2
        MsgBox(dblResult)

        dblResult = dblNumber1 * dblnumber2
        MsgBox(dblResult)

        dblResult = dblNumber1 / dblnumber2
        MsgBox(dblResult)

        dblResult = dblNumber1 ^ dblnumber2
        MsgBox(dblResult)

        dblResult = dblNumber1 \ dblnumber2
        MsgBox(dblResult)

        dblResult = dblNumber1 Mod dblnumber2
        MsgBox(dblResult)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnComplexCalculation.Click
        Dim decPrice As Decimal
        Dim iQuantity As Integer
        Dim decDiscount As Decimal
        Dim decTotalCost As Decimal
        Dim decPostage As Decimal


        decPrice = 5
        iQuantity = 10
        decDiscount = 2
        decPostage = 3



        decTotalCost = ((decPrice - decDiscount) * iQuantity) + decPostage


        MsgBox(decTotalCost)


    End Sub
End Class