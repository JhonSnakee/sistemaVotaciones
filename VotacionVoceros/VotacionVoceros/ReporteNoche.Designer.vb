<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteNoche
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteNoche))
        Me.VotosNocheBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblcompDataSet = New VotacionVoceros.tblcompDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.VotosNocheTableAdapter = New VotacionVoceros.tblcompDataSetTableAdapters.VotosNocheTableAdapter()
        CType(Me.VotosNocheBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblcompDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VotosNocheBindingSource
        '
        Me.VotosNocheBindingSource.DataMember = "VotosNoche"
        Me.VotosNocheBindingSource.DataSource = Me.tblcompDataSet
        '
        'tblcompDataSet
        '
        Me.tblcompDataSet.DataSetName = "tblcompDataSet"
        Me.tblcompDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ReporteNoche"
        ReportDataSource1.Value = Me.VotosNocheBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VotacionVoceros.ReporteNoche.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(559, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'VotosNocheTableAdapter
        '
        Me.VotosNocheTableAdapter.ClearBeforeFill = True
        '
        'ReporteNoche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReporteNoche"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReporteNoche"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.VotosNocheBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblcompDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VotosNocheBindingSource As BindingSource
    Friend WithEvents tblcompDataSet As tblcompDataSet
    Friend WithEvents VotosNocheTableAdapter As tblcompDataSetTableAdapters.VotosNocheTableAdapter
End Class
