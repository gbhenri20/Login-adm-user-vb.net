Imports System.Data.SqlClient

Public Class CriarTabelaUsuarios
    Public Sub CriarTabela()
        Try
            If conn Is Nothing OrElse conn.State = ConnectionState.Closed Then
                Conecta_banco()
            End If

            Dim sql As String =
                "CREATE TABLE tb_usuarios (" &
                "id INT IDENTITY(1,1) PRIMARY KEY, " &
                "nome NVARCHAR(100) NOT NULL, " &
                "email NVARCHAR(100) NOT NULL UNIQUE, " &
                "senha NVARCHAR(100) NOT NULL, " &
                "tipo NVARCHAR(10) NOT NULL CHECK (tipo IN ('ADM','USER')), " &
                "data_criacao DATETIME DEFAULT GETDATE()" &
                ")"

            Dim cmd As New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()

            MsgBox("Tabela 'tb_usuarios' criada com sucesso!", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Erro ao criar tabela: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


End Class

