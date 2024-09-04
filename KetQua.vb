Imports System.Data.SqlClient
Imports QuanLySinhVien.Connection

Public Class KetQua
    Dim Conn As New Connection()

    Private Sub LoadData()
        Dim query As String = " SELECT sv.hoTen, mh.tenMonHoc, kq.lanThi, kq.diem
                                FROM SinhVien sv, MonHoc mh, KetQua kq
                                WHERE sv.Ma = kq.maSinhVien AND kq.maMonHoc = mh.Ma"
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
                DataGridView1.Rows.Add(reader("hoTen"), reader("tenMonHoc"), reader("lanThi"), reader("diem"))
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        Finally
            Conn.connection.Close()
        End Try
    End Sub

    Private Sub KetQua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

End Class