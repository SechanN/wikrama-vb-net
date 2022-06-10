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
        Me.BB = New System.Windows.Forms.TextBox()
        Me.TB = New System.Windows.Forms.TextBox()
        Me.Hasil = New System.Windows.Forms.TextBox()
        Me.hitung = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Berat Badan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tinggi Badan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasil"
        '
        'BB
        '
        Me.BB.Location = New System.Drawing.Point(373, 65)
        Me.BB.Name = "BB"
        Me.BB.Size = New System.Drawing.Size(100, 22)
        Me.BB.TabIndex = 3
        Me.BB.Text = "60"
        '
        'TB
        '
        Me.TB.Location = New System.Drawing.Point(373, 122)
        Me.TB.Name = "TB"
        Me.TB.Size = New System.Drawing.Size(100, 22)
        Me.TB.TabIndex = 4
        Me.TB.Text = "169"
        '
        'Hasil
        '
        Me.Hasil.Location = New System.Drawing.Point(373, 201)
        Me.Hasil.Name = "Hasil"
        Me.Hasil.Size = New System.Drawing.Size(100, 22)
        Me.Hasil.TabIndex = 5
        '
        'hitung
        '
        Me.hitung.Location = New System.Drawing.Point(62, 160)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(411, 23)
        Me.hitung.TabIndex = 6
        Me.hitung.Text = "Hitung"
        Me.hitung.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Kalkulator IMT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1499, 253)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.hitung)
        Me.Controls.Add(Me.Hasil)
        Me.Controls.Add(Me.TB)
        Me.Controls.Add(Me.BB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BB As System.Windows.Forms.TextBox
    Friend WithEvents TB As System.Windows.Forms.TextBox
    Friend WithEvents Hasil As System.Windows.Forms.TextBox
    Friend WithEvents hitung As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
