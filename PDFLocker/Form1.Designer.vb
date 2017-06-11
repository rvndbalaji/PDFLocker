<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Strt
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Strt))
        Me.notif = New System.Windows.Forms.Label()
        Me.tit = New System.Windows.Forms.Label()
        Me.table = New System.Windows.Forms.DataGridView()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fpass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpy = New System.Windows.Forms.Label()
        Me.slct = New System.Windows.Forms.Label()
        Me.no = New System.Windows.Forms.TextBox()
        Me.bar = New System.Windows.Forms.Panel()
        Me.menu = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Label()
        Me.lock = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.abt = New System.Windows.Forms.Label()
        Me.hlp = New System.Windows.Forms.Label()
        Me.sett = New System.Windows.Forms.Label()
        Me.tut = New System.Windows.Forms.Label()
        Me.tip = New System.Windows.Forms.Label()
        CType(Me.table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'notif
        '
        Me.notif.AllowDrop = True
        Me.notif.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.notif.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.notif.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notif.ForeColor = System.Drawing.Color.White
        Me.notif.Location = New System.Drawing.Point(0, 49)
        Me.notif.Name = "notif"
        Me.notif.Size = New System.Drawing.Size(775, 41)
        Me.notif.TabIndex = 4
        Me.notif.Text = "Welcome"
        Me.notif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tit
        '
        Me.tit.AllowDrop = True
        Me.tit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tit.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.tit.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tit.ForeColor = System.Drawing.Color.White
        Me.tit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tit.Location = New System.Drawing.Point(0, 0)
        Me.tit.Name = "tit"
        Me.tit.Size = New System.Drawing.Size(776, 53)
        Me.tit.TabIndex = 5
        Me.tit.Text = "       PDF Locker"
        Me.tit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'table
        '
        Me.table.AllowUserToAddRows = False
        Me.table.AllowUserToDeleteRows = False
        Me.table.AllowUserToResizeRows = False
        Me.table.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.table.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.table.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.table.ColumnHeadersHeight = 32
        Me.table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fname, Me.fpass})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.table.DefaultCellStyle = DataGridViewCellStyle2
        Me.table.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.table.Location = New System.Drawing.Point(461, 102)
        Me.table.Name = "table"
        Me.table.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.table.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.table.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
        Me.table.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.table.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table.RowTemplate.Height = 30
        Me.table.Size = New System.Drawing.Size(301, 296)
        Me.table.TabIndex = 9
        '
        'fname
        '
        Me.fname.HeaderText = "File Name"
        Me.fname.Name = "fname"
        Me.fname.ReadOnly = True
        '
        'fpass
        '
        Me.fpass.HeaderText = "Password"
        Me.fpass.Name = "fpass"
        Me.fpass.ReadOnly = True
        '
        'cpy
        '
        Me.cpy.AllowDrop = True
        Me.cpy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cpy.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.cpy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cpy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cpy.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpy.ForeColor = System.Drawing.Color.Black
        Me.cpy.Location = New System.Drawing.Point(274, 136)
        Me.cpy.Name = "cpy"
        Me.cpy.Size = New System.Drawing.Size(144, 41)
        Me.cpy.TabIndex = 12
        Me.cpy.Text = "Make copies..."
        Me.cpy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'slct
        '
        Me.slct.AllowDrop = True
        Me.slct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.slct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.slct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.slct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.slct.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slct.ForeColor = System.Drawing.Color.Black
        Me.slct.Location = New System.Drawing.Point(29, 136)
        Me.slct.Name = "slct"
        Me.slct.Size = New System.Drawing.Size(144, 41)
        Me.slct.TabIndex = 13
        Me.slct.Text = "Select PDF file"
        Me.slct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'no
        '
        Me.no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.no.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no.ForeColor = System.Drawing.Color.Black
        Me.no.Location = New System.Drawing.Point(179, 138)
        Me.no.Multiline = True
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(89, 39)
        Me.no.TabIndex = 15
        Me.no.Text = "1"
        Me.no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bar
        '
        Me.bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.bar.Controls.Add(Me.abt)
        Me.bar.Controls.Add(Me.hlp)
        Me.bar.Controls.Add(Me.sett)
        Me.bar.Controls.Add(Me.tut)
        Me.bar.Location = New System.Drawing.Point(0, 0)
        Me.bar.Name = "bar"
        Me.bar.Size = New System.Drawing.Size(0, 53)
        Me.bar.TabIndex = 17
        '
        'menu
        '
        Me.menu.AutoSize = True
        Me.menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.menu.FlatAppearance.BorderSize = 0
        Me.menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menu.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu.ForeColor = System.Drawing.Color.White
        Me.menu.Image = Global.PDFLocker.My.Resources.Resources._32
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(55, 53)
        Me.menu.TabIndex = 18
        Me.menu.UseVisualStyleBackColor = False
        '
        'save
        '
        Me.save.AllowDrop = True
        Me.save.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.Enabled = False
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.ForeColor = System.Drawing.Color.Black
        Me.save.Image = Global.PDFLocker.My.Resources.Resources._1422192174_save_32
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save.Location = New System.Drawing.Point(461, 402)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(301, 41)
        Me.save.TabIndex = 16
        Me.save.Text = "Save list to text file"
        Me.save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lock
        '
        Me.lock.AllowDrop = True
        Me.lock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lock.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.lock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lock.Enabled = False
        Me.lock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lock.ForeColor = System.Drawing.Color.Black
        Me.lock.Image = Global.PDFLocker.My.Resources.Resources._1422189312_lock_blue
        Me.lock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lock.Location = New System.Drawing.Point(136, 197)
        Me.lock.Name = "lock"
        Me.lock.Size = New System.Drawing.Size(181, 60)
        Me.lock.TabIndex = 14
        Me.lock.Text = "Start Locking       "
        Me.lock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.PDFLocker.My.Resources.Resources.File_pdf_64
        Me.PictureBox1.Location = New System.Drawing.Point(304, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'abt
        '
        Me.abt.AllowDrop = True
        Me.abt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.abt.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.abt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.abt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abt.ForeColor = System.Drawing.Color.Black
        Me.abt.Image = Global.PDFLocker.My.Resources.Resources._1415371857_ic_info_48px_32
        Me.abt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.abt.Location = New System.Drawing.Point(0, 203)
        Me.abt.Name = "abt"
        Me.abt.Size = New System.Drawing.Size(0, 50)
        Me.abt.TabIndex = 22
        Me.abt.Text = "About"
        Me.abt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hlp
        '
        Me.hlp.AllowDrop = True
        Me.hlp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hlp.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.hlp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hlp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hlp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hlp.ForeColor = System.Drawing.Color.Black
        Me.hlp.Image = Global.PDFLocker.My.Resources.Resources._1416997718_ic_help_48px_32
        Me.hlp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hlp.Location = New System.Drawing.Point(0, 153)
        Me.hlp.Name = "hlp"
        Me.hlp.Size = New System.Drawing.Size(0, 50)
        Me.hlp.TabIndex = 21
        Me.hlp.Text = "If you need help...      "
        Me.hlp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sett
        '
        Me.sett.AllowDrop = True
        Me.sett.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sett.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.sett.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sett.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sett.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sett.ForeColor = System.Drawing.Color.Black
        Me.sett.Image = Global.PDFLocker.My.Resources.Resources.settings_2
        Me.sett.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sett.Location = New System.Drawing.Point(0, 103)
        Me.sett.Name = "sett"
        Me.sett.Size = New System.Drawing.Size(0, 50)
        Me.sett.TabIndex = 20
        Me.sett.Text = "App Settings"
        Me.sett.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tut
        '
        Me.tut.AllowDrop = True
        Me.tut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tut.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tut.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tut.ForeColor = System.Drawing.Color.Black
        Me.tut.Image = Global.PDFLocker.My.Resources.Resources.Clipboard_flat_32
        Me.tut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tut.Location = New System.Drawing.Point(0, 54)
        Me.tut.Name = "tut"
        Me.tut.Size = New System.Drawing.Size(0, 49)
        Me.tut.TabIndex = 19
        Me.tut.Text = "How it works"
        Me.tut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tip
        '
        Me.tip.AllowDrop = True
        Me.tip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tip.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tip.ForeColor = System.Drawing.Color.White
        Me.tip.Location = New System.Drawing.Point(0, 398)
        Me.tip.Name = "tip"
        Me.tip.Size = New System.Drawing.Size(455, 49)
        Me.tip.TabIndex = 19
        Me.tip.Text = "Note : Password length and format can be changed in ""App Settings"""
        Me.tip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Strt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(774, 447)
        Me.Controls.Add(Me.tip)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.table)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bar)
        Me.Controls.Add(Me.tit)
        Me.Controls.Add(Me.notif)
        Me.Controls.Add(Me.lock)
        Me.Controls.Add(Me.no)
        Me.Controls.Add(Me.slct)
        Me.Controls.Add(Me.cpy)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Strt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents notif As System.Windows.Forms.Label
    Friend WithEvents tit As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents table As System.Windows.Forms.DataGridView
    Friend WithEvents fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fpass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cpy As System.Windows.Forms.Label
    Friend WithEvents slct As System.Windows.Forms.Label
    Friend WithEvents no As System.Windows.Forms.TextBox
    Friend WithEvents save As System.Windows.Forms.Label
    Friend WithEvents lock As System.Windows.Forms.Label
    Friend WithEvents bar As System.Windows.Forms.Panel
    Friend WithEvents menu As System.Windows.Forms.Button
    Friend WithEvents tut As System.Windows.Forms.Label
    Friend WithEvents sett As System.Windows.Forms.Label
    Friend WithEvents hlp As System.Windows.Forms.Label
    Friend WithEvents abt As System.Windows.Forms.Label
    Friend WithEvents tip As System.Windows.Forms.Label

End Class
