Imports System.IO
Public Class DaftarPegawai

    Private Sub DaftarPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StreamToDisplay As StreamReader
        StreamToDisplay =
         New StreamReader("C:\Users\Edgar Hadhyra J\source\repos\database-CRUD\DataPegawai.txt")
        txtNote.Text = StreamToDisplay.ReadToEnd
        StreamToDisplay.Close()
        txtNote.Select(0, 0)
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim i As Integer
        Dim totalWord As String
        Dim AllText As String
        For i = 1 To txtNote.TextLength
            txtNote.Find(txtSearch.Text.Trim(), i, RichTextBoxFinds.WholeWord)
            txtNote.SelectionColor = Color.White
            txtNote.SelectionBackColor = Color.Green
        Next

        Dim count As Integer
        For i = 1 To txtNote.Text.Split(" ").Length - 1
            If txtNote.Text.Split(" ")(i).Trim().ToLower() = txtSearch.Text.Trim() Then
                count = count + 1
            End If
        Next
        totalWord = count.ToString()
        AllText = txtNote.Text
        If AllText.Contains(txtSearch.Text) Then
        Else
            MessageBox.Show("Kata tidak ditemukan", "Hasil Pencarian")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class