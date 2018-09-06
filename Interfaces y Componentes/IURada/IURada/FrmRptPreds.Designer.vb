<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMBUSQUEDABACKUP1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMBUSQUEDABACKUP1))
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cboCanalPrincipal = New System.Windows.Forms.ComboBox()
        Me.cboCR = New System.Windows.Forms.ComboBox()
        Me.cboCampaña = New System.Windows.Forms.ComboBox()
        Me.rbUsers = New System.Windows.Forms.RadioButton()
        Me.rbBloques = New System.Windows.Forms.RadioButton()
        Me.rbCanal = New System.Windows.Forms.RadioButton()
        Me.splPrincipal = New System.Windows.Forms.SplitContainer()
        Me.gbxCanales = New System.Windows.Forms.GroupBox()
        Me.chkTodosCanales = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCanales = New System.Windows.Forms.ComboBox()
        Me.cboTamArbol = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnData = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.gbxTipo = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cboTipoRpt = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.button3 = New System.Windows.Forms.Button()
        Me.chkTodasCom = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.splSecundario = New System.Windows.Forms.SplitContainer()
        Me.btnSlider = New System.Windows.Forms.PictureBox()
        Me.crvFinal = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.lblTitulo = New System.Windows.Forms.Label()
        CType(Me.splPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splPrincipal.Panel1.SuspendLayout()
        Me.splPrincipal.Panel2.SuspendLayout()
        Me.splPrincipal.SuspendLayout()
        Me.gbxCanales.SuspendLayout()
        Me.gbxTipo.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.splSecundario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splSecundario.Panel1.SuspendLayout()
        Me.splSecundario.Panel2.SuspendLayout()
        Me.splSecundario.SuspendLayout()
        CType(Me.btnSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(61, 20)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(141, 21)
        Me.TextBox2.TabIndex = 23
        '
        'cboCanalPrincipal
        '
        Me.cboCanalPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCanalPrincipal.FormattingEnabled = True
        Me.cboCanalPrincipal.Location = New System.Drawing.Point(6, 20)
        Me.cboCanalPrincipal.Name = "cboCanalPrincipal"
        Me.cboCanalPrincipal.Size = New System.Drawing.Size(49, 21)
        Me.cboCanalPrincipal.TabIndex = 20
        '
        'cboCR
        '
        Me.cboCR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCR.FormattingEnabled = True
        Me.cboCR.Location = New System.Drawing.Point(57, 19)
        Me.cboCR.Name = "cboCR"
        Me.cboCR.Size = New System.Drawing.Size(152, 21)
        Me.cboCR.TabIndex = 16
        '
        'cboCampaña
        '
        Me.cboCampaña.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampaña.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCampaña.FormattingEnabled = True
        Me.cboCampaña.Location = New System.Drawing.Point(54, 19)
        Me.cboCampaña.Name = "cboCampaña"
        Me.cboCampaña.Size = New System.Drawing.Size(209, 21)
        Me.cboCampaña.TabIndex = 15
        '
        'rbUsers
        '
        Me.rbUsers.AutoSize = True
        Me.rbUsers.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbUsers.Location = New System.Drawing.Point(10, 55)
        Me.rbUsers.Name = "rbUsers"
        Me.rbUsers.Size = New System.Drawing.Size(101, 17)
        Me.rbUsers.TabIndex = 26
        Me.rbUsers.Text = "POR USUARIOS"
        Me.rbUsers.UseVisualStyleBackColor = True
        '
        'rbBloques
        '
        Me.rbBloques.AutoSize = True
        Me.rbBloques.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBloques.Location = New System.Drawing.Point(10, 38)
        Me.rbBloques.Name = "rbBloques"
        Me.rbBloques.Size = New System.Drawing.Size(95, 17)
        Me.rbBloques.TabIndex = 25
        Me.rbBloques.Text = "POR BLOQUES"
        Me.rbBloques.UseVisualStyleBackColor = True
        '
        'rbCanal
        '
        Me.rbCanal.AutoSize = True
        Me.rbCanal.Checked = True
        Me.rbCanal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCanal.Location = New System.Drawing.Point(11, 21)
        Me.rbCanal.Name = "rbCanal"
        Me.rbCanal.Size = New System.Drawing.Size(82, 17)
        Me.rbCanal.TabIndex = 24
        Me.rbCanal.TabStop = True
        Me.rbCanal.Text = "POR CANAL"
        Me.rbCanal.UseVisualStyleBackColor = True
        '
        'splPrincipal
        '
        Me.splPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splPrincipal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splPrincipal.Location = New System.Drawing.Point(0, 21)
        Me.splPrincipal.Name = "splPrincipal"
        '
        'splPrincipal.Panel1
        '
        Me.splPrincipal.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.splPrincipal.Panel1.Controls.Add(Me.gbxCanales)
        Me.splPrincipal.Panel1.Controls.Add(Me.Panel4)
        Me.splPrincipal.Panel1.Controls.Add(Me.btnData)
        Me.splPrincipal.Panel1.Controls.Add(Me.Panel2)
        Me.splPrincipal.Panel1.Controls.Add(Me.Panel1)
        Me.splPrincipal.Panel1.Controls.Add(Me.Button1)
        Me.splPrincipal.Panel1.Controls.Add(Me.btnExportar)
        Me.splPrincipal.Panel1.Controls.Add(Me.gbxTipo)
        Me.splPrincipal.Panel1.Controls.Add(Me.GroupBox4)
        Me.splPrincipal.Panel1.Controls.Add(Me.GroupBox3)
        Me.splPrincipal.Panel1.Controls.Add(Me.GroupBox2)
        Me.splPrincipal.Panel1.Controls.Add(Me.GroupBox1)
        '
        'splPrincipal.Panel2
        '
        Me.splPrincipal.Panel2.Controls.Add(Me.splSecundario)
        Me.splPrincipal.Size = New System.Drawing.Size(1156, 528)
        Me.splPrincipal.SplitterDistance = 294
        Me.splPrincipal.TabIndex = 32
        '
        'gbxCanales
        '
        Me.gbxCanales.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.gbxCanales.Controls.Add(Me.chkTodosCanales)
        Me.gbxCanales.Controls.Add(Me.Label2)
        Me.gbxCanales.Controls.Add(Me.Label1)
        Me.gbxCanales.Controls.Add(Me.cboCanales)
        Me.gbxCanales.Controls.Add(Me.cboTamArbol)
        Me.gbxCanales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gbxCanales.ForeColor = System.Drawing.Color.White
        Me.gbxCanales.Location = New System.Drawing.Point(8, 292)
        Me.gbxCanales.Name = "gbxCanales"
        Me.gbxCanales.Size = New System.Drawing.Size(279, 88)
        Me.gbxCanales.TabIndex = 134
        Me.gbxCanales.TabStop = False
        Me.gbxCanales.Text = "Canales"
        '
        'chkTodosCanales
        '
        Me.chkTodosCanales.AutoSize = True
        Me.chkTodosCanales.Location = New System.Drawing.Point(200, 69)
        Me.chkTodosCanales.Name = "chkTodosCanales"
        Me.chkTodosCanales.Size = New System.Drawing.Size(60, 17)
        Me.chkTodosCanales.TabIndex = 129
        Me.chkTodosCanales.Text = "Todos"
        Me.chkTodosCanales.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Canal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Tipo"
        '
        'cboCanales
        '
        Me.cboCanales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCanales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCanales.FormattingEnabled = True
        Me.cboCanales.Location = New System.Drawing.Point(53, 42)
        Me.cboCanales.Name = "cboCanales"
        Me.cboCanales.Size = New System.Drawing.Size(207, 21)
        Me.cboCanales.TabIndex = 17
        '
        'cboTamArbol
        '
        Me.cboTamArbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTamArbol.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTamArbol.FormattingEnabled = True
        Me.cboTamArbol.Items.AddRange(New Object() {"PRINCIPALES", "TODOS"})
        Me.cboTamArbol.Location = New System.Drawing.Point(54, 13)
        Me.cboTamArbol.Name = "cboTamArbol"
        Me.cboTamArbol.Size = New System.Drawing.Size(206, 21)
        Me.cboTamArbol.TabIndex = 16
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(-1, 396)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 35)
        Me.Panel4.TabIndex = 132
        Me.Panel4.Visible = False
        '
        'btnData
        '
        Me.btnData.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnData.FlatAppearance.BorderSize = 0
        Me.btnData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnData.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnData.ForeColor = System.Drawing.Color.White
        Me.btnData.Image = CType(resources.GetObject("btnData.Image"), System.Drawing.Image)
        Me.btnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnData.Location = New System.Drawing.Point(-1, 394)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(286, 38)
        Me.btnData.TabIndex = 133
        Me.btnData.Text = "Data"
        Me.btnData.UseVisualStyleBackColor = False
        Me.btnData.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 477)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 35)
        Me.Panel2.TabIndex = 131
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 437)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 35)
        Me.Panel1.TabIndex = 128
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 435)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(286, 38)
        Me.Button1.TabIndex = 130
        Me.Button1.Text = "REPORTE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExportar.FlatAppearance.BorderSize = 0
        Me.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.ForeColor = System.Drawing.Color.White
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(3, 474)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(283, 38)
        Me.btnExportar.TabIndex = 129
        Me.btnExportar.Text = "EXPORTAR"
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'gbxTipo
        '
        Me.gbxTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.gbxTipo.Controls.Add(Me.Button4)
        Me.gbxTipo.Controls.Add(Me.cboTipoRpt)
        Me.gbxTipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gbxTipo.ForeColor = System.Drawing.Color.White
        Me.gbxTipo.Location = New System.Drawing.Point(6, 231)
        Me.gbxTipo.Name = "gbxTipo"
        Me.gbxTipo.Size = New System.Drawing.Size(279, 48)
        Me.gbxTipo.TabIndex = 127
        Me.gbxTipo.TabStop = False
        Me.gbxTipo.Text = "Tipo Reporte"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(6, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(45, 29)
        Me.Button4.TabIndex = 131
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'cboTipoRpt
        '
        Me.cboTipoRpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoRpt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoRpt.FormattingEnabled = True
        Me.cboTipoRpt.Items.AddRange(New Object() {"DETALLADO", "LATERALES Y CANALES", "CANALES PRINCIPALES"})
        Me.cboTipoRpt.Location = New System.Drawing.Point(56, 20)
        Me.cboTipoRpt.Name = "cboTipoRpt"
        Me.cboTipoRpt.Size = New System.Drawing.Size(206, 21)
        Me.cboTipoRpt.TabIndex = 16
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.rbUsers)
        Me.GroupBox4.Controls.Add(Me.rbCanal)
        Me.GroupBox4.Controls.Add(Me.rbBloques)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(5, 139)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(280, 78)
        Me.GroupBox4.TabIndex = 125
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reporte"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboCanalPrincipal)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(982, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(37, 32)
        Me.GroupBox3.TabIndex = 124
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Canal"
        Me.GroupBox3.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.button3)
        Me.GroupBox2.Controls.Add(Me.chkTodasCom)
        Me.GroupBox2.Controls.Add(Me.cboCR)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(5, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(282, 48)
        Me.GroupBox2.TabIndex = 123
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Comision Regante"
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.button3.FlatAppearance.BorderSize = 0
        Me.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.White
        Me.button3.Image = CType(resources.GetObject("button3.Image"), System.Drawing.Image)
        Me.button3.Location = New System.Drawing.Point(2, 13)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(48, 29)
        Me.button3.TabIndex = 129
        Me.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button3.UseVisualStyleBackColor = False
        '
        'chkTodasCom
        '
        Me.chkTodasCom.AutoSize = True
        Me.chkTodasCom.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodasCom.Location = New System.Drawing.Point(217, 25)
        Me.chkTodasCom.Name = "chkTodasCom"
        Me.chkTodasCom.Size = New System.Drawing.Size(60, 15)
        Me.chkTodasCom.TabIndex = 128
        Me.chkTodasCom.Text = "TODAS"
        Me.chkTodasCom.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.cboCampaña)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(5, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 48)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Campaña"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(5, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 29)
        Me.Button2.TabIndex = 130
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'splSecundario
        '
        Me.splSecundario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splSecundario.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splSecundario.Location = New System.Drawing.Point(0, 0)
        Me.splSecundario.Name = "splSecundario"
        Me.splSecundario.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splSecundario.Panel1
        '
        Me.splSecundario.Panel1.Controls.Add(Me.btnSlider)
        '
        'splSecundario.Panel2
        '
        Me.splSecundario.Panel2.Controls.Add(Me.crvFinal)
        Me.splSecundario.Size = New System.Drawing.Size(858, 528)
        Me.splSecundario.SplitterDistance = 34
        Me.splSecundario.TabIndex = 1
        '
        'btnSlider
        '
        Me.btnSlider.BackgroundImage = CType(resources.GetObject("btnSlider.BackgroundImage"), System.Drawing.Image)
        Me.btnSlider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSlider.Location = New System.Drawing.Point(0, 0)
        Me.btnSlider.Name = "btnSlider"
        Me.btnSlider.Size = New System.Drawing.Size(50, 32)
        Me.btnSlider.TabIndex = 1
        Me.btnSlider.TabStop = False
        '
        'crvFinal
        '
        Me.crvFinal.ActiveViewIndex = -1
        Me.crvFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvFinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvFinal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvFinal.Location = New System.Drawing.Point(0, 0)
        Me.crvFinal.Name = "crvFinal"
        Me.crvFinal.Size = New System.Drawing.Size(858, 490)
        Me.crvFinal.TabIndex = 0
        Me.crvFinal.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1156, 21)
        Me.lblTitulo.TabIndex = 31
        Me.lblTitulo.Text = "REPORTES R.A.D.A"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FRMBUSQUEDABACKUP1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 549)
        Me.Controls.Add(Me.splPrincipal)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "FRMBUSQUEDABACKUP1"
        Me.Text = "Form1"
        Me.splPrincipal.Panel1.ResumeLayout(False)
        Me.splPrincipal.Panel2.ResumeLayout(False)
        CType(Me.splPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splPrincipal.ResumeLayout(False)
        Me.gbxCanales.ResumeLayout(False)
        Me.gbxCanales.PerformLayout()
        Me.gbxTipo.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.splSecundario.Panel1.ResumeLayout(False)
        Me.splSecundario.Panel2.ResumeLayout(False)
        CType(Me.splSecundario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splSecundario.ResumeLayout(False)
        CType(Me.btnSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents cboCanalPrincipal As System.Windows.Forms.ComboBox
    Friend WithEvents cboCR As System.Windows.Forms.ComboBox
    Friend WithEvents cboCampaña As System.Windows.Forms.ComboBox
    Friend WithEvents rbUsers As System.Windows.Forms.RadioButton
    Friend WithEvents rbBloques As System.Windows.Forms.RadioButton
    Friend WithEvents rbCanal As System.Windows.Forms.RadioButton
    Friend WithEvents splPrincipal As System.Windows.Forms.SplitContainer
    Friend WithEvents crvFinal As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbxTipo As System.Windows.Forms.GroupBox
    Friend WithEvents cboTipoRpt As System.Windows.Forms.ComboBox
    Friend WithEvents chkTodasCom As System.Windows.Forms.CheckBox
    Private WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents btnData As System.Windows.Forms.Button
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents splSecundario As System.Windows.Forms.SplitContainer
    Friend WithEvents btnSlider As System.Windows.Forms.PictureBox
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents gbxCanales As System.Windows.Forms.GroupBox
    Friend WithEvents cboTamArbol As System.Windows.Forms.ComboBox
    Friend WithEvents cboCanales As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkTodosCanales As System.Windows.Forms.CheckBox
End Class
