Imports System.Data.SqlClient

Public Class Cadastro


    Private Sub btn_logar_tela_Click(sender As Object, e As EventArgs) Handles btn_logar_tela.Click
        Dim telaPrincipal As New Form1()
        telaPrincipal.Show()     ' Abre a nova tela
        Me.Close() ' Fecha o formulário atual (opcional)
    End Sub

    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        txt_senha1.PasswordChar = "*"c
        txt_senha2.PasswordChar = "*"c
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Dim nome As String = txt_user.Text.Trim()
        Dim email As String = txt_email.Text.Trim()
        Dim senha As String = txt_senha1.Text.Trim()
        Dim confirmaSenha As String = txt_senha2.Text.Trim()
        Dim tipo As String = "USER" ' ou "ADM", dependendo da lógica

        ' Verifica se os campos estão preenchidos
        If nome = "" Or email = "" Or senha = "" Or confirmaSenha = "" Then
            MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Verifica se as senhas coincidem
        If senha <> confirmaSenha Then
            MessageBox.Show("As senhas não coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Conexão com o banco


        ' Verifica se o usuário já existe
        Dim checkSql As String = "SELECT COUNT(*) FROM tb_usuarios WHERE nome = @nome or email = @email"
        Using checkCmd As New SqlCommand(checkSql, conn)
            checkCmd.Parameters.AddWithValue("@nome", nome)
            checkCmd.Parameters.AddWithValue("@email", email)
            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("Usuário já existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End Using

        ' Insere o novo usuário
        Try
            ' Garante que o banco está conectado
            Conecta_banco()

            Dim sql As String = "INSERT INTO tb_usuarios (nome,email, senha, tipo) VALUES (@nome,@email, @senha, @tipo)"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@nome", txt_user.Text)
            cmd.Parameters.AddWithValue("@email", txt_email.Text)
            cmd.Parameters.AddWithValue("@senha", txt_senha1.Text)
            cmd.Parameters.AddWithValue("@tipo", "USER")

            cmd.ExecuteNonQuery()
            MessageBox.Show("Usuário cadastrado com sucesso!")

            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao cadastrar: " & ex.Message)
        End Try

    End Sub
End Class