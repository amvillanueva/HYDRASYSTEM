Imports System.Windows.Forms
Imports HYDRAEntidades
Imports HYDRAOperaciones.ControlRada


Public Class FrmPrediosUniCat

    Dim dtPredios As DataTable
    Dim xmlPredios As String

    Private Sub FrmPrediosUniCat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarComboBoxCampana()
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

    Private Sub btnPrevie_Click(sender As Object, e As EventArgs) Handles btnPrevie.Click
        Try
            dtPredios = Nothing
            dtPredios = WFControlRAda.Instancia.fdu_Predio_x_UnidadCatastral(cboCampana.SelectedValue, txtUC.Text)
            dgvPredios.DataSource = dtPredios
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Generaxmlpredios()
        xmlPredios = "<r>  "
        ordernarcolumnas()
        With dtPredios
            ordernarcolumnas()
            If dtPredios.Rows.Count > 0 Then
                For Each dRow As DataRow In .Rows

                    If dRow("-") = True Then
                        xmlPredios = xmlPredios & "  <d "
                        xmlPredios = xmlPredios & "Persona=" + Chr(34) & dRow("Persona").ToString & Chr(34) & " "
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
        'Formato para  recorre dgv con for I00 to dgv.rowcunt
        ' MsgBox(dgvPredios.Item("-", i).Value())
        MsgBox("XML:  " & xmlPredios)
    End Sub


    Private Sub ordernarcolumnas()
        dgvPredios.Columns("CustomerID").Visible = False
        dgvPredios.Columns("-").DisplayIndex = 0
        dgvPredios.Columns("Predio_Nombre").DisplayIndex = 1
        dgvPredios.Columns("Unidad_Catastral").DisplayIndex = 1
        dgvPredios.Columns("Campana").DisplayIndex = 3
        dgvPredios.Columns("Comision").DisplayIndex = 4

    End Sub

    Private Sub tsbtnEditar_Click(sender As Object, e As EventArgs) Handles tsbtnEditar.Click

        Generaxmlpredios()
    End Sub
End Class