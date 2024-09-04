Imports System.Data.SqlClient
Imports QuanLySinhVien.Connection

Public Class DanhSach
    Dim Conn As New Connection()
    Private Sub DanhSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim query As String = "SELECT Ma, hoTen, namSinh, maLop FROM SinhVien"
        Try
            Conn.connection.Open()
            'Dim adapter As New SqlDataAdapter(query, Conn.connection)
            Dim command As New SqlCommand(query, Conn.connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            'Dim table As New DataTable()

            'adapter.Fill(table)
            'DataGridView1.DataSource = table
            DataGridView1.Rows.Clear()
            While reader.Read()
                DataGridView1.Rows.Add(reader("Ma"), reader("hoTen"), reader("namSinh"), reader("maLop"))
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        Finally
            Conn.connection.Close()
        End Try
    End Sub

    Private Sub ThemBtn_Click(sender As Object, e As EventArgs) Handles ThemBtn.Click
        Dim maSV As String = TextMSV.Text
        Dim hoTen As String = TextHoTen.Text
        Dim namSinh As String = TextNamSinh.Text
        Dim tenLop As String = TextTenLop.Text

        Dim query As String = "INSERT INTO SinhVien(Ma, hoTen, namSinh, maLop) VALUES('" & maSV & "', N'" & hoTen & "', '" & namSinh & "', '" & tenLop & "')"
        Try
            Conn.connection.Open()
            Dim command As New SqlCommand(query, Conn.connection)
            Dim result As Integer = command.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Thêm sinh viên thành công")

            Else
                MessageBox.Show("Thêm sinh viên thất bại")
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thêm sinh viên: " & ex.Message)
        Finally
            Conn.connection.Close()
            LoadData()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        TextMSV.Text = selectedRow.Cells(0).Value.ToString()
        TextHoTen.Text = selectedRow.Cells(1).Value.ToString()
        TextNamSinh.Text = selectedRow.Cells(2).Value.ToString()
        TextTenLop.Text = selectedRow.Cells(3).Value.ToString()
    End Sub

    Private Sub SuaBtn_Click(sender As Object, e As EventArgs) Handles SuaBtn.Click
        Dim maSV As String = TextMSV.Text
        Dim hoTen As String = TextHoTen.Text
        Dim namSinh As String = TextNamSinh.Text
        Dim tenLop As String = TextTenLop.Text

        Dim query As String = "UPDATE SinhVien SET hoTen = N'" & hoTen & "', namSinh = '" & namSinh & "', maLop = '" & tenLop & "' WHERE Ma = '" & maSV & "'"
        Try
            Conn.connection.Open()
            Dim command As New SqlCommand(query, Conn.connection)
            Dim result As Integer = command.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Sửa thông tin sinh viên thành công")

            Else
                MessageBox.Show("Sửa thông tin sinh viên thất bại")
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi khi sửa thông tin sinh viên: " & ex.Message)
        Finally
            Conn.connection.Close()
            LoadData()
        End Try
    End Sub

    Private Sub XoaBtn_Click(sender As Object, e As EventArgs) Handles XoaBtn.Click
        Dim maSV As String = TextMSV.Text
        Dim resultDg As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xác nhận", MessageBoxButtons.YesNo)
        If resultDg = DialogResult.Yes Then
            Dim query As String = "DELETE FROM SinhVien WHERE Ma = '" & maSV & "'"
            Try
                Conn.connection.Open()
                Dim command As New SqlCommand(query, Conn.connection)
                Dim result As Integer = command.ExecuteNonQuery()
                If result > 0 Then
                    MessageBox.Show("Xóa sinh viên thành công")

                Else
                    MessageBox.Show("Xóa thông tin sinh viên thất bại")
                End If
            Catch ex As Exception
                MessageBox.Show("Lỗi khi xóa sinh viên: " & ex.Message)
            Finally
                Conn.connection.Close()
                LoadData()
            End Try
        End If
    End Sub
End Class