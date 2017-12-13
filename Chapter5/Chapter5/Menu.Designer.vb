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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTestScores = New System.Windows.Forms.Button()
        Me.btnSumOfNumbers = New System.Windows.Forms.Button()
        Me.btnDistanceCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPopulation = New System.Windows.Forms.Button()
        Me.btnRandomNumber = New System.Windows.Forms.Button()
        Me.btnRandomNumberEnchanement = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Running Total"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTestScores
        '
        Me.btnTestScores.Location = New System.Drawing.Point(12, 57)
        Me.btnTestScores.Name = "btnTestScores"
        Me.btnTestScores.Size = New System.Drawing.Size(116, 23)
        Me.btnTestScores.TabIndex = 1
        Me.btnTestScores.Text = "Test Scores"
        Me.btnTestScores.UseVisualStyleBackColor = True
        '
        'btnSumOfNumbers
        '
        Me.btnSumOfNumbers.Location = New System.Drawing.Point(12, 99)
        Me.btnSumOfNumbers.Name = "btnSumOfNumbers"
        Me.btnSumOfNumbers.Size = New System.Drawing.Size(116, 23)
        Me.btnSumOfNumbers.TabIndex = 2
        Me.btnSumOfNumbers.Text = "Sum of Numbers"
        Me.btnSumOfNumbers.UseVisualStyleBackColor = True
        '
        'btnDistanceCalc
        '
        Me.btnDistanceCalc.Location = New System.Drawing.Point(82, 138)
        Me.btnDistanceCalc.Name = "btnDistanceCalc"
        Me.btnDistanceCalc.Size = New System.Drawing.Size(116, 23)
        Me.btnDistanceCalc.TabIndex = 3
        Me.btnDistanceCalc.Text = "Distance Calulator"
        Me.btnDistanceCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(105, 214)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 36)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPopulation
        '
        Me.btnPopulation.Location = New System.Drawing.Point(156, 12)
        Me.btnPopulation.Name = "btnPopulation"
        Me.btnPopulation.Size = New System.Drawing.Size(116, 23)
        Me.btnPopulation.TabIndex = 5
        Me.btnPopulation.Text = "Population"
        Me.btnPopulation.UseVisualStyleBackColor = True
        '
        'btnRandomNumber
        '
        Me.btnRandomNumber.Location = New System.Drawing.Point(156, 57)
        Me.btnRandomNumber.Name = "btnRandomNumber"
        Me.btnRandomNumber.Size = New System.Drawing.Size(116, 23)
        Me.btnRandomNumber.TabIndex = 6
        Me.btnRandomNumber.Text = "Random Number "
        Me.btnRandomNumber.UseVisualStyleBackColor = True
        '
        'btnRandomNumberEnchanement
        '
        Me.btnRandomNumberEnchanement.Location = New System.Drawing.Point(156, 99)
        Me.btnRandomNumberEnchanement.Name = "btnRandomNumberEnchanement"
        Me.btnRandomNumberEnchanement.Size = New System.Drawing.Size(116, 23)
        Me.btnRandomNumberEnchanement.TabIndex = 7
        Me.btnRandomNumberEnchanement.Text = "Random Number +"
        Me.btnRandomNumberEnchanement.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnRandomNumberEnchanement)
        Me.Controls.Add(Me.btnRandomNumber)
        Me.Controls.Add(Me.btnPopulation)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDistanceCalc)
        Me.Controls.Add(Me.btnSumOfNumbers)
        Me.Controls.Add(Me.btnTestScores)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Menu"
        Me.Text = "Chapter 5 Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnTestScores As System.Windows.Forms.Button
    Friend WithEvents btnSumOfNumbers As System.Windows.Forms.Button
    Friend WithEvents btnDistanceCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPopulation As System.Windows.Forms.Button
    Friend WithEvents btnRandomNumber As System.Windows.Forms.Button
    Friend WithEvents btnRandomNumberEnchanement As System.Windows.Forms.Button
End Class
