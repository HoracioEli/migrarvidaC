Module ModuloGeneral

    Public POLIZA As String
    Public TIPO, VIGENCIA, PRODUCTOR, ORGANIZADOR, SOCIO, NROSOCIO, ANUALIDAD, COBERTURA, TASAIngresar As String
    Public TASA As Single

    Public Periodo As Byte

    Public DOCUMENTO, CUIL, ADHERENTE, APELLIDO, NOMBRE, SEXO, FNACIMIENTO, SumaAsegurada, SUELDO, FECHAINGRESO As String
    Public NombreABuscar As String
    Public Id As Integer
    Public Abandonar As Byte
    Public Correcto As Byte

    Public ExPoliza, ExCUIL, ExApellido, ExNombre, ExSexo, ExFNacimiento, ExSumaAsegurada, ExSueldo, ExFechaIngreso, ExBeneficiario As String
    Public PolizaDynamo As String

    Public Relacion, ActualApellido, ActualNombre, ActualCUIL, ActualSumaAsegurada, ActualSueldo, ActualFechaIngreso As String
    Public ActualSexo, ActualFechaNacimiento, Estado As String
    Public Antiguedad As Single

    Sub EliminarDatosPolizas()
        SQL = "DELETE * FROM POLIZAS"
        Call EliminarEnAcces()

    End Sub
    Sub IngresarDatosPoliza()

        SQL = "INSERT INTO POLIZAS (Poliza,Tipo,Vigencia,Productor,Organizador,Socio,NroSocio,Anualidad,Cobertura,Tasa)"
        SQL = SQL & " Values ("
        SQL = SQL & "'" & POLIZA & "',"
        SQL = SQL & "'" & TIPO & "',"
        SQL = SQL & "'" & VIGENCIA & "',"
        SQL = SQL & "'" & PRODUCTOR & "',"
        SQL = SQL & "'" & ORGANIZADOR & "',"
        SQL = SQL & "'" & SOCIO & "',"
        SQL = SQL & "'" & NROSOCIO & "',"
        SQL = SQL & "'" & ANUALIDAD & "',"
        SQL = SQL & "'" & COBERTURA & "',"
        SQL = SQL & "'" & TASAIngresar & "'"
        SQL = SQL & ")"

        Call IngresarEnAcces()

    End Sub
    Sub EliminarDatosAdherentes()
        SQL = "DELETE * FROM ADHERENTES"
        Call EliminarEnAcces()

    End Sub
    Sub IngresarDatosAdherente()

        SQL = "INSERT INTO ADHERENTES (Poliza,Documento,ADHERENTE,FNACIMIENTO,SUMAASEGURADA,APELLIDO,NOMBRE)"
        SQL = SQL & " Values ("
        SQL = SQL & "'" & POLIZA & "',"
        SQL = SQL & "'" & DOCUMENTO & "',"
        SQL = SQL & "'" & ADHERENTE & "',"
        SQL = SQL & "'" & FNACIMIENTO & "',"
        SQL = SQL & "'" & SumaAsegurada & "',"
        SQL = SQL & "'" & APELLIDO & "',"
        SQL = SQL & "'" & NOMBRE & "'"
        SQL = SQL & ")"

        Call IngresarEnAcces()

    End Sub
    Sub SepararApellido_Nombre()

        Dim Largo As Integer
        Dim Posicion As Byte


        Largo = Len(ADHERENTE)

        Posicion = InStr(ADHERENTE, ",")
        If Posicion = 0 Then
            'no hay "," entonces busca por espacio
            Posicion = InStr(ADHERENTE, " ")
        End If

        APELLIDO = Mid(ADHERENTE, 1, Posicion - 1)
        APELLIDO = Trim(APELLIDO)
        NOMBRE = Mid(ADHERENTE, Posicion + 1, Largo - Posicion)
        NOMBRE = Trim(NOMBRE)



    End Sub
    Sub AgregarSexo()

        Try
            ConsultaSQL = "Select Nombre,Id from ADHERENTES where sexo is null"

            Call Consultar2()

            If dr2.HasRows Then
                While dr2.Read()

                    NOMBRE = dr2(0).ToString
                    Id = CInt(dr2(1).ToString)

                    'BUSCAR EN LA TABLA SEXO por el nombre completo
                    SEXO = Nothing
                    NombreABuscar = NOMBRE

                    Call BuscarSexo()

                    If SEXO <> Nothing Then 'encontrò sexo para ese nombre
                        Call AgregarSexoA_Tabla_Adherentes()
                    Else
                        'DIVIDIR EL NOMBRE EN SUS PARTES Y BUSCAR POR CADA UNA DE SUS PARTES.
                        Call DividirNombre()
                        If Abandonar = 1 Then
                            Exit While
                        End If
                    End If

                    Form1.Text = "Analizando nombre: " & NOMBRE

                End While

            End If

            If Abandonar = 1 Then
                MsgBox("El proceso se ha interrumpido. Debe comenzar de nuevo desde este punto", MsgBoxStyle.Information, "OPERACION TRUNCADA")
                Abandonar = 0
            Else
                MsgBox("Edicion de documentos realizado con éxito")
            End If


            dr2.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub BuscarSexo()


        Try
            ConsultaSQL = "Select Sexo from Sexo where Nombre='" & NombreABuscar & "'"

            Call Consultar3()



            If dr3.HasRows Then
                While dr3.Read()
                    SEXO = dr3(0).ToString
                End While
            End If

            dr3.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            dr3.Close()
        End Try

    End Sub
    Sub AgregarSexoA_Tabla_Adherentes()
        SQL = "UPDATE ADHERENTES SET "
        SQL += "Sexo='" & SEXO & "'"
        SQL += " where id=" & Id

        Call IngresarEnAcces()
    End Sub
    Sub DividirNombre()
        Dim Decision As String
        Dim Posicion As Integer
        Dim SoloUnNombre As Byte
        Dim CantidadVueltas As Byte
        Dim Sexo1Vuelta As String
        Dim NombreCompleto As String


        NOMBRE = Trim(NOMBRE)
        NombreCompleto = NOMBRE

        'Ejemplo: Horacio Jose

        While Len(NOMBRE) > 0 ' la primera vuelta len = 12 , el largo de "horacio Jose"
            CantidadVueltas = CantidadVueltas + 1
            Posicion = NOMBRE.IndexOf(" ") ' busca el espacio entre nombre = 7


            If Posicion > 0 Then ' significa que hay mas de un nombre separado por espacio " "
                NombreABuscar = NOMBRE.Substring(0, Posicion) 'devuelve Horacio
                'Nombre = Nombre.Substring(Posicion + 1) ' se queda con Jose
            Else
                NombreABuscar = NOMBRE 'es solo un nombre
                SoloUnNombre = 1
            End If


            Call BuscarSexo() 'por el nombre Horacio primero por nombre, en segunda vuelta por Josè

            If SEXO = Nothing Then 'si no encuentra, pregunta a que sexo corresponde el nombre Horacio
                Decision = InputBox(NombreABuscar & Chr(13) & Chr(13) & "1 = Masculino " & Chr(13) & "2 = Femenino" & Chr(13) & "0 = Indefinido", "Informar sexo para el nombre ", "1")

                Select Case Decision
                    Case "1"
                        SEXO = "Masculino"
                    Case "2"
                        SEXO = "Femenino"
                    Case Else
                        SEXO = Nothing
                End Select

                Call AgregarSexoA_TablaSexo()
            End If

            If CantidadVueltas = 1 Then
                If SoloUnNombre = 1 Then
                    Call AgregarSexoA_Tabla_Adherentes()
                    Exit While
                End If
                Sexo1Vuelta = SEXO 'guarda el dato del sexo del primer nombre
                SEXO = Nothing ' vuelve valor de sexo a cero para el siguiente nombre
            Else
                If Sexo1Vuelta = SEXO Then
                    'si los dos nombre son del mismo sexo se presume que el nombre compuesto es del mismo sexo
                    ' por tanto se guarda el nombre completo en tabla sexo
                    NombreABuscar = NombreCompleto
                    Call AgregarSexoA_TablaSexo()
                    Call AgregarSexoA_Tabla_Adherentes()
                    SEXO = Nothing
                    Sexo1Vuelta = Nothing
                    Exit While
                Else
                    'es para el caso de JOSE MARIA - el primero sera masculino, el segundo femenino, pero en conjunto es masculino
                    'por tanto pregunta al operador y almacena el nombre compuesto
                    Decision = InputBox(NombreCompleto & Chr(13) & Chr(13) & "1 = Masculino " & Chr(13) & "2 = Femenino" & Chr(13) & "0 = Indefinido", "Informar sexo para el nombre ", "1")

                    Select Case Decision
                        Case "1"
                            SEXO = "Masculino"
                        Case "2"
                            SEXO = "Femenino"
                        Case Else
                            SEXO = Nothing
                    End Select

                    If SEXO <> Nothing Then
                        NombreABuscar = NombreCompleto
                        Call AgregarSexoA_TablaSexo()
                        Call AgregarSexoA_Tabla_Adherentes()
                        Exit While
                    Else
                        Dim Respuesta As Byte
                        Dim Mensaje As String = "Se asume que una parte del nombre corresponde al apellido"
                        Mensaje += " por tanto se deberán ingresar los datos en forma manual" & Chr(13) & "."
                        Mensaje += "Si presiona sobre 'SI' se pedira que ingrese los datos manualmente"
                        Mensaje += "Caso contrario se cancela el trabajo y hay que empezar desde este punto."
                        Respuesta = MsgBox(Mensaje, MsgBoxStyle.YesNo, "ES NECESARIO LA INTERVENCIÓN DEL OPERADOR")
                        If Respuesta = vbYes Then
                            APELLIDO = InputBox("Ingresar la parte del nombre que se integral al apellido", "Se corrije APELLIDO NOMBRE", APELLIDO & " " & NombreCompleto)
                            NOMBRE = InputBox("Ingrese el NOMBRE correcto", "Nombre correcto", APELLIDO & " " & NombreCompleto)
                            Decision = InputBox("Ingrese el SEXO considerando: " & Chr(13) & "1 = Masculino " & Chr(13) & "2 = Femenino", APELLIDO & " " & NombreCompleto, "1")
                            Select Case Decision
                                Case "1"
                                    SEXO = "Masculino"
                                Case "2"
                                    SEXO = "Femenino"
                            End Select
                            'Call Actualizar_Apellido_Nombre_Sexo_TablaDatosActualizados()
                            Exit While
                        Else
                            Abandonar = 1
                            Exit While

                        End If


                    End If

                End If
            End If




            If SoloUnNombre = 1 And CantidadVueltas = 1 Then
                Exit While
                If SEXO = Nothing Then
                    MsgBox("No se seleccionó sexo para " & NOMBRE & Chr(13) & " hay que volver a ejecutar el paso 5 al terminar este proceso", MsgBoxStyle.Critical, "ERROR DEL OPERADOR")
                Else
                    'GUARDAR EL SEXO EN DATOS ACTUALIZADOS
                End If
            Else
                NOMBRE = NOMBRE.Substring(Posicion)
                NOMBRE = Trim(NOMBRE)

            End If

        End While


    End Sub
    Sub AgregarSexoA_TablaSexo()
        If SEXO = Nothing Then
            Exit Sub
        End If

        SQL = "INSERT INTO Sexo ( Nombre, Sexo)"
        SQL = SQL & " Values ("
        SQL = SQL & "'" & NombreABuscar & "',"
        SQL = SQL & "'" & SEXO & "'"
        SQL = SQL & ")"

        Call IngresarEnAcces()
    End Sub
    Sub Editar_CUIL()
        Try
            ConsultaSQL = "Select Documento, Id, Sexo from ADHERENTES"

            Call Consultar2()

            If dr2.HasRows Then
                While dr2.Read()
                    Correcto = 0
                    DOCUMENTO = dr2(0).ToString
                    Id = CInt(dr2(1).ToString)
                    SEXO = dr2(2).ToString


                    Call HallarCuil()

                End While

            End If


            If Correcto = 1 Then
                MsgBox("CUIL EDITADO con éxito", MsgBoxStyle.Information, "OPERACION EXITOSA")
            End If
            dr2.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub HallarCuil()
        Try
            Dim X, Y As String
            Dim Z As String
            Dim Sumatoria As Integer
            Dim N1, N2, N3, N4, N5, N6, N7, N8 As String
            Dim Redondeo As Integer = 0
            Dim Resto As Integer


            If Len(DOCUMENTO) = 7 Then
                DOCUMENTO = "0" & DOCUMENTO
            End If

            X = 2
            Select Case SEXO
                Case "Femenino"
                    Y = 7
                Case "Masculino"
                    Y = 0
            End Select

            N1 = Mid(DOCUMENTO, 1, 1)
            N2 = Mid(DOCUMENTO, 2, 1)
            N3 = Mid(DOCUMENTO, 3, 1)
            N4 = Mid(DOCUMENTO, 4, 1)
            N5 = Mid(DOCUMENTO, 5, 1)
            N6 = Mid(DOCUMENTO, 6, 1)
            N7 = Mid(DOCUMENTO, 7, 1)
            N8 = Mid(DOCUMENTO, 8, 1)

            Sumatoria = 0
            Sumatoria = CInt(X) * 5
            Sumatoria = Sumatoria + CInt(Y) * 4
            Sumatoria = Sumatoria + CInt(N1) * 3
            Sumatoria = Sumatoria + CInt(N2) * 2
            Sumatoria = Sumatoria + CInt(N3) * 7
            Sumatoria = Sumatoria + CInt(N4) * 6
            Sumatoria = Sumatoria + CInt(N5) * 5
            Sumatoria = Sumatoria + CInt(N6) * 4
            Sumatoria = Sumatoria + CInt(N7) * 3
            Sumatoria = Sumatoria + CInt(N8) * 2

            Redondeo = Int(Sumatoria / 11)

            Resto = Sumatoria - (Redondeo * 11)

            Select Case Resto
                Case 0
                    Z = 0
                Case 1
                    Y = 3
                    If SEXO = "Femenino" Then Z = 4
                    If SEXO = "Masculino" Then Z = 9
                Case Else
                    Z = CStr(Math.Abs(Resto - 11))
            End Select

            CUIL = X & Y & "-" & DOCUMENTO & "-" & Z

            Form1.Text = DOCUMENTO & " " & CUIL

            Call AgregarCUIL_Tabla_Adherentes()

            Correcto = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub AgregarCUIL_Tabla_Adherentes()
        SQL = "UPDATE ADHERENTES SET "
        SQL += "CUIL='" & CUIL & "'"
        SQL += " WHERE id=" & Id

        Call IngresarEnAcces()
    End Sub

    Sub AgregarNroPolizaDynamo()
        SQL = "UPDATE POLIZAS SET "
        SQL += "NuevaPoliza='" & PolizaDynamo & "'"
        SQL += " WHERE Poliza='" & Form1.lbPoliza.Text & "'"

        Call IngresarEnAcces()
    End Sub

    Sub EliminarActual()
        SQL = "DELETE * FROM Vigentes"
        Call EliminarEnAcces()

    End Sub


    Sub IngresarActual()

        SQL = "INSERT INTO Vigentes ( Relacion,Apellido,Nombre,CUIL,SumaAsegurada,FechaIngreso,Sueldo,Sexo,FechaNacimiento,Estado)"
        SQL &= " Values ("
        SQL = SQL & "'" & Relacion & "',"
        SQL = SQL & "'" & ActualApellido & "',"
        SQL = SQL & "'" & ActualNombre & "',"
        SQL = SQL & "'" & ActualCUIL & "',"
        SQL = SQL & "'" & ActualSumaAsegurada & "',"
        SQL = SQL & "'" & ActualFechaIngreso & "',"
        SQL = SQL & "'" & ActualSueldo & "',"
        SQL = SQL & "'" & ActualSexo & "',"
        SQL = SQL & "'" & ActualFechaNacimiento & "',"
        SQL = SQL & "'" & Estado & "'"
        SQL &= ")"

        Call IngresarEnAcces()

    End Sub

    Sub Editar_CUIL_Vigentes()
        Try
            ConsultaSQL = "Select CUIL, Id, Sexo from Vigentes"

            Call Consultar2()

            If dr2.HasRows Then
                While dr2.Read()
                    Correcto = 0
                    CUIL = dr2(0).ToString
                    Id = CInt(dr2(1).ToString)
                    SEXO = dr2(2).ToString

                    'es para sacarle la terminacion "Masculino (M)"
                    ' (M) Masculino o (F) a Femenino


                    Select Case Len(CUIL)
                        Case > 8

                        Case = 8
                            DOCUMENTO = CUIL
                            Call HallarCuil_Vigentes()
                        Case < 8
                            DOCUMENTO = "0" & CUIL
                            Call HallarCuil_Vigentes()
                    End Select

                End While

            End If


            dr2.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Sub HallarCuil_Vigentes()
        Try
            Dim X, Y As String
            Dim Z As String
            Dim Sumatoria As Integer
            Dim N1, N2, N3, N4, N5, N6, N7, N8 As String
            Dim Redondeo As Integer = 0
            Dim Resto As Integer


            If Len(DOCUMENTO) = 7 Then
                DOCUMENTO = "0" & DOCUMENTO
            End If

            X = 2
            Select Case SEXO
                Case "Femenino"
                    Y = 7
                Case "Masculino"
                    Y = 0
            End Select

            N1 = Mid(DOCUMENTO, 1, 1)
            N2 = Mid(DOCUMENTO, 2, 1)
            N3 = Mid(DOCUMENTO, 3, 1)
            N4 = Mid(DOCUMENTO, 4, 1)
            N5 = Mid(DOCUMENTO, 5, 1)
            N6 = Mid(DOCUMENTO, 6, 1)
            N7 = Mid(DOCUMENTO, 7, 1)
            N8 = Mid(DOCUMENTO, 8, 1)

            Sumatoria = 0
            Sumatoria = CInt(X) * 5
            Sumatoria += CInt(Y) * 4
            Sumatoria += CInt(N1) * 3
            Sumatoria += CInt(N2) * 2
            Sumatoria += CInt(N3) * 7
            Sumatoria += CInt(N4) * 6
            Sumatoria += CInt(N5) * 5
            Sumatoria += CInt(N6) * 4
            Sumatoria += CInt(N7) * 3
            Sumatoria += CInt(N8) * 2

            Redondeo = Int(Sumatoria / 11)

            Resto = Sumatoria - (Redondeo * 11)

            Select Case Resto
                Case 0
                    Z = 0
                Case 1
                    Y = 3
                    If SEXO = "Femenino" Then Z = 4
                    If SEXO = "Masculino" Then Z = 9
                Case Else
                    Z = CStr(Math.Abs(Resto - 11))
            End Select


            CUIL = X & Y & "-" & DOCUMENTO & "-" & Z

            Call AgregarCUIL_Tabla_Vigentes()

            Correcto = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub AgregarCUIL_Tabla_Vigentes()
        SQL = "UPDATE Vigentes SET "
        SQL += "CUIL='" & CUIL & "'"
        SQL += " WHERE id=" & Id

        Call IngresarEnAcces()
    End Sub


    Sub CalcularSueldo()
        Dim FechaIngreso As Date




        Try
            ConsultaSQL = "Select FechaIngreso, Id, SumaAsegurada from Vigentes"

            Call Consultar2()

            If dr2.HasRows Then
                While dr2.Read()

                    FechaIngreso = CDate(dr2(0).ToString)
                    Id = CInt(dr2(1).ToString)
                    SumaAsegurada = dr2(2).ToString



                    Antiguedad = DateDiff(DateInterval.Month, FechaIngreso, Today())

                    Antiguedad /= 12
                    Dim Entero As Integer
                    Entero = Antiguedad
                    Dim Resto As Single
                    Resto = Antiguedad - Entero
                    If Resto > 0.3 Then
                        Entero += 1
                    End If

                    Antiguedad = Entero
                    SUELDO = (CSng(SumaAsegurada) * 2) / Antiguedad

                    SUELDO = Format(CSng(SUELDO), "#.##")




                    SQL = "UPDATE Vigentes SET "
                    SQL += "Antiguedad='" & Antiguedad & "',"
                    SQL += "Sueldo='" & SUELDO & "'"
                    SQL += " where id=" & Id

                    Call IngresarEnAcces()

                End While

            End If



            dr2.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Sub BuscarPolizaXNumero()

        Try


            ConsultaSQL = "SELECT Poliza, Tipo, NuevaPoliza, Vigencia, Productor, Organizador, Socio, NroSocio, Anualidad, Cobertura, Tasa"
            ConsultaSQL += " From POLIZAS"
            ConsultaSQL += " Where Poliza = '" & POLIZA & "'"
            'ConsultaSQL += " And NuevaPoliza Is Null"
            'ConsultaSQL += " Order By POLIZAS.Anualidad"

            Call Consultar2()
            If dr2.HasRows Then
                dr2.Read()
                POLIZA = dr2(0).ToString
                Form1.lbPoliza.Text = POLIZA
                Form1.lbTipoContrato.Text = dr2(1).ToString
                Form1.CboTipoContrato.Text = dr2(1).ToString
                Form1.lbNuevaPoliza.Text = dr2(2).ToString
                Form1.LbVigencia.Text = dr2(3).ToString
                Form1.LbProductor.Text = dr2(4).ToString
                Form1.LbOrganizador.Text = dr2(5).ToString
                Form1.LbSocio.Text = dr2(6).ToString
                Form1.LbNroSocio.Text = dr2(7).ToString
                Form1.LbAnualidad.Text = dr2(8).ToString
                Form1.lbCobertura.Text = dr2(9).ToString
                Form1.LbTasa.Text = dr2(10).ToString
                Form1.txPoliza.Text = Mid(Form1.lbPoliza.Text, 6, 7)
            End If
            dr2.Close()

            Periodo = 0
            Select Case Form1.LbVigencia.Text
                Case "Mensual"
                    Periodo = 1
                Case "Bimestral"
                    Periodo = 2
                Case "Trimestral"
                    Periodo = 3
                Case "Semestral"
                    Periodo = 6
                Case "Anual"
                    Periodo = 12
            End Select
        Catch ex As Exception
            dr2.Close()
            MsgBox(ex.Message)
        End Try



    End Sub


End Module
