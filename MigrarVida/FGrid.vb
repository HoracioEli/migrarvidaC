Public Class FGrid
    Public TipoBusqueda As String
    Public NroPolizaABuscar, NroTransaccion, MES, ASEGURADO, TIPO, PRODUCTOR As String
    Private Sub FGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Adherentes_ListarGrid()
    End Sub


    Sub Adherentes_ListarGrid()
        DataGridBusquedas.DataSource = Nothing
        DataGridBusquedas.Rows.Clear()

        Select Case TipoBusqueda
            Case "POLIZAS"
                ConsultaSQL = "Select * from POLIZAS WHERE POLIZA LIKE '%" & NroPolizaABuscar & "%'"
            Case "TRANSACCION"
                ConsultaSQL = "Select * from POLIZAS WHERE NuevaPoliza LIKE '%" & NroTransaccion & "%'"
            Case "MES"
                ConsultaSQL = "Select * from POLIZAS WHERE NuevaPoliza LIKE '%" & MES & "%'"
            Case "ASEGURADO"
                ConsultaSQL = "Select * from POLIZAS WHERE Socio LIKE '%" & ASEGURADO & "%'"
            Case "TIPO"
                ConsultaSQL = "Select * from POLIZAS WHERE Tipo LIKE '%" & TIPO & "%'"
            Case "PRODUCTOR"
                ConsultaSQL = "Select * from POLIZAS WHERE Productor LIKE '%" & PRODUCTOR & "%'"
            Case Else
                ConsultaSQL = "Select * from POLIZAS"
        End Select


        Call LlenarGridBusqueda()

    End Sub

    Private Sub AseguradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AseguradoToolStripMenuItem.Click
        ASEGURADO = InputBox("Ingresar SOCIO ASEGURADO", "Busqueda por SOCIO")
        If ASEGURADO = Nothing Then
            Exit Sub
        Else
            TipoBusqueda = "ASEGURADO"
            Adherentes_ListarGrid()

        End If
    End Sub

    Private Sub ProductorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductorToolStripMenuItem.Click
        PRODUCTOR = InputBox("Ingresar CODIGO PRODUCTOR", "Busqueda por PRODUCTOR")
        If PRODUCTOR = Nothing Then
            Exit Sub
        Else
            TipoBusqueda = "PRODUCTOR"
            Adherentes_ListarGrid()

        End If
    End Sub

    Private Sub TodosLosRegistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosLosRegistrosToolStripMenuItem.Click

        TipoBusqueda = Nothing
            Adherentes_ListarGrid()


    End Sub

    Private Sub TipoContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoContratoToolStripMenuItem.Click
        TIPO = InputBox("Ingresar TIPO de contrato", "Busqueda por contrato")
        If TIPO = Nothing Then
            Exit Sub
        Else
            TipoBusqueda = "TIPO"
            Adherentes_ListarGrid()

        End If
    End Sub

    Sub LlenarGridBusqueda()
        Try

            Dim Ds As New DataSet
            Dim Dt As New System.Data.DataTable


            Dim Adaptador As New OleDb.OleDbDataAdapter(ConsultaSQL, CONN)

            Ds.Tables.Add("Tabla")
            Adaptador.Fill(Ds.Tables("Tabla"))
            Me.DataGridBusquedas.DataSource = Ds.Tables("Tabla")



            REM Me.DataGridBusquedas.Columns(0).HeaderText = "Riesgos"
            REM Me.DataGridBusquedas.Columns(0).HeaderText = "Suma Asegurada"
            'Me.DataGridBusquedas.Columns(0).Width = 1


        Catch ex As Exception

        End Try
    End Sub





    Private Sub DataGridBusquedas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridBusquedas.CellDoubleClick
        Dim Index As Integer

        Index = e.RowIndex


        Dim Selectedrow As DataGridViewRow

        Selectedrow = DataGridBusquedas.Rows(Index)
        POLIZA = (Selectedrow.Cells(0).Value.ToString)

        Form1.lbPoliza.Text = POLIZA
        Call BuscarPolizaXNumero()
        Me.Close()
    End Sub

    Private Sub PolizaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PolizaToolStripMenuItem.Click
        NroPolizaABuscar = InputBox("Ingresar todo el número o parte de la póliza NSIIS", "Busqueda por Nro de Poliza")
        If NroPolizaABuscar = Nothing Then
            Exit Sub
        Else
            TipoBusqueda = "POLIZAS"
            Adherentes_ListarGrid()

        End If
    End Sub

    Private Sub MesDeVencimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MesDeVencimientoToolStripMenuItem.Click
        MES = InputBox("Ingresar MES FIN VIGENCIA NSIIS", "Busqueda por MES de vencimiento")
        If MES = Nothing Then
            Exit Sub
        Else
            TipoBusqueda = "MES"
            Adherentes_ListarGrid()

        End If
    End Sub

    Private Sub TransaccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaccionToolStripMenuItem.Click
        NroTransaccion = InputBox("Ingresar todo el número o parte de la Poliza ó Transaccion Policy", "Busqueda por Poliza o Transaccion Dynamo")
        If NroTransaccion = Nothing Then
            Exit Sub
        Else
            TipoBusqueda = "TRANSACCION"
            Adherentes_ListarGrid()

        End If
    End Sub
End Class