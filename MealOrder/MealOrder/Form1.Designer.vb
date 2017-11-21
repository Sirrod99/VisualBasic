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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.chkOnion = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radFries = New System.Windows.Forms.RadioButton()
        Me.radChickenFingers = New System.Windows.Forms.RadioButton()
        Me.radCyanide = New System.Windows.Forms.RadioButton()
        Me.radBurger = New System.Windows.Forms.RadioButton()
        Me.radChezBurger = New System.Windows.Forms.RadioButton()
        Me.radTaco = New System.Windows.Forms.RadioButton()
        Me.radChicken = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radChicken)
        Me.GroupBox1.Controls.Add(Me.radTaco)
        Me.GroupBox1.Controls.Add(Me.radChezBurger)
        Me.GroupBox1.Controls.Add(Me.radBurger)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Ya' Meal Now!"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkOnion)
        Me.GroupBox2.Controls.Add(Me.chkMayo)
        Me.GroupBox2.Controls.Add(Me.chkLettuce)
        Me.GroupBox2.Controls.Add(Me.chkTomato)
        Me.GroupBox2.Location = New System.Drawing.Point(293, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 149)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Whatcha' Want On It?"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radCyanide)
        Me.GroupBox3.Controls.Add(Me.radChickenFingers)
        Me.GroupBox3.Controls.Add(Me.radFries)
        Me.GroupBox3.Location = New System.Drawing.Point(293, 213)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 88)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "What Do Ya' Want With It?"
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(6, 19)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(62, 17)
        Me.chkTomato.TabIndex = 0
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(6, 53)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 1
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Location = New System.Drawing.Point(6, 89)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(52, 17)
        Me.chkMayo.TabIndex = 2
        Me.chkMayo.Text = "Mayo"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'chkOnion
        '
        Me.chkOnion.AutoSize = True
        Me.chkOnion.Location = New System.Drawing.Point(6, 121)
        Me.chkOnion.Name = "chkOnion"
        Me.chkOnion.Size = New System.Drawing.Size(98, 17)
        Me.chkOnion.TabIndex = 3
        Me.chkOnion.Text = "A Whole Onion"
        Me.chkOnion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ravie", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Get You Food And Go"
        '
        'radFries
        '
        Me.radFries.AutoSize = True
        Me.radFries.Location = New System.Drawing.Point(7, 20)
        Me.radFries.Name = "radFries"
        Me.radFries.Size = New System.Drawing.Size(47, 17)
        Me.radFries.TabIndex = 0
        Me.radFries.TabStop = True
        Me.radFries.Text = "Fries"
        Me.radFries.UseVisualStyleBackColor = True
        '
        'radChickenFingers
        '
        Me.radChickenFingers.AutoSize = True
        Me.radChickenFingers.Location = New System.Drawing.Point(7, 43)
        Me.radChickenFingers.Name = "radChickenFingers"
        Me.radChickenFingers.Size = New System.Drawing.Size(101, 17)
        Me.radChickenFingers.TabIndex = 1
        Me.radChickenFingers.TabStop = True
        Me.radChickenFingers.Text = "Chicken Fingers"
        Me.radChickenFingers.UseVisualStyleBackColor = True
        '
        'radCyanide
        '
        Me.radCyanide.AutoSize = True
        Me.radCyanide.Location = New System.Drawing.Point(7, 65)
        Me.radCyanide.Name = "radCyanide"
        Me.radCyanide.Size = New System.Drawing.Size(145, 17)
        Me.radCyanide.TabIndex = 2
        Me.radCyanide.TabStop = True
        Me.radCyanide.Text = "A Lethal Dose of Cyanide"
        Me.radCyanide.UseVisualStyleBackColor = True
        '
        'radBurger
        '
        Me.radBurger.AutoSize = True
        Me.radBurger.Location = New System.Drawing.Point(6, 19)
        Me.radBurger.Name = "radBurger"
        Me.radBurger.Size = New System.Drawing.Size(56, 17)
        Me.radBurger.TabIndex = 2
        Me.radBurger.TabStop = True
        Me.radBurger.Text = "Burger"
        Me.radBurger.UseVisualStyleBackColor = True
        '
        'radChezBurger
        '
        Me.radChezBurger.AutoSize = True
        Me.radChezBurger.Location = New System.Drawing.Point(6, 56)
        Me.radChezBurger.Name = "radChezBurger"
        Me.radChezBurger.Size = New System.Drawing.Size(83, 17)
        Me.radChezBurger.TabIndex = 3
        Me.radChezBurger.TabStop = True
        Me.radChezBurger.Text = "Chez Burger"
        Me.radChezBurger.UseVisualStyleBackColor = True
        '
        'radTaco
        '
        Me.radTaco.AutoSize = True
        Me.radTaco.Location = New System.Drawing.Point(6, 125)
        Me.radTaco.Name = "radTaco"
        Me.radTaco.Size = New System.Drawing.Size(100, 17)
        Me.radTaco.TabIndex = 4
        Me.radTaco.TabStop = True
        Me.radTaco.Text = "Delgodo's Taco"
        Me.radTaco.UseVisualStyleBackColor = True
        '
        'radChicken
        '
        Me.radChicken.AutoSize = True
        Me.radChicken.Location = New System.Drawing.Point(6, 92)
        Me.radChicken.Name = "radChicken"
        Me.radChicken.Size = New System.Drawing.Size(64, 17)
        Me.radChicken.TabIndex = 5
        Me.radChicken.TabStop = True
        Me.radChicken.Text = "Chicken"
        Me.radChicken.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(18, 213)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(269, 60)
        Me.lblResult.TabIndex = 4
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 278)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(212, 278)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(93, 278)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(113, 23)
        Me.lblTotal.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(505, 389)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radChicken As System.Windows.Forms.RadioButton
    Friend WithEvents radTaco As System.Windows.Forms.RadioButton
    Friend WithEvents radChezBurger As System.Windows.Forms.RadioButton
    Friend WithEvents radBurger As System.Windows.Forms.RadioButton
    Friend WithEvents chkOnion As System.Windows.Forms.CheckBox
    Friend WithEvents chkMayo As System.Windows.Forms.CheckBox
    Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents radCyanide As System.Windows.Forms.RadioButton
    Friend WithEvents radChickenFingers As System.Windows.Forms.RadioButton
    Friend WithEvents radFries As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
