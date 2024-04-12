Public Class Form1
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click

        Dim stCountry As String
        stCountry = txtCountry.Text

        'We could either change the at the input level or change while in iteration
        'stCountry = stCountry.ToUpper

        If stCountry.ToUpper = "Auastralia" Then
            MsgBox("G'day mate!")
            MsgBox("no worries")

        ElseIf stCountry.ToUpper = "France" Then
            MsgBox("Bonjour")
            MsgBox("Comment allez-vous?")

        ElseIf stCountry.ToUpper = "Japan" Then
            MsgBox("Konnichiwa")
            MsgBox("Choushi wa dou desu ka")
        Else
            MsgBox("I hope you are well.")
        End If

    End Sub
End Class
