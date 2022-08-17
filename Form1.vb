Imports System.Data.Odbc

Public Class Form1

    '-------------------------------------------------

    '--- CREO LOS OBJETOS BD A LOS QUE DARE VALOR:

    '--- (LUEGO EN EL FORM_LOAD)

    '--------------------------------------------------

    Private MyCn As New OdbcConnection

    Private MyDatAdp As New OdbcDataAdapter

    Private MyCmdBld As New OdbcCommandBuilder

    Private MyDataTbl As New DataTable

    Private MyRowPosition As Integer = 0

    Private Sub showrecords()
        If MyDataTbl.Rows.Count = 0 Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            Exit Sub
        End If
        TextBox1.Text = MyDataTbl.Rows(MyRowPosition)("CLAVE").ToString()
        TextBox2.Text = MyDataTbl.Rows(MyRowPosition)("NOMBRE").ToString()
        TextBox3.Text = MyDataTbl.Rows(MyRowPosition)("PROVINCIA").ToString()
    End Sub



    'Inicializo los objetos en la carga del formulario

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MyCn.ConnectionString = "Dsn=ACCESS"

        MyCn.Open()

        MyDatAdp = New OdbcDataAdapter(“SELECT * FROM tabla”, MyCn)

        MyCmdBld = New OdbcCommandBuilder(MyDatAdp)

        MyDatAdp.Fill(MyDataTbl)



        '____________________________________________________________
        'CARGA EN EL COMBOBOX EL REGISTRO NOMBRE
        '____________________________________________________________
        Cursor.Current = Cursors.WaitCursor
        MyRowPosition = 0

        For I = 1 To MyDataTbl.Rows.Count
            Call showrecords()
            'Añade al combo textbox2.text porque es el registro "NOMBRE" (La clave principal en Access)
            ComboBox1.Items.Add(TextBox2.Text)
            MyRowPosition = I
        Next
        MyRowPosition = 0



        '-----------------------
        'ESTÉTICA DE LOS BOTONES, QUE APAREZCA UN BOCADILLO DE TEXTO = ARRAY DE TOOLTIP
        Dim TL(8) As ToolTip 'DIMENSIONO SEGUN EN QUE CONTROLES QUIERO MI AYUDA
        For I = 0 To 8
            TL(I) = New ToolTip
            TL(I).IsBalloon = True
        Next
        TL(0).SetToolTip(Me.BTN_IRALPRIMERO, "Ir al primero")
        TL(1).SetToolTip(Me.BTN_RETROCEDER, "Ir al anterior")
        TL(2).SetToolTip(Me.BTN_AVANZAR, "Ir al siguiente")
        TL(3).SetToolTip(Me.BTN_IRALULTIMO, "Ir al último")
        TL(4).SetToolTip(Me.BTN_GRABAR, "Guardar Registro")
        TL(5).SetToolTip(Me.BTN_NUEVO, "Crear Registro")
        TL(6).SetToolTip(Me.BTN_BUSCAR, "Buscar")
        TL(7).SetToolTip(Me.BTN_BORRAR, "Borrar")
        '-----------------------

    End Sub


    'CREO LOS BOTONES 

    Private Sub BTN_IRALPRIMERO_Click(sender As Object, e As EventArgs) Handles BTN_IRALPRIMERO.Click
        MyRowPosition = 0
        Call showrecords()
    End Sub

    Private Sub BTN_RETROCEDER_Click(sender As Object, e As EventArgs) Handles BTN_RETROCEDER.Click
        If MyRowPosition = 0 Then Exit Sub
        MyRowPosition = MyRowPosition - 1
        Call showrecords()
    End Sub

    Private Sub BTN_AVANZAR_Click(sender As Object, e As EventArgs) Handles BTN_AVANZAR.Click
        If MyDataTbl.Rows.Count - 1 = MyRowPosition Then Exit Sub
        MyRowPosition = MyRowPosition + 1
        Call showrecords()
    End Sub

    Private Sub BTN_IRALULTIMO_Click(sender As Object, e As EventArgs) Handles BTN_IRALULTIMO.Click
        MyRowPosition = MyDataTbl.Rows.Count - 1
        Call showrecords()
    End Sub


    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click
        Dim MyNewRow As DataRow = MyDataTbl.NewRow()
        MyDataTbl.Rows.Add(MyNewRow)
        MyRowPosition = MyDataTbl.Rows.Count - 1
        Me.showrecords()
        TextBox1.Select()
        BTN_GRABAR.Enabled = True
        BTN_NUEVO.Enabled = False
    End Sub


    Private Sub BTN_GRABAR_Click(sender As Object, e As EventArgs) Handles BTN_GRABAR.Click
        'DATA ADAPTER
        Try
            If MyDataTbl.Rows.Count <> 0 Then
                MyDataTbl.Rows(MyRowPosition)("CLAVE") = UCase(TextBox1.Text)
                MyDataTbl.Rows(MyRowPosition)("NOMBRE") = UCase(TextBox2.Text)
                MyDataTbl.Rows(MyRowPosition)("PROVINCIA") = UCase(TextBox3.Text)
                MyDatAdp.Update(MyDataTbl)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call REFRESCA()
        BTN_GRABAR.Enabled = False
        BTN_NUEVO.Enabled = True
    End Sub

    Private Sub BTN_BUSCAR_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR.Click

        GroupBox1.Visible = True


    End Sub

    Private Sub BTN_BORRAR_Click(sender As Object, e As EventArgs) Handles BTN_BORRAR.Click
        Dim R As Integer 'VARIABLE R PARA EL SI = 6 O EL NO =7 DEL MSGBOX
        R = MsgBox("¿Estas seguro de querer borrar el registro?", vbYesNo, "BORRAR REGISTRO")
        If R = 7 Then Exit Sub
        If MyDataTbl.Rows.Count <> 0 Then  'SI HAY FILAS ENTONCES
            MyDataTbl.Rows(MyRowPosition).Delete()
            MyDatAdp.Update(MyDataTbl)
            MyRowPosition = 0
            Me.showrecords()
        End If
    End Sub


    Sub REFRESCA()
        MyCn.Close()
        MyCn.ConnectionString = "Dsn=ACCESS"
        MyDatAdp = New OdbcDataAdapter("SELECT * FROM tabla", MyCn)
        MyCmdBld = New OdbcCommandBuilder(MyDatAdp)
        MyDatAdp.Fill(MyDataTbl)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'checked cambia para ponerse activado o para ponerse desactivado
        If RadioButton1.Checked = True Then
            Dim sebusca As String
            Cursor.Current = Cursors.WaitCursor
            MyRowPosition = 0
            Call showrecords()

            sebusca = UCase(InputBox("Mete la clave del registro", "SE BUSCA"))
            For I = 0 To MyDataTbl.Rows.Count
                Call showrecords()
                'se busca por textbox1.text porque es el registro "CLAVE" (La clave principal en Access)
                If InStr(TextBox1.Text, sebusca) <> 0 Then
                    GoTo sal
                End If
                MyRowPosition = I
            Next
            MsgBox("No esta")


            'El cursor del mouse le da forma de actualizar
