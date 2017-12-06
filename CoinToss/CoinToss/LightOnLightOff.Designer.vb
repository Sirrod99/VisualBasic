<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LightOnLightOff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LightOnLightOff))
        Me.picLightOn = New System.Windows.Forms.PictureBox()
        Me.picLightOff = New System.Windows.Forms.PictureBox()
        Me.btnLightSwitch = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        CType(Me.picLightOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLightOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLightOn
        '
        Me.picLightOn.Image = CType(resources.GetObject("picLightOn.Image"), System.Drawing.Image)
        Me.picLightOn.Location = New System.Drawing.Point(7, 12)
        Me.picLightOn.Name = "picLightOn"
        Me.picLightOn.Size = New System.Drawing.Size(259, 186)
        Me.picLightOn.TabIndex = 0
        Me.picLightOn.TabStop = False
        '
        'picLightOff
        '
        Me.picLightOff.Image = CType(resources.GetObject("picLightOff.Image"), System.Drawing.Image)
        Me.picLightOff.Location = New System.Drawing.Point(272, 12)
        Me.picLightOff.Name = "picLightOff"
        Me.picLightOff.Size = New System.Drawing.Size(176, 265)
        Me.picLightOff.TabIndex = 1
        Me.picLightOff.TabStop = False
        '
        'btnLightSwitch
        '
        Me.btnLightSwitch.Location = New System.Drawing.Point(24, 214)
        Me.btnLightSwitch.Name = "btnLightSwitch"
        Me.btnLightSwitch.Size = New System.Drawing.Size(75, 23)
        Me.btnLightSwitch.TabIndex = 2
        Me.btnLightSwitch.Text = "Light Switch"
        Me.btnLightSwitch.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(165, 214)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(114, 269)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 23)
        Me.lblResult.TabIndex = 4
        '
        'LightOnLightOff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 330)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLightSwitch)
        Me.Controls.Add(Me.picLightOff)
        Me.Controls.Add(Me.picLightOn)
        Me.Name = "LightOnLightOff"
        Me.Text = "Form2"
        CType(Me.picLightOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLightOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picLightOn As System.Windows.Forms.PictureBox
    Friend WithEvents picLightOff As System.Windows.Forms.PictureBox
    Friend WithEvents btnLightSwitch As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
End Class
