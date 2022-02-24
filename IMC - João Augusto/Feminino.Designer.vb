<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Femi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Femi))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BtCalc = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtBack = New System.Windows.Forms.Button()
        Me.BtClear = New System.Windows.Forms.Button()
        Me.BtTabela = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Altura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Peso"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(84, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(84, 66)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(169, 20)
        Me.TextBox2.TabIndex = 3
        '
        'BtCalc
        '
        Me.BtCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCalc.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCalc.Location = New System.Drawing.Point(284, 23)
        Me.BtCalc.Name = "BtCalc"
        Me.BtCalc.Size = New System.Drawing.Size(86, 26)
        Me.BtCalc.TabIndex = 4
        Me.BtCalc.Text = "Calcular"
        Me.BtCalc.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(2, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 19)
        Me.Label3.TabIndex = 5
        '
        'BtBack
        '
        Me.BtBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtBack.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtBack.Location = New System.Drawing.Point(385, 55)
        Me.BtBack.Name = "BtBack"
        Me.BtBack.Size = New System.Drawing.Size(86, 31)
        Me.BtBack.TabIndex = 6
        Me.BtBack.Text = "Voltar"
        Me.BtBack.UseVisualStyleBackColor = False
        '
        'BtClear
        '
        Me.BtClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtClear.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtClear.Location = New System.Drawing.Point(284, 55)
        Me.BtClear.Name = "BtClear"
        Me.BtClear.Size = New System.Drawing.Size(86, 31)
        Me.BtClear.TabIndex = 7
        Me.BtClear.Text = "Limpar"
        Me.BtClear.UseVisualStyleBackColor = False
        '
        'BtTabela
        '
        Me.BtTabela.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtTabela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtTabela.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtTabela.Location = New System.Drawing.Point(385, 23)
        Me.BtTabela.Name = "BtTabela"
        Me.BtTabela.Size = New System.Drawing.Size(86, 26)
        Me.BtTabela.TabIndex = 8
        Me.BtTabela.Text = "IMC"
        Me.BtTabela.UseVisualStyleBackColor = False
        '
        'Femi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(498, 343)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtTabela)
        Me.Controls.Add(Me.BtClear)
        Me.Controls.Add(Me.BtBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtCalc)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Femi"
        Me.Opacity = 0.89R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Feminino - IMC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtCalc As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtBack As Button
    Friend WithEvents BtClear As Button
    Friend WithEvents BtTabela As Button
End Class
