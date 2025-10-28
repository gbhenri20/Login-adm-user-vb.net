Imports System.Data.SqlClient

Module Module2
    Public conn As SqlConnection
    Public sql, diretorio As String
    Public count As Int64

    Sub Conecta_banco()
        Try
            Dim connStr As String = "Server=tcp:loglogin.database.windows.net,1433;" &
                                    "Database=logbd;" &
                                    "User ID=loglogin;" &
                                    "Password=123456a.;" &
                                    "Encrypt=True;" &
                                    "TrustServerCertificate=False;" &
                                    "Connection Timeout=30;"

            conn = New SqlConnection(connStr)
            conn.Open()
            'MsgBox("Conexão realizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Logar")

        Catch ex As Exception
            MsgBox("Erro na conexão" & Environment.NewLine & ex.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "SQL SERVER")
        End Try
    End Sub



End Module
