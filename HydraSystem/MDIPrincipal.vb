Imports System.Data.SqlClient
Imports HYDRAEntidades
Imports IURada
Imports PoolConexionesHydra

Public Class MDIPrincipal
    Private Sub mniSalir_Click(sender As Object, e As EventArgs) Handles mniSalir.Click
        End
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        End
    End Sub

    Private Sub ReportesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles tsbRADA.Click

    End Sub

    Private Sub mniSeleccionarEmpresa_Click(sender As Object, e As EventArgs) Handles mniSeleccionarEmpresa.Click
        Dim MDIFOrm As New PruebaListarEmpresas
        MDIFOrm.MdiParent = Me
        MDIFOrm.Show()

    End Sub

    Private Sub CerrarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTodoToolStripMenuItem.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub MDIPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim tempconexionbd As String = "Data Source=SYSTEM\HYDRASYSTEM;Initial Catalog=HYDRA-CENTRAL;Persist Security Info=True;User ID=sa;Password=GH_&34trA"

        SesionUsuario.Usuario = "prueba"
        TSQL.ConexionPermanente = New SqlConnection(tempconexionbd)
        SesionUsuario.SesionConexion.BaseDatos = "HYDRA-CENTRAL"
        SesionUsuario.SesionConexion.DsnNombre = ".\HYDRASYSTEM" '"CnnGEAC"
        SesionUsuario.SesionConexion.LoginUser = "sa"
        SesionUsuario.SesionConexion.LoginClave = "GH_&34trA"



    End Sub

    Public Shared Function DataGridViewToDataTable(ByVal dtg As DataGridView, Optional ByVal DataTableName As String = "myDataTable") As DataTable
        Try
            Dim dt As New DataTable(DataTableName)
            Dim row As DataRow
            Dim TotalDatagridviewColumns As Integer = dtg.ColumnCount - 1
            'Add Datacolumn
            For Each c As DataGridViewColumn In dtg.Columns
                Dim idColumn As DataColumn = New DataColumn()
                idColumn.ColumnName = c.Name
                dt.Columns.Add(idColumn)
            Next
            'Now Iterate thru Datagrid and create the data row
            For Each dr As DataGridViewRow In dtg.Rows
                'Iterate thru datagrid
                row = dt.NewRow 'Create new row
                'Iterate thru Column 1 up to the total number of columns
                For cn As Integer = 0 To TotalDatagridviewColumns
                    row.Item(cn) = dr.Cells(cn).Value
                Next
                'Now add the row to Datarow Collection
                dt.Rows.Add(row)
            Next
            'Now return the data table
            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub ReporteTSDB_Click(sender As Object, e As EventArgs) Handles ReporteTSDB.Click
        Dim FrmPersonaPredios As New FRMBUSQUEDABACKUP1
        FrmPersonaPredios.MdiParent = Me
        FrmPersonaPredios.Show()
    End Sub



    Private Sub PrediosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrediosToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs)
        Dim FrmPersonaPredios As New FrmPrediosPadron
        FrmPersonaPredios.MdiParent = Me
        FrmPersonaPredios.Show()
    End Sub

    Private Sub EliminarMatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim FrmPersonaPredios As New FRMBUSQUEDABACKUP1
        FrmPersonaPredios.MdiParent = Me
        FrmPersonaPredios.Show()
    End Sub

    Private Sub PREDIOSToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim FrmPersonaPredios As New FrmMantenimiento
        FrmPersonaPredios.MdiParent = Me
        FrmPersonaPredios.Show()
    End Sub




