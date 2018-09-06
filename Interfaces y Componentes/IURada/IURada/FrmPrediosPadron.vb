Imports System.Windows.Forms
Imports HYDRAOperaciones.ControlRada
Imports HYDRAEntidades

Public Class FrmPrediosPadron
    Dim dtPersonasPred As New DataTable
    Dim idpredio As String
    Dim comision As String
    Dim campaña As String
    Dim idPersona As String
    Public canal As String
    Public bloqueriego As String
    Dim cargado As Boolean = False
    Dim n As Integer = 0


    Dim xmlPredios As String
    Dim dtPredios As DataTable
    Private Sub FrmPrediosPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
        cargarComboBoxCampana()
        pdu_limpiar()
        'pdu_listadoPadron()
        cargado = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub pdu_listadoPadron()
        Try
            dtPersonasPred = WFControlRAda.Instancia.fdu_Rada_Padron_Sociedad(chkSociedades.Checked)
            'dgvPersonas.DataSource = dtPersonasPred
            If dtPersonasPred Is Nothing Then
                MsgBox(WFControlRAda.Instancia.UltimoMensaje, MsgBoxStyle.Exclamation, Me.Text)
            Else
                With dgvPersona
                    .DataSource = dtPersonasPred
                    For Each col As DataGridViewColumn In .Columns
                        col.Visible = False
                        If col.Name = "Nombres" Then col.Visible = True
                        If col.Name = "Identidad" Then col.Visible = True
                    Next
                    .AutoResizeColumns()
                End With
            End If
        Catch ex As Exception
            MsgBox("error: " & ex.ToString)
        End Try
    End Sub

    Private Sub dgvPadron_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvPadron.CurrentCellChanged
        If cargado Then
            'activarpredio = False
            If IsDBNull(dgvPadron.CurrentRow.Cells("Identidad").Value) Then
                Exit Sub
            Else
                idPersona = dgvPadron.CurrentRow.Cells("Identidad").Value
                predios_x_IdPersona(cboCampana.SelectedValue.ToString, idPersona)
            End If
            'activarpredio = True
        Else
        End If
    End Sub

    Public Sub predios_x_IdPersona(ByVal campaña As String, ByVal identidad As String)
        dtPredios = Nothing
        'MsgBox("id: " & identidad & "camapaña: " & campaña)
        Try
            dtPredios = WFControlRAda.Instancia.fdu_Predio_x_Id(identidad, campaña)
            With dgvPredios
                .DataSource = dtPredios
                For Each col As DataGridViewColumn In .Columns
                    col.Visible = True
                    col.ReadOnly = True
                    If col.Name = "-" Then col.ReadOnly = False
                Next
            End With
        Catch ex As Exception
            MsgBox("error: " & ex.ToString)
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
            MsgBox(ex)
        End Try
    End Sub

    Private Sub pdu_limpiar()
        txtNombres.Text = ""
        txtNombres.Tag = -1
    End Sub

    Private Sub txtNombres_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNombres.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                dgvPersona.Visible = False
                btnPreview.Focus()
            Case Keys.Return
                If dgvPersona.Visible AndAlso dgvPersona.RowCount > 0 Then
                    pdu_RetornaPersona()
                    btnPreview.Focus()
                End If
            Case Keys.Down
                If dgvPersona.Visible AndAlso dgvPersona.RowCount > 0 Then
                    dgvPersona.Focus()
                End If
        End Select
    End Sub




    Sub pdu_RetornaPersona()
        cargado = False
        With dgvPersona
            If .RowCount > 0 Then
                If .CurrentCell Is Nothing Then
                    .CurrentCell = .Rows.Item(0).Cells("Nombres")
                End If
                txtNombres.Text = .CurrentRow.Cells("Nombres").Value
                txtNombres.Tag = .CurrentRow.Cells("Identidad").Value
                txtIdentidad.Text = .CurrentRow.Cells("Identidad").Value
                dgvPredios.DataSource = Nothing
                'TxtApPaterno.Text = .CurrentRow.Cells("ApePat").Value
                'TxtApMaterno.Text = .CurrentRow.Cells("ApeMat").Value
                .Visible = False
            End If
        End With
    End Sub


    Private Sub ObtienePersonaSeleccionada()
        cargado = False
        Dim Dv As New DataView(dtPersonasPred)
        Dv.RowFilter = "Nombres Like " & "'" & txtNombres.Text.Trim() & "*" & "'"
        dgvPadron.DataSource = Dv.ToTable
        With dgvPadron
            .MultiSelect = False
            For Each col As DataGridViewColumn In .Columns
                col.Visible = True
                'If col.Name = "ApePat" Then col.Visible = False
                'If col.Name = "ApeMat" Then col.Visible = False
                'If col.Name = "Nombres" Then col.Visible = False
                'If col.Name = "IdPersonaGeneral" Then col.Visible = False
            Next
        End With
        'NO PERMITIR ORDENAR
        For i = 0 To dgvPadron.Columns.Count - 1
            dgvPadron.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
        cargado = True

    End Sub


    Private Sub dgvPersona_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvPersona.KeyDown
        If e.KeyCode = Keys.Return Then
            pdu_RetornaPersona()
            btnPreview.Focus()
            ' dtmPeriodo.Focus()
        End If
    End Sub

    Private Sub dgvPersona_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvPersona.MouseDoubleClick
        pdu_RetornaPersona()
    End Sub

    Private Sub txtNombres_TextChanged(sender As Object, e As EventArgs) Handles txtNombres.TextChanged

        dgvPersona.Height = 150
        txtNombres.Tag = -1
        If txtNombres.Text.Trim.Length = 0 Then
            txtNombres.Tag = -1
            dgvPersona.Visible = False
        ElseIf txtNombres.Text.Trim.Length >= 6 Then
            dgvPersona.Visible = True
            If txtNombres.Text.Trim.Length = 6 Then pdu_listadoPadron()
            Dim Dv As New DataView(dtPersonasPred)
            Dv.RowFilter = "Nombres Like " & "'" & txtNombres.Text.Trim() & "*" & "'"
            dgvPersona.DataSource = Dv.ToTable
        End If
    End Sub


    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        RemoveHandler dgvPadron.CurrentCellChanged, AddressOf dgvPadron_CurrentCellChanged

        dgvPadron.DataSource = Nothing
        dgvPredios.DataSource = Nothing

        pdu_listadoPadron()
        ObtienePersonaSeleccionada()
        AddHandler dgvPadron.CurrentCellChanged, AddressOf dgvPadron_CurrentCellChanged
    End Sub

    Private Sub txtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidad.TextChanged
        dgvPersona.Height = 150
        txtIdentidad.Tag = -1
        If txtIdentidad.Text.Trim.Length = 0 Then
            txtIdentidad.Tag = -1
            dgvPersona.Visible = False
        ElseIf txtIdentidad.Text.Trim.Length >= 4 Then
            dgvPersona.Visible = True
            If txtIdentidad.Text.Trim.Length = 4 Then pdu_listadoPadron()
            Dim Dv As New DataView(dtPersonasPred)
            If IsNumeric(txtIdentidad.Text.Trim()) Then
                'Dv.RowFilter = "Identidad = " & CInt(txtCODIGOALUMNO.Text.Trim())
                Dv.RowFilter = "Identidad Like " & "'" & txtIdentidad.Text.Trim() & "*" & "'"
                dgvPersona.DataSource = Dv.ToTable
            Else
                Exit Sub
            End If
        End If
    End Sub



    Private Sub txtIdentidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdentidad.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                dgvPersona.Visible = False
                btnPreview.Focus()
            Case Keys.Return
                If dgvPersona.Visible AndAlso dgvPersona.RowCount > 0 Then
                    pdu_RetornaPersona()
                    btnPreview.Focus()
                End If
            Case Keys.Down
                If dgvPersona.Visible AndAlso dgvPersona.RowCount > 0 Then
                    dgvPersona.Focus()
                End If
        End Select
    End Sub

    Private Sub cboCampana_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCampana.SelectedValueChanged
        If cargado Then
            dgvPredios.DataSource = Nothing
        End If
    End Sub

    Private Sub btnxml_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim mvr As FrmMantenimiento = New FrmMantenimiento
        'mvr.MdiParent = Me
        contarseleccionado()
        If n = 1 Then
            mvr.consultainertan = True
            mvr.idpredio = idpredio
            mvr.com = comision
            mvr.camp = campaña
            mvr.canal = canal
            mvr.bloqueriego = bloqueriego
            'mvr.dni = idPersona
            mvr.ShowDialog()
        Else
            MsgBox("debe seleccionar solo un registro")
        End If
    End Sub

    Private Sub contarseleccionado()
        n = 0
        If dgvPredios.Rows.Count > 0 Then
            For Each dRow As DataGridViewRow In dgvPredios.Rows
                If CBool(dRow.Cells("-").Value) Then
                    idpredio = dRow.Cells("Predio").Value
                    campaña = dRow.Cells("Campana").Value
                    comision = dRow.Cells("Comision_Regante").Value

                    canal = dRow.Cells("Canal").Value
                    bloqueriego = dRow.Cells("Bloque_Riego").Value

                    n += 1
                End If
            Next
        End If
    End Sub


    Private Sub Generaxmlpredios()
        xmlPredios = "<r>  "
        With dtPredios
            If dtPredios.Rows.Count > 0 Then
                For Each dRow As DataRow In .Rows

                    If dRow("-") = True Then
                        xmlPredios = xmlPredios & "  <d "
                        xmlPredios = xmlPredios & "NombrePredio=" + Chr(34) & dRow("Predio_Nombre").ToString & Chr(34) & " "
                        xmlPredios = xmlPredios & "UC=" + Chr(34) & Trim(dRow("Unidad_Catastral").ToString) & Chr(34) & " "
                        xmlPredios = xmlPredios & "Resolucion=" + Chr(34) & dRow("Resolucion").ToString & Chr(34) & " "
                        xmlPredios = xmlPredios & "AreaTotal=" + Chr(34) & dRow("HaTotal").ToString & Chr(34) & " "
                        xmlPredios = xmlPredios & " />"
                    End If
                Next
            End If
        End With
        xmlPredios = xmlPredios & "</r>"

        MsgBox("XML:  " & xmlPredios)
    End Sub

    Private Sub btnGenXml_Click(sender As Object, e As EventArgs) Handles btnGenXml.Click
        Generaxmlpredios()
    End Sub
End Class