<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KetQua
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.hoTen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monHoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lanThi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 107)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kết quả sinh viên"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.hoTen, Me.monHoc, Me.lanThi, Me.diem})
        Me.DataGridView1.Location = New System.Drawing.Point(152, 125)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(466, 240)
        Me.DataGridView1.TabIndex = 2
        '
        'hoTen
        '
        Me.hoTen.HeaderText = "Họ tên"
        Me.hoTen.Name = "hoTen"
        Me.hoTen.Width = 130
        '
        'monHoc
        '
        Me.monHoc.HeaderText = "Môn Học"
        Me.monHoc.Name = "monHoc"
        '
        'lanThi
        '
        Me.lanThi.HeaderText = "Lần Thi"
        Me.lanThi.Name = "lanThi"
        '
        'diem
        '
        Me.diem.HeaderText = "Điểm"
        Me.diem.Name = "diem"
        '
        'KetQua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "KetQua"
        Me.Text = "KetQua"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents hoTen As DataGridViewTextBoxColumn
    Friend WithEvents monHoc As DataGridViewTextBoxColumn
    Friend WithEvents lanThi As DataGridViewTextBoxColumn
    Friend WithEvents diem As DataGridViewTextBoxColumn
End Class
