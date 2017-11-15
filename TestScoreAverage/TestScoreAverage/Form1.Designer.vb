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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.txtTestScoreOne = New System.Windows.Forms.TextBox()
        Me.txtTestScoreFour = New System.Windows.Forms.TextBox()
        Me.txtTestScoreThree = New System.Windows.Forms.TextBox()
        Me.txtTestScoreTwo = New System.Windows.Forms.TextBox()
        Me.btnCalcAv = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Test Score 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Test Score 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Test Score 3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Test Score 4:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Average"
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(114, 277)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(100, 22)
        Me.lblAverage.TabIndex = 5
        '
        'txtTestScoreOne
        '
        Me.txtTestScoreOne.Location = New System.Drawing.Point(114, 28)
        Me.txtTestScoreOne.Name = "txtTestScoreOne"
        Me.txtTestScoreOne.Size = New System.Drawing.Size(100, 20)
        Me.txtTestScoreOne.TabIndex = 6
        '
        'txtTestScoreFour
        '
        Me.txtTestScoreFour.Location = New System.Drawing.Point(114, 214)
        Me.txtTestScoreFour.Name = "txtTestScoreFour"
        Me.txtTestScoreFour.Size = New System.Drawing.Size(100, 20)
        Me.txtTestScoreFour.TabIndex = 8
        '
        'txtTestScoreThree
        '
        Me.txtTestScoreThree.Location = New System.Drawing.Point(114, 146)
        Me.txtTestScoreThree.Name = "txtTestScoreThree"
        Me.txtTestScoreThree.Size = New System.Drawing.Size(100, 20)
        Me.txtTestScoreThree.TabIndex = 9
        '
        'txtTestScoreTwo
        '
        Me.txtTestScoreTwo.Location = New System.Drawing.Point(114, 80)
        Me.txtTestScoreTwo.Name = "txtTestScoreTwo"
        Me.txtTestScoreTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtTestScoreTwo.TabIndex = 10
        '
        'btnCalcAv
        '
        Me.btnCalcAv.Location = New System.Drawing.Point(12, 335)
        Me.btnCalcAv.Name = "btnCalcAv"
        Me.btnCalcAv.Size = New System.Drawing.Size(75, 35)
        Me.btnCalcAv.TabIndex = 11
        Me.btnCalcAv.Text = "Calculate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Average" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnCalcAv.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(123, 335)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 35)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(231, 335)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(318, 382)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcAv)
        Me.Controls.Add(Me.txtTestScoreTwo)
        Me.Controls.Add(Me.txtTestScoreThree)
        Me.Controls.Add(Me.txtTestScoreFour)
        Me.Controls.Add(Me.txtTestScoreOne)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents txtTestScoreOne As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScoreFour As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScoreThree As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScoreTwo As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcAv As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
