
Imports System.Data.Odbc

Public Class Fox

    Private cfp, codbc As New OdbcConnection

    'Ejecuta una consulta a la BD de Jorge en FoxPro
    Function EjecutarConsultaFox(ByVal strSql As String, ByVal IdSucursal As Integer) As DataTable

        Dim dt As New DataTable()

        cfp.ConnectionString = Cnn_Fox

        Dim dtax As New OdbcDataAdapter(strSql, cfp)

        Try
            dtax.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "ERROR EN FOXPRO")

            If cfp.State = ConnectionState.Open Then
                cfp.Close()
            End If
            Return Nothing 'dt vacio
            'Exit Function
        End Try
        dtax.Dispose()
        cfp.Close()
        'cmd.Dispose()
        cfp.Dispose()

        ''If dt.Rows.Count = 0 Then
        ''    dt = Nothing
        ''End If

        Return dt
    End Function


End Class
