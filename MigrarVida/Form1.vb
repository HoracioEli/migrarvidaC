Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports System.IO
Public Class Form1
    Public Fila As Integer
    Public Columna As Integer
    Public Dato As String
    Public SumaAseguradaTotal As Integer
    Public SumaAseguradaFija As Integer



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Conectarse()
    End Sub
    Private Sub btnPaso1_Click(sender As Object, e As EventArgs) Handles btnPaso1.Click
        Dim MyExcel As Workbook
        Dim ApExcel As Excel.Application
        'Dim HojaExcel As Worksheet
        Dim RutaPlantilla As String = "C:\Publico\Migrar\MIGRACION_COLECTIVO_CC.xlsx "
        Dim Contador As Integer
        Dim PolizaPrevia As String = Nothing

        'PRIMERO VACIA LA TABLA POLIZAS
        Call EliminarDatosPolizas()

        ApExcel = New Excel.Application()
        ApExcel.Visible = False
        MyExcel = ApExcel.Workbooks.Open(RutaPlantilla,, False)

        Try
            Fila = 2
            Columna = 2


            POLIZA = MyExcel.Sheets(1).Cells(Fila, Columna).Value
            POLIZA = Trim(POLIZA)
            'lo convierte en mayúscula
            POLIZA = POLIZA.ToUpper

            While POLIZA <> Nothing
                Columna = 2
                POLIZA = MyExcel.Sheets(1).Cells(Fila, Columna).Value
                POLIZA = Trim(POLIZA)
                'lo convierte en mayúscula
                POLIZA = POLIZA.ToUpper

                If POLIZA <> PolizaPrevia Then
                    Columna = 6
                    TIPO = MyExcel.Sheets(1).Cells(Fila, Columna).Value

                    Columna = 12
                    VIGENCIA = MyExcel.Sheets(1).Cells(Fila, Columna).Value

                    Columna = 14
                    PRODUCTOR = MyExcel.Sheets(1).Cells(Fila, Columna).Value

                    Columna = 15
                    ORGANIZADOR = MyExcel.Sheets(1).Cells(Fila, Columna).Value

                    Columna = 17
                    SOCIO = MyExcel.Sheets(1).Cells(Fila, Columna).Value

                    Columna = 18
                    NROSOCIO = MyExcel.Sheets(1).Cells(Fila, Columna).Value

                    Columna = 38
                    ANUALIDAD = MyExcel.Sheets(1).Cells(Fila, Columna).Value


                    Columna = 30
                    COBERTURA = MyExcel.Sheets(1).Cells(Fila, Columna).Value

                    Columna = 31
                    COBERTURA += " " & MyExcel.Sheets(1).Cells(Fila, Columna).Value

                    Columna = 32
                    COBERTURA += " " & MyExcel.Sheets(1).Cells(Fila, Columna).Value

                    Columna = 33
                    COBERTURA += " " & MyExcel.Sheets(1).Cells(Fila, Columna).Value



                    Columna = 34
                    TASA = CSng(MyExcel.Sheets(1).Cells(Fila, Columna).Value)

                    Columna = 35
                    TASA = TASA + CSng(MyExcel.Sheets(1).Cells(Fila, Columna).Value)

                    Columna = 36
                    TASA = TASA + CSng(MyExcel.Sheets(1).Cells(Fila, Columna).Value)

                    Columna = 37
                    TASA = TASA + CSng(MyExcel.Sheets(1).Cells(Fila, Columna).Value)
                    TASAIngresar = CStr(TASA)

                    Call IngresarDatosPoliza()
                    Contador += 1
                    PolizaPrevia = POLIZA

                End If

                Fila = Fila + 1
                Me.Text = "Analizando la fila =" & Fila & "-" & POLIZA



            End While

            MyExcel.Close()
            ApExcel.Quit()

            MsgBox("Se han importado en forma exitosa " & Contador & " registros", MsgBoxStyle.Information, "IMPORTACION EXITOSA")








        Catch ex As Exception
            MyExcel.Close()
            ApExcel.Quit()
            MsgBox(ex.Message)



        End Try
    End Sub
    Private Sub btnPaso2_Click(sender As Object, e As EventArgs) Handles btnPaso2.Click
        Dim MyExcel As Workbook
        Dim ApExcel As Excel.Application
        'Dim HojaExcel As Worksheet
        Dim RutaPlantilla As String = "C:\Publico\Migrar\MIGRACION_COLECTIVO_CC.xlsx "
        Dim Contador As Integer
        Dim PolizaPrevia As String = Nothing

        'PRIMERO VACIA LA TABLA POLIZAS
        Call EliminarDatosAdherentes()

        ApExcel = New Excel.Application()
        ApExcel.Visible = False
        MyExcel = ApExcel.Workbooks.Open(RutaPlantilla,, False)

        Try
            Fila = 2
            Columna = 2


            POLIZA = MyExcel.Sheets(1).Cells(Fila, Columna).Value
            POLIZA = Trim(POLIZA)
            'lo convierte en mayúscula
            POLIZA = POLIZA.ToUpper

            While POLIZA <> Nothing
                Columna = 2
                POLIZA = MyExcel.Sheets(1).Cells(Fila, Columna).Value
                POLIZA = Trim(POLIZA)
                'lo convierte en mayúscula
                POLIZA = POLIZA.ToUpper


                Columna = 23
                DOCUMENTO = MyExcel.Sheets(1).Cells(Fila, Columna).Value

                Columna = 22
                ADHERENTE = MyExcel.Sheets(1).Cells(Fila, Columna).Value
                ADHERENTE = Trim(ADHERENTE)
                'lo convierte en mayúscula
                ADHERENTE = ADHERENTE.ToUpper
                APELLIDO = Nothing
                NOMBRE = Nothing
                If ADHERENTE <> Nothing Then
                    Call SepararApellido_Nombre()
                End If


                Columna = 24
                FNACIMIENTO = MyExcel.Sheets(1).Cells(Fila, Columna).Value

                Columna = 28
                SumaAsegurada = MyExcel.Sheets(1).Cells(Fila, Columna).Value




                Call IngresarDatosAdherente()
                Contador += 1




                Fila = Fila + 1
                Me.Text = "Analizando la fila =" & Fila & "-" & ADHERENTE



            End While

            MyExcel.Close()
            ApExcel.Quit()

            MsgBox("Se han importado en forma exitosa " & Contador & " registros", MsgBoxStyle.Information, "IMPORTACION EXITOSA")

        Catch ex As Exception
            MyExcel.Close()
            ApExcel.Quit()
            MsgBox(ex.Message)



        End Try
    End Sub
    Private Sub btnPaso3_Click(sender As Object, e As EventArgs) Handles btnPaso3.Click
        Call AgregarSexo()
    End Sub
    Private Sub btnPaso4_Click(sender As Object, e As EventArgs) Handles btnPaso4.Click
        Call Editar_CUIL()
    End Sub
    Sub ExportarAExcel()

        Dim MyExcel As Workbook
        Dim ApExcel As Excel.Application
        Dim Archivo As String
        Dim CantidadAdherentes As Integer = 0
        Dim Prefijo As String
        POLIZA = lbPoliza.Text
        Try
            ApExcel = New Excel.Application()
            ApExcel.Visible = False
            Select Case CboTipoContrato.Text
                Case "Peón Rural"
                    MyExcel = ApExcel.Workbooks.Open("C:\Publico\Migrar" & "\PANTILLA RURAL.xlsx")
                    Prefijo = "RURAL"
                Case "Convenio Mercantil"
                    MyExcel = ApExcel.Workbooks.Open("C:\Publico\Migrar" & "\PLANTILLA MERCANTIL.xlsx")
                    Prefijo = "MERCANTIL"
                Case "Obligaciones Laborales"
                    MyExcel = ApExcel.Workbooks.Open("C:\Publico\Migrar" & "\PLANTILLA_LCT.xlsx")
                    Prefijo = "LCT"
                Case "Optativos"
                    MyExcel = ApExcel.Workbooks.Open("C:\Publico\Migrar" & "\PLANTILLA OPTATIVO - CAPITAL UNIFORME.xlsx")
                    Prefijo = "OPTATIVO"
            End Select


            ConsultaSQL = "Select Apellido,Nombre,Sueldo,FechaIngreso,FechaNacimiento,CUIL,Sexo,SumaAsegurada FROM vigentes"
            Fila = 2
            SumaAseguradaTotal = 0

            Call Consultar2()
            If dr2.HasRows Then
                While dr2.Read()
                    ExApellido = dr2(0).ToString
                    ExNombre = dr2(1).ToString
                    ExSueldo = dr2(2).ToString
                    ExFechaIngreso = dr2(3).ToString
                    ExFNacimiento = dr2(4).ToString
                    ExCUIL = dr2(5).ToString
                    ExSexo = dr2(6).ToString
                    ExSumaAsegurada = dr2(7).ToString


                    SumaAseguradaTotal += CInt(ExSumaAsegurada)
                    CantidadAdherentes += 1

                    ExBeneficiario = "Tomador"

                    MyExcel.Sheets(1).Cells(Fila, 1).Value = "Agregar"
                    MyExcel.Sheets(1).Cells(Fila, 2).Value = "C.U.I.L."
                    MyExcel.Sheets(1).Cells(Fila, 3).Value = ExCUIL
                    MyExcel.Sheets(1).Cells(Fila, 4).Value = ExApellido
                    MyExcel.Sheets(1).Cells(Fila, 5).Value = ExNombre
                    MyExcel.Sheets(1).Cells(Fila, 6).Value = ExSexo
                    MyExcel.Sheets(1).Cells(Fila, 7).Value = ExFNacimiento
                    If Prefijo = "OPTATIVO" Then
                        MyExcel.Sheets(1).Cells(Fila, 8).Value = ExSumaAsegurada
                        MyExcel.Sheets(1).Cells(Fila, 9).Value = ExBeneficiario
                    Else
                        MyExcel.Sheets(1).Cells(Fila, 8).Value = ExBeneficiario
                    End If


                    If CboTipoContrato.Text = "Obligaciones Laborales" Then
                        MyExcel.Sheets(1).Cells(Fila, 8).Value = ExSueldo
                        MyExcel.Sheets(1).Cells(Fila, 9).Value = ExFechaIngreso
                        MyExcel.Sheets(1).Cells(Fila, 10).Value = ExBeneficiario
                    End If
                    Fila = Fila + 1
                    Me.Text = "Procesando registro: " & CantidadAdherentes
                End While
            End If

            Archivo = RutaLocal & Prefijo & " " & lbPoliza.Text & ".xlsx"

            If File.Exists(Archivo) Then
                My.Computer.FileSystem.DeleteFile(Archivo)
            End If

            MyExcel.SaveAs(Archivo)
            ApExcel.Quit()

            MsgBox("Proceso terminado exitosamente ", MsgBoxStyle.Information, "Cantidad de adherentes " & CantidadAdherentes)

            If SumaAseguradaFija > 0 Then
                lbSumaAsegurada.Text = SumaAseguradaFija * CantidadAdherentes
            Else
                lbSumaAsegurada.Text = SumaAseguradaTotal
            End If

            Dim PrimaPeriodo As Single = 0

            PrimaPeriodo = CSng(lbSumaAsegurada.Text) / 1000
            PrimaPeriodo = PrimaPeriodo * Periodo
            PrimaPeriodo = PrimaPeriodo * CSng(LbTasa.Text)
            LbPrimaPeriodo.Text = Format(PrimaPeriodo, "#.00")


            dr2.Close()
        Catch ex As Exception
            dr2.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnExportarAExcel_Click(sender As Object, e As EventArgs) Handles btnExportarAExcel.Click
        Call ExportarAExcel()
    End Sub


    Sub BuscarPolizaParaProcesar()

        Try


            ConsultaSQL = "SELECT Poliza, Tipo, NuevaPoliza, Vigencia, Productor, Organizador, Socio, NroSocio, Anualidad, Cobertura, Tasa"
            ConsultaSQL += " From POLIZAS"
            ConsultaSQL += " Where Tipo = '" & CboTipoContrato.Text & "'"
            ConsultaSQL += " And NuevaPoliza like '%" & txConcepto.Text & "%'"
            ConsultaSQL += " Order By POLIZAS.Anualidad"

            Call Consultar2()
            If dr2.HasRows Then
                dr2.Read()
                POLIZA = dr2(0).ToString
                lbPoliza.Text = POLIZA
                lbTipoContrato.Text = dr2(1).ToString
                lbNuevaPoliza.Text = dr2(2).ToString
                LbVigencia.Text = dr2(3).ToString
                LbProductor.Text = dr2(4).ToString
                LbOrganizador.Text = dr2(5).ToString
                LbSocio.Text = dr2(6).ToString
                LbNroSocio.Text = dr2(7).ToString
                LbAnualidad.Text = dr2(8).ToString
                lbCobertura.Text = dr2(9).ToString
                LbTasa.Text = dr2(10).ToString
                txPoliza.Text = Mid(lbPoliza.Text, 6, 7)
            End If
            dr2.Close()

            Periodo = 0
            Select Case LbVigencia.Text
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


    Private Sub btnBuscarPoliza_Click(sender As Object, e As EventArgs) Handles btnBuscarPoliza.Click
        If CboTipoContrato.Text = Nothing Then
            MsgBox("Primero debe seleccionar un tipo de contrato", MsgBoxStyle.Critical, "FALTO EL TIPO DE CONTRATO")
            Exit Sub
        End If
        Call LimpiarControles()
        Call BuscarPolizaParaProcesar()

    End Sub

    Private Sub CboTipoContrato_Leave(sender As Object, e As EventArgs) Handles CboTipoContrato.Leave
        Select Case CboTipoContrato.Text
            Case "Peón Rural"
                SumaAseguradaFija = 68750
            Case "Convenio Mercantil"
                SumaAseguradaFija = 482715
            Case Else
                SumaAseguradaFija = 0
        End Select
    End Sub

    Private Sub btnPolizaDynamo_Click(sender As Object, e As EventArgs) Handles btnPolizaDynamo.Click


        PolizaDynamo = InputBox("Ingresar Número de Policy Center", "Agregar Nº de Póliza")
        If PolizaDynamo = Nothing Then
            MsgBox("Operación Abortada", MsgBoxStyle.Information, "No se ingresó el número de póliza")
        End If

        Call AgregarNroPolizaDynamo()
        Call LimpiarControles()
        Call BuscarPolizaParaProcesar()



    End Sub

    Sub LimpiarControles()
        lbPoliza.Text = Nothing
        lbTipoContrato.Text = Nothing
        lbNuevaPoliza.Text = Nothing
        LbVigencia.Text = Nothing
        LbProductor.Text = Nothing
        LbOrganizador.Text = Nothing
        LbSocio.Text = Nothing
        LbNroSocio.Text = Nothing
        LbAnualidad.Text = Nothing
        lbCobertura.Text = Nothing
        LbTasa.Text = Nothing
        lbSumaAsegurada.Text = Nothing
        LbPrimaPeriodo.Text = Nothing
        txPoliza.Text = Nothing
        Me.Text = "Migración Vida Colectivo"

    End Sub

    Private Sub btnBuscarArchivoExporadoNSIIS_Click(sender As Object, e As EventArgs) Handles btnBuscarArchivoExporadoNSIIS.Click
        OpenFileDialog1.ShowDialog()
        LbRutaPlantillaExcel.Text = OpenFileDialog1.FileName

        If LbRutaPlantillaExcel.Text = Nothing Then
            Exit Sub
        Else
            Call VolcarEnTablaVigentes()
            Call Editar_CUIL_Vigentes()
            If CboTipoContrato.Text = "Obligaciones Laborales" Then
                Call CalcularSueldo()
            End If


        End If
    End Sub

    Sub VolcarEnTablaVigentes()
        Dim MyExcel As Workbook
        Dim ApExcel As Excel.Application
        Dim RutaPlantilla As String = LbRutaPlantillaExcel.Text


        Dim Contador As Integer

        Try


            'PRIMERO VACIA LA TABLA DATOS ACTUALIZADOS
            Call EliminarActual()

            ApExcel = New Excel.Application()
            ApExcel.Visible = False
            MyExcel = ApExcel.Workbooks.Open(RutaPlantilla,, False)




            Fila = 2
            Columna = 1


            Relacion = MyExcel.Sheets(1).Cells(Fila, Columna).Value


            While Relacion <> ""
                Contador = Contador + 1
                Columna = 2

                Columna = 3
                ActualApellido = MyExcel.Sheets(1).Cells(Fila, Columna).Value
                ActualApellido = Trim(ActualApellido)


                Columna = 4
                ActualNombre = MyExcel.Sheets(1).Cells(Fila, Columna).Value
                ActualNombre = Trim(ActualNombre)

                Columna = 6
                ActualCUIL = MyExcel.Sheets(1).Cells(Fila, Columna).Value

                Columna = 7
                ActualSumaAsegurada = MyExcel.Sheets(1).Cells(Fila, Columna).Value

                Columna = 8
                ActualFechaIngreso = MyExcel.Sheets(1).Cells(Fila, Columna).Value

                Columna = 9
                ActualSueldo = MyExcel.Sheets(1).Cells(Fila, Columna).Value

                Columna = 11
                ActualSexo = MyExcel.Sheets(1).Cells(Fila, Columna).Value

                'es para sacarle la terminacion "Masculino (M)"
                ' (M) Masculino o (F) a Femenino
                Dim Largo As Byte = Len(ActualSexo)

                ActualSexo = ActualSexo.Substring(0, Largo - 4)

                Columna = 12
                ActualFechaNacimiento = MyExcel.Sheets(1).Cells(Fila, Columna).Value

                Columna = 13
                Estado = MyExcel.Sheets(1).Cells(Fila, Columna).Value


                Select Case Relacion
                    Case "Adherente (08)"
                        If Estado = "Vigente" Then
                            Call IngresarActual()
                        End If
                End Select



                Fila = Fila + 1
                Columna = 1
                Relacion = MyExcel.Sheets(1).Cells(Fila, Columna).Value
                Me.Text = "Procesando el registro " & Fila - 2
            End While

            MyExcel.Close()
            ApExcel.Quit()

            MsgBox("Se han importado en forma exitosa " & Contador & " registros", MsgBoxStyle.Information, "IMPORTACION EXITOSA")


        Catch ex As Exception
            MyExcel.Close()
            ApExcel.Quit()
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CalcularDescuento()
        Dim PremioNSIIS As Integer
        Dim PremioPC As Integer
        Dim Diferencia As Single
        Dim Multiplicar As Byte



        If txPremioNSIIS.Text = Nothing Or txPremioPC.Text = Nothing Then
            txDctoRecargo.Text = Nothing
            Exit Sub
        End If


        Periodo = 0
        Select Case LbVigencia.Text
            Case "Mensual"
                Multiplicar = 12
            Case "Bimestral"
                Multiplicar = 6
            Case "Trimestral"
                Multiplicar = 4
            Case "Semestral"
                Multiplicar = 2
            Case "Anual"
                Multiplicar = 1
        End Select

        PremioNSIIS = CInt(txPremioNSIIS.Text) * Multiplicar
        PremioPC = CInt(txPremioPC.Text)

        Diferencia = -1 - (1 * ((PremioNSIIS / PremioPC) * -1))

        txDctoRecargo.Text = Diferencia


    End Sub

    Private Sub txPremioNSIIS_Leave(sender As Object, e As EventArgs) Handles txPremioNSIIS.Leave
        Call CalcularDescuento()
    End Sub

    Private Sub txPremioPC_Leave(sender As Object, e As EventArgs) Handles txPremioPC.Leave
        Call CalcularDescuento()
    End Sub

    Private Sub btnGrilla_Click(sender As Object, e As EventArgs) Handles btnGrilla.Click
        Dim F As New FGrid
        F.ShowDialog()
    End Sub
End Class
