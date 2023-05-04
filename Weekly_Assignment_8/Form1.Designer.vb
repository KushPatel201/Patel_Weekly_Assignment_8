<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSmart))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSavings = New System.Windows.Forms.Label()
        Me.lblAverageSavings = New System.Windows.Forms.Label()
        Me.lblMaxSavings = New System.Windows.Forms.Label()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.btnStatistics = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(323, 607)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblSavings
        '
        Me.lblSavings.AutoSize = True
        Me.lblSavings.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lblSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblSavings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSavings.Location = New System.Drawing.Point(20, 207)
        Me.lblSavings.Name = "lblSavings"
        Me.lblSavings.Size = New System.Drawing.Size(65, 20)
        Me.lblSavings.TabIndex = 1
        Me.lblSavings.Text = "Savings"
        '
        'lblAverageSavings
        '
        Me.lblAverageSavings.AutoSize = True
        Me.lblAverageSavings.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lblAverageSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageSavings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblAverageSavings.Location = New System.Drawing.Point(20, 299)
        Me.lblAverageSavings.Name = "lblAverageSavings"
        Me.lblAverageSavings.Size = New System.Drawing.Size(128, 20)
        Me.lblAverageSavings.TabIndex = 2
        Me.lblAverageSavings.Text = "Average Savings"
        '
        'lblMaxSavings
        '
        Me.lblMaxSavings.AutoSize = True
        Me.lblMaxSavings.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lblMaxSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxSavings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblMaxSavings.Location = New System.Drawing.Point(20, 394)
        Me.lblMaxSavings.Name = "lblMaxSavings"
        Me.lblMaxSavings.Size = New System.Drawing.Size(94, 20)
        Me.lblMaxSavings.TabIndex = 3
        Me.lblMaxSavings.Text = "MaxSavings"
        '
        'cboMonths
        '
        Me.cboMonths.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonths.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Location = New System.Drawing.Point(24, 104)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(269, 32)
        Me.cboMonths.TabIndex = 4
        '
        'btnStatistics
        '
        Me.btnStatistics.Enabled = False
        Me.btnStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnStatistics.Location = New System.Drawing.Point(24, 531)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(269, 44)
        Me.btnStatistics.TabIndex = 5
        Me.btnStatistics.Text = "DISPLAY STATISTICS"
        Me.btnStatistics.UseVisualStyleBackColor = True
        Me.btnStatistics.Visible = False
        '
        'frmSmart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 596)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.cboMonths)
        Me.Controls.Add(Me.lblMaxSavings)
        Me.Controls.Add(Me.lblAverageSavings)
        Me.Controls.Add(Me.lblSavings)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmSmart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSavings As Label
    Friend WithEvents lblAverageSavings As Label
    Friend WithEvents lblMaxSavings As Label
    Friend WithEvents cboMonths As ComboBox
    Friend WithEvents btnStatistics As Button
End Class
