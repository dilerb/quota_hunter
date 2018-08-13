Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Timer1.Enabled = "True" Then
            Timer1.Interval = (Int(TextBox3.Text) * 1000)
            Timer1.Enabled = False
            Timer2.Interval = (Int(TextBox3.Text) * 1000)
            Timer2.Enabled = False
            Timer3.Interval = (Int(TextBox3.Text) * 1000)
            Timer3.Enabled = False
            Timer4.Enabled = False
            Button1.Text = "BAŞLAT"
        Else
            Timer1.Enabled = True
            Timer2.Enabled = True
            Timer3.Enabled = True
            Button1.Text = "DURDUR"
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If TextBox1.Text = "" Then
            Label2.Text = "?"
            GoTo e1
        End If

        Dim Talep As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.sis.itu.edu.tr/tr/ders_programlari/LSprogramlar/prg.php?fb=" & TextBox1.Text)
        Dim Cevap As System.Net.HttpWebResponse = Talep.GetResponse()


        Dim Okuyucu As System.IO.StreamReader = New System.IO.StreamReader(Cevap.GetResponseStream())


        Dim Kaynakkodu As String = Okuyucu.ReadToEnd



        Dim sayi1
        Dim w1, w2
        Dim kont As Integer


        If TextBox2.Text = "" Then
            Label2.Text = "?"
            GoTo e1
        End If

        sayi1 = InStr(1, Kaynakkodu, TextBox2.Text)



        Kaynakkodu = Strings.Mid(Kaynakkodu, sayi1, 700)
        sayi1 = InStr(1, Kaynakkodu, "<br>")
        Kaynakkodu = Strings.Mid(Kaynakkodu, sayi1, (700 - sayi1))
        sayi1 = InStr(1, Kaynakkodu, "<a")
        Kaynakkodu = Strings.Mid(Kaynakkodu, 1, sayi1)
        sayi1 = InStr(1, Kaynakkodu, "<td>")
        Kaynakkodu = Strings.Mid(Kaynakkodu, (sayi1 + 4), (Len(Kaynakkodu) - sayi1))
        sayi1 = InStr(1, Kaynakkodu, "<td>")
        Kaynakkodu = Strings.Mid(Kaynakkodu, (sayi1 + 4), (Len(Kaynakkodu) - sayi1))
        sayi1 = InStr(1, Kaynakkodu, "<td>")
        Kaynakkodu = Strings.Mid(Kaynakkodu, (sayi1 + 4), (Len(Kaynakkodu) - sayi1))
        sayi1 = InStr(1, Kaynakkodu, "<td>")
        Kaynakkodu = Strings.Mid(Kaynakkodu, (sayi1 + 4), (Len(Kaynakkodu) - sayi1))
        sayi1 = InStr(1, Kaynakkodu, "<")
        w1 = Strings.Left(Kaynakkodu, sayi1 - 1)
        sayi1 = InStr(1, Kaynakkodu, "<td>")
        Kaynakkodu = Strings.Mid(Kaynakkodu, (sayi1 + 4), (Len(Kaynakkodu) - sayi1))
        sayi1 = InStr(1, Kaynakkodu, "<")
        w2 = Strings.Left(Kaynakkodu, sayi1 - 1)

        kont = Int(w1) - Int(w2)



        If kont > 0 Then
            Label2.Text = kont & " kişilik yer var " & "(" & w1 & "/" & w2 & ")"
            Timer4.Enabled = True

        End If

        If kont = 0 Then
            Label2.Text = "Dolu " & "(" & w1 & "/" & w2 & ")"

        End If


        If kont < 0 Then
            Label2.Text = w1 & "/" & w2 & " ..."

        End If

