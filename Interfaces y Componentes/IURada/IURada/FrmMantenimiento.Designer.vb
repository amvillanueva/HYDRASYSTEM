<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimiento))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtidPredio = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboCampana = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboCR = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCanal = New System.Windows.Forms.ComboBox()
        Me.cbBLoque = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtCodSara = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtNumPredio = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtNombrePredio = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtUC = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAreaTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBajoRiego = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFiltr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPerm = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLic = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtHR = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtOR = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtVolumenA = New System.Windows.Forms.TextBox()
        Me.dtpFechaRes = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtResolucion = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpNUEVOFechaRes = New System.Windows.Forms.DateTimePicker()
        Me.cboCampañaActualziar = New System.Windows.Forms.ComboBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.cboEsActivo = New System.Windows.Forms.ComboBox()
        Me.cboEsSancionado = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cboEsnuevo = New System.Windows.Forms.ComboBox()
        Me.splPrincipal = New System.Windows.Forms.SplitContainer()
        Me.btmSave = New System.Windows.Forms.Button()
        Me.dgvDatosPredio = New System.Windows.Forms.DataGridView()
        Me.btnPrevie = New System.Windows.Forms.Button()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboTipoDocuser = New System.Windows.Forms.ComboBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtContribuyente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvPersona = New System.Windows.Forms.DataGridView()
        Me.txtComite = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.splPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splPrincipal.Panel1.SuspendLayout()
        Me.splPrincipal.Panel2.SuspendLayout()
        Me.splPrincipal.SuspendLayout()
        CType(Me.dgvDatosPredio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.AliceBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(835, 27)
        Me.lblTitulo.TabIndex = 30
        Me.lblTitulo.Text = "MANTENIMIENTO DE PREDIO"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtidPredio
        '
        Me.txtidPredio.Location = New System.Drawing.Point(6, 19)
        Me.txtidPredio.Name = "txtidPredio"
        Me.txtidPredio.Size = New System.Drawing.Size(100, 20)
        Me.txtidPredio.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboCampana)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(16, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 50)
        Me.GroupBox1.TabIndex = 127
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboCR)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(171, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(194, 50)
        Me.GroupBox2.TabIndex = 128
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "COMISION DE REGANTES"
        '
        'cboCR
        '
        Me.cboCR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCR.FormattingEnabled = True
        Me.cboCR.Location = New System.Drawing.Point(6, 19)
        Me.cboCR.Name = "cboCR"
        Me.cboCR.Size = New System.Drawing.Size(182, 21)
        Me.cboCR.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtidPredio)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(381, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(120, 50)
        Me.GroupBox3.TabIndex = 129
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ID PREDIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "CD/Canal/Lateral"
        '
        'cbCanal
        '
        Me.cbCanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCanal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCanal.FormattingEnabled = True
        Me.cbCanal.Location = New System.Drawing.Point(146, 18)
        Me.cbCanal.Name = "cbCanal"
        Me.cbCanal.Size = New System.Drawing.Size(246, 20)
        Me.cbCanal.TabIndex = 131
        '
        'cbBLoque
        '
        Me.cbBLoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBLoque.Enabled = False
        Me.cbBLoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBLoque.FormattingEnabled = True
        Me.cbBLoque.Location = New System.Drawing.Point(146, 45)
        Me.cbBLoque.Name = "cbBLoque"
        Me.cbBLoque.Size = New System.Drawing.Size(246, 20)
        Me.cbBLoque.TabIndex = 132
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Bloque de Riego:  "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox10)
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(22, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(794, 226)
        Me.GroupBox5.TabIndex = 134
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "PREDIOS"
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox10.Controls.Add(Me.Label29)
        Me.GroupBox10.Controls.Add(Me.txtCodSara)
        Me.GroupBox10.Controls.Add(Me.Label28)
        Me.GroupBox10.Controls.Add(Me.txtNumPredio)
        Me.GroupBox10.Controls.Add(Me.Label31)
        Me.GroupBox10.Controls.Add(Me.txtNombrePredio)
        Me.GroupBox10.Controls.Add(Me.Label32)
        Me.GroupBox10.Controls.Add(Me.txtUC)
        Me.GroupBox10.ForeColor = System.Drawing.Color.Indigo
        Me.GroupBox10.Location = New System.Drawing.Point(7, 16)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(773, 46)
        Me.GroupBox10.TabIndex = 136
        Me.GroupBox10.TabStop = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(628, 17)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(75, 13)
        Me.Label29.TabIndex = 42
        Me.Label29.Text = "Codigo SARA:"
        Me.Label29.Visible = False
        '
        'txtCodSara
        '
        Me.txtCodSara.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodSara.Location = New System.Drawing.Point(709, 14)
        Me.txtCodSara.Name = "txtCodSara"
        Me.txtCodSara.Size = New System.Drawing.Size(53, 20)
        Me.txtCodSara.TabIndex = 41
        Me.txtCodSara.Visible = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(533, 17)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(47, 13)
        Me.Label28.TabIndex = 40
        Me.Label28.Text = "Numero:"
        Me.Label28.Visible = False
        '
        'txtNumPredio
        '
        Me.txtNumPredio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumPredio.Location = New System.Drawing.Point(585, 14)
        Me.txtNumPredio.Name = "txtNumPredio"
        Me.txtNumPredio.Size = New System.Drawing.Size(42, 20)
        Me.txtNumPredio.TabIndex = 39
        Me.txtNumPredio.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(259, 17)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(47, 13)
        Me.Label31.TabIndex = 38
        Me.Label31.Text = "Nombre:"
        '
        'txtNombrePredio
        '
        Me.txtNombrePredio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePredio.Location = New System.Drawing.Point(312, 14)
        Me.txtNombrePredio.Name = "txtNombrePredio"
        Me.txtNombrePredio.Size = New System.Drawing.Size(256, 20)
        Me.txtNombrePredio.TabIndex = 37
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(10, 17)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 13)
        Me.Label32.TabIndex = 36
        Me.Label32.Text = "Unidad Catastral:"
        '
        'txtUC
        '
        Me.txtUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUC.Location = New System.Drawing.Point(104, 14)
        Me.txtUC.Name = "txtUC"
        Me.txtUC.Size = New System.Drawing.Size(100, 20)
        Me.txtUC.TabIndex = 33
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.txtAreaTotal)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.txtBajoRiego)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.txtFiltr)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.txtPerm)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.txtLic)
        Me.GroupBox7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox7.Location = New System.Drawing.Point(14, 69)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(356, 149)
        Me.GroupBox7.TabIndex = 135
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Areas o Superficie"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(24, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Total:"
        '
        'txtAreaTotal
        '
        Me.txtAreaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAreaTotal.Location = New System.Drawing.Point(103, 125)
        Me.txtAreaTotal.Name = "txtAreaTotal"
        Me.txtAreaTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtAreaTotal.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(24, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Bajo Riego:"
        '
        'txtBajoRiego
        '
        Me.txtBajoRiego.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBajoRiego.Location = New System.Drawing.Point(103, 99)
        Me.txtBajoRiego.Name = "txtBajoRiego"
        Me.txtBajoRiego.Size = New System.Drawing.Size(100, 20)
        Me.txtBajoRiego.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(24, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Filtracion:"
        '
        'txtFiltr
        '
        Me.txtFiltr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltr.Location = New System.Drawing.Point(103, 71)
        Me.txtFiltr.Name = "txtFiltr"
        Me.txtFiltr.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltr.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Permiso:"
        '
        'txtPerm
        '
        Me.txtPerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerm.Location = New System.Drawing.Point(103, 45)
        Me.txtPerm.Name = "txtPerm"
        Me.txtPerm.Size = New System.Drawing.Size(100, 20)
        Me.txtPerm.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(25, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Licencia:"
        '
        'txtLic
        '
        Me.txtLic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLic.Location = New System.Drawing.Point(103, 18)
        Me.txtLic.Name = "txtLic"
        Me.txtLic.Size = New System.Drawing.Size(100, 20)
        Me.txtLic.TabIndex = 33
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox6.Controls.Add(Me.txtComite)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.txtHR)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.txtOR)
        Me.GroupBox6.Controls.Add(Me.ComboBox4)
        Me.GroupBox6.Controls.Add(Me.cbCanal)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.ComboBox3)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.cbBLoque)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox6.Location = New System.Drawing.Point(379, 68)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(401, 150)
        Me.GroupBox6.TabIndex = 134
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Ubicacion Geografica"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(291, 77)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(40, 13)
        Me.Label27.TabIndex = 143
        Me.Label27.Text = "Toma: "
        Me.Label27.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(14, 103)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 13)
        Me.Label15.TabIndex = 139
        Me.Label15.Text = "Horas de Riego: "
        '
        'txtHR
        '
        Me.txtHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHR.Location = New System.Drawing.Point(149, 100)
        Me.txtHR.Name = "txtHR"
        Me.txtHR.Size = New System.Drawing.Size(125, 20)
        Me.txtHR.TabIndex = 138
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(14, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 137
        Me.Label14.Text = "Orden de Riego: "
        '
        'txtOR
        '
        Me.txtOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOR.Location = New System.Drawing.Point(149, 74)
        Me.txtOR.Name = "txtOR"
        Me.txtOR.Size = New System.Drawing.Size(125, 20)
        Me.txtOR.TabIndex = 136
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(-238, 32)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(233, 23)
        Me.ComboBox4.TabIndex = 131
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-397, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 16)
        Me.Label7.TabIndex = 133
        Me.Label7.Text = "BLOQUE DE RIEGO:  "
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(-238, 59)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(233, 23)
        Me.ComboBox3.TabIndex = 132
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-397, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 16)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "CD/ CANAL/ LATERAL: "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(280, 71)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 13)
        Me.Label17.TabIndex = 142
        Me.Label17.Text = "m3"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(15, 71)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 13)
        Me.Label16.TabIndex = 141
        Me.Label16.Text = "Volumen Anual: "
        '
        'txtVolumenA
        '
        Me.txtVolumenA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolumenA.Location = New System.Drawing.Point(140, 67)
        Me.txtVolumenA.Name = "txtVolumenA"
        Me.txtVolumenA.Size = New System.Drawing.Size(125, 20)
        Me.txtVolumenA.TabIndex = 140
        '
        'dtpFechaRes
        '
        Me.dtpFechaRes.Enabled = False
        Me.dtpFechaRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaRes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRes.Location = New System.Drawing.Point(248, 38)
        Me.dtpFechaRes.Name = "dtpFechaRes"
        Me.dtpFechaRes.Size = New System.Drawing.Size(109, 21)
        Me.dtpFechaRes.TabIndex = 48
        Me.dtpFechaRes.Value = New Date(2018, 3, 15, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(247, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 13)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Fecha de resolucion:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(9, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Resolucion:"
        '
        'txtResolucion
        '
        Me.txtResolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResolucion.Location = New System.Drawing.Point(12, 39)
        Me.txtResolucion.Name = "txtResolucion"
        Me.txtResolucion.Size = New System.Drawing.Size(213, 20)
        Me.txtResolucion.TabIndex = 45
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox8.Controls.Add(Me.Label17)
        Me.GroupBox8.Controls.Add(Me.Label16)
        Me.GroupBox8.Controls.Add(Me.txtVolumenA)
        Me.GroupBox8.Controls.Add(Me.dtpFechaRes)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.txtResolucion)
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Black
        Me.GroupBox8.Location = New System.Drawing.Point(29, 230)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(467, 120)
        Me.GroupBox8.TabIndex = 148
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "DOCUMENTO QUE OTORGA EL DERECHO"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(209, 74)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 13)
        Me.Label22.TabIndex = 53
        Me.Label22.Text = "Predio:"
        Me.Label22.Visible = False
        '
        'TextBox13
        '
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(211, 91)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(82, 20)
        Me.TextBox13.TabIndex = 50
        Me.TextBox13.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(93, 74)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(75, 13)
        Me.Label23.TabIndex = 54
        Me.Label23.Text = "Nueva Fecha:"
        Me.Label23.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(24, 74)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 13)
        Me.Label21.TabIndex = 52
        Me.Label21.Text = "Campaña:"
        Me.Label21.Visible = False
        '
        'dtpNUEVOFechaRes
        '
        Me.dtpNUEVOFechaRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNUEVOFechaRes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNUEVOFechaRes.Location = New System.Drawing.Point(96, 85)
        Me.dtpNUEVOFechaRes.Name = "dtpNUEVOFechaRes"
        Me.dtpNUEVOFechaRes.Size = New System.Drawing.Size(109, 21)
        Me.dtpNUEVOFechaRes.TabIndex = 51
        Me.dtpNUEVOFechaRes.Value = New Date(2018, 3, 15, 0, 0, 0, 0)
        Me.dtpNUEVOFechaRes.Visible = False
        '
        'cboCampañaActualziar
        '
        Me.cboCampañaActualziar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampañaActualziar.FormattingEnabled = True
        Me.cboCampañaActualziar.Location = New System.Drawing.Point(27, 90)
        Me.cboCampañaActualziar.Name = "cboCampañaActualziar"
        Me.cboCampañaActualziar.Size = New System.Drawing.Size(60, 21)
        Me.cboCampañaActualziar.TabIndex = 49
        Me.cboCampañaActualziar.Visible = False
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox9.Controls.Add(Me.Label22)
        Me.GroupBox9.Controls.Add(Me.Label23)
        Me.GroupBox9.Controls.Add(Me.cboEsActivo)
        Me.GroupBox9.Controls.Add(Me.cboEsSancionado)
        Me.GroupBox9.Controls.Add(Me.TextBox13)
        Me.GroupBox9.Controls.Add(Me.Label25)
        Me.GroupBox9.Controls.Add(Me.Label21)
        Me.GroupBox9.Controls.Add(Me.dtpNUEVOFechaRes)
        Me.GroupBox9.Controls.Add(Me.Label24)
        Me.GroupBox9.Controls.Add(Me.Label26)
        Me.GroupBox9.Controls.Add(Me.cboEsnuevo)
        Me.GroupBox9.Controls.Add(Me.cboCampañaActualziar)
        Me.GroupBox9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Black
        Me.GroupBox9.Location = New System.Drawing.Point(502, 230)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(300, 120)
        Me.GroupBox9.TabIndex = 149
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "INDICADORES Y SITUACIONES DEL PREDIO:"
        '
        'cboEsActivo
        '
        Me.cboEsActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEsActivo.FormattingEnabled = True
        Me.cboEsActivo.Items.AddRange(New Object() {"N", "S"})
        Me.cboEsActivo.Location = New System.Drawing.Point(218, 44)
        Me.cboEsActivo.Name = "cboEsActivo"
        Me.cboEsActivo.Size = New System.Drawing.Size(31, 21)
        Me.cboEsActivo.TabIndex = 58
        '
        'cboEsSancionado
        '
        Me.cboEsSancionado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEsSancionado.FormattingEnabled = True
        Me.cboEsSancionado.Items.AddRange(New Object() {"N", "S"})
        Me.cboEsSancionado.Location = New System.Drawing.Point(140, 44)
        Me.cboEsSancionado.Name = "cboEsSancionado"
        Me.cboEsSancionado.Size = New System.Drawing.Size(31, 21)
        Me.cboEsSancionado.TabIndex = 57
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(215, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 13)
        Me.Label25.TabIndex = 56
        Me.Label25.Text = "Activo:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(116, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 13)
        Me.Label24.TabIndex = 54
        Me.Label24.Text = "Sancion/Multa:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(47, 23)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(42, 13)
        Me.Label26.TabIndex = 52
        Me.Label26.Text = "Nuevo:"
        '
        'cboEsnuevo
        '
        Me.cboEsnuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEsnuevo.FormattingEnabled = True
        Me.cboEsnuevo.Items.AddRange(New Object() {"N", "S"})
        Me.cboEsnuevo.Location = New System.Drawing.Point(54, 44)
        Me.cboEsnuevo.Name = "cboEsnuevo"
        Me.cboEsnuevo.Size = New System.Drawing.Size(31, 21)
        Me.cboEsnuevo.TabIndex = 49
        '
        'splPrincipal
        '
        Me.splPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splPrincipal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splPrincipal.Location = New System.Drawing.Point(0, 27)
        Me.splPrincipal.Name = "splPrincipal"
        Me.splPrincipal.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splPrincipal.Panel1
        '
        Me.splPrincipal.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.splPrincipal.Panel1.Controls.Add(Me.btmSave)
        Me.splPrincipal.Panel1.Controls.Add(Me.dgvDatosPredio)
        Me.splPrincipal.Panel1.Controls.Add(Me.btnPrevie)
        Me.splPrincipal.Panel1.Controls.Add(Me.GroupBox1)
        Me.splPrincipal.Panel1.Controls.Add(Me.GroupBox2)
        Me.splPrincipal.Panel1.Controls.Add(Me.GroupBox3)
        Me.splPrincipal.Panel1.ForeColor = System.Drawing.Color.White
        '
        'splPrincipal.Panel2
        '
        Me.splPrincipal.Panel2.Controls.Add(Me.txtObservaciones)
        Me.splPrincipal.Panel2.Controls.Add(Me.Label20)
        Me.splPrincipal.Panel2.Controls.Add(Me.GroupBox4)
        Me.splPrincipal.Panel2.Controls.Add(Me.GroupBox5)
        Me.splPrincipal.Panel2.Controls.Add(Me.GroupBox9)
        Me.splPrincipal.Panel2.Controls.Add(Me.GroupBox8)
        Me.splPrincipal.Size = New System.Drawing.Size(835, 562)
        Me.splPrincipal.SplitterDistance = 64
        Me.splPrincipal.TabIndex = 197
        '
        'btmSave
        '
        Me.btmSave.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btmSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btmSave.FlatAppearance.BorderSize = 0
        Me.btmSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btmSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmSave.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmSave.ForeColor = System.Drawing.Color.White
        Me.btmSave.Image = CType(resources.GetObject("btmSave.Image"), System.Drawing.Image)
        Me.btmSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btmSave.Location = New System.Drawing.Point(689, 11)
        Me.btmSave.Name = "btmSave"
        Me.btmSave.Size = New System.Drawing.Size(113, 38)
        Me.btmSave.TabIndex = 199
        Me.btmSave.Text = "GUARDAR"
        Me.btmSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btmSave.UseVisualStyleBackColor = False
        '
        'dgvDatosPredio
        '
        Me.dgvDatosPredio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatosPredio.Location = New System.Drawing.Point(522, 21)
        Me.dgvDatosPredio.Name = "dgvDatosPredio"
        Me.dgvDatosPredio.Size = New System.Drawing.Size(11, 28)
        Me.dgvDatosPredio.TabIndex = 198
        Me.dgvDatosPredio.Visible = False
        '
        'btnPrevie
        '
        Me.btnPrevie.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnPrevie.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPrevie.FlatAppearance.BorderSize = 0
        Me.btnPrevie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnPrevie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevie.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevie.ForeColor = System.Drawing.Color.White
        Me.btnPrevie.Image = CType(resources.GetObject("btnPrevie.Image"), System.Drawing.Image)
        Me.btnPrevie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrevie.Location = New System.Drawing.Point(551, 11)
        Me.btnPrevie.Name = "btnPrevie"
        Me.btnPrevie.Size = New System.Drawing.Size(104, 38)
        Me.btnPrevie.TabIndex = 197
        Me.btnPrevie.Text = "BUSCAR"
        Me.btnPrevie.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrevie.UseVisualStyleBackColor = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(35, 445)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(770, 35)
        Me.txtObservaciones.TabIndex = 152
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(34, 429)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 13)
        Me.Label20.TabIndex = 151
        Me.Label20.Text = "Observaciones:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.cboTipoDocuser)
        Me.GroupBox4.Controls.Add(Me.txtDNI)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtContribuyente)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(29, 355)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(780, 67)
        Me.GroupBox4.TabIndex = 150
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "INFORMACION DE USUARIO"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(17, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 145
        Me.Label19.Text = "Tipo:"
        '
        'cboTipoDocuser
        '
        Me.cboTipoDocuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocuser.Enabled = False
        Me.cboTipoDocuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocuser.FormattingEnabled = True
        Me.cboTipoDocuser.Location = New System.Drawing.Point(14, 40)
        Me.cboTipoDocuser.Name = "cboTipoDocuser"
        Me.cboTipoDocuser.Size = New System.Drawing.Size(226, 20)
        Me.cboTipoDocuser.TabIndex = 135
        '
        'txtDNI
        '
        Me.txtDNI.Enabled = False
        Me.txtDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI.Location = New System.Drawing.Point(256, 39)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(95, 20)
        Me.txtDNI.TabIndex = 144
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(381, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(182, 13)
        Me.Label18.TabIndex = 143
        Me.Label18.Text = "Apellidos y Nombres / Razon Social: "
        '
        'txtContribuyente
        '
        Me.txtContribuyente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContribuyente.Location = New System.Drawing.Point(381, 40)
        Me.txtContribuyente.Name = "txtContribuyente"
        Me.txtContribuyente.Size = New System.Drawing.Size(291, 20)
        Me.txtContribuyente.TabIndex = 142
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(258, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Identidad:"
        '
        'dgvPersona
        '
        Me.dgvPersona.AllowUserToAddRows = False
        Me.dgvPersona.AllowUserToDeleteRows = False
        Me.dgvPersona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPersona.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvPersona.BackgroundColor = System.Drawing.Color.LightBlue
        Me.dgvPersona.ColumnHeadersVisible = False
        Me.dgvPersona.Location = New System.Drawing.Point(410, 512)
        Me.dgvPersona.MultiSelect = False
        Me.dgvPersona.Name = "dgvPersona"
        Me.dgvPersona.ReadOnly = True
        Me.dgvPersona.RowHeadersVisible = False
        Me.dgvPersona.Size = New System.Drawing.Size(381, 5)
        Me.dgvPersona.TabIndex = 207
        Me.dgvPersona.Visible = False
        '
        'txtComite
        '
        Me.txtComite.Location = New System.Drawing.Point(337, 95)
        Me.txtComite.Name = "txtComite"
        Me.txtComite.Size = New System.Drawing.Size(33, 21)
        Me.txtComite.TabIndex = 144
        Me.txtComite.Visible = False
        '
        'FrmMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 589)
        Me.Controls.Add(Me.dgvPersona)
        Me.Controls.Add(Me.splPrincipal)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "FrmMantenimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMantenimiento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.splPrincipal.Panel1.ResumeLayout(False)
        Me.splPrincipal.Panel2.ResumeLayout(False)
        Me.splPrincipal.Panel2.PerformLayout()
        CType(Me.splPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splPrincipal.ResumeLayout(False)
        CType(Me.dgvDatosPredio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtidPredio As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCampana As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCR As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCanal As System.Windows.Forms.ComboBox
    Friend WithEvents cbBLoque As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaRes As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtResolucion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAreaTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBajoRiego As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFiltr As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPerm As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtLic As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtVolumenA As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtHR As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtOR As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dtpNUEVOFechaRes As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents cboCampañaActualziar As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cboEsnuevo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtNombrePredio As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtUC As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtCodSara As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtNumPredio As System.Windows.Forms.TextBox
    Friend WithEvents cboEsActivo As System.Windows.Forms.ComboBox
    Friend WithEvents cboEsSancionado As System.Windows.Forms.ComboBox
    Friend WithEvents splPrincipal As System.Windows.Forms.SplitContainer
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocuser As System.Windows.Forms.ComboBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtContribuyente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents btnPrevie As System.Windows.Forms.Button
    Friend WithEvents dgvDatosPredio As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPersona As System.Windows.Forms.DataGridView
    Private WithEvents btmSave As System.Windows.Forms.Button
    Friend WithEvents txtComite As System.Windows.Forms.TextBox
End Class
