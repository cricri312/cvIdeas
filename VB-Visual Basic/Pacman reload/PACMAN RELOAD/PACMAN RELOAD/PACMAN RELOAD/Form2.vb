Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("C:\PACMAN RELOAD\file.bat", "/k dir")
        Me.Close()
        Form1.Close()
    End Sub
End Class