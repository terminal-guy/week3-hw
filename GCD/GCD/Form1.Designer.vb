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
        Me.txtbtn1 = New System.Windows.Forms.TextBox()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.txtbtn2 = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtGCD = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.Label1.Location = New System.Drawing.Point(35, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program for Summing the Integers from 1 to N. Please input a value for N"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(82, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "A = "
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(82, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "B ="
        '
        'txtbtn1
        '
        Me.txtbtn1.Location = New System.Drawing.Point(204, 67)
        Me.txtbtn1.Name = "txtbtn1"
        Me.txtbtn1.Size = New System.Drawing.Size(155, 20)
        Me.txtbtn1.TabIndex = 10
        '
        'lstData
        '
        Me.lstData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstData.BackColor = System.Drawing.Color.Black
        Me.lstData.ForeColor = System.Drawing.Color.SpringGreen
        Me.lstData.FormattingEnabled = True
        Me.lstData.IntegralHeight = False
        Me.lstData.Items.AddRange(New Object() {"Yetheendranadhan Vishal Adhithya APU; ID = 12423155"})
        Me.lstData.Location = New System.Drawing.Point(85, 223)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(294, 372)
        Me.lstData.TabIndex = 11
        '
        'txtbtn2
        '
        Me.txtbtn2.Location = New System.Drawing.Point(204, 109)
        Me.txtbtn2.Name = "txtbtn2"
        Me.txtbtn2.Size = New System.Drawing.Size(155, 20)
        Me.txtbtn2.TabIndex = 12
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnExit.Location = New System.Drawing.Point(304, 613)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(95, 613)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 14
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtGCD
        '
        Me.txtGCD.Location = New System.Drawing.Point(204, 154)
        Me.txtGCD.Name = "txtGCD"
        Me.txtGCD.Size = New System.Drawing.Size(155, 20)
        Me.txtGCD.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(82, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "GCD ="
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 672)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtGCD)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtbtn2)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.txtbtn1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Yetheendranadhan Vishal Adhithya 12423155"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbtn1 As TextBox
    Friend WithEvents lstData As ListBox
    Friend WithEvents txtbtn2 As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnGo As Button
    Friend WithEvents txtGCD As TextBox
    Friend WithEvents Label4 As Label
End Class
