<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PicGreen = New System.Windows.Forms.PictureBox()
        Me.PicBlue = New System.Windows.Forms.PictureBox()
        Me.PicRed = New System.Windows.Forms.PictureBox()
        Me.PicYellow = New System.Windows.Forms.PictureBox()
        Me.PicPurple = New System.Windows.Forms.PictureBox()
        Me.LblScore = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EndProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PicGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicYellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPurple, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicGreen
        '
        Me.PicGreen.BackColor = System.Drawing.Color.DarkGreen
        Me.PicGreen.Location = New System.Drawing.Point(184, 24)
        Me.PicGreen.Name = "PicGreen"
        Me.PicGreen.Size = New System.Drawing.Size(200, 100)
        Me.PicGreen.TabIndex = 1
        Me.PicGreen.TabStop = False
        '
        'PicBlue
        '
        Me.PicBlue.BackColor = System.Drawing.Color.Navy
        Me.PicBlue.Location = New System.Drawing.Point(297, 338)
        Me.PicBlue.Name = "PicBlue"
        Me.PicBlue.Size = New System.Drawing.Size(200, 100)
        Me.PicBlue.TabIndex = 2
        Me.PicBlue.TabStop = False
        '
        'PicRed
        '
        Me.PicRed.BackColor = System.Drawing.Color.Firebrick
        Me.PicRed.Location = New System.Drawing.Point(572, 141)
        Me.PicRed.Name = "PicRed"
        Me.PicRed.Size = New System.Drawing.Size(100, 200)
        Me.PicRed.TabIndex = 3
        Me.PicRed.TabStop = False
        '
        'PicYellow
        '
        Me.PicYellow.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.PicYellow.Location = New System.Drawing.Point(144, 141)
        Me.PicYellow.Name = "PicYellow"
        Me.PicYellow.Size = New System.Drawing.Size(100, 200)
        Me.PicYellow.TabIndex = 4
        Me.PicYellow.TabStop = False
        '
        'PicPurple
        '
        Me.PicPurple.BackColor = System.Drawing.Color.Purple
        Me.PicPurple.Location = New System.Drawing.Point(435, 24)
        Me.PicPurple.Name = "PicPurple"
        Me.PicPurple.Size = New System.Drawing.Size(200, 100)
        Me.PicPurple.TabIndex = 5
        Me.PicPurple.TabStop = False
        '
        'LblScore
        '
        Me.LblScore.AutoSize = True
        Me.LblScore.BackColor = System.Drawing.Color.Transparent
        Me.LblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScore.Location = New System.Drawing.Point(362, 223)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(74, 25)
        Me.LblScore.TabIndex = 6
        Me.LblScore.Text = "Score:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 42)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Simon"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EndProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EndProgramToolStripMenuItem
        '
        Me.EndProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EndToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.EndProgramToolStripMenuItem.Name = "EndProgramToolStripMenuItem"
        Me.EndProgramToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.EndProgramToolStripMenuItem.Text = "End Program"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.EndToolStripMenuItem.Text = "End"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'Hard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final_Project_Master___Simon.My.Resources.Resources.SimonHardTabelTop
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblScore)
        Me.Controls.Add(Me.PicPurple)
        Me.Controls.Add(Me.PicYellow)
        Me.Controls.Add(Me.PicRed)
        Me.Controls.Add(Me.PicBlue)
        Me.Controls.Add(Me.PicGreen)
        Me.Name = "Hard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hard"
        CType(Me.PicGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicYellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPurple, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicGreen As PictureBox
    Friend WithEvents PicBlue As PictureBox
    Friend WithEvents PicRed As PictureBox
    Friend WithEvents PicYellow As PictureBox
    Friend WithEvents PicPurple As PictureBox
    Friend WithEvents LblScore As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EndProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
End Class
