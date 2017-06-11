<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.no = New System.Windows.Forms.TextBox()
        Me.cancel = New System.Windows.Forms.Label()
        Me.save = New System.Windows.Forms.Label()
        Me.tit = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.CheckBox()
        Me.n = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(89, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(437, 43)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "1. Length of the password to be generated"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'no
        '
        Me.no.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no.ForeColor = System.Drawing.Color.Black
        Me.no.Location = New System.Drawing.Point(383, 65)
        Me.no.Multiline = True
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(69, 32)
        Me.no.TabIndex = 34
        Me.no.Text = "6"
        Me.no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cancel
        '
        Me.cancel.AllowDrop = True
        Me.cancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.ForeColor = System.Drawing.Color.White
        Me.cancel.Image = Global.PDFLocker.My.Resources.Resources.cross1
        Me.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancel.Location = New System.Drawing.Point(329, 224)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(277, 51)
        Me.cancel.TabIndex = 36
        Me.cancel.Text = "     Cancel && keep settings"
        Me.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'save
        '
        Me.save.AllowDrop = True
        Me.save.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.ForeColor = System.Drawing.Color.White
        Me.save.Image = Global.PDFLocker.My.Resources.Resources.tick
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save.Location = New System.Drawing.Point(26, 224)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(277, 51)
        Me.save.TabIndex = 35
        Me.save.Text = "Save these settings"
        Me.save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tit
        '
        Me.tit.AllowDrop = True
        Me.tit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tit.BackColor = System.Drawing.Color.Black
        Me.tit.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tit.ForeColor = System.Drawing.Color.White
        Me.tit.Image = Global.PDFLocker.My.Resources.Resources.settings_2
        Me.tit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tit.Location = New System.Drawing.Point(0, 0)
        Me.tit.Name = "tit"
        Me.tit.Size = New System.Drawing.Size(629, 48)
        Me.tit.TabIndex = 28
        Me.tit.Text = "App Settings"
        Me.tit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(89, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 96)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "2. Consider these formats to be used in the generated password"
        '
        'a
        '
        Me.a.BackColor = System.Drawing.Color.White
        Me.a.Checked = True
        Me.a.CheckState = System.Windows.Forms.CheckState.Checked
        Me.a.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.ForeColor = System.Drawing.Color.Black
        Me.a.Location = New System.Drawing.Point(113, 134)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(150, 27)
        Me.a.TabIndex = 39
        Me.a.Text = "Alphabets"
        Me.a.UseVisualStyleBackColor = False
        '
        'n
        '
        Me.n.BackColor = System.Drawing.Color.White
        Me.n.Checked = True
        Me.n.CheckState = System.Windows.Forms.CheckState.Checked
        Me.n.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n.ForeColor = System.Drawing.Color.Black
        Me.n.Location = New System.Drawing.Point(113, 167)
        Me.n.Name = "n"
        Me.n.Size = New System.Drawing.Size(150, 27)
        Me.n.TabIndex = 40
        Me.n.Text = "Numbers"
        Me.n.UseVisualStyleBackColor = False
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(629, 295)
        Me.Controls.Add(Me.n)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.no)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settings"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tit As System.Windows.Forms.Label
    Friend WithEvents no As System.Windows.Forms.TextBox
    Friend WithEvents save As System.Windows.Forms.Label
    Friend WithEvents cancel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents a As System.Windows.Forms.CheckBox
    Friend WithEvents n As System.Windows.Forms.CheckBox
End Class
