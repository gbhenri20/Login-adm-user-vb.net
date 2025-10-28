Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        ' Dim tabela As New CriarTabelaUsuarios()
        'tabela.CriarTabela()
        txt_senha.PasswordChar = "*"c
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim username = txt_user.Text.Trim()
        Dim pwd = txt_senha.Text.Trim()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(pwd) Then
            MessageBox.Show("Informe usuário e senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Garante conexão ativa
            If conn Is Nothing OrElse conn.State <> ConnectionState.Open Then
                Conecta_banco()
                If conn Is Nothing OrElse conn.State <> ConnectionState.Open Then
                    MessageBox.Show("Não foi possível conectar ao banco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If

            ' Verifica login e obtém o tipo de usuário
            Dim sql As String = "SELECT tipo FROM tb_usuarios WHERE (nome = @user OR email = @user) AND senha = @pwd"

            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@user", username)
                cmd.Parameters.AddWithValue("@pwd", pwd)

                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    Dim tipoUsuario As String = result.ToString().ToUpper()

                    If tipoUsuario = "ADM" Then
                        MessageBox.Show("Login de administrador bem-sucedido!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim telaAdm As New FormADM()
                        telaAdm.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Login de usuário comum bem-sucedido!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim telaUser As New FormUser()
                        telaUser.Show()
                        Me.Hide()
                    End If
                Else
                    MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao validar login: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btn_cad_telaClick(sender As Object, e As EventArgs) Handles btn_cad_tela.Click
        Dim cad As New Cadastro()
        cad.Show()     ' Abre a nova tela
        Me.Hide() ' Fecha o formulário atual (opcional)

    End Sub


End Class