sal:

            Cursor.Current = Cursors.Default
            GroupBox1.Visible = False
        End If
        RadioButton1.Checked = False

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'checked cambia para ponerse activado o para ponerse desactivado
        If RadioButton2.Checked = True Then
            Dim sebusca As String
            Cursor.Current = Cursors.WaitCursor
            MyRowPosition = 0
            Call showrecords()

            'Ucase pone en mayusculas -  si metes en minusculas no lo coge
            sebusca = UCase(InputBox("Mete el nombre del registro", "SE BUSCA"))

            For I = 0 To MyDataTbl.Rows.Count
                Call showrecords()
                'se busca por textbox2.text porque es el registro "NOMBRE" 
                If InStr(TextBox2.Text, sebusca) <> 0 Then
                    GoTo sal
                End If
                MyRowPosition = I
            Next
            MsgBox("No esta")


            'El cursor del mouse le da forma de actualizar
sal:

            Cursor.Current = Cursors.Default

            GroupBox1.Visible = False
        End If
        RadioButton2.Checked = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        'checked cambia para ponerse activado o para ponerse desactivado
        If RadioButton3.Checked = True Then
            Dim sebusca As String
            Cursor.Current = Cursors.WaitCursor
            MyRowPosition = 0
            Call showrecords()

            sebusca = UCase(InputBox("Mete la provincia del registro", "SE BUSCA"))
            For I = 0 To MyDataTbl.Rows.Count
                Call showrecords()
                'se busca por textbox3.text porque es el registro "PROVINCIA" 
                If InStr(TextBox3.Text, sebusca) <> 0 Then
                    GoTo sal
                End If
                MyRowPosition = I
            Next
            MsgBox("No esta")


            'El cursor del mouse le da forma de actualizar
sal:

            Cursor.Current = Cursors.Default

            GroupBox1.Visible = False
        End If
        RadioButton3.Checked = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        BTN_GRABAR.Enabled = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        BTN_GRABAR.Enabled = True
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        BTN_GRABAR.Enabled = True
    End Sub


    '____________________________________________________________
    'CARGA EN EL TEXTBOX 2 (NOMBRE) EL TEXTO DEL COMBOBOX
    '____________________________________________________________
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        MyRowPosition = 0

        For I = 0 To MyDataTbl.Rows.Count
            Call showrecords()
            If InStr(TextBox2.Text, ComboBox1.Text) <> 0 Then
                GoTo IR
            End If
            'Añade al combo textbox2.text porque es el registro "NOMBRE" (La clave principal en Access)
            MyRowPosition = I
        Next
IR:
    End Sub
End Class
