Public Class Form1
    Private Sub btnTemprature_Click(sender As Object, e As EventArgs) Handles btnTemprature.Click
        Dim iTemprature As Integer
        iTemprature = CInt(txtTemprature.Text)

        Select Case iTemprature
            Case Is = 0
                MsgBox("Feezing")
                MsgBox("water will freeze")
            Case Is < 0
                MsgBox("sub zero")
            Case 1 To 10
                MsgBox("Cold")
            Case 11 To 20
                MsgBox("Warm")
            Case Else
                MsgBox("hot")
        End Select
    End Sub
End Class
