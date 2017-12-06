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
        Me.cblCountry = New System.Windows.Forms.ComboBox()
        Me.cblArtist = New System.Windows.Forms.ComboBox()
        Me.cblPlay = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.txtPlay = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.btnShowSelections = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cblCountry
        '
        Me.cblCountry.FormattingEnabled = True
        Me.cblCountry.Items.AddRange(New Object() {"England", "Ireland", "Scotland", "Wales"})
        Me.cblCountry.Location = New System.Drawing.Point(110, 22)
        Me.cblCountry.Name = "cblCountry"
        Me.cblCountry.Size = New System.Drawing.Size(121, 21)
        Me.cblCountry.TabIndex = 0
        '
        'cblArtist
        '
        Me.cblArtist.FormattingEnabled = True
        Me.cblArtist.Items.AddRange(New Object() {"Michelangelo", "Raphael", "da Vinci"})
        Me.cblArtist.Location = New System.Drawing.Point(110, 189)
        Me.cblArtist.Name = "cblArtist"
        Me.cblArtist.Size = New System.Drawing.Size(121, 21)
        Me.cblArtist.TabIndex = 1
        '
        'cblPlay
        '
        Me.cblPlay.FormattingEnabled = True
        Me.cblPlay.Items.AddRange(New Object() {"Hamlet ", "Much Ado about Nothing", "Romeo and Juliet", "A Comedy of Errors"})
        Me.cblPlay.Location = New System.Drawing.Point(110, 105)
        Me.cblPlay.Name = "cblPlay"
        Me.cblPlay.Size = New System.Drawing.Size(121, 21)
        Me.cblPlay.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Choose a country"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Choose a play"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Choose an artist"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtArtist)
        Me.GroupBox1.Controls.Add(Me.txtPlay)
        Me.GroupBox1.Controls.Add(Me.txtCountry)
        Me.GroupBox1.Location = New System.Drawing.Point(237, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 180)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your Choices"
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(6, 143)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(188, 20)
        Me.txtArtist.TabIndex = 2
        '
        'txtPlay
        '
        Me.txtPlay.Location = New System.Drawing.Point(6, 75)
        Me.txtPlay.Name = "txtPlay"
        Me.txtPlay.Size = New System.Drawing.Size(188, 20)
        Me.txtPlay.TabIndex = 1
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(6, 14)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(188, 20)
        Me.txtCountry.TabIndex = 0
        '
        'btnShowSelections
        '
        Me.btnShowSelections.Location = New System.Drawing.Point(11, 242)
        Me.btnShowSelections.Name = "btnShowSelections"
        Me.btnShowSelections.Size = New System.Drawing.Size(75, 38)
        Me.btnShowSelections.TabIndex = 7
        Me.btnShowSelections.Text = "Show" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Selections" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnShowSelections.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(186, 242)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 38)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(356, 242)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 38)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(443, 295)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnShowSelections)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cblPlay)
        Me.Controls.Add(Me.cblArtist)
        Me.Controls.Add(Me.cblCountry)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cblCountry As System.Windows.Forms.ComboBox
    Friend WithEvents cblArtist As System.Windows.Forms.ComboBox
    Friend WithEvents cblPlay As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtArtist As System.Windows.Forms.TextBox
    Friend WithEvents txtPlay As System.Windows.Forms.TextBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents btnShowSelections As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