#Region "diseño y decoracion"

    Private Sub tsbRADA_MouseEnter(sender As Object, e As EventArgs) Handles tsbRADA.MouseEnter
        'MenuRegNuevo.BackColor = Color.FromArgb(70, 70, 70)   'FONDO
        tsbRADA.ForeColor = Color.FromArgb(70, 70, 70)     'COLOR DE LETRA
    End Sub
    Private Sub tsbRADA_MouselEAVE(sender As Object, e As EventArgs) Handles tsbRADA.MouseLeave
        'MenuRegNuevo.BackColor = Color.FromArgb(70, 70, 70)   'FONDO
        tsbRADA.ForeColor = Color.LightSteelBlue      'COLOR DE LETRA
    End Sub
    Private Sub tsbPCR_MouseEnter(sender As Object, e As EventArgs) Handles tsbPCR.MouseEnter
        tsbPCR.ForeColor = Color.FromArgb(70, 70, 70)
    End Sub
    Private Sub tsbPCR_MouselEAVE(sender As Object, e As EventArgs) Handles tsbPCR.MouseLeave
        tsbPCR.ForeColor = Color.LightSteelBlue
    End Sub
    Private Sub tsbProgramacion_MouseEnter(sender As Object, e As EventArgs) Handles tsbProgramacion.MouseEnter
        tsbProgramacion.ForeColor = Color.FromArgb(70, 70, 70)
    End Sub
    Private Sub tsbProgramacion_MouselEAVE(sender As Object, e As EventArgs) Handles tsbProgramacion.MouseLeave
        tsbProgramacion.ForeColor = Color.LightSteelBlue
    End Sub
    Private Sub tsbDistribucion_MouseEnter(sender As Object, e As EventArgs) Handles tsbDistribucion.MouseEnter
        tsbDistribucion.ForeColor = Color.FromArgb(70, 70, 70)
    End Sub
    Private Sub tsbDistribucion_MouselEAVE(sender As Object, e As EventArgs) Handles tsbDistribucion.MouseLeave
        tsbDistribucion.ForeColor = Color.LightSteelBlue
    End Sub
    Private Sub tsbTarifa_MouseEnter(sender As Object, e As EventArgs) Handles tsbTarifa.MouseEnter
        tsbTarifa.ForeColor = Color.FromArgb(70, 70, 70)
    End Sub
    Private Sub tsbTarifa_MouselEAVE(sender As Object, e As EventArgs) Handles tsbTarifa.MouseLeave
        tsbTarifa.ForeColor = Color.LightSteelBlue
    End Sub
    Private Sub tsbUtilidades_MouseEnter(sender As Object, e As EventArgs) Handles tsbUtilidades.MouseEnter
        tsbUtilidades.ForeColor = Color.FromArgb(70, 70, 70)
    End Sub
    Private Sub tsbUtilidades_MouselEAVE(sender As Object, e As EventArgs) Handles tsbUtilidades.MouseLeave
        tsbUtilidades.ForeColor = Color.LightSteelBlue
    End Sub
    Private Sub tsbHidrometria_MouseEnter(sender As Object, e As EventArgs) Handles tsbHidrometria.MouseEnter
        tsbHidrometria.ForeColor = Color.FromArgb(70, 70, 70)
    End Sub
    Private Sub tsbHidrometria_MouselEAVE(sender As Object, e As EventArgs) Handles tsbHidrometria.MouseLeave
        tsbHidrometria.ForeColor = Color.LightSteelBlue
    End Sub
    Private Sub tsbAlmacen_MouseEnter(sender As Object, e As EventArgs) Handles tsbAlmacen.MouseEnter
        tsbAlmacen.ForeColor = Color.FromArgb(70, 70, 70)
    End Sub
    Private Sub tsbAlmacen_MouselEAVE(sender As Object, e As EventArgs) Handles tsbAlmacen.MouseLeave
        tsbAlmacen.ForeColor = Color.LightSteelBlue
    End Sub
    Private Sub tsbAdministracion_MouseEnter(sender As Object, e As EventArgs) Handles tsbAdministracion.MouseEnter
        tsbAdministracion.ForeColor = Color.FromArgb(70, 70, 70)
    End Sub

    Private Sub tsbAdministracion_MouselEAVE(sender As Object, e As EventArgs) Handles tsbAdministracion.MouseLeave
        tsbAdministracion.ForeColor = Color.LightSteelBlue
    End Sub
    Private Sub tsbVer_MouseEnter(sender As Object, e As EventArgs) Handles tsbVer.MouseEnter
        tsbVer.ForeColor = Color.FromArgb(70, 70, 70)
    End Sub
    Private Sub tsbVer_MouselEAVE(sender As Object, e As EventArgs) Handles tsbVer.MouseLeave
        tsbVer.ForeColor = Color.LightSteelBlue
    End Sub
    Private Sub tsbVentana_MouseEnter(sender As Object, e As EventArgs) Handles tsbVentana.MouseEnter
        tsbVentana.ForeColor = Color.FromArgb(70, 70, 70)
    End Sub
    Private Sub tsbVentana_MouselEAVE(sender As Object, e As EventArgs) Handles tsbVentana.MouseLeave
        tsbVentana.ForeColor = Color.LightSteelBlue
    End Sub
    Private Sub tsbSalir_MouseEnter(sender As Object, e As EventArgs) Handles tsbSalir.MouseEnter
        tsbSalir.ForeColor = Color.FromArgb(70, 70, 70)
    End Sub
    Private Sub tsbSalir_MouselEAVE(sender As Object, e As EventArgs) Handles tsbSalir.MouseLeave
        tsbSalir.ForeColor = Color.LightSteelBlue
    End Sub
    Private Sub tsbAyuda_MouseEnter(sender As Object, e As EventArgs) Handles tsbAyuda.MouseEnter
        tsbAyuda.ForeColor = Color.FromArgb(70, 70, 70)
    End Sub
    Private Sub tsbAyuda_MouselEAVE(sender As Object, e As EventArgs) Handles tsbAyuda.MouseLeave
        tsbAyuda.ForeColor = Color.LightSteelBlue
    End Sub

    Private Sub ParticionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParticionesToolStripMenuItem.Click

    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        Dim FrmNuevoPredios As New backupconsultas
        FrmNuevoPredios.MdiParent = Me
        FrmNuevoPredios.Show()
    End Sub

    Private Sub ContribuyenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContribuyenteToolStripMenuItem.Click
        Dim FrmPersonaPredios As New FrmPrediosPadron
        FrmPersonaPredios.MdiParent = Me
        FrmPersonaPredios.Show()
    End Sub

    Private Sub PorUnidadCatastralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorUnidadCatastralToolStripMenuItem.Click
        Dim FrmPersonaPredios As New FrmPrediosUniCat
        FrmPersonaPredios.MdiParent = Me
        FrmPersonaPredios.Show()
    End Sub

    Private Sub DesgloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesgloseToolStripMenuItem.Click
        Dim FrmNuevoPredios As New FrmNuevoPredio
        FrmNuevoPredios.MdiParent = Me
        FrmNuevoPredios.Show()
    End Sub

    Private Sub ModificaPredioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificaPredioToolStripMenuItem.Click
        Dim FrmPersonaPredios As New FrmMantenimiento
        FrmPersonaPredios.MdiParent = Me
        FrmPersonaPredios.Show()
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        Dim FrmPersonaPredios As New FrmPadronReg_Sociedad
        FrmPersonaPredios.MdiParent = Me
        FrmPersonaPredios.Show()
    End Sub

#End Region

End Class
