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
        'Add up all items and display the output

        Dim aiData(4) As Integer

        aiData(0) = 9
        aiData(1) = 14
        aiData(2) = 17
        aiData(3) = 15
        aiData(4) = 85

        Dim i As Integer
        Dim iTotal As Integer

        For i = 0to4
                iTotal = iTotal + aiData(i)
        Next

        MsgBox("Total is " & iTotal)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnExercise4.Click
        'Calculate the avg of the items

        Dim aiData(4) As Integer

        aiData(0) = 9
        aiData(1) = 14
        aiData(2) = 17
        aiData(3) = 15
        aiData(4) = 85

        Dim i As Integer
        Dim iTotal As Integer

        For i = 0 To 4
            iTotal = aiData(i)
        Next

        MsgBox("The average number is " & iTotal / 5)



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnExercise5.Click
        'Add items which are greater than 20 and display the total

        Dim aiData(4) As Integer

        aiData(0) = 9
        aiData(1) = 14
        aiData(2) = 17
        aiData(3) = 15
        aiData(4) = 85

        Dim i As Integer
        Dim iTotal As Integer

        For i = 0to4
                If aiData(i) > 20 Then
                iTotal = iTotal + aiData(i)
            End If
        Next

        MsgBox("Items bigger than 20's total is " & iTotal)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnExercise6.Click
        'Find the largest item

        Dim aiData(4) As Integer

        aiData(0) = 9
        aiData(1) = 14
        aiData(2) = 17
        aiData(3) = 15
        aiData(4) = 85

        Dim i As Integer
        Dim iMax As Integer


        For i = 0 To 4
            If aiData(i) > iMax Then
                iMax = aiData(i)
            End If
        Next

        MsgBox("The largest number is " & iMax)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnExercise7.Click
        'Find the smallest item

        Dim aiData(4) As Integer

        aiData(0) = 9
        aiData(1) = 14
        aiData(2) = 17
        aiData(3) = 15
        aiData(4) = 85

        Dim i As Integer
        Dim iMin As Integer

        iMin = 25000

        For i = 0 To 4
            If aiData(i) < iMin Then
                iMin = aiData(i)
            End If
        Next

        MsgBox("The smallest number is " & iMin)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnExercise8.Click
        'Replace each item in an array with a new value that twice as big then output the new values

        Dim aiData(4) As Integer

        aiData(0) = 9
        aiData(1) = 14
        aiData(2) = 17
        aiData(3) = 15
        aiData(4) = 85

        Dim i As Integer

        For i = 0 To 4
            aiData(i) = aiData(i) * 2
        Next

        Dim stOut As String

        For i = 0 To 4
            stOut = stOut & aiData(i) & vbNewLine

        Next

        MsgBox(stOut)


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
