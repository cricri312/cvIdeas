Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.URL = ("C:\Users\viola\Desktop\hal.mp3")
        Label2.Image = My.Resources.imgres
        Button2.Enabled = False

    End Sub
    Private Sub start()
        Dim start = Panel1.Location
        start.Offset(10, 10)
        Cursor.Position = PointToScreen(start)




    End Sub

    Private Sub Label6_MouseMove_1(sender As Object, e As MouseEventArgs)
        start()
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
       
    End Sub

    Private Sub Label55_MouseMove(sender As Object, e As MouseEventArgs) Handles Label9.MouseMove, Label8.MouseMove, Label7.MouseMove, Label61.MouseMove, Label60.MouseMove, Label6.MouseMove, Label59.MouseMove, Label58.MouseMove, Label57.MouseMove, Label56.MouseMove, Label55.MouseMove, Label54.MouseMove, Label53.MouseMove, Label52.MouseMove, Label51.MouseMove, Label50.MouseMove, Label5.MouseMove, Label49.MouseMove, Label48.MouseMove, Label47.MouseMove, Label46.MouseMove, Label45.MouseMove, Label44.MouseMove, Label43.MouseMove, Label42.MouseMove, Label41.MouseMove, Label40.MouseMove, Label4.MouseMove, Label39.MouseMove, Label38.MouseMove, Label37.MouseMove, Label36.MouseMove, Label35.MouseMove, Label34.MouseMove, Label33.MouseMove, Label32.MouseMove, Label31.MouseMove, Label30.MouseMove, Label3.MouseMove, Label29.MouseMove, Label28.MouseMove, Label27.MouseMove, Label26.MouseMove, Label25.MouseMove, Label24.MouseMove, Label23.MouseMove, Label22.MouseMove, Label21.MouseMove, Label20.MouseMove, Label2.MouseMove, Label19.MouseMove, Label18.MouseMove, Label17.MouseMove, Label16.MouseMove, Label15.MouseMove, Label14.MouseMove, Label13.MouseMove, Label12.MouseMove, Label11.MouseMove, Label10.MouseMove, Label1.MouseMove
        start()


    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("DOBREJ ZABAWY")
        Button1.Enabled = False
        Button2.Enabled = False
        start()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Label1.Text = "AVVIA" Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            Label1.Text = "STOP"
        ElseIf Label1.Text = "STOP" Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub

    Private Sub Label62_MouseMove(sender As Object, e As MouseEventArgs) Handles Label62.MouseMove
        Button2.Enabled = True
    End Sub

    Private Sub Label63_Click(sender As Object, e As EventArgs) Handles Label63.Click
        Button2.Enabled = True
    End Sub

    Private Sub Label64_MouseMove(sender As Object, e As MouseEventArgs) Handles Label64.MouseMove
        start()
    End Sub

    Private Sub Label65_MouseMove(sender As Object, e As MouseEventArgs) Handles Label65.MouseMove
        start()
    End Sub

    Private Sub INFORMACJToolStripMenuItem_MouseUp(sender As Object, e As MouseEventArgs) Handles INFORMACJToolStripMenuItem.MouseUp

    End Sub

    Private Sub INFORMACJToolStripMenuItem_MouseMove(sender As Object, e As MouseEventArgs) Handles INFORMACJToolStripMenuItem.MouseMove

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim x As Integer = 0
        If Label66.Text = "go" Then
            x = x + 1
            TextBox1.Text = x
            Label66.Text = "stop"

        ElseIf Label66.Text = "stop" Then
            x = x + 1
            TextBox1.Text = x
            Label66.Text = "go"

        End If

    End Sub
End Class
