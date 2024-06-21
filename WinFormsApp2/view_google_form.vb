Imports System.Net.Http
Imports Newtonsoft.Json

Public Class view_google_form
    Private currentIndex As Integer = 0
    Private submissions As List(Of Dictionary(Of String, String))

    Private Async Sub view_google_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.BackColor = Color.Yellow
        Button1.ForeColor = Color.Black

        Button2.BackColor = Color.LightBlue
        Button2.ForeColor = Color.DarkBlue

        Await FetchSubmissions()
    End Sub

    Private Async Function FetchSubmissions() As Task
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/read")
                If response.IsSuccessStatusCode Then
                    Dim jsondata As String = Await response.Content.ReadAsStringAsync()
                    submissions = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(jsondata)
                    If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
                        Await FetchSubmission(0)
                    Else
                        MessageBox.Show("No submissions found.")
                    End If
                Else
                    MessageBox.Show("Failed to fetch submissions")
                End If
            End Using
        Catch ex As HttpRequestException
            MessageBox.Show($"Request error: {ex.Message}")
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Function

    Private Async Function FetchSubmission(index As Integer) As Task
        If submissions IsNot Nothing AndAlso index >= 0 AndAlso index < submissions.Count Then
            Dim data As Dictionary(Of String, String) = submissions(index)
            TextBox4.Text = data("name")
            TextBox3.Text = data("email")
            TextBox2.Text = data("phone")
            TextBox1.Text = data("github")
            TextBox5.Text = data("stopwatch")
        End If
    End Function

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await FetchSubmission(currentIndex)
        Else
            MessageBox.Show("No more submissions.")
        End If
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            Await FetchSubmission(currentIndex)
        Else
            MessageBox.Show("Already at the last submission.")
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim email As String = TextBox6.Text
        Await SearchDataSync(email)
    End Sub

    Private Async Function SearchDataSync(email As String) As Task
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/search?email={email}")
                If response.IsSuccessStatusCode Then
                    Dim responseData As String = Await response.Content.ReadAsStringAsync()
                    submissions = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(responseData)
                    If submissions.Count > 0 Then
                        currentIndex = 0
                        FetchSubmission(currentIndex)
                    Else
                        MessageBox.Show("No submissions found for the provided email.")
                    End If
                Else
                    MessageBox.Show("Failed to search data.")
                End If
            End Using
        Catch ex As HttpRequestException
            MessageBox.Show($"Request error: {ex.Message}")
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Function

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Async Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If submissions IsNot Nothing AndAlso submissions.Count > 0 AndAlso currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Delete", MessageBoxButtons.YesNo)
            If confirmResult = DialogResult.Yes Then
                Await DeleteSubmissionAsync(currentIndex)
                Close()
            End If
        End If
    End Sub

    Private Async Function DeleteSubmissionAsync(index As Integer) As Task
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/delete/{index}")
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("form Deleted Successfully")
                    submissions.RemoveAt(currentIndex)
                    If submissions.Count > 0 Then
                        If currentIndex >= submissions.Count Then
                            currentIndex = submissions.Count - 1
                            FetchSubmission(index)

                        End If
                    End If
                Else
                    MessageBox.Show("Failed to delete submission.")

                End If

            End Using

        Catch ex As HttpRequestException
            MessageBox.Show($"Request error: {ex.Message}")
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")

        End Try


    End Function
End Class