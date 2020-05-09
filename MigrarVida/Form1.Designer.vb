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
        Me.btnPaso1 = New System.Windows.Forms.Button()
        Me.btnPaso2 = New System.Windows.Forms.Button()
        Me.btnPaso3 = New System.Windows.Forms.Button()
        Me.btnPaso4 = New System.Windows.Forms.Button()
        Me.btnExportarAExcel = New System.Windows.Forms.Button()
        Me.CboTipoContrato = New System.Windows.Forms.ComboBox()
        Me.LbTipo = New System.Windows.Forms.Label()
        Me.btnBuscarPoliza = New System.Windows.Forms.Button()
        Me.lbPoliza = New System.Windows.Forms.Label()
        Me.lbTipoContrato = New System.Windows.Forms.Label()
        Me.lbNuevaPoliza = New System.Windows.Forms.Label()
        Me.LbVigencia = New System.Windows.Forms.Label()
        Me.LbProductor = New System.Windows.Forms.Label()
        Me.LbOrganizador = New System.Windows.Forms.Label()
        Me.LbSocio = New System.Windows.Forms.Label()
        Me.LbNroSocio = New System.Windows.Forms.Label()
        Me.LbAnualidad = New System.Windows.Forms.Label()
        Me.lbCobertura = New System.Windows.Forms.Label()
        Me.LbTasa = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbSumaAsegurada = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbPrimaPeriodo = New System.Windows.Forms.Label()
        Me.btnPolizaDynamo = New System.Windows.Forms.Button()
        Me.btnBuscarArchivoExporadoNSIIS = New System.Windows.Forms.Button()
        Me.LbRutaPlantillaExcel = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txPoliza = New System.Windows.Forms.TextBox()
        Me.txPremioNSIIS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txPremioPC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txDctoRecargo = New System.Windows.Forms.TextBox()
        Me.btnGrilla = New System.Windows.Forms.Button()
        Me.txConcepto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPaso1
        '
        Me.btnPaso1.Enabled = False
        Me.btnPaso1.Location = New System.Drawing.Point(220, 214)
        Me.btnPaso1.Name = "btnPaso1"
        Me.btnPaso1.Size = New System.Drawing.Size(143, 39)
        Me.btnPaso1.TabIndex = 1
        Me.btnPaso1.Text = "Paso 1 - Migrar a Polizas"
        Me.btnPaso1.UseVisualStyleBackColor = True
        Me.btnPaso1.Visible = False
        '
        'btnPaso2
        '
        Me.btnPaso2.Enabled = False
        Me.btnPaso2.Location = New System.Drawing.Point(220, 259)
        Me.btnPaso2.Name = "btnPaso2"
        Me.btnPaso2.Size = New System.Drawing.Size(143, 39)
        Me.btnPaso2.TabIndex = 2
        Me.btnPaso2.Text = "Paso 2 - Migrar a Adherentes"
        Me.btnPaso2.UseVisualStyleBackColor = True
        Me.btnPaso2.Visible = False
        '
        'btnPaso3
        '
        Me.btnPaso3.Enabled = False
        Me.btnPaso3.Location = New System.Drawing.Point(220, 304)
        Me.btnPaso3.Name = "btnPaso3"
        Me.btnPaso3.Size = New System.Drawing.Size(143, 39)
        Me.btnPaso3.TabIndex = 3
        Me.btnPaso3.Text = "Paso 3 - Agregar Sexo"
        Me.btnPaso3.UseVisualStyleBackColor = True
        Me.btnPaso3.Visible = False
        '
        'btnPaso4
        '
        Me.btnPaso4.Enabled = False
        Me.btnPaso4.Location = New System.Drawing.Point(220, 349)
        Me.btnPaso4.Name = "btnPaso4"
        Me.btnPaso4.Size = New System.Drawing.Size(143, 39)
        Me.btnPaso4.TabIndex = 4
        Me.btnPaso4.Text = "Paso 4 - Crear CUIL"
        Me.btnPaso4.UseVisualStyleBackColor = True
        Me.btnPaso4.Visible = False
        '
        'btnExportarAExcel
        '
        Me.btnExportarAExcel.Location = New System.Drawing.Point(12, 357)
        Me.btnExportarAExcel.Name = "btnExportarAExcel"
        Me.btnExportarAExcel.Size = New System.Drawing.Size(143, 39)
        Me.btnExportarAExcel.TabIndex = 4
        Me.btnExportarAExcel.Text = "Exportar a Excel"
        Me.btnExportarAExcel.UseVisualStyleBackColor = True
        '
        'CboTipoContrato
        '
        Me.CboTipoContrato.FormattingEnabled = True
        Me.CboTipoContrato.Items.AddRange(New Object() {"Convenio Mercantil", "Obligaciones Laborales", "Optativos", "Peón Rural"})
        Me.CboTipoContrato.Location = New System.Drawing.Point(14, 30)
        Me.CboTipoContrato.Name = "CboTipoContrato"
        Me.CboTipoContrato.Size = New System.Drawing.Size(145, 21)
        Me.CboTipoContrato.TabIndex = 0
        '
        'LbTipo
        '
        Me.LbTipo.AutoSize = True
        Me.LbTipo.ForeColor = System.Drawing.Color.White
        Me.LbTipo.Location = New System.Drawing.Point(11, 14)
        Me.LbTipo.Name = "LbTipo"
        Me.LbTipo.Size = New System.Drawing.Size(86, 13)
        Me.LbTipo.TabIndex = 7
        Me.LbTipo.Text = "Tipo de Contrato"
        '
        'btnBuscarPoliza
        '
        Me.btnBuscarPoliza.Location = New System.Drawing.Point(12, 253)
        Me.btnBuscarPoliza.Name = "btnBuscarPoliza"
        Me.btnBuscarPoliza.Size = New System.Drawing.Size(143, 39)
        Me.btnBuscarPoliza.TabIndex = 2
        Me.btnBuscarPoliza.Text = "Buscar Poliza a Procesar"
        Me.btnBuscarPoliza.UseVisualStyleBackColor = True
        '
        'lbPoliza
        '
        Me.lbPoliza.BackColor = System.Drawing.Color.White
        Me.lbPoliza.Location = New System.Drawing.Point(693, 188)
        Me.lbPoliza.Name = "lbPoliza"
        Me.lbPoliza.Size = New System.Drawing.Size(100, 23)
        Me.lbPoliza.TabIndex = 9
        Me.lbPoliza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbPoliza.Visible = False
        '
        'lbTipoContrato
        '
        Me.lbTipoContrato.BackColor = System.Drawing.Color.White
        Me.lbTipoContrato.Location = New System.Drawing.Point(347, 28)
        Me.lbTipoContrato.Name = "lbTipoContrato"
        Me.lbTipoContrato.Size = New System.Drawing.Size(100, 23)
        Me.lbTipoContrato.TabIndex = 10
        Me.lbTipoContrato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbNuevaPoliza
        '
        Me.lbNuevaPoliza.BackColor = System.Drawing.Color.White
        Me.lbNuevaPoliza.Location = New System.Drawing.Point(462, 28)
        Me.lbNuevaPoliza.Name = "lbNuevaPoliza"
        Me.lbNuevaPoliza.Size = New System.Drawing.Size(100, 23)
        Me.lbNuevaPoliza.TabIndex = 11
        Me.lbNuevaPoliza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbVigencia
        '
        Me.LbVigencia.BackColor = System.Drawing.Color.White
        Me.LbVigencia.Location = New System.Drawing.Point(577, 28)
        Me.LbVigencia.Name = "LbVigencia"
        Me.LbVigencia.Size = New System.Drawing.Size(100, 23)
        Me.LbVigencia.TabIndex = 12
        Me.LbVigencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbProductor
        '
        Me.LbProductor.BackColor = System.Drawing.Color.White
        Me.LbProductor.Location = New System.Drawing.Point(692, 28)
        Me.LbProductor.Name = "LbProductor"
        Me.LbProductor.Size = New System.Drawing.Size(100, 23)
        Me.LbProductor.TabIndex = 13
        Me.LbProductor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbOrganizador
        '
        Me.LbOrganizador.BackColor = System.Drawing.Color.White
        Me.LbOrganizador.Location = New System.Drawing.Point(799, 30)
        Me.LbOrganizador.Name = "LbOrganizador"
        Me.LbOrganizador.Size = New System.Drawing.Size(100, 23)
        Me.LbOrganizador.TabIndex = 14
        Me.LbOrganizador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbSocio
        '
        Me.LbSocio.BackColor = System.Drawing.Color.White
        Me.LbSocio.Location = New System.Drawing.Point(221, 73)
        Me.LbSocio.Name = "LbSocio"
        Me.LbSocio.Size = New System.Drawing.Size(678, 23)
        Me.LbSocio.TabIndex = 15
        Me.LbSocio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbNroSocio
        '
        Me.LbNroSocio.BackColor = System.Drawing.Color.White
        Me.LbNroSocio.Location = New System.Drawing.Point(799, 118)
        Me.LbNroSocio.Name = "LbNroSocio"
        Me.LbNroSocio.Size = New System.Drawing.Size(100, 23)
        Me.LbNroSocio.TabIndex = 16
        Me.LbNroSocio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbAnualidad
        '
        Me.LbAnualidad.BackColor = System.Drawing.Color.White
        Me.LbAnualidad.Location = New System.Drawing.Point(221, 118)
        Me.LbAnualidad.Name = "LbAnualidad"
        Me.LbAnualidad.Size = New System.Drawing.Size(100, 23)
        Me.LbAnualidad.TabIndex = 17
        Me.LbAnualidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCobertura
        '
        Me.lbCobertura.BackColor = System.Drawing.Color.White
        Me.lbCobertura.Location = New System.Drawing.Point(347, 118)
        Me.lbCobertura.Name = "lbCobertura"
        Me.lbCobertura.Size = New System.Drawing.Size(100, 23)
        Me.lbCobertura.TabIndex = 18
        Me.lbCobertura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbTasa
        '
        Me.LbTasa.BackColor = System.Drawing.Color.White
        Me.LbTasa.Location = New System.Drawing.Point(462, 118)
        Me.LbTasa.Name = "LbTasa"
        Me.LbTasa.Size = New System.Drawing.Size(100, 23)
        Me.LbTasa.TabIndex = 19
        Me.LbTasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(219, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Poliza NSIIS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(347, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Tipo de Contrato"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(462, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Nueva Poliza"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(577, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Vigencia"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(692, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Productor"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(799, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Organizador"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(221, 57)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Socio"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(799, 102)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 13)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Nº SOCIO NSIIS"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(221, 102)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 13)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Anualidad"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(347, 102)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 13)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "Cobertura"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(462, 102)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 13)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "Tasa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(577, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Suma Asegurada"
        '
        'lbSumaAsegurada
        '
        Me.lbSumaAsegurada.BackColor = System.Drawing.Color.White
        Me.lbSumaAsegurada.Location = New System.Drawing.Point(577, 118)
        Me.lbSumaAsegurada.Name = "lbSumaAsegurada"
        Me.lbSumaAsegurada.Size = New System.Drawing.Size(100, 23)
        Me.lbSumaAsegurada.TabIndex = 31
        Me.lbSumaAsegurada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(692, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Prima Período"
        '
        'LbPrimaPeriodo
        '
        Me.LbPrimaPeriodo.BackColor = System.Drawing.Color.White
        Me.LbPrimaPeriodo.Location = New System.Drawing.Point(692, 118)
        Me.LbPrimaPeriodo.Name = "LbPrimaPeriodo"
        Me.LbPrimaPeriodo.Size = New System.Drawing.Size(100, 23)
        Me.LbPrimaPeriodo.TabIndex = 33
        Me.LbPrimaPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPolizaDynamo
        '
        Me.btnPolizaDynamo.BackColor = System.Drawing.Color.Maroon
        Me.btnPolizaDynamo.ForeColor = System.Drawing.Color.White
        Me.btnPolizaDynamo.Location = New System.Drawing.Point(10, 421)
        Me.btnPolizaDynamo.Name = "btnPolizaDynamo"
        Me.btnPolizaDynamo.Size = New System.Drawing.Size(143, 50)
        Me.btnPolizaDynamo.TabIndex = 5
        Me.btnPolizaDynamo.Text = "Nº Poliza Dynamo"
        Me.btnPolizaDynamo.UseVisualStyleBackColor = False
        '
        'btnBuscarArchivoExporadoNSIIS
        '
        Me.btnBuscarArchivoExporadoNSIIS.Location = New System.Drawing.Point(10, 312)
        Me.btnBuscarArchivoExporadoNSIIS.Name = "btnBuscarArchivoExporadoNSIIS"
        Me.btnBuscarArchivoExporadoNSIIS.Size = New System.Drawing.Size(143, 39)
        Me.btnBuscarArchivoExporadoNSIIS.TabIndex = 3
        Me.btnBuscarArchivoExporadoNSIIS.Text = "Buscar Archivo Exportado NSIIS"
        Me.btnBuscarArchivoExporadoNSIIS.UseVisualStyleBackColor = True
        '
        'LbRutaPlantillaExcel
        '
        Me.LbRutaPlantillaExcel.ForeColor = System.Drawing.Color.White
        Me.LbRutaPlantillaExcel.Location = New System.Drawing.Point(221, 160)
        Me.LbRutaPlantillaExcel.Name = "LbRutaPlantillaExcel"
        Me.LbRutaPlantillaExcel.Size = New System.Drawing.Size(247, 19)
        Me.LbRutaPlantillaExcel.TabIndex = 37
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txPoliza
        '
        Me.txPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txPoliza.Location = New System.Drawing.Point(220, 28)
        Me.txPoliza.Name = "txPoliza"
        Me.txPoliza.Size = New System.Drawing.Size(100, 24)
        Me.txPoliza.TabIndex = 6
        '
        'txPremioNSIIS
        '
        Me.txPremioNSIIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txPremioNSIIS.Location = New System.Drawing.Point(799, 185)
        Me.txPremioNSIIS.Name = "txPremioNSIIS"
        Me.txPremioNSIIS.Size = New System.Drawing.Size(100, 24)
        Me.txPremioNSIIS.TabIndex = 7
        Me.txPremioNSIIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(796, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Premio NSIIS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(796, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Premio PC"
        '
        'txPremioPC
        '
        Me.txPremioPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txPremioPC.Location = New System.Drawing.Point(799, 235)
        Me.txPremioPC.Name = "txPremioPC"
        Me.txPremioPC.Size = New System.Drawing.Size(100, 24)
        Me.txPremioPC.TabIndex = 8
        Me.txPremioPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(799, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Dcto/Recargo"
        '
        'txDctoRecargo
        '
        Me.txDctoRecargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txDctoRecargo.Location = New System.Drawing.Point(802, 290)
        Me.txDctoRecargo.Name = "txDctoRecargo"
        Me.txDctoRecargo.Size = New System.Drawing.Size(100, 24)
        Me.txDctoRecargo.TabIndex = 9
        Me.txDctoRecargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGrilla
        '
        Me.btnGrilla.Location = New System.Drawing.Point(799, 420)
        Me.btnGrilla.Name = "btnGrilla"
        Me.btnGrilla.Size = New System.Drawing.Size(114, 39)
        Me.btnGrilla.TabIndex = 10
        Me.btnGrilla.Text = "Ver Grilla"
        Me.btnGrilla.UseVisualStyleBackColor = True
        '
        'txConcepto
        '
        Me.txConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txConcepto.Location = New System.Drawing.Point(15, 89)
        Me.txConcepto.Name = "txConcepto"
        Me.txConcepto.Size = New System.Drawing.Size(144, 24)
        Me.txConcepto.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Concepto Búsqueda"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(938, 483)
        Me.Controls.Add(Me.txConcepto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnGrilla)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txDctoRecargo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txPremioPC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txPremioNSIIS)
        Me.Controls.Add(Me.txPoliza)
        Me.Controls.Add(Me.LbRutaPlantillaExcel)
        Me.Controls.Add(Me.btnBuscarArchivoExporadoNSIIS)
        Me.Controls.Add(Me.btnPolizaDynamo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LbPrimaPeriodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbSumaAsegurada)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LbTasa)
        Me.Controls.Add(Me.lbCobertura)
        Me.Controls.Add(Me.LbAnualidad)
        Me.Controls.Add(Me.LbNroSocio)
        Me.Controls.Add(Me.LbSocio)
        Me.Controls.Add(Me.LbOrganizador)
        Me.Controls.Add(Me.LbProductor)
        Me.Controls.Add(Me.LbVigencia)
        Me.Controls.Add(Me.lbNuevaPoliza)
        Me.Controls.Add(Me.lbTipoContrato)
        Me.Controls.Add(Me.lbPoliza)
        Me.Controls.Add(Me.btnBuscarPoliza)
        Me.Controls.Add(Me.LbTipo)
        Me.Controls.Add(Me.CboTipoContrato)
        Me.Controls.Add(Me.btnExportarAExcel)
        Me.Controls.Add(Me.btnPaso4)
        Me.Controls.Add(Me.btnPaso3)
        Me.Controls.Add(Me.btnPaso2)
        Me.Controls.Add(Me.btnPaso1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Migracion Vida Colectivo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPaso1 As Button
    Friend WithEvents btnPaso2 As Button
    Friend WithEvents btnPaso3 As Button
    Friend WithEvents btnPaso4 As Button
    Friend WithEvents btnExportarAExcel As Button
    Friend WithEvents CboTipoContrato As ComboBox
    Friend WithEvents LbTipo As Label
    Friend WithEvents btnBuscarPoliza As Button
    Friend WithEvents lbPoliza As Label
    Friend WithEvents lbTipoContrato As Label
    Friend WithEvents lbNuevaPoliza As Label
    Friend WithEvents LbVigencia As Label
    Friend WithEvents LbProductor As Label
    Friend WithEvents LbOrganizador As Label
    Friend WithEvents LbSocio As Label
    Friend WithEvents LbNroSocio As Label
    Friend WithEvents LbAnualidad As Label
    Friend WithEvents lbCobertura As Label
    Friend WithEvents LbTasa As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbSumaAsegurada As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LbPrimaPeriodo As Label
    Friend WithEvents btnPolizaDynamo As Button
    Friend WithEvents btnBuscarArchivoExporadoNSIIS As Button
    Friend WithEvents LbRutaPlantillaExcel As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txPoliza As TextBox
    Friend WithEvents txPremioNSIIS As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txPremioPC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txDctoRecargo As TextBox
    Friend WithEvents btnGrilla As Button
    Friend WithEvents txConcepto As TextBox
    Friend WithEvents Label6 As Label
End Class
