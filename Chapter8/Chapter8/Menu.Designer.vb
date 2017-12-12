<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnFriendList1 = New System.Windows.Forms.Button()
        Me.btnFriendList2 = New System.Windows.Forms.Button()
        Me.btnPlaneArray = New System.Windows.Forms.Button()
        Me.btnNumberGen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to the Chapter 8 Tutorials!"
        '
        'btnFriendList1
        '
        Me.btnFriendList1.Location = New System.Drawing.Point(26, 51)
        Me.btnFriendList1.Name = "btnFriendList1"
        Me.btnFriendList1.Size = New System.Drawing.Size(75, 33)
        Me.btnFriendList1.TabIndex = 1
        Me.btnFriendList1.Text = "Friends List"
        Me.btnFriendList1.UseVisualStyleBackColor = True
        '
        'btnFriendList2
        '
        Me.btnFriendList2.Location = New System.Drawing.Point(244, 51)
        Me.btnFriendList2.Name = "btnFriendList2"
        Me.btnFriendList2.Size = New System.Drawing.Size(75, 33)
        Me.btnFriendList2.TabIndex = 2
        Me.btnFriendList2.Text = "Friend List +"
        Me.btnFriendList2.UseVisualStyleBackColor = True
        '
        'btnPlaneArray
        '
        Me.btnPlaneArray.Location = New System.Drawing.Point(133, 112)
        Me.btnPlaneArray.Name = "btnPlaneArray"
        Me.btnPlaneArray.Size = New System.Drawing.Size(75, 33)
        Me.btnPlaneArray.TabIndex = 3
        Me.btnPlaneArray.Text = "Plane Array"
        Me.btnPlaneArray.UseVisualStyleBackColor = True
        '
        'btnNumberGen
        '
        Me.btnNumberGen.Location = New System.Drawing.Point(79, 185)
        Me.btnNumberGen.Name = "btnNumberGen"
        Me.btnNumberGen.Size = New System.Drawing.Size(182, 39)
        Me.btnNumberGen.TabIndex = 4
        Me.btnNumberGen.Text = "Number Generator"
        Me.btnNumberGen.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(344, 312)
        Me.Controls.Add(Me.btnNumberGen)
        Me.Controls.Add(Me.btnPlaneArray)
        Me.Controls.Add(Me.btnFriendList2)
        Me.Controls.Add(Me.btnFriendList1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Menu"
        Me.Text = "Chapter 8: Tutorial Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFriendList1 As System.Windows.Forms.Button
    Friend WithEvents btnFriendList2 As System.Windows.Forms.Button
    Friend WithEvents btnPlaneArray As System.Windows.Forms.Button
    Friend WithEvents btnNumberGen As System.Windows.Forms.Button
End Class
