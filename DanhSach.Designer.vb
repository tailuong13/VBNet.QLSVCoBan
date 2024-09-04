<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DanhSach
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Masv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hoten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Namsinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tenlop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThemBtn = New System.Windows.Forms.Button()
        Me.SuaBtn = New System.Windows.Forms.Button()
        Me.XoaBtn = New System.Windows.Forms.Button()
        Me.LabelMSV = New System.Windows.Forms.Label()
        Me.LabelHoTen = New System.Windows.Forms.Label()
        Me.LabelNamSinh = New System.Windows.Forms.Label()
        Me.LabelTenLop = New System.Windows.Forms.Label()
        Me.TextMSV = New System.Windows.Forms.TextBox()
        Me.TextHoTen = New System.Windows.Forms.TextBox()
        Me.TextNamSinh = New System.Windows.Forms.TextBox()
        Me.TextTenLop = New System.Windows.Forms.TextBox()
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
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Danh Sách Sinh Viên"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Masv, Me.Hoten, Me.Namsinh, Me.Tenlop})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(365, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(423, 216)
        Me.DataGridView1.TabIndex = 1
        '
        'Masv
        '
        Me.Masv.HeaderText = "MSV"
        Me.Masv.Name = "Masv"
        Me.Masv.Width = 70
        '
        'Hoten
        '
        Me.Hoten.HeaderText = "Họ Tên"
        Me.Hoten.Name = "Hoten"
        Me.Hoten.Width = 130
        '
        'Namsinh
        '
        Me.Namsinh.HeaderText = "Năm sinh"
        Me.Namsinh.Name = "Namsinh"
        Me.Namsinh.Width = 50
        '
        'Tenlop
        '
        Me.Tenlop.HeaderText = "Tên Lớp"
        Me.Tenlop.Name = "Tenlop"
        Me.Tenlop.Width = 130
        '
        'ThemBtn
        '
        Me.ThemBtn.Location = New System.Drawing.Point(12, 358)
        Me.ThemBtn.Name = "ThemBtn"
        Me.ThemBtn.Size = New System.Drawing.Size(97, 44)
        Me.ThemBtn.TabIndex = 2
        Me.ThemBtn.Text = "Thêm"
        Me.ThemBtn.UseVisualStyleBackColor = True
        '
        'SuaBtn
        '
        Me.SuaBtn.Location = New System.Drawing.Point(137, 358)
        Me.SuaBtn.Name = "SuaBtn"
        Me.SuaBtn.Size = New System.Drawing.Size(97, 44)
        Me.SuaBtn.TabIndex = 3
        Me.SuaBtn.Text = "Sửa"
        Me.SuaBtn.UseVisualStyleBackColor = True
        '
        'XoaBtn
        '
        Me.XoaBtn.Location = New System.Drawing.Point(266, 358)
        Me.XoaBtn.Name = "XoaBtn"
        Me.XoaBtn.Size = New System.Drawing.Size(97, 44)
        Me.XoaBtn.TabIndex = 4
        Me.XoaBtn.Text = "Xóa"
        Me.XoaBtn.UseVisualStyleBackColor = True
        '
        'LabelMSV
        '
        Me.LabelMSV.AutoSize = True
        Me.LabelMSV.Location = New System.Drawing.Point(14, 136)
        Me.LabelMSV.Name = "LabelMSV"
        Me.LabelMSV.Size = New System.Drawing.Size(70, 13)
        Me.LabelMSV.TabIndex = 5
        Me.LabelMSV.Text = "Mã Sinh Viên"
        '
        'LabelHoTen
        '
        Me.LabelHoTen.AutoSize = True
        Me.LabelHoTen.Location = New System.Drawing.Point(14, 169)
        Me.LabelHoTen.Name = "LabelHoTen"
        Me.LabelHoTen.Size = New System.Drawing.Size(43, 13)
        Me.LabelHoTen.TabIndex = 6
        Me.LabelHoTen.Text = "Họ Tên"
        '
        'LabelNamSinh
        '
        Me.LabelNamSinh.AutoSize = True
        Me.LabelNamSinh.Location = New System.Drawing.Point(14, 203)
        Me.LabelNamSinh.Name = "LabelNamSinh"
        Me.LabelNamSinh.Size = New System.Drawing.Size(51, 13)
        Me.LabelNamSinh.TabIndex = 7
        Me.LabelNamSinh.Text = "Năm sinh"
        '
        'LabelTenLop
        '
        Me.LabelTenLop.AutoSize = True
        Me.LabelTenLop.Location = New System.Drawing.Point(14, 241)
        Me.LabelTenLop.Name = "LabelTenLop"
        Me.LabelTenLop.Size = New System.Drawing.Size(43, 13)
        Me.LabelTenLop.TabIndex = 8
        Me.LabelTenLop.Text = "Tên lớp"
        '
        'TextMSV
        '
        Me.TextMSV.Location = New System.Drawing.Point(102, 129)
        Me.TextMSV.Name = "TextMSV"
        Me.TextMSV.Size = New System.Drawing.Size(164, 20)
        Me.TextMSV.TabIndex = 9
        '
        'TextHoTen
        '
        Me.TextHoTen.Location = New System.Drawing.Point(102, 162)
        Me.TextHoTen.Name = "TextHoTen"
        Me.TextHoTen.Size = New System.Drawing.Size(164, 20)
        Me.TextHoTen.TabIndex = 10
        '
        'TextNamSinh
        '
        Me.TextNamSinh.Location = New System.Drawing.Point(102, 196)
        Me.TextNamSinh.Name = "TextNamSinh"
        Me.TextNamSinh.Size = New System.Drawing.Size(164, 20)
        Me.TextNamSinh.TabIndex = 11
        '
        'TextTenLop
        '
        Me.TextTenLop.Location = New System.Drawing.Point(102, 234)
        Me.TextTenLop.Name = "TextTenLop"
        Me.TextTenLop.Size = New System.Drawing.Size(164, 20)
        Me.TextTenLop.TabIndex = 12
        '
        'DanhSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextTenLop)
        Me.Controls.Add(Me.TextNamSinh)
        Me.Controls.Add(Me.TextHoTen)
        Me.Controls.Add(Me.TextMSV)
        Me.Controls.Add(Me.LabelTenLop)
        Me.Controls.Add(Me.LabelNamSinh)
        Me.Controls.Add(Me.LabelHoTen)
        Me.Controls.Add(Me.LabelMSV)
        Me.Controls.Add(Me.XoaBtn)
        Me.Controls.Add(Me.SuaBtn)
        Me.Controls.Add(Me.ThemBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "DanhSach"
        Me.Text = "DanhSach"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Masv As DataGridViewTextBoxColumn
    Friend WithEvents Hoten As DataGridViewTextBoxColumn
    Friend WithEvents Namsinh As DataGridViewTextBoxColumn
    Friend WithEvents Tenlop As DataGridViewTextBoxColumn
    Friend WithEvents ThemBtn As Button
    Friend WithEvents SuaBtn As Button
    Friend WithEvents XoaBtn As Button
    Friend WithEvents LabelMSV As Label
    Friend WithEvents LabelHoTen As Label
    Friend WithEvents LabelNamSinh As Label
    Friend WithEvents LabelTenLop As Label
    Friend WithEvents TextMSV As TextBox
    Friend WithEvents TextHoTen As TextBox
    Friend WithEvents TextNamSinh As TextBox
    Friend WithEvents TextTenLop As TextBox
End Class
