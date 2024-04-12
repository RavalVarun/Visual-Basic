<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculationForm
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
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblSimpleCaclucation = New System.Windows.Forms.Label()
        Me.lblComplexCalculation = New System.Windows.Forms.Label()
        Me.btnComplexCalculation = New System.Windows.Forms.Button()
        Me.lblNumberComplex1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumber1
        '
        Me.lblNumber1.AutoSize = True
        Me.lblNumber1.Location = New System.Drawing.Point(99, 94)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(62, 16)
        Me.lblNumber1.TabIndex = 0
        Me.lblNumber1.Text = "Number1"
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(169, 94)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(170, 22)
        Me.txtNumber1.TabIndex = 1
        '
        'lblNumber2
        '
        Me.lblNumber2.AutoSize = True
        Me.lblNumber2.Location = New System.Drawing.Point(99, 148)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(62, 16)
        Me.lblNumber2.TabIndex = 2
        Me.lblNumber2.Text = "Number2"
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(169, 145)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(170, 22)
        Me.txtNumber2.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(169, 226)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(162, 66)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblSimpleCaclucation
        '
        Me.lblSimpleCaclucation.AutoSize = True
        Me.lblSimpleCaclucation.Location = New System.Drawing.Point(191, 41)
        Me.lblSimpleCaclucation.Name = "lblSimpleCaclucation"
        Me.lblSimpleCaclucation.Size = New System.Drawing.Size(118, 16)
        Me.lblSimpleCaclucation.TabIndex = 5
        Me.lblSimpleCaclucation.Text = "Simple Calculation"
        '
        'lblComplexCalculation
        '
        Me.lblComplexCalculation.AutoSize = True
        Me.lblComplexCalculation.Location = New System.Drawing.Point(601, 40)
        Me.lblComplexCalculation.Name = "lblComplexCalculation"
        Me.lblComplexCalculation.Size = New System.Drawing.Size(129, 16)
        Me.lblComplexCalculation.TabIndex = 6
        Me.lblComplexCalculation.Text = "Complex Calculation"
        '
        'btnComplexCalculation
        '
        Me.btnComplexCalculation.Location = New System.Drawing.Point(577, 220)
        Me.btnComplexCalculation.Name = "btnComplexCalculation"
        Me.btnComplexCalculation.Size = New System.Drawing.Size(162, 66)
        Me.btnComplexCalculation.TabIndex = 11
        Me.btnComplexCalculation.Text = "Calculate"
        Me.btnComplexCalculation.UseVisualStyleBackColor = True
        '
        'lblNumberComplex1
        '
        Me.lblNumberComplex1.AutoSize = True
        Me.lblNumberComplex1.Location = New System.Drawing.Point(511, 97)
        Me.lblNumberComplex1.Name = "lblNumberComplex1"
        Me.lblNumberComplex1.Size = New System.Drawing.Size(336, 16)
        Me.lblNumberComplex1.TabIndex = 7
        Me.lblNumberComplex1.Text = "The button below calculates Price of Cake (hard coded)"
        '
        'CalculationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 450)
        Me.Controls.Add(Me.btnComplexCalculation)
        Me.Controls.Add(Me.lblNumberComplex1)
        Me.Controls.Add(Me.lblComplexCalculation)
        Me.Controls.Add(Me.lblSimpleCaclucation)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.lblNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.lblNumber1)
        Me.Name = "CalculationForm"
        Me.Text = "CalculationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumber1 As Label
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents lblNumber2 As Label
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblSimpleCaclucation As Label
    Friend WithEvents lblComplexCalculation As Label
    Friend WithEvents btnComplexCalculation As Button
    Friend WithEvents lblNumberComplex1 As Label
End Class
