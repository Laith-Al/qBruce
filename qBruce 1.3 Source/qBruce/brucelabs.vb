Imports System.Runtime.InteropServices

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

    <DllImport("user32.dll")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll")>
    Private Shared Sub SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub lab_top_panel_MouseDown(sender As Object, e As MouseEventArgs) Handles lab_top_panel.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub
    ' end of form movment logic
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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles lab_top_panel.Paint

    End Sub
End Class