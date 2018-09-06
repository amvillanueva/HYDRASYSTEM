
Imports System.Data.SqlClient
'Imports PoolConexiones
'Imports GEACEntidades
'Imports GEACEntidades.Contabilidad



Namespace DAOAlmacen
    Public NotInheritable Class DAOControlAlmacen

        Public Advertencia As String = String.Empty
        Private Shared _Instancia As DAOControlAlmacen = Nothing
        Private SesionUsuario As String = HYDRAEntidades.SesionUsuario.Usuario

#Region "Instancia unica de la clase"
        Public Shared ReadOnly Property Instancia() As DAOControlAlmacen
            Get
                If _Instancia Is Nothing Then
                    _Instancia = New DAOControlAlmacen
                End If
                Return _Instancia
            End Get
        End Property
#End Region

        Public Function fdu_ALM_ListarProductoAlmacen(ByVal periodoRecibido As String, ByVal idAlmacen As Integer) As DataTable
            Dim dt As New DataTable
            Dim cmd As New SqlCommand
            Dim da As SqlDataAdapter = Nothing

            Try
                cmd.CommandText = "[CENTRAL].[Almacen].[SpAlm_AL_ListarProductosAlmacenes]"
                'cmd.Connection = TSQL.ConexionPermanente     ''FALTA IMPLEMENTAR EL POOLCONEXIONES
                cmd.Connection = New SqlConnection("Data Source=ANTHONY-PC\SERVIDORCHICAMA;Initial Catalog=HYDRA-CENTRAL;Persist Security Info=True;User ID=sa;Password=12345")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdAlmacen", idAlmacen)
                cmd.Parameters.AddWithValue("@PeriodoRecibido", periodoRecibido)

                da = New SqlDataAdapter(cmd)
                da.Fill(dt)
            Catch ex As Exception
                Advertencia = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
                Return Nothing
            Finally
                cmd.Dispose()
                cmd = Nothing
                If Not IsNothing(da) Then
                    da.Dispose()
                    da = Nothing
                End If
            End Try
            Return dt
        End Function
    End Class

End Namespace


