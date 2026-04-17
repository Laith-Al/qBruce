Imports System.Diagnostics
Imports System.Net
Imports System.Runtime.InteropServices

Public Class QBruce

    ' VARIABLES
    Private logs As New List(Of String)
    Private secondForm As New webflasher()
    Private WithEvents ProgTimer As New Timer()

    ' LOG SYSTEM
    Private Sub AddLog(action As String)
        Dim timeStamp As String = DateTime.Now.ToString("HH:mm:ss")
        logs.Add(timeStamp & " | " & action)
    End Sub

    ' FORM DRAGGING
    <DllImport("user32.dll")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll")>
    Private Shared Sub SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub TopPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles top_panel.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    ' FORM LOAD
    Private Sub QBruce_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wifi_ssid_textbox.Text = GetWifiSSID()
        ip_address_textbox.Text = "172.0.0.1"

        notifications_panel.ShowBalloonTip(1000, "qBruce Launched!", "qBruce version 1.3 has been successfully launched", ToolTipIcon.None)

        UpdateMemoryLabel()
        AddLog("App Launched")
    End Sub


    ' CONNECTION LOGIC
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
        SaveDomain(url)
        AddLog("Connecting to " & url)
    End Sub

    Private Function GetValidUrl(input As String) As String
        Dim defaultIp As String = "172.0.0.1"

        If String.IsNullOrWhiteSpace(input) Then
            Return "http://" & defaultIp
        End If

        Dim working As String = input.Trim()
        Dim noProtocol As String = working.ToLower()

        If noProtocol.StartsWith("http://") Then
            noProtocol = noProtocol.Substring(7)
        ElseIf noProtocol.StartsWith("https://") Then
            noProtocol = noProtocol.Substring(8)
        End If

        noProtocol = noProtocol.TrimEnd("/"c)

        If noProtocol = "bruce.computer" OrElse noProtocol = "bruce.local" Then
            If working.StartsWith("http://") OrElse working.StartsWith("https://") Then
                Return working
            Else
                Return "http://" & noProtocol
            End If
        End If

        Dim ip As IPAddress = Nothing
        If IPAddress.TryParse(noProtocol, ip) Then
            If working.StartsWith("http://") OrElse working.StartsWith("https://") Then
                Return working
            Else
                Return "http://" & noProtocol
            End If
        End If

        Return Nothing
    End Function

    ' WIFI SSID
    Private Function GetWifiSSID() As String
        Try
            Dim psi As New ProcessStartInfo With {
                .FileName = "netsh",
                .Arguments = "wlan show interfaces",
                .RedirectStandardOutput = True,
                .UseShellExecute = False,
                .CreateNoWindow = True
            }

            Using proc As Process = Process.Start(psi)
                Dim output As String = proc.StandardOutput.ReadToEnd()
                proc.WaitForExit()

                If output.ToLower().Contains("disconnected") Then
                    Return "Not Currently Available"
                End If

                For Each line As String In output.Split(Environment.NewLine)
                    Dim trimmed = line.Trim()

                    If trimmed.StartsWith("SSID") AndAlso Not trimmed.StartsWith("BSSID") Then
                        Dim parts = trimmed.Split(":"c)
                        If parts.Length > 1 Then
                            Return parts(1).Trim()
                        End If
                    End If
                Next

                Return "Not Available"
            End Using

        Catch
            Return "Not Available"
        End Try
    End Function

    ' MEMORY SYSTEM
    Private Sub UpdateMemoryLabel()
        Dim domains As New List(Of String)

        If Not String.IsNullOrWhiteSpace(My.Settings.LastDomains) Then
            domains = My.Settings.LastDomains.Split("|"c).ToList()
        End If

        While domains.Count < 3
            domains.Add("N/A")
        End While

        memory_label.Text =
            "1. " & domains(0) & vbCrLf &
            "2. " & domains(1) & vbCrLf &
            "3. " & domains(2)
    End Sub

    Private Sub SaveDomain(url As String)
        Dim uri As New Uri(url)
        Dim domain As String = uri.Host

        Dim domains As New List(Of String)

        If Not String.IsNullOrWhiteSpace(My.Settings.LastDomains) Then
            domains = My.Settings.LastDomains.Split("|"c).ToList()
        End If

        domains.Remove(domain)
        domains.Insert(0, domain)

        If domains.Count > 3 Then
            domains = domains.Take(3).ToList()
        End If

        My.Settings.LastDomains = String.Join("|", domains)
        My.Settings.Save()

        UpdateMemoryLabel()
    End Sub

    ' UI EVENTS
    Private Sub ConnectBox_Click(sender As Object, e As EventArgs) Handles connect_box.Click
        ConnectToTarget()
    End Sub

    Private Sub IpAddressTextbox_KeyDown(sender As Object, e As KeyEventArgs) Handles ip_address_textbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ConnectToTarget()
        End If
    End Sub

    Private Sub XIcon1_Click(sender As Object, e As EventArgs) Handles xicon1.Click
        Me.Close()
    End Sub

    Private Sub QBruceTitle_Click(sender As Object, e As EventArgs) Handles qBruce_1.Click
        MsgBox("qBruce Version 1.3 Changes:" & vbCrLf & vbCrLf &
               "1. Changes to app UI, including font change for UI buttons" & vbCrLf & vbCrLf &
               "2. Cleaned up code" & vbCrLf & vbCrLf &
               "3. Improved performance and stability" & vbCrLf & vbCrLf &
               "3. Optimised app & added some QOL features" & vbCrLf & vbCrLf &
               "Software made by Laith Alshara | l.a_i_t.h", MsgBoxStyle.Information, "qBruce 1.3")

    End Sub

    Private Sub InfoButton_Click(sender As Object, e As EventArgs) Handles info_button.Click
        MsgBox("qBruce is a tool to help you connect to your Bruce device using the WebUI or BruceLabs feature, it also allows you it flash it with the latest firmware. It is designed to be simple and user-friendly, so you can get your device up and running in no time!" & vbCrLf & vbCrLf & "To use qBruce, simply connect your computer to the same Wi-Fi network as your Bruce device, and enter the IP address / Domain of your device in the Textbox. Then click the 'Connect' button to access the web interface of your Bruce device." & vbCrLf & vbCrLf & "From there, you can easily flash the latest firmware, manage your device settings, and more!" & vbCrLf & vbCrLf & "Software made by Laith Alshara | l.a_i_t.h" & vbCrLf & vbCrLf & "Thank you for choosing qBruce!", MsgBoxStyle.Information, "About qBruce 1.3")
    End Sub

    Private Sub WebFlashing_Click(sender As Object, e As EventArgs) Handles web_flashing.Click
        Me.Hide()
        webflasher.Show()
        webflasher.BringToFront()
        webflasher.Activate()
        AddLog("Opened Web Flasher")
    End Sub

    Private Sub BruceLaboratoryBox_Click(sender As Object, e As EventArgs) Handles brucelaboratory_box.Click
        Me.Hide()
        brucelabs.Show()
        brucelabs.BringToFront()
        brucelabs.Activate()
        AddLog("Opened BruceLabs")
    End Sub

    ' WEBVIEW EVENTS
    Private Sub Connector_NavigationStarting(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs) Handles connector.NavigationStarting
        progression_bar.Value = 0
        progression_bar.Visible = True
        ProgTimer.Interval = 30
        ProgTimer.Start()
    End Sub

    Private Sub ProgTimer_Tick(sender As Object, e As EventArgs) Handles ProgTimer.Tick
        If progression_bar.Value < 90 Then
            progression_bar.Value += 1
        End If
    End Sub

    Private Sub Connector_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles connector.NavigationCompleted
        ProgTimer.Stop()
        progression_bar.Value = 100
        progression_bar.Visible = False

        If e.IsSuccess Then
            dynamic_box.Image = My.Resources.ready_round
            AddLog("Loaded successfully")
        Else
            dynamic_box.Image = My.Resources.error_round_final
            AddLog("Failed to load page")
        End If
    End Sub
    ' LOG WINDOW
    Private Sub LogsPicture_Click(sender As Object, e As EventArgs) Handles logs_picture.Click
        Dim logForm As New Form With {
            .Text = "qBruce Logs:",
            .Size = New Size(500, 400),
            .StartPosition = FormStartPosition.CenterScreen,
            .FormBorderStyle = FormBorderStyle.FixedToolWindow,
            .BackColor = Color.White,
            .Icon = Me.Icon,
            .ShowInTaskbar = False
        }

        Dim txt As New TextBox With {
            .Multiline = True,
            .Dock = DockStyle.Fill,
            .ReadOnly = True,
            .ScrollBars = ScrollBars.Vertical,
            .Text = String.Join(Environment.NewLine, logs)
        }

        logForm.Controls.Add(txt)
        logForm.Show()
    End Sub
End Class