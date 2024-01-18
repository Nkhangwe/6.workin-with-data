Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim YourMessage As String

        Dim Birthyear As Integer
        YourMessage = "Happy bday! How old are you now"
        MsgBox(YourMessage)
        Birthyear = Val(InputBox("enter Year of Birth"))
        MsgBox("you are  now" & 2024 - Birthyear & "years old")
    End Sub
End Class
