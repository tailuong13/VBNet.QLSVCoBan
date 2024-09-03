Imports System.Data.SqlClient
Imports QuanLySinhVien.Connection

Public Class DanhSach
    Dim Conn As New Connection()
    Private Sub DanhSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT * FROM SinhVien"
        Try
            Dim adapter As New SqlDataAdapter(query, Conn.connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        Finally
            Conn.connection.Close()
        End Try
    End Sub
End Class