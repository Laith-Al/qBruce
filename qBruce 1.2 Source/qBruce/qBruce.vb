Imports System.Diagnostics
Imports System.Net
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.Logging


Public Class qBruce
    'Log Logic
    Private logs As New List(Of String)
    Private Sub AddLog(action As String)
        Dim timeStamp As String = DateTime.Now.ToString("HH:mm:ss")
        logs.Add(timeStamp & " | " & action)
    End Sub

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wifi_ssid_textbox.Text = GetWifiSSID()
        ip_address_textbox.Text = "172.0.0.1"

        AddLog("App Launched")
    End Sub

    ' End Of Log Logic
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
        ' Part of log logic
        AddLog("Connecting to " & url)
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

                ' Check if WiFi is disconnected
                If output.ToLower().Contains("disconnected") Then
                    Return "Not Currently Available"
                End If

                ' Loop through lines (more reliable than regex)
                For Each line As String In output.Split(Environment.NewLine)
                    Dim trimmed = line.Trim()

                    ' Match ONLY "SSID" (not BSSID)
                    If trimmed.StartsWith("SSID") AndAlso Not trimmed.StartsWith("BSSID") Then
                        Dim parts = trimmed.Split(":"c)
                        If parts.Length > 1 Then
                            Return parts(1).Trim()
                        End If
                    End If
                Next

                Return "Not Available"
            End Using

        Catch ex As Exception
            Return "Not Available"
        End Try
    End Function

    Private Sub xicon1_Click(sender As Object, e As EventArgs) Handles xicon1.Click
        Me.Close()
    End Sub
    Private Sub qBruce_1_Click(sender As Object, e As EventArgs) Handles qBruce_1.Click
        MsgBox("qBruce 1.2 Changelogs:" & vbCrLf & vbCrLf &
               "1. Added Bruce Labs Button" & vbCrLf & vbCrLf &
               "2. Made UI and design more consistent, and made the primary web display larger" & vbCrLf & vbCrLf &
               "3. Modified main UI to include logs and ready status and progress bar." & vbCrLf & vbCrLf &
               "4. Added New Section for new UI elements." & vbCrLf & vbCrLf &
               "5. Added Temporary Logging System To Application" & vbCrLf & vbCrLf &
               "6. Tweaked & Fixed Issues Reguarding Wifi SSID Detection" & vbCrLf & vbCrLf &
               "7. Modified Web Flasher" & vbCrLf & vbCrLf &
               "Software made by Laith | l.a_i_t.h" & vbCrLf & vbCrLf &
               "Thank you for choosing qBruce!", MsgBoxStyle.Exclamation, "qBruce 1.2 Changelogs")
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
        notifications_panel.ShowBalloonTip(1000, "qBruce", "qBruce version 1.2 has been successfully launched", ToolTipIcon.Info)
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
               "Thank you for choosing qBruce!", MsgBoxStyle.Information, "About qBruce 1.2")
    End Sub

    Private Sub web_flashing_Click(sender As Object, e As EventArgs) Handles web_flashing.Click
        Me.Hide()
        webflasher.Show()
        webflasher.BringToFront()
        webflasher.Activate()
        ' Part of log logic
        AddLog("Opened Web Flasher")
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

    Private Sub brucelaboratory_box_Click(sender As Object, e As EventArgs) Handles brucelaboratory_box.Click
        Me.Hide()
        brucelabs.Show()
        brucelabs.BringToFront()
        brucelabs.Activate()
        ' Part of log logic
        AddLog("Opened BruceLabs")
    End Sub

    Private Sub BruceLabsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BruceLabsToolStripMenuItem.Click
        Me.Hide()
        brucelabs.Show()
        brucelabs.BringToFront()
        brucelabs.Activate()
    End Sub

    Private Sub progression_bar_Click(sender As Object, e As EventArgs) Handles progression_bar.Click

    End Sub
    Private WithEvents progTimer As New Timer()

    Private Sub connector_NavigationStarting(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs) Handles connector.NavigationStarting
        progression_bar.Value = 0
        progression_bar.Visible = True
        progTimer.Interval = 30
        progTimer.Start()
    End Sub

    Private Sub progTimer_Tick(sender As Object, e As EventArgs) Handles progTimer.Tick
        If progression_bar.Value < 90 Then
            progression_bar.Value += 1
        End If
    End Sub

    Private Sub connector_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles connector.NavigationCompleted
        progTimer.Stop()
        progression_bar.Value = 100
        progression_bar.Visible = False

        ' Update dynamic_box based on success
        If e.IsSuccess Then
            dynamic_box.Image = My.Resources.ready_round   ' WebView2 loaded successfully
        Else
            dynamic_box.Image = My.Resources.error_round_final   ' Failed to load
        End If

        ' Part of log logic aswell
        If e.IsSuccess Then
            AddLog("Loaded successfully")
        Else
            AddLog("Failed to load page")
        End If


    End Sub

    Private Sub logs_picture_Click(sender As Object, e As EventArgs) Handles logs_picture.Click
        Dim logForm As New Form()

        ' Title
        logForm.Text = "Logs"

        ' Size
        logForm.Size = New Size(500, 400)

        ' Center on screen
        logForm.StartPosition = FormStartPosition.CenterScreen

        ' Fixed tool window
        logForm.FormBorderStyle = FormBorderStyle.FixedToolWindow

        ' Background
        logForm.BackColor = Color.White

        ' Put Future Logo Here:

        ' Textbox
        Dim txt As New TextBox()
        txt.Multiline = True
        txt.Dock = DockStyle.Fill
        txt.ReadOnly = True
        txt.ScrollBars = ScrollBars.Vertical

        txt.Text = String.Join(Environment.NewLine, logs)

        logForm.Controls.Add(txt)

        logForm.Show()
    End Sub

    Private Sub dynamic_box_Click(sender As Object, e As EventArgs) Handles dynamic_box.Click

    End Sub
End Class