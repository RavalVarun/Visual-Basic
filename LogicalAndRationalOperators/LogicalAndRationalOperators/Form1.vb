Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGrade.Click

        Dim iScore As Integer

        If IsNumeric(txtExamScore.Text) = True Then
            iScore = CInt(txtExamScore.Text)
        Else
            MsgBox("You must enter a valid number")
            Exit Sub
        End If

        If Not (iScore >= 0 And iScore <= 100) Then
            MsgBox("That is not a valid socore, please enter a number between 0 and 100")

        ElseIf iScore <= 20 Then
            MsgBox("Grade F")
        ElseIf iScore > 20 And iScore <= 30 Then
            MsgBox("Grade E")
        ElseIf iScore > 30 And iScore <= 40 Then
            MsgBox("Grade D")
        ElseIf iScore > 40 And iScore <= 50 Then
            MsgBox("Grade C")
        ElseIf iScore > 50 And iScore <= 70 Then
            MsgBox("Grade B")
        Else
            MsgBox("Grade A")

        End If
        MsgBox("all done")

    End Sub
End Class
