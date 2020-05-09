<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FGrid
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridBusquedas = New System.Windows.Forms.DataGridView()
        Me.CMenuBusquedas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BusquedaPorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PolizaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MesDeVencimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosLosRegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AseguradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoContratoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridBusquedas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMenuBusquedas.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridBusquedas
        '
        Me.DataGridBusquedas.AllowUserToAddRows = False
        Me.DataGridBusquedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridBusquedas.ContextMenuStrip = Me.CMenuBusquedas
        Me.DataGridBusquedas.Location = New System.Drawing.Point(24, 44)
        Me.DataGridBusquedas.Name = "DataGridBusquedas"
        Me.DataGridBusquedas.Size = New System.Drawing.Size(888, 367)
        Me.DataGridBusquedas.TabIndex = 4
        '
        'CMenuBusquedas
        '
        Me.CMenuBusquedas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BusquedaPorToolStripMenuItem})
        Me.CMenuBusquedas.Name = "CMenuBusquedas"
        Me.CMenuBusquedas.Size = New System.Drawing.Size(181, 48)
        '
        'BusquedaPorToolStripMenuItem
        '
        Me.BusquedaPorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PolizaToolStripMenuItem, Me.TransaccionToolStripMenuItem, Me.MesDeVencimientoToolStripMenuItem, Me.AseguradoToolStripMenuItem, Me.ProductorToolStripMenuItem, Me.TipoContratoToolStripMenuItem, Me.TodosLosRegistrosToolStripMenuItem})
        Me.BusquedaPorToolStripMenuItem.Name = "BusquedaPorToolStripMenuItem"
        Me.BusquedaPorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BusquedaPorToolStripMenuItem.Text = "Busqueda por"
        '
        'PolizaToolStripMenuItem
        '
        Me.PolizaToolStripMenuItem.Name = "PolizaToolStripMenuItem"
        Me.PolizaToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.PolizaToolStripMenuItem.Text = "Poliza NSIIS"
        '
        'TransaccionToolStripMenuItem
        '
        Me.TransaccionToolStripMenuItem.Name = "TransaccionToolStripMenuItem"
        Me.TransaccionToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.TransaccionToolStripMenuItem.Text = "Poliza o Transaccion Dynamo"
        '
        'MesDeVencimientoToolStripMenuItem
        '
        Me.MesDeVencimientoToolStripMenuItem.Name = "MesDeVencimientoToolStripMenuItem"
        Me.MesDeVencimientoToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.MesDeVencimientoToolStripMenuItem.Text = "Mes de Vencimiento"
        '
        'TodosLosRegistrosToolStripMenuItem
        '
        Me.TodosLosRegistrosToolStripMenuItem.Name = "TodosLosRegistrosToolStripMenuItem"
        Me.TodosLosRegistrosToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.TodosLosRegistrosToolStripMenuItem.Text = "Todos los Registros"
        '
        'AseguradoToolStripMenuItem
        '
        Me.AseguradoToolStripMenuItem.Name = "AseguradoToolStripMenuItem"
        Me.AseguradoToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.AseguradoToolStripMenuItem.Text = "Asegurado"
        '
        'ProductorToolStripMenuItem
        '
        Me.ProductorToolStripMenuItem.Name = "ProductorToolStripMenuItem"
        Me.ProductorToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.ProductorToolStripMenuItem.Text = "Productor"
        '
        'TipoContratoToolStripMenuItem
        '
        Me.TipoContratoToolStripMenuItem.Name = "TipoContratoToolStripMenuItem"
        Me.TipoContratoToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.TipoContratoToolStripMenuItem.Text = "Tipo Contrato"
        '
        'FGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(938, 483)
        Me.Controls.Add(Me.DataGridBusquedas)
        Me.Name = "FGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grilla"
        CType(Me.DataGridBusquedas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMenuBusquedas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridBusquedas As DataGridView
    Friend WithEvents CMenuBusquedas As ContextMenuStrip
    Friend WithEvents BusquedaPorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PolizaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MesDeVencimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodosLosRegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AseguradoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoContratoToolStripMenuItem As ToolStripMenuItem
End Class
