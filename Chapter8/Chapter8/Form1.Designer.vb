<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblThird = New System.Windows.Forms.Label()
        Me.lblFifth = New System.Windows.Forms.Label()
        Me.lblForth = New System.Windows.Forms.Label()
        Me.btnGenNumb = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFirst
        '
        Me.lblFirst.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirst.Location = New System.Drawing.Point(12, 23)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(43, 43)
        Me.lblFirst.TabIndex = 0
        '
        'lblSecond
        '
        Me.lblSecond.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecond.Location = New System.Drawing.Point(76, 23)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(43, 43)
        Me.lblSecond.TabIndex = 1
        '
        'lblThird
        '
        Me.lblThird.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblThird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThird.Location = New System.Drawing.Point(139, 23)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(43, 43)
        Me.lblThird.TabIndex = 2
        '
        'lblFifth
        '
        Me.lblFifth.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblFifth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFifth.Location = New System.Drawing.Point(207, 23)
        Me.lblFifth.Name = "lblFifth"
        Me.lblFifth.Size = New System.Drawing.Size(43, 43)
        Me.lblFifth.TabIndex = 3
        '
        'lblForth
        '
        Me.lblForth.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblForth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblForth.Location = New System.Drawing.Point(277, 23)
        Me.lblForth.Name = "lblForth"
        Me.lblForth.Size = New System.Drawing.Size(43, 43)
        Me.lblForth.TabIndex = 4
        '
        'btnGenNumb
        '
        Me.btnGenNumb.Location = New System.Drawing.Point(44, 117)
        Me.btnGenNumb.Name = "btnGenNumb"
        Me.btnGenNumb.Size = New System.Drawing.Size(75, 36)
        Me.btnGenNumb.TabIndex = 5
        Me.btnGenNumb.Text = "Generate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Numbers"
        Me.btnGenNumb.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(207, 117)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 36)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(332, 171)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGenNumb)
        Me.Controls.Add(Me.lblForth)
        Me.Controls.Add(Me.lblFifth)
        Me.Controls.Add(Me.lblThird)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents lblThird As System.Windows.Forms.Label
    Friend WithEvents lblFifth As System.Windows.Forms.Label
    Friend WithEvents lblForth As System.Windows.Forms.Label
    Friend WithEvents btnGenNumb As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
