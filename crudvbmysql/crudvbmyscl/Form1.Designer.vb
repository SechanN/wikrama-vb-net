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
        Me.kodebuku = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.kode_buku = New System.Windows.Forms.TextBox()
        Me.judul_buku = New System.Windows.Forms.TextBox()
        Me.penerbit = New System.Windows.Forms.TextBox()
        Me.jenis_buku = New System.Windows.Forms.TextBox()
        Me.create = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kodebuku
        '
        Me.kodebuku.AutoSize = True
        Me.kodebuku.Location = New System.Drawing.Point(34, 33)
        Me.kodebuku.Name = "kodebuku"
        Me.kodebuku.Size = New System.Drawing.Size(77, 17)
        Me.kodebuku.TabIndex = 0
        Me.kodebuku.Text = "Kode Buku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Judul Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(332, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Penerbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(332, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Buku"
        '
        'kode_buku
        '
        Me.kode_buku.Location = New System.Drawing.Point(173, 33)
        Me.kode_buku.Name = "kode_buku"
        Me.kode_buku.Size = New System.Drawing.Size(100, 22)
        Me.kode_buku.TabIndex = 4
        '
        'judul_buku
        '
        Me.judul_buku.Location = New System.Drawing.Point(173, 80)
        Me.judul_buku.Name = "judul_buku"
        Me.judul_buku.Size = New System.Drawing.Size(100, 22)
        Me.judul_buku.TabIndex = 5
        '
        'penerbit
        '
        Me.penerbit.Location = New System.Drawing.Point(415, 30)
        Me.penerbit.Name = "penerbit"
        Me.penerbit.Size = New System.Drawing.Size(100, 22)
        Me.penerbit.TabIndex = 6
        '
        'jenis_buku
        '
        Me.jenis_buku.Location = New System.Drawing.Point(415, 82)
        Me.jenis_buku.Name = "jenis_buku"
        Me.jenis_buku.Size = New System.Drawing.Size(100, 22)
        Me.jenis_buku.TabIndex = 7
        '
        'create
        '
        Me.create.Location = New System.Drawing.Point(61, 160)
        Me.create.Name = "create"
        Me.create.Size = New System.Drawing.Size(75, 23)
        Me.create.TabIndex = 8
        Me.create.Text = "Create"
        Me.create.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(223, 160)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(75, 23)
        Me.edit.TabIndex = 9
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(415, 159)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(75, 23)
        Me.delete.TabIndex = 10
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 226)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(478, 150)
        Me.DataGridView1.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 410)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.create)
        Me.Controls.Add(Me.jenis_buku)
        Me.Controls.Add(Me.penerbit)
        Me.Controls.Add(Me.judul_buku)
        Me.Controls.Add(Me.kode_buku)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.kodebuku)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents kodebuku As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents kode_buku As System.Windows.Forms.TextBox
    Friend WithEvents judul_buku As System.Windows.Forms.TextBox
    Friend WithEvents penerbit As System.Windows.Forms.TextBox
    Friend WithEvents jenis_buku As System.Windows.Forms.TextBox
    Friend WithEvents create As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
