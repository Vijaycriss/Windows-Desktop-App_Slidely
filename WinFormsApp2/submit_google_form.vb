Imports System.Drawing.Text
Imports System.Net.Http
Imports System.Runtime.CompilerServices
Imports System.Text
Imports Newtonsoft.Json

Public Class submit_google_form

    Private isSubmitting As Boolean = False
    Private stopwatch As New Stopwatch()
    Dim ss, tt, vv As Integer

    Private Sub submit_google_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.BackColor = Color.LightBlue
        Button1.ForeColor = Color.DarkBlue

        Button2.BackColor = Color.Yellow
        Button2.ForeColor = Color.Black

        ' Initialize timer settings
        Timer1.Interval = 1000
        Timer1.Enabled = False
        Label1.Text = "00:00:00"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If isSubmitting Then Return
        isSubmitting = True

        Dim data As New Dictionary(Of String, String) From {
            {"name", TextBox4.Text},
            {"email", TextBox3.Text},
            {"phone", TextBox2.Text},
            {"github", TextBox1.Text},
            {"stopwatch", Label1.Text}
            }

        Dim jsonData As String = JsonConvert.SerializeObject(data)
        Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")

        PostDataAsync("http://localhost:3000/submit", content)

    End Sub

    Private Async Sub PostDataAsync(url As String, content As StringContent)
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.PostAsync(url, content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Data submitted successfully")

                Else
                    Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                    MessageBox.Show($"Failed to submit data. Status code: {response.StatusCode}, Response: {responseContent}")
                End If
            End Using
        Catch ex As HttpRequestException
            MessageBox.Show($"Request error: {ex.Message}")
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        Finally
            isSubmitting = False
        End Try
    End Sub


    Private Sub button2_click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = True
        'If stopwatch.IsRunning Then
        'stopwatch.Stop()
        'Button2.Text = "Resume"
        'Else
        'stopwatch.Start()
        'Button2.Text = "Pause"
        'End If
        'Timer1.Enabled = stopwatch.IsRunning

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = String.Format("{0:00}:{1:00}:{2:00}", ss, tt, vv)
        vv = vv + 1
        If vv > 59 Then
            vv = 0
            tt = tt + 1
        End If
        If tt = 2 Then
            vv = 0
            tt = 0
            Label1.Text = "00:00:00"
            Timer1.Enabled = False
            MessageBox.Show("Time Ended")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class