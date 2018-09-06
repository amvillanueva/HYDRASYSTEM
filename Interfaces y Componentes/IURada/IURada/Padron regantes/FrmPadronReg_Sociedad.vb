Imports System.Windows.Forms
Imports HYDRAOperaciones.ControlRada
Imports HYDRAEntidades


Public Class FrmPadronReg_Sociedad

    Dim cargado As Boolean = False
    Dim dtPersonasPred As New DataTable
    Dim xmlSociedad As String =""

    Private Sub FrmPadronReg_Sociedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
        'cargarComboBoxCampana()
        pdu_limpiar()
        'pdu_listadoPadron()

        'Me.WindowState = FormWindowState.Maximized
    End Sub

#Region "PADRON REGANTE"
    'Private Sub cargarComboBoxCampana()
    '    Try
    '        Dim dt As New DataTable
    '        dt = WFControlRAda.Instancia.fdu_cargarCampañas
    '        With cboCampana
    '            .DataSource = dt
    '            .DisplayMember = "Descripcion"
    '            .ValueMember = "campana"
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex)
    '    End Try
    'End Sub
    Private Sub pdu_listadoPadron()
        Try
            dtPersonasPred = WFControlRAda.Instancia.fdu_Rada_Padron_Sociedad(0)
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

                'TxtApPaterno.Text = .CurrentRow.Cells("ApePat").Value
                'TxtApMaterno.Text = .CurrentRow.Cells("ApeMat").Value
                .Visible = False
            End If
        End With
    End Sub


    Private Sub ObtienePersonaSeleccionada()
        cargado = False
        Dim Dv As New DataView(dtPersonasPred)
        'Dv.RowFilter = "Nombres Like " & "'" & txtNombres.Text.Trim() & "*" & "'"

        Dv.RowFilter = "Nombres Like  '%" & txtNombres.Text.Trim() & "%'"
        '"Name LIKE '%"+MyTextBox.Text+%'";
        dgvPadron.DataSource = Dv.ToTable
        With dgvPadron
            .MultiSelect = False
            For Each col As DataGridViewColumn In .Columns
                col.Visible = False


                If col.Name = "Nombres" Then col.Visible = True
                If col.Name = "Identidad" Then col.Visible = True
                If col.Name = "IdSociedad" Then col.Visible = True



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

    Private Sub btnPreview_Click_1(sender As Object, e As EventArgs) Handles btnPreview.Click

        pdu_listadoPadron()
        If dgvPadron.RowCount > 0 Then
            cargado = True
        End If

        ObtienePersonaSeleccionada()
    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click













        Try
            If cargado Then
                'activarpredio = False
                If IsDBNull(dgvPadron.CurrentRow.Cells("Identidad").Value) Then
                    Exit Sub
                    MsgBox("IDENTIDAD VACIO ")
                Else

                    If dgvSociedad.Rows.Count > 0 Then
                        For Each dRow As DataGridViewRow In dgvSociedad.Rows
                            If (dRow.Cells("Identidad").Value = dgvPadron.CurrentRow.Cells("Identidad").Value) Then

                                MsgBox("YA HAS INGRESADO A ESTE USUARIO", MsgBoxStyle.Critical)
                                Exit Sub
                            End If
                        Next
                    End If

                End If

                dgvSociedad.Rows.Add(dgvPadron.CurrentRow.Cells("Identidad").Value, dgvPadron.CurrentRow.Cells("Nombres").Value, dgvPadron.CurrentRow.Cells("IdSociedad").Value)


            End If
        Catch ex As Exception
            MsgBox("error try catch " & ex.ToString)

        End Try



    End Sub
    Private Sub GeneraxmlSociedad()
        xmlSociedad = "<r>  "
        With dgvSociedad

            For Each dRow As DataGridViewRow In dgvSociedad.Rows

                xmlSociedad = xmlSociedad & "  <d "
                xmlSociedad = xmlSociedad & "Identidad=" + Chr(34) & dRow.Cells("Identidad").Value.ToString & Chr(34) & " "
                xmlSociedad = xmlSociedad & "IdSociedad=" + Chr(34) & dRow.Cells("IdSociedad").Value.ToString & Chr(34) & " "
                'xmlSociedad = xmlSociedad & "UC=" + Chr(34) & Trim(dRow("Unidad_Catastral").ToString) & Chr(34) & " "
                'xmlSociedad = xmlSociedad & "Resolucion=" + Chr(34) & dRow("Resolucion").ToString & Chr(34) & " "
                'xmlSociedad = xmlSociedad & "AreaTotal=" + Chr(34) & dRow("HaTotal").ToString & Chr(34) & " "
                xmlSociedad = xmlSociedad & " />"

            Next

        End With
        xmlSociedad = xmlSociedad & "</r>"


    End Sub

    Private Sub tsbSave_Click(sender As Object, e As EventArgs) Handles tsbSave.Click
        If dgvSociedad.Rows.Count > 0 Then
            xmlSociedad = ""
            GeneraxmlSociedad()
            MsgBox("XML:  " & xmlSociedad)

            Try
                If WFControlRAda.Instancia.Registra_NuevaSoc(xmlSociedad, SesionUsuario.Usuario) Then
                    MsgBox("REGISTRADO CON EXITO", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    'limpiar()
                Else
                    MsgBox("ERROR EN MODIFICACION DE DATOS", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End If
            Catch ex As Exception
                MsgBox("ERROR EN REGISTRO", MsgBoxStyle.Critical)
            End Try


        Else
            MsgBox("VACIO", MsgBoxStyle.Critical)


        End If



    End Sub
#End Region



End Class
