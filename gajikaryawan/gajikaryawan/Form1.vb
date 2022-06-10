Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim jmkerja, jmlembur, jmtidakhadir, uangmakan, totalgaji As Integer

        jmkerja = Me.jmkerja.Text * 15000
        jmlembur = Me.jmlembur.Text * 10000
        jmtidakhadir = Me.jmtidakhadir.Text * 100000



        totalgaji = jmkerja + jmlembur - jmtidakhadir
        uangmakan = Me.jmkerja.Text * 10000

        Me.totalgaji.Text = totalgaji
        Me.uangmakan.Text = uangmakan


    End Sub

    Private Sub totalgaji_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles totalgaji.Click

    End Sub
End Class
