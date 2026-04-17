<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class brucelabs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(brucelabs))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.laboratory = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.lab_top_panel = New System.Windows.Forms.Panel()
        Me.xiconlab = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.laboratory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lab_top_panel.SuspendLayout()
        CType(Me.xiconlab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.laboratory)
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1152, 614)
        Me.Panel1.TabIndex = 0
        '
        'laboratory
        '
        Me.laboratory.AllowExternalDrop = True
        Me.laboratory.CreationProperties = Nothing
        Me.laboratory.DefaultBackgroundColor = System.Drawing.Color.Black
        Me.laboratory.Location = New System.Drawing.Point(3, 3)
        Me.laboratory.Name = "laboratory"
        Me.laboratory.Size = New System.Drawing.Size(1146, 608)
        Me.laboratory.Source = New System.Uri("https://bruce.computer/my_bruce", System.UriKind.Absolute)
        Me.laboratory.TabIndex = 0
        Me.laboratory.ZoomFactor = 1.0R
        '
        'lab_top_panel
        '
        Me.lab_top_panel.BackColor = System.Drawing.Color.Black
        Me.lab_top_panel.Controls.Add(Me.xiconlab)
        Me.lab_top_panel.Location = New System.Drawing.Point(0, -1)
        Me.lab_top_panel.Name = "lab_top_panel"
        Me.lab_top_panel.Size = New System.Drawing.Size(1152, 25)
        Me.lab_top_panel.TabIndex = 1
        '
        'xiconlab
        '
        Me.xiconlab.BackColor = System.Drawing.Color.Black
        Me.xiconlab.Image = Global.qBruce.My.Resources.Resources.x_icon_new
        Me.xiconlab.Location = New System.Drawing.Point(1131, 3)
        Me.xiconlab.Name = "xiconlab"
        Me.xiconlab.Size = New System.Drawing.Size(18, 19)
        Me.xiconlab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.xiconlab.TabIndex = 1
        Me.xiconlab.TabStop = False
        '
        'brucelabs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrchid
        Me.ClientSize = New System.Drawing.Size(1152, 643)
        Me.Controls.Add(Me.lab_top_panel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "brucelabs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "qBruce Lbs"
        Me.Panel1.ResumeLayout(False)
        CType(Me.laboratory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lab_top_panel.ResumeLayout(False)
        CType(Me.xiconlab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents laboratory As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents lab_top_panel As Panel
    Friend WithEvents xiconlab As PictureBox
End Class
