<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContVotosN
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
        Me.VotosNocheBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VotosNocheTableAdapter = New VotacionVoceros.tblcompDataSetTableAdapters.VotosNocheTableAdapter()
        Me.N1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcompDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VotosNocheBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.N1DataGridViewTextBoxColumn, Me.N2DataGridViewTextBoxColumn, Me.N3DataGridViewTextBoxColumn, Me.VBNDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VotosNocheBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(454, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'TblcompDataSet
        '
        Me.TblcompDataSet.DataSetName = "tblcompDataSet"
        Me.TblcompDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VotosNocheBindingSource
        '
        Me.VotosNocheBindingSource.DataMember = "VotosNoche"
        Me.VotosNocheBindingSource.DataSource = Me.TblcompDataSet
        '
        'VotosNocheTableAdapter
        '
        Me.VotosNocheTableAdapter.ClearBeforeFill = True
        '
        'N1DataGridViewTextBoxColumn
        '
        Me.N1DataGridViewTextBoxColumn.DataPropertyName = "N1"
        Me.N1DataGridViewTextBoxColumn.HeaderText = "N1"
        Me.N1DataGridViewTextBoxColumn.Name = "N1DataGridViewTextBoxColumn"
        '
        'N2DataGridViewTextBoxColumn
        '
        Me.N2DataGridViewTextBoxColumn.DataPropertyName = "N2"
        Me.N2DataGridViewTextBoxColumn.HeaderText = "N2"
        Me.N2DataGridViewTextBoxColumn.Name = "N2DataGridViewTextBoxColumn"
        '
        'N3DataGridViewTextBoxColumn
        '
        Me.N3DataGridViewTextBoxColumn.DataPropertyName = "N3"
        Me.N3DataGridViewTextBoxColumn.HeaderText = "N3"
        Me.N3DataGridViewTextBoxColumn.Name = "N3DataGridViewTextBoxColumn"
        '
        'VBNDataGridViewTextBoxColumn
        '
        Me.VBNDataGridViewTextBoxColumn.DataPropertyName = "VBN"
        Me.VBNDataGridViewTextBoxColumn.HeaderText = "VBN"
        Me.VBNDataGridViewTextBoxColumn.Name = "VBNDataGridViewTextBoxColumn"
        '
        'ContVotosN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 199)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ContVotosN"
        Me.Text = "ContVotosN"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcompDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VotosNocheBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TblcompDataSet As tblcompDataSet
    Friend WithEvents VotosNocheBindingSource As BindingSource
    Friend WithEvents VotosNocheTableAdapter As tblcompDataSetTableAdapters.VotosNocheTableAdapter
    Friend WithEvents N1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
