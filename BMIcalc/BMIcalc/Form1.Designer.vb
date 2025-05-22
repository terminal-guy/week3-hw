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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbmi = New System.Windows.Forms.TextBox()
        Me.txtstdweight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtheight = New System.Windows.Forms.TextBox()
        Me.txtweight = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(73, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your height and weight and press <Compute>"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Height (cm)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbmi)
        Me.GroupBox1.Controls.Add(Me.txtstdweight)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 198)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 197)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your output"
        '
        'txtbmi
        '
        Me.txtbmi.Location = New System.Drawing.Point(219, 105)
        Me.txtbmi.Name = "txtbmi"
        Me.txtbmi.Size = New System.Drawing.Size(100, 20)
        Me.txtbmi.TabIndex = 3
        '
        'txtstdweight
        '
        Me.txtstdweight.Location = New System.Drawing.Point(219, 45)
        Me.txtstdweight.Name = "txtstdweight"
        Me.txtstdweight.Size = New System.Drawing.Size(100, 20)
        Me.txtstdweight.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Body Mass Index:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Standard Weight (kg)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Weight (kg)"
        '
        'txtheight
        '
        Me.txtheight.Location = New System.Drawing.Point(286, 92)
        Me.txtheight.Name = "txtheight"
        Me.txtheight.Size = New System.Drawing.Size(100, 20)
        Me.txtheight.TabIndex = 4
        '
        'txtweight
        '
        Me.txtweight.Location = New System.Drawing.Point(286, 136)
        Me.txtweight.Name = "txtweight"
        Me.txtweight.Size = New System.Drawing.Size(100, 20)
        Me.txtweight.TabIndex = 5
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Aqua
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.lblStatus.Location = New System.Drawing.Point(71, 436)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(146, 25)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Undetermined"
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(324, 436)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 7
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 513)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtweight)
        Me.Controls.Add(Me.txtheight)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Yetheendranadhan Vishal Adhithya APU"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbmi As TextBox
    Friend WithEvents txtstdweight As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtheight As TextBox
    Friend WithEvents txtweight As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnexit As Button
End Class
