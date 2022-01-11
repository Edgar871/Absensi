Imports System.Data.OleDb
Imports System.IO
Public Class RekapAbsen
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\dataAbsen.accdb")
    Dim dataRead As OleDbDataReader
    Dim i As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Text = "Rekap Absen, " + Format(Now, "hh:mm:ss tt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DaftarPegawai.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub RekapAbsen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            lbl_Connection.Text = "Connected"
            lbl_Connection.ForeColor = Color.Lime
        Catch ex As Exception
            lbl_Connection.Text = "DisConnected"
            lbl_Connection.ForeColor = Color.Red
        End Try
        conn.Close()
        loadingDatagridView()
        txt_ID.Text = "[AUTO]"
        txt_ID.Enabled = False
    End Sub

    Sub loadingDatagridView()
        Try
            DataGridView2.Rows.Clear()
            conn.Open()
            Dim dataAbsen As New OleDb.OleDbCommand("Select * from dataAbsen", conn)
            dataRead = dataAbsen.ExecuteReader
            While dataRead.Read
                DataGridView2.Rows.Add(dataRead.Item("ID"), dataRead.Item("Nama"), dataRead.Item("Jabatan"), dataRead.Item("Durasi"), dataRead.Item("Alamat"), dataRead.Item("Absen"), dataRead.Item("Waktu"), dataRead.Item("Timer"))
            End While
            dataRead.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
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
        loadingDatagridView()
    End Sub
    Private Sub btn_Simpan_Click(sender As Object, e As EventArgs) Handles btn_Simpan.Click
        save()
        'ListBox1.Items.Add(Result)
        'history.ListBox1.Items.Add(Format(Now, "MM/dd/yyyy hh:mm:ss tt") & " Added " & dataAbsen)
    End Sub

    Sub delete()
        Try
            conn.Open()
            If MsgBox("Apakah kamu yakin ingin menghapus data?", vbQuestion + vbYesNo) = vbYes Then
                Dim dataAbsen As New OleDbCommand("Delete * from dataAbsen  where ID=@ID", conn)
                dataAbsen.Parameters.Clear()

                dataAbsen.Parameters.AddWithValue("@ID", txt_ID.Text)
                i = dataAbsen.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Data berhasil dihapus", vbInformation)
                End If
            Else
                MsgBox("Gagal menghapus data", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingDatagridView()
    End Sub
    Private Sub btn_Hapus_Click(sender As Object, e As EventArgs) Handles btn_Hapus.Click
        delete()
    End Sub

    Sub edit()
        Try
            conn.Open()
            If MsgBox("Apakah kamu yakin ingin mengubah data?", vbQuestion + vbYesNo) = vbYes Then
                Dim dataAbsen As New OleDbCommand("UPDATE dataAbsen SET `Nama`=@Nama,`Jabatan`=@Jabatan,`Durasi`=@Durasi,`Alamat`=@Alamat,`Absen`=@Absen,`Waktu`=@Waktu,`Timer`=@Timer where ID=@ID", conn)
                dataAbsen.Parameters.Clear()
                dataAbsen.Parameters.AddWithValue("@Nama", txt_Nama.Text)
                dataAbsen.Parameters.AddWithValue("@Jabatan", cb_Jabatan.Text)
                dataAbsen.Parameters.AddWithValue("@Durasi", txt_Durasi.Text)
                dataAbsen.Parameters.AddWithValue("@Alamat", txt_Alamat.Text)
                dataAbsen.Parameters.AddWithValue("@Absen", cb_Absen.Text)
                dataAbsen.Parameters.AddWithValue("@Waktu", DateTimePicker1.Text)
                dataAbsen.Parameters.AddWithValue("@Timer", TimeOfDay.ToString("HH:mm:ss"))
                dataAbsen.Parameters.AddWithValue("@ID", txt_ID.Text)
                i = dataAbsen.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Data berhasil diubah", vbInformation)
                End If
            Else
                MsgBox("gagal mengubah data", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingDatagridView()
    End Sub
    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        edit()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        txt_ID.Text = DataGridView2.CurrentRow.Cells(0).Value
        txt_Nama.Text = DataGridView2.CurrentRow.Cells(1).Value
        cb_Jabatan.Text = DataGridView2.CurrentRow.Cells(2).Value
        txt_Durasi.Text = DataGridView2.CurrentRow.Cells(3).Value
        txt_Alamat.Text = DataGridView2.CurrentRow.Cells(4).Value
        cb_Absen.Text = DataGridView2.CurrentRow.Cells(5).Value
    End Sub

    Sub search()
        Try

            DataGridView2.Rows.Clear()
            conn.Open()
            Dim dataAbsen As New OleDbCommand("Select *from dataAbsen where `Nama` like '%" & TextBox1.Text & "%' or `Absen` like '%" & TextBox1.Text & "%' ", conn)
            dataRead = dataAbsen.ExecuteReader
            While dataRead.Read
                DataGridView2.Rows.Add(dataRead.Item("ID"), dataRead.Item("Nama"), dataRead.Item("Jabatan"), dataRead.Item("Durasi"), dataRead.Item("Alamat"), dataRead.Item("Absen"))

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        search()
    End Sub
End Class