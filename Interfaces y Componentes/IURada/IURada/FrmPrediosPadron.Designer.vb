<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrediosPadron
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrediosPadron))
        Me.dgvPredios = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPadron = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboCampana = New System.Windows.Forms.ComboBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.chkSociedades = New System.Windows.Forms.CheckBox()
        Me.gbxBuscarALumno = New System.Windows.Forms.GroupBox()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGenXml = New System.Windows.Forms.Button()
        Me.dgvPersona = New System.Windows.Forms.DataGridView()
        Me.lblTitulo = New System.Windows.Forms.Label()
        CType(Me.dgvPredios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPadron, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.gbxBuscarALumno.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPredios
        '
        Me.dgvPredios.AllowUserToAddRows = False
        Me.dgvPredios.AllowUserToDeleteRows = False
        Me.dgvPredios.AllowUserToOrderColumns = True
        Me.dgvPredios.AllowUserToResizeRows = False
        Me.dgvPredios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPredios.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgvPredios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPredios.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPredios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPredios.Location = New System.Drawing.Point(0, 0)
        Me.dgvPredios.MultiSelect = False
        Me.dgvPredios.Name = "dgvPredios"
        Me.dgvPredios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPredios.Size = New System.Drawing.Size(615, 124)
        Me.dgvPredios.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "FOTO IDENTIDAD"
        '
        'dgvPadron
        '
        Me.dgvPadron.AllowUserToAddRows = False
        Me.dgvPadron.AllowUserToDeleteRows = False
        Me.dgvPadron.AllowUserToResizeRows = False
        Me.dgvPadron.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPadron.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPadron.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPadron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPadron.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPadron.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPadron.Location = New System.Drawing.Point(0, 0)
        Me.dgvPadron.MultiSelect = False
        Me.dgvPadron.Name = "dgvPadron"
        Me.dgvPadron.ReadOnly = True
        Me.dgvPadron.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPadron.Size = New System.Drawing.Size(615, 414)
        Me.dgvPadron.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Linen
        Me.Panel1.Location = New System.Drawing.Point(20, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(163, 134)
        Me.Panel1.TabIndex = 10
        '
        'cboCampana
        '
        Me.cboCampana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampana.FormattingEnabled = True
        Me.cboCampana.Location = New System.Drawing.Point(6, 19)
        Me.cboCampana.Name = "cboCampana"
        Me.cboCampana.Size = New System.Drawing.Size(130, 21)
        Me.cboCampana.TabIndex = 11
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(45, 533)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(113, 37)
        Me.btnEditar.TabIndex = 12
        Me.btnEditar.Text = "EDITAR PREDIO"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnGenXml)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnEditar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1187, 657)
        Me.SplitContainer1.SplitterDistance = 615
        Me.SplitContainer1.TabIndex = 13
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgvPredios)
        Me.SplitContainer2.Size = New System.Drawing.Size(615, 657)
        Me.SplitContainer2.SplitterDistance = 529
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.chkSociedades)
        Me.SplitContainer3.Panel1.Controls.Add(Me.gbxBuscarALumno)
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.dgvPadron)
        Me.SplitContainer3.Size = New System.Drawing.Size(615, 529)
        Me.SplitContainer3.SplitterDistance = 111
        Me.SplitContainer3.TabIndex = 0
        '
        'chkSociedades
        '
        Me.chkSociedades.AutoSize = True
        Me.chkSociedades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSociedades.Location = New System.Drawing.Point(17, 83)
        Me.chkSociedades.Name = "chkSociedades"
        Me.chkSociedades.Size = New System.Drawing.Size(146, 20)
        Me.chkSociedades.TabIndex = 0
        Me.chkSociedades.Text = "Buscar Sociedades"
        Me.chkSociedades.UseVisualStyleBackColor = True
        '
        'gbxBuscarALumno
        '
        Me.gbxBuscarALumno.BackColor = System.Drawing.SystemColors.Control
        Me.gbxBuscarALumno.Controls.Add(Me.txtIdentidad)
        Me.gbxBuscarALumno.Controls.Add(Me.btnPreview)
        Me.gbxBuscarALumno.Controls.Add(Me.txtNombres)
        Me.gbxBuscarALumno.Location = New System.Drawing.Point(7, 28)
        Me.gbxBuscarALumno.Name = "gbxBuscarALumno"
        Me.gbxBuscarALumno.Size = New System.Drawing.Size(438, 43)
        Me.gbxBuscarALumno.TabIndex = 205
        Me.gbxBuscarALumno.TabStop = False
        Me.gbxBuscarALumno.Text = "BUSCAR PERSONA"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(10, 16)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(94, 20)
        Me.txtIdentidad.TabIndex = 196
        '
        'btnPreview
        '
        Me.btnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPreview.Location = New System.Drawing.Point(396, 15)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(35, 23)
        Me.btnPreview.TabIndex = 195
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(110, 16)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(280, 21)
        Me.txtNombres.TabIndex = 193
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboCampana)
        Me.GroupBox1.Location = New System.Drawing.Point(451, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 50)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CAMPAÑA"
        '
        'btnGenXml
        '
        Me.btnGenXml.Location = New System.Drawing.Point(45, 589)
        Me.btnGenXml.Name = "btnGenXml"
        Me.btnGenXml.Size = New System.Drawing.Size(113, 31)
        Me.btnGenXml.TabIndex = 13
        Me.btnGenXml.Text = "GENERA XML"
        Me.btnGenXml.UseVisualStyleBackColor = True
        '
        'dgvPersona
        '
        Me.dgvPersona.AllowUserToAddRows = False
        Me.dgvPersona.AllowUserToDeleteRows = False
        Me.dgvPersona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPersona.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvPersona.BackgroundColor = System.Drawing.Color.LightBlue
        Me.dgvPersona.ColumnHeadersVisible = False
        Me.dgvPersona.Location = New System.Drawing.Point(30, 72)
        Me.dgvPersona.MultiSelect = False
        Me.dgvPersona.Name = "dgvPersona"
        Me.dgvPersona.ReadOnly = True
        Me.dgvPersona.RowHeadersVisible = False
        Me.dgvPersona.Size = New System.Drawing.Size(381, 5)
        Me.dgvPersona.TabIndex = 206
        Me.dgvPersona.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1187, 25)
        Me.lblTitulo.TabIndex = 29
        Me.lblTitulo.Text = "CONSULTAS DE PREDIO"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmPrediosPadron
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 657)
        Me.Controls.Add(Me.dgvPersona)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmPrediosPadron"
        Me.Text = "FrmPrediosPersona"
        CType(Me.dgvPredios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPadron, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.gbxBuscarALumno.ResumeLayout(False)
        Me.gbxBuscarALumno.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPredios As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvPadron As System.Windows.Forms.DataGridView
    Friend WithEvents cboCampana As System.Windows.Forms.ComboBox
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dgvPersona As System.Windows.Forms.DataGridView
    Friend WithEvents gbxBuscarALumno As System.Windows.Forms.GroupBox
    Friend WithEvents txtIdentidad As System.Windows.Forms.TextBox
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnGenXml As System.Windows.Forms.Button
    Friend WithEvents chkSociedades As System.Windows.Forms.CheckBox
End Class
