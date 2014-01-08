Public Class Form1
    Dim x, y As Decimal
    Dim ris As Single

    Private Sub Somma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Somma.Click
        ' Caricamento
        x = CDec(TextBox1.Text)
        y = CDec(TextBox2.Text)
        ris = x + y
        'textbox3.text=cstr(ris)
        MessageBox.Show(CStr(ris), "Risultato della somma", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Dividi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dividi.Click
        Try
            x = CDec(TextBox1.Text)
            y = CDec(TextBox2.Text)
            ris = x / y
            MessageBox.Show(CStr(ris), "Risultato della divisione", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Intercetta l'errore nel caso in cui il valore di y sia nullo
            'Catch ex As Exception When y = 0
        Catch ex As DivideByZeroException
            Beep()
            ' Visualizza il messaggio d'errore
            MessageBox.Show("Errore: Tentativo di divisione per 0.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As InvalidCastException
            Beep()
            ' Visualizza il messaggio d'errore
            MessageBox.Show("Errore: Non hai inserito valori numerici.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Beep()
            ' Visualizza il messaggio d'errore
            MessageBox.Show("Errore!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Beep()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub
End Class
