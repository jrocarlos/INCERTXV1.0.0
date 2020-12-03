<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Janela1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TITU = New System.Windows.Forms.TextBox()
        Me.CMCLAB = New System.Windows.Forms.TextBox()
        Me.TÍTULO = New System.Windows.Forms.Label()
        Me.CMC = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.B = New System.Windows.Forms.CheckBox()
        Me.A = New System.Windows.Forms.CheckBox()
        Me.TIPOINC = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Q2 = New System.Windows.Forms.TextBox()
        Me.Q1 = New System.Windows.Forms.TextBox()
        Me.QINC = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CMCDIV = New System.Windows.Forms.TextBox()
        Me.INICIAR = New System.Windows.Forms.Button()
        Me.SAIR = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TITU
        '
        Me.TITU.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TITU.Location = New System.Drawing.Point(87, 25)
        Me.TITU.Name = "TITU"
        Me.TITU.Size = New System.Drawing.Size(290, 26)
        Me.TITU.TabIndex = 0
        '
        'CMCLAB
        '
        Me.CMCLAB.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CMCLAB.Location = New System.Drawing.Point(196, 57)
        Me.CMCLAB.Name = "CMCLAB"
        Me.CMCLAB.Size = New System.Drawing.Size(70, 26)
        Me.CMCLAB.TabIndex = 1
        '
        'TÍTULO
        '
        Me.TÍTULO.AutoSize = True
        Me.TÍTULO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TÍTULO.Location = New System.Drawing.Point(8, 28)
        Me.TÍTULO.Name = "TÍTULO"
        Me.TÍTULO.Size = New System.Drawing.Size(73, 19)
        Me.TÍTULO.TabIndex = 2
        Me.TÍTULO.Text = "TÍTULO:"
        '
        'CMC
        '
        Me.CMC.AutoSize = True
        Me.CMC.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMC.Location = New System.Drawing.Point(7, 64)
        Me.CMC.Name = "CMC"
        Me.CMC.Size = New System.Drawing.Size(183, 19)
        Me.CMC.TabIndex = 3
        Me.CMC.Text = "CMC (LABORATÓRIO):"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.B)
        Me.Panel1.Controls.Add(Me.A)
        Me.Panel1.Controls.Add(Me.TIPOINC)
        Me.Panel1.Location = New System.Drawing.Point(48, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(203, 222)
        Me.Panel1.TabIndex = 4
        '
        'B
        '
        Me.B.AutoSize = True
        Me.B.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B.Location = New System.Drawing.Point(12, 142)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(174, 20)
        Me.B.TabIndex = 7
        Me.B.Text = "TIPO DE INCERTEZA B"
        Me.B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.B.UseVisualStyleBackColor = True
        '
        'A
        '
        Me.A.AutoSize = True
        Me.A.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A.Location = New System.Drawing.Point(12, 86)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(173, 20)
        Me.A.TabIndex = 6
        Me.A.Text = "TIPO DE INCERTEZA A"
        Me.A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.A.UseVisualStyleBackColor = True
        '
        'TIPOINC
        '
        Me.TIPOINC.AutoSize = True
        Me.TIPOINC.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIPOINC.Location = New System.Drawing.Point(3, 14)
        Me.TIPOINC.Name = "TIPOINC"
        Me.TIPOINC.Size = New System.Drawing.Size(191, 19)
        Me.TIPOINC.TabIndex = 4
        Me.TIPOINC.Text = "TIPOS DE INCERTEZAS"
        Me.TIPOINC.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Q2)
        Me.Panel2.Controls.Add(Me.Q1)
        Me.Panel2.Controls.Add(Me.QINC)
        Me.Panel2.Location = New System.Drawing.Point(257, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(203, 222)
        Me.Panel2.TabIndex = 5
        '
        'Q2
        '
        Me.Q2.Enabled = False
        Me.Q2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q2.Location = New System.Drawing.Point(41, 136)
        Me.Q2.Name = "Q2"
        Me.Q2.Size = New System.Drawing.Size(127, 26)
        Me.Q2.TabIndex = 9
        '
        'Q1
        '
        Me.Q1.Enabled = False
        Me.Q1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q1.Location = New System.Drawing.Point(41, 86)
        Me.Q1.Name = "Q1"
        Me.Q1.Size = New System.Drawing.Size(127, 26)
        Me.Q1.TabIndex = 4
        '
        'QINC
        '
        Me.QINC.AutoSize = True
        Me.QINC.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QINC.Location = New System.Drawing.Point(4, 14)
        Me.QINC.Name = "QINC"
        Me.QINC.Size = New System.Drawing.Size(194, 19)
        Me.QINC.TabIndex = 8
        Me.QINC.Text = "N° DE CONTRIBUIÇÕES"
        Me.QINC.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Window
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.CMCDIV)
        Me.Panel3.Controls.Add(Me.TITU)
        Me.Panel3.Controls.Add(Me.CMCLAB)
        Me.Panel3.Controls.Add(Me.CMC)
        Me.Panel3.Controls.Add(Me.TÍTULO)
        Me.Panel3.Location = New System.Drawing.Point(48, 18)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(412, 100)
        Me.Panel3.TabIndex = 6
        '
        'CMCDIV
        '
        Me.CMCDIV.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CMCDIV.Location = New System.Drawing.Point(328, 57)
        Me.CMCDIV.Name = "CMCDIV"
        Me.CMCDIV.Size = New System.Drawing.Size(49, 26)
        Me.CMCDIV.TabIndex = 4
        '
        'INICIAR
        '
        Me.INICIAR.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.INICIAR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INICIAR.Location = New System.Drawing.Point(48, 352)
        Me.INICIAR.Name = "INICIAR"
        Me.INICIAR.Size = New System.Drawing.Size(203, 38)
        Me.INICIAR.TabIndex = 7
        Me.INICIAR.Text = "INICIAR"
        Me.INICIAR.UseVisualStyleBackColor = False
        '
        'SAIR
        '
        Me.SAIR.BackColor = System.Drawing.Color.Maroon
        Me.SAIR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAIR.ForeColor = System.Drawing.Color.White
        Me.SAIR.Location = New System.Drawing.Point(257, 352)
        Me.SAIR.Name = "SAIR"
        Me.SAIR.Size = New System.Drawing.Size(203, 38)
        Me.SAIR.TabIndex = 8
        Me.SAIR.Text = "SAIR"
        Me.SAIR.UseVisualStyleBackColor = False
        '
        'Janela1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(502, 402)
        Me.Controls.Add(Me.SAIR)
        Me.Controls.Add(Me.INICIAR)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Janela1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INCERTX"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TITU As TextBox
    Friend WithEvents CMCLAB As TextBox
    Friend WithEvents TÍTULO As Label
    Friend WithEvents CMC As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents B As CheckBox
    Friend WithEvents A As CheckBox
    Friend WithEvents TIPOINC As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Q2 As TextBox
    Friend WithEvents Q1 As TextBox
    Friend WithEvents QINC As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CMCDIV As TextBox
    Friend WithEvents INICIAR As Button
    Friend WithEvents SAIR As Button
End Class
