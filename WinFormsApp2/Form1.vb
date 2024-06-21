Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim view_google_form As New view_google_form()
        view_google_form.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim submit_google_form As New submit_google_form()
        submit_google_form.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackColor = Color.Yellow
        Button1.ForeColor = Color.Black

        Button2.BackColor = Color.LightBlue
        Button2.ForeColor = Color.DarkBlue
    End Sub
End Class
