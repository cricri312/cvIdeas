Imports System
Imports System.Diagnostics
Imports Emgu.CV.Structure
Imports Emgu.CV
Imports Emgu.CV.CvEnum
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.ComponentModel
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports MySql.Data.MySqlClient


Public Class Form1
    'Deklaracja zmienneych
    Dim czcionka As New MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5D, 0.6D)
    Dim punktyTwarzy As HaarCascade
    Dim aktualnRamka As Image(Of Bgr, Byte)
    Dim camera As Capture
    Dim result As Image(Of Gray, Byte)
    Dim nauczoneTwarze As Image(Of Gray, Byte) = Nothing
    Dim szareTwarze As Image(Of Gray, Byte) = Nothing
    Dim obrazyNauczenia As List(Of Image(Of Gray, Byte)) = New List(Of Image(Of Gray, Byte))()
    Dim labele As List(Of String) = New List(Of String)()
    Dim ludzieKto As List(Of String) = New List(Of String)()
    Dim ile As Integer
    Dim numerLabelu As Integer
    Dim pomocznica As Integer
    Dim imiona As String = Nothing
    Dim imie As String
    Dim polaczenie As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Public Sub New()

        InitializeComponent()
        polaczenie = New MySqlConnection("datasource=remotemysql.com;port=3306;username=UaYfyT79pG;password=Q3unPYSWy5")
        TextBox1.Enabled = False
        Button2.Enabled = False
        'Asocjacia pliku xml do obiektu haarcascade ktory prosto muwiac okresla punkty twarzy
        punktyTwarzy = New HaarCascade("haarcascade_frontalface_default.xml")
        'Uzywamy blok try do wykrycia bledow
        Try
            'Ladowanie imion
            Dim labelInfo As String
            labelInfo = File.ReadAllText(Application.StartupPath + "/Database/imiona.txt")
            Dim Labels As String()
            Labels = labelInfo.Split(",")

            numerLabelu = Convert.ToInt16(Labels(0))
            ile = numerLabelu
            'Ladownaie obrazow 
            Dim dodajTwarz As String
            For i As Integer = 1 To numerLabelu
                dodajTwarz = "twarz" & i & ".bmp"
                obrazyNauczenia.Add(New Image(Of Gray, Byte)(Application.StartupPath + "/Database/" & dodajTwarz))
                labele.Add(Labels(i))
            Next

        Catch ex As Exception
            'W razie koniecznosci jezeli nie jes spelniony zaden z warunkow to wysyla komunikat
            MessageBox.Show("Nic nie ma w mojej Bazie Danych", "Wrzuc cos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    'Drugi przycisk czyli zapisuje zdjecie
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ile = ile + 1
        szareTwarze = camera.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)
        Dim znalezioneTwarze As MCvAvgComp()() = szareTwarze.DetectHaarCascade(punktyTwarzy, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, New Size(20, 20))

        For Each f As MCvAvgComp In znalezioneTwarze(0)
            nauczoneTwarze = aktualnRamka.Copy(f.rect).Convert(Of Gray, Byte)
            Exit For
        Next

        nauczoneTwarze = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)
        obrazyNauczenia.Add(nauczoneTwarze)
        labele.Add(TextBox1.Text)
        File.WriteAllText(Application.StartupPath + "/Database/imiona.txt", obrazyNauczenia.ToArray().Length.ToString() & ",")

        For i As Integer = 1 To obrazyNauczenia.ToArray().Length
            obrazyNauczenia.ToArray()(i - 1).Save(Application.StartupPath + "/Database/twarz" & i & ".bmp")
            File.AppendAllText(Application.StartupPath + "/Database/imiona.txt", labele.ToArray()(i - 1) + ",")

        Next
        'polaczenie.Open()
        command = New MySqlCommand("INSERT INTO `UaYfyT79pG`.`XD`(`name`) VALUES (@xd)", polaczenie)
        command.Parameters.Add("@xd", MySqlDbType.VarChar).Value = TextBox1.Text
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("goood")
            polaczenie.Close()
            polaczenie.Open()
        End If
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        polaczenie.Open()
        camera = New Capture()
        camera.QueryFrame()
        Timer1.Start()
        TextBox1.Enabled = True
        Button2.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ludzieKto.Add("")

        aktualnRamka = camera.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)

        szareTwarze = aktualnRamka.Convert(Of Gray, Byte)()

        Dim znalezioneTwarzeTeraz As MCvAvgComp()() = szareTwarze.DetectHaarCascade(punktyTwarzy, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, New Size(20, 20))

        For Each f As MCvAvgComp In znalezioneTwarzeTeraz(0)
            pomocznica = pomocznica + 1
            result = aktualnRamka.Copy(f.rect).Convert(Of Gray, Byte)().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)
            aktualnRamka.Draw(f.rect, New Bgr(Color.Green), 3)

            If obrazyNauczenia.ToArray().Length <> 0 Then
                Dim termCriterias As New MCvTermCriteria(ile, 0.001)
                Dim recognizer As New EigenObjectRecognizer(obrazyNauczenia.ToArray(), labele.ToArray(), 3000, termCriterias)
                imie = recognizer.Recognize(result)
                aktualnRamka.Draw(imie, czcionka, New Point(f.rect.X - 2, f.rect.Y - 2), New Bgr(Color.LightGreen))
                'SQL ZAPYTANIA I KOD

                If imie = "cristian" Then
                    command = New MySqlCommand("UPDATE `UaYfyT79pG`.`Status` SET `status` = '1' WHERE `ID` = 4", polaczenie)

                    If command.ExecuteNonQuery() = 1 Then

                        polaczenie.Close()
                        polaczenie.Open()
                    End If
                ElseIf imie <> "cristian" Then
                    command = New MySqlCommand("UPDATE `UaYfyT79pG`.`Status` SET `status` = '0' WHERE `ID` = 4", polaczenie)

                    If command.ExecuteNonQuery() = 1 Then

                        polaczenie.Close()
                        polaczenie.Open()
                    End If

                End If


                'KONIEC SZALENCZEJ TWORCZOSCI

            End If
                ludzieKto(pomocznica - 1) = imie
            ludzieKto.Add("")
        Next
        pomocznica = 0
        For nnn As Integer = 0 To znalezioneTwarzeTeraz(0).Length - 1
            imiona = imiona + ludzieKto(nnn) + ", "
        Next
        ImageBox1.Image = aktualnRamka
        imiona = ""
        ludzieKto.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class