Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExercise1.Click
        Dim aiData(4) As Integer

        aiData(0) = 9
        aiData(1) = 14
        aiData(2) = 17
        aiData(3) = 15
        aiData(4) = 85

        Dim i As Integer
        For i = 0 To 4
            MsgBox(aiData(i))
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExercise2.Click
        'Output Each Item in a separate message one after another

        Dim aiData(4) As Integer

        aiData(0) = 9
        aiData(1) = 14
        aiData(2) = 17
        aiData(3) = 15
        aiData(4) = 85

        Dim i As Integer
        Dim stOut As String

        For i - 0 To 4
            stOut = stOut & aiData(i) & vbNewLine
        Next

        MsgBox(stOut)
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExercise3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnExercise4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnExercise5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnExercise6.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnExercise7.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnExercise8.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
