Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

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

        'Remove comment to enable the perticular loop. Keeping in comment to have user not to click through every output

        '** dispaly Individual's all data **

        'Dim x As Integer

        'For x = 0 To 4
        'MsgBox(astPeople(x, 4))
        'Next

        '** display Last Names**

        'Dim y As Integer

        'For y = 0 To 4
        'MsgBox(astPeople(1, y))
        'Next

        '** dispaly Individual's Nationality **

        'Dim n As Integer

        'For n = 0 To 4
        'MsgBox(astPeople(3, n))
        'Next
    End Sub
End Class
