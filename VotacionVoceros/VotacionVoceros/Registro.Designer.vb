<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Dim FichaLabel As System.Windows.Forms.Label
        Dim ProgramaLabel As System.Windows.Forms.Label
        Dim Tipo_DocumentoLabel As System.Windows.Forms.Label
        Dim No_DocumentoLabel As System.Windows.Forms.Label
        Dim Nombres_y_ApellidosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FichaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresYApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VotantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasedatosvotacionDataSet = New VotacionVoceros.BasedatosvotacionDataSet()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FichaTextBox = New System.Windows.Forms.TextBox()
        Me.ProgramaTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_DocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.No_DocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.Nombres_y_ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.VotantesTableAdapter = New VotacionVoceros.BasedatosvotacionDataSetTableAdapters.VotantesTableAdapter()
        Me.TableAdapterManager = New VotacionVoceros.BasedatosvotacionDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        FichaLabel = New System.Windows.Forms.Label()
        ProgramaLabel = New System.Windows.Forms.Label()
        Tipo_DocumentoLabel = New System.Windows.Forms.Label()
        No_DocumentoLabel = New System.Windows.Forms.Label()
        Nombres_y_ApellidosLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VotantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasedatosvotacionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FichaLabel
        '
        FichaLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        FichaLabel.AutoSize = True
        FichaLabel.BackColor = System.Drawing.Color.Transparent
        FichaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FichaLabel.ForeColor = System.Drawing.Color.Transparent
        FichaLabel.Location = New System.Drawing.Point(15, 320)
        FichaLabel.Name = "FichaLabel"
        FichaLabel.Size = New System.Drawing.Size(42, 13)
        FichaLabel.TabIndex = 31
        FichaLabel.Text = "Ficha:"
        '
        'ProgramaLabel
        '
        ProgramaLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        ProgramaLabel.AutoSize = True
        ProgramaLabel.BackColor = System.Drawing.Color.Transparent
        ProgramaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProgramaLabel.ForeColor = System.Drawing.Color.Transparent
        ProgramaLabel.Location = New System.Drawing.Point(121, 320)
        ProgramaLabel.Name = "ProgramaLabel"
        ProgramaLabel.Size = New System.Drawing.Size(64, 13)
        ProgramaLabel.TabIndex = 32
        ProgramaLabel.Text = "Programa:"
        '
        'Tipo_DocumentoLabel
        '
        Tipo_DocumentoLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Tipo_DocumentoLabel.AutoSize = True
        Tipo_DocumentoLabel.BackColor = System.Drawing.Color.Transparent
        Tipo_DocumentoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tipo_DocumentoLabel.ForeColor = System.Drawing.Color.Transparent
        Tipo_DocumentoLabel.Location = New System.Drawing.Point(365, 320)
        Tipo_DocumentoLabel.Name = "Tipo_DocumentoLabel"
        Tipo_DocumentoLabel.Size = New System.Drawing.Size(104, 13)
        Tipo_DocumentoLabel.TabIndex = 33
        Tipo_DocumentoLabel.Text = "Tipo Documento:"
        '
        'No_DocumentoLabel
        '
        No_DocumentoLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        No_DocumentoLabel.AutoSize = True
        No_DocumentoLabel.BackColor = System.Drawing.Color.Transparent
        No_DocumentoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        No_DocumentoLabel.ForeColor = System.Drawing.Color.Transparent
        No_DocumentoLabel.Location = New System.Drawing.Point(480, 320)
        No_DocumentoLabel.Name = "No_DocumentoLabel"
        No_DocumentoLabel.Size = New System.Drawing.Size(95, 13)
        No_DocumentoLabel.TabIndex = 34
        No_DocumentoLabel.Text = "No Documento:"
        '
        'Nombres_y_ApellidosLabel
        '
        Nombres_y_ApellidosLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Nombres_y_ApellidosLabel.AutoSize = True
        Nombres_y_ApellidosLabel.BackColor = System.Drawing.Color.Transparent
        Nombres_y_ApellidosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombres_y_ApellidosLabel.ForeColor = System.Drawing.Color.Transparent
        Nombres_y_ApellidosLabel.Location = New System.Drawing.Point(603, 320)
        Nombres_y_ApellidosLabel.Name = "Nombres_y_ApellidosLabel"
        Nombres_y_ApellidosLabel.Size = New System.Drawing.Size(125, 13)
        Nombres_y_ApellidosLabel.TabIndex = 35
        Nombres_y_ApellidosLabel.Text = "Nombres y Apellidos:"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FichaDataGridViewTextBoxColumn, Me.ProgramaDataGridViewTextBoxColumn, Me.TipoDocumentoDataGridViewTextBoxColumn, Me.NoDocumentoDataGridViewTextBoxColumn, Me.NombresYApellidosDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VotantesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 167)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(932, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'FichaDataGridViewTextBoxColumn
        '
        Me.FichaDataGridViewTextBoxColumn.DataPropertyName = "Ficha"
        Me.FichaDataGridViewTextBoxColumn.HeaderText = "Ficha"
        Me.FichaDataGridViewTextBoxColumn.Name = "FichaDataGridViewTextBoxColumn"
        '
        'ProgramaDataGridViewTextBoxColumn
        '
        Me.ProgramaDataGridViewTextBoxColumn.DataPropertyName = "Programa"
        Me.ProgramaDataGridViewTextBoxColumn.HeaderText = "Programa"
        Me.ProgramaDataGridViewTextBoxColumn.Name = "ProgramaDataGridViewTextBoxColumn"
        Me.ProgramaDataGridViewTextBoxColumn.Width = 300
        '
        'TipoDocumentoDataGridViewTextBoxColumn
        '
        Me.TipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "Tipo Documento"
        Me.TipoDocumentoDataGridViewTextBoxColumn.HeaderText = "Tipo Documento"
        Me.TipoDocumentoDataGridViewTextBoxColumn.Name = "TipoDocumentoDataGridViewTextBoxColumn"
        Me.TipoDocumentoDataGridViewTextBoxColumn.Width = 70
        '
        'NoDocumentoDataGridViewTextBoxColumn
        '
        Me.NoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "No Documento"
        Me.NoDocumentoDataGridViewTextBoxColumn.HeaderText = "No Documento"
        Me.NoDocumentoDataGridViewTextBoxColumn.Name = "NoDocumentoDataGridViewTextBoxColumn"
        '
        'NombresYApellidosDataGridViewTextBoxColumn
        '
        Me.NombresYApellidosDataGridViewTextBoxColumn.DataPropertyName = "Nombres y Apellidos"
        Me.NombresYApellidosDataGridViewTextBoxColumn.HeaderText = "Nombres y Apellidos"
        Me.NombresYApellidosDataGridViewTextBoxColumn.Name = "NombresYApellidosDataGridViewTextBoxColumn"
        Me.NombresYApellidosDataGridViewTextBoxColumn.Width = 300
        '
        'VotantesBindingSource
        '
        Me.VotantesBindingSource.DataMember = "Votantes"
        Me.VotantesBindingSource.DataSource = Me.BasedatosvotacionDataSet
        '
        'BasedatosvotacionDataSet
        '
        Me.BasedatosvotacionDataSet.DataSetName = "BasedatosvotacionDataSet"
        Me.BasedatosvotacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(940, 149)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'FichaTextBox
        '
        Me.FichaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FichaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VotantesBindingSource, "Ficha", True))
        Me.FichaTextBox.Location = New System.Drawing.Point(18, 336)
        Me.FichaTextBox.Name = "FichaTextBox"
        Me.FichaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FichaTextBox.TabIndex = 32
        '
        'ProgramaTextBox
        '
        Me.ProgramaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgramaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VotantesBindingSource, "Programa", True))
        Me.ProgramaTextBox.Location = New System.Drawing.Point(124, 336)
        Me.ProgramaTextBox.Name = "ProgramaTextBox"
        Me.ProgramaTextBox.Size = New System.Drawing.Size(238, 20)
        Me.ProgramaTextBox.TabIndex = 33
        '
        'Tipo_DocumentoTextBox
        '
        Me.Tipo_DocumentoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tipo_DocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VotantesBindingSource, "Tipo Documento", True))
        Me.Tipo_DocumentoTextBox.Location = New System.Drawing.Point(368, 336)
        Me.Tipo_DocumentoTextBox.Name = "Tipo_DocumentoTextBox"
        Me.Tipo_DocumentoTextBox.Size = New System.Drawing.Size(101, 20)
        Me.Tipo_DocumentoTextBox.TabIndex = 34
        '
        'No_DocumentoTextBox
        '
        Me.No_DocumentoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.No_DocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VotantesBindingSource, "No Documento", True))
        Me.No_DocumentoTextBox.Location = New System.Drawing.Point(483, 336)
        Me.No_DocumentoTextBox.Name = "No_DocumentoTextBox"
        Me.No_DocumentoTextBox.Size = New System.Drawing.Size(117, 20)
        Me.No_DocumentoTextBox.TabIndex = 35
        '
        'Nombres_y_ApellidosTextBox
        '
        Me.Nombres_y_ApellidosTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Nombres_y_ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VotantesBindingSource, "Nombres y Apellidos", True))
        Me.Nombres_y_ApellidosTextBox.Location = New System.Drawing.Point(606, 336)
        Me.Nombres_y_ApellidosTextBox.Name = "Nombres_y_ApellidosTextBox"
        Me.Nombres_y_ApellidosTextBox.Size = New System.Drawing.Size(257, 20)
        Me.Nombres_y_ApellidosTextBox.TabIndex = 36
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(874, 362)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(58, 23)
        Me.Button7.TabIndex = 43
        Me.Button7.Text = "Inicio"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(433, 362)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 42
        Me.Button6.Text = "Limpiar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(591, 362)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 23)
        Me.Button5.TabIndex = 41
        Me.Button5.Text = "Actualizar Tabla"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(514, 362)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 23)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "Buscar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(191, 362)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 23)
        Me.Button3.TabIndex = 39
        Me.Button3.Text = "Borrar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(99, 362)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 23)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Modificar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(18, 362)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Insertar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'VotantesTableAdapter
        '
        Me.VotantesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = VotacionVoceros.BasedatosvotacionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VotantesTableAdapter = Me.VotantesTableAdapter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(857, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 65)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Developed By: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jhon Murillo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cristian Cuartas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ficha: 1752634" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inst: Fabio Garci" &
    "a"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1128, 513)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Nombres_y_ApellidosLabel)
        Me.Controls.Add(Me.Nombres_y_ApellidosTextBox)
        Me.Controls.Add(No_DocumentoLabel)
        Me.Controls.Add(Me.No_DocumentoTextBox)
        Me.Controls.Add(Tipo_DocumentoLabel)
        Me.Controls.Add(Me.Tipo_DocumentoTextBox)
        Me.Controls.Add(ProgramaLabel)
        Me.Controls.Add(Me.ProgramaTextBox)
        Me.Controls.Add(FichaLabel)
        Me.Controls.Add(Me.FichaTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VotantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasedatosvotacionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BasedatosvotacionDataSet As BasedatosvotacionDataSet
    Friend WithEvents VotantesBindingSource As BindingSource
    Friend WithEvents VotantesTableAdapter As BasedatosvotacionDataSetTableAdapters.VotantesTableAdapter
    Friend WithEvents FichaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgramaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDocumentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoDocumentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresYApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableAdapterManager As BasedatosvotacionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FichaTextBox As TextBox
    Friend WithEvents ProgramaTextBox As TextBox
    Friend WithEvents Tipo_DocumentoTextBox As TextBox
    Friend WithEvents No_DocumentoTextBox As TextBox
    Friend WithEvents Nombres_y_ApellidosTextBox As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