e1:
    End Sub

    
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If TextBox5.Text = "" Then
            Label9.Text = "?"
            GoTo e2

        End If


        Dim Talep2 As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.sis.itu.edu.tr/tr/ders_programlari/LSprogramlar/prg.php?fb=" & TextBox5.Text)
        Dim Cevap2 As System.Net.HttpWebResponse = Talep2.GetResponse()
       

        Dim Okuyucu2 As System.IO.StreamReader = New System.IO.StreamReader(Cevap2.GetResponseStream())


        Dim Kaynakkodu2 As String = Okuyucu2.ReadToEnd

        Dim sayi2
        Dim w12, w22
        Dim kont2 As Integer

        If TextBox4.Text = "" Then
            Label9.Text = "?"
            GoTo e2
        End If

        sayi2 = InStr(1, Kaynakkodu2, TextBox4.Text)

        Kaynakkodu2 = Strings.Mid(Kaynakkodu2, sayi2, 700)
        sayi2 = InStr(1, Kaynakkodu2, "<br>")
        Kaynakkodu2 = Strings.Mid(Kaynakkodu2, sayi2, (700 - sayi2))
        sayi2 = InStr(1, Kaynakkodu2, "<a")
        Kaynakkodu2 = Strings.Mid(Kaynakkodu2, 1, sayi2)
        sayi2 = InStr(1, Kaynakkodu2, "<td>")
        Kaynakkodu2 = Strings.Mid(Kaynakkodu2, (sayi2 + 4), (Len(Kaynakkodu2) - sayi2))
        sayi2 = InStr(1, Kaynakkodu2, "<td>")
        Kaynakkodu2 = Strings.Mid(Kaynakkodu2, (sayi2 + 4), (Len(Kaynakkodu2) - sayi2))
        sayi2 = InStr(1, Kaynakkodu2, "<td>")
        Kaynakkodu2 = Strings.Mid(Kaynakkodu2, (sayi2 + 4), (Len(Kaynakkodu2) - sayi2))
        sayi2 = InStr(1, Kaynakkodu2, "<td>")
        Kaynakkodu2 = Strings.Mid(Kaynakkodu2, (sayi2 + 4), (Len(Kaynakkodu2) - sayi2))
        sayi2 = InStr(1, Kaynakkodu2, "<")
        w12 = Strings.Left(Kaynakkodu2, sayi2 - 1)
        sayi2 = InStr(1, Kaynakkodu2, "<td>")
        Kaynakkodu2 = Strings.Mid(Kaynakkodu2, (sayi2 + 4), (Len(Kaynakkodu2) - sayi2))
        sayi2 = InStr(1, Kaynakkodu2, "<")
        w22 = Strings.Left(Kaynakkodu2, sayi2 - 1)

        kont2 = Int(w12) - Int(w22)


        If kont2 > 0 Then
            Label9.Text = kont2 & " kişilik yer var " & "(" & w12 & "/" & w22 & ")"
            Timer4.Enabled = True

        End If



        If kont2 = 0 Then
            Label9.Text = "Dolu " & "(" & w12 & "/" & w22 & ")"

        End If




        If kont2 < 0 Then
            Label9.Text = w12 & "/" & w22 & " ..."

        End If


e2:
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick

        If TextBox7.Text = "" Then
            Label13.Text = "?"
            GoTo e3
        End If

        Dim Talep3 As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.sis.itu.edu.tr/tr/ders_programlari/LSprogramlar/prg.php?fb=" & TextBox7.Text)
        Dim Cevap3 As System.Net.HttpWebResponse = Talep3.GetResponse()
       
        Dim Okuyucu3 As System.IO.StreamReader = New System.IO.StreamReader(Cevap3.GetResponseStream())
        
        Dim Kaynakkodu3 As String = Okuyucu3.ReadToEnd
        Dim sayi3
        Dim w13, w23
        Dim kont3 As Integer

        If TextBox6.Text = "" Then
            Label13.Text = "?"
            GoTo e3
        End If

        
        sayi3 = InStr(1, Kaynakkodu3, TextBox6.Text)

        Kaynakkodu3 = Strings.Mid(Kaynakkodu3, sayi3, 700)
        sayi3 = InStr(1, Kaynakkodu3, "<br>")
        Kaynakkodu3 = Strings.Mid(Kaynakkodu3, sayi3, (700 - sayi3))
        sayi3 = InStr(1, Kaynakkodu3, "<a")
        Kaynakkodu3 = Strings.Mid(Kaynakkodu3, 1, sayi3)
        sayi3 = InStr(1, Kaynakkodu3, "<td>")
        Kaynakkodu3 = Strings.Mid(Kaynakkodu3, (sayi3 + 4), (Len(Kaynakkodu3) - sayi3))
        sayi3 = InStr(1, Kaynakkodu3, "<td>")
        Kaynakkodu3 = Strings.Mid(Kaynakkodu3, (sayi3 + 4), (Len(Kaynakkodu3) - sayi3))
        sayi3 = InStr(1, Kaynakkodu3, "<td>")
        Kaynakkodu3 = Strings.Mid(Kaynakkodu3, (sayi3 + 4), (Len(Kaynakkodu3) - sayi3))
        sayi3 = InStr(1, Kaynakkodu3, "<td>")
        Kaynakkodu3 = Strings.Mid(Kaynakkodu3, (sayi3 + 4), (Len(Kaynakkodu3) - sayi3))
        sayi3 = InStr(1, Kaynakkodu3, "<")
        w13 = Strings.Left(Kaynakkodu3, sayi3 - 1)
        sayi3 = InStr(1, Kaynakkodu3, "<td>")
        Kaynakkodu3 = Strings.Mid(Kaynakkodu3, (sayi3 + 4), (Len(Kaynakkodu3) - sayi3))
        sayi3 = InStr(1, Kaynakkodu3, "<")
        w23 = Strings.Left(Kaynakkodu3, sayi3 - 1)

        kont3 = Int(w13) - Int(w23)

        
        If kont3 > 0 Then
            Label13.Text = kont3 & " kişilik yer var " & "(" & w13 & "/" & w23 & ")"
            Timer4.Enabled = True
        End If
            

        
        If kont3 = 0 Then

            Label13.Text = "Dolu " & "(" & w13 & "/" & w23 & ")"
        End If


        
        If kont3 < 0 Then
            Label13.Text = w13 & "/" & w23 & " ..."

        End If


e3:
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
    End Sub
End Class
