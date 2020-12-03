<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class janela2
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
        Me.TIPOINC = New System.Windows.Forms.Label()
        Me.TITULOCONTRIBUI = New System.Windows.Forms.TextBox()
        Me.INSERIR1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TIPOCONT = New System.Windows.Forms.Label()
        Me.NOMECONT = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.COEFICIENTE = New System.Windows.Forms.Label()
        Me.DESVIO = New System.Windows.Forms.Label()
        Me.QUANTIDADE = New System.Windows.Forms.Label()
        Me.ESTIMATIVA = New System.Windows.Forms.Label()
        Me.COLETA = New System.Windows.Forms.Label()
        Me.SAIR = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FerramentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TIPOINC
        '
        Me.TIPOINC.AutoSize = True
        Me.TIPOINC.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIPOINC.Location = New System.Drawing.Point(13, 49)
        Me.TIPOINC.Name = "TIPOINC"
        Me.TIPOINC.Size = New System.Drawing.Size(146, 16)
        Me.TIPOINC.TabIndex = 0
        Me.TIPOINC.Text = "TIPO DA INCERTEZA:"
        '
        'TITULOCONTRIBUI
        '
        Me.TITULOCONTRIBUI.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TITULOCONTRIBUI.Location = New System.Drawing.Point(210, 16)
        Me.TITULOCONTRIBUI.Name = "TITULOCONTRIBUI"
        Me.TITULOCONTRIBUI.Size = New System.Drawing.Size(306, 23)
        Me.TITULOCONTRIBUI.TabIndex = 1
        '
        'INSERIR1
        '
        Me.INSERIR1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.INSERIR1.FlatAppearance.BorderSize = 10
        Me.INSERIR1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INSERIR1.Location = New System.Drawing.Point(360, 29)
        Me.INSERIR1.Name = "INSERIR1"
        Me.INSERIR1.Size = New System.Drawing.Size(161, 52)
        Me.INSERIR1.TabIndex = 2
        Me.INSERIR1.Text = "INSERIR INCERTEZA"
        Me.INSERIR1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.TIPOCONT)
        Me.Panel1.Controls.Add(Me.NOMECONT)
        Me.Panel1.Controls.Add(Me.TIPOINC)
        Me.Panel1.Controls.Add(Me.TITULOCONTRIBUI)
        Me.Panel1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(37, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(529, 111)
        Me.Panel1.TabIndex = 3
        '
        'TIPOCONT
        '
        Me.TIPOCONT.AutoSize = True
        Me.TIPOCONT.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIPOCONT.Location = New System.Drawing.Point(13, 78)
        Me.TIPOCONT.Name = "TIPOCONT"
        Me.TIPOCONT.Size = New System.Drawing.Size(173, 16)
        Me.TIPOCONT.TabIndex = 3
        Me.TIPOCONT.Text = "TIPO DA CONTRIBUIÇÃO:"
        '
        'NOMECONT
        '
        Me.NOMECONT.AutoSize = True
        Me.NOMECONT.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMECONT.Location = New System.Drawing.Point(13, 19)
        Me.NOMECONT.Name = "NOMECONT"
        Me.NOMECONT.Size = New System.Drawing.Size(191, 16)
        Me.NOMECONT.TabIndex = 2
        Me.NOMECONT.Text = "TÍTULO DA CONTRIBUIÇÃO:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.COEFICIENTE)
        Me.Panel2.Controls.Add(Me.DESVIO)
        Me.Panel2.Controls.Add(Me.QUANTIDADE)
        Me.Panel2.Controls.Add(Me.ESTIMATIVA)
        Me.Panel2.Controls.Add(Me.COLETA)
        Me.Panel2.Controls.Add(Me.SAIR)
        Me.Panel2.Controls.Add(Me.INSERIR1)
        Me.Panel2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(37, 157)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(529, 190)
        Me.Panel2.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(249, 154)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 23)
        Me.TextBox4.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(210, 124)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(139, 23)
        Me.TextBox3.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(210, 90)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(139, 23)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(210, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 23)
        Me.TextBox1.TabIndex = 9
        '
        'COEFICIENTE
        '
        Me.COEFICIENTE.AutoSize = True
        Me.COEFICIENTE.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COEFICIENTE.Location = New System.Drawing.Point(13, 158)
        Me.COEFICIENTE.Name = "COEFICIENTE"
        Me.COEFICIENTE.Size = New System.Drawing.Size(230, 16)
        Me.COEFICIENTE.TabIndex = 8
        Me.COEFICIENTE.Text = "COEFICIENTE DE SENSIBILIDADE:"
        '
        'DESVIO
        '
        Me.DESVIO.AutoSize = True
        Me.DESVIO.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DESVIO.Location = New System.Drawing.Point(13, 127)
        Me.DESVIO.Name = "DESVIO"
        Me.DESVIO.Size = New System.Drawing.Size(124, 16)
        Me.DESVIO.TabIndex = 7
        Me.DESVIO.Text = "DESVIO PADRÃO:"
        '
        'QUANTIDADE
        '
        Me.QUANTIDADE.AutoSize = True
        Me.QUANTIDADE.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QUANTIDADE.Location = New System.Drawing.Point(13, 93)
        Me.QUANTIDADE.Name = "QUANTIDADE"
        Me.QUANTIDADE.Size = New System.Drawing.Size(188, 16)
        Me.QUANTIDADE.TabIndex = 6
        Me.QUANTIDADE.Text = "QUANTIDADE DE MEDIDAS:"
        '
        'ESTIMATIVA
        '
        Me.ESTIMATIVA.AutoSize = True
        Me.ESTIMATIVA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ESTIMATIVA.Location = New System.Drawing.Point(13, 60)
        Me.ESTIMATIVA.Name = "ESTIMATIVA"
        Me.ESTIMATIVA.Size = New System.Drawing.Size(90, 16)
        Me.ESTIMATIVA.TabIndex = 5
        Me.ESTIMATIVA.Text = "ESTIMATIVA:"
        '
        'COLETA
        '
        Me.COLETA.AutoSize = True
        Me.COLETA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COLETA.Location = New System.Drawing.Point(13, 28)
        Me.COLETA.Name = "COLETA"
        Me.COLETA.Size = New System.Drawing.Size(125, 16)
        Me.COLETA.TabIndex = 4
        Me.COLETA.Text = "TIPO DA COLETA:"
        '
        'SAIR
        '
        Me.SAIR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SAIR.FlatAppearance.BorderSize = 10
        Me.SAIR.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAIR.Location = New System.Drawing.Point(360, 109)
        Me.SAIR.Name = "SAIR"
        Me.SAIR.Size = New System.Drawing.Size(161, 52)
        Me.SAIR.TabIndex = 3
        Me.SAIR.Text = "SAIR"
        Me.SAIR.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivosToolStripMenuItem, Me.EditarToolStripMenuItem, Me.FerramentasToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(601, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivosToolStripMenuItem
        '
        Me.ArquivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.ArquivosToolStripMenuItem.Name = "ArquivosToolStripMenuItem"
        Me.ArquivosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ArquivosToolStripMenuItem.Text = "Arquivos"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.NovoToolStripMenuItem.Text = "Novo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'FerramentasToolStripMenuItem
        '
        Me.FerramentasToolStripMenuItem.Name = "FerramentasToolStripMenuItem"
        Me.FerramentasToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.FerramentasToolStripMenuItem.Text = "Ferramentas"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'janela2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(601, 370)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "janela2"
        Me.Text = "INSERIR CONTRIBUIÇÃO"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TIPOINC As Label
    Friend WithEvents TITULOCONTRIBUI As TextBox
    Friend WithEvents INSERIR1 As Button
    Friend WithEvents SAIR As Button
    Friend WithEvents NOMECONT As Label
    Friend WithEvents TIPOCONT As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FerramentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COEFICIENTE As Label
    Friend WithEvents DESVIO As Label
    Friend WithEvents QUANTIDADE As Label
    Friend WithEvents ESTIMATIVA As Label
    Friend WithEvents COLETA As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
