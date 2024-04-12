Public Class Form1
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click

        Dim iMax As Integer
        Dim stOddOrEven As String
        Dim x As Integer

        iMax = InputBox("what number do you want to count up to?")
        stOddOrEven = InputBox("do you want odd numbers or even numbers?")

        If stOddOrEven = "even" Then
            For x = 2 To iMax Step 2
                MsgBox(x)
            Next
        ElseIf stOddOrEven = "odd" Then
            For x = 1 To iMax Step 2
                MsgBox(x)
            Next

        End If
    End Sub
End Class
