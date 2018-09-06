Imports System.Windows.Forms
Imports HYDRAEntidades
Imports HYDRAOperaciones.ControlRada

Public Class FrmMantenimiento

    Public idpredio As String
    Public com As String
    Public camp As String
    Public dni As String

    Public canal As String
    Public bloqueriego As String

    Dim cargado As Boolean = False


    Public consultainertan As Boolean = False



    Private Sub FrmMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        cargarComboBoxCR()
        cargarComboBoxCampana()
        cargarComboBoxCampanatoActualizar()
        cargarTipoident()
        'MsgBox("com: " & com & "camp: " & camp)

        If consultainertan Then
            'MsgBox("consulta interna")
            If idpredio.Length > 0 And com.Length > 0 And camp.Length > 0 Then
                txtidPredio.Enabled = False
                cboCR.Enabled = False
                cboCampana.Enabled = False
                cargado = True
            End If

            'Else MsgBox("consulta externa")

        End If


        If com <> Nothing Then
            cboCR.SelectedValue = com
            cboCampana.SelectedValue = camp
            txtidPredio.Text = idpredio
        Else
            ''com = cboCR.SelectedValue
            ''camp = cboCampana.SelectedValue



        End If

        cargarCanaBloqueCR(cboCR.SelectedValue)

    End Sub

    Private Sub cargarComboBoxCampana()
        Try
            Dim dt As New DataTable
            dt = WFControlRAda.Instancia.fdu_cargarCampañas
            With cboCampana
                .DataSource = dt
                .DisplayMember = "Descripcion"
                .ValueMember = "campana"
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub cargarTipoident()
        Try
            Dim dt As DataTable = Nothing
            dt = WFControlRAda.Instancia.fdu_cargarTipoIdentidad


            With cboTipoDocuser
                .DataSource = dt
                .DisplayMember = "Abreviado"
                .ValueMember = "Tipo_Identidad"
            End With


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cargarComboBoxCampanatoActualizar()
        Try
            Dim dt As New DataTable
            dt = WFControlRAda.Instancia.fdu_cargarCampañas

            With cboCampañaActualziar
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
                'txtCR.Text = "Descripcion"
            End With

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub cargarCanaBloqueCR(ByVal comision As String)
        Try
            Dim dt As New DataTable
            dt = WFControlRAda.Instancia.fdu_CanalBLoqueComReg(comision)
            With cbCanal
                .DataSource = dt
                .DisplayMember = "Canal"
                .ValueMember = "idCanal"
            End With
            With cbBLoque
                .DataSource = dt
                .DisplayMember = "BloqueRiego"
                .ValueMember = "idBloque"
            End With
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub



    Private Sub splPrincipal_SplitterMoved(sender As Object, e As System.Windows.Forms.SplitterEventArgs) Handles splPrincipal.SplitterMoved

    End Sub

    Private Sub btnPrevie_Click(sender As Object, e As EventArgs) Handles btnPrevie.Click
        limpiar()
        pdu_RetornaDatosPredio()
        'If cargado And consultainertan Then

        '    cargarCanaBloqueCR(com)
        '    MsgBox("1canal: " & canal & "  bloqueriego: " & bloqueriego & "COMISION:" & com)
        '    cbCanal.SelectedValue = canal
        'ElseIf cargado And consultainertan = False Then


        '    MsgBox("2canal: " & canal & "  bloqueriego: " & bloqueriego & "COMISION:" & com)
        'End If

    End Sub


    Sub pdu_RetornaDatosPredio()
        Try
            Dim dt As DataTable = Nothing
            dt = WFControlRAda.Instancia.fdu_cargaDatosPredio_Mantenimiento(txtidPredio.Text, cboCampana.SelectedValue, cboCR.SelectedValue)
            dgvDatosPredio.DataSource = dt

            With dgvDatosPredio
                If .RowCount > 0 Then
                    If .CurrentCell Is Nothing Then
                        .CurrentCell = .Rows.Item(0).Cells("Unidad_Catastral")
                    End If
                    txtUC.Text = .CurrentRow.Cells("Unidad_Catastral").Value
                    txtNombrePredio.Text = IIf(.CurrentRow.Cells("Predio_Nombre").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("Predio_Nombre").Value.ToString), "")
                    txtNumPredio.Text = IIf(.CurrentRow.Cells("PredioNro").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("PredioNro").Value.ToString), "")
                    txtCodSara.Text = IIf(.CurrentRow.Cells("Codigo").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("Codigo").Value.ToString), "")
                    txtLic.Text = IIf(.CurrentRow.Cells("HaLicencia").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("HaLicencia").Value.ToString), "")
                    txtPerm.Text = IIf(.CurrentRow.Cells("HaPermiso").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("HaPermiso").Value.ToString), "")
                    txtFiltr.Text = IIf(.CurrentRow.Cells("HaFiltracion").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("HaFiltracion").Value.ToString), "")
                    txtBajoRiego.Text = IIf(.CurrentRow.Cells("HaBajo_Riego").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("HaBajo_Riego").Value.ToString), "")
                    txtAreaTotal.Text = IIf(.CurrentRow.Cells("HaTotal").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("HaTotal").Value.ToString), "")
                    txtResolucion.Text = IIf(.CurrentRow.Cells("Resolucion").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("Resolucion").Value.ToString), "")
                    txtContribuyente.Text = IIf(.CurrentRow.Cells("Contribuyente").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("Contribuyente").Value.ToString), "")
                    txtComite.Text = IIf(.CurrentRow.Cells("Comite_Regante").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("Comite_Regante").Value.ToString), "")
                    txtOR.Text = IIf(.CurrentRow.Cells("Orden_Riego").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("Orden_Riego").Value.ToString), "")
                    txtHR.Text = IIf(.CurrentRow.Cells("Horas_Riego").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("Horas_Riego").Value.ToString), "")
                    txtVolumenA.Text = IIf(.CurrentRow.Cells("Volumen_Anual").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("Volumen_Anual").Value.ToString), "")
                    dtpFechaRes.Text = IIf(.CurrentRow.Cells("Fecha").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("Fecha").Value.ToString), Today)
                    cboCampañaActualziar.SelectedValue = cboCampana.SelectedValue
                    cbCanal.SelectedValue = IIf(.CurrentRow.Cells("Canal").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("Canal").Value.ToString), "")
                    cboTipoDocuser.SelectedValue = IIf(.CurrentRow.Cells("Tipo_Identidad").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("Tipo_Identidad").Value.ToString), "")
                    txtDNI.Text = IIf(.CurrentRow.Cells("Identidad").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("Identidad").Value.ToString), "")
                    txtObservaciones.Text = IIf(.CurrentRow.Cells("Observaciones").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("Observaciones").Value.ToString), "")
                    cboEsActivo.Text = IIf(.CurrentRow.Cells("Activo").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("Activo").Value.ToString), "")
                    cboEsSancionado.Text = IIf(.CurrentRow.Cells("Sancionado_Multa").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("Sancionado_Multa").Value.ToString), "")
                    cboEsnuevo.Text = IIf(.CurrentRow.Cells("Nuevo").Value.ToString.Trim.Length > 0, Trim(.CurrentRow.Cells("Nuevo").Value.ToString), "")
                    .Visible = False
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub


    Private Sub limpiar()
        txtUC.Text = ""
        txtNombrePredio.Text = ""
        txtNumPredio.Text = ""
        txtCodSara.Text = ""
        txtLic.Text = ""
        txtPerm.Text = ""
        txtFiltr.Text = ""
        txtBajoRiego.Text = ""
        txtAreaTotal.Text = ""
        txtResolucion.Text = ""
        txtContribuyente.Text = ""
        txtComite.Text = ""
        txtOR.Text = ""
        txtHR.Text = ""
        txtVolumenA.Text = ""
        dtpFechaRes.Text = ""
        cboCampañaActualziar.SelectedValue = -1
        cbCanal.SelectedValue = -1
        cboTipoDocuser.SelectedValue = -1
        txtDNI.Text = ""
        txtObservaciones.Text = ""
        cboEsActivo.Text = -1
        cboEsSancionado.Text = -1
        cboEsnuevo.Text = -1
    End Sub

    Private Sub txtidPredio_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtidPredio.KeyDown
        If e.KeyCode = Keys.Return Then
            btnPrevie.Focus()
        End If
    End Sub

    Private Sub btmSave_Click(sender As Object, e As EventArgs) Handles btmSave.Click
        '                                 (Predio As String, ByVal Campana As String,
        '                            ByVal ComisionRegante As String, ByVal Unidad_Catastral As String, ByVal Predio_Nombre As String,
        '                            ByVal PredioNro As String, ByVal Codigo As String, ByVal HaLicencia As Decimal, ByVal HaPermiso As Decimal,
        '                            ByVal HaFiltracion As Decimal, ByVal HaBajo_Riego As Decimal, ByVal HaTotal As Decimal, ByVal Canal As String,
        '                            ByVal Bloque_Riego As String, ByVal Comite_Regante As String, ByVal Orden_Riego As Decimal,
        '                            ByVal Horas_Riego As Decimal, ByVal Volumen_Anual As Decimal, ByVal Resolucion As String, ByVal Fecha As String,
        '                            ByVal Nuevo As String, ByVal Sancionado_Multa As String, ByVal Activo As String,
        '                            ByVal CampanatoActualizar As String, ByVal Identidad As String, ByVal Observaciones As String,
        '                            ByVal User)


        'MsgBox(SesionUsuario.Usuario)
        Try
            If WFControlRAda.Instancia.ModificaPredio(txtidPredio.Text, cboCampana.SelectedValue,
                                    cboCR.SelectedValue, txtUC.Text, txtNombrePredio.Text,
                                    txtNumPredio.Text, txtCodSara.Text, CDec(IIf(txtLic.Text.Trim.Length > 0, txtLic.Text, 0)),
                                   CDec(IIf(txtPerm.Text.Trim.Length > 0, txtPerm.Text, 0)),
                                   CDec(IIf(txtFiltr.Text.Trim.Length > 0, txtFiltr.Text, 0)),
                                   CDec(IIf(txtBajoRiego.Text.Trim.Length > 0, txtBajoRiego.Text, 0)),
                                   CDec(IIf(txtAreaTotal.Text.Trim.Length > 0, txtAreaTotal.Text, 0)), cbCanal.SelectedValue,
                                   cbBLoque.SelectedValue, txtComite.Text,
                                   CDec(IIf(txtOR.Text.Trim.Length > 0, txtOR.Text, 0)),
                                   CDec(IIf(txtHR.Text.Trim.Length > 0, txtHR.Text, 0)),
                                   CDec(IIf(txtVolumenA.Text.Trim.Length > 0, txtVolumenA.Text, 0)),
                                   txtResolucion.Text, dtpNUEVOFechaRes.Text,
                                   cboEsnuevo.Text, cboEsSancionado.Text, cboEsActivo.Text,
                                    cboCampañaActualziar.SelectedValue, txtDNI.Text, txtObservaciones.Text,
                                   SesionUsuario.Usuario) Then
                MsgBox("REGISTRADO CON EXITO", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                limpiar()
            Else
                MsgBox("ERROR EN MODIFICACION DE DATOS", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End If


        Catch ex As Exception
            MsgBox("ERROR EN ACTUALIZACION DATOS PREDIO - Excepcion: " & ex.ToString)
        End Try
    End Sub


End Class