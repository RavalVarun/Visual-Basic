﻿Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim iCount As Integer

        Do While iCount < 5
            iCount = iCount + 1
            MsgBox("Hey" & iCount)
        Loop

        iCount = 0

        Do
            iCount = iCount + 1
            MsgBox("Hello" & iCount)
        Loop While iCount < 5

        iCount = 0
        Do Until iCount = 5
            iCount = iCount + 1
            MsgBox("hello" & iCount)
        Loop

        iCount = 0
        Do
            iCount = iCount + 1
            MsgBox("Hello" & iCount)
        Loop Until iCount = 5

        MsgBox("Program has ended")

    End Sub
End Class
