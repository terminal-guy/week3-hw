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
        Me.trkHour = New System.Windows.Forms.TrackBar()
        Me.lblState = New System.Windows.Forms.Label()
        CType(Me.trkHour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trkHour
        '
        Me.trkHour.Location = New System.Drawing.Point(59, 31)
        Me.trkHour.Maximum = 23
        Me.trkHour.Name = "trkHour"
        Me.trkHour.Size = New System.Drawing.Size(432, 45)
        Me.trkHour.TabIndex = 0
        '
        'lblState
        '
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblState.Location = New System.Drawing.Point(73, 120)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(408, 42)
        Me.lblState.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 171)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.trkHour)
        Me.Name = "Form1"
        Me.Text = "Yetheendranadhan Vishal Adhithya 12423155"
        CType(Me.trkHour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents trkHour As TrackBar
    Friend WithEvents lblState As Label
End Class
