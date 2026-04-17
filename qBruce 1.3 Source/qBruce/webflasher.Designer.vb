<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class webflasher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(webflasher))
        Me.webflasher_web = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(Me.webflasher_web, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'webflasher_web
        '
        Me.webflasher_web.AllowExternalDrop = True
        Me.webflasher_web.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webflasher_web.CreationProperties = Nothing
        Me.webflasher_web.DefaultBackgroundColor = System.Drawing.Color.White
        Me.webflasher_web.Location = New System.Drawing.Point(-2, -1)
        Me.webflasher_web.Name = "webflasher_web"
        Me.webflasher_web.Size = New System.Drawing.Size(1072, 542)
        Me.webflasher_web.Source = New System.Uri("https://bruce.computer/flasher", System.UriKind.Absolute)
        Me.webflasher_web.TabIndex = 0
        Me.webflasher_web.ZoomFactor = 1.0R
        '
        'webflasher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(1070, 540)
        Me.Controls.Add(Me.webflasher_web)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "webflasher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Web Flasher"
        CType(Me.webflasher_web, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents webflasher_web As Microsoft.Web.WebView2.WinForms.WebView2
End Class
