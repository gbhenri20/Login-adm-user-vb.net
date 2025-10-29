<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_cad_tela = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USER"
        '
        'txt_user
        '
        Me.txt_user.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(319, 111)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(224, 34)
        Me.txt_user.TabIndex = 1
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(370, 231)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(121, 43)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "ENTRAR"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(226, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SENHA"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(319, 165)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(224, 34)
        Me.txt_senha.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "FORMULARIO DE LOGIN"
        '
        'btn_cad_tela
        '
        Me.btn_cad_tela.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_tela.Location = New System.Drawing.Point(355, 319)
        Me.btn_cad_tela.Name = "btn_cad_tela"
        Me.btn_cad_tela.Size = New System.Drawing.Size(155, 43)
        Me.btn_cad_tela.TabIndex = 6
        Me.btn_cad_tela.Text = "CADASTRAR"
        Me.btn_cad_tela.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(314, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(239, 27)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NÃO POSSUI CONTA?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_cad_tela)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_cad_tela As Button
    Friend WithEvents Label4 As Label
End Class
