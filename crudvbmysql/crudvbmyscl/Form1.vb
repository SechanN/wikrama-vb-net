Imports System.Data.Odbc

Public Class Form1

    Sub awal()
        kode_buku.Text = ""
        judul_buku.Text = ""
        penerbit.Text = ""
        jenis_buku.Text = ""

        Call Koneksi()
        da = New OdbcDataAdapter("Select * From tb_buku", conn)
        ds = New DataSet

        da.Fill(ds, "tb_buku")
        DataGridView1.DataSource = ds.Tables("tb_buku")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles create.Click
        If kode_buku.Text = "" Or judul_buku.Text = "" Or penerbit.Text = "" Or jenis_buku.Text = "" Then
            MsgBox("Pastikan data tidak boleh kosong")
        Else
            Call Koneksi()
            Dim create As String = "insert into tb_buku values ('" & kode_buku.Text & "','" & judul_buku.Text & "','" & penerbit.Text & "','" & jenis_buku.Text & "')"
            CMD = New OdbcCommand(create, conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Ditambahkan")

            Call awal()

        End If

    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        If kode_buku.Text = "" Or judul_buku.Text = "" Or penerbit.Text = "" Or jenis_buku.Text = "" Then
            MsgBox("Pastikan data tidak boleh kosong")
        Else
            Call Koneksi()
            Dim edit As String = "update ignore tb_buku SET kode_buku='" & kode_buku.Text & "', judul_buku='" & judul_buku.Text & "',penerbit='" & penerbit.Text & "',jenis_buku='" & jenis_buku.Text & "'"
            CMD = New OdbcCommand(edit, conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Diedit")

            Call awal()

        End If
    End Sub


    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        If kode_buku.Text = "" Or judul_buku.Text = "" Or penerbit.Text = "" Or jenis_buku.Text = "" Then
            MsgBox("Pastikan data tidak boleh kosong")
        Else
            Call Koneksi()
            Dim delete As String = "delete from tb_buku where kode_buku='" & kode_buku.Text & "'"
            CMD = New OdbcCommand(delete, conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Dihapus")

            Call awal()

        End If
    End Sub

    Private Sub kode_buku_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles kode_buku.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            CMD = New OdbcCommand("SELECT * FROM tb_buku WHERE kode_buku='" & kode_buku.Text & "'")
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                judul_buku.Text = RD.Item("judul")
                penerbit.Text = RD.Item("penerbit")
                jenis_buku.Text = RD.Item("jenis_buku")


            Else
                MsgBox("Data Tidak Ditemukan")

            End If
        End If

    End Sub

End Class
