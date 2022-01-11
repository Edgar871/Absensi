<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Text = "Form Absen Pegawai, " + Format(Now, "hh:mm:ss tt")
    End Sub


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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txt_Durasi = New System.Windows.Forms.TextBox()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Simpan = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cb_Absen = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Alamat = New System.Windows.Forms.TextBox()
        Me.cb_Jabatan = New System.Windows.Forms.ComboBox()
        Me.txt_Nama = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.lbl_Connection = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(814, 60)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(251, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Absensi"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txt_Durasi)
        Me.GroupBox1.Controls.Add(Me.btn_Clear)
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
        Me.GroupBox1.Location = New System.Drawing.Point(32, 87)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(651, 501)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form Absen"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(37, 399)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(228, 27)
        Me.DateTimePicker1.TabIndex = 19
        Me.DateTimePicker1.Value = New Date(2022, 1, 10, 12, 18, 11, 0)
        '
        'txt_Durasi
        '
        Me.txt_Durasi.Location = New System.Drawing.Point(304, 239)
        Me.txt_Durasi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Durasi.Name = "txt_Durasi"
        Me.txt_Durasi.Size = New System.Drawing.Size(147, 27)
        Me.txt_Durasi.TabIndex = 18
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(184, 449)
        Me.btn_Clear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(86, 31)
        Me.btn_Clear.TabIndex = 17
        Me.btn_Clear.Text = "Bersihkan"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Simpan
        '
        Me.btn_Simpan.Location = New System.Drawing.Point(21, 449)
        Me.btn_Simpan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Simpan.Name = "btn_Simpan"
        Me.btn_Simpan.Size = New System.Drawing.Size(86, 31)
        Me.btn_Simpan.TabIndex = 14
        Me.btn_Simpan.Text = "Simpan"
        Me.btn_Simpan.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Absen"
        '
        'cb_Absen
        '
        Me.cb_Absen.FormattingEnabled = True
        Me.cb_Absen.Items.AddRange(New Object() {"HADIR", "TERLAMBAT", "IZIN", "ALFA"})
        Me.cb_Absen.Location = New System.Drawing.Point(304, 348)
        Me.cb_Absen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cb_Absen.Name = "cb_Absen"
        Me.cb_Absen.Size = New System.Drawing.Size(147, 28)
        Me.cb_Absen.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 40)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Durasi Kerja " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(dalam menit)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Jabatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ID"
        '
        'txt_Alamat
        '
        Me.txt_Alamat.Location = New System.Drawing.Point(304, 293)
        Me.txt_Alamat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Alamat.Name = "txt_Alamat"
        Me.txt_Alamat.Size = New System.Drawing.Size(147, 27)
        Me.txt_Alamat.TabIndex = 5
        '
        'cb_Jabatan
        '
        Me.cb_Jabatan.FormattingEnabled = True
        Me.cb_Jabatan.Items.AddRange(New Object() {"SPV", "Staff"})
        Me.cb_Jabatan.Location = New System.Drawing.Point(304, 179)
        Me.cb_Jabatan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cb_Jabatan.Name = "cb_Jabatan"
        Me.cb_Jabatan.Size = New System.Drawing.Size(147, 28)
        Me.cb_Jabatan.TabIndex = 4
        '
        'txt_Nama
        '
        Me.txt_Nama.Location = New System.Drawing.Point(304, 124)
        Me.txt_Nama.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Nama.Name = "txt_Nama"
        Me.txt_Nama.Size = New System.Drawing.Size(147, 27)
        Me.txt_Nama.TabIndex = 3
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(304, 72)
        Me.txt_ID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(147, 27)
        Me.txt_ID.TabIndex = 2
        '
        'lbl_Connection
        '
        Me.lbl_Connection.AutoSize = True
        Me.lbl_Connection.Location = New System.Drawing.Point(99, 31)
        Me.lbl_Connection.Name = "lbl_Connection"
        Me.lbl_Connection.Size = New System.Drawing.Size(15, 20)
        Me.lbl_Connection.TabIndex = 1
        Me.lbl_Connection.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Status DB :"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(708, 564)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 605)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Absen Pegawai"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Alamat As TextBox
    Friend WithEvents cb_Jabatan As ComboBox
    Friend WithEvents txt_Nama As TextBox
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents lbl_Connection As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cb_Absen As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Simpan As Button
    Friend WithEvents txt_Durasi As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
End Class
