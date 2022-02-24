<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Masc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Masc))
        Me.BtTabela = New System.Windows.Forms.Button()
        Me.BtClear = New System.Windows.Forms.Button()
        Me.BtBack = New System.Windows.Forms.Button()
        Me.BtCalc = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtTabela
        '
        Me.BtTabela.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtTabela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtTabela.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtTabela.Location = New System.Drawing.Point(388, 23)
        Me.BtTabela.Name = "BtTabela"
        Me.BtTabela.Size = New System.Drawing.Size(87, 28)
        Me.BtTabela.TabIndex = 16
        Me.BtTabela.Text = "IMC"
        Me.BtTabela.UseVisualStyleBackColor = False
        '
        'BtClear
        '
        Me.BtClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtClear.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtClear.Location = New System.Drawing.Point(284, 56)
        Me.BtClear.Name = "BtClear"
        Me.BtClear.Size = New System.Drawing.Size(87, 29)
        Me.BtClear.TabIndex = 15
        Me.BtClear.Text = "Limpar"
        Me.BtClear.UseVisualStyleBackColor = False
        '
        'BtBack
        '
        Me.BtBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtBack.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtBack.Location = New System.Drawing.Point(388, 57)
        Me.BtBack.Name = "BtBack"
        Me.BtBack.Size = New System.Drawing.Size(87, 29)
        Me.BtBack.TabIndex = 14
        Me.BtBack.Text = "Voltar"
        Me.BtBack.UseVisualStyleBackColor = False
        '
        'BtCalc
        '
        Me.BtCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCalc.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCalc.Location = New System.Drawing.Point(284, 22)
        Me.BtCalc.Name = "BtCalc"
        Me.BtCalc.Size = New System.Drawing.Size(87, 27)
        Me.BtCalc.TabIndex = 13
        Me.BtCalc.Text = "Calcular"
        Me.BtCalc.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(80, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(172, 20)
        Me.TextBox2.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(80, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 32)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Peso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 32)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Altura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 19)
        Me.Label3.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(213, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 18
        '
        'Masc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(498, 343)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtTabela)
        Me.Controls.Add(Me.BtClear)
        Me.Controls.Add(Me.BtBack)
        Me.Controls.Add(Me.BtCalc)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Masc"
        Me.Opacity = 0.89R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Masculino - IMC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtTabela As Button
    Friend WithEvents BtClear As Button
    Friend WithEvents BtBack As Button
    Friend WithEvents BtCalc As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
