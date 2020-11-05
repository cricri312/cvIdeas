
Public Class Form1
    Dim x As Integer
    Dim a(100) As String
    Dim punkty As Integer = 0
    Dim l As Integer
    Dim s As Integer
    Dim y As Integer = 1000
    Dim vit As Integer = 3
    Dim score As Integer = 0
    Dim velocity As Integer = 3
    Private Property Image As Bitmap

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer5.Enabled = False
        Label101.Text = l

        ''ProgressBar1.Hide()

    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        If Label101.Text = 100 Then
            Timer5.Enabled = True
            Label101.Hide()

        End If
    End Sub

    Private Sub Button1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button1.KeyPress
        If e.KeyChar = "w" Then
            l = l + 1
            Label101.Text = l
            punk()
            Button1.Top = Button1.Top - velocity
            If eat() = True Then
                Select Case a(100)
                    Case a(0)
                        If Label42.Left < (Button1.Left + Button1.Size.Width) And (Label42.Left + Label42.Width) > Button1.Left And Label42.Top < (Button1.Top + Button1.Size.Height) And (Label42.Size.Height + Label42.Top) > Button1.Top Then
                            Label42.Hide()
                        End If
                        If Label41.Left < (Button1.Left + Button1.Size.Width) And (Label41.Left + Label41.Width) > Button1.Left And Label41.Top < (Button1.Top + Button1.Size.Height) And (Label41.Size.Height + Label41.Top) > Button1.Top Then
                            Label41.Hide()
                        End If
                        If Label43.Left < (Button1.Left + Button1.Size.Width) And (Label43.Left + Label43.Width) > Button1.Left And Label43.Top < (Button1.Top + Button1.Size.Height) And (Label43.Size.Height + Label43.Top) > Button1.Top Then
                            Label43.Hide()
                        End If
                        If Label44.Left < (Button1.Left + Button1.Size.Width) And (Label44.Left + Label44.Width) > Button1.Left And Label44.Top < (Button1.Top + Button1.Size.Height) And (Label44.Size.Height + Label44.Top) > Button1.Top Then
                            Label44.Hide()
                        End If
                        If Label45.Left < (Button1.Left + Button1.Size.Width) And (Label45.Left + Label45.Width) > Button1.Left And Label45.Top < (Button1.Top + Button1.Size.Height) And (Label45.Size.Height + Label45.Top) > Button1.Top Then
                            Label45.Hide()
                        End If
                        If Label46.Left < (Button1.Left + Button1.Size.Width) And (Label46.Left + Label46.Width) > Button1.Left And Label46.Top < (Button1.Top + Button1.Size.Height) And (Label46.Size.Height + Label46.Top) > Button1.Top Then
                            Label46.Hide()
                        End If
                        If Label47.Left < (Button1.Left + Button1.Size.Width) And (Label47.Left + Label47.Width) > Button1.Left And Label47.Top < (Button1.Top + Button1.Size.Height) And (Label47.Size.Height + Label47.Top) > Button1.Top Then
                            Label47.Hide()
                        End If
                        If Label48.Left < (Button1.Left + Button1.Size.Width) And (Label48.Left + Label48.Width) > Button1.Left And Label48.Top < (Button1.Top + Button1.Size.Height) And (Label48.Size.Height + Label48.Top) > Button1.Top Then
                            Label48.Hide()
                        End If
                        If Label49.Left < (Button1.Left + Button1.Size.Width) And (Label49.Left + Label49.Width) > Button1.Left And Label49.Top < (Button1.Top + Button1.Size.Height) And (Label49.Size.Height + Label49.Top) > Button1.Top Then
                            Label49.Hide()
                        End If
                        If Label50.Left < (Button1.Left + Button1.Size.Width) And (Label50.Left + Label50.Width) > Button1.Left And Label50.Top < (Button1.Top + Button1.Size.Height) And (Label50.Size.Height + Label50.Top) > Button1.Top Then
                            Label50.Hide()
                        End If
                        If Label51.Left < (Button1.Left + Button1.Size.Width) And (Label51.Left + Label51.Width) > Button1.Left And Label51.Top < (Button1.Top + Button1.Size.Height) And (Label51.Size.Height + Label51.Top) > Button1.Top Then
                            Label51.Hide()
                        End If
                        If Label52.Left < (Button1.Left + Button1.Size.Width) And (Label52.Left + Label52.Width) > Button1.Left And Label52.Top < (Button1.Top + Button1.Size.Height) And (Label52.Size.Height + Label52.Top) > Button1.Top Then
                            Label52.Hide()
                        End If
                        If Label53.Left < (Button1.Left + Button1.Size.Width) And (Label53.Left + Label53.Width) > Button1.Left And Label53.Top < (Button1.Top + Button1.Size.Height) And (Label53.Size.Height + Label53.Top) > Button1.Top Then
                            Label53.Hide()
                        End If
                        If Label54.Left < (Button1.Left + Button1.Size.Width) And (Label54.Left + Label54.Width) > Button1.Left And Label54.Top < (Button1.Top + Button1.Size.Height) And (Label54.Size.Height + Label54.Top) > Button1.Top Then
                            Label54.Hide()
                        End If
                        If Label55.Left < (Button1.Left + Button1.Size.Width) And (Label55.Left + Label55.Width) > Button1.Left And Label55.Top < (Button1.Top + Button1.Size.Height) And (Label55.Size.Height + Label55.Top) > Button1.Top Then
                            Label55.Hide()
                        End If
                        If Label56.Left < (Button1.Left + Button1.Size.Width) And (Label56.Left + Label56.Width) > Button1.Left And Label56.Top < (Button1.Top + Button1.Size.Height) And (Label56.Size.Height + Label56.Top) > Button1.Top Then
                            Label56.Hide()
                        End If
                        If Label57.Left < (Button1.Left + Button1.Size.Width) And (Label57.Left + Label57.Width) > Button1.Left And Label57.Top < (Button1.Top + Button1.Size.Height) And (Label57.Size.Height + Label57.Top) > Button1.Top Then
                            Label57.Hide()
                        End If
                        If Label58.Left < (Button1.Left + Button1.Size.Width) And (Label58.Left + Label58.Width) > Button1.Left And Label58.Top < (Button1.Top + Button1.Size.Height) And (Label58.Size.Height + Label58.Top) > Button1.Top Then
                            Label58.Hide()
                        End If
                        If Label59.Left < (Button1.Left + Button1.Size.Width) And (Label59.Left + Label59.Width) > Button1.Left And Label59.Top < (Button1.Top + Button1.Size.Height) And (Label59.Size.Height + Label59.Top) > Button1.Top Then
                            Label59.Hide()
                        End If
                        If Label60.Left < (Button1.Left + Button1.Size.Width) And (Label60.Left + Label60.Width) > Button1.Left And Label60.Top < (Button1.Top + Button1.Size.Height) And (Label60.Size.Height + Label60.Top) > Button1.Top Then
                            Label60.Hide()
                        End If
                        If Label61.Left < (Button1.Left + Button1.Size.Width) And (Label61.Left + Label61.Width) > Button1.Left And Label61.Top < (Button1.Top + Button1.Size.Height) And (Label61.Size.Height + Label61.Top) > Button1.Top Then
                            Label61.Hide()
                        End If
                        If Label62.Left < (Button1.Left + Button1.Size.Width) And (Label62.Left + Label62.Width) > Button1.Left And Label62.Top < (Button1.Top + Button1.Size.Height) And (Label62.Size.Height + Label62.Top) > Button1.Top Then
                            Label62.Hide()
                        End If
                        If Label63.Left < (Button1.Left + Button1.Size.Width) And (Label63.Left + Label63.Width) > Button1.Left And Label63.Top < (Button1.Top + Button1.Size.Height) And (Label63.Size.Height + Label63.Top) > Button1.Top Then
                            Label63.Hide()
                        End If
                        If Label64.Left < (Button1.Left + Button1.Size.Width) And (Label64.Left + Label64.Width) > Button1.Left And Label64.Top < (Button1.Top + Button1.Size.Height) And (Label64.Size.Height + Label64.Top) > Button1.Top Then
                            Label64.Hide()
                        End If
                        If Label65.Left < (Button1.Left + Button1.Size.Width) And (Label65.Left + Label65.Width) > Button1.Left And Label65.Top < (Button1.Top + Button1.Size.Height) And (Label65.Size.Height + Label65.Top) > Button1.Top Then
                            Label65.Hide()
                        End If
                        If Label66.Left < (Button1.Left + Button1.Size.Width) And (Label66.Left + Label66.Width) > Button1.Left And Label66.Top < (Button1.Top + Button1.Size.Height) And (Label66.Size.Height + Label66.Top) > Button1.Top Then
                            Label66.Hide()
                        End If
                        If Label67.Left < (Button1.Left + Button1.Size.Width) And (Label67.Left + Label67.Width) > Button1.Left And Label67.Top < (Button1.Top + Button1.Size.Height) And (Label67.Size.Height + Label67.Top) > Button1.Top Then
                            Label67.Hide()
                        End If
                        If Label68.Left < (Button1.Left + Button1.Size.Width) And (Label68.Left + Label68.Width) > Button1.Left And Label68.Top < (Button1.Top + Button1.Size.Height) And (Label68.Size.Height + Label68.Top) > Button1.Top Then
                            Label68.Hide()
                        End If
                        If Label69.Left < (Button1.Left + Button1.Size.Width) And (Label69.Left + Label69.Width) > Button1.Left And Label69.Top < (Button1.Top + Button1.Size.Height) And (Label69.Size.Height + Label69.Top) > Button1.Top Then
                            Label69.Hide()
                        End If
                        If Label70.Left < (Button1.Left + Button1.Size.Width) And (Label70.Left + Label70.Width) > Button1.Left And Label70.Top < (Button1.Top + Button1.Size.Height) And (Label70.Size.Height + Label70.Top) > Button1.Top Then
                            Label70.Hide()
                        End If
                        If Label71.Left < (Button1.Left + Button1.Size.Width) And (Label71.Left + Label71.Width) > Button1.Left And Label71.Top < (Button1.Top + Button1.Size.Height) And (Label71.Size.Height + Label71.Top) > Button1.Top Then
                            Label71.Hide()
                        End If
                        If Label72.Left < (Button1.Left + Button1.Size.Width) And (Label72.Left + Label72.Width) > Button1.Left And Label72.Top < (Button1.Top + Button1.Size.Height) And (Label72.Size.Height + Label72.Top) > Button1.Top Then
                            Label72.Hide()
                        End If
                        If Label73.Left < (Button1.Left + Button1.Size.Width) And (Label73.Left + Label73.Width) > Button1.Left And Label73.Top < (Button1.Top + Button1.Size.Height) And (Label73.Size.Height + Label73.Top) > Button1.Top Then
                            Label73.Hide()
                        End If
                        If Label74.Left < (Button1.Left + Button1.Size.Width) And (Label74.Left + Label74.Width) > Button1.Left And Label74.Top < (Button1.Top + Button1.Size.Height) And (Label74.Size.Height + Label74.Top) > Button1.Top Then
                            Label74.Hide()
                        End If
                        If Label75.Left < (Button1.Left + Button1.Size.Width) And (Label75.Left + Label75.Width) > Button1.Left And Label75.Top < (Button1.Top + Button1.Size.Height) And (Label75.Size.Height + Label75.Top) > Button1.Top Then
                            Label75.Hide()
                        End If
                        If Label76.Left < (Button1.Left + Button1.Size.Width) And (Label76.Left + Label76.Width) > Button1.Left And Label76.Top < (Button1.Top + Button1.Size.Height) And (Label76.Size.Height + Label76.Top) > Button1.Top Then
                            Label76.Hide()
                           
                        End If
                        If Label77.Left < (Button1.Left + Button1.Size.Width) And (Label77.Left + Label77.Width) > Button1.Left And Label77.Top < (Button1.Top + Button1.Size.Height) And (Label77.Size.Height + Label77.Top) > Button1.Top Then
                            Label77.Hide()
                        End If
                        If Label78.Left < (Button1.Left + Button1.Size.Width) And (Label78.Left + Label78.Width) > Button1.Left And Label78.Top < (Button1.Top + Button1.Size.Height) And (Label78.Size.Height + Label78.Top) > Button1.Top Then
                            Label78.Hide()
                        End If
                        If Label79.Left < (Button1.Left + Button1.Size.Width) And (Label79.Left + Label79.Width) > Button1.Left And Label79.Top < (Button1.Top + Button1.Size.Height) And (Label79.Size.Height + Label79.Top) > Button1.Top Then
                            Label79.Hide()
                        End If
                        If Label80.Left < (Button1.Left + Button1.Size.Width) And (Label80.Left + Label80.Width) > Button1.Left And Label80.Top < (Button1.Top + Button1.Size.Height) And (Label80.Size.Height + Label80.Top) > Button1.Top Then
                            Label80.Hide()
                        End If
                        If Label81.Left < (Button1.Left + Button1.Size.Width) And (Label81.Left + Label81.Width) > Button1.Left And Label81.Top < (Button1.Top + Button1.Size.Height) And (Label81.Size.Height + Label81.Top) > Button1.Top Then
                            Label81.Hide()
                        End If
                        If Label82.Left < (Button1.Left + Button1.Size.Width) And (Label82.Left + Label82.Width) > Button1.Left And Label82.Top < (Button1.Top + Button1.Size.Height) And (Label82.Size.Height + Label82.Top) > Button1.Top Then
                            Label82.Hide()
                        End If
                        If Label83.Left < (Button1.Left + Button1.Size.Width) And (Label83.Left + Label83.Width) > Button1.Left And Label83.Top < (Button1.Top + Button1.Size.Height) And (Label83.Size.Height + Label83.Top) > Button1.Top Then
                            Label83.Hide()
                        End If
                        If Label84.Left < (Button1.Left + Button1.Size.Width) And (Label84.Left + Label84.Width) > Button1.Left And Label84.Top < (Button1.Top + Button1.Size.Height) And (Label84.Size.Height + Label84.Top) > Button1.Top Then
                            Label84.Hide()
                        End If
                        If Label85.Left < (Button1.Left + Button1.Size.Width) And (Label85.Left + Label85.Width) > Button1.Left And Label85.Top < (Button1.Top + Button1.Size.Height) And (Label85.Size.Height + Label85.Top) > Button1.Top Then
                            Label85.Hide()
                        End If
                        If Label86.Left < (Button1.Left + Button1.Size.Width) And (Label86.Left + Label86.Width) > Button1.Left And Label86.Top < (Button1.Top + Button1.Size.Height) And (Label86.Size.Height + Label86.Top) > Button1.Top Then
                            Label86.Hide()
                        End If
                        If Label87.Left < (Button1.Left + Button1.Size.Width) And (Label87.Left + Label87.Width) > Button1.Left And Label87.Top < (Button1.Top + Button1.Size.Height) And (Label87.Size.Height + Label87.Top) > Button1.Top Then
                            Label87.Hide()
                            MsgBox("GRATULUJE WYGRALES Z " & score & "PUNKTAMI")
                            Form2.Show()
                        End If
                        If Label88.Left < (Button1.Left + Button1.Size.Width) And (Label88.Left + Label88.Width) > Button1.Left And Label88.Top < (Button1.Top + Button1.Size.Height) And (Label88.Size.Height + Label88.Top) > Button1.Top Then
                            Label88.Hide()
                        End If
                        If Label89.Left < (Button1.Left + Button1.Size.Width) And (Label89.Left + Label89.Width) > Button1.Left And Label89.Top < (Button1.Top + Button1.Size.Height) And (Label89.Size.Height + Label89.Top) > Button1.Top Then
                            Label89.Hide()
                        End If
                        If Label90.Left < (Button1.Left + Button1.Size.Width) And (Label90.Left + Label90.Width) > Button1.Left And Label90.Top < (Button1.Top + Button1.Size.Height) And (Label90.Size.Height + Label90.Top) > Button1.Top Then
                            Label90.Hide()
                        End If
                        If Label91.Left < (Button1.Left + Button1.Size.Width) And (Label91.Left + Label91.Width) > Button1.Left And Label91.Top < (Button1.Top + Button1.Size.Height) And (Label91.Size.Height + Label91.Top) > Button1.Top Then
                            Label91.Hide()
                        End If
                        If Label92.Left < (Button1.Left + Button1.Size.Width) And (Label92.Left + Label92.Width) > Button1.Left And Label92.Top < (Button1.Top + Button1.Size.Height) And (Label92.Size.Height + Label92.Top) > Button1.Top Then
                            Label92.Hide()
                        End If
                        If Label93.Left < (Button1.Left + Button1.Size.Width) And (Label93.Left + Label93.Width) > Button1.Left And Label93.Top < (Button1.Top + Button1.Size.Height) And (Label93.Size.Height + Label93.Top) > Button1.Top Then
                            Label93.Hide()
                        End If
                        If Label94.Left < (Button1.Left + Button1.Size.Width) And (Label94.Left + Label94.Width) > Button1.Left And Label94.Top < (Button1.Top + Button1.Size.Height) And (Label94.Size.Height + Label94.Top) > Button1.Top Then
                            Label94.Hide()
                        End If
                        If Label95.Left < (Button1.Left + Button1.Size.Width) And (Label95.Left + Label95.Width) > Button1.Left And Label95.Top < (Button1.Top + Button1.Size.Height) And (Label95.Size.Height + Label95.Top) > Button1.Top Then
                            Label95.Hide()
                        End If
                        If Label96.Left < (Button1.Left + Button1.Size.Width) And (Label96.Left + Label96.Width) > Button1.Left And Label96.Top < (Button1.Top + Button1.Size.Height) And (Label96.Size.Height + Label96.Top) > Button1.Top Then
                            Label96.Hide()
                        End If
                        If Label97.Left < (Button1.Left + Button1.Size.Width) And (Label97.Left + Label97.Width) > Button1.Left And Label97.Top < (Button1.Top + Button1.Size.Height) And (Label97.Size.Height + Label97.Top) > Button1.Top Then
                            Label97.Hide()
                        End If
                        If Label98.Left < (Button1.Left + Button1.Size.Width) And (Label98.Left + Label98.Width) > Button1.Left And Label98.Top < (Button1.Top + Button1.Size.Height) And (Label98.Size.Height + Label98.Top) > Button1.Top Then
                            Label98.Hide()
                        End If
                        If Label99.Left < (Button1.Left + Button1.Size.Width) And (Label99.Left + Label99.Width) > Button1.Left And Label99.Top < (Button1.Top + Button1.Size.Height) And (Label99.Size.Height + Label99.Top) > Button1.Top Then
                            Label99.Hide()
                        End If
                       
                End Select
           


            End If
            Label110.Text = score
            Timer1_Tick()
            teleport()
            If collision() = True Then
                Button1.Top = Button1.Top + velocity
            End If
        ElseIf e.KeyChar = "s" Then
            l = l + 1
            Label101.Text = l
            punk()
            Button1.Top = Button1.Top + velocity
            If eat() = True Then

                Select Case a(100)
                    Case a(0)
                        If Label42.Left < (Button1.Left + Button1.Size.Width) And (Label42.Left + Label42.Width) > Button1.Left And Label42.Top < (Button1.Top + Button1.Size.Height) And (Label42.Size.Height + Label42.Top) > Button1.Top Then
                            Label42.Hide()
                        End If
                        If Label41.Left < (Button1.Left + Button1.Size.Width) And (Label41.Left + Label41.Width) > Button1.Left And Label41.Top < (Button1.Top + Button1.Size.Height) And (Label41.Size.Height + Label41.Top) > Button1.Top Then
                            Label41.Hide()
                        End If
                        If Label43.Left < (Button1.Left + Button1.Size.Width) And (Label43.Left + Label43.Width) > Button1.Left And Label43.Top < (Button1.Top + Button1.Size.Height) And (Label43.Size.Height + Label43.Top) > Button1.Top Then
                            Label43.Hide()
                        End If
                        If Label44.Left < (Button1.Left + Button1.Size.Width) And (Label44.Left + Label44.Width) > Button1.Left And Label44.Top < (Button1.Top + Button1.Size.Height) And (Label44.Size.Height + Label44.Top) > Button1.Top Then
                            Label44.Hide()
                        End If
                        If Label45.Left < (Button1.Left + Button1.Size.Width) And (Label45.Left + Label45.Width) > Button1.Left And Label45.Top < (Button1.Top + Button1.Size.Height) And (Label45.Size.Height + Label45.Top) > Button1.Top Then
                            Label45.Hide()
                        End If
                        If Label46.Left < (Button1.Left + Button1.Size.Width) And (Label46.Left + Label46.Width) > Button1.Left And Label46.Top < (Button1.Top + Button1.Size.Height) And (Label46.Size.Height + Label46.Top) > Button1.Top Then
                            Label46.Hide()
                        End If
                        If Label47.Left < (Button1.Left + Button1.Size.Width) And (Label47.Left + Label47.Width) > Button1.Left And Label47.Top < (Button1.Top + Button1.Size.Height) And (Label47.Size.Height + Label47.Top) > Button1.Top Then
                            Label47.Hide()
                        End If
                        If Label48.Left < (Button1.Left + Button1.Size.Width) And (Label48.Left + Label48.Width) > Button1.Left And Label48.Top < (Button1.Top + Button1.Size.Height) And (Label48.Size.Height + Label48.Top) > Button1.Top Then
                            Label48.Hide()
                        End If
                        If Label49.Left < (Button1.Left + Button1.Size.Width) And (Label49.Left + Label49.Width) > Button1.Left And Label49.Top < (Button1.Top + Button1.Size.Height) And (Label49.Size.Height + Label49.Top) > Button1.Top Then
                            Label49.Hide()
                        End If
                        If Label50.Left < (Button1.Left + Button1.Size.Width) And (Label50.Left + Label50.Width) > Button1.Left And Label50.Top < (Button1.Top + Button1.Size.Height) And (Label50.Size.Height + Label50.Top) > Button1.Top Then
                            Label50.Hide()
                        End If
                        If Label51.Left < (Button1.Left + Button1.Size.Width) And (Label51.Left + Label51.Width) > Button1.Left And Label51.Top < (Button1.Top + Button1.Size.Height) And (Label51.Size.Height + Label51.Top) > Button1.Top Then
                            Label51.Hide()
                        End If
                        If Label52.Left < (Button1.Left + Button1.Size.Width) And (Label52.Left + Label52.Width) > Button1.Left And Label52.Top < (Button1.Top + Button1.Size.Height) And (Label52.Size.Height + Label52.Top) > Button1.Top Then
                            Label52.Hide()
                        End If
                        If Label53.Left < (Button1.Left + Button1.Size.Width) And (Label53.Left + Label53.Width) > Button1.Left And Label53.Top < (Button1.Top + Button1.Size.Height) And (Label53.Size.Height + Label53.Top) > Button1.Top Then
                            Label53.Hide()
                        End If
                        If Label54.Left < (Button1.Left + Button1.Size.Width) And (Label54.Left + Label54.Width) > Button1.Left And Label54.Top < (Button1.Top + Button1.Size.Height) And (Label54.Size.Height + Label54.Top) > Button1.Top Then
                            Label54.Hide()
                        End If
                        If Label55.Left < (Button1.Left + Button1.Size.Width) And (Label55.Left + Label55.Width) > Button1.Left And Label55.Top < (Button1.Top + Button1.Size.Height) And (Label55.Size.Height + Label55.Top) > Button1.Top Then
                            Label55.Hide()
                        End If
                        If Label56.Left < (Button1.Left + Button1.Size.Width) And (Label56.Left + Label56.Width) > Button1.Left And Label56.Top < (Button1.Top + Button1.Size.Height) And (Label56.Size.Height + Label56.Top) > Button1.Top Then
                            Label56.Hide()
                        End If
                        If Label57.Left < (Button1.Left + Button1.Size.Width) And (Label57.Left + Label57.Width) > Button1.Left And Label57.Top < (Button1.Top + Button1.Size.Height) And (Label57.Size.Height + Label57.Top) > Button1.Top Then
                            Label57.Hide()
                        End If
                        If Label58.Left < (Button1.Left + Button1.Size.Width) And (Label58.Left + Label58.Width) > Button1.Left And Label58.Top < (Button1.Top + Button1.Size.Height) And (Label58.Size.Height + Label58.Top) > Button1.Top Then
                            Label58.Hide()
                        End If
                        If Label59.Left < (Button1.Left + Button1.Size.Width) And (Label59.Left + Label59.Width) > Button1.Left And Label59.Top < (Button1.Top + Button1.Size.Height) And (Label59.Size.Height + Label59.Top) > Button1.Top Then
                            Label59.Hide()
                        End If
                        If Label60.Left < (Button1.Left + Button1.Size.Width) And (Label60.Left + Label60.Width) > Button1.Left And Label60.Top < (Button1.Top + Button1.Size.Height) And (Label60.Size.Height + Label60.Top) > Button1.Top Then
                            Label60.Hide()
                        End If
                        If Label61.Left < (Button1.Left + Button1.Size.Width) And (Label61.Left + Label61.Width) > Button1.Left And Label61.Top < (Button1.Top + Button1.Size.Height) And (Label61.Size.Height + Label61.Top) > Button1.Top Then
                            Label61.Hide()
                        End If
                        If Label62.Left < (Button1.Left + Button1.Size.Width) And (Label62.Left + Label62.Width) > Button1.Left And Label62.Top < (Button1.Top + Button1.Size.Height) And (Label62.Size.Height + Label62.Top) > Button1.Top Then
                            Label62.Hide()
                        End If
                        If Label63.Left < (Button1.Left + Button1.Size.Width) And (Label63.Left + Label63.Width) > Button1.Left And Label63.Top < (Button1.Top + Button1.Size.Height) And (Label63.Size.Height + Label63.Top) > Button1.Top Then
                            Label63.Hide()
                        End If
                        If Label64.Left < (Button1.Left + Button1.Size.Width) And (Label64.Left + Label64.Width) > Button1.Left And Label64.Top < (Button1.Top + Button1.Size.Height) And (Label64.Size.Height + Label64.Top) > Button1.Top Then
                            Label64.Hide()
                        End If
                        If Label65.Left < (Button1.Left + Button1.Size.Width) And (Label65.Left + Label65.Width) > Button1.Left And Label65.Top < (Button1.Top + Button1.Size.Height) And (Label65.Size.Height + Label65.Top) > Button1.Top Then
                            Label65.Hide()
                        End If
                        If Label66.Left < (Button1.Left + Button1.Size.Width) And (Label66.Left + Label66.Width) > Button1.Left And Label66.Top < (Button1.Top + Button1.Size.Height) And (Label66.Size.Height + Label66.Top) > Button1.Top Then
                            Label66.Hide()
                        End If
                        If Label67.Left < (Button1.Left + Button1.Size.Width) And (Label67.Left + Label67.Width) > Button1.Left And Label67.Top < (Button1.Top + Button1.Size.Height) And (Label67.Size.Height + Label67.Top) > Button1.Top Then
                            Label67.Hide()
                        End If
                        If Label68.Left < (Button1.Left + Button1.Size.Width) And (Label68.Left + Label68.Width) > Button1.Left And Label68.Top < (Button1.Top + Button1.Size.Height) And (Label68.Size.Height + Label68.Top) > Button1.Top Then
                            Label68.Hide()
                        End If
                        If Label69.Left < (Button1.Left + Button1.Size.Width) And (Label69.Left + Label69.Width) > Button1.Left And Label69.Top < (Button1.Top + Button1.Size.Height) And (Label69.Size.Height + Label69.Top) > Button1.Top Then
                            Label69.Hide()
                        End If
                        If Label70.Left < (Button1.Left + Button1.Size.Width) And (Label70.Left + Label70.Width) > Button1.Left And Label70.Top < (Button1.Top + Button1.Size.Height) And (Label70.Size.Height + Label70.Top) > Button1.Top Then
                            Label70.Hide()
                        End If
                        If Label71.Left < (Button1.Left + Button1.Size.Width) And (Label71.Left + Label71.Width) > Button1.Left And Label71.Top < (Button1.Top + Button1.Size.Height) And (Label71.Size.Height + Label71.Top) > Button1.Top Then
                            Label71.Hide()
                        End If
                        If Label72.Left < (Button1.Left + Button1.Size.Width) And (Label72.Left + Label72.Width) > Button1.Left And Label72.Top < (Button1.Top + Button1.Size.Height) And (Label72.Size.Height + Label72.Top) > Button1.Top Then
                            Label72.Hide()
                        End If
                        If Label73.Left < (Button1.Left + Button1.Size.Width) And (Label73.Left + Label73.Width) > Button1.Left And Label73.Top < (Button1.Top + Button1.Size.Height) And (Label73.Size.Height + Label73.Top) > Button1.Top Then
                            Label73.Hide()
                        End If
                        If Label74.Left < (Button1.Left + Button1.Size.Width) And (Label74.Left + Label74.Width) > Button1.Left And Label74.Top < (Button1.Top + Button1.Size.Height) And (Label74.Size.Height + Label74.Top) > Button1.Top Then
                            Label74.Hide()
                        End If
                        If Label75.Left < (Button1.Left + Button1.Size.Width) And (Label75.Left + Label75.Width) > Button1.Left And Label75.Top < (Button1.Top + Button1.Size.Height) And (Label75.Size.Height + Label75.Top) > Button1.Top Then
                            Label75.Hide()
                        End If
                        If Label76.Left < (Button1.Left + Button1.Size.Width) And (Label76.Left + Label76.Width) > Button1.Left And Label76.Top < (Button1.Top + Button1.Size.Height) And (Label76.Size.Height + Label76.Top) > Button1.Top Then
                            Label76.Hide()
                        End If
                        If Label77.Left < (Button1.Left + Button1.Size.Width) And (Label77.Left + Label77.Width) > Button1.Left And Label77.Top < (Button1.Top + Button1.Size.Height) And (Label77.Size.Height + Label77.Top) > Button1.Top Then
                            Label77.Hide()
                        End If
                        If Label78.Left < (Button1.Left + Button1.Size.Width) And (Label78.Left + Label78.Width) > Button1.Left And Label78.Top < (Button1.Top + Button1.Size.Height) And (Label78.Size.Height + Label78.Top) > Button1.Top Then
                            Label78.Hide()
                        End If
                        If Label79.Left < (Button1.Left + Button1.Size.Width) And (Label79.Left + Label79.Width) > Button1.Left And Label79.Top < (Button1.Top + Button1.Size.Height) And (Label79.Size.Height + Label79.Top) > Button1.Top Then
                            Label79.Hide()
                        End If
                        If Label80.Left < (Button1.Left + Button1.Size.Width) And (Label80.Left + Label80.Width) > Button1.Left And Label80.Top < (Button1.Top + Button1.Size.Height) And (Label80.Size.Height + Label80.Top) > Button1.Top Then
                            Label80.Hide()
                        End If
                        If Label81.Left < (Button1.Left + Button1.Size.Width) And (Label81.Left + Label81.Width) > Button1.Left And Label81.Top < (Button1.Top + Button1.Size.Height) And (Label81.Size.Height + Label81.Top) > Button1.Top Then
                            Label81.Hide()
                        End If
                        If Label82.Left < (Button1.Left + Button1.Size.Width) And (Label82.Left + Label82.Width) > Button1.Left And Label82.Top < (Button1.Top + Button1.Size.Height) And (Label82.Size.Height + Label82.Top) > Button1.Top Then
                            Label82.Hide()
                        End If
                        If Label83.Left < (Button1.Left + Button1.Size.Width) And (Label83.Left + Label83.Width) > Button1.Left And Label83.Top < (Button1.Top + Button1.Size.Height) And (Label83.Size.Height + Label83.Top) > Button1.Top Then
                            Label83.Hide()
                        End If
                        If Label84.Left < (Button1.Left + Button1.Size.Width) And (Label84.Left + Label84.Width) > Button1.Left And Label84.Top < (Button1.Top + Button1.Size.Height) And (Label84.Size.Height + Label84.Top) > Button1.Top Then
                            Label84.Hide()
                        End If
                        If Label85.Left < (Button1.Left + Button1.Size.Width) And (Label85.Left + Label85.Width) > Button1.Left And Label85.Top < (Button1.Top + Button1.Size.Height) And (Label85.Size.Height + Label85.Top) > Button1.Top Then
                            Label85.Hide()
                        End If
                        If Label86.Left < (Button1.Left + Button1.Size.Width) And (Label86.Left + Label86.Width) > Button1.Left And Label86.Top < (Button1.Top + Button1.Size.Height) And (Label86.Size.Height + Label86.Top) > Button1.Top Then
                            Label86.Hide()
                        End If
                        If Label87.Left < (Button1.Left + Button1.Size.Width) And (Label87.Left + Label87.Width) > Button1.Left And Label87.Top < (Button1.Top + Button1.Size.Height) And (Label87.Size.Height + Label87.Top) > Button1.Top Then
                            Label87.Hide()
                            MsgBox("GRATULUJE WYGRALES Z " & score & "PUNKTAMI")
                            Form2.Show()
                        End If
                        If Label88.Left < (Button1.Left + Button1.Size.Width) And (Label88.Left + Label88.Width) > Button1.Left And Label88.Top < (Button1.Top + Button1.Size.Height) And (Label88.Size.Height + Label88.Top) > Button1.Top Then
                            Label88.Hide()
                        End If
                        If Label89.Left < (Button1.Left + Button1.Size.Width) And (Label89.Left + Label89.Width) > Button1.Left And Label89.Top < (Button1.Top + Button1.Size.Height) And (Label89.Size.Height + Label89.Top) > Button1.Top Then
                            Label89.Hide()
                        End If
                        If Label90.Left < (Button1.Left + Button1.Size.Width) And (Label90.Left + Label90.Width) > Button1.Left And Label90.Top < (Button1.Top + Button1.Size.Height) And (Label90.Size.Height + Label90.Top) > Button1.Top Then
                            Label90.Hide()
                        End If
                        If Label91.Left < (Button1.Left + Button1.Size.Width) And (Label91.Left + Label91.Width) > Button1.Left And Label91.Top < (Button1.Top + Button1.Size.Height) And (Label91.Size.Height + Label91.Top) > Button1.Top Then
                            Label91.Hide()
                        End If
                        If Label92.Left < (Button1.Left + Button1.Size.Width) And (Label92.Left + Label92.Width) > Button1.Left And Label92.Top < (Button1.Top + Button1.Size.Height) And (Label92.Size.Height + Label92.Top) > Button1.Top Then
                            Label92.Hide()
                        End If
                        If Label93.Left < (Button1.Left + Button1.Size.Width) And (Label93.Left + Label93.Width) > Button1.Left And Label93.Top < (Button1.Top + Button1.Size.Height) And (Label93.Size.Height + Label93.Top) > Button1.Top Then
                            Label93.Hide()
                        End If
                        If Label94.Left < (Button1.Left + Button1.Size.Width) And (Label94.Left + Label94.Width) > Button1.Left And Label94.Top < (Button1.Top + Button1.Size.Height) And (Label94.Size.Height + Label94.Top) > Button1.Top Then
                            Label94.Hide()
                        End If
                        If Label95.Left < (Button1.Left + Button1.Size.Width) And (Label95.Left + Label95.Width) > Button1.Left And Label95.Top < (Button1.Top + Button1.Size.Height) And (Label95.Size.Height + Label95.Top) > Button1.Top Then
                            Label95.Hide()
                        End If
                        If Label96.Left < (Button1.Left + Button1.Size.Width) And (Label96.Left + Label96.Width) > Button1.Left And Label96.Top < (Button1.Top + Button1.Size.Height) And (Label96.Size.Height + Label96.Top) > Button1.Top Then
                            Label96.Hide()
                        End If
                        If Label97.Left < (Button1.Left + Button1.Size.Width) And (Label97.Left + Label97.Width) > Button1.Left And Label97.Top < (Button1.Top + Button1.Size.Height) And (Label97.Size.Height + Label97.Top) > Button1.Top Then
                            Label97.Hide()
                        End If
                        If Label98.Left < (Button1.Left + Button1.Size.Width) And (Label98.Left + Label98.Width) > Button1.Left And Label98.Top < (Button1.Top + Button1.Size.Height) And (Label98.Size.Height + Label98.Top) > Button1.Top Then
                            Label98.Hide()
                        End If
                        If Label99.Left < (Button1.Left + Button1.Size.Width) And (Label99.Left + Label99.Width) > Button1.Left And Label99.Top < (Button1.Top + Button1.Size.Height) And (Label99.Size.Height + Label99.Top) > Button1.Top Then
                            Label99.Hide()
                        End If
                End Select


            End If
            Timer2_tick()
            teleport()
            If collision() = True Then
                Button1.Top = Button1.Top - velocity
            End If
        ElseIf e.KeyChar = "d" Then
            l = l + 1
            Label101.Text = l
            punk()
            Button1.Left = Button1.Left + velocity
            If eat() = True Then

                Select Case a(100)
                    Case a(0)
                        If Label42.Left < (Button1.Left + Button1.Size.Width) And (Label42.Left + Label42.Width) > Button1.Left And Label42.Top < (Button1.Top + Button1.Size.Height) And (Label42.Size.Height + Label42.Top) > Button1.Top Then
                            Label42.Hide()
                        End If
                        If Label41.Left < (Button1.Left + Button1.Size.Width) And (Label41.Left + Label41.Width) > Button1.Left And Label41.Top < (Button1.Top + Button1.Size.Height) And (Label41.Size.Height + Label41.Top) > Button1.Top Then
                            Label41.Hide()
                        End If
                        If Label43.Left < (Button1.Left + Button1.Size.Width) And (Label43.Left + Label43.Width) > Button1.Left And Label43.Top < (Button1.Top + Button1.Size.Height) And (Label43.Size.Height + Label43.Top) > Button1.Top Then
                            Label43.Hide()

                        End If
                        If Label44.Left < (Button1.Left + Button1.Size.Width) And (Label44.Left + Label44.Width) > Button1.Left And Label44.Top < (Button1.Top + Button1.Size.Height) And (Label44.Size.Height + Label44.Top) > Button1.Top Then
                            Label44.Hide()
                        End If
                        If Label45.Left < (Button1.Left + Button1.Size.Width) And (Label45.Left + Label45.Width) > Button1.Left And Label45.Top < (Button1.Top + Button1.Size.Height) And (Label45.Size.Height + Label45.Top) > Button1.Top Then
                            Label45.Hide()
                        End If
                        If Label46.Left < (Button1.Left + Button1.Size.Width) And (Label46.Left + Label46.Width) > Button1.Left And Label46.Top < (Button1.Top + Button1.Size.Height) And (Label46.Size.Height + Label46.Top) > Button1.Top Then
                            Label46.Hide()
                        End If
                        If Label47.Left < (Button1.Left + Button1.Size.Width) And (Label47.Left + Label47.Width) > Button1.Left And Label47.Top < (Button1.Top + Button1.Size.Height) And (Label47.Size.Height + Label47.Top) > Button1.Top Then
                            Label47.Hide()
                        End If
                        If Label48.Left < (Button1.Left + Button1.Size.Width) And (Label48.Left + Label48.Width) > Button1.Left And Label48.Top < (Button1.Top + Button1.Size.Height) And (Label48.Size.Height + Label48.Top) > Button1.Top Then
                            Label48.Hide()
                        End If
                        If Label49.Left < (Button1.Left + Button1.Size.Width) And (Label49.Left + Label49.Width) > Button1.Left And Label49.Top < (Button1.Top + Button1.Size.Height) And (Label49.Size.Height + Label49.Top) > Button1.Top Then
                            Label49.Hide()
                        End If
                        If Label50.Left < (Button1.Left + Button1.Size.Width) And (Label50.Left + Label50.Width) > Button1.Left And Label50.Top < (Button1.Top + Button1.Size.Height) And (Label50.Size.Height + Label50.Top) > Button1.Top Then
                            Label50.Hide()
                        End If
                        If Label51.Left < (Button1.Left + Button1.Size.Width) And (Label51.Left + Label51.Width) > Button1.Left And Label51.Top < (Button1.Top + Button1.Size.Height) And (Label51.Size.Height + Label51.Top) > Button1.Top Then
                            Label51.Hide()
                        End If
                        If Label52.Left < (Button1.Left + Button1.Size.Width) And (Label52.Left + Label52.Width) > Button1.Left And Label52.Top < (Button1.Top + Button1.Size.Height) And (Label52.Size.Height + Label52.Top) > Button1.Top Then
                            Label52.Hide()
                        End If
                        If Label53.Left < (Button1.Left + Button1.Size.Width) And (Label53.Left + Label53.Width) > Button1.Left And Label53.Top < (Button1.Top + Button1.Size.Height) And (Label53.Size.Height + Label53.Top) > Button1.Top Then
                            Label53.Hide()
                        End If
                        If Label54.Left < (Button1.Left + Button1.Size.Width) And (Label54.Left + Label54.Width) > Button1.Left And Label54.Top < (Button1.Top + Button1.Size.Height) And (Label54.Size.Height + Label54.Top) > Button1.Top Then
                            Label54.Hide()
                        End If
                        If Label55.Left < (Button1.Left + Button1.Size.Width) And (Label55.Left + Label55.Width) > Button1.Left And Label55.Top < (Button1.Top + Button1.Size.Height) And (Label55.Size.Height + Label55.Top) > Button1.Top Then
                            Label55.Hide()
                        End If
                        If Label56.Left < (Button1.Left + Button1.Size.Width) And (Label56.Left + Label56.Width) > Button1.Left And Label56.Top < (Button1.Top + Button1.Size.Height) And (Label56.Size.Height + Label56.Top) > Button1.Top Then
                            Label56.Hide()
                        End If
                        If Label57.Left < (Button1.Left + Button1.Size.Width) And (Label57.Left + Label57.Width) > Button1.Left And Label57.Top < (Button1.Top + Button1.Size.Height) And (Label57.Size.Height + Label57.Top) > Button1.Top Then
                            Label57.Hide()
                        End If
                        If Label58.Left < (Button1.Left + Button1.Size.Width) And (Label58.Left + Label58.Width) > Button1.Left And Label58.Top < (Button1.Top + Button1.Size.Height) And (Label58.Size.Height + Label58.Top) > Button1.Top Then
                            Label58.Hide()
                        End If
                        If Label59.Left < (Button1.Left + Button1.Size.Width) And (Label59.Left + Label59.Width) > Button1.Left And Label59.Top < (Button1.Top + Button1.Size.Height) And (Label59.Size.Height + Label59.Top) > Button1.Top Then
                            Label59.Hide()
                        End If
                        If Label60.Left < (Button1.Left + Button1.Size.Width) And (Label60.Left + Label60.Width) > Button1.Left And Label60.Top < (Button1.Top + Button1.Size.Height) And (Label60.Size.Height + Label60.Top) > Button1.Top Then
                            Label60.Hide()
                        End If
                        If Label61.Left < (Button1.Left + Button1.Size.Width) And (Label61.Left + Label61.Width) > Button1.Left And Label61.Top < (Button1.Top + Button1.Size.Height) And (Label61.Size.Height + Label61.Top) > Button1.Top Then
                            Label61.Hide()
                        End If
                        If Label62.Left < (Button1.Left + Button1.Size.Width) And (Label62.Left + Label62.Width) > Button1.Left And Label62.Top < (Button1.Top + Button1.Size.Height) And (Label62.Size.Height + Label62.Top) > Button1.Top Then
                            Label62.Hide()
                        End If
                        If Label63.Left < (Button1.Left + Button1.Size.Width) And (Label63.Left + Label63.Width) > Button1.Left And Label63.Top < (Button1.Top + Button1.Size.Height) And (Label63.Size.Height + Label63.Top) > Button1.Top Then
                            Label63.Hide()
                        End If
                        If Label64.Left < (Button1.Left + Button1.Size.Width) And (Label64.Left + Label64.Width) > Button1.Left And Label64.Top < (Button1.Top + Button1.Size.Height) And (Label64.Size.Height + Label64.Top) > Button1.Top Then
                            Label64.Hide()
                        End If
                        If Label65.Left < (Button1.Left + Button1.Size.Width) And (Label65.Left + Label65.Width) > Button1.Left And Label65.Top < (Button1.Top + Button1.Size.Height) And (Label65.Size.Height + Label65.Top) > Button1.Top Then
                            Label65.Hide()
                        End If
                        If Label66.Left < (Button1.Left + Button1.Size.Width) And (Label66.Left + Label66.Width) > Button1.Left And Label66.Top < (Button1.Top + Button1.Size.Height) And (Label66.Size.Height + Label66.Top) > Button1.Top Then
                            Label66.Hide()
                        End If
                        If Label67.Left < (Button1.Left + Button1.Size.Width) And (Label67.Left + Label67.Width) > Button1.Left And Label67.Top < (Button1.Top + Button1.Size.Height) And (Label67.Size.Height + Label67.Top) > Button1.Top Then
                            Label67.Hide()
                        End If
                        If Label68.Left < (Button1.Left + Button1.Size.Width) And (Label68.Left + Label68.Width) > Button1.Left And Label68.Top < (Button1.Top + Button1.Size.Height) And (Label68.Size.Height + Label68.Top) > Button1.Top Then
                            Label68.Hide()
                        End If
                        If Label69.Left < (Button1.Left + Button1.Size.Width) And (Label69.Left + Label69.Width) > Button1.Left And Label69.Top < (Button1.Top + Button1.Size.Height) And (Label69.Size.Height + Label69.Top) > Button1.Top Then
                            Label69.Hide()
                        End If
                        If Label70.Left < (Button1.Left + Button1.Size.Width) And (Label70.Left + Label70.Width) > Button1.Left And Label70.Top < (Button1.Top + Button1.Size.Height) And (Label70.Size.Height + Label70.Top) > Button1.Top Then
                            Label70.Hide()
                        End If
                        If Label71.Left < (Button1.Left + Button1.Size.Width) And (Label71.Left + Label71.Width) > Button1.Left And Label71.Top < (Button1.Top + Button1.Size.Height) And (Label71.Size.Height + Label71.Top) > Button1.Top Then
                            Label71.Hide()
                        End If
                        If Label72.Left < (Button1.Left + Button1.Size.Width) And (Label72.Left + Label72.Width) > Button1.Left And Label72.Top < (Button1.Top + Button1.Size.Height) And (Label72.Size.Height + Label72.Top) > Button1.Top Then
                            Label72.Hide()
                        End If
                        If Label73.Left < (Button1.Left + Button1.Size.Width) And (Label73.Left + Label73.Width) > Button1.Left And Label73.Top < (Button1.Top + Button1.Size.Height) And (Label73.Size.Height + Label73.Top) > Button1.Top Then
                            Label73.Hide()
                        End If
                        If Label74.Left < (Button1.Left + Button1.Size.Width) And (Label74.Left + Label74.Width) > Button1.Left And Label74.Top < (Button1.Top + Button1.Size.Height) And (Label74.Size.Height + Label74.Top) > Button1.Top Then
                            Label74.Hide()
                        End If
                        If Label75.Left < (Button1.Left + Button1.Size.Width) And (Label75.Left + Label75.Width) > Button1.Left And Label75.Top < (Button1.Top + Button1.Size.Height) And (Label75.Size.Height + Label75.Top) > Button1.Top Then
                            Label75.Hide()
                        End If
                        If Label76.Left < (Button1.Left + Button1.Size.Width) And (Label76.Left + Label76.Width) > Button1.Left And Label76.Top < (Button1.Top + Button1.Size.Height) And (Label76.Size.Height + Label76.Top) > Button1.Top Then
                            Label76.Hide()
                        End If
                        If Label77.Left < (Button1.Left + Button1.Size.Width) And (Label77.Left + Label77.Width) > Button1.Left And Label77.Top < (Button1.Top + Button1.Size.Height) And (Label77.Size.Height + Label77.Top) > Button1.Top Then
                            Label77.Hide()
                        End If
                        If Label78.Left < (Button1.Left + Button1.Size.Width) And (Label78.Left + Label78.Width) > Button1.Left And Label78.Top < (Button1.Top + Button1.Size.Height) And (Label78.Size.Height + Label78.Top) > Button1.Top Then
                            Label78.Hide()
                        End If
                        If Label79.Left < (Button1.Left + Button1.Size.Width) And (Label79.Left + Label79.Width) > Button1.Left And Label79.Top < (Button1.Top + Button1.Size.Height) And (Label79.Size.Height + Label79.Top) > Button1.Top Then
                            Label79.Hide()
                        End If
                        If Label80.Left < (Button1.Left + Button1.Size.Width) And (Label80.Left + Label80.Width) > Button1.Left And Label80.Top < (Button1.Top + Button1.Size.Height) And (Label80.Size.Height + Label80.Top) > Button1.Top Then
                            Label80.Hide()
                        End If
                        If Label81.Left < (Button1.Left + Button1.Size.Width) And (Label81.Left + Label81.Width) > Button1.Left And Label81.Top < (Button1.Top + Button1.Size.Height) And (Label81.Size.Height + Label81.Top) > Button1.Top Then
                            Label81.Hide()
                        End If
                        If Label82.Left < (Button1.Left + Button1.Size.Width) And (Label82.Left + Label82.Width) > Button1.Left And Label82.Top < (Button1.Top + Button1.Size.Height) And (Label82.Size.Height + Label82.Top) > Button1.Top Then
                            Label82.Hide()
                        End If
                        If Label83.Left < (Button1.Left + Button1.Size.Width) And (Label83.Left + Label83.Width) > Button1.Left And Label83.Top < (Button1.Top + Button1.Size.Height) And (Label83.Size.Height + Label83.Top) > Button1.Top Then
                            Label83.Hide()
                        End If
                        If Label84.Left < (Button1.Left + Button1.Size.Width) And (Label84.Left + Label84.Width) > Button1.Left And Label84.Top < (Button1.Top + Button1.Size.Height) And (Label84.Size.Height + Label84.Top) > Button1.Top Then
                            Label84.Hide()
                        End If
                        If Label85.Left < (Button1.Left + Button1.Size.Width) And (Label85.Left + Label85.Width) > Button1.Left And Label85.Top < (Button1.Top + Button1.Size.Height) And (Label85.Size.Height + Label85.Top) > Button1.Top Then
                            Label85.Hide()
                        End If
                        If Label86.Left < (Button1.Left + Button1.Size.Width) And (Label86.Left + Label86.Width) > Button1.Left And Label86.Top < (Button1.Top + Button1.Size.Height) And (Label86.Size.Height + Label86.Top) > Button1.Top Then
                            Label86.Hide()
                        End If
                        If Label87.Left < (Button1.Left + Button1.Size.Width) And (Label87.Left + Label87.Width) > Button1.Left And Label87.Top < (Button1.Top + Button1.Size.Height) And (Label87.Size.Height + Label87.Top) > Button1.Top Then
                            Label87.Hide()
                            MsgBox("GRATULUJE WYGRALES Z " & score & "PUNKTAMI")
                            Form2.Show()
                        End If
                        If Label88.Left < (Button1.Left + Button1.Size.Width) And (Label88.Left + Label88.Width) > Button1.Left And Label88.Top < (Button1.Top + Button1.Size.Height) And (Label88.Size.Height + Label88.Top) > Button1.Top Then
                            Label88.Hide()
                        End If
                        If Label89.Left < (Button1.Left + Button1.Size.Width) And (Label89.Left + Label89.Width) > Button1.Left And Label89.Top < (Button1.Top + Button1.Size.Height) And (Label89.Size.Height + Label89.Top) > Button1.Top Then
                            Label89.Hide()
                        End If
                        If Label90.Left < (Button1.Left + Button1.Size.Width) And (Label90.Left + Label90.Width) > Button1.Left And Label90.Top < (Button1.Top + Button1.Size.Height) And (Label90.Size.Height + Label90.Top) > Button1.Top Then
                            Label90.Hide()
                        End If
                        If Label91.Left < (Button1.Left + Button1.Size.Width) And (Label91.Left + Label91.Width) > Button1.Left And Label91.Top < (Button1.Top + Button1.Size.Height) And (Label91.Size.Height + Label91.Top) > Button1.Top Then
                            Label91.Hide()
                        End If
                        If Label92.Left < (Button1.Left + Button1.Size.Width) And (Label92.Left + Label92.Width) > Button1.Left And Label92.Top < (Button1.Top + Button1.Size.Height) And (Label92.Size.Height + Label92.Top) > Button1.Top Then
                            Label92.Hide()
                        End If
                        If Label93.Left < (Button1.Left + Button1.Size.Width) And (Label93.Left + Label93.Width) > Button1.Left And Label93.Top < (Button1.Top + Button1.Size.Height) And (Label93.Size.Height + Label93.Top) > Button1.Top Then
                            Label93.Hide()
                        End If
                        If Label94.Left < (Button1.Left + Button1.Size.Width) And (Label94.Left + Label94.Width) > Button1.Left And Label94.Top < (Button1.Top + Button1.Size.Height) And (Label94.Size.Height + Label94.Top) > Button1.Top Then
                            Label94.Hide()
                        End If
                        If Label95.Left < (Button1.Left + Button1.Size.Width) And (Label95.Left + Label95.Width) > Button1.Left And Label95.Top < (Button1.Top + Button1.Size.Height) And (Label95.Size.Height + Label95.Top) > Button1.Top Then
                            Label95.Hide()
                        End If
                        If Label96.Left < (Button1.Left + Button1.Size.Width) And (Label96.Left + Label96.Width) > Button1.Left And Label96.Top < (Button1.Top + Button1.Size.Height) And (Label96.Size.Height + Label96.Top) > Button1.Top Then
                            Label96.Hide()
                        End If
                        If Label97.Left < (Button1.Left + Button1.Size.Width) And (Label97.Left + Label97.Width) > Button1.Left And Label97.Top < (Button1.Top + Button1.Size.Height) And (Label97.Size.Height + Label97.Top) > Button1.Top Then
                            Label97.Hide()
                        End If
                        If Label98.Left < (Button1.Left + Button1.Size.Width) And (Label98.Left + Label98.Width) > Button1.Left And Label98.Top < (Button1.Top + Button1.Size.Height) And (Label98.Size.Height + Label98.Top) > Button1.Top Then
                            Label98.Hide()
                        End If
                        If Label99.Left < (Button1.Left + Button1.Size.Width) And (Label99.Left + Label99.Width) > Button1.Left And Label99.Top < (Button1.Top + Button1.Size.Height) And (Label99.Size.Height + Label99.Top) > Button1.Top Then
                            Label99.Hide()
                        End If
                End Select


            End If
            timer3_tick()
            teleport()
            If collision() = True Then
                Button1.Left = Button1.Left - velocity
            End If
        ElseIf e.KeyChar = "a" Then
            l = l + 1
            Label101.Text = l
            punk()
            Button1.Left = Button1.Left - velocity
            If eat() = True Then

                Select Case a(100)
                    Case a(0)
                        If Label42.Left < (Button1.Left + Button1.Size.Width) And (Label42.Left + Label42.Width) > Button1.Left And Label42.Top < (Button1.Top + Button1.Size.Height) And (Label42.Size.Height + Label42.Top) > Button1.Top Then
                            Label42.Hide()
                        End If
                        If Label41.Left < (Button1.Left + Button1.Size.Width) And (Label41.Left + Label41.Width) > Button1.Left And Label41.Top < (Button1.Top + Button1.Size.Height) And (Label41.Size.Height + Label41.Top) > Button1.Top Then
                            Label41.Hide()
                        End If
                        If Label43.Left < (Button1.Left + Button1.Size.Width) And (Label43.Left + Label43.Width) > Button1.Left And Label43.Top < (Button1.Top + Button1.Size.Height) And (Label43.Size.Height + Label43.Top) > Button1.Top Then
                            Label43.Hide()
                        End If
                        If Label44.Left < (Button1.Left + Button1.Size.Width) And (Label44.Left + Label44.Width) > Button1.Left And Label44.Top < (Button1.Top + Button1.Size.Height) And (Label44.Size.Height + Label44.Top) > Button1.Top Then
                            Label44.Hide()
                        End If
                        If Label45.Left < (Button1.Left + Button1.Size.Width) And (Label45.Left + Label45.Width) > Button1.Left And Label45.Top < (Button1.Top + Button1.Size.Height) And (Label45.Size.Height + Label45.Top) > Button1.Top Then
                            Label45.Hide()
                        End If
                        If Label46.Left < (Button1.Left + Button1.Size.Width) And (Label46.Left + Label46.Width) > Button1.Left And Label46.Top < (Button1.Top + Button1.Size.Height) And (Label46.Size.Height + Label46.Top) > Button1.Top Then
                            Label46.Hide()


                        End If
            If Label47.Left < (Button1.Left + Button1.Size.Width) And (Label47.Left + Label47.Width) > Button1.Left And Label47.Top < (Button1.Top + Button1.Size.Height) And (Label47.Size.Height + Label47.Top) > Button1.Top Then
                Label47.Hide()
            End If
            If Label48.Left < (Button1.Left + Button1.Size.Width) And (Label48.Left + Label48.Width) > Button1.Left And Label48.Top < (Button1.Top + Button1.Size.Height) And (Label48.Size.Height + Label48.Top) > Button1.Top Then
                Label48.Hide()
            End If
            If Label49.Left < (Button1.Left + Button1.Size.Width) And (Label49.Left + Label49.Width) > Button1.Left And Label49.Top < (Button1.Top + Button1.Size.Height) And (Label49.Size.Height + Label49.Top) > Button1.Top Then
                Label49.Hide()
            End If
            If Label50.Left < (Button1.Left + Button1.Size.Width) And (Label50.Left + Label50.Width) > Button1.Left And Label50.Top < (Button1.Top + Button1.Size.Height) And (Label50.Size.Height + Label50.Top) > Button1.Top Then
                Label50.Hide()
            End If
            If Label51.Left < (Button1.Left + Button1.Size.Width) And (Label51.Left + Label51.Width) > Button1.Left And Label51.Top < (Button1.Top + Button1.Size.Height) And (Label51.Size.Height + Label51.Top) > Button1.Top Then
                Label51.Hide()
            End If
            If Label52.Left < (Button1.Left + Button1.Size.Width) And (Label52.Left + Label52.Width) > Button1.Left And Label52.Top < (Button1.Top + Button1.Size.Height) And (Label52.Size.Height + Label52.Top) > Button1.Top Then
                Label52.Hide()
            End If
            If Label53.Left < (Button1.Left + Button1.Size.Width) And (Label53.Left + Label53.Width) > Button1.Left And Label53.Top < (Button1.Top + Button1.Size.Height) And (Label53.Size.Height + Label53.Top) > Button1.Top Then
                Label53.Hide()
            End If
            If Label54.Left < (Button1.Left + Button1.Size.Width) And (Label54.Left + Label54.Width) > Button1.Left And Label54.Top < (Button1.Top + Button1.Size.Height) And (Label54.Size.Height + Label54.Top) > Button1.Top Then
                Label54.Hide()
            End If
            If Label55.Left < (Button1.Left + Button1.Size.Width) And (Label55.Left + Label55.Width) > Button1.Left And Label55.Top < (Button1.Top + Button1.Size.Height) And (Label55.Size.Height + Label55.Top) > Button1.Top Then
                Label55.Hide()
            End If
            If Label56.Left < (Button1.Left + Button1.Size.Width) And (Label56.Left + Label56.Width) > Button1.Left And Label56.Top < (Button1.Top + Button1.Size.Height) And (Label56.Size.Height + Label56.Top) > Button1.Top Then
                Label56.Hide()
            End If
            If Label57.Left < (Button1.Left + Button1.Size.Width) And (Label57.Left + Label57.Width) > Button1.Left And Label57.Top < (Button1.Top + Button1.Size.Height) And (Label57.Size.Height + Label57.Top) > Button1.Top Then
                Label57.Hide()
            End If
            If Label58.Left < (Button1.Left + Button1.Size.Width) And (Label58.Left + Label58.Width) > Button1.Left And Label58.Top < (Button1.Top + Button1.Size.Height) And (Label58.Size.Height + Label58.Top) > Button1.Top Then
                Label58.Hide()
            End If
            If Label59.Left < (Button1.Left + Button1.Size.Width) And (Label59.Left + Label59.Width) > Button1.Left And Label59.Top < (Button1.Top + Button1.Size.Height) And (Label59.Size.Height + Label59.Top) > Button1.Top Then
                Label59.Hide()
            End If
            If Label60.Left < (Button1.Left + Button1.Size.Width) And (Label60.Left + Label60.Width) > Button1.Left And Label60.Top < (Button1.Top + Button1.Size.Height) And (Label60.Size.Height + Label60.Top) > Button1.Top Then
                Label60.Hide()
            End If
            If Label61.Left < (Button1.Left + Button1.Size.Width) And (Label61.Left + Label61.Width) > Button1.Left And Label61.Top < (Button1.Top + Button1.Size.Height) And (Label61.Size.Height + Label61.Top) > Button1.Top Then
                Label61.Hide()
            End If
            If Label62.Left < (Button1.Left + Button1.Size.Width) And (Label62.Left + Label62.Width) > Button1.Left And Label62.Top < (Button1.Top + Button1.Size.Height) And (Label62.Size.Height + Label62.Top) > Button1.Top Then
                Label62.Hide()
            End If
            If Label63.Left < (Button1.Left + Button1.Size.Width) And (Label63.Left + Label63.Width) > Button1.Left And Label63.Top < (Button1.Top + Button1.Size.Height) And (Label63.Size.Height + Label63.Top) > Button1.Top Then
                Label63.Hide()
            End If
            If Label64.Left < (Button1.Left + Button1.Size.Width) And (Label64.Left + Label64.Width) > Button1.Left And Label64.Top < (Button1.Top + Button1.Size.Height) And (Label64.Size.Height + Label64.Top) > Button1.Top Then
                Label64.Hide()
            End If
            If Label65.Left < (Button1.Left + Button1.Size.Width) And (Label65.Left + Label65.Width) > Button1.Left And Label65.Top < (Button1.Top + Button1.Size.Height) And (Label65.Size.Height + Label65.Top) > Button1.Top Then
                Label65.Hide()
            End If
            If Label66.Left < (Button1.Left + Button1.Size.Width) And (Label66.Left + Label66.Width) > Button1.Left And Label66.Top < (Button1.Top + Button1.Size.Height) And (Label66.Size.Height + Label66.Top) > Button1.Top Then
                Label66.Hide()
            End If
            If Label67.Left < (Button1.Left + Button1.Size.Width) And (Label67.Left + Label67.Width) > Button1.Left And Label67.Top < (Button1.Top + Button1.Size.Height) And (Label67.Size.Height + Label67.Top) > Button1.Top Then
                Label67.Hide()
            End If
            If Label68.Left < (Button1.Left + Button1.Size.Width) And (Label68.Left + Label68.Width) > Button1.Left And Label68.Top < (Button1.Top + Button1.Size.Height) And (Label68.Size.Height + Label68.Top) > Button1.Top Then
                Label68.Hide()
            End If
            If Label69.Left < (Button1.Left + Button1.Size.Width) And (Label69.Left + Label69.Width) > Button1.Left And Label69.Top < (Button1.Top + Button1.Size.Height) And (Label69.Size.Height + Label69.Top) > Button1.Top Then
                Label69.Hide()
            End If
            If Label70.Left < (Button1.Left + Button1.Size.Width) And (Label70.Left + Label70.Width) > Button1.Left And Label70.Top < (Button1.Top + Button1.Size.Height) And (Label70.Size.Height + Label70.Top) > Button1.Top Then
                Label70.Hide()
            End If
            If Label71.Left < (Button1.Left + Button1.Size.Width) And (Label71.Left + Label71.Width) > Button1.Left And Label71.Top < (Button1.Top + Button1.Size.Height) And (Label71.Size.Height + Label71.Top) > Button1.Top Then
                Label71.Hide()
            End If
            If Label72.Left < (Button1.Left + Button1.Size.Width) And (Label72.Left + Label72.Width) > Button1.Left And Label72.Top < (Button1.Top + Button1.Size.Height) And (Label72.Size.Height + Label72.Top) > Button1.Top Then
                Label72.Hide()
            End If
            If Label73.Left < (Button1.Left + Button1.Size.Width) And (Label73.Left + Label73.Width) > Button1.Left And Label73.Top < (Button1.Top + Button1.Size.Height) And (Label73.Size.Height + Label73.Top) > Button1.Top Then
                Label73.Hide()
            End If
            If Label74.Left < (Button1.Left + Button1.Size.Width) And (Label74.Left + Label74.Width) > Button1.Left And Label74.Top < (Button1.Top + Button1.Size.Height) And (Label74.Size.Height + Label74.Top) > Button1.Top Then
                Label74.Hide()
            End If
            If Label75.Left < (Button1.Left + Button1.Size.Width) And (Label75.Left + Label75.Width) > Button1.Left And Label75.Top < (Button1.Top + Button1.Size.Height) And (Label75.Size.Height + Label75.Top) > Button1.Top Then
                Label75.Hide()
            End If
            If Label76.Left < (Button1.Left + Button1.Size.Width) And (Label76.Left + Label76.Width) > Button1.Left And Label76.Top < (Button1.Top + Button1.Size.Height) And (Label76.Size.Height + Label76.Top) > Button1.Top Then
                Label76.Hide()
            End If
            If Label77.Left < (Button1.Left + Button1.Size.Width) And (Label77.Left + Label77.Width) > Button1.Left And Label77.Top < (Button1.Top + Button1.Size.Height) And (Label77.Size.Height + Label77.Top) > Button1.Top Then
                Label77.Hide()
            End If
            If Label78.Left < (Button1.Left + Button1.Size.Width) And (Label78.Left + Label78.Width) > Button1.Left And Label78.Top < (Button1.Top + Button1.Size.Height) And (Label78.Size.Height + Label78.Top) > Button1.Top Then
                Label78.Hide()
            End If
            If Label79.Left < (Button1.Left + Button1.Size.Width) And (Label79.Left + Label79.Width) > Button1.Left And Label79.Top < (Button1.Top + Button1.Size.Height) And (Label79.Size.Height + Label79.Top) > Button1.Top Then
                Label79.Hide()
            End If
            If Label80.Left < (Button1.Left + Button1.Size.Width) And (Label80.Left + Label80.Width) > Button1.Left And Label80.Top < (Button1.Top + Button1.Size.Height) And (Label80.Size.Height + Label80.Top) > Button1.Top Then
                Label80.Hide()
            End If
            If Label81.Left < (Button1.Left + Button1.Size.Width) And (Label81.Left + Label81.Width) > Button1.Left And Label81.Top < (Button1.Top + Button1.Size.Height) And (Label81.Size.Height + Label81.Top) > Button1.Top Then
                Label81.Hide()
            End If
            If Label82.Left < (Button1.Left + Button1.Size.Width) And (Label82.Left + Label82.Width) > Button1.Left And Label82.Top < (Button1.Top + Button1.Size.Height) And (Label82.Size.Height + Label82.Top) > Button1.Top Then
                Label82.Hide()
            End If
            If Label83.Left < (Button1.Left + Button1.Size.Width) And (Label83.Left + Label83.Width) > Button1.Left And Label83.Top < (Button1.Top + Button1.Size.Height) And (Label83.Size.Height + Label83.Top) > Button1.Top Then
                Label83.Hide()
            End If
            If Label84.Left < (Button1.Left + Button1.Size.Width) And (Label84.Left + Label84.Width) > Button1.Left And Label84.Top < (Button1.Top + Button1.Size.Height) And (Label84.Size.Height + Label84.Top) > Button1.Top Then
                Label84.Hide()
            End If
            If Label85.Left < (Button1.Left + Button1.Size.Width) And (Label85.Left + Label85.Width) > Button1.Left And Label85.Top < (Button1.Top + Button1.Size.Height) And (Label85.Size.Height + Label85.Top) > Button1.Top Then
                Label85.Hide()
            End If
            If Label86.Left < (Button1.Left + Button1.Size.Width) And (Label86.Left + Label86.Width) > Button1.Left And Label86.Top < (Button1.Top + Button1.Size.Height) And (Label86.Size.Height + Label86.Top) > Button1.Top Then
                Label86.Hide()
            End If
            If Label87.Left < (Button1.Left + Button1.Size.Width) And (Label87.Left + Label87.Width) > Button1.Left And Label87.Top < (Button1.Top + Button1.Size.Height) And (Label87.Size.Height + Label87.Top) > Button1.Top Then
                            Label87.Hide()
                            MsgBox("GRATULUJE WYGRALES Z " & score & "PUNKTAMI")
                            Form2.Show()
            End If
            If Label88.Left < (Button1.Left + Button1.Size.Width) And (Label88.Left + Label88.Width) > Button1.Left And Label88.Top < (Button1.Top + Button1.Size.Height) And (Label88.Size.Height + Label88.Top) > Button1.Top Then
                Label88.Hide()
            End If
            If Label89.Left < (Button1.Left + Button1.Size.Width) And (Label89.Left + Label89.Width) > Button1.Left And Label89.Top < (Button1.Top + Button1.Size.Height) And (Label89.Size.Height + Label89.Top) > Button1.Top Then
                Label89.Hide()
            End If
            If Label90.Left < (Button1.Left + Button1.Size.Width) And (Label90.Left + Label90.Width) > Button1.Left And Label90.Top < (Button1.Top + Button1.Size.Height) And (Label90.Size.Height + Label90.Top) > Button1.Top Then
                Label90.Hide()
            End If
            If Label91.Left < (Button1.Left + Button1.Size.Width) And (Label91.Left + Label91.Width) > Button1.Left And Label91.Top < (Button1.Top + Button1.Size.Height) And (Label91.Size.Height + Label91.Top) > Button1.Top Then
                Label91.Hide()
            End If
            If Label92.Left < (Button1.Left + Button1.Size.Width) And (Label92.Left + Label92.Width) > Button1.Left And Label92.Top < (Button1.Top + Button1.Size.Height) And (Label92.Size.Height + Label92.Top) > Button1.Top Then
                Label92.Hide()
            End If
            If Label93.Left < (Button1.Left + Button1.Size.Width) And (Label93.Left + Label93.Width) > Button1.Left And Label93.Top < (Button1.Top + Button1.Size.Height) And (Label93.Size.Height + Label93.Top) > Button1.Top Then
                Label93.Hide()
            End If
            If Label94.Left < (Button1.Left + Button1.Size.Width) And (Label94.Left + Label94.Width) > Button1.Left And Label94.Top < (Button1.Top + Button1.Size.Height) And (Label94.Size.Height + Label94.Top) > Button1.Top Then
                Label94.Hide()
            End If
            If Label95.Left < (Button1.Left + Button1.Size.Width) And (Label95.Left + Label95.Width) > Button1.Left And Label95.Top < (Button1.Top + Button1.Size.Height) And (Label95.Size.Height + Label95.Top) > Button1.Top Then
                Label95.Hide()
            End If
            If Label96.Left < (Button1.Left + Button1.Size.Width) And (Label96.Left + Label96.Width) > Button1.Left And Label96.Top < (Button1.Top + Button1.Size.Height) And (Label96.Size.Height + Label96.Top) > Button1.Top Then
                Label96.Hide()
            End If
            If Label97.Left < (Button1.Left + Button1.Size.Width) And (Label97.Left + Label97.Width) > Button1.Left And Label97.Top < (Button1.Top + Button1.Size.Height) And (Label97.Size.Height + Label97.Top) > Button1.Top Then
                Label97.Hide()
            End If
            If Label98.Left < (Button1.Left + Button1.Size.Width) And (Label98.Left + Label98.Width) > Button1.Left And Label98.Top < (Button1.Top + Button1.Size.Height) And (Label98.Size.Height + Label98.Top) > Button1.Top Then
                Label98.Hide()
            End If
            If Label99.Left < (Button1.Left + Button1.Size.Width) And (Label99.Left + Label99.Width) > Button1.Left And Label99.Top < (Button1.Top + Button1.Size.Height) And (Label99.Size.Height + Label99.Top) > Button1.Top Then
                Label99.Hide()
            End If
                End Select
            End If
            timer4_tick()
            teleport()
            If collision() = True Then
                Button1.Left = Button1.Left + velocity
            End If
        End If
    End Sub
    Private Sub punk()
        score = score + 0
        Label110.Text = score
        If eat() = True Then
            score = Val(Label110.Text) + 10
        End If
        Label110.Text = score
    End Sub
    Function collision() As Boolean



        If Label1.Left < (Button1.Left + Button1.Size.Width) And (Label1.Left + Label1.Width) > Button1.Left And Label1.Top < (Button1.Top + Button1.Size.Height) And (Label1.Size.Height + Label1.Top) > Button1.Top Then
            Return True
        ElseIf Label2.Left < (Button1.Left + Button1.Size.Width) And (Label2.Left + Label2.Width) > Button1.Left And Label2.Top < (Button1.Top + Button1.Size.Height) And (Label2.Size.Height + Label2.Top) > Button1.Top Then
            Return True
        ElseIf Label3.Left < (Button1.Left + Button1.Size.Width) And (Label3.Left + Label3.Width) > Button1.Left And Label3.Top < (Button1.Top + Button1.Size.Height) And (Label3.Size.Height + Label3.Top) > Button1.Top Then
            Return True : ElseIf Label4.Left < (Button1.Left + Button1.Size.Width) And (Label4.Left + Label4.Width) > Button1.Left And Label4.Top < (Button1.Top + Button1.Size.Height) And (Label4.Size.Height + Label4.Top) > Button1.Top Then
            Return True : ElseIf Label6.Left < (Button1.Left + Button1.Size.Width) And (Label6.Left + Label6.Width) > Button1.Left And Label6.Top < (Button1.Top + Button1.Size.Height) And (Label6.Size.Height + Label6.Top) > Button1.Top Then
            Return True : ElseIf Label7.Left < (Button1.Left + Button1.Size.Width) And (Label7.Left + Label7.Width) > Button1.Left And Label7.Top < (Button1.Top + Button1.Size.Height) And (Label7.Size.Height + Label7.Top) > Button1.Top Then
            Return True : ElseIf Label8.Left < (Button1.Left + Button1.Size.Width) And (Label8.Left + Label8.Width) > Button1.Left And Label8.Top < (Button1.Top + Button1.Size.Height) And (Label8.Size.Height + Label8.Top) > Button1.Top Then
            Return True : ElseIf Label9.Left < (Button1.Left + Button1.Size.Width) And (Label9.Left + Label9.Width) > Button1.Left And Label9.Top < (Button1.Top + Button1.Size.Height) And (Label9.Size.Height + Label9.Top) > Button1.Top Then
            Return True : ElseIf Label10.Left < (Button1.Left + Button1.Size.Width) And (Label10.Left + Label10.Width) > Button1.Left And Label10.Top < (Button1.Top + Button1.Size.Height) And (Label10.Size.Height + Label10.Top) > Button1.Top Then
            Return True : ElseIf Label11.Left < (Button1.Left + Button1.Size.Width) And (Label11.Left + Label11.Width) > Button1.Left And Label11.Top < (Button1.Top + Button1.Size.Height) And (Label11.Size.Height + Label11.Top) > Button1.Top Then
            Return True : ElseIf Label12.Left < (Button1.Left + Button1.Size.Width) And (Label12.Left + Label12.Width) > Button1.Left And Label12.Top < (Button1.Top + Button1.Size.Height) And (Label12.Size.Height + Label12.Top) > Button1.Top Then
            Return True : ElseIf Label13.Left < (Button1.Left + Button1.Size.Width) And (Label13.Left + Label13.Width) > Button1.Left And Label13.Top < (Button1.Top + Button1.Size.Height) And (Label13.Size.Height + Label13.Top) > Button1.Top Then
            Return True : ElseIf Label14.Left < (Button1.Left + Button1.Size.Width) And (Label14.Left + Label14.Width) > Button1.Left And Label14.Top < (Button1.Top + Button1.Size.Height) And (Label14.Size.Height + Label14.Top) > Button1.Top Then
            Return True : ElseIf Label15.Left < (Button1.Left + Button1.Size.Width) And (Label15.Left + Label15.Width) > Button1.Left And Label15.Top < (Button1.Top + Button1.Size.Height) And (Label15.Size.Height + Label15.Top) > Button1.Top Then
            Return True : ElseIf Label16.Left < (Button1.Left + Button1.Size.Width) And (Label16.Left + Label16.Width) > Button1.Left And Label16.Top < (Button1.Top + Button1.Size.Height) And (Label16.Size.Height + Label16.Top) > Button1.Top Then
            Return True : ElseIf Label17.Left < (Button1.Left + Button1.Size.Width) And (Label17.Left + Label17.Width) > Button1.Left And Label17.Top < (Button1.Top + Button1.Size.Height) And (Label17.Size.Height + Label17.Top) > Button1.Top Then
            Return True : ElseIf Label18.Left < (Button1.Left + Button1.Size.Width) And (Label18.Left + Label18.Width) > Button1.Left And Label18.Top < (Button1.Top + Button1.Size.Height) And (Label18.Size.Height + Label18.Top) > Button1.Top Then
            Return True : ElseIf Label19.Left < (Button1.Left + Button1.Size.Width) And (Label19.Left + Label19.Width) > Button1.Left And Label19.Top < (Button1.Top + Button1.Size.Height) And (Label19.Size.Height + Label19.Top) > Button1.Top Then
            Return True : ElseIf Label20.Left < (Button1.Left + Button1.Size.Width) And (Label20.Left + Label20.Width) > Button1.Left And Label20.Top < (Button1.Top + Button1.Size.Height) And (Label20.Size.Height + Label20.Top) > Button1.Top Then
            Return True : ElseIf Label21.Left < (Button1.Left + Button1.Size.Width) And (Label21.Left + Label21.Width) > Button1.Left And Label21.Top < (Button1.Top + Button1.Size.Height) And (Label21.Size.Height + Label21.Top) > Button1.Top Then
            Return True : ElseIf Label22.Left < (Button1.Left + Button1.Size.Width) And (Label22.Left + Label22.Width) > Button1.Left And Label22.Top < (Button1.Top + Button1.Size.Height) And (Label22.Size.Height + Label22.Top) > Button1.Top Then
            Return True : ElseIf Label23.Left < (Button1.Left + Button1.Size.Width) And (Label23.Left + Label23.Width) > Button1.Left And Label23.Top < (Button1.Top + Button1.Size.Height) And (Label23.Size.Height + Label23.Top) > Button1.Top Then
            Return True : ElseIf Label24.Left < (Button1.Left + Button1.Size.Width) And (Label24.Left + Label24.Width) > Button1.Left And Label24.Top < (Button1.Top + Button1.Size.Height) And (Label24.Size.Height + Label24.Top) > Button1.Top Then
            Return True : ElseIf Label25.Left < (Button1.Left + Button1.Size.Width) And (Label25.Left + Label25.Width) > Button1.Left And Label25.Top < (Button1.Top + Button1.Size.Height) And (Label25.Size.Height + Label25.Top) > Button1.Top Then
            Return True : ElseIf Label26.Left < (Button1.Left + Button1.Size.Width) And (Label26.Left + Label26.Width) > Button1.Left And Label26.Top < (Button1.Top + Button1.Size.Height) And (Label26.Size.Height + Label26.Top) > Button1.Top Then
            Return True : ElseIf Label27.Left < (Button1.Left + Button1.Size.Width) And (Label27.Left + Label27.Width) > Button1.Left And Label27.Top < (Button1.Top + Button1.Size.Height) And (Label27.Size.Height + Label27.Top) > Button1.Top Then
            Return True : ElseIf Label28.Left < (Button1.Left + Button1.Size.Width) And (Label28.Left + Label28.Width) > Button1.Left And Label28.Top < (Button1.Top + Button1.Size.Height) And (Label28.Size.Height + Label28.Top) > Button1.Top Then
            Return True : ElseIf Label29.Left < (Button1.Left + Button1.Size.Width) And (Label29.Left + Label29.Width) > Button1.Left And Label29.Top < (Button1.Top + Button1.Size.Height) And (Label29.Size.Height + Label29.Top) > Button1.Top Then
            Return True : ElseIf Label30.Left < (Button1.Left + Button1.Size.Width) And (Label30.Left + Label30.Width) > Button1.Left And Label30.Top < (Button1.Top + Button1.Size.Height) And (Label30.Size.Height + Label30.Top) > Button1.Top Then
            Return True : ElseIf Label31.Left < (Button1.Left + Button1.Size.Width) And (Label31.Left + Label31.Width) > Button1.Left And Label31.Top < (Button1.Top + Button1.Size.Height) And (Label31.Size.Height + Label31.Top) > Button1.Top Then
            Return True : ElseIf Label32.Left < (Button1.Left + Button1.Size.Width) And (Label32.Left + Label32.Width) > Button1.Left And Label32.Top < (Button1.Top + Button1.Size.Height) And (Label32.Size.Height + Label32.Top) > Button1.Top Then
            Return True : ElseIf Label33.Left < (Button1.Left + Button1.Size.Width) And (Label33.Left + Label33.Width) > Button1.Left And Label33.Top < (Button1.Top + Button1.Size.Height) And (Label33.Size.Height + Label33.Top) > Button1.Top Then
            Return True : ElseIf Label34.Left < (Button1.Left + Button1.Size.Width) And (Label34.Left + Label34.Width) > Button1.Left And Label34.Top < (Button1.Top + Button1.Size.Height) And (Label34.Size.Height + Label34.Top) > Button1.Top Then
            Return True : ElseIf Label35.Left < (Button1.Left + Button1.Size.Width) And (Label35.Left + Label35.Width) > Button1.Left And Label35.Top < (Button1.Top + Button1.Size.Height) And (Label35.Size.Height + Label35.Top) > Button1.Top Then
            Return True : ElseIf Label36.Left < (Button1.Left + Button1.Size.Width) And (Label36.Left + Label36.Width) > Button1.Left And Label36.Top < (Button1.Top + Button1.Size.Height) And (Label36.Size.Height + Label36.Top) > Button1.Top Then
            Return True : ElseIf Label37.Left < (Button1.Left + Button1.Size.Width) And (Label37.Left + Label37.Width) > Button1.Left And Label37.Top < (Button1.Top + Button1.Size.Height) And (Label37.Size.Height + Label37.Top) > Button1.Top Then
            Return True : ElseIf Label38.Left < (Button1.Left + Button1.Size.Width) And (Label38.Left + Label38.Width) > Button1.Left And Label38.Top < (Button1.Top + Button1.Size.Height) And (Label38.Size.Height + Label38.Top) > Button1.Top Then
            Return True : ElseIf Label39.Left < (Button1.Left + Button1.Size.Width) And (Label39.Left + Label39.Width) > Button1.Left And Label39.Top < (Button1.Top + Button1.Size.Height) And (Label39.Size.Height + Label39.Top) > Button1.Top Then
            Return True : ElseIf Label40.Left < (Button1.Left + Button1.Size.Width) And (Label40.Left + Label40.Width) > Button1.Left And Label40.Top < (Button1.Top + Button1.Size.Height) And (Label40.Size.Height + Label40.Top) > Button1.Top Then
            Return True : 

        End If
        Return False



        Return False
    End Function
    Function collisiondeat() As Boolean
        If Button2.Left < (Button1.Left + Button1.Size.Width) And (Button2.Left + Button2.Width) > Button1.Left And Button2.Top < (Button1.Top + Button1.Size.Height) And (Button2.Size.Height + Button2.Top) > Button1.Top Then
            Return True : ElseIf gnam1.Left < (Button1.Left + Button1.Size.Width) And (gnam1.Left + gnam1.Width) > Button1.Left And gnam1.Top < (Button1.Top + Button1.Size.Height) And (gnam1.Size.Height + gnam1.Top) > Button1.Top Then
            Return True : ElseIf gnam2.Left < (Button1.Left + Button1.Size.Width) And (gnam2.Left + gnam2.Width) > Button1.Left And gnam2.Top < (Button1.Top + Button1.Size.Height) And (gnam2.Size.Height + gnam2.Top) > Button1.Top Then
            Return True : ElseIf gnam3.Left < (Button1.Left + Button1.Size.Width) And (gnam3.Left + gnam3.Width) > Button1.Left And gnam3.Top < (Button1.Top + Button1.Size.Height) And (gnam3.Size.Height + gnam3.Top) > Button1.Top Then
            Return True : ElseIf Button4.Left < (Button1.Left + Button1.Size.Width) And (Button4.Left + Button4.Width) > Button1.Left And Button4.Top < (Button1.Top + Button1.Size.Height) And (Button4.Size.Height + Button4.Top) > Button1.Top Then
            Return True
        End If
        Return False
    End Function
    Function eat()
        If Label41.Left < (Button1.Left + Button1.Size.Width) And (Label41.Left + Label41.Width) > Button1.Left And Label41.Top < (Button1.Top + Button1.Size.Height) And (Label41.Size.Height + Label41.Top) > Button1.Top Then
            Return True & a(0)
        ElseIf Label42.Left < (Button1.Left + Button1.Size.Width) And (Label42.Left + Label42.Width) > Button1.Left And Label42.Top < (Button1.Top + Button1.Size.Height) And (Label42.Size.Height + Label42.Top) > Button1.Top Then
            Return True & a(0) : ElseIf Label43.Left < (Button1.Left + Button1.Size.Width) And (Label43.Left + Label43.Width) > Button1.Left And Label43.Top < (Button1.Top + Button1.Size.Height) And (Label43.Size.Height + Label43.Top) > Button1.Top Then
            Return True : ElseIf Label44.Left < (Button1.Left + Button1.Size.Width) And (Label44.Left + Label44.Width) > Button1.Left And Label44.Top < (Button1.Top + Button1.Size.Height) And (Label44.Size.Height + Label44.Top) > Button1.Top Then
            Return True : ElseIf Label45.Left < (Button1.Left + Button1.Size.Width) And (Label45.Left + Label45.Width) > Button1.Left And Label45.Top < (Button1.Top + Button1.Size.Height) And (Label45.Size.Height + Label45.Top) > Button1.Top Then
            Return True : ElseIf Label46.Left < (Button1.Left + Button1.Size.Width) And (Label46.Left + Label46.Width) > Button1.Left And Label46.Top < (Button1.Top + Button1.Size.Height) And (Label46.Size.Height + Label46.Top) > Button1.Top Then
            Return True : ElseIf Label47.Left < (Button1.Left + Button1.Size.Width) And (Label47.Left + Label47.Width) > Button1.Left And Label47.Top < (Button1.Top + Button1.Size.Height) And (Label47.Size.Height + Label47.Top) > Button1.Top Then
            Return True : ElseIf Label48.Left < (Button1.Left + Button1.Size.Width) And (Label48.Left + Label48.Width) > Button1.Left And Label48.Top < (Button1.Top + Button1.Size.Height) And (Label48.Size.Height + Label48.Top) > Button1.Top Then
            Return True : ElseIf Label49.Left < (Button1.Left + Button1.Size.Width) And (Label49.Left + Label49.Width) > Button1.Left And Label49.Top < (Button1.Top + Button1.Size.Height) And (Label49.Size.Height + Label49.Top) > Button1.Top Then
            Return True : ElseIf Label50.Left < (Button1.Left + Button1.Size.Width) And (Label50.Left + Label50.Width) > Button1.Left And Label50.Top < (Button1.Top + Button1.Size.Height) And (Label50.Size.Height + Label50.Top) > Button1.Top Then
            Return True : ElseIf Label51.Left < (Button1.Left + Button1.Size.Width) And (Label51.Left + Label51.Width) > Button1.Left And Label51.Top < (Button1.Top + Button1.Size.Height) And (Label51.Size.Height + Label51.Top) > Button1.Top Then
            Return True : ElseIf Label52.Left < (Button1.Left + Button1.Size.Width) And (Label52.Left + Label52.Width) > Button1.Left And Label52.Top < (Button1.Top + Button1.Size.Height) And (Label52.Size.Height + Label52.Top) > Button1.Top Then
            Return True : ElseIf Label53.Left < (Button1.Left + Button1.Size.Width) And (Label53.Left + Label53.Width) > Button1.Left And Label53.Top < (Button1.Top + Button1.Size.Height) And (Label53.Size.Height + Label53.Top) > Button1.Top Then
            Return True : ElseIf Label54.Left < (Button1.Left + Button1.Size.Width) And (Label54.Left + Label54.Width) > Button1.Left And Label54.Top < (Button1.Top + Button1.Size.Height) And (Label54.Size.Height + Label54.Top) > Button1.Top Then
            Return True : ElseIf Label55.Left < (Button1.Left + Button1.Size.Width) And (Label55.Left + Label55.Width) > Button1.Left And Label55.Top < (Button1.Top + Button1.Size.Height) And (Label55.Size.Height + Label55.Top) > Button1.Top Then
            Return True : ElseIf Label56.Left < (Button1.Left + Button1.Size.Width) And (Label56.Left + Label56.Width) > Button1.Left And Label56.Top < (Button1.Top + Button1.Size.Height) And (Label56.Size.Height + Label56.Top) > Button1.Top Then
            Return True : ElseIf Label57.Left < (Button1.Left + Button1.Size.Width) And (Label57.Left + Label57.Width) > Button1.Left And Label57.Top < (Button1.Top + Button1.Size.Height) And (Label57.Size.Height + Label57.Top) > Button1.Top Then
            Return True : ElseIf Label58.Left < (Button1.Left + Button1.Size.Width) And (Label58.Left + Label58.Width) > Button1.Left And Label58.Top < (Button1.Top + Button1.Size.Height) And (Label58.Size.Height + Label58.Top) > Button1.Top Then
            Return True : ElseIf Label59.Left < (Button1.Left + Button1.Size.Width) And (Label59.Left + Label59.Width) > Button1.Left And Label59.Top < (Button1.Top + Button1.Size.Height) And (Label59.Size.Height + Label59.Top) > Button1.Top Then
            Return True : ElseIf Label60.Left < (Button1.Left + Button1.Size.Width) And (Label60.Left + Label60.Width) > Button1.Left And Label60.Top < (Button1.Top + Button1.Size.Height) And (Label60.Size.Height + Label60.Top) > Button1.Top Then
            Return True : ElseIf Label61.Left < (Button1.Left + Button1.Size.Width) And (Label61.Left + Label61.Width) > Button1.Left And Label61.Top < (Button1.Top + Button1.Size.Height) And (Label61.Size.Height + Label61.Top) > Button1.Top Then
            Return True : ElseIf Label62.Left < (Button1.Left + Button1.Size.Width) And (Label62.Left + Label62.Width) > Button1.Left And Label62.Top < (Button1.Top + Button1.Size.Height) And (Label62.Size.Height + Label62.Top) > Button1.Top Then
            Return True : ElseIf Label63.Left < (Button1.Left + Button1.Size.Width) And (Label63.Left + Label63.Width) > Button1.Left And Label63.Top < (Button1.Top + Button1.Size.Height) And (Label63.Size.Height + Label63.Top) > Button1.Top Then
            Return True : ElseIf Label64.Left < (Button1.Left + Button1.Size.Width) And (Label64.Left + Label64.Width) > Button1.Left And Label64.Top < (Button1.Top + Button1.Size.Height) And (Label64.Size.Height + Label64.Top) > Button1.Top Then
            Return True : ElseIf Label65.Left < (Button1.Left + Button1.Size.Width) And (Label65.Left + Label65.Width) > Button1.Left And Label65.Top < (Button1.Top + Button1.Size.Height) And (Label65.Size.Height + Label65.Top) > Button1.Top Then
            Return True : ElseIf Label66.Left < (Button1.Left + Button1.Size.Width) And (Label66.Left + Label66.Width) > Button1.Left And Label66.Top < (Button1.Top + Button1.Size.Height) And (Label66.Size.Height + Label66.Top) > Button1.Top Then
            Return True : ElseIf Label67.Left < (Button1.Left + Button1.Size.Width) And (Label67.Left + Label67.Width) > Button1.Left And Label67.Top < (Button1.Top + Button1.Size.Height) And (Label67.Size.Height + Label67.Top) > Button1.Top Then
            Return True : ElseIf Label68.Left < (Button1.Left + Button1.Size.Width) And (Label68.Left + Label68.Width) > Button1.Left And Label68.Top < (Button1.Top + Button1.Size.Height) And (Label68.Size.Height + Label68.Top) > Button1.Top Then
            Return True : ElseIf Label69.Left < (Button1.Left + Button1.Size.Width) And (Label69.Left + Label69.Width) > Button1.Left And Label69.Top < (Button1.Top + Button1.Size.Height) And (Label69.Size.Height + Label69.Top) > Button1.Top Then
            Return True : ElseIf Label70.Left < (Button1.Left + Button1.Size.Width) And (Label70.Left + Label70.Width) > Button1.Left And Label70.Top < (Button1.Top + Button1.Size.Height) And (Label70.Size.Height + Label70.Top) > Button1.Top Then
            Return True : ElseIf Label71.Left < (Button1.Left + Button1.Size.Width) And (Label71.Left + Label71.Width) > Button1.Left And Label71.Top < (Button1.Top + Button1.Size.Height) And (Label71.Size.Height + Label71.Top) > Button1.Top Then
            Return True : ElseIf Label72.Left < (Button1.Left + Button1.Size.Width) And (Label72.Left + Label72.Width) > Button1.Left And Label72.Top < (Button1.Top + Button1.Size.Height) And (Label72.Size.Height + Label72.Top) > Button1.Top Then
            Return True : ElseIf Label73.Left < (Button1.Left + Button1.Size.Width) And (Label73.Left + Label73.Width) > Button1.Left And Label73.Top < (Button1.Top + Button1.Size.Height) And (Label73.Size.Height + Label73.Top) > Button1.Top Then
            Return True : ElseIf Label74.Left < (Button1.Left + Button1.Size.Width) And (Label74.Left + Label74.Width) > Button1.Left And Label74.Top < (Button1.Top + Button1.Size.Height) And (Label74.Size.Height + Label74.Top) > Button1.Top Then
            Return True : ElseIf Label75.Left < (Button1.Left + Button1.Size.Width) And (Label75.Left + Label75.Width) > Button1.Left And Label75.Top < (Button1.Top + Button1.Size.Height) And (Label75.Size.Height + Label75.Top) > Button1.Top Then
            Return True : ElseIf Label76.Left < (Button1.Left + Button1.Size.Width) And (Label76.Left + Label76.Width) > Button1.Left And Label76.Top < (Button1.Top + Button1.Size.Height) And (Label76.Size.Height + Label76.Top) > Button1.Top Then
            Return True : ElseIf Label77.Left < (Button1.Left + Button1.Size.Width) And (Label77.Left + Label77.Width) > Button1.Left And Label77.Top < (Button1.Top + Button1.Size.Height) And (Label77.Size.Height + Label77.Top) > Button1.Top Then
            Return True : ElseIf Label78.Left < (Button1.Left + Button1.Size.Width) And (Label78.Left + Label78.Width) > Button1.Left And Label78.Top < (Button1.Top + Button1.Size.Height) And (Label78.Size.Height + Label78.Top) > Button1.Top Then
            Return True : ElseIf Label79.Left < (Button1.Left + Button1.Size.Width) And (Label79.Left + Label79.Width) > Button1.Left And Label79.Top < (Button1.Top + Button1.Size.Height) And (Label79.Size.Height + Label79.Top) > Button1.Top Then
            Return True : ElseIf Label80.Left < (Button1.Left + Button1.Size.Width) And (Label80.Left + Label80.Width) > Button1.Left And Label80.Top < (Button1.Top + Button1.Size.Height) And (Label80.Size.Height + Label80.Top) > Button1.Top Then
            Return True : ElseIf Label81.Left < (Button1.Left + Button1.Size.Width) And (Label81.Left + Label81.Width) > Button1.Left And Label81.Top < (Button1.Top + Button1.Size.Height) And (Label81.Size.Height + Label81.Top) > Button1.Top Then
            Return True : ElseIf Label82.Left < (Button1.Left + Button1.Size.Width) And (Label82.Left + Label82.Width) > Button1.Left And Label82.Top < (Button1.Top + Button1.Size.Height) And (Label82.Size.Height + Label82.Top) > Button1.Top Then
            Return True : ElseIf Label83.Left < (Button1.Left + Button1.Size.Width) And (Label83.Left + Label83.Width) > Button1.Left And Label83.Top < (Button1.Top + Button1.Size.Height) And (Label83.Size.Height + Label83.Top) > Button1.Top Then
            Return True : ElseIf Label84.Left < (Button1.Left + Button1.Size.Width) And (Label84.Left + Label84.Width) > Button1.Left And Label84.Top < (Button1.Top + Button1.Size.Height) And (Label84.Size.Height + Label84.Top) > Button1.Top Then
            Return True : ElseIf Label85.Left < (Button1.Left + Button1.Size.Width) And (Label85.Left + Label85.Width) > Button1.Left And Label85.Top < (Button1.Top + Button1.Size.Height) And (Label85.Size.Height + Label85.Top) > Button1.Top Then
            Return True : ElseIf Label86.Left < (Button1.Left + Button1.Size.Width) And (Label86.Left + Label86.Width) > Button1.Left And Label86.Top < (Button1.Top + Button1.Size.Height) And (Label86.Size.Height + Label86.Top) > Button1.Top Then
            Return True : ElseIf Label87.Left < (Button1.Left + Button1.Size.Width) And (Label87.Left + Label87.Width) > Button1.Left And Label87.Top < (Button1.Top + Button1.Size.Height) And (Label87.Size.Height + Label87.Top) > Button1.Top Then
            Return True : ElseIf Label88.Left < (Button1.Left + Button1.Size.Width) And (Label88.Left + Label88.Width) > Button1.Left And Label88.Top < (Button1.Top + Button1.Size.Height) And (Label88.Size.Height + Label88.Top) > Button1.Top Then
            Return True : ElseIf Label89.Left < (Button1.Left + Button1.Size.Width) And (Label89.Left + Label89.Width) > Button1.Left And Label89.Top < (Button1.Top + Button1.Size.Height) And (Label89.Size.Height + Label89.Top) > Button1.Top Then
            Return True : ElseIf Label90.Left < (Button1.Left + Button1.Size.Width) And (Label90.Left + Label90.Width) > Button1.Left And Label90.Top < (Button1.Top + Button1.Size.Height) And (Label90.Size.Height + Label90.Top) > Button1.Top Then
            Return True : ElseIf Label91.Left < (Button1.Left + Button1.Size.Width) And (Label91.Left + Label91.Width) > Button1.Left And Label91.Top < (Button1.Top + Button1.Size.Height) And (Label91.Size.Height + Label91.Top) > Button1.Top Then
            Return True : ElseIf Label92.Left < (Button1.Left + Button1.Size.Width) And (Label92.Left + Label92.Width) > Button1.Left And Label92.Top < (Button1.Top + Button1.Size.Height) And (Label92.Size.Height + Label92.Top) > Button1.Top Then
            Return True : ElseIf Label93.Left < (Button1.Left + Button1.Size.Width) And (Label93.Left + Label93.Width) > Button1.Left And Label93.Top < (Button1.Top + Button1.Size.Height) And (Label93.Size.Height + Label93.Top) > Button1.Top Then
            Return True : ElseIf Label94.Left < (Button1.Left + Button1.Size.Width) And (Label94.Left + Label94.Width) > Button1.Left And Label94.Top < (Button1.Top + Button1.Size.Height) And (Label94.Size.Height + Label94.Top) > Button1.Top Then
            Return True : ElseIf Label95.Left < (Button1.Left + Button1.Size.Width) And (Label95.Left + Label95.Width) > Button1.Left And Label95.Top < (Button1.Top + Button1.Size.Height) And (Label95.Size.Height + Label95.Top) > Button1.Top Then
            Return True : ElseIf Label96.Left < (Button1.Left + Button1.Size.Width) And (Label96.Left + Label96.Width) > Button1.Left And Label96.Top < (Button1.Top + Button1.Size.Height) And (Label96.Size.Height + Label96.Top) > Button1.Top Then
            Return True : ElseIf Label97.Left < (Button1.Left + Button1.Size.Width) And (Label97.Left + Label97.Width) > Button1.Left And Label97.Top < (Button1.Top + Button1.Size.Height) And (Label97.Size.Height + Label97.Top) > Button1.Top Then
            Return True : ElseIf Label98.Left < (Button1.Left + Button1.Size.Width) And (Label98.Left + Label98.Width) > Button1.Left And Label98.Top < (Button1.Top + Button1.Size.Height) And (Label98.Size.Height + Label98.Top) > Button1.Top Then
            Return True : ElseIf Label99.Left < (Button1.Left + Button1.Size.Width) And (Label99.Left + Label99.Width) > Button1.Left And Label99.Top < (Button1.Top + Button1.Size.Height) And (Label99.Size.Height + Label99.Top) > Button1.Top Then
            Return True
        End If
        Return False
    End Function
    Private Sub teleport()
        If Label103.Left < (Button1.Left + Button1.Size.Width) And (Label103.Left + Label103.Width) > Button1.Left And Label103.Top < (Button1.Top + Button1.Size.Height) And (Label103.Size.Height + Label103.Top) > Button1.Top Then
            Button1.Top = 194
            Button1.Left = 11

        ElseIf Label100.Left < (Button1.Left + Button1.Size.Width) And (Label100.Left + Label100.Width) > Button1.Left And Label100.Top < (Button1.Top + Button1.Size.Height) And (Label100.Size.Height + Label100.Top) > Button1.Top Then
            Button1.Top = 208
            Button1.Left = 646
        End If
    End Sub
    Private Sub kill()

        Button2.Top = Button2.Top - 3
        If (Button2.Top = 155 And Button2.Left = 371) Then
            For l = 0 To 14
                Button2.Left = Button2.Left + 3
            Next
        End If
        While Label32.Left < (Button2.Left + Button2.Size.Width) And (Label32.Left + Label32.Width) > Button2.Left And Label32.Top < (Button2.Top + Button2.Size.Height) And (Label32.Size.Height + Label32.Top) > Button2.Top
            Button2.Top = Button2.Top + 3
            Button2.Left = Button2.Left + 3
        End While
        While Label11.Left < (Button2.Left + Button2.Size.Width) And (Label11.Left + Label11.Width) > Button2.Left And Label11.Top < (Button2.Top + Button2.Size.Height) And (Label11.Size.Height + Label11.Top) > Button2.Top
            Button2.Top = Button2.Top + 3
            Button2.Left = Button2.Left - 3
        End While
        While Label6.Left < (Button2.Left + Button2.Size.Width) And (Label6.Left + Label6.Width) > Button2.Left And Label6.Top < (Button2.Top + Button2.Size.Height) And (Label6.Size.Height + Label6.Top) > Button2.Top
            Button2.Top = Button2.Top + 3
            Button2.Left = Button2.Left - 3
        End While
        While Label21.Left < (Button2.Left + Button2.Size.Width) And (Label21.Left + Label21.Width) > Button2.Left And Label21.Top < (Button2.Top + Button2.Size.Height) And (Label21.Size.Height + Label21.Top) > Button2.Top
            Button2.Left = Button2.Left - 3
            Button2.Top = Button2.Top + 3
        End While
        If (Label4.Left < (Button2.Left + Button2.Size.Width) And (Label4.Left + Label4.Width) > Button2.Left And Label4.Top < (Button2.Top + Button2.Size.Height) And (Label4.Size.Height + Label4.Top) > Button2.Top) Then
            Button2.Top = Button2.Top + 3
            Button2.Left = Button2.Left - 3
        End If
        If (Label3.Left < (Button2.Left + Button2.Size.Width) And (Label3.Left + Label3.Width) > Button2.Left And Label3.Top < (Button2.Top + Button2.Size.Height) And (Label3.Size.Height + Label3.Top) > Button2.Top) Then
            Button2.Left = 371
            Button2.Top = 242
        End If
        gnam3.Visible = True : gnam1.Enabled = True
        gnam1.Visible = True : gnam2.Enabled = True
        gnam2.Visible = True : gnam3.Enabled = True




    End Sub
    Private Sub Gnamm1()
        gnam1.Left = gnam1.Left + 3
        While Label27.Left < (gnam1.Left + gnam1.Size.Width) And (Label27.Left + Label27.Width) > gnam1.Left And Label27.Top < (gnam1.Top + gnam1.Size.Height) And (Label27.Size.Height + Label27.Top) > gnam1.Top
            gnam1.Left = 470
            gnam1.Top = 163
        End While
        While Label36.Left < (gnam1.Left + gnam1.Size.Width) And (Label36.Left + Label36.Width) > gnam1.Left And Label36.Top < (gnam1.Top + gnam1.Size.Height) And (Label36.Size.Height + Label36.Top) > gnam1.Top
            gnam1.Top = gnam1.Top - 2
        End While
        While Label12.Left < (gnam1.Left + gnam1.Size.Width) And (Label12.Left + Label12.Width) > gnam1.Left And Label12.Top < (gnam1.Top + gnam1.Size.Height) And (Label12.Size.Height + Label12.Top) > gnam1.Top
            gnam1.Left = gnam1.Left - 3
            gnam1.Top = gnam1.Top - 3
        End While
        While Label13.Left < (gnam1.Left + gnam1.Size.Width) And (Label13.Left + Label13.Width) > gnam1.Left And Label13.Top < (gnam1.Top + gnam1.Size.Height) And (Label13.Size.Height + Label13.Top) > gnam1.Top

            For l = 0 To 10
                gnam1.Left = gnam1.Left - 3
            Next
        End While
        If Label20.Left < (gnam1.Left + gnam1.Size.Width) And (Label20.Left + Label20.Width) > gnam1.Left And Label20.Top < (gnam1.Top + gnam1.Size.Height) And (Label20.Size.Height + Label20.Top) > gnam1.Top Then
            gnam1.Top = gnam1.Top + 3
            gnam1.Left = gnam1.Left - 3
        End If
        If Label104.Left < (gnam1.Left + gnam1.Size.Width) And (Label104.Left + Label104.Width) > gnam1.Left And Label104.Top < (gnam1.Top + gnam1.Size.Height) And (Label104.Size.Height + Label104.Top) > gnam1.Top Then
            gnam1.Left = 484
            gnam1.Top = 395
        End If
        If Label14.Left < (gnam1.Left + gnam1.Size.Width) And (Label14.Left + Label14.Width) > gnam1.Left And Label14.Top < (gnam1.Top + gnam1.Size.Height) And (Label14.Size.Height + Label14.Top) > gnam1.Top Then
            gnam1.Left = gnam1.Left - 3
            gnam1.Top = gnam1.Top - 3
        End If
        If Label103.Left < (gnam1.Left + gnam1.Size.Width) And (Label103.Left + Label103.Width) > gnam1.Left And Label103.Top < (gnam1.Top + gnam1.Size.Height) And (Label103.Size.Height + Label103.Top) > gnam1.Top Then
            gnam1.Left = 390
            gnam1.Top = 242
        End If
    End Sub
    Private Sub Gnamm2()
        gnam2.Top = gnam2.Top - 3
        If Label37.Left < (gnam2.Left + gnam2.Size.Width) And (Label37.Left + Label37.Width) > gnam2.Left And Label37.Top < (gnam2.Top + gnam2.Size.Height) And (Label37.Size.Height + Label37.Top) > gnam2.Top Then
            gnam2.Left = 315
            gnam2.Top = 399
        End If
        If Label17.Left < (gnam2.Left + gnam2.Size.Width) And (Label17.Left + Label17.Width) > gnam2.Left And Label17.Top < (gnam2.Top + gnam2.Size.Height) And (Label17.Size.Height + Label17.Top) > gnam2.Top Then
            gnam2.Top = gnam2.Top + 3
            gnam2.Left = gnam2.Left + 3
        End If
        If Label24.Left < (gnam2.Left + gnam2.Size.Width) And (Label24.Left + Label24.Width) > gnam2.Left And Label24.Top < (gnam2.Top + gnam2.Size.Height) And (Label24.Size.Height + Label24.Top) > gnam2.Top Then
            gnam2.Top = gnam2.Top + 3
            gnam2.Left = gnam2.Left - 3
        End If
        If Label25.Left < (gnam2.Left + gnam2.Size.Width) And (Label25.Left + Label25.Width) > gnam2.Left And Label25.Top < (gnam2.Top + gnam2.Size.Height) And (Label25.Size.Height + Label25.Top) > gnam2.Top Then
            gnam2.Top = gnam2.Top + 3
            gnam2.Left = gnam2.Left - 3
        End If
        If Label26.Left < (gnam2.Left + gnam2.Size.Width) And (Label26.Left + Label26.Width) > gnam2.Left And Label26.Top < (gnam2.Top + gnam2.Size.Height) And (Label26.Size.Height + Label26.Top) > gnam2.Top Then
            gnam2.Top = gnam2.Top + 3
            gnam2.Left = gnam2.Left - 3
        End If
        If Label31.Left < (gnam2.Left + gnam2.Size.Width) And (Label31.Left + Label31.Width) > gnam2.Left And Label31.Top < (gnam2.Top + gnam2.Size.Height) And (Label31.Size.Height + Label31.Top) > gnam2.Top Then
            gnam2.Left = 171
            gnam2.Top = 398
        End If
        If Label33.Left < (gnam2.Left + gnam2.Size.Width) And (Label33.Left + Label33.Width) > gnam2.Left And Label33.Top < (gnam2.Top + gnam2.Size.Height) And (Label33.Size.Height + Label33.Top) > gnam2.Top Then
            gnam2.Left = 328
            gnam2.Top = 244
        End If
    End Sub
    Private Sub Gnamm3()
        gnam3.Left = gnam3.Left - 3
        While Label26.Left < (gnam3.Left + gnam3.Size.Width) And (Label26.Left + Label26.Width) > gnam3.Left And Label26.Top < (gnam3.Top + gnam3.Size.Height) And (Label26.Size.Height + Label26.Top) > gnam3.Top
            gnam3.Left = 186
            gnam3.Top = 242
        End While
        While Label33.Left < (gnam3.Left + gnam3.Size.Width) And (Label33.Left + Label33.Width) > gnam3.Left And Label33.Top < (gnam3.Top + gnam3.Size.Height) And (Label33.Size.Height + Label33.Top) > gnam3.Top
            gnam3.Left = gnam3.Left + 3
            gnam3.Top = gnam3.Top - 3

        End While
        While Label29.Left < (gnam3.Left + gnam3.Size.Width) And (Label29.Left + Label29.Width) > gnam3.Left And Label29.Top < (gnam3.Top + gnam3.Size.Height) And (Label29.Size.Height + Label29.Top) > gnam3.Top
            gnam3.Left = gnam3.Left + 3
            gnam3.Top = gnam3.Top + 3
        End While
        While Label7.Left < (gnam3.Left + gnam3.Size.Width) And (Label7.Left + Label7.Width) > gnam3.Left And Label7.Top < (gnam3.Top + gnam3.Size.Height) And (Label7.Size.Height + Label7.Top) > gnam3.Top
            gnam3.Left = gnam3.Left + 3
            gnam3.Top = gnam3.Top + 3

        End While
        While Label1.Left < (gnam3.Left + gnam3.Size.Width) And (Label1.Left + Label1.Width) > gnam3.Left And Label1.Top < (gnam3.Top + gnam3.Size.Height) And (Label1.Size.Height + Label1.Top) > gnam3.Top
            gnam3.Left = gnam3.Left + 3
            gnam3.Top = gnam3.Top - 3
            gnam3.Left = gnam3.Left + 220
        End While
        While Label19.Left < (gnam3.Left + gnam3.Size.Width) And (Label19.Left + Label19.Width) > gnam3.Left And Label19.Top < (gnam3.Top + gnam3.Size.Height) And (Label19.Size.Height + Label19.Top) > gnam3.Top
            gnam3.Left = gnam3.Left + 3
            gnam3.Top = gnam3.Top - 3
        End While
        While Label38.Left < (gnam3.Left + gnam3.Size.Width) And (Label38.Left + Label38.Width) > gnam3.Left And Label38.Top < (gnam3.Top + gnam3.Size.Height) And (Label38.Size.Height + Label38.Top) > gnam3.Top
            gnam3.Left = 243
            gnam3.Top = 295
        End While
        While Label34.Left < (gnam3.Left + gnam3.Size.Width) And (Label34.Left + Label34.Width) > gnam3.Left And Label34.Top < (gnam3.Top + gnam3.Size.Height) And (Label34.Size.Height + Label34.Top) > gnam3.Top
            gnam3.Left = gnam3.Left + 3
            gnam3.Top = gnam3.Top + 3
        End While
        While Label16.Left < (gnam3.Left + gnam3.Size.Width) And (Label16.Left + Label16.Width) > gnam3.Left And Label16.Top < (gnam3.Top + gnam3.Size.Height) And (Label16.Size.Height + Label16.Top) > gnam3.Top
            gnam3.Left = 649
            gnam3.Top = 398
        End While
        While Label18.Left < (gnam3.Left + gnam3.Size.Width) And (Label18.Left + Label18.Width) > gnam3.Left And Label16.Top < (gnam3.Top + gnam3.Size.Height) And (Label18.Size.Height + Label18.Top) > gnam3.Top
            gnam3.Left = 277
            gnam3.Top = 245
        End While
    End Sub
    Private Sub licznik()

        s += 1
    End Sub
    Function collisionkill2() As Boolean
        If Label1.Left < (Button4.Left + Button4.Size.Width) And (Label1.Left + Label1.Width) > Button4.Left And Label1.Top < (Button4.Top + Button4.Size.Height) And (Label1.Size.Height + Label1.Top) > Button4.Top Then
            Return True
        ElseIf Label2.Left < (Button4.Left + Button4.Size.Width) And (Label2.Left + Label2.Width) > Button4.Left And Label2.Top < (Button4.Top + Button4.Size.Height) And (Label2.Size.Height + Label2.Top) > Button4.Top Then
            Return True
        ElseIf Label3.Left < (Button1.Left + Button1.Size.Width) And (Label3.Left + Label3.Width) > Button1.Left And Label3.Top < (Button1.Top + Button1.Size.Height) And (Label3.Size.Height + Label3.Top) > Button1.Top Then
            Return True : ElseIf Label4.Left < (Button1.Left + Button1.Size.Width) And (Label4.Left + Label4.Width) > Button1.Left And Label4.Top < (Button1.Top + Button1.Size.Height) And (Label4.Size.Height + Label4.Top) > Button1.Top Then
            Return True : ElseIf Label6.Left < (Button1.Left + Button1.Size.Width) And (Label6.Left + Label6.Width) > Button1.Left And Label6.Top < (Button1.Top + Button1.Size.Height) And (Label6.Size.Height + Label6.Top) > Button1.Top Then
            Return True : ElseIf Label7.Left < (Button1.Left + Button1.Size.Width) And (Label7.Left + Label7.Width) > Button1.Left And Label7.Top < (Button1.Top + Button1.Size.Height) And (Label7.Size.Height + Label7.Top) > Button1.Top Then
            Return True : ElseIf Label8.Left < (Button1.Left + Button1.Size.Width) And (Label8.Left + Label8.Width) > Button1.Left And Label8.Top < (Button1.Top + Button1.Size.Height) And (Label8.Size.Height + Label8.Top) > Button1.Top Then
            Return True : ElseIf Label9.Left < (Button1.Left + Button1.Size.Width) And (Label9.Left + Label9.Width) > Button1.Left And Label9.Top < (Button1.Top + Button1.Size.Height) And (Label9.Size.Height + Label9.Top) > Button1.Top Then
            Return True : ElseIf Label10.Left < (Button1.Left + Button1.Size.Width) And (Label10.Left + Label10.Width) > Button1.Left And Label10.Top < (Button1.Top + Button1.Size.Height) And (Label10.Size.Height + Label10.Top) > Button1.Top Then
            Return True : ElseIf Label11.Left < (Button1.Left + Button1.Size.Width) And (Label11.Left + Label11.Width) > Button1.Left And Label11.Top < (Button1.Top + Button1.Size.Height) And (Label11.Size.Height + Label11.Top) > Button1.Top Then
            Return True : ElseIf Label12.Left < (Button1.Left + Button1.Size.Width) And (Label12.Left + Label12.Width) > Button1.Left And Label12.Top < (Button1.Top + Button1.Size.Height) And (Label12.Size.Height + Label12.Top) > Button1.Top Then
            Return True : ElseIf Label13.Left < (Button1.Left + Button1.Size.Width) And (Label13.Left + Label13.Width) > Button1.Left And Label13.Top < (Button1.Top + Button1.Size.Height) And (Label13.Size.Height + Label13.Top) > Button1.Top Then
            Return True : ElseIf Label14.Left < (Button1.Left + Button1.Size.Width) And (Label14.Left + Label14.Width) > Button1.Left And Label14.Top < (Button1.Top + Button1.Size.Height) And (Label14.Size.Height + Label14.Top) > Button1.Top Then
            Return True : ElseIf Label15.Left < (Button1.Left + Button1.Size.Width) And (Label15.Left + Label15.Width) > Button1.Left And Label15.Top < (Button1.Top + Button1.Size.Height) And (Label15.Size.Height + Label15.Top) > Button1.Top Then
            Return True : ElseIf Label16.Left < (Button1.Left + Button1.Size.Width) And (Label16.Left + Label16.Width) > Button1.Left And Label16.Top < (Button1.Top + Button1.Size.Height) And (Label16.Size.Height + Label16.Top) > Button1.Top Then
            Return True : ElseIf Label17.Left < (Button1.Left + Button1.Size.Width) And (Label17.Left + Label17.Width) > Button1.Left And Label17.Top < (Button1.Top + Button1.Size.Height) And (Label17.Size.Height + Label17.Top) > Button1.Top Then
            Return True : ElseIf Label18.Left < (Button1.Left + Button1.Size.Width) And (Label18.Left + Label18.Width) > Button1.Left And Label18.Top < (Button1.Top + Button1.Size.Height) And (Label18.Size.Height + Label18.Top) > Button1.Top Then
            Return True : ElseIf Label19.Left < (Button1.Left + Button1.Size.Width) And (Label19.Left + Label19.Width) > Button1.Left And Label19.Top < (Button1.Top + Button1.Size.Height) And (Label19.Size.Height + Label19.Top) > Button1.Top Then
            Return True : ElseIf Label20.Left < (Button1.Left + Button1.Size.Width) And (Label20.Left + Label20.Width) > Button1.Left And Label20.Top < (Button1.Top + Button1.Size.Height) And (Label20.Size.Height + Label20.Top) > Button1.Top Then
            Return True : ElseIf Label21.Left < (Button1.Left + Button1.Size.Width) And (Label21.Left + Label21.Width) > Button1.Left And Label21.Top < (Button1.Top + Button1.Size.Height) And (Label21.Size.Height + Label21.Top) > Button1.Top Then
            Return True : ElseIf Label22.Left < (Button1.Left + Button1.Size.Width) And (Label22.Left + Label22.Width) > Button1.Left And Label22.Top < (Button1.Top + Button1.Size.Height) And (Label22.Size.Height + Label22.Top) > Button1.Top Then
            Return True : ElseIf Label23.Left < (Button1.Left + Button1.Size.Width) And (Label23.Left + Label23.Width) > Button1.Left And Label23.Top < (Button1.Top + Button1.Size.Height) And (Label23.Size.Height + Label23.Top) > Button1.Top Then
            Return True : ElseIf Label24.Left < (Button1.Left + Button1.Size.Width) And (Label24.Left + Label24.Width) > Button1.Left And Label24.Top < (Button1.Top + Button1.Size.Height) And (Label24.Size.Height + Label24.Top) > Button1.Top Then
            Return True : ElseIf Label25.Left < (Button4.Left + Button4.Size.Width) And (Label25.Left + Label25.Width) > Button4.Left And Label25.Top < (Button4.Top + Button4.Size.Height) And (Label25.Size.Height + Label25.Top) > Button4.Top Then
            Return True : ElseIf Label26.Left < (Button1.Left + Button1.Size.Width) And (Label26.Left + Label26.Width) > Button1.Left And Label26.Top < (Button1.Top + Button1.Size.Height) And (Label26.Size.Height + Label26.Top) > Button1.Top Then
            Return True : ElseIf Label27.Left < (Button1.Left + Button1.Size.Width) And (Label27.Left + Label27.Width) > Button1.Left And Label27.Top < (Button1.Top + Button1.Size.Height) And (Label27.Size.Height + Label27.Top) > Button1.Top Then
            Return True : ElseIf Label28.Left < (Button1.Left + Button1.Size.Width) And (Label28.Left + Label28.Width) > Button1.Left And Label28.Top < (Button1.Top + Button1.Size.Height) And (Label28.Size.Height + Label28.Top) > Button1.Top Then
            Return True : ElseIf Label29.Left < (Button1.Left + Button1.Size.Width) And (Label29.Left + Label29.Width) > Button1.Left And Label29.Top < (Button1.Top + Button1.Size.Height) And (Label29.Size.Height + Label29.Top) > Button1.Top Then
            Return True : ElseIf Label30.Left < (Button1.Left + Button1.Size.Width) And (Label30.Left + Label30.Width) > Button1.Left And Label30.Top < (Button1.Top + Button1.Size.Height) And (Label30.Size.Height + Label30.Top) > Button1.Top Then
            Return True : ElseIf Label31.Left < (Button1.Left + Button1.Size.Width) And (Label31.Left + Label31.Width) > Button1.Left And Label31.Top < (Button1.Top + Button1.Size.Height) And (Label31.Size.Height + Label31.Top) > Button1.Top Then
            Return True : ElseIf Label32.Left < (Button1.Left + Button1.Size.Width) And (Label32.Left + Label32.Width) > Button1.Left And Label32.Top < (Button1.Top + Button1.Size.Height) And (Label32.Size.Height + Label32.Top) > Button1.Top Then
            Return True : ElseIf Label33.Left < (Button1.Left + Button1.Size.Width) And (Label33.Left + Label33.Width) > Button1.Left And Label33.Top < (Button1.Top + Button1.Size.Height) And (Label33.Size.Height + Label33.Top) > Button1.Top Then
            Return True : ElseIf Label34.Left < (Button1.Left + Button1.Size.Width) And (Label34.Left + Label34.Width) > Button1.Left And Label34.Top < (Button1.Top + Button1.Size.Height) And (Label34.Size.Height + Label34.Top) > Button1.Top Then
            Return True : ElseIf Label35.Left < (Button1.Left + Button1.Size.Width) And (Label35.Left + Label35.Width) > Button1.Left And Label35.Top < (Button1.Top + Button1.Size.Height) And (Label35.Size.Height + Label35.Top) > Button1.Top Then
            Return True : ElseIf Label36.Left < (Button1.Left + Button1.Size.Width) And (Label36.Left + Label36.Width) > Button1.Left And Label36.Top < (Button1.Top + Button1.Size.Height) And (Label36.Size.Height + Label36.Top) > Button1.Top Then
            Return True : ElseIf Label37.Left < (Button1.Left + Button1.Size.Width) And (Label37.Left + Label37.Width) > Button1.Left And Label37.Top < (Button1.Top + Button1.Size.Height) And (Label37.Size.Height + Label37.Top) > Button1.Top Then
            Return True : ElseIf Label38.Left < (Button1.Left + Button1.Size.Width) And (Label38.Left + Label38.Width) > Button1.Left And Label38.Top < (Button1.Top + Button1.Size.Height) And (Label38.Size.Height + Label38.Top) > Button1.Top Then
            Return True : ElseIf Label39.Left < (Button1.Left + Button1.Size.Width) And (Label39.Left + Label39.Width) > Button1.Left And Label39.Top < (Button1.Top + Button1.Size.Height) And (Label39.Size.Height + Label39.Top) > Button1.Top Then
            Return True : ElseIf Label40.Left < (Button1.Left + Button1.Size.Width) And (Label40.Left + Label40.Width) > Button1.Left And Label40.Top < (Button1.Top + Button1.Size.Height) And (Label40.Size.Height + Label40.Top) > Button1.Top Then
            Return True

        End If
        Return False



        Return False
    End Function
 
    Private Sub kill2()
        If Button1.Left > Button4.Left Then
            Button4.Left += 3
        Else
            Button4.Left -= 3

        End If
        If Button1.Top > Button4.Top Then
            Button4.Top += 3
        Else
            Button4.Top -= 3

        End If
        If collisionkill2() = True Then
            Button4.Left = Button4.Left - 3

        End If


    End Sub
    Private Sub Timer2_tick()
        If x = 0 Then
            Button1.Image = My.Resources.giu
            x = 1 : Exit Sub
        ElseIf x = 1 Then
            Button1.Image = My.Resources.giu1
            x = 2
            Exit Sub
        ElseIf x = 2 Then
            Button1.Image = My.Resources.giu2
            x = 3
            Exit Sub
        ElseIf x = 3 Then
            Button1.Image = My.Resources.giu
            x = 4
            Exit Sub
        ElseIf x = 4 Then
            x = 0
        End If
    End Sub

    Private Sub timer3_tick()
        If x = 0 Then
            Button1.Image = My.Resources.destra
            x = 1 : Exit Sub
        ElseIf x = 1 Then
            Button1.Image = My.Resources.destra1
            x = 2
            Exit Sub
        ElseIf x = 2 Then
            Button1.Image = My.Resources.destra2
            x = 3
            Exit Sub
        ElseIf x = 3 Then
            Button1.Image = My.Resources.destra
            x = 4
            Exit Sub
        ElseIf x = 4 Then
            x = 0
        End If
    End Sub

    Private Sub timer4_tick()
        If x = 0 Then
            Button1.Image = My.Resources.sinistra
            x = 1 : Exit Sub
        ElseIf x = 1 Then
            Button1.Image = My.Resources.sinistra1
            x = 2
            Exit Sub
        ElseIf x = 2 Then
            Button1.Image = My.Resources.sinistra2
            x = 3
            Exit Sub
        ElseIf x = 3 Then
            Button1.Image = My.Resources.sinistra
            x = 4
            Exit Sub
        ElseIf x = 4 Then
            x = 0
        End If
    End Sub

    Private Sub Timer1_Tick()
        If x = 0 Then
            Button1.Image = My.Resources.su
            x = 1 : Exit Sub
        ElseIf x = 1 Then
            Button1.Image = My.Resources.su1
            x = 2
            Exit Sub
        ElseIf x = 2 Then
            Button1.Image = My.Resources.su2
            x = 3
            Exit Sub
        ElseIf x = 3 Then
            Button1.Image = My.Resources.su
            x = 4
            Exit Sub
        ElseIf x = 4 Then
            x = 0
        End If
    End Sub


    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        kill()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        kill2()
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        licznik()
        Label102.Text = s
        If Label102.Text = 300 Then
            Label102.Hide()


        End If
    End Sub

    Private Sub moveGnam1_Tick(sender As Object, e As EventArgs) Handles moveGnam1.Tick
        Gnamm1()

    End Sub

    Private Sub moveGnam2_Tick(sender As Object, e As EventArgs) Handles moveGnam2.Tick
        Gnamm2()
    End Sub

    Private Sub moveGnam3_Tick(sender As Object, e As EventArgs) Handles moveGnam3.Tick
        Gnamm3()
    End Sub


    Private Sub Button1_LocationChanged(sender As Object, e As EventArgs) Handles Button1.LocationChanged
        If Val(Label102.Text) > 150 Then
            moveGnam3.Enabled = True
            moveGnam1.Enabled = True
            moveGnam2.Enabled = True
            Label102.Enabled = False
        End If
    End Sub



    Private Sub Button2_LocationChanged(sender As Object, e As EventArgs) Handles Button2.LocationChanged
        If collisiondeat() = True Then
            vit = vit - 1
            Button1.Left = 264
            Button1.Top = 200
            PictureBox1.Hide()
            Label107.Text = vit
            If Label107.Text = 1 Then
                PictureBox2.Hide()
            End If
            If Label107.Text = "0" Then
                PictureBox3.Hide()
                Label108.Visible = True
                PictureBox4.Visible = True
                Timer6.Enabled = True
                Button4.Image = My.Resources.ghost
                For l = 0 To 50
                    Label87.Left = Label87.Left + 1
                Next
            End If
            If Label107.Text = "-1" Then
                PictureBox4.Hide()
                moveGnam1.Enabled = False
                moveGnam2.Enabled = False
                moveGnam3.Enabled = False
                Timer6.Enabled = False
                Timer5.Enabled = False
                Button1.Enabled = False
                Button2.Enabled = False
                Button4.Enabled = False
                gnam1.Enabled = False
                gnam2.Enabled = False
                gnam3.Enabled = False
                MsgBox("DOBRZE ROZEGRANY , PUNKTY:" & score)
                Form2.Show()

            End If
        End If
    End Sub

    Private Sub INFORMACJAToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles INFORMACJAToolStripMenuItem.MouseEnter
        PictureBox5.Visible = True
    End Sub

    Private Sub INFORMACJAToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles INFORMACJAToolStripMenuItem.MouseLeave
        PictureBox5.Visible = False
    End Sub

    

    Private Sub INFORMACJAToolStripMenuItem_MouseMove(sender As Object, e As MouseEventArgs) Handles INFORMACJAToolStripMenuItem.MouseMove

    End Sub

    Private Sub HELPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HELPToolStripMenuItem.Click
        MsgBox("JEZELI TWOJ STWOREK NIE CHODZI, TO NACISNI NA NIEGO , ALBO WYLACZ DUZE LITERY", MsgBoxStyle.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        velocity = velocity + 1
    End Sub

    Private Sub ABYWYGRACToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABYWYGRACToolStripMenuItem.Click
        MsgBox("ABY WYGRAC TRZEBA WEJSC DO TRYBU 'ZYCIE EKSTRA' , ABY WEJSC TRZEBA STRACIC WSZYSTKIE ZYCIA.PO STRACENIU ZYC POJAWI SIE NOWA GWIAZDKA , ZDOBADC JA WYGRAJ!!")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        velocity = velocity - 1
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "admin" Then
            Button3.Visible = True
            Button5.Visible = True
        ElseIf TextBox1.Text = "close" Then
            Button3.Visible = False
            Button5.Visible = False
        End If
    End Sub

    Private Sub COSFAJNEGOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COSFAJNEGOToolStripMenuItem.Click
        music.Enabled = True
        music1.Enabled = False
        AxWindowsMediaPlayer2.Ctlcontrols.stop()
        AxWindowsMediaPlayer1.URL = ("C:\PACMAN RELOAD\theme1.mp3")
    End Sub

    Private Sub music_Tick(sender As Object, e As EventArgs) Handles music.Tick

        If Button6.Text = "Button6" Then
            AxWindowsMediaPlayer1.URL = ("C:\PACMAN RELOAD\theme1.mp3")
            Button6.Text = "Button7"
        ElseIf Button6.Text = "Button7" Then
            AxWindowsMediaPlayer1.URL = ("C:\PACMAN RELOAD\theme1.mp3")
            Button6.Text = "Button6"
        End If
    End Sub

    Private Sub MUZYKA1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MUZYKA1ToolStripMenuItem.Click
        music.Enabled = False
        music1.Enabled = True
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        AxWindowsMediaPlayer2.URL = ("C:\PACMAN RELOAD\theme.mp3")
    End Sub

    Private Sub music1_Tick(sender As Object, e As EventArgs) Handles music1.Tick
        If Button7.Text = "Button8" Then
            AxWindowsMediaPlayer1.URL = ("C:\PACMAN RELOAD\theme.mp3")
            Button7.Text = "Button9"
        ElseIf Button7.Text = "Button9" Then
            AxWindowsMediaPlayer1.URL = ("C:\PACMAN RELOAD\theme.mp3")
            Button7.Text = "Button8"
        End If
    End Sub
End Class

