<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.jmkerja = New System.Windows.Forms.TextBox()
        Me.jmlembur = New System.Windows.Forms.TextBox()
        Me.jmtidakhadir = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.totalgaji = New System.Windows.Forms.Label()
        Me.uangmakan = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(323, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Perhitungan Gaji Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = " Jml Jam Kerja"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jml Lembur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jml Tidak Hadir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(382, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Gaji"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(382, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Uang Makan"
        '
        'jmkerja
        '
        Me.jmkerja.Location = New System.Drawing.Point(199, 65)
        Me.jmkerja.Name = "jmkerja"
        Me.jmkerja.Size = New System.Drawing.Size(100, 22)
        Me.jmkerja.TabIndex = 6
        '
        'jmlembur
        '
        Me.jmlembur.Location = New System.Drawing.Point(199, 117)
        Me.jmlembur.Name = "jmlembur"
        Me.jmlembur.Size = New System.Drawing.Size(100, 22)
        Me.jmlembur.TabIndex = 7
        '
        'jmtidakhadir
        '
        Me.jmtidakhadir.Location = New System.Drawing.Point(199, 171)
        Me.jmtidakhadir.Name = "jmtidakhadir"
        Me.jmtidakhadir.Size = New System.Drawing.Size(100, 22)
        Me.jmtidakhadir.TabIndex = 8
        Me.jmtidakhadir.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(144, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 33)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'totalgaji
        '
        Me.totalgaji.AutoSize = True
        Me.totalgaji.Location = New System.Drawing.Point(559, 65)
        Me.totalgaji.Name = "totalgaji"
        Me.totalgaji.Size = New System.Drawing.Size(57, 17)
        Me.totalgaji.TabIndex = 12
        Me.totalgaji.Text = "totalgaji"
        '
        'uangmakan
        '
        Me.uangmakan.AutoSize = True
        Me.uangmakan.Location = New System.Drawing.Point(559, 117)
        Me.uangmakan.Name = "uangmakan"
        Me.uangmakan.Size = New System.Drawing.Size(82, 17)
        Me.uangmakan.TabIndex = 13
        Me.uangmakan.Text = "uangmakan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 389)
        Me.Controls.Add(Me.uangmakan)
        Me.Controls.Add(Me.totalgaji)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.jmtidakhadir)
        Me.Controls.Add(Me.jmlembur)
        Me.Controls.Add(Me.jmkerja)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Jml Tidak Hadir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents jmkerja As System.Windows.Forms.TextBox
    Friend WithEvents jmlembur As System.Windows.Forms.TextBox
    Friend WithEvents jmtidakhadir As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents totalgaji As System.Windows.Forms.Label
    Friend WithEvents uangmakan As System.Windows.Forms.Label

End Class
