<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrediosUniCat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrediosUniCat))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.btnPrevie = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtUC = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboCampana = New System.Windows.Forms.ComboBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.dgvPredios = New System.Windows.Forms.DataGridView()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvPredios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox10.Controls.Add(Me.btnPrevie)
        Me.GroupBox10.Controls.Add(Me.GroupBox2)
        Me.GroupBox10.Controls.Add(Me.GroupBox1)
        Me.GroupBox10.ForeColor = System.Drawing.Color.Indigo
        Me.GroupBox10.Location = New System.Drawing.Point(17, 6)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(879, 67)
        Me.GroupBox10.TabIndex = 138
        Me.GroupBox10.TabStop = False
        '
        'btnPrevie
        '
        Me.btnPrevie.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnPrevie.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPrevie.FlatAppearance.BorderSize = 0
        Me.btnPrevie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnPrevie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevie.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevie.ForeColor = System.Drawing.Color.White
        Me.btnPrevie.Image = CType(resources.GetObject("btnPrevie.Image"), System.Drawing.Image)
        Me.btnPrevie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrevie.Location = New System.Drawing.Point(760, 17)
        Me.btnPrevie.Name = "btnPrevie"
        Me.btnPrevie.Size = New System.Drawing.Size(104, 38)
        Me.btnPrevie.TabIndex = 199
        Me.btnPrevie.Text = "BUSCAR"
        Me.btnPrevie.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrevie.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtUC)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(170, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(149, 50)
        Me.GroupBox2.TabIndex = 198
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "UNIDAD CATASTRAL"
        '
        'txtUC
        '
        Me.txtUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUC.Location = New System.Drawing.Point(6, 20)
        Me.txtUC.Name = "txtUC"
        Me.txtUC.Size = New System.Drawing.Size(137, 20)
        Me.txtUC.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboCampana)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(6, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 50)
        Me.GroupBox1.TabIndex = 197
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CAMPAÑA"
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
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(914, 25)
        Me.lblTitulo.TabIndex = 139
        Me.lblTitulo.Text = "BUSQUEDA POR UNIDAD CATASTRAL"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvPredios)
        Me.SplitContainer1.Size = New System.Drawing.Size(914, 328)
        Me.SplitContainer1.SplitterDistance = 80
        Me.SplitContainer1.TabIndex = 140
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnEditar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(914, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnEditar
        '
        Me.tsbtnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tsbtnEditar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbtnEditar.ForeColor = System.Drawing.Color.White
        Me.tsbtnEditar.Image = CType(resources.GetObject("tsbtnEditar.Image"), System.Drawing.Image)
        Me.tsbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEditar.Name = "tsbtnEditar"
        Me.tsbtnEditar.Size = New System.Drawing.Size(69, 22)
        Me.tsbtnEditar.Text = "EDITAR"
        '
        'dgvPredios
        '
        Me.dgvPredios.AllowUserToAddRows = False
        Me.dgvPredios.AllowUserToDeleteRows = False
        Me.dgvPredios.AllowUserToOrderColumns = True
        Me.dgvPredios.AllowUserToResizeRows = False
        Me.dgvPredios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPredios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dgvPredios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPredios.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPredios.Location = New System.Drawing.Point(0, 28)
        Me.dgvPredios.MultiSelect = False
        Me.dgvPredios.Name = "dgvPredios"
        Me.dgvPredios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPredios.Size = New System.Drawing.Size(914, 216)
        Me.dgvPredios.TabIndex = 9
        '
        'FrmPrediosUniCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 353)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lblTitulo)
        Me.MaximizeBox = False
        Me.Name = "FrmPrediosUniCat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPrediosUniCat"
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvPredios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUC As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCampana As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents btnPrevie As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvPredios As System.Windows.Forms.DataGridView
End Class
