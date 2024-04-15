Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barrack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Femal"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Methematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Eitnstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Sceintist"

        astPeople(0, 4) = "Nikola"
        astPeople(1, 4) = "Tesla"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Croatian"
        astPeople(4, 4) = "Inventor"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "van Gough"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"

        'display items in a row

        For y = 0 To 5
            For x = 0 To 4
                MsgBox(astPeople(x, y))
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barrack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Femal"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Methematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Eitnstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Sceintist"

        astPeople(0, 4) = "Nikola"
        astPeople(1, 4) = "Tesla"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Croatian"
        astPeople(4, 4) = "Inventor"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "van Gough"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"

        Dim x As Integer
        Dim y As Integer

        For x = 0 To 4
            For y = 0 To 5
                MsgBox(astPeople(x, y))
            Next
        Next


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barrack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Femal"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Methematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Eitnstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Sceintist"

        astPeople(0, 4) = "Nikola"
        astPeople(1, 4) = "Tesla"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Croatian"
        astPeople(4, 4) = "Inventor"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "van Gough"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"

        Dim x As Integer
        Dim y As Integer
        Dim stOut As String

        For y = 0 To 5
            For x = 0 To 4
                stOut = stOut & astPeople(x, y) & " "

            Next
            stOut = stOut & vbNewLine

        Next
        MsgBox(stOut)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barrack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Femal"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Methematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Eitnstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Sceintist"

        astPeople(0, 4) = "Nikola"
        astPeople(1, 4) = "Tesla"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Croatian"
        astPeople(4, 4) = "Inventor"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "van Gough"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"

        Dim x As Integer
        Dim y As Integer
        Dim bFound As Boolean
        Dim stTarget As String
        Dim stout As String

        bFound = False

        stTarget = InputBox("Search by last name")

        For y = 0 To 5
            If astPeople(1, y) = stTarget Then
                bFound = True
                Exit For
            End If
        Next

        If bFound = True Then
            For x = 0 To 4
                stout = stout & astPeople(x, y) & " "
            Next
        Else
            stout = "not found"
        End If

        MsgBox(stout)
    End Sub
End Class
