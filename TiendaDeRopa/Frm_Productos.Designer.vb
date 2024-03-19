<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Productos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinimosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UbicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiendaDeRopaDataSet = New TiendaDeRopa.TiendaDeRopaDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox6 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox8 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox9 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox10 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_Ultimo = New System.Windows.Forms.Button()
        Me.cmd_Anterior = New System.Windows.Forms.Button()
        Me.cmd_Siguiente = New System.Windows.Forms.Button()
        Me.cmd_Inicio = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_Guardar = New System.Windows.Forms.Button()
        Me.cmd_Salir = New System.Windows.Forms.Button()
        Me.MaskedTextBox7 = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductosTableAdapter = New TiendaDeRopa.TiendaDeRopaDataSetTableAdapters.productosTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiendaDeRopaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.IdCategoriaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.MaximosDataGridViewTextBoxColumn, Me.MinimosDataGridViewTextBoxColumn, Me.UbicacionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(548, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCategoriaDataGridViewTextBoxColumn
        '
        Me.IdCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.Name = "IdCategoriaDataGridViewTextBoxColumn"
        Me.IdCategoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        Me.ExistenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaximosDataGridViewTextBoxColumn
        '
        Me.MaximosDataGridViewTextBoxColumn.DataPropertyName = "maximos"
        Me.MaximosDataGridViewTextBoxColumn.HeaderText = "maximos"
        Me.MaximosDataGridViewTextBoxColumn.Name = "MaximosDataGridViewTextBoxColumn"
        Me.MaximosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MinimosDataGridViewTextBoxColumn
        '
        Me.MinimosDataGridViewTextBoxColumn.DataPropertyName = "minimos"
        Me.MinimosDataGridViewTextBoxColumn.HeaderText = "minimos"
        Me.MinimosDataGridViewTextBoxColumn.Name = "MinimosDataGridViewTextBoxColumn"
        Me.MinimosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UbicacionDataGridViewTextBoxColumn
        '
        Me.UbicacionDataGridViewTextBoxColumn.DataPropertyName = "ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.HeaderText = "ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.Name = "UbicacionDataGridViewTextBoxColumn"
        Me.UbicacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.TiendaDeRopaDataSet
        '
        'TiendaDeRopaDataSet
        '
        Me.TiendaDeRopaDataSet.DataSetName = "TiendaDeRopaDataSet"
        Me.TiendaDeRopaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id_Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(260, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Costo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(260, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Existencia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(260, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Maximos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(260, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Minimos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(260, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Ubicacion"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "idProducto", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(83, 6)
        Me.MaskedTextBox1.Mask = "99999"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(89, 20)
        Me.MaskedTextBox1.TabIndex = 11
        Me.MaskedTextBox1.ValidatingType = GetType(Integer)
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "maximos", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(327, 66)
        Me.MaskedTextBox2.Mask = "99999"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(82, 20)
        Me.MaskedTextBox2.TabIndex = 12
        Me.MaskedTextBox2.ValidatingType = GetType(Integer)
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "existencia", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(327, 35)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(82, 20)
        Me.MaskedTextBox3.TabIndex = 13
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "costo", True))
        Me.MaskedTextBox4.Location = New System.Drawing.Point(327, 6)
        Me.MaskedTextBox4.Mask = "99999"
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(82, 20)
        Me.MaskedTextBox4.TabIndex = 14
        Me.MaskedTextBox4.ValidatingType = GetType(Integer)
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "minimos", True))
        Me.MaskedTextBox5.Location = New System.Drawing.Point(327, 96)
        Me.MaskedTextBox5.Mask = "99999"
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(82, 20)
        Me.MaskedTextBox5.TabIndex = 15
        Me.MaskedTextBox5.ValidatingType = GetType(Integer)
        '
        'MaskedTextBox6
        '
        Me.MaskedTextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "ubicacion", True))
        Me.MaskedTextBox6.Location = New System.Drawing.Point(327, 125)
        Me.MaskedTextBox6.Name = "MaskedTextBox6"
        Me.MaskedTextBox6.Size = New System.Drawing.Size(151, 20)
        Me.MaskedTextBox6.TabIndex = 16
        '
        'MaskedTextBox8
        '
        Me.MaskedTextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precio", True))
        Me.MaskedTextBox8.Location = New System.Drawing.Point(83, 125)
        Me.MaskedTextBox8.Mask = "99999"
        Me.MaskedTextBox8.Name = "MaskedTextBox8"
        Me.MaskedTextBox8.Size = New System.Drawing.Size(89, 20)
        Me.MaskedTextBox8.TabIndex = 18
        Me.MaskedTextBox8.ValidatingType = GetType(Integer)
        '
        'MaskedTextBox9
        '
        Me.MaskedTextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "descripcion", True))
        Me.MaskedTextBox9.Location = New System.Drawing.Point(83, 96)
        Me.MaskedTextBox9.Name = "MaskedTextBox9"
        Me.MaskedTextBox9.Size = New System.Drawing.Size(150, 20)
        Me.MaskedTextBox9.TabIndex = 19
        '
        'MaskedTextBox10
        '
        Me.MaskedTextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "nombre", True))
        Me.MaskedTextBox10.Location = New System.Drawing.Point(83, 66)
        Me.MaskedTextBox10.Name = "MaskedTextBox10"
        Me.MaskedTextBox10.Size = New System.Drawing.Size(150, 20)
        Me.MaskedTextBox10.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_Ultimo)
        Me.GroupBox1.Controls.Add(Me.cmd_Anterior)
        Me.GroupBox1.Controls.Add(Me.cmd_Siguiente)
        Me.GroupBox1.Controls.Add(Me.cmd_Inicio)
        Me.GroupBox1.Location = New System.Drawing.Point(186, 203)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 56)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'cmd_Ultimo
        '
        Me.cmd_Ultimo.Location = New System.Drawing.Point(301, 19)
        Me.cmd_Ultimo.Name = "cmd_Ultimo"
        Me.cmd_Ultimo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Ultimo.TabIndex = 3
        Me.cmd_Ultimo.Text = "Ultimo"
        Me.cmd_Ultimo.UseVisualStyleBackColor = True
        '
        'cmd_Anterior
        '
        Me.cmd_Anterior.Location = New System.Drawing.Point(202, 19)
        Me.cmd_Anterior.Name = "cmd_Anterior"
        Me.cmd_Anterior.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Anterior.TabIndex = 2
        Me.cmd_Anterior.Text = "Anterior"
        Me.cmd_Anterior.UseVisualStyleBackColor = True
        '
        'cmd_Siguiente
        '
        Me.cmd_Siguiente.Location = New System.Drawing.Point(103, 19)
        Me.cmd_Siguiente.Name = "cmd_Siguiente"
        Me.cmd_Siguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Siguiente.TabIndex = 1
        Me.cmd_Siguiente.Text = "Siguiente"
        Me.cmd_Siguiente.UseVisualStyleBackColor = True
        '
        'cmd_Inicio
        '
        Me.cmd_Inicio.Location = New System.Drawing.Point(6, 19)
        Me.cmd_Inicio.Name = "cmd_Inicio"
        Me.cmd_Inicio.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Inicio.TabIndex = 0
        Me.cmd_Inicio.Text = "Inicio"
        Me.cmd_Inicio.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmd_Nuevo)
        Me.GroupBox2.Controls.Add(Me.cmd_Guardar)
        Me.GroupBox2.Controls.Add(Me.cmd_Salir)
        Me.GroupBox2.Location = New System.Drawing.Point(186, 292)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(382, 56)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(33, 19)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Nuevo.TabIndex = 4
        Me.cmd_Nuevo.Text = "Nuevo"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_Guardar
        '
        Me.cmd_Guardar.Enabled = False
        Me.cmd_Guardar.Location = New System.Drawing.Point(154, 19)
        Me.cmd_Guardar.Name = "cmd_Guardar"
        Me.cmd_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Guardar.TabIndex = 5
        Me.cmd_Guardar.Text = "Guardar"
        Me.cmd_Guardar.UseVisualStyleBackColor = True
        '
        'cmd_Salir
        '
        Me.cmd_Salir.Location = New System.Drawing.Point(260, 19)
        Me.cmd_Salir.Name = "cmd_Salir"
        Me.cmd_Salir.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Salir.TabIndex = 6
        Me.cmd_Salir.Text = "Salir"
        Me.cmd_Salir.UseVisualStyleBackColor = True
        '
        'MaskedTextBox7
        '
        Me.MaskedTextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "idCategoria", True))
        Me.MaskedTextBox7.Location = New System.Drawing.Point(83, 39)
        Me.MaskedTextBox7.Mask = "99999"
        Me.MaskedTextBox7.Name = "MaskedTextBox7"
        Me.MaskedTextBox7.Size = New System.Drawing.Size(89, 20)
        Me.MaskedTextBox7.TabIndex = 24
        Me.MaskedTextBox7.ValidatingType = GetType(Integer)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Id_Categoria"
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'Frm_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MaskedTextBox7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MaskedTextBox10)
        Me.Controls.Add(Me.MaskedTextBox9)
        Me.Controls.Add(Me.MaskedTextBox8)
        Me.Controls.Add(Me.MaskedTextBox6)
        Me.Controls.Add(Me.MaskedTextBox5)
        Me.Controls.Add(Me.MaskedTextBox4)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.KeyPreview = True
        Me.Name = "Frm_Productos"
        Me.Text = "Frm_Productos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiendaDeRopaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents MaskedTextBox5 As MaskedTextBox
    Friend WithEvents MaskedTextBox6 As MaskedTextBox
    Friend WithEvents MaskedTextBox8 As MaskedTextBox
    Friend WithEvents MaskedTextBox9 As MaskedTextBox
    Friend WithEvents MaskedTextBox10 As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmd_Ultimo As Button
    Friend WithEvents cmd_Anterior As Button
    Friend WithEvents cmd_Siguiente As Button
    Friend WithEvents cmd_Inicio As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmd_Nuevo As Button
    Friend WithEvents cmd_Guardar As Button
    Friend WithEvents cmd_Salir As Button
    Friend WithEvents MaskedTextBox7 As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TiendaDeRopaDataSet As TiendaDeRopaDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As TiendaDeRopaDataSetTableAdapters.productosTableAdapter
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaximosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinimosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
