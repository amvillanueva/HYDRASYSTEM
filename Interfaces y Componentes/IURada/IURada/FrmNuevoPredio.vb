Imports HYDRAOperaciones.ControlRada
Public Class FrmNuevoPredio
    Private Sub FrmNuevoPredio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        limpiar()
        cargarComboBoxCR()
        cargarComboBoxCampana()
        cargarTipoident()

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

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        pdu_RetornaDatosPredio()
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

    Private Sub btnPrevie_Click(sender As Object, e As EventArgs) Handles btnPrevie.Click
        pdu_RetornaDatosPredio()
    End Sub
End Class