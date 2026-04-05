Public Class brucelabs

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

    Private Sub brucelabs_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        qBruce.Show()
    End Sub

    Private Sub laboratory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        laboratory.Source = New Uri("https://bruce.computer/my_bruce")
    End Sub
    Private Sub laboratory_Click(sender As Object, e As EventArgs) Handles laboratory.Click

    End Sub

    Private Sub xiconlab_Click(sender As Object, e As EventArgs) Handles xiconlab.Click
        Me.Close()
    End Sub
End Class