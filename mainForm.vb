Imports System.Data.SqlClient
Imports QuanLySinhVien.Connection

Public Class mainForm
    Dim Conn As New Connection()
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn.Connect()
    End Sub

    Private Sub OpenChildForm(form As Form)
        contentPanel.Controls.Clear()

        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill

        contentPanel.Controls.Add(form)
        contentPanel.Tag = form
        form.BringToFront()
        form.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New Dashboard()
        OpenChildForm(form)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New DanhSach()
    End Sub
End Class
