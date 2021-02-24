' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class GestionSociosModificaciones

    ' Variable para almacenar el número de socio inicial con el que se identificará el registro a modificar.
    Dim numSocioInicial As String

    ' Variable de control que controla que no se recoja más de una vez el valor de la primary key
    Dim numControlPK As Single = 0

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CasaLibroDB.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Socios", conexion)

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet



    ' Método que se ejecuta cuando se pulsa el botón "Limpiar".
    ' "Limpia" todos los textBox, dejandolos vacios.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Vaciamos cada textBox de forma individual
        TextBox_NumeroSocio.Clear()
        TextBox_Nombre.Clear()
        TextBox_Apellidos.Clear()
        TextBox_Telefono.Clear()
        TextBox_Correo.Clear()
    End Sub

    '  Método que se ejecuta al iniciarse el formulario. El cual nos mostrará los datos de la Seleccion que hemos hecho en el DataGridView_Socios del formulario GestionSocios
    '  en los textBox correspondientes. Para esto crearemos un nuevo comando, y lo asociaremos al midataset para obtener los datos que queremos
    Private Sub GestionSociosModificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Creamos un comando nuevo con una Query nueva la cual vamos a usar para poder buscar un socio en concreto
        Dim comando As New OleDbCommand(("select * from Socios where NumeroDeSocio = @numSocio"), conexion)

        'Al adaptador le asignamos este nuevo comando "comando"
        adaptador.SelectCommand = comando
        'Al comando le vamos a pasar por parametro @numSocio (valor de tipo Numeric, 8) el cual va a ser cogido de la Fila(currentRow) seleccionada de la Columna 0 (NumeroSocio)
        'del DataGridView_Socios del formulario GestionSocios. Es decir al seleccionar un elemento detectará cual es la fila y el valor de la columna 0 y lo pasará por parametro.
        comando.Parameters.Add("@numSocio", OleDbType.Numeric, 8).Value = GestionSocios.DataGridView_Socios.Item(0, GestionSocios.DataGridView_Socios.CurrentRow.Index).Value

        'Limpiamos el midataset para que no haya información residual
        midataset.Clear() 'de este form 
        'Asociamos el nuevo adaptador con el nuevo comando al midataset de la tabla Socios 
        adaptador.Fill(midataset, "Socios")

        If GestionSocios.numeroDeControlBindingModificaciones = 0 Then
            'Se relacionan los campos de la tabla con los textbox y se muestran los datos del registro que queremos modificar.
            Me.TextBox_NumeroSocio.DataBindings.Add("text", midataset, "Socios.NumeroDeSocio")
            Me.TextBox_Nombre.DataBindings.Add("text", midataset, "Socios.Nombre")
            Me.TextBox_Apellidos.DataBindings.Add("text", midataset, "Socios.Apellidos")
            Me.TextBox_Telefono.DataBindings.Add("text", midataset, "Socios.Telefono")
            Me.TextBox_Correo.DataBindings.Add("text", midataset, "Socios.Correo")

            GestionSocios.numeroDeControlBindingModificaciones = 1
        End If


        ' Inicializamos la variable asignandole el número de socio inicial
        numSocioInicial = GestionSocios.DataGridView_Socios.Item(0, GestionSocios.DataGridView_Socios.CurrentRow.Index).Value


    End Sub



    ' Método que se ejecuta al pulsarse el botón "Modificar"
    ' Se encarga de modificar los datos ya existentes en la DB
    Private Sub Button_Modificar_Click(sender As Object, e As EventArgs) Handles Button_Modificar.Click
        If TextBox_NumeroSocio.Text = "" Or TextBox_Nombre.Text = "" Or TextBox_Apellidos.Text = "" Or TextBox_Telefono.Text = "" Or TextBox_Correo.Text = "" Then
            MsgBox("Debes seleccionar un registro para actualizarlo y si lo has seleccionado, no debe quedar ningún campo en blanco", MsgBoxStyle.OkOnly, "Error al dar de alta.")
        Else

            Dim valor As String
            Dim control As Integer = 0

            ' Comprobamos que la clave primaria no se encuentra ya registrada.
            For contador As Integer = 0 To GestionSocios.DataGridView_Socios.RowCount - 1
                valor = GestionSocios.DataGridView_Socios.Item(0, contador).Value

                If valor = TextBox_NumeroSocio.Text And valor <> numSocioInicial Then
                    MsgBox("No puedes introducir un número de socio que ya existe en la base de datos.", MsgBoxStyle.OkOnly, "Error, clave duplicada")
                    control = 1
                End If
            Next


            If control = 0 Then
                Try
                    ' Montamos una query parametrizada.
                    Dim queryParametrizada As String = "UPDATE Socios SET NumeroDeSocio=?, Nombre=?, Apellidos=?, Telefono=?, Correo=? WHERE NumeroDeSocio=?"
                    Using cmd = New OleDbCommand(queryParametrizada, conexion)

                        conexion.Open()
                        cmd.Parameters.AddWithValue("@p1", Convert.ToInt64(TextBox_NumeroSocio.Text))
                        cmd.Parameters.AddWithValue("@p2", TextBox_Nombre.Text)
                        cmd.Parameters.AddWithValue("@p3", TextBox_Apellidos.Text)
                        cmd.Parameters.AddWithValue("@p4", Convert.ToInt64(TextBox_Telefono.Text))
                        cmd.Parameters.AddWithValue("@p5", TextBox_Correo.Text)
                        cmd.Parameters.AddWithValue("@p6", Convert.ToSingle(numSocioInicial))

                        cmd.ExecuteNonQuery()

                        ' System.FormatException montar try catch

                        conexion.Close()
                    End Using


                    ' Dim cb As New OleDbCommandBuilder(adaptador)
                    ' adaptador.UpdateCommand = cb.GetUpdateCommand
                Catch ex As System.InvalidOperationException
                    ' Avisamos del error por mensaje
                    MsgBox("Algo no ha ido bien, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                End Try

                ' Dim a As Integer = GestionSocios.posicionDataGridSeleccionada

                ' Dim fila As DataRow = GestionSocios.midataset.Tables("Socios").Rows(a)



                ' Comenzamos la edición
                '  fila.BeginEdit()
                '  fila("NumeroDeSocio") = TextBox_NumeroSocio.Text
                '  fila("Nombre") = TextBox_Nombre.Text
                ' fila("Apellidos") = TextBox_Apellidos.Text
                '  fila("Telefono") = TextBox_Telefono.Text
                '  fila("Correo") = TextBox_Correo.Text
                '  fila.EndEdit()
                ' Finalizamos la edición

                '  Try
                ' ' Ejecutamos la sentencia
                ' adaptador.Update(GestionSocios.midataset.Tables("Socios"))
                ' Catch ex As System.InvalidOperationException

                ' End Try

                ' Actualizamos el dataGridView del formulario de gestión principal
                ' GestionSocios.midataset.Clear()

                ' Cargamos cache
                'GestionSocios.adaptador.Fill(GestionSocios.midataset, "Socios")

                ' cargar en el datagridview, le decimos de donde sacamos los datos

                'GestionSocios.DataGridView_Socios.DataSource = GestionSocios.midataset
                'GestionSocios.DataGridView_Socios.DataMember = "Socios"

                ' Actualizamos el dataGridView del formulario de gestión principal
                GestionSocios.midataset.Clear()
                GestionSocios.adaptador.Fill(GestionSocios.midataset, "Socios")

                ' Cerramos la ventana
                Me.Close()

                ' Hacer try-catch
                ' 

            End If

        End If
    End Sub


    ' #####################################################    Métodos varios    ##########################################################################


    ' Método que se ejecuta cuando el botón "Salir..." del ToolStrip es pulsado y que nos lleva al formulario "GestionSocios".
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Mostramos el formulario "GestionSocios".
        GestionSocios.Show()

        ' Cerramos este formulario
        Me.Close()
    End Sub

    ' Método que se ejecuta cuando es pulsado el botón "Calculadora" del menuStrip
    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        ' Try catch para atrapar el error en caso de que el ordenador del usuario
        Try
            Dim program As String
            program = "calc.exe"
            Process.Start(program)
        Catch ex As System.ComponentModel.Win32Exception '
            MsgBox("Ha ocurrido un error, no se pudo iniciar la calculadora.", MsgBoxStyle.OkOnly, "Error (proceso calculadora)")
        End Try
    End Sub


End Class