﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_senha1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_senha2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_logar_tela = New System.Windows.Forms.Button()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.Location = New System.Drawing.Point(374, 271)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(147, 38)
        Me.btn_cadastrar.TabIndex = 0
        Me.btn_cadastrar.Text = "CADASTRAR"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USER"
        '
        'txt_senha1
        '
        Me.txt_senha1.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha1.Location = New System.Drawing.Point(349, 163)
        Me.txt_senha1.Name = "txt_senha1"
        Me.txt_senha1.Size = New System.Drawing.Size(201, 34)
        Me.txt_senha1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SENHA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(370, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CADASTRAR"
        '
        'txt_user
        '
        Me.txt_user.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(349, 61)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(201, 34)
        Me.txt_user.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(120, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 27)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CONFIRMAR SENHA"
        '
        'txt_senha2
        '
        Me.txt_senha2.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha2.Location = New System.Drawing.Point(349, 215)
        Me.txt_senha2.Name = "txt_senha2"
        Me.txt_senha2.Size = New System.Drawing.Size(201, 34)
        Me.txt_senha2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(327, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 27)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "JÁ POSSUI CONTA?"
        '
        'btn_logar_tela
        '
        Me.btn_logar_tela.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logar_tela.Location = New System.Drawing.Point(375, 342)
        Me.btn_logar_tela.Name = "btn_logar_tela"
        Me.btn_logar_tela.Size = New System.Drawing.Size(147, 38)
        Me.btn_logar_tela.TabIndex = 9
        Me.btn_logar_tela.Text = "LOGAR"
        Me.btn_logar_tela.UseVisualStyleBackColor = True
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(349, 110)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(201, 34)
        Me.txt_email.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(258, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 27)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "E-MAIL"
        '
        'Cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_logar_tela)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_senha2)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_senha1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Name = "Cadastro"
        Me.Text = "Cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_senha1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_senha2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_logar_tela As Button
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label6 As Label
End Class
