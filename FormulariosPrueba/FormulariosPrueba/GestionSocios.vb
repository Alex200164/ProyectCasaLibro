﻿' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class GestionSocios

    ' Número de control para controlar el dataBinding de los text boxes del formulario modificaciones, evitando que se relacionen dos veces.
    Public numeroDeControlBindingModificaciones As Long

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CasaLibroDB.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Socios", conexion)

    'Declaramos el botón  Modificar que será creado dinamicamente junto a los resgistros del DataGridView.
    Public button_din_modificar As New DataGridViewButtonColumn
    'Creamos in estilo que aplicaremos a las caracteristicas del botón Modificar.
    Public style As New DataGridViewCellStyle

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    Public posicionDataGridSeleccionada As Integer

    ' Método que se ejecuta al iniciarse el formulario
    Private Sub GestionSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Cargar la memoria del cache con datos.
            adaptador.Fill(midataset, "Socios")

            ' cargar en el datagridview, le decimos de donde sacamos los datos
            DataGridView_Socios.DataSource = midataset
            DataGridView_Socios.DataMember = "Socios"

            ' Inicializamos el número de control
            numeroDeControlBindingModificaciones = 0

            'Creación en la ultima columna del DataGridView el botón de modificar en cada registro.
            crearButtonDataGridView()

        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("Parece que algo ha salido mal. Revise que la base de datos no esté abierta durante la ejecución.", MsgBoxStyle.OkOnly, "Error - Base de datos")

            ' Especificamos la posición de la ventana
            posicionarFormularioMenuPrincipal()

            ' Mostramos el menú principal.
            MenuPrincipal.Show()

            ' Cerramos este formulario
            Me.Close()

        End Try
    End Sub

    ' Método que se ejecuta al pulsar en una de las cajas del DataGridView
    Private Sub DataGridView_Socios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Socios.CellClick
        posicionDataGridSeleccionada = BindingContext(midataset, "Socios").Position
    End Sub

    ' Método que permite posicionar la ventana en la posición especificada del formulario "GestionSociosAltas".
    ' En este caso para evitar que quede encima del formulario anterior.
    Private Shared Sub posicionarGestionAltas()
        GestionSociosAltas.StartPosition = FormStartPosition.Manual
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.55)
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Height - (My.Computer.Screen.Bounds.Size.Height * 0.8)
        GestionSociosAltas.Location = New Point(a, b)
    End Sub

    ' Método que permite posicionar la ventana en la posición especificada del formulario "GestionSociosModificaciones".
    ' En este caso para evitar que quede encima del formulario anterior.
    Private Shared Sub posicionarGestionModificaciones()
        GestionSociosModificaciones.StartPosition = FormStartPosition.Manual
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.55)
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Height - (My.Computer.Screen.Bounds.Size.Height * 0.8)
        GestionSociosModificaciones.Location = New Point(a, b)
    End Sub

    ' Método que permite posicionar la ventana en la posición especificada del formulario "MenuPrincipal".
    ' En este caso para evitar que quede encima del formulario anterior.
    Private Shared Sub posicionarFormularioMenuPrincipal()
        MenuPrincipal.StartPosition = FormStartPosition.Manual
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.97)
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Height - (My.Computer.Screen.Bounds.Size.Height * 0.97)
        MenuPrincipal.Location = New Point(a, b)
    End Sub

    ' Método que se ejecuta cuando el botón "Añadir" es pulsado.
    Private Sub Button_Annadir_Click(sender As Object, e As EventArgs) Handles Button_Annadir.Click
        ' Posicionamos el formulario que vamos a mostrar.
        posicionarGestionAltas()
        ' Mostramos el formulario
        GestionSociosAltas.ShowDialog()
    End Sub


    'Método que crea y da formato al botón de modificar, en cada una de los registros del DataGridView. 
    'Este bóton abrirá el formulario de GestionSociosModificaciones. 
    Public Sub crearButtonDataGridView()
        'style.BackColor when the button Is Not selected
        style.BackColor = Color.White

        'Le asignamos un nombre   
        button_din_modificar.Name = "Modificar"
        'Le asignamos un tamaño
        button_din_modificar.Width = 50
        'declare a DataGridViewCellStyle
        button_din_modificar.FlatStyle = FlatStyle.Popup

        'Cargar en la ultima columna del DataGridView, la creación y el estilo del botón interno.
        DataGridView_Socios.Columns.Add(button_din_modificar)
    End Sub

    'Metodo evento que capta la puslación en la celda relativa al botón. 
    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles DataGridView_Socios.CellContentClick

        'Convierte el objeto en sender
        Dim senderGrid = DirectCast(sender, DataGridView)

        'Comprueba que es una columna del data gridview que tiene el evento y que tiene indice mayor que 0
        'Si es correcto se ejecutará el comando de abrir GestionSociosModificaciones
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            ' Posicionamos el formulario que vamos a mostrar.
            posicionarGestionModificaciones()
            ' Mostramos el formulario
            GestionSociosModificaciones.ShowDialog()

            'System.ArgumentException hacer expecion try catch


        End If
    End Sub

    'Metodo que pinta el Icono asociado al botón dinámico Modificar, el la ultima Columna del DataGridView
    Private Sub DataGridView1_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles DataGridView_Socios.CellPainting
        If e.ColumnIndex = 5 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            'Liena de código que calcula la posicion de el dibujo en concreto.
            e.Graphics.DrawImage(My.Resources.modificar_ico, CInt((e.CellBounds.Width / 2) - (My.Resources.modificar_ico.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.modificar_ico.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    'Metodo que detecta que botón se ha pulsado y envia la orden  de posicionar a: 
    'GestionLibros/GestionEmpleados/GestionSocios
    Private Sub posicionarFormulariosGestiones(ByVal btn_Name As String)
        'Especifica que el tipo de posicion de arranque será manual para Gestión Libros
        GestionLibros.StartPosition = FormStartPosition.Manual
        'Especifica que el tipo de posicion de arranque será manual para Gestión Empleados
        GestionEmpleados.StartPosition = FormStartPosition.Manual
        'Especifica que el tipo de posicion de arranque será manual para Gestión Articulos
        GestionArticulos.StartPosition = FormStartPosition.Manual

        'Varaible tipo Integer que calculará la posición vertical en la que ubicará el nuevo formulario
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.97)

        'Varaible tipo Integer que calculará la posición horizontal en la que ubicará el nuevo formulario
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.97)

        'Condición que compará el nombre del botón recibido como parametro con la cadena correspondiente a dicho botón.
        If btn_Name.Equals("gestiónlibrostoolstripmenuitem1") Then
            GestionLibros.Location = New Point(a, b) 'Posiciona en las coordenadas a y b     
        ElseIf btn_Name.Equals("gestiónempleadostoolstripmenuitem1") Then
            GestionEmpleados.Location = New Point(a, b) 'Posiciona en las coordenadas a y b
        ElseIf btn_Name.Equals("gestiónarticulostoolstripmenuitem1") Then
            GestionArticulos.Location = New Point(a, b) 'Posiciona en las coordenadas a y b
        End If
    End Sub

    ' Método que se ejecuta cuando es pulsado el botón "Gestion de Libros" del menuStrip
    Private Sub GestiónLibrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestiónLibrosToolStripMenuItem1.Click
        'Variable que nos dice cual es el Nombre del ToolStripMenuItem pulsado
        Dim item_Name As String = DirectCast(sender, ToolStripMenuItem).Name.ToLower.Replace("clear", "")

        'Confirmación sobre cambio de formulario
        If MsgBox("¿Está seguro de que desea cambiar de formulario?", 36, "Salir") = 6 Then
            Me.Hide() 'Ocultamos este formulario

            'Invocamos al método que posiciona el Formulario de Gestion
            posicionarFormulariosGestiones(item_Name)

            GestionLibros.Show()
        End If
    End Sub

    ' Método que se ejecuta cuando es pulsado el botón "Gestion de Socios" del menuStrip
    Private Sub GestiónArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónArticulosToolStripMenuItem1.Click
        'Variable que nos dice cual es el Nombre del ToolStripMenuItem pulsado
        Dim item_Name As String = DirectCast(sender, ToolStripMenuItem).Name.ToLower.Replace("clear", "")

        'Confirmación sobre cambio de formulario
        If MsgBox("¿Está seguro de que desea cambiar de formulario?", 36, "Salir") = 6 Then
            Me.Hide() 'Ocultamos este formulario

            'Invocamos al método que posiciona el Formulario de Gestion
            posicionarFormulariosGestiones(item_Name)

            GestionArticulos.Show()
        End If
    End Sub

    ' Método que se ejecuta cuando es pulsado el botón "Gestion de Empleados" del menuStrip
    Private Sub GestiónEmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestiónEmpleadosToolStripMenuItem1.Click
        'Variable que nos dice cual es el Nombre del ToolStripMenuItem pulsado
        Dim item_Name As String = DirectCast(sender, ToolStripMenuItem).Name.ToLower.Replace("clear", "")

        'Confirmación sobre cambio de formulario
        If MsgBox("¿Está seguro de que desea cambiar de formulario?", 36, "Salir") = 6 Then
            Me.Hide() 'Ocultamos este formulario

            'Invocamos al método que posiciona el Formulario de Gestion
            posicionarFormulariosGestiones(item_Name)

            GestionEmpleados.Show()
        End If
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

    ' Método que se ejecuta cuando el botón "Salir..." del ToolStrip es pulsado y que nos lleva al formulario "MenuPrincipal"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Especificamos la posición de la ventana
        posicionarFormularioMenuPrincipal()

        ' Mostramos el menú principal.
        MenuPrincipal.Show()


        ' Cerramos este formulario
        Me.Close()
    End Sub

    ' Actualizamos el dataGridView
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        midataset.Clear()


        ' Cargar la memoria del cache con datos.
        adaptador.Fill(midataset, "Socios")

        ' cargar en el datagridview, le decimos de donde sacamos los datos
        DataGridView_Socios.DataSource = midataset
        DataGridView_Socios.DataMember = "Socios"
    End Sub
End Class