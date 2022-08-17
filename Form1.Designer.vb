<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.BTN_BORRAR = New System.Windows.Forms.Button()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.BTN_GRABAR = New System.Windows.Forms.Button()
        Me.BTN_IRALULTIMO = New System.Windows.Forms.Button()
        Me.BTN_AVANZAR = New System.Windows.Forms.Button()
        Me.BTN_RETROCEDER = New System.Windows.Forms.Button()
        Me.BTN_IRALPRIMERO = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "PROVINCIA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "NOMBRE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "CLAVE"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(236, 194)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(202, 20)
        Me.TextBox3.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(236, 168)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(202, 20)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(236, 142)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(202, 20)
        Me.TextBox1.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BTN_NUEVO)
        Me.Panel1.Controls.Add(Me.BTN_BORRAR)
        Me.Panel1.Controls.Add(Me.BTN_BUSCAR)
        Me.Panel1.Controls.Add(Me.BTN_GRABAR)
        Me.Panel1.Controls.Add(Me.BTN_IRALULTIMO)
        Me.Panel1.Controls.Add(Me.BTN_AVANZAR)
        Me.Panel1.Controls.Add(Me.BTN_RETROCEDER)
        Me.Panel1.Controls.Add(Me.BTN_IRALPRIMERO)
        Me.Panel1.Location = New System.Drawing.Point(116, 288)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 46)
        Me.Panel1.TabIndex = 8
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Image = Global.ODBC_CON_CODIGO.My.Resources.Resources.add_circle
        Me.BTN_NUEVO.Location = New System.Drawing.Point(341, 3)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(41, 40)
        Me.BTN_NUEVO.TabIndex = 7
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'BTN_BORRAR
        '
        Me.BTN_BORRAR.Image = Global.ODBC_CON_CODIGO.My.Resources.Resources.delete_circle
        Me.BTN_BORRAR.Location = New System.Drawing.Point(435, 3)
        Me.BTN_BORRAR.Name = "BTN_BORRAR"
        Me.BTN_BORRAR.Size = New System.Drawing.Size(41, 40)
        Me.BTN_BORRAR.TabIndex = 6
        Me.BTN_BORRAR.UseVisualStyleBackColor = True
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.Image = Global.ODBC_CON_CODIGO.My.Resources.Resources.web_search
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(482, 3)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(41, 40)
        Me.BTN_BUSCAR.TabIndex = 5
        Me.BTN_BUSCAR.UseVisualStyleBackColor = True
        '
        'BTN_GRABAR
        '
        Me.BTN_GRABAR.Enabled = False
        Me.BTN_GRABAR.Image = Global.ODBC_CON_CODIGO.My.Resources.Resources.ok
        Me.BTN_GRABAR.Location = New System.Drawing.Point(388, 3)
        Me.BTN_GRABAR.Name = "BTN_GRABAR"
        Me.BTN_GRABAR.Size = New System.Drawing.Size(41, 40)
        Me.BTN_GRABAR.TabIndex = 4
        Me.BTN_GRABAR.UseVisualStyleBackColor = True
        '
        'BTN_IRALULTIMO
        '
        Me.BTN_IRALULTIMO.Image = Global.ODBC_CON_CODIGO.My.Resources.Resources.fast_forward
        Me.BTN_IRALULTIMO.Location = New System.Drawing.Point(144, 3)
        Me.BTN_IRALULTIMO.Name = "BTN_IRALULTIMO"
        Me.BTN_IRALULTIMO.Size = New System.Drawing.Size(41, 40)
        Me.BTN_IRALULTIMO.TabIndex = 3
        Me.BTN_IRALULTIMO.UseVisualStyleBackColor = True
        '
        'BTN_AVANZAR
        '
        Me.BTN_AVANZAR.Image = Global.ODBC_CON_CODIGO.My.Resources.Resources.next_
        Me.BTN_AVANZAR.Location = New System.Drawing.Point(97, 3)
        Me.BTN_AVANZAR.Name = "BTN_AVANZAR"
        Me.BTN_AVANZAR.Size = New System.Drawing.Size(41, 40)
        Me.BTN_AVANZAR.TabIndex = 2
        Me.BTN_AVANZAR.UseVisualStyleBackColor = True
        '
        'BTN_RETROCEDER
        '
        Me.BTN_RETROCEDER.Image = Global.ODBC_CON_CODIGO.My.Resources.Resources.back_
        Me.BTN_RETROCEDER.Location = New System.Drawing.Point(50, 3)
        Me.BTN_RETROCEDER.Name = "BTN_RETROCEDER"
        Me.BTN_RETROCEDER.Size = New System.Drawing.Size(41, 40)
        Me.BTN_RETROCEDER.TabIndex = 1
        Me.BTN_RETROCEDER.UseVisualStyleBackColor = True
        '
        'BTN_IRALPRIMERO
        '
        Me.BTN_IRALPRIMERO.Image = Global.ODBC_CON_CODIGO.My.Resources.Resources.reward
        Me.BTN_IRALPRIMERO.Location = New System.Drawing.Point(3, 3)
        Me.BTN_IRALPRIMERO.Name = "BTN_IRALPRIMERO"
        Me.BTN_IRALPRIMERO.Size = New System.Drawing.Size(41, 40)
        Me.BTN_IRALPRIMERO.TabIndex = 0
        Me.BTN_IRALPRIMERO.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(194, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(314, 33)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ODBC CON CODIGO"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(504, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 97)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "¿BUSCAR POR?"
        Me.GroupBox1.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(15, 70)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(83, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "PROVINCIA"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(15, 47)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(72, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "NOMBRE"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "CLAVE"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(474, 115)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(199, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_NUEVO As Button
    Friend WithEvents BTN_BORRAR As Button
    Friend WithEvents BTN_BUSCAR As Button
    Friend WithEvents BTN_GRABAR As Button
    Friend WithEvents BTN_IRALULTIMO As Button
    Friend WithEvents BTN_AVANZAR As Button
    Friend WithEvents BTN_RETROCEDER As Button
    Friend WithEvents BTN_IRALPRIMERO As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
End Class
