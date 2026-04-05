Public Class webflasher
    Private Function IsAllowedDomain(url As String) As Boolean
        Try
            Dim uri As New Uri(url)
            Dim host As String = uri.Host.ToLower()

            ' Allow bruce.computer and any subdomain (*.bruce.computer)
            If host = "bruce.computer" OrElse host.EndsWith(".bruce.computer") Then
                Return True
            End If

            Return False
        Catch
            Return False
        End Try
    End Function
    Private Sub webflasher_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        qBruce.Show()
    End Sub
    Private Sub webflasher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        webflasher_web.Source = New Uri("https://bruce.computer/flasher")
    End Sub
    Private Sub webflasher_web_NavigationStarting(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs) Handles webflasher_web.NavigationStarting
        If Not IsAllowedDomain(e.Uri) Then
            e.Cancel = True
            MessageBox.Show("You're not allowed to go there!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class