<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContVotosD
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
        Me.VotosDiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VotosDiaTableAdapter = New VotacionVoceros.tblcompDataSetTableAdapters.VotosDiaTableAdapter()
        Me.T1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcompDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VotosDiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.T1DataGridViewTextBoxColumn, Me.T2DataGridViewTextBoxColumn, Me.T3DataGridViewTextBoxColumn, Me.VBDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VotosDiaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(448, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'TblcompDataSet
        '
        Me.TblcompDataSet.DataSetName = "tblcompDataSet"
        Me.TblcompDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VotosDiaBindingSource
        '
        Me.VotosDiaBindingSource.DataMember = "VotosDia"
        Me.VotosDiaBindingSource.DataSource = Me.TblcompDataSet
        '
        'VotosDiaTableAdapter
        '
        Me.VotosDiaTableAdapter.ClearBeforeFill = True
        '
        'T1DataGridViewTextBoxColumn
        '
        Me.T1DataGridViewTextBoxColumn.DataPropertyName = "T1"
        Me.T1DataGridViewTextBoxColumn.HeaderText = "T1"
        Me.T1DataGridViewTextBoxColumn.Name = "T1DataGridViewTextBoxColumn"
        '
        'T2DataGridViewTextBoxColumn
        '
        Me.T2DataGridViewTextBoxColumn.DataPropertyName = "T2"
        Me.T2DataGridViewTextBoxColumn.HeaderText = "T2"
        Me.T2DataGridViewTextBoxColumn.Name = "T2DataGridViewTextBoxColumn"
        '
        'T3DataGridViewTextBoxColumn
        '
        Me.T3DataGridViewTextBoxColumn.DataPropertyName = "T3"
        Me.T3DataGridViewTextBoxColumn.HeaderText = "T3"
        Me.T3DataGridViewTextBoxColumn.Name = "T3DataGridViewTextBoxColumn"
        '
        'VBDataGridViewTextBoxColumn
        '
        Me.VBDataGridViewTextBoxColumn.DataPropertyName = "VB"
        Me.VBDataGridViewTextBoxColumn.HeaderText = "VB"
        Me.VBDataGridViewTextBoxColumn.Name = "VBDataGridViewTextBoxColumn"
        '
        'ContVotosD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 179)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ContVotosD"
        Me.Text = "ContVotosD"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcompDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VotosDiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TblcompDataSet As tblcompDataSet
    Friend WithEvents VotosDiaBindingSource As BindingSource
    Friend WithEvents VotosDiaTableAdapter As tblcompDataSetTableAdapters.VotosDiaTableAdapter
    Friend WithEvents T1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents T2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents T3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
