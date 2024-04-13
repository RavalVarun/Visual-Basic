Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim astFruits(4) As String

        astFruits(0) = "Banana"
        astFruits(1) = "Apple"
        astFruits(2) = "Mango"
        astFruits(3) = "Strawberry"
        astFruits(4) = "Grapes"

        Dim i As Integer

        For i = 0 To 4
            MsgBox(astFruits(i))
        Next

    End Sub
End Class
