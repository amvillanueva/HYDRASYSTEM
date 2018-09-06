<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPadronReg_Sociedad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPadronReg_Sociedad))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.dgvPadron = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvSociedad = New System.Windows.Forms.DataGridView()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSociedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.dgvPersona = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbRegante = New System.Windows.Forms.TabPage()
        Me.chkSociedades = New System.Windows.Forms.CheckBox()
        Me.tbSociedad = New System.Windows.Forms.TabPage()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvPadron, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSociedad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tbRegante.SuspendLayout()
        Me.tbSociedad.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1161, 25)
        Me.lblTitulo.TabIndex = 31
        Me.lblTitulo.Text = "NUEVO  REGANTE / SOCIEDAD"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox10)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer3.Size = New System.Drawing.Size(1143, 310)
        Me.SplitContainer3.SplitterDistance = 70
        Me.SplitContainer3.TabIndex = 32
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox10.Controls.Add(Me.btnPreview)
        Me.GroupBox10.Controls.Add(Me.GroupBox2)
        Me.GroupBox10.ForeColor = System.Drawing.Color.Indigo
        Me.GroupBox10.Location = New System.Drawing.Point(16, 7)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(555, 58)
        Me.GroupBox10.TabIndex = 139
        Me.GroupBox10.TabStop = False
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnPreview.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPreview.FlatAppearance.BorderSize = 0
        Me.btnPreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.ForeColor = System.Drawing.Color.White
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.Location = New System.Drawing.Point(440, 10)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(104, 38)
        Me.btnPreview.TabIndex = 199
        Me.btnPreview.Text = "BUSCAR"
        Me.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtIdentidad)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(4, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(403, 50)
        Me.GroupBox2.TabIndex = 198
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Regane"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(10, 19)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(94, 20)
        Me.txtIdentidad.TabIndex = 196
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(110, 19)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(280, 21)
        Me.txtNombres.TabIndex = 193
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOut)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvPadron)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1143, 236)
        Me.SplitContainer1.SplitterDistance = 530
        Me.SplitContainer1.TabIndex = 6
        '
        'btnOut
        '
        Me.btnOut.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOut.Location = New System.Drawing.Point(504, 110)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(23, 35)
        Me.btnOut.TabIndex = 30
        Me.btnOut.Text = ">"
        Me.btnOut.UseVisualStyleBackColor = True
        '
        'dgvPadron
        '
        Me.dgvPadron.AllowUserToAddRows = False
        Me.dgvPadron.AllowUserToResizeRows = False
        Me.dgvPadron.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPadron.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPadron.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPadron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPadron.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPadron.Location = New System.Drawing.Point(3, 28)
        Me.dgvPadron.MultiSelect = False
        Me.dgvPadron.Name = "dgvPadron"
        Me.dgvPadron.ReadOnly = True
        Me.dgvPadron.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPadron.Size = New System.Drawing.Size(495, 208)
        Me.dgvPadron.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvSociedad)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(601, 205)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nueva Sociedad"
        '
        'dgvSociedad
        '
        Me.dgvSociedad.AllowUserToAddRows = False
        Me.dgvSociedad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSociedad.BackgroundColor = System.Drawing.Color.MintCream
        Me.dgvSociedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSociedad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identidad, Me.Nombres, Me.IdSociedad})
        Me.dgvSociedad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSociedad.Location = New System.Drawing.Point(3, 18)
        Me.dgvSociedad.Name = "dgvSociedad"
        Me.dgvSociedad.ReadOnly = True
        Me.dgvSociedad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSociedad.Size = New System.Drawing.Size(595, 184)
        Me.dgvSociedad.TabIndex = 0
        '
        'Identidad
        '
        Me.Identidad.HeaderText = "Identidad"
        Me.Identidad.Name = "Identidad"
        Me.Identidad.ReadOnly = True
        Me.Identidad.Width = 84
        '
        'Nombres
        '
        Me.Nombres.HeaderText = "Nombres"
        Me.Nombres.Name = "Nombres"
        Me.Nombres.ReadOnly = True
        Me.Nombres.Width = 80
        '
        'IdSociedad
        '
        Me.IdSociedad.HeaderText = "IdSociedad"
        Me.IdSociedad.Name = "IdSociedad"
        Me.IdSociedad.ReadOnly = True
        Me.IdSociedad.Width = 92
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSave, Me.ToolStripSeparator2, Me.ToolStripSeparator1, Me.tsbtnEditar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(609, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbSave
        '
        Me.tsbSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tsbSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbSave.ForeColor = System.Drawing.Color.White
        Me.tsbSave.Image = CType(resources.GetObject("tsbSave.Image"), System.Drawing.Image)
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(190, 22)
        Me.tsbSave.Text = "GUARDAR NUEVA SOCIEDAD"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnEditar
        '
        Me.tsbtnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tsbtnEditar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbtnEditar.ForeColor = System.Drawing.Color.White
        Me.tsbtnEditar.Image = CType(resources.GetObject("tsbtnEditar.Image"), System.Drawing.Image)
        Me.tsbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEditar.Name = "tsbtnEditar"
        Me.tsbtnEditar.Size = New System.Drawing.Size(68, 22)
        Me.tsbtnEditar.Text = "EDITAR"
        '
        'dgvPersona
        '
        Me.dgvPersona.AllowUserToAddRows = False
        Me.dgvPersona.AllowUserToDeleteRows = False
        Me.dgvPersona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPersona.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvPersona.BackgroundColor = System.Drawing.Color.LightBlue
        Me.dgvPersona.ColumnHeadersVisible = False
        Me.dgvPersona.Location = New System.Drawing.Point(42, 104)
        Me.dgvPersona.MultiSelect = False
        Me.dgvPersona.Name = "dgvPersona"
        Me.dgvPersona.ReadOnly = True
        Me.dgvPersona.RowHeadersVisible = False
        Me.dgvPersona.Size = New System.Drawing.Size(381, 5)
        Me.dgvPersona.TabIndex = 208
        Me.dgvPersona.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbRegante)
        Me.TabControl1.Controls.Add(Me.tbSociedad)
        Me.TabControl1.Location = New System.Drawing.Point(4, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1157, 342)
        Me.TabControl1.TabIndex = 33
        '
        'tbRegante
        '
        Me.tbRegante.Controls.Add(Me.chkSociedades)
        Me.tbRegante.Location = New System.Drawing.Point(4, 22)
        Me.tbRegante.Name = "tbRegante"
        Me.tbRegante.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRegante.Size = New System.Drawing.Size(1149, 316)
        Me.tbRegante.TabIndex = 0
        Me.tbRegante.Text = "Nuevo Regante"
        Me.tbRegante.UseVisualStyleBackColor = True
        '
        'chkSociedades
        '
        Me.chkSociedades.AutoSize = True
        Me.chkSociedades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSociedades.Location = New System.Drawing.Point(209, 6)
        Me.chkSociedades.Name = "chkSociedades"
        Me.chkSociedades.Size = New System.Drawing.Size(146, 20)
        Me.chkSociedades.TabIndex = 1
        Me.chkSociedades.Text = "Buscar Sociedades"
        Me.chkSociedades.UseVisualStyleBackColor = True
        '
        'tbSociedad
        '
        Me.tbSociedad.Controls.Add(Me.SplitContainer3)
        Me.tbSociedad.Location = New System.Drawing.Point(4, 22)
        Me.tbSociedad.Name = "tbSociedad"
        Me.tbSociedad.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSociedad.Size = New System.Drawing.Size(1149, 316)
        Me.tbSociedad.TabIndex = 1
        Me.tbSociedad.Text = "Nueva Sociedad"
        Me.tbSociedad.UseVisualStyleBackColor = True
        '
        'FrmPadronReg_Sociedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 375)
        Me.Controls.Add(Me.dgvPersona)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "FrmPadronReg_Sociedad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPadronReg_Sociedad"
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvPadron, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSociedad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tbRegante.ResumeLayout(False)
        Me.tbRegante.PerformLayout()
        Me.tbSociedad.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtIdentidad As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents dgvPadron As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPersona As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbRegante As System.Windows.Forms.TabPage
    Friend WithEvents tbSociedad As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Private WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSociedades As System.Windows.Forms.CheckBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnOut As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSociedad As System.Windows.Forms.DataGridView
    Friend WithEvents Identidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdSociedad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
