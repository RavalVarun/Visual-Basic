Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim stAge As String
        Dim iAge As Integer

        Do While IsNumeric(stAge) = False
            stAge = InputBox("please enter your age in years")
        Loop

        iAge = CInt(stAge)

        MsgBox("You are " & iAge & " years old")

    End Sub
End Class
