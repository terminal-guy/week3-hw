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
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(331, 79)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(100, 20)
        Me.txtPrincipal.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Chocolate
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label1.Location = New System.Drawing.Point(128, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Principal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Chocolate
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label2.Location = New System.Drawing.Point(128, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Chocolate
        Me.Label3.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label3.Location = New System.Drawing.Point(128, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Time:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(235, 269)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.Location = New System.Drawing.Point(262, 326)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(19, 13)
        Me.lblresult.TabIndex = 7
        Me.lblresult.Text = "  ?"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(331, 212)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(100, 20)
        Me.txtTime.TabIndex = 8
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(331, 140)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 404)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Name = "Form1"
        Me.Text = "Yetheendranadhan Vishal Adhithya APU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblresult As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtRate As TextBox
End Class
