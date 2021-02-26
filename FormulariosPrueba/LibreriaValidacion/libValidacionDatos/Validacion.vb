Imports System.IO

Public Class Validacion

    ' Validación de DNI
    Public Function validarDNI(codigo As String, tipo As Integer) As Boolean

        ' Si el tipo es 1, solo se comprueba que no se pase de 8 caracteres y que estos sean solo númericos
        ' Si el tipo es 2, comprueba todo, incluyendo que la minima longitud sea de 8 caracteres.

        ' Se opta de nuevo por la solución de poner en un String los valores permitidos.
        Dim charsPosibles As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789"

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 9

        If tipo = 1 Then
            For i = 1 To codigo.Length
                For j = 1 To charsPosibles.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosibles, j)) Then

                    Else
                        ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                        ' entonces los datos se validan.
                        coincidencias = coincidencias + 1
                    End If
                Next j
            Next i

            ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
            If coincidencias = codigo.Length And codigo.Length <= valorMaximo Then
                valido = True
            Else
                MsgBox(" El dato DNI, no puede contener caracteres que no sean numéricos o símbolos no permitidos, debe tener una longitud de 9 digitos. La letra debe estar en mayúscula.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
                'MsgBox(" El número de socio no puede contener otros caracteres que no sean números.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
            End If
            Return valido
        End If

        If tipo = 2 Then
            For i = 1 To codigo.Length
                For j = 1 To charsPosibles.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosibles, j)) Then

                    Else
                        ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                        ' entonces los datos se validan.
                        coincidencias = coincidencias + 1
                    End If
                Next j
            Next i

            ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
            If coincidencias = codigo.Length And codigo.Length = valorMaximo Then
                valido = True
            Else
                MsgBox(" El dato DNI, no puede contener caracteres que no sean numéricos o símbolos no permitidos, debe tener una longitud de 9 digitos. La letra debe estar en mayúscula.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
                'MsgBox(" El número de socio no puede contener otros caracteres que no sean números.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
            End If
            Return valido
        End If

    End Function

    ' Validación de número de socio
    Public Function validarNumeroSocio(codigo As String, tipo As Integer) As Boolean

        ' Si el tipo es 1, solo se comprueba que no se pase de 8 caracteres y que estos sean solo númericos
        ' Si el tipo es 2, comprueba todo, incluyendo que la minima longitud sea de 8 caracteres.

        ' Se opta de nuevo por la solución de poner en un String los valores permitidos.
        Dim charsPosibles As String = "0123456789"

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 8

        If tipo = 1 Then
            For i = 1 To codigo.Length
                For j = 1 To charsPosibles.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosibles, j)) Then

                    Else
                        ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                        ' entonces los datos se validan.
                        coincidencias = coincidencias + 1
                    End If
                Next j
            Next i

            ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
            If coincidencias = codigo.Length And codigo.Length <= valorMaximo Then
                valido = True
            Else
                MsgBox(" El dato número socio, no puede contener caracteres que no sean numéricos o símbolos no permitidos, debe tener una longitud de 8 digitos.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
                'MsgBox(" El número de socio no puede contener otros caracteres que no sean números.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
            End If
            Return valido
        End If

        If tipo = 2 Then
            For i = 1 To codigo.Length
                For j = 1 To charsPosibles.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosibles, j)) Then

                    Else
                        ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                        ' entonces los datos se validan.
                        coincidencias = coincidencias + 1
                    End If
                Next j
            Next i

            ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
            If coincidencias = codigo.Length And codigo.Length = valorMaximo Then
                valido = True
            Else
                MsgBox(" El dato número socio, no puede contener caracteres que no sean numéricos o símbolos no permitidos, debe tener una longitud de 8 digitos.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
                'MsgBox(" El número de socio no puede contener otros caracteres que no sean números.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
            End If
            Return valido
        End If

        'Solo se permiten códigos de hasta 8 números.
        'If codigo.Length > valorMaximo Then
        'MsgBox("Por favor, introduzca un número de socio que sea de 8 dígitos", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta.")
        'End If


    End Function

    ' Validación de número de teléfono
    Public Function validarTelefono(codigo As String, tipo As Integer) As Boolean
        ' Se opta de nuevo por la solución de poner en un String los valores permitidos.
        Dim charsPosibles As String = "0123456789"

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 9

        ' Solo se permiten códigos de hasta 9 números.
        'If codigo.Length > valorMaximo Then
        'MsgBox("Por favor, introduzca un número de teléfono que sea menor de 8 dígitos", MsgBoxStyle.OkOnly, "Longitud incorrecta.")
        'End If

        If tipo = 1 Then

            For i = 1 To codigo.Length
                For j = 1 To charsPosibles.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosibles, j)) Then

                    Else
                        ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                        ' entonces los datos se validan.
                        coincidencias = coincidencias + 1
                    End If
                Next j
            Next i

            ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
            If coincidencias = codigo.Length And codigo.Length <= valorMaximo Then
                valido = True
            Else
                MsgBox(" El dato telefono, no puede contener caracteres que no sean numéricos o símbolos no permitidos, también debe tener una longitud de 9 digitos.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
            End If
            Return valido

        End If

        If tipo = 2 Then

            For i = 1 To codigo.Length
                For j = 1 To charsPosibles.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosibles, j)) Then

                    Else
                        ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                        ' entonces los datos se validan.
                        coincidencias = coincidencias + 1
                    End If
                Next j
            Next i

            ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
            If coincidencias = codigo.Length And codigo.Length = valorMaximo Then
                valido = True
            Else
                MsgBox(" El dato telefono, no puede contener caracteres que no sean numéricos o símbolos no permitidos, también debe tener una longitud de 9 digitos.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
            End If
            Return valido

        End If
    End Function

    ' Validación de nombre
    Public Function validarNombre(codigo As String, tipo As Integer) As Boolean

        ' Si tipo es 1, se realizara la validación de un nombre.
        ' Si tipo es 2, se realizara la validación de un apellido.

        ' Para el nombre.
        Dim charsPosiblesNombre As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ "
        Dim charsPosiblesApellido As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ- "

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 50

        ' Solo se permiten nombres de hasta 50 números.
        If codigo.Length > valorMaximo Then
            MsgBox("Por favor, introduzca un nombre que sea menor de 50 caracteres.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta.")
        End If

        ' Validación nombre
        If tipo = 1 Then
            For i = 1 To codigo.Length
                For j = 1 To charsPosiblesNombre.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosiblesNombre, j)) Then

                    Else
                        ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                        ' entonces los datos se validan.
                        coincidencias = coincidencias + 1
                    End If
                Next j
            Next i
        End If

        ' Validación apellido
        If tipo = 2 Then
            For i = 1 To codigo.Length
                For j = 1 To charsPosiblesApellido.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosiblesApellido, j)) Then

                    Else
                        ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                        ' entonces los datos se validan.
                        coincidencias = coincidencias + 1
                    End If
                Next j
            Next i
        End If


        ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
        If coincidencias = codigo.Length Then
            valido = True
        Else
            MsgBox(" El nombre/apellido no puede contener caracteres numéricos o símbolos no permitidos.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
        End If
        Return valido
    End Function

    ' Validación de usuario
    Public Function validarUsuario(codigo As String) As Boolean

        Dim charsPosiblesUsuario As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890-_"

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 30

        ' Solo se permiten usuarios de hasta 30 caracteres.
        If codigo.Length > valorMaximo Then
            MsgBox("Por favor, introduzca un usuario que sea menor de 31 caracteres.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta.")
        End If


        For i = 1 To codigo.Length
            For j = 1 To charsPosiblesUsuario.Length
                If (GetChar(codigo, i) <> GetChar(charsPosiblesUsuario, j)) Then

                Else
                    ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                    ' entonces los datos se validan.
                    coincidencias = coincidencias + 1
                End If
            Next j
        Next i

        ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
        If coincidencias = codigo.Length Then
            valido = True
        Else
            MsgBox(" El usuario no puede contener símbolos no permitidos. Debe tener una longitud máxima de 30 caracteres", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
        End If
        Return valido
    End Function

    ' Validación de contraseña
    Public Function validarContra(codigo As String, tipo As Integer) As Boolean

        Dim charsPosiblesNombre As String = "1234567890"

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 4

        If tipo = 1 Then
            For i = 1 To codigo.Length
                For j = 1 To charsPosiblesNombre.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosiblesNombre, j)) Then

                    Else
                        ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                        ' entonces los datos se validan.
                        coincidencias = coincidencias + 1
                    End If
                Next j
            Next i

            ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
            If coincidencias = codigo.Length And codigo.Length <= valorMaximo Then
                valido = True
            Else
                MsgBox(" La contraseña no puede contener caracteres no permitidos. Debe tener una longitud de 4 digitos", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
            End If
            Return valido
        End If

        If tipo = 2 Then
            For i = 1 To codigo.Length
                For j = 1 To charsPosiblesNombre.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosiblesNombre, j)) Then

                    Else
                        ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                        ' entonces los datos se validan.
                        coincidencias = coincidencias + 1
                    End If
                Next j
            Next i

            ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
            If coincidencias = codigo.Length And codigo.Length = valorMaximo Then
                valido = True
            Else
                MsgBox(" La contraseña no puede contener caracteres no permitidos. Debe tener una longitud de 4 digitos", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
            End If
            Return valido
        End If


    End Function

    ' Validación del ROL
    Public Function validarROL(codigo As String, tipo As Integer) As Boolean

        Dim charsPosiblesNombre As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ"

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 20

        If tipo = 1 Then
            For i = 1 To codigo.Length
                For j = 1 To charsPosiblesNombre.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosiblesNombre, j)) Then

                    Else
                        ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                        ' entonces los datos se validan.
                        coincidencias = coincidencias + 1
                    End If
                Next j
            Next i

            ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
            If coincidencias = codigo.Length And codigo.Length <= valorMaximo Then
                valido = True
            Else
                MsgBox(" El rol no puede contener caracteres no permitidos. Debe tener una longitud menor de 21 caracteres", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
            End If
            Return valido
        End If

        If tipo = 2 Then
            For i = 1 To codigo.Length
                For j = 1 To charsPosiblesNombre.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosiblesNombre, j)) Then

                    Else
                        ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                        ' entonces los datos se validan.
                        coincidencias = coincidencias + 1
                    End If
                Next j
            Next i

            ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
            If coincidencias = codigo.Length And codigo.Length = valorMaximo Then
                valido = True
            Else
                MsgBox(" El rol no puede contener caracteres no permitidos. Debe tener una longitud menor de 21 caracteres", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
            End If
            Return valido
        End If
    End Function


    ' Validación de correo electrónico
    Public Function validarCorreo(codigo As String, tipo As Integer) As Boolean

        ' Si el tipo es 1, solo se comprueba que no se pase de 120 caracteres
        ' Si el tipo es 2, comprueba todo, incluyendo que la minima longitud sea de 120 caracteres.

        ' Para el correo.
        Dim charsPosiblesCorreo As String = "1234567890abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ_-.@!#"

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 120

        If tipo = 1 Then
            For i = 1 To codigo.Length
                For j = 1 To charsPosiblesCorreo.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosiblesCorreo, j)) Then

                    Else
                        ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                        ' entonces los datos se validan.
                        coincidencias = coincidencias + 1
                    End If
                Next j
            Next i

            ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
            If coincidencias = codigo.Length And codigo.Length <= valorMaximo Then
                valido = True
            Else
                MsgBox(" El correo electrónico no puede contener símbolos no permitidos o ser mayor de 120 caracteres.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
                'MsgBox(" El número de socio no puede contener otros caracteres que no sean números.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
            End If
            Return valido
        End If


        If tipo = 2 Then
            For i = 1 To codigo.Length
                For j = 1 To charsPosiblesCorreo.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosiblesCorreo, j)) Then

                    Else
                        ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                        ' entonces los datos se validan.
                        coincidencias = coincidencias + 1
                    End If
                Next j
            Next i

            ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
            If coincidencias = codigo.Length And codigo.Length = valorMaximo Then
                valido = True
            Else
                MsgBox(" El correo electrónico no puede contener símbolos no permitidos o ser mayor de 120 caracteres.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
                'MsgBox(" El número de socio no puede contener otros caracteres que no sean números.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
            End If
            Return valido
        End If

    End Function

    ' Método usado en la pantalla de inicio de sesión para ver que se introducen solo números en el campo de contraseña.
    Public Function validarCodigo(codigo As String, tipo As Integer) As Boolean
        ' Si se recibe 0 se está validando contraseña en inicio de sesión. (se permiten 4 dígitos)
        ' Si se recibe 1 se está validando teléfono. (se permite 9 dígitos).
        ' Si se recibe 2 se está validando precios en productos

        ' Se opta de nuevo por la solución de poner en un String los valores permitidos.
        Dim charsPosibles As String = "0123456789"
        ' Para el campo de teléfono se permite usar el carácter especial +.
        Dim charsPosiblesTelefono As String = "0123456789+"
        Dim charsPosiblesPrecio As String = "0123456789. "
        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer
        If tipo = 0 Then
            valorMaximo = 4
        ElseIf tipo = 1 Then
            valorMaximo = 9
        ElseIf tipo = 2 Then
            valorMaximo = 5
        End If
        ' Solo se permiten códigos de hasta 4 números.
        ' La validación de que sean 4 se hace en otro método, porque eso depende de la creación de usuarios.
        If codigo.Length > valorMaximo Then
            MsgBox("Por favor, introduzca una contraseña/código de 4 dígitos", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta.")

        Else
            For i = 1 To codigo.Length
                If tipo = 0 Then
                    For j = 1 To charsPosibles.Length
                        If (GetChar(codigo, i) <> GetChar(charsPosibles, j)) Then

                        Else
                            ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                            ' entonces los datos se validan.
                            coincidencias = coincidencias + 1
                        End If
                    Next j
                ElseIf tipo = 1 Then
                    For j = 1 To charsPosiblesTelefono.Length
                        If (GetChar(codigo, i) <> GetChar(charsPosiblesTelefono, j)) Then

                        Else
                            ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                            ' entonces los datos se validan.
                            coincidencias = coincidencias + 1
                        End If
                    Next j
                ElseIf tipo = 2 Then
                    For j = 1 To charsPosiblesPrecio.Length
                        If (GetChar(codigo, i) <> GetChar(charsPosiblesPrecio, j)) Then

                        Else
                            ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                            ' entonces los datos se validan.
                            coincidencias = coincidencias + 1
                        End If
                    Next j
                End If

            Next i
        End If
        ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
        If coincidencias = codigo.Length Then
            valido = True
        End If
        Return valido
    End Function


    ' Método para comprobar que usuario y contraseña introducidos en la pantalla de inicio
    ' coinciden con datos guardados en el fichero secuencial usuarios.txt
    Public Function comprobarDatosSecuencial(file As String, usuario As String, contrasena As Integer) As Integer
        'si devuelve 0 los datos están mal, si devuelve 1 están bien, y si 2 es el admin el que se está conectando.
        Dim coincidenciaNombre As String = ""
        Dim coincidenciaContrasena As Integer = 0
        Dim correcto As Integer = 0
        Dim coincidencia As String
        Dim admin As Boolean
        Try
            ' Este método es como el de coprobar datos para archivos de texto, pero para archivos secuenciales.
            ' Devuelve un booleano, true si los datos coinciden, false si los datos no son correctos.
            FileOpen(1, file, OpenMode.Input)

            While Not EOF(1)
                Input(1, coincidenciaNombre)
                '  MsgBox("coincidenciaNombre:" & coincidenciaNombre & " y parámetro: " & usuario)
                If coincidenciaNombre.Equals(usuario) Then
                    ' Si mientras se lee el archivo secuencial se encuentra un nombre que coincida con el
                    ' pasado por parámetro, se pasa a leer el siguiente campo(la contraseña).
                    Input(1, coincidenciaContrasena)
                    'comentado, razón: esta linea era para testeo: MsgBox("coincidenciaContrasena:" & coincidenciaContrasena & " y parámetro: " & contrasena)
                    ' Si la contraseña coincide con la pasada por parámetro, entonces se valida el acceso a la aplicación.
                    If coincidenciaContrasena = contrasena Then
                        '  FileOpen(1, "usuarios.txt", OpenMode.Input)
                        Input(1, coincidencia)
                        Input(1, coincidencia)
                        Input(1, coincidencia)
                        Input(1, coincidencia)
                        Input(1, admin)
                        If admin = True Then
                            correcto = 2
                            ' Salimos del  while porque ya encontramos al usuario.
                            Exit While
                        Else
                            ' Salimos del  while porque ya encontramos al usuario.
                            correcto = 1
                            Exit While
                        End If
                    Else

                    End If


                End If

            End While


            FileClose(1)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

        Return correcto
    End Function


    Public Function errorLogWrite()
        ' Escribir en errorLog
        Dim fichero = "Errorlog.txt"
        Dim fich As New FileStream(fichero, FileMode.Append, FileAccess.Write)
        Dim rs As New StreamWriter(fich)
        rs.WriteLine(Now & "---> " & "Error en la comprobación de datos." & Chr(13) & "Detalle: " & Err.Description & Chr(13) & "Número de error: " & Err.Number)

        rs.Close()
        fich.Close()
    End Function

    Public Function mensajeErrorDatos()
        MsgBox("Error en la comprobación de datos." & Chr(13) & "Detalle: " & Err.Description & Chr(13) & "Número de error: " & Err.Number)
        errorLogWrite()
    End Function


    ' Método usado para validar diversos campos
    ' Si se recibe el integer 0 = se valida el campo categoría
    ' si se recibe el integer 1 = se valida el campo nombre
    ' si se recibe el integer 2 = se valida el campo tamaño
    Public Function validarCampoProducto(stringRecibido As String, tipo As Integer) As Boolean
        ' Entorno:
        ' Creamos una lista de caracteres permitidos.
        Dim charsPosibles As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ "
        Dim charsPosiblesCategoria As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ "
        Dim charsposiblesTamano As String = "0123456789'. "
        ' Las variables donde guardaremos los caracteres para compararlos.
        Dim chDeLista As Char
        Dim chRecibido As Char
        ' El buchón/chivato para ver si el número de aciertos (caracteres equivalentes) es el mismo al número
        ' de caracteres del string pasado por parámetro.
        Dim coincidencias As Integer = 0
        ' Finalmente la variable boolean valido para que en el formulario se pueda saber si
        ' el string es válido o no.
        Dim valido As Boolean = False
        Dim valorMaximo As Integer


        ' Asignamos el valor a la variable valorMaximo según el tipo de campo que hemos recibido por parámetro.
        If tipo = 0 Or tipo = 1 Then
            valorMaximo = 15
        ElseIf tipo = 2 Then
            valorMaximo = 8
        End If


        ' Inicio
        ' Primero comprobamos el tamaño del string
        If stringRecibido.Length > valorMaximo Then
            MsgBox("No se permiten más de" & valorMaximo & " caracteres.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta")
        Else
            ' Iteramos un número de veces igual al tamaño del string pasado por parámetro.
            For i = 1 To stringRecibido.Length
                ' Guardamos el carácter en chRecibido.
                chRecibido = GetChar(stringRecibido, i)
                ' Comprobamos si el carácter que acabamos de guardar es igual a los caracteres del string(charsPosibles).
                ' Iteramos un número de veces igual al tamaño del string usado para comparar los caracteres en el campo.


                ' Con esta estructura vemos qué estamos validando
                ' Solo si es el tamaño (parámetro con valor 2) se usa la lista charsPosiblesTamano 
                ' Que solo permite números y punto
                If tipo = 2 Then
                    For j = 1 To charsposiblesTamano.Length
                        If chRecibido = GetChar(charsposiblesTamano, j) Then
                            ' Comparamos los caracteres. Si son iguales, se suma 1 al buchón
                            coincidencias = coincidencias + 1
                        End If
                    Next j
                ElseIf tipo = 1 Then
                    ' Si estamos validando nombre:
                    For j = 1 To charsPosibles.Length
                        If chRecibido = GetChar(charsPosibles, j) Then
                            ' Comparamos los caracteres. Si son iguales, se suma 1 al buchón
                            coincidencias = coincidencias + 1
                        End If
                    Next j
                    ' Si estamos validando categoría:
                ElseIf tipo = 0 Then

                    For j = 1 To charsPosiblesCategoria.Length
                        If chRecibido = GetChar(charsPosiblesCategoria, j) Then
                            ' Comparamos los caracteres. Si son iguales, se suma 1 al buchón
                            coincidencias = coincidencias + 1
                        End If
                    Next j
                End If
            Next i

            ' Si el buchón tiene un valor igual al tamaño del string pasado, significa que todos los caracteres
            ' son válidos, pues fueron comparados con los caracteres del String y fueron dados por buenos.
            If coincidencias = stringRecibido.Length Then
                valido = True
            End If
        End If

        Return valido

    End Function

    'Validacion de ISBN
    Public Function ValidarISBN(codigo As String) As Boolean
        ' Se opta de nuevo por la solución de poner en un String los valores permitidos.
        Dim charsPosibles As String = "0123456789"

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        'Máxima longitud del valor.
        valorMaximo = 13

        'Solo se permiten códigos de hasta 13 números.
        If codigo.Length > valorMaximo Then
            MsgBox("Por favor, introduzca un ISBN que sea menor de 13 dígitos", MsgBoxStyle.OkOnly, "Longitud incorrecta.")
        End If

        For i = 1 To codigo.Length
            For j = 1 To charsPosibles.Length
                If (GetChar(codigo, i) <> GetChar(charsPosibles, j)) Then

                Else
                    ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                    ' entonces los datos se validan.
                    coincidencias = coincidencias + 1
                End If
            Next j
        Next i

        ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
        If coincidencias = codigo.Length And codigo.Length <= valorMaximo Then
            valido = True
        Else
            MsgBox("El dato ISBN, solo acepta caracteres numéricos, también debe tener una longitud de 13 digitos.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
        End If
        Return valido
    End Function


    'Validacion de Titulos libros
    Public Function validarTitulolibro(codigo As String) As Boolean

        Dim charsPosiblesNombre As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890-_éúíóáÁÉÍÓÚ,()¿?¡!: "

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 100

        ' Solo se permiten usuarios de hasta 50 caracteres.
        If codigo.Length > valorMaximo Then
            MsgBox("Por favor, introduzca un Titulo que sea menor de 100 caracteres.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta.")
        End If

        For i = 1 To codigo.Length
            For j = 1 To charsPosiblesNombre.Length
                If (GetChar(codigo, i) <> GetChar(charsPosiblesNombre, j)) Then

                Else
                    ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                    ' entonces los datos se validan.
                    coincidencias = coincidencias + 1
                End If
            Next j
        Next i

        ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
        If coincidencias = codigo.Length Then
            valido = True
        Else
            MsgBox(" El Titulo no puede contener símbolos no permitidos. Debe tener una longitud máxima de 100 caracteres", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
        End If
        Return valido
    End Function

    'Validacion Nombre Autor/es
    Public Function validarAutor(codigo As String) As Boolean

        ' Si tipo es 1, se realizara la validación de un nombre.

        ' Para el nombre.
        Dim charsPosiblesNombre As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ.- "

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 50

        ' Solo se permiten nombres de hasta 50 números.
        If codigo.Length > valorMaximo Then
            MsgBox("Por favor, introduzca un nombre que sea menor de 50 caracteres.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta.")
        End If

        ' Validación nombre
        For i = 1 To codigo.Length
            For j = 1 To charsPosiblesNombre.Length
                If (GetChar(codigo, i) <> GetChar(charsPosiblesNombre, j)) Then

                Else
                    ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                    ' entonces los datos se validan.
                    coincidencias = coincidencias + 1
                End If
            Next j
        Next i

        ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
        If coincidencias = codigo.Length Then
            valido = True
        Else
            MsgBox(" El Autor no puede contener caracteres numéricos o símbolos no permitidos.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
        End If
        Return valido
    End Function

    'Validación Numero de paginas/ Año de edicion /Sotck
    Public Function validar4digitos(codigo As String) As Boolean

        Dim charsPosiblesNombre As String = "1234567890"

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 4


        For i = 1 To codigo.Length
            For j = 1 To charsPosiblesNombre.Length
                If (GetChar(codigo, i) <> GetChar(charsPosiblesNombre, j)) Then

                Else
                    ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                    ' entonces los datos se validan.
                    coincidencias = coincidencias + 1
                End If
            Next j
        Next i

        ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
        If coincidencias = codigo.Length And codigo.Length <= valorMaximo Then
            valido = True
        Else
            MsgBox(" Solo se permiten Números. Debe tener una longitud de 4 digitos", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
        End If
        Return valido


    End Function

    'Validacion Editorial
    Public Function validarEditorial(codigo As String) As Boolean

        ' Para el nombre.
        Dim charsPosiblesNombre As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ.123456789 "

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 50

        ' Solo se permiten nombres de hasta 50 números.
        If codigo.Length > valorMaximo Then
            MsgBox("Por favor, introduzca un nombre de editorial que sea menor de 50 caracteres.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta.")
        End If

        ' Validación nombre
        For i = 1 To codigo.Length
            For j = 1 To charsPosiblesNombre.Length
                If (GetChar(codigo, i) <> GetChar(charsPosiblesNombre, j)) Then

                Else
                    ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                    ' entonces los datos se validan.
                    coincidencias = coincidencias + 1
                End If
            Next j
        Next i


        ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
        If coincidencias = codigo.Length Then
            valido = True
        Else
            MsgBox(" La editorial no puede contener caracteres numéricos o símbolos no permitidos.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
        End If
        Return valido
    End Function

    'Validacion Idioma
    Public Function validarIdioma(codigo As String) As Boolean


        ' Para el nombre.
        Dim charsPosiblesNombre As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ "

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 50

        ' Solo se permiten nombres de hasta 50 números.
        If codigo.Length > valorMaximo Then
            MsgBox("Por favor, introduzca un Idioma que sea menor de 50 caracteres.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta.")
        End If

        ' Validación nombre

        For i = 1 To codigo.Length
            For j = 1 To charsPosiblesNombre.Length
                If (GetChar(codigo, i) <> GetChar(charsPosiblesNombre, j)) Then

                Else
                    ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                    ' entonces los datos se validan.
                    coincidencias = coincidencias + 1
                End If
            Next j
        Next i



        ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
        If coincidencias = codigo.Length Then
            valido = True
        Else
            MsgBox(" El Idioma no puede contener caracteres numéricos o símbolos no permitidos.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
        End If
        Return valido
    End Function

    'Validacion Plaza de Edicion 
    Public Function validarPlazaEdicion(codigo As String, tipo As Integer) As Boolean

        ' Si tipo es 1, se realizara la validación de un nombre.
        ' Si tipo es 2, se realizara la validación de un apellido.

        ' Para el nombre.
        Dim charsPosiblesNombre As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ- "

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 20

        ' Solo se permiten nombres de hasta 50 números.
        If codigo.Length > valorMaximo Then
            MsgBox("Por favor, introduzca un nombre que sea menor de 20 caracteres.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta.")
        End If

        ' Validación nombre
        If tipo = 1 Then
            For i = 1 To codigo.Length
                For j = 1 To charsPosiblesNombre.Length
                    If (GetChar(codigo, i) <> GetChar(charsPosiblesNombre, j)) Then

                    Else
                        ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                        ' entonces los datos se validan.
                        coincidencias = coincidencias + 1
                    End If
                Next j
            Next i
        End If


        ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
        If coincidencias = codigo.Length Then
            valido = True
        Else
            MsgBox(" La plaza de edicion no puede contener caracteres numéricos o símbolos no permitidos.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
        End If
        Return valido
    End Function

    'Validacion Traductor 
    Public Function validarTraductor(codigo As String) As Boolean

        ' Para el nombre.
        Dim charsPosiblesNombre As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ.- "

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 50

        ' Solo se permiten nombres de hasta 50 números.
        If codigo.Length > valorMaximo Then
            MsgBox("Por favor, introduzca un nombre que sea menor de 50 caracteres.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta.")
        End If

        ' Validación nombre

        For i = 1 To codigo.Length
            For j = 1 To charsPosiblesNombre.Length
                If (GetChar(codigo, i) <> GetChar(charsPosiblesNombre, j)) Then

                Else
                    ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                    ' entonces los datos se validan.
                    coincidencias = coincidencias + 1
                End If
            Next j
        Next i



        ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
        If coincidencias = codigo.Length Then
            valido = True
        Else
            MsgBox(" El Tradcutor no puede contener caracteres numéricos o símbolos no permitidos.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
        End If
        Return valido
    End Function

    'Validar Precio
    Public Function validarPrecio(codigo As String) As Boolean


        ' Se opta de nuevo por la solución de poner en un String los valores permitidos.
        Dim charsPosibles As String = "0123456789,"

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 6

        ' Solo se permiten códigos de hasta 6 números.
        'If codigo.Length > valorMaximo Then
        'MsgBox("Por favor, introduzca un número de teléfono que sea menor de 6 dígitos", MsgBoxStyle.OkOnly, "Longitud incorrecta.")
        'End If

        For i = 1 To codigo.Length
            For j = 1 To charsPosibles.Length
                If (GetChar(codigo, i) <> GetChar(charsPosibles, j)) Then

                Else
                    ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                    ' entonces los datos se validan.
                    coincidencias = coincidencias + 1
                End If
            Next j
        Next i

        ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
        If coincidencias = codigo.Length And codigo.Length <= valorMaximo Then
            valido = True
        Else
            MsgBox(" El precio, solo admite caracteres numéricos y coma ',' .También debe tener una longitud de 6 digitos.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
        End If
        Return valido
    End Function


    'Validar Nombre productos
    Public Function validarNombreProducto(codigo As String) As Boolean

        Dim charsPosiblesNombre As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890-_éúíóá¿?¡!();,.& "

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 50
        ' Solo se permiten nombres de hasta 50 números.
        If codigo.Length > valorMaximo Then
            MsgBox("Por favor, introduzca una Nombre que sea menor de 50 caracteres.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta.")
        End If

        For i = 1 To codigo.Length
            For j = 1 To charsPosiblesNombre.Length
                If (GetChar(codigo, i) <> GetChar(charsPosiblesNombre, j)) Then

                Else
                    ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                    ' entonces los datos se validan.
                    coincidencias = coincidencias + 1
                End If
            Next j
        Next i

        ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
        If coincidencias = codigo.Length Then
            valido = True
        Else
            MsgBox(" El Nombre del producto no puede contener símbolos no permitidos. Debe tener una longitud máxima de 50 caracteres", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
        End If
        Return valido
    End Function

    'Validar Categoría Y Genero
    Public Function validarCategoria(codigo As String) As Boolean

        ' Para el nombre.
        Dim charsPosiblesNombre As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ- "

        Dim valido As Boolean = False
        Dim coincidencias As Integer = 0
        Dim valorMaximo As Integer

        ' Máxima longitud del valor.
        valorMaximo = 50

        ' Solo se permiten nombres de hasta 50 números.
        If codigo.Length > valorMaximo Then
            MsgBox("Por favor, introduzca una Categoria que sea menor de 50 caracteres.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Longitud incorrecta.")
        End If

        ' Validación nombre

        For i = 1 To codigo.Length
            For j = 1 To charsPosiblesNombre.Length
                If (GetChar(codigo, i) <> GetChar(charsPosiblesNombre, j)) Then

                Else
                    ' Si se encuentran el mismo número de coincidencias que caracteres contrastados hay
                    ' entonces los datos se validan.
                    coincidencias = coincidencias + 1
                End If
            Next j
        Next i


        ' Devolvemos si los datos son válidos si se han encontrado tantas coincidencias como caracteres tenga la cadena.
        If coincidencias = codigo.Length Then
            valido = True
        Else
            MsgBox(" La Categoria no puede contener caracteres numéricos o símbolos no permitidos.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
        End If
        Return valido
    End Function

End Class
