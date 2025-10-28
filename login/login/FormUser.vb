Imports System.Data.SqlClient
Imports System.Data
Public Class FormUser
        Private dtUsuarios As New DataTable
        Private daUsuarios As SqlDataAdapter
        Private dtAdmin As New DataTable
        Private daAdmin As SqlDataAdapter
        Private cbUsuarios As New SqlCommandBuilder

    Private Sub Formuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()

        ' --- DataGridView Usuário (somente leitura) ---
        daUsuarios = New SqlDataAdapter("SELECT id, nome, email FROM tb_usuarios", conn)
        dtUsuarios.Clear()
        daUsuarios.Fill(dtUsuarios)
        dgvUsuarios.DataSource = dtUsuarios
        dgvUsuarios.ReadOnly = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim voltar As New Form1()
            voltar.Show()
            Me.Hide()
        End Sub
    End Class