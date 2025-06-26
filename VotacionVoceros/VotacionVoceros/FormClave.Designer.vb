<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClave
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblcompDataSet = New VotacionVoceros.tblcompDataSet()
        Me.ContraseñaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContraseñaTableAdapter = New VotacionVoceros.tblcompDataSetTableAdapters.ContraseñaTableAdapter()
        Me.ClaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcompDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContraseñaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClaveDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ContraseñaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(151, 54)
        Me.DataGridView1.TabIndex = 0
        '
        'TblcompDataSet
        '
        Me.TblcompDataSet.DataSetName = "tblcompDataSet"
        Me.TblcompDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContraseñaBindingSource
        '
        Me.ContraseñaBindingSource.DataMember = "Contraseña"
        Me.ContraseñaBindingSource.DataSource = Me.TblcompDataSet
        '
        'ContraseñaTableAdapter
        '
        Me.ContraseñaTableAdapter.ClearBeforeFill = True
        '
        'ClaveDataGridViewTextBoxColumn
        '
        Me.ClaveDataGridViewTextBoxColumn.DataPropertyName = "Clave"
        Me.ClaveDataGridViewTextBoxColumn.HeaderText = "Clave"
        Me.ClaveDataGridViewTextBoxColumn.Name = "ClaveDataGridViewTextBoxColumn"
        '
        'FormClave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(182, 80)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormClave"
        Me.Text = "FormClave"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcompDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContraseñaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TblcompDataSet As tblcompDataSet
    Friend WithEvents ContraseñaBindingSource As BindingSource
    Friend WithEvents ContraseñaTableAdapter As tblcompDataSetTableAdapters.ContraseñaTableAdapter
    Friend WithEvents ClaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
