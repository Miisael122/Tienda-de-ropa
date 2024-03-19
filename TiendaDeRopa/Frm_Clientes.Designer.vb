<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Clientes
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
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomicilioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuntosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiendaDeRopaDataSet = New TiendaDeRopa.TiendaDeRopaDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_Inicio = New System.Windows.Forms.Button()
        Me.cmd_Siguiente = New System.Windows.Forms.Button()
        Me.cmd_Anterior = New System.Windows.Forms.Button()
        Me.cmd_Ultimo = New System.Windows.Forms.Button()
        Me.id_Cliente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox7 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox8 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox9 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox10 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox11 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmd_Salir = New System.Windows.Forms.Button()
        Me.cmd_Guardar = New System.Windows.Forms.Button()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.MaskedTextBox6 = New System.Windows.Forms.MaskedTextBox()
        Me.ClientesTableAdapter = New TiendaDeRopa.TiendaDeRopaDataSetTableAdapters.clientesTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiendaDeRopaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.DomicilioDataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.CpDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.PuntosDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(621, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(248, 139)
        Me.DataGridView1.TabIndex = 0
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        Me.IdClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CelularDataGridViewTextBoxColumn
        '
        Me.CelularDataGridViewTextBoxColumn.DataPropertyName = "celular"
        Me.CelularDataGridViewTextBoxColumn.HeaderText = "celular"
        Me.CelularDataGridViewTextBoxColumn.Name = "CelularDataGridViewTextBoxColumn"
        Me.CelularDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DomicilioDataGridViewTextBoxColumn
        '
        Me.DomicilioDataGridViewTextBoxColumn.DataPropertyName = "domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.HeaderText = "domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.Name = "DomicilioDataGridViewTextBoxColumn"
        Me.DomicilioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "colonia"
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        Me.ColoniaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CpDataGridViewTextBoxColumn
        '
        Me.CpDataGridViewTextBoxColumn.DataPropertyName = "cp"
        Me.CpDataGridViewTextBoxColumn.HeaderText = "cp"
        Me.CpDataGridViewTextBoxColumn.Name = "CpDataGridViewTextBoxColumn"
        Me.CpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CiudadDataGridViewTextBoxColumn
        '
        Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "ciudad"
        Me.CiudadDataGridViewTextBoxColumn.HeaderText = "ciudad"
        Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
        Me.CiudadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "correo"
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PuntosDataGridViewTextBoxColumn
        '
        Me.PuntosDataGridViewTextBoxColumn.DataPropertyName = "puntos"
        Me.PuntosDataGridViewTextBoxColumn.HeaderText = "puntos"
        Me.PuntosDataGridViewTextBoxColumn.Name = "PuntosDataGridViewTextBoxColumn"
        Me.PuntosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "saldo"
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "saldo"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        Me.SaldoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.TiendaDeRopaDataSet
        '
        'TiendaDeRopaDataSet
        '
        Me.TiendaDeRopaDataSet.DataSetName = "TiendaDeRopaDataSet"
        Me.TiendaDeRopaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_Inicio)
        Me.GroupBox1.Controls.Add(Me.cmd_Siguiente)
        Me.GroupBox1.Controls.Add(Me.cmd_Anterior)
        Me.GroupBox1.Controls.Add(Me.cmd_Ultimo)
        Me.GroupBox1.Location = New System.Drawing.Point(276, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 68)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmd_Inicio
        '
        Me.cmd_Inicio.Location = New System.Drawing.Point(6, 28)
        Me.cmd_Inicio.Name = "cmd_Inicio"
        Me.cmd_Inicio.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Inicio.TabIndex = 24
        Me.cmd_Inicio.Text = "Inicio"
        Me.cmd_Inicio.UseVisualStyleBackColor = True
        '
        'cmd_Siguiente
        '
        Me.cmd_Siguiente.Location = New System.Drawing.Point(101, 28)
        Me.cmd_Siguiente.Name = "cmd_Siguiente"
        Me.cmd_Siguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Siguiente.TabIndex = 25
        Me.cmd_Siguiente.Text = "Siguiente"
        Me.cmd_Siguiente.UseVisualStyleBackColor = True
        '
        'cmd_Anterior
        '
        Me.cmd_Anterior.Location = New System.Drawing.Point(193, 28)
        Me.cmd_Anterior.Name = "cmd_Anterior"
        Me.cmd_Anterior.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Anterior.TabIndex = 26
        Me.cmd_Anterior.Text = "Anterior"
        Me.cmd_Anterior.UseVisualStyleBackColor = True
        '
        'cmd_Ultimo
        '
        Me.cmd_Ultimo.Location = New System.Drawing.Point(293, 28)
        Me.cmd_Ultimo.Name = "cmd_Ultimo"
        Me.cmd_Ultimo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Ultimo.TabIndex = 27
        Me.cmd_Ultimo.Text = "Ultimo"
        Me.cmd_Ultimo.UseVisualStyleBackColor = True
        '
        'id_Cliente
        '
        Me.id_Cliente.AutoSize = True
        Me.id_Cliente.Location = New System.Drawing.Point(12, 12)
        Me.id_Cliente.Name = "id_Cliente"
        Me.id_Cliente.Size = New System.Drawing.Size(54, 13)
        Me.id_Cliente.TabIndex = 2
        Me.id_Cliente.Text = "Id_Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Celular"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Domicilio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Colonia"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(273, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "C.P."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(273, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Ciudad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(273, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Correo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(273, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Puntos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(273, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Saldo"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "idCliente", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(72, 12)
        Me.MaskedTextBox1.Mask = "99999"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 13
        Me.MaskedTextBox1.ValidatingType = GetType(Integer)
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "telefono", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(72, 77)
        Me.MaskedTextBox2.Mask = "000-0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(195, 20)
        Me.MaskedTextBox2.TabIndex = 14
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nombre", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(72, 42)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(195, 20)
        Me.MaskedTextBox3.TabIndex = 15
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "colonia", True))
        Me.MaskedTextBox4.Location = New System.Drawing.Point(72, 187)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(195, 20)
        Me.MaskedTextBox4.TabIndex = 16
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "domicilio", True))
        Me.MaskedTextBox5.Location = New System.Drawing.Point(72, 150)
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(195, 20)
        Me.MaskedTextBox5.TabIndex = 17
        '
        'MaskedTextBox7
        '
        Me.MaskedTextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "ciudad", True))
        Me.MaskedTextBox7.Location = New System.Drawing.Point(318, 42)
        Me.MaskedTextBox7.Name = "MaskedTextBox7"
        Me.MaskedTextBox7.Size = New System.Drawing.Size(196, 20)
        Me.MaskedTextBox7.TabIndex = 19
        '
        'MaskedTextBox8
        '
        Me.MaskedTextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "puntos", True))
        Me.MaskedTextBox8.Location = New System.Drawing.Point(318, 115)
        Me.MaskedTextBox8.Mask = "99999"
        Me.MaskedTextBox8.Name = "MaskedTextBox8"
        Me.MaskedTextBox8.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox8.TabIndex = 20
        Me.MaskedTextBox8.ValidatingType = GetType(Integer)
        '
        'MaskedTextBox9
        '
        Me.MaskedTextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "correo", True))
        Me.MaskedTextBox9.Location = New System.Drawing.Point(318, 77)
        Me.MaskedTextBox9.Name = "MaskedTextBox9"
        Me.MaskedTextBox9.Size = New System.Drawing.Size(196, 20)
        Me.MaskedTextBox9.TabIndex = 21
        '
        'MaskedTextBox10
        '
        Me.MaskedTextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "saldo", True))
        Me.MaskedTextBox10.Location = New System.Drawing.Point(318, 150)
        Me.MaskedTextBox10.Mask = "99999"
        Me.MaskedTextBox10.Name = "MaskedTextBox10"
        Me.MaskedTextBox10.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox10.TabIndex = 22
        Me.MaskedTextBox10.ValidatingType = GetType(Integer)
        '
        'MaskedTextBox11
        '
        Me.MaskedTextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cp", True))
        Me.MaskedTextBox11.Location = New System.Drawing.Point(318, 12)
        Me.MaskedTextBox11.Mask = "00000"
        Me.MaskedTextBox11.Name = "MaskedTextBox11"
        Me.MaskedTextBox11.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox11.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmd_Salir)
        Me.GroupBox2.Controls.Add(Me.cmd_Guardar)
        Me.GroupBox2.Controls.Add(Me.cmd_Nuevo)
        Me.GroupBox2.Location = New System.Drawing.Point(276, 342)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(403, 78)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'cmd_Salir
        '
        Me.cmd_Salir.Location = New System.Drawing.Point(273, 35)
        Me.cmd_Salir.Name = "cmd_Salir"
        Me.cmd_Salir.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Salir.TabIndex = 29
        Me.cmd_Salir.Text = "Salir"
        Me.cmd_Salir.UseVisualStyleBackColor = True
        '
        'cmd_Guardar
        '
        Me.cmd_Guardar.Enabled = False
        Me.cmd_Guardar.Location = New System.Drawing.Point(152, 35)
        Me.cmd_Guardar.Name = "cmd_Guardar"
        Me.cmd_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Guardar.TabIndex = 30
        Me.cmd_Guardar.Text = "Guardar"
        Me.cmd_Guardar.UseVisualStyleBackColor = True
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(26, 35)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Nuevo.TabIndex = 28
        Me.cmd_Nuevo.Text = "Nuevo"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'MaskedTextBox6
        '
        Me.MaskedTextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "celular", True))
        Me.MaskedTextBox6.Location = New System.Drawing.Point(72, 115)
        Me.MaskedTextBox6.Name = "MaskedTextBox6"
        Me.MaskedTextBox6.Size = New System.Drawing.Size(195, 20)
        Me.MaskedTextBox6.TabIndex = 24
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Frm_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(905, 450)
        Me.Controls.Add(Me.MaskedTextBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MaskedTextBox8)
        Me.Controls.Add(Me.MaskedTextBox11)
        Me.Controls.Add(Me.MaskedTextBox10)
        Me.Controls.Add(Me.MaskedTextBox9)
        Me.Controls.Add(Me.MaskedTextBox7)
        Me.Controls.Add(Me.MaskedTextBox5)
        Me.Controls.Add(Me.MaskedTextBox4)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.id_Cliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.KeyPreview = True
        Me.Name = "Frm_Clientes"
        Me.Text = "Frm_Clientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiendaDeRopaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents id_Cliente As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents MaskedTextBox5 As MaskedTextBox
    Friend WithEvents MaskedTextBox7 As MaskedTextBox
    Friend WithEvents MaskedTextBox8 As MaskedTextBox
    Friend WithEvents MaskedTextBox9 As MaskedTextBox
    Friend WithEvents MaskedTextBox10 As MaskedTextBox
    Friend WithEvents MaskedTextBox11 As MaskedTextBox
    Friend WithEvents cmd_Inicio As Button
    Friend WithEvents cmd_Siguiente As Button
    Friend WithEvents cmd_Anterior As Button
    Friend WithEvents cmd_Ultimo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmd_Nuevo As Button
    Friend WithEvents cmd_Salir As Button
    Friend WithEvents cmd_Guardar As Button
    Friend WithEvents MaskedTextBox6 As MaskedTextBox
    Friend WithEvents TiendaDeRopaDataSet As TiendaDeRopaDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As TiendaDeRopaDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomicilioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PuntosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
