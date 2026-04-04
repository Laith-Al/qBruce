<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class qBruce
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(qBruce))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.info_button = New System.Windows.Forms.PictureBox()
        Me.qBruce_1 = New System.Windows.Forms.Label()
        Me.xicon1 = New System.Windows.Forms.PictureBox()
        Me.connect_panel = New System.Windows.Forms.Panel()
        Me.connector = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.UI_Panel = New System.Windows.Forms.Panel()
        Me.advertisment_box = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.wifi_ssid_textbox = New System.Windows.Forms.TextBox()
        Me.ip_address_textbox = New System.Windows.Forms.TextBox()
        Me.ip_addresser = New System.Windows.Forms.Label()
        Me.wifilable = New System.Windows.Forms.Label()
        Me.connect_box = New System.Windows.Forms.PictureBox()
        Me.notifications_panel = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Context_Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebFlasherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.info_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xicon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.connect_panel.SuspendLayout()
        CType(Me.connector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_Panel.SuspendLayout()
        CType(Me.advertisment_box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.connect_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Context_Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.info_button)
        Me.Panel1.Controls.Add(Me.qBruce_1)
        Me.Panel1.Controls.Add(Me.xicon1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(865, 27)
        Me.Panel1.TabIndex = 0
        '
        'info_button
        '
        Me.info_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.info_button.Image = Global.qBruce.My.Resources.Resources.info1
        Me.info_button.Location = New System.Drawing.Point(820, 3)
        Me.info_button.Name = "info_button"
        Me.info_button.Size = New System.Drawing.Size(19, 18)
        Me.info_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.info_button.TabIndex = 1
        Me.info_button.TabStop = False
        '
        'qBruce_1
        '
        Me.qBruce_1.AutoSize = True
        Me.qBruce_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.qBruce_1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qBruce_1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.qBruce_1.Location = New System.Drawing.Point(3, 3)
        Me.qBruce_1.Name = "qBruce_1"
        Me.qBruce_1.Size = New System.Drawing.Size(118, 23)
        Me.qBruce_1.TabIndex = 1
        Me.qBruce_1.Text = "qBruce - 1.1"
        '
        'xicon1
        '
        Me.xicon1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.xicon1.Image = Global.qBruce.My.Resources.Resources.x_icon
        Me.xicon1.Location = New System.Drawing.Point(845, 3)
        Me.xicon1.Name = "xicon1"
        Me.xicon1.Size = New System.Drawing.Size(17, 18)
        Me.xicon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.xicon1.TabIndex = 0
        Me.xicon1.TabStop = False
        '
        'connect_panel
        '
        Me.connect_panel.BackColor = System.Drawing.Color.Black
        Me.connect_panel.Controls.Add(Me.connector)
        Me.connect_panel.Location = New System.Drawing.Point(288, 33)
        Me.connect_panel.Name = "connect_panel"
        Me.connect_panel.Size = New System.Drawing.Size(567, 451)
        Me.connect_panel.TabIndex = 1
        '
        'connector
        '
        Me.connector.AllowExternalDrop = True
        Me.connector.CreationProperties = Nothing
        Me.connector.DefaultBackgroundColor = System.Drawing.Color.White
        Me.connector.Location = New System.Drawing.Point(3, 3)
        Me.connector.Name = "connector"
        Me.connector.Size = New System.Drawing.Size(561, 445)
        Me.connector.Source = New System.Uri("http://172.0.0.1/", System.UriKind.Absolute)
        Me.connector.TabIndex = 0
        Me.connector.ZoomFactor = 1.0R
        '
        'UI_Panel
        '
        Me.UI_Panel.BackColor = System.Drawing.Color.Black
        Me.UI_Panel.Controls.Add(Me.advertisment_box)
        Me.UI_Panel.Controls.Add(Me.PictureBox2)
        Me.UI_Panel.Controls.Add(Me.PictureBox1)
        Me.UI_Panel.Controls.Add(Me.wifi_ssid_textbox)
        Me.UI_Panel.Controls.Add(Me.ip_address_textbox)
        Me.UI_Panel.Controls.Add(Me.ip_addresser)
        Me.UI_Panel.Controls.Add(Me.wifilable)
        Me.UI_Panel.Controls.Add(Me.connect_box)
        Me.UI_Panel.Location = New System.Drawing.Point(9, 33)
        Me.UI_Panel.Name = "UI_Panel"
        Me.UI_Panel.Size = New System.Drawing.Size(270, 451)
        Me.UI_Panel.TabIndex = 2
        '
        'advertisment_box
        '
        Me.advertisment_box.Image = Global.qBruce.My.Resources.Resources.advertisment_1
        Me.advertisment_box.Location = New System.Drawing.Point(0, 0)
        Me.advertisment_box.Name = "advertisment_box"
        Me.advertisment_box.Size = New System.Drawing.Size(270, 138)
        Me.advertisment_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.advertisment_box.TabIndex = 8
        Me.advertisment_box.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.qBruce.My.Resources.Resources.webflasher
        Me.PictureBox2.Location = New System.Drawing.Point(37, 343)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(195, 50)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-27, -48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'wifi_ssid_textbox
        '
        Me.wifi_ssid_textbox.Cursor = System.Windows.Forms.Cursors.No
        Me.wifi_ssid_textbox.Location = New System.Drawing.Point(75, 305)
        Me.wifi_ssid_textbox.Name = "wifi_ssid_textbox"
        Me.wifi_ssid_textbox.ReadOnly = True
        Me.wifi_ssid_textbox.Size = New System.Drawing.Size(192, 20)
        Me.wifi_ssid_textbox.TabIndex = 5
        '
        'ip_address_textbox
        '
        Me.ip_address_textbox.Location = New System.Drawing.Point(93, 269)
        Me.ip_address_textbox.Name = "ip_address_textbox"
        Me.ip_address_textbox.Size = New System.Drawing.Size(174, 20)
        Me.ip_address_textbox.TabIndex = 4
        Me.ip_address_textbox.Text = "172.0.0.1"
        '
        'ip_addresser
        '
        Me.ip_addresser.AutoSize = True
        Me.ip_addresser.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ip_addresser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ip_addresser.Location = New System.Drawing.Point(3, 268)
        Me.ip_addresser.Name = "ip_addresser"
        Me.ip_addresser.Size = New System.Drawing.Size(92, 19)
        Me.ip_addresser.TabIndex = 3
        Me.ip_addresser.Text = "IP / Domain:"
        '
        'wifilable
        '
        Me.wifilable.AutoSize = True
        Me.wifilable.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wifilable.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.wifilable.Location = New System.Drawing.Point(3, 304)
        Me.wifilable.Name = "wifilable"
        Me.wifilable.Size = New System.Drawing.Size(74, 19)
        Me.wifilable.TabIndex = 1
        Me.wifilable.Text = "Wifi SSID:"
        '
        'connect_box
        '
        Me.connect_box.Cursor = System.Windows.Forms.Cursors.Hand
        Me.connect_box.Image = Global.qBruce.My.Resources.Resources.connect
        Me.connect_box.Location = New System.Drawing.Point(37, 399)
        Me.connect_box.Name = "connect_box"
        Me.connect_box.Size = New System.Drawing.Size(195, 40)
        Me.connect_box.TabIndex = 0
        Me.connect_box.TabStop = False
        '
        'notifications_panel
        '
        Me.notifications_panel.ContextMenuStrip = Me.Context_Menu
        Me.notifications_panel.Icon = CType(resources.GetObject("notifications_panel.Icon"), System.Drawing.Icon)
        Me.notifications_panel.Text = "qBruce"
        Me.notifications_panel.Visible = True
        '
        'Context_Menu
        '
        Me.Context_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.WebFlasherToolStripMenuItem})
        Me.Context_Menu.Name = "Context_Menu"
        Me.Context_Menu.Size = New System.Drawing.Size(139, 48)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1, Me.HideToolStripMenuItem, Me.ShowToolStripMenuItem})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ExitToolStripMenuItem.Text = "qBruce"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'WebFlasherToolStripMenuItem
        '
        Me.WebFlasherToolStripMenuItem.Name = "WebFlasherToolStripMenuItem"
        Me.WebFlasherToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.WebFlasherToolStripMenuItem.Text = "Web Flasher"
        '
        'qBruce
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(864, 488)
        Me.Controls.Add(Me.UI_Panel)
        Me.Controls.Add(Me.connect_panel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "qBruce"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "qBruce"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.info_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xicon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.connect_panel.ResumeLayout(False)
        CType(Me.connector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_Panel.ResumeLayout(False)
        Me.UI_Panel.PerformLayout()
        CType(Me.advertisment_box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.connect_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Context_Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents xicon1 As PictureBox
    Friend WithEvents qBruce_1 As Label
    Friend WithEvents connect_panel As Panel
    Friend WithEvents connector As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents UI_Panel As Panel
    Friend WithEvents wifilable As Label
    Friend WithEvents connect_box As PictureBox
    Friend WithEvents ip_addresser As Label
    Friend WithEvents ip_address_textbox As TextBox
    Friend WithEvents wifi_ssid_textbox As TextBox
    Friend WithEvents info_button As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents advertisment_box As PictureBox
    Friend WithEvents notifications_panel As NotifyIcon
    Friend WithEvents Context_Menu As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebFlasherToolStripMenuItem As ToolStripMenuItem
End Class
