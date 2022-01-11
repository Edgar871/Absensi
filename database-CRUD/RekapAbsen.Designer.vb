<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RekapAbsen
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_Durasi = New System.Windows.Forms.TextBox()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Hapus = New System.Windows.Forms.Button()
        Me.btn_Simpan = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cb_Absen = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Alamat = New System.Windows.Forms.TextBox()
        Me.cb_Jabatan = New System.Windows.Forms.ComboBox()
        Me.txt_Nama = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.lbl_Connection = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 45)
        Me.Panel1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(378, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rekap Absen"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(774, 518)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 25)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Tampilkan Daftar Pegawai"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 518)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 22)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_Durasi
        '
        Me.txt_Durasi.Location = New System.Drawing.Point(107, 192)
        Me.txt_Durasi.Name = "txt_Durasi"
        Me.txt_Durasi.Size = New System.Drawing.Size(129, 23)
        Me.txt_Durasi.TabIndex = 18
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(161, 346)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_Clear.TabIndex = 17
        Me.btn_Clear.Text = "Bersihkan"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(18, 380)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Edit.TabIndex = 16
        Me.btn_Edit.Text = "Edit"
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_Hapus
        '
        Me.btn_Hapus.Location = New System.Drawing.Point(161, 380)
        Me.btn_Hapus.Name = "btn_Hapus"
        Me.btn_Hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_Hapus.TabIndex = 15
        Me.btn_Hapus.Text = "Hapus"
        Me.btn_Hapus.UseVisualStyleBackColor = True
        '
        'btn_Simpan
        '
        Me.btn_Simpan.Location = New System.Drawing.Point(18, 346)
        Me.btn_Simpan.Name = "btn_Simpan"
        Me.btn_Simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_Simpan.TabIndex = 14
        Me.btn_Simpan.Text = "Simpan"
        Me.btn_Simpan.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Absen"
        '
        'cb_Absen
        '
        Me.cb_Absen.FormattingEnabled = True
        Me.cb_Absen.Items.AddRange(New Object() {"HADIR", "TERLAMBAT", "IZIN", "ALFA"})
        Me.cb_Absen.Location = New System.Drawing.Point(107, 274)
        Me.cb_Absen.Name = "cb_Absen"
        Me.cb_Absen.Size = New System.Drawing.Size(129, 23)
        Me.cb_Absen.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 30)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Durasi Kerja " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(dalam menit)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Jabatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nama"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txt_Durasi)
        Me.GroupBox1.Controls.Add(Me.btn_Clear)
        Me.GroupBox1.Controls.Add(Me.btn_Edit)
        Me.GroupBox1.Controls.Add(Me.btn_Hapus)
        Me.GroupBox1.Controls.Add(Me.btn_Simpan)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cb_Absen)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Alamat)
        Me.GroupBox1.Controls.Add(Me.cb_Jabatan)
        Me.GroupBox1.Controls.Add(Me.txt_Nama)
        Me.GroupBox1.Controls.Add(Me.txt_ID)
        Me.GroupBox1.Controls.Add(Me.lbl_Connection)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 415)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form Absen"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy H:mm:ss"
        Me.DateTimePicker1.Location = New System.Drawing.Point(29, 309)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePicker1.TabIndex = 19
        Me.DateTimePicker1.Value = New Date(2022, 1, 10, 13, 17, 41, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ID"
        '
        'txt_Alamat
        '
        Me.txt_Alamat.Location = New System.Drawing.Point(107, 233)
        Me.txt_Alamat.Name = "txt_Alamat"
        Me.txt_Alamat.Size = New System.Drawing.Size(129, 23)
        Me.txt_Alamat.TabIndex = 5
        '
        'cb_Jabatan
        '
        Me.cb_Jabatan.FormattingEnabled = True
        Me.cb_Jabatan.Items.AddRange(New Object() {"SPV", "Staff"})
        Me.cb_Jabatan.Location = New System.Drawing.Point(107, 147)
        Me.cb_Jabatan.Name = "cb_Jabatan"
        Me.cb_Jabatan.Size = New System.Drawing.Size(129, 23)
        Me.cb_Jabatan.TabIndex = 4
        '
        'txt_Nama
        '
        Me.txt_Nama.Location = New System.Drawing.Point(107, 106)
        Me.txt_Nama.Name = "txt_Nama"
        Me.txt_Nama.Size = New System.Drawing.Size(129, 23)
        Me.txt_Nama.TabIndex = 3
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(107, 67)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(129, 23)
        Me.txt_ID.TabIndex = 2
        '
        'lbl_Connection
        '
        Me.lbl_Connection.AutoSize = True
        Me.lbl_Connection.Location = New System.Drawing.Point(87, 24)
        Me.lbl_Connection.Name = "lbl_Connection"
        Me.lbl_Connection.Size = New System.Drawing.Size(12, 15)
        Me.lbl_Connection.TabIndex = 1
        Me.lbl_Connection.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Status DB :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(288, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(660, 415)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tabel Absen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Cari"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.Column1, Me.Column2})
        Me.DataGridView2.Location = New System.Drawing.Point(10, 65)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(643, 150)
        Me.DataGridView2.TabIndex = 20
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(82, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(281, 23)
        Me.TextBox1.TabIndex = 18
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Jabatan"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Durasi Kerja"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Alamat"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Absen"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Waktu"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 75
        '
        'Column2
        '
        Me.Column2.HeaderText = "Timer"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'RekapAbsen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 551)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "RekapAbsen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rekap Absen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_Durasi As TextBox
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Edit As Button
    Friend WithEvents btn_Hapus As Button
    Friend WithEvents btn_Simpan As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cb_Absen As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Alamat As TextBox
    Friend WithEvents cb_Jabatan As ComboBox
    Friend WithEvents txt_Nama As TextBox
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents lbl_Connection As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
