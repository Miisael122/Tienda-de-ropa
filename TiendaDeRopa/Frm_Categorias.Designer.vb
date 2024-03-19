<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Categorias
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_idCategoria = New System.Windows.Forms.MaskedTextBox()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiendaDeRopaDataSet = New TiendaDeRopa.TiendaDeRopaDataSet()
        Me.txt_Concepto = New System.Windows.Forms.MaskedTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdCategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConceptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_Inicio = New System.Windows.Forms.Button()
        Me.cmd_Siguiente = New System.Windows.Forms.Button()
        Me.cmd_Anterior = New System.Windows.Forms.Button()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_Ultimo = New System.Windows.Forms.Button()
        Me.cmd_Guardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmd_Salir = New System.Windows.Forms.Button()
        Me.CategoriasTableAdapter = New TiendaDeRopa.TiendaDeRopaDataSetTableAdapters.categoriasTableAdapter()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiendaDeRopaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id_Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Concepto"
        '
        'txt_idCategoria
        '
        Me.txt_idCategoria.AllowDrop = True
        Me.txt_idCategoria.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasBindingSource, "idCategoria", True))
        Me.txt_idCategoria.Location = New System.Drawing.Point(85, 26)
        Me.txt_idCategoria.Mask = "99999"
        Me.txt_idCategoria.Name = "txt_idCategoria"
        Me.txt_idCategoria.Size = New System.Drawing.Size(100, 20)
        Me.txt_idCategoria.TabIndex = 2
        Me.txt_idCategoria.ValidatingType = GetType(Integer)
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "categorias"
        Me.CategoriasBindingSource.DataSource = Me.TiendaDeRopaDataSet
        '
        'TiendaDeRopaDataSet
        '
        Me.TiendaDeRopaDataSet.DataSetName = "TiendaDeRopaDataSet"
        Me.TiendaDeRopaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_Concepto
        '
        Me.txt_Concepto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasBindingSource, "concepto", True))
        Me.txt_Concepto.Location = New System.Drawing.Point(85, 66)
        Me.txt_Concepto.Name = "txt_Concepto"
        Me.txt_Concepto.Size = New System.Drawing.Size(233, 20)
        Me.txt_Concepto.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCategoriaDataGridViewTextBoxColumn, Me.ConceptoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CategoriasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(475, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(313, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'IdCategoriaDataGridViewTextBoxColumn
        '
        Me.IdCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.Name = "IdCategoriaDataGridViewTextBoxColumn"
        Me.IdCategoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConceptoDataGridViewTextBoxColumn
        '
        Me.ConceptoDataGridViewTextBoxColumn.DataPropertyName = "concepto"
        Me.ConceptoDataGridViewTextBoxColumn.HeaderText = "concepto"
        Me.ConceptoDataGridViewTextBoxColumn.Name = "ConceptoDataGridViewTextBoxColumn"
        Me.ConceptoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'cmd_Inicio
        '
        Me.cmd_Inicio.Location = New System.Drawing.Point(6, 40)
        Me.cmd_Inicio.Name = "cmd_Inicio"
        Me.cmd_Inicio.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Inicio.TabIndex = 5
        Me.cmd_Inicio.Text = "Inicio"
        Me.cmd_Inicio.UseVisualStyleBackColor = True
        '
        'cmd_Siguiente
        '
        Me.cmd_Siguiente.Location = New System.Drawing.Point(105, 40)
        Me.cmd_Siguiente.Name = "cmd_Siguiente"
        Me.cmd_Siguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Siguiente.TabIndex = 6
        Me.cmd_Siguiente.Text = "Siguiente"
        Me.cmd_Siguiente.UseVisualStyleBackColor = True
        '
        'cmd_Anterior
        '
        Me.cmd_Anterior.Location = New System.Drawing.Point(201, 40)
        Me.cmd_Anterior.Name = "cmd_Anterior"
        Me.cmd_Anterior.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Anterior.TabIndex = 7
        Me.cmd_Anterior.Text = "Anterior"
        Me.cmd_Anterior.UseVisualStyleBackColor = True
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(6, 41)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Nuevo.TabIndex = 8
        Me.cmd_Nuevo.Text = "Nuevo"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_Ultimo
        '
        Me.cmd_Ultimo.Location = New System.Drawing.Point(295, 40)
        Me.cmd_Ultimo.Name = "cmd_Ultimo"
        Me.cmd_Ultimo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Ultimo.TabIndex = 9
        Me.cmd_Ultimo.Text = "Ultimo"
        Me.cmd_Ultimo.UseVisualStyleBackColor = True
        '
        'cmd_Guardar
        '
        Me.cmd_Guardar.Enabled = False
        Me.cmd_Guardar.Location = New System.Drawing.Point(147, 41)
        Me.cmd_Guardar.Name = "cmd_Guardar"
        Me.cmd_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Guardar.TabIndex = 10
        Me.cmd_Guardar.Text = "Guardar"
        Me.cmd_Guardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_Inicio)
        Me.GroupBox1.Controls.Add(Me.cmd_Siguiente)
        Me.GroupBox1.Controls.Add(Me.cmd_Anterior)
        Me.GroupBox1.Controls.Add(Me.cmd_Ultimo)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 100)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmd_Salir)
        Me.GroupBox2.Controls.Add(Me.cmd_Nuevo)
        Me.GroupBox2.Controls.Add(Me.cmd_Guardar)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 100)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'cmd_Salir
        '
        Me.cmd_Salir.Location = New System.Drawing.Point(295, 41)
        Me.cmd_Salir.Name = "cmd_Salir"
        Me.cmd_Salir.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Salir.TabIndex = 13
        Me.cmd_Salir.Text = "Salir"
        Me.cmd_Salir.UseVisualStyleBackColor = True
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'Frm_Categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_Concepto)
        Me.Controls.Add(Me.txt_idCategoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "Frm_Categorias"
        Me.Text = "Categorias"
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiendaDeRopaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_idCategoria As MaskedTextBox
    Friend WithEvents txt_Concepto As MaskedTextBox
    Friend WithEvents DataGridView1 As DataGridView

    Friend WithEvents cmd_Inicio As Button
    Friend WithEvents cmd_Siguiente As Button
    Friend WithEvents cmd_Anterior As Button
    Friend WithEvents cmd_Nuevo As Button
    Friend WithEvents cmd_Ultimo As Button
    Friend WithEvents cmd_Guardar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmd_Salir As Button
    Friend WithEvents TiendaDeRopaDataSet As TiendaDeRopaDataSet
    Friend WithEvents CategoriasBindingSource As BindingSource
    Friend WithEvents CategoriasTableAdapter As TiendaDeRopaDataSetTableAdapters.categoriasTableAdapter
    Friend WithEvents IdCategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConceptoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
