Imports System.Text.RegularExpressions
Imports System.Diagnostics
Imports System.Net


Public Class qBruce
    Private secondForm As New webflasher() ' Pre-load the form

    Private Sub ConnectToTarget()
        If String.IsNullOrWhiteSpace(ip_address_textbox.Text) Then
            ip_address_textbox.Text = "172.0.0.1"
        End If

        Dim url As String = GetValidUrl(ip_address_textbox.Text)

        If url Is Nothing Then
            MessageBox.Show("Error: Action Not Supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        connector.Source = New Uri(url)
    End Sub

    Private Function GetValidUrl(input As String) As String
        Dim defaultIp As String = "172.0.0.1"

        If String.IsNullOrWhiteSpace(input) Then
            Return "http://" & defaultIp
        End If

        Dim working As String = input.Trim()

        ' Remove protocol if present for validation
        Dim noProtocol As String = working.ToLower()
        If noProtocol.StartsWith("http://") Then
            noProtocol = noProtocol.Substring(7)
        ElseIf noProtocol.StartsWith("https://") Then
            noProtocol = noProtocol.Substring(8)
        End If

        ' Remove trailing slash if any
        noProtocol = noProtocol.TrimEnd("/"c)

        ' Check allowed domains
        If noProtocol = "bruce.computer" OrElse noProtocol = "bruce.local" Then
            ' Return original if already has protocol, otherwise add http
            If working.StartsWith("http://") OrElse working.StartsWith("https://") Then
                Return working
            Else
                Return "http://" & noProtocol
            End If
        End If

        ' Check if valid IP
        Dim ip As IPAddress = Nothing
        If IPAddress.TryParse(noProtocol, ip) Then
            If working.StartsWith("http://") OrElse working.StartsWith("https://") Then
                Return working
            Else
                Return "http://" & noProtocol
            End If
        End If

        ' Invalid
        Return Nothing
    End Function
    Private Function GetWifiSSID() As String
        Try
            Dim psi As New ProcessStartInfo
            psi.FileName = "netsh"
            psi.Arguments = "wlan show interfaces"
            psi.RedirectStandardOutput = True
            psi.UseShellExecute = False
            psi.CreateNoWindow = True

            Using proc As Process = Process.Start(psi)
                Dim output As String = proc.StandardOutput.ReadToEnd()
                proc.WaitForExit()

                ' Check if WiFi interface exists
                If Not output.Contains("SSID") Then
                    Return "Not Available"
                End If

                ' Match SSID line (but ignore BSSID)
                Dim match As Match = Regex.Match(output, "^\s*SSID\s*:\s*(.+)$", RegexOptions.Multiline)

                If match.Success Then
                    Dim ssid As String = match.Groups(1).Value.Trim()

                    If ssid = "" Then
                        Return "No Wifi"
                    End If

                    Return ssid
                Else
                    ' If interface exists but not connected
                    If output.Contains("State") AndAlso output.Contains("disconnected") Then
                        Return "No Wifi"
                    End If

                    Return "Not Available / Not Applicable"
                End If
            End Using

        Catch ex As Exception
            Return "Not Available"
        End Try
    End Function

    Private Sub xicon1_Click(sender As Object, e As EventArgs) Handles xicon1.Click
        Me.Close()
    End Sub
    Private Sub qBruce_1_Click(sender As Object, e As EventArgs) Handles qBruce_1.Click
        MsgBox("qBruce 1.1 Changelogs:" & vbCrLf & vbCrLf &
               "1. Allow user to use enter key instead of connect button" & vbCrLf & vbCrLf &
               "2. Made UI and design more consistent, aswell as making the main form bigger" & vbCrLf & vbCrLf &
               "3. Added Notifications to app" & vbCrLf & vbCrLf &
               "4. Fixed Bugs & Added Taskbar Mini Icon" & vbCrLf & vbCrLf &
               "5. Fixed Web Flasher & Resized it" & vbCrLf & vbCrLf &
               "Software made by Laith | l.a_i_t.h" & vbCrLf & vbCrLf &
               "Thank you for choosing qBruce!", MsgBoxStyle.Exclamation, "qBruce 1.1 Changelogs")
    End Sub

    Private Sub connect_panel_Paint(sender As Object, e As PaintEventArgs) Handles connect_panel.Paint

    End Sub

    Private Sub UI_Panel_Paint(sender As Object, e As PaintEventArgs) Handles UI_Panel.Paint

    End Sub

    Private Sub wifilable_Click(sender As Object, e As EventArgs) Handles wifilable.Click

    End Sub

    Private Sub ip_addresser_Click(sender As Object, e As EventArgs) Handles ip_addresser.Click

    End Sub

    Private Sub ip_address_textbox_TextChanged(sender As Object, e As EventArgs) Handles ip_address_textbox.TextChanged

    End Sub
    Private Sub qBruce_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wifi_ssid_textbox.Text = GetWifiSSID()
        ip_address_textbox.Text = "172.0.0.1"
        notifications_panel.ShowBalloonTip(1000, "qBruce", "qBruce version 1.1 has been successfully launched", ToolTipIcon.Info)
    End Sub
    Private Sub connect_box_Click(sender As Object, e As EventArgs) Handles connect_box.Click
        ' If empty → reset textbox to default
        If String.IsNullOrWhiteSpace(ip_address_textbox.Text) Then
            ip_address_textbox.Text = "172.0.0.1"
        End If

        Dim url As String = GetValidUrl(ip_address_textbox.Text)

        If url Is Nothing Then
            MessageBox.Show("Error: Action Not Supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        connector.Source = New Uri(url)
        ConnectToTarget()
    End Sub

    Private Sub connector_Click(sender As Object, e As EventArgs) Handles connector.Click

    End Sub
    
    Private Sub info_button_Click(sender As Object, e As EventArgs) Handles info_button.Click
        MsgBox("qBruce is a tool to help you connect to your Bruce device using the WebUI feature, it also allows you it flash it with the latest firmware. It is designed to be simple and user-friendly, so you can get your device up and running in no time!" & vbCrLf & vbCrLf &
               "To use qBruce, simply connect your computer to the same Wi-Fi network as your Bruce device, and enter the IP address / Domain of your device in the Textbox. Then click the 'Connect' button to access the web interface of your Bruce device." & vbCrLf & vbCrLf &
               "From there, you can easily flash the latest firmware, manage your device settings, and more!" & vbCrLf & vbCrLf &
               "Software made by Laith Alshara | l.a_i_t.h" & vbCrLf & vbCrLf &
               "Thank you for choosing qBruce!", MsgBoxStyle.Information, "About qBruce 1.1")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        webflasher.Show()
        webflasher.BringToFront()
        webflasher.Activate()
    End Sub

    Private Sub AdvertismentBox_Click(sender As Object, e As EventArgs) Handles advertisment_box.Click

    End Sub


    Private Sub notifications_panel_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles notifications_panel.MouseDoubleClick

    End Sub
    Private Sub ip_address_textbox_KeyDown(sender As Object, e As KeyEventArgs) Handles ip_address_textbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' prevents beep sound
            connect_box_Click(sender, EventArgs.Empty)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub WebFlasherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebFlasherToolStripMenuItem.Click
        Me.Hide()
        webflasher.Show()
        webflasher.BringToFront()
        webflasher.Activate()
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
    End Sub
End Class