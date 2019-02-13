Public Class Form1

    Dim OG As Single
    Dim UG As Single
    Dim Zwischen As Single
    Dim Rechnung As String
    Dim Schritt As Single
    Dim Ohne As Single
    Dim comp As String
    Dim gerad As Single

    Private Sub cmdErgebnis_Click(sender As Object, e As EventArgs) Handles cmdErgebnis.Click

        OG = txtOG.Text
        UG = txtUG.Text
        Schritt = txtSchritt.Text
        If Ohne! = "" Then
            Ohne = txtOhne.Text
        End If

        If UG >= OG Then
            MsgBox("ERROR")
            txtOG.Clear()
            txtUG.Clear()
        Else

            Rechnung = UG

            Do While UG < OG




                UG = UG + Schritt
                comp = InStr(CStr(UG), CStr(Ohne))

                If comp = 0 Then
                    Zwischen = Zwischen + UG
                    Rechnung = Rechnung & "+" & UG
                End If

            Loop


            MsgBox(Zwischen)
            lblUebersicht.Text = Rechnung
        End If



    End Sub

    Private Sub cmdGeradeZ_Click(sender As Object, e As EventArgs) Handles cmdGeradeZ.Click

        OG = txtOG.Text
        UG = txtUG.Text
        Schritt = txtSchritt.Text

        If UG >= OG Then
            MsgBox("ERROR")
            txtOG.Clear()
            txtUG.Clear()
        Else

            Rechnung = UG

            Do While UG < OG

                UG = UG + Schritt
                gerad = UG Mod 2

                If gerad = 0 Then
                    Zwischen = Zwischen + UG
                    Rechnung = Rechnung & "+" & UG
                End If
            Loop

            MsgBox(Zwischen)
            lblUebersicht.Text = Rechnung
        End If

    End Sub

End Class
