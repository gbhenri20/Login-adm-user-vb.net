Imports System.Data.SqlClient
Imports System.Data

Public Class FormAdm
    Private dtUsuarios As New DataTable
    Private daUsuarios As SqlDataAdapter
    Private dtAdmin As New DataTable
    Private daAdmin As SqlDataAdapter
    Private cbUsuarios As New SqlCommandBuilder

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()



        daAdmin = New SqlDataAdapter("SELECT id, nome, email, senha FROM tb_usuarios", conn)
        dtAdmin.Clear()
        daAdmin.Fill(dtAdmin)
        dgvAdmin.DataSource = dtAdmin
        dgvAdmin.ReadOnly = False
        dgvAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            cbUsuarios = New SqlCommandBuilder(daAdmin)
            daAdmin.Update(dtAdmin)
            MsgBox("Alterações salvas com sucesso!")
        Catch ex As Exception
            MsgBox("Erro ao salvar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If dgvAdmin.SelectedRows.Count > 0 Then
            Dim linha As DataGridViewRow = dgvAdmin.SelectedRows(0)
            Dim id As Integer = linha.Cells("id").Value
            Dim cmd As New SqlCommand("DELETE FROM tb_usuarios WHERE id=@id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            If MsgBox("Deseja realmente excluir?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cmd.ExecuteNonQuery()
                dtAdmin.Rows.Remove(CType(linha.DataBoundItem, DataRowView).Row)
                MsgBox("Registro excluído!")
            End If
        Else
            MsgBox("Selecione um registro para excluir.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim voltar As New Form1()
        voltar.Show()
        Me.Hide()
    End Sub
End Class
