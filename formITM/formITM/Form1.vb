Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hitung.Click
        Dim hitung As Double


        hitung = Me.BB.Text / (Me.TB.Text * Me.TB.Text) * 10000
        Me.Hasil.Text = hitung

    End Sub
End Class
