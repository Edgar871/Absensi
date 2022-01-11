Imports System.Data.OleDb
Imports System.IO
Public Class Form1
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\dataAbsen.accdb")
    Dim dataRead As OleDbDataReader
    Dim i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            lbl_Connection.Text = "Connected"
            lbl_Connection.ForeColor = Color.Lime
        Catch ex As Exception
            lbl_Connection.Text = "DisConnected"
            lbl_Connection.ForeColor = Color.Red
        End Try
        conn.Close()
        txt_ID.Text = "[AUTO]"
        txt_ID.Enabled = False
    End Sub

    Sub clear()
        txt_ID.Text = "[AUTO]"
        txt_Nama.Clear()
        txt_Alamat.Clear()
        txt_Durasi.Clear()
    End Sub
    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        clear()
    End Sub

    Sub save()
        Try
            conn.Open()
            If MsgBox("Apakah kamu yakin ingin menyimpan data?", vbQuestion + vbYesNo) = vbYes Then
                Dim dataAbsen As New OleDb.OleDbCommand("Insert into dataAbsen(`Nama`, `Jabatan`, `Durasi`, `Alamat`, `Absen`, Waktu, `Timer`) values(@Nama, @Jabatan, @Durasi, @Alamat, @Absen, @Waktu, @Timer)", conn)
                dataAbsen.Parameters.Clear()
                dataAbsen.Parameters.AddWithValue("@Nama", txt_Nama.Text)
                dataAbsen.Parameters.AddWithValue("@Jabatan", cb_Jabatan.Text)
                dataAbsen.Parameters.AddWithValue("@Durasi", txt_Durasi.Text)
                dataAbsen.Parameters.AddWithValue("@Alamat", txt_Alamat.Text)
                dataAbsen.Parameters.AddWithValue("@Absen", cb_Absen.Text)
                dataAbsen.Parameters.AddWithValue("@Waktu", DateTimePicker1.Text)
                dataAbsen.Parameters.AddWithValue("@Timer", TimeOfDay.ToString("HH:mm:ss"))
                i = dataAbsen.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Data Berhasil Disimpan!", vbInformation)
                End If
            Else
                MsgBox("Data Gagal Disimpan!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub btn_Simpan_Click(sender As Object, e As EventArgs) Handles btn_Simpan.Click
        save()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
