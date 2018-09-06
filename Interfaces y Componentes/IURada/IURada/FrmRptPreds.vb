Imports HYDRAOperaciones.ControlRada
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports HYDRAEntidades
Public Class FRMBUSQUEDABACKUP1

    Private tamArbol As Integer = 0
    Private cargado As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarComboBoxCampana()

        cargarComboBoxCR()
        cboTipoRpt.SelectedIndex = 0
        cboTamArbol.SelectedIndex = 0
        cargaCanales()
        chkTodosCanales.Checked = True
        cargado = True
        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub cargarComboBoxCampana()
        Try
            Dim dt As New DataTable
            dt = WFControlRAda.Instancia.fdu_cargarCampañas
            With cboCampaña
                .DataSource = dt
                .DisplayMember = "Descripcion"
                .ValueMember = "campana"
            End With

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub


    Private Sub cargarComboBoxCR()
        Try
            Dim dt As New DataTable
            dt = WFControlRAda.Instancia.fdu_cargarComReg
            With cboCR
                .DataSource = dt
                .DisplayMember = "Descripcion"
                .ValueMember = "Comision_Regante"
            End With

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub cargaCanales()
        Try
            Dim dt As New DataTable
            dt = WFControlRAda.Instancia.fdu_cargaCanales_Comision(cboCR.SelectedValue, "", tamArbol)
            With cboCanales
                .DataSource = dt
                .DisplayMember = "Descripcion"
                .ValueMember = "Canal"
            End With

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub



    Private Function ListarPrediosxCanal_OrdenA() As DataTable
        Try
            Dim dt As New DataTable
            dt = WFControlRAda.Instancia.fdu_Predio_xCanal_OrdenA(cboCampaña.SelectedValue, cboCR.SelectedValue)

            Return dt
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Function

    Private Sub rpt_PorCanal()
        If gbxTipo.Visible = True And cboTipoRpt.SelectedIndex = 0 Then  'detallado'
            Dim oConexInfo As ConnectionInfo
            Dim oListaTablas As Tables
            Dim oTabla As Table
            Dim oTablaConexInfo As TableLogOnInfo
            oConexInfo = New ConnectionInfo()
            oConexInfo.ServerName = SesionUsuario.SesionConexion.DsnNombre
            oConexInfo.DatabaseName = SesionUsuario.SesionConexion.BaseDatos
            oConexInfo.UserID = SesionUsuario.SesionConexion.LoginUser
            oConexInfo.Password = SesionUsuario.SesionConexion.LoginClave
            Cursor = Cursors.WaitCursor
            Try
                Dim oReporteDatos As Object = Nothing
                oReporteDatos = New crPredioXCanal
                oListaTablas = oReporteDatos.Database.Tables
                For Each oTabla In oListaTablas
                    oTablaConexInfo = oTabla.LogOnInfo
                    oTablaConexInfo.ConnectionInfo = oConexInfo
                    oTabla.ApplyLogOnInfo(oTablaConexInfo)
                Next

                With oReporteDatos
                    .SetParameterValue("@campana", cboCampaña.SelectedValue)
                    .SetParameterValue("@ComReg", cboCR.SelectedValue)
                    .SetParameterValue("@nomCampña", cboCampaña.Text)
                    .SetParameterValue("@Canal", IIf(chkTodosCanales.Checked, DBNull.Value, cboCanales.SelectedValue))


                End With
                Me.crvFinal.ReportSource = oReporteDatos
                Me.WindowState = FormWindowState.Maximized
            Catch ex As Exception
                MsgBox("Error al Reportar los Requerimientos.")
            End Try
            Cursor = Cursors.Default


        ElseIf gbxTipo.Visible = True And cboTipoRpt.SelectedIndex = 1 Then  'laterales y canales'
            Dim oConexInfo As ConnectionInfo
            Dim oListaTablas As Tables
            Dim oTabla As Table
            Dim oTablaConexInfo As TableLogOnInfo
            oConexInfo = New ConnectionInfo()
            oConexInfo.ServerName = SesionUsuario.SesionConexion.DsnNombre
            oConexInfo.DatabaseName = SesionUsuario.SesionConexion.BaseDatos
            oConexInfo.UserID = SesionUsuario.SesionConexion.LoginUser
            oConexInfo.Password = SesionUsuario.SesionConexion.LoginClave
            Cursor = Cursors.WaitCursor
            Try
                Dim oReporteDatos As Object = Nothing
                oReporteDatos = New crPredioXCanal_canalesylaterales
                oListaTablas = oReporteDatos.Database.Tables
                For Each oTabla In oListaTablas
                    oTablaConexInfo = oTabla.LogOnInfo
                    oTablaConexInfo.ConnectionInfo = oConexInfo
                    oTabla.ApplyLogOnInfo(oTablaConexInfo)
                Next

                With oReporteDatos
                    .SetParameterValue("@campana", cboCampaña.SelectedValue)
                    .SetParameterValue("@ComReg", cboCR.SelectedValue)
                    .SetParameterValue("@nomCampña", cboCampaña.Text)


                End With
                Me.crvFinal.ReportSource = oReporteDatos
                Me.WindowState = FormWindowState.Maximized
            Catch ex As Exception
                MsgBox("Error al Reportar los Requerimientos.")
            End Try
            Cursor = Cursors.Default

        Else

            Dim oConexInfo As ConnectionInfo
            Dim oListaTablas As Tables
            Dim oTabla As Table
            Dim oTablaConexInfo As TableLogOnInfo
            oConexInfo = New ConnectionInfo()
            oConexInfo.ServerName = SesionUsuario.SesionConexion.DsnNombre
            oConexInfo.DatabaseName = SesionUsuario.SesionConexion.BaseDatos
            oConexInfo.UserID = SesionUsuario.SesionConexion.LoginUser
            oConexInfo.Password = SesionUsuario.SesionConexion.LoginClave
            Cursor = Cursors.WaitCursor
            Try
                Dim oReporteDatos As Object = Nothing
                oReporteDatos = New crPredioXCanal_Principales
                oListaTablas = oReporteDatos.Database.Tables
                For Each oTabla In oListaTablas
                    oTablaConexInfo = oTabla.LogOnInfo
                    oTablaConexInfo.ConnectionInfo = oConexInfo
                    oTabla.ApplyLogOnInfo(oTablaConexInfo)
                Next

                With oReporteDatos
                    .SetParameterValue("@campana", cboCampaña.SelectedValue)
                    If chkTodasCom.Checked Then
                        .SetParameterValue("@ComReg", -1)
                    Else
                        .SetParameterValue("@ComReg", cboCR.SelectedValue)
                    End If



                    .SetParameterValue("@nomcampana", cboCampaña.Text)


                End With
                Me.crvFinal.ReportSource = oReporteDatos
                Me.WindowState = FormWindowState.Maximized
            Catch ex As Exception
                MsgBox("Error al Reportar los Requerimientos.")
            End Try
            Cursor = Cursors.Default
        End If




    End Sub
    Private Sub rpt_PorBloque()
        Dim oConexInfo As ConnectionInfo
        Dim oListaTablas As Tables
        Dim oTabla As Table
        Dim oTablaConexInfo As TableLogOnInfo
        oConexInfo = New ConnectionInfo()
        oConexInfo.ServerName = SesionUsuario.SesionConexion.DsnNombre
        oConexInfo.DatabaseName = SesionUsuario.SesionConexion.BaseDatos
        oConexInfo.UserID = SesionUsuario.SesionConexion.LoginUser
        oConexInfo.Password = SesionUsuario.SesionConexion.LoginClave
        Cursor = Cursors.WaitCursor
        Try
            Dim oReporteDatos As Object = Nothing
            oReporteDatos = New crPredioXBLoque
            oListaTablas = oReporteDatos.Database.Tables
            For Each oTabla In oListaTablas
                oTablaConexInfo = oTabla.LogOnInfo
                oTablaConexInfo.ConnectionInfo = oConexInfo
                oTabla.ApplyLogOnInfo(oTablaConexInfo)
            Next

            With oReporteDatos
                .SetParameterValue("@campana", cboCampaña.SelectedValue)
                .SetParameterValue("@ComReg", cboCR.SelectedValue)
                .SetParameterValue("@nomcampana", cboCampaña.Text)
                .SetParameterValue("@Canal", DBNull.Value)
            End With
            Me.crvFinal.ReportSource = oReporteDatos
            Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MsgBox("Error al Reportar los Requerimientos.")
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub rpt_PorUsuarios()
        Dim oConexInfo As ConnectionInfo
        Dim oListaTablas As Tables
        Dim oTabla As Table
        Dim oTablaConexInfo As TableLogOnInfo
        oConexInfo = New ConnectionInfo()
        oConexInfo.ServerName = SesionUsuario.SesionConexion.DsnNombre
        oConexInfo.DatabaseName = SesionUsuario.SesionConexion.BaseDatos
        oConexInfo.UserID = SesionUsuario.SesionConexion.LoginUser
        oConexInfo.Password = SesionUsuario.SesionConexion.LoginClave
        Cursor = Cursors.WaitCursor
        Try
            Dim oReporteDatos As Object = Nothing
            oReporteDatos = New crPredioXUsuarios
            oListaTablas = oReporteDatos.Database.Tables
            For Each oTabla In oListaTablas
                oTablaConexInfo = oTabla.LogOnInfo
                oTablaConexInfo.ConnectionInfo = oConexInfo
                oTabla.ApplyLogOnInfo(oTablaConexInfo)
            Next

            With oReporteDatos
                .SetParameterValue("@campana", cboCampaña.SelectedValue)
                .SetParameterValue("@ComReg", cboCR.SelectedValue)
                .SetParameterValue("@nomcampana", cboCampaña.Text)
                .SetParameterValue("@Canal", DBNull.Value)
            End With
            Me.crvFinal.ReportSource = oReporteDatos
            Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MsgBox("Error al Reportar los Requerimientos." & ex.ToString)
        End Try
        Cursor = Cursors.Default
    End Sub



    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbBloques.CheckedChanged
        If rbBloques.Checked Then
            gbxTipo.Visible = False
        End If
    End Sub

    Private Sub btnVerReporte_Click(sender As Object, e As EventArgs)
        If rbCanal.Checked Then
            rpt_PorCanal()

        ElseIf rbBloques.Checked Then
            rpt_PorBloque()
        Else
            rpt_PorUsuarios()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub rbCanal_CheckedChanged(sender As Object, e As EventArgs) Handles rbCanal.CheckedChanged
        If rbCanal.Checked Then
            gbxTipo.Visible = True
            gbxCanales.Visible = True
        Else
            gbxCanales.Visible = False
        End If
    End Sub

    Private Sub rbUsers_CheckedChanged(sender As Object, e As EventArgs) Handles rbUsers.CheckedChanged
        If rbUsers.Checked Then
            gbxTipo.Visible = False
        End If
    End Sub

    Private Sub chkTodasCom_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodasCom.CheckedChanged
        'If chkTodasCom.Checked Then
        '    cboCR.Enabled = False
        'Else
        '    cboCR.Enabled = True
        'End If
    End Sub

    Private Sub cboTipoRpt_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTipoRpt.SelectedValueChanged
        If cboTipoRpt.SelectedIndex = 2 Then
            chkTodasCom.Visible = True
        Else
            chkTodasCom.Visible = False
        End If


        If cboTipoRpt.SelectedIndex = 0 Then
            gbxCanales.Visible = True
        Else
            gbxCanales.Visible = False
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rbCanal.Checked Then
            rpt_PorCanal()
            'MsgBox("canal")
        ElseIf rbBloques.Checked Then
            'MsgBox("bloque")
            rpt_PorBloque()
        Else
            MsgBox("usuario")
            rpt_PorUsuarios()
        End If
    End Sub

    Private Sub btnSlider_Click(sender As Object, e As EventArgs) Handles btnSlider.Click
        If (splPrincipal.SplitterDistance = 294) Then
            splPrincipal.SplitterDistance = 57
        Else
            splPrincipal.SplitterDistance = 294
        End If
    End Sub

    Private Sub cboTamArbol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTamArbol.SelectedIndexChanged
        If cboTamArbol.SelectedIndex = 0 Then
            tamArbol = 4
            cargaCanales()

        Else
            tamArbol = 0
            cargaCanales()
        End If

    End Sub

    Private Sub cboCR_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCR.SelectedValueChanged
        If cargado Then
            cargaCanales()
        End If

    End Sub

    Private Sub chkTodosCanales_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodosCanales.CheckedChanged
        If chkTodosCanales.Checked Then
            cboTamArbol.Enabled = False
            cboCanales.Enabled = False
        Else
            cboTamArbol.Enabled = True
            cboCanales.Enabled = True
        End If
    End Sub
End Class
