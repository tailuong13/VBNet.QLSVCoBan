Imports System.Data.SqlClient

Public Class Connection
    Public connectionString As String = "Data Source=LAPTOP-E4IRA0MP;Initial Catalog=QLSV;User ID=sa;Password=1234567"
    Public connection As New SqlConnection(connectionString)
    Public Sub Connect()
        Try
            connection.Open()
            MessageBox.Show("Kết nối thành công")
        Catch ex As Exception
            MessageBox.Show("Kết nối thất bại")
        Finally
            connection.Close()
        End Try
    End Sub
End Class
