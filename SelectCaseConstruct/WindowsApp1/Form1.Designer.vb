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
        Me.btnTemprature = New System.Windows.Forms.Button()
        Me.lblTemprature = New System.Windows.Forms.Label()
        Me.txtTemprature = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnTemprature
        '
        Me.btnTemprature.Location = New System.Drawing.Point(294, 276)
        Me.btnTemprature.Name = "btnTemprature"
        Me.btnTemprature.Size = New System.Drawing.Size(162, 59)
        Me.btnTemprature.TabIndex = 0
        Me.btnTemprature.Text = "Check Temprature"
        Me.btnTemprature.UseVisualStyleBackColor = True
        '
        'lblTemprature
        '
        Me.lblTemprature.AutoSize = True
        Me.lblTemprature.Location = New System.Drawing.Point(178, 130)
        Me.lblTemprature.Name = "lblTemprature"
        Me.lblTemprature.Size = New System.Drawing.Size(111, 16)
        Me.lblTemprature.TabIndex = 1
        Me.lblTemprature.Text = "Enter Temprature"
        '
        'txtTemprature
        '
        Me.txtTemprature.Location = New System.Drawing.Point(295, 123)
        Me.txtTemprature.Name = "txtTemprature"
        Me.txtTemprature.Size = New System.Drawing.Size(208, 22)
        Me.txtTemprature.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtTemprature)
        Me.Controls.Add(Me.lblTemprature)
        Me.Controls.Add(Me.btnTemprature)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTemprature As Button
    Friend WithEvents lblTemprature As Label
    Friend WithEvents txtTemprature As TextBox
End Class
