Imports System.Data.SqlClient
Imports PoolConexionesHydra

Namespace DAORada
    Public NotInheritable Class DAOControlRada

        Public Advertencia As String = String.Empty
        Private Shared _Instancia As DAOControlRada = Nothing
        Private SesionUsuario As String = HYDRAEntidades.SesionUsuario.Usuario


        '  Private tempconexionbd As String = "Data Source=JORDAN;Initial Catalog=HYDRA-CENTRAL;Persist Security Info=True;User ID=sa;Password=12345"


#Region "Instancia unica de la clase"
        Public Shared ReadOnly Property Instancia() As DAOControlRada
            Get
                If _Instancia Is Nothing Then
                    _Instancia = New DAOControlRada
                End If
                Return _Instancia
            End Get
        End Property
#End Region

        Public Function fdu_Rada_Padron_Sociedad(ByVal incluirSociedad As Boolean) As DataTable
            Dim dt As New DataTable
            Dim cmd As New SqlCommand
            Dim da As SqlDataAdapter = Nothing

            Try
                cmd.CommandText = "[dbo].[RADA_Listar_Padron]"
                cmd.Connection = TSQL.ConexionPermanente     ''FALTA IMPLEMENTAR EL POOLCONEXIONES
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@incluirSociedad", incluirSociedad)
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


        Public Function fdu_cargarCampañas() As DataTable
            Dim dt As New DataTable
            Dim cmd As New SqlCommand
            Dim da As SqlDataAdapter = Nothing

            Try
                cmd.CommandText = "[dbo].[Listar_Campañas_Chicama]"
                cmd.Connection = TSQL.ConexionPermanente     ''FALTA IMPLEMENTAR EL POOLCONEXIONES
                cmd.CommandType = CommandType.StoredProcedure
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
        Public Function fdu_cargarTipoIdentidad() As DataTable
            Dim dt As New DataTable
            Dim cmd As New SqlCommand
            Dim da As SqlDataAdapter = Nothing

            Try
                cmd.CommandText = "[dbo].[Listar_TipoIdentidad]"
                cmd.Connection = TSQL.ConexionPermanente     ''FALTA IMPLEMENTAR EL POOLCONEXIONES
                cmd.CommandType = CommandType.StoredProcedure
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



        Public Function fdu_cargarComReg() As DataTable
            Dim dt As New DataTable
            Dim cmd As New SqlCommand
            Dim da As SqlDataAdapter = Nothing

            Try
                cmd.CommandText = "[dbo].[Listar_ComisionesRegantes_Chicama]"
                cmd.Connection = TSQL.ConexionPermanente     ''FALTA IMPLEMENTAR EL POOLCONEXIONES
                cmd.CommandType = CommandType.StoredProcedure
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
        Public Function fdu_CanalBLoqueComReg(ByVal comision As String) As DataTable
            Dim dt As New DataTable
            Dim cmd As New SqlCommand
            Dim da As SqlDataAdapter = Nothing

            Try
                cmd.CommandText = "[dbo].[Listar_Canales_Bloques_Comision]"
                cmd.Connection = TSQL.ConexionPermanente     ''FALTA IMPLEMENTAR EL POOLCONEXIONES
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@comision", comision)
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


        Public Function fdu_cargaDatosPredio_Mantenimiento(ByVal predio As String, ByVal campana As String, ByVal comision As String) As DataTable
            Dim dt As New DataTable
            Dim cmd As New SqlCommand
            Dim da As SqlDataAdapter = Nothing
            Try
                cmd.CommandText = "[dbo].[RADA_cargaDatosPredio_Mantenimiento]"
                cmd.Connection = TSQL.ConexionPermanente     ''FALTA IMPLEMENTAR EL POOLCONEXIONES
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Predio", predio)
                cmd.Parameters.AddWithValue("@Campana", campana)
                cmd.Parameters.AddWithValue("@Comision_Regante", comision)
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

        Public Function fdu_cargaCanales_Comision(ByVal cr As String, ByVal canal As String, ByVal tamarbol As Integer) As DataTable
            Dim dt As New DataTable
            Dim cmd As New SqlCommand
            Dim da As SqlDataAdapter = Nothing
            Try
                cmd.CommandText = "[dbo].[listarCanal_Comision_Tamaño]"
                cmd.Connection = TSQL.ConexionPermanente     ''FALTA IMPLEMENTAR EL POOLCONEXIONES
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ComisionRegante", cr)
                cmd.Parameters.AddWithValue("@Canal", IIf(canal.Trim.Length <= 0, DBNull.Value, canal))
                cmd.Parameters.AddWithValue("@TamañoArbol", IIf(tamarbol = 0, DBNull.Value, tamarbol))
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

        Public Function fdu_Predio_x_Id(ByVal campaña As String, ByVal identidad As String) As DataTable
            Dim dt As New DataTable
            Dim cmd As New SqlCommand
            Dim da As SqlDataAdapter = Nothing

            Try
                cmd.CommandText = "[dbo].[listarPredio_x_Id]"
                cmd.Connection = TSQL.ConexionPermanente     ''FALTA IMPLEMENTAR EL POOLCONEXIONES
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@campaña", campaña)
                cmd.Parameters.AddWithValue("@Identidad", identidad)

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

        Public Function fdu_Predio_x_UnidadCatastral(ByVal campaña As String, ByVal uc As String) As DataTable
            Dim dt As New DataTable
            Dim cmd As New SqlCommand
            Dim da As SqlDataAdapter = Nothing

            Try
                cmd.CommandText = "[dbo].[listarPredio_x_UnidadCatastral]"
                cmd.Connection = TSQL.ConexionPermanente     ''FALTA IMPLEMENTAR EL POOLCONEXIONES
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@campaña", campaña)
                cmd.Parameters.AddWithValue("@UC", uc)

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



        Public Function fdu_Predio_x_Canal_OrdenA(ByVal campaña As String, ByVal ComReg As String) As DataTable
            Dim dt As New DataTable
            Dim cmd As New SqlCommand
            Dim da As SqlDataAdapter = Nothing

            Try
                cmd.CommandText = "[dbo].[listarPredio_x_Canal_OrdenA]"
                cmd.Connection = TSQL.ConexionPermanente     ''FALTA IMPLEMENTAR EL POOLCONEXIONES
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@campana", campaña)
                cmd.Parameters.AddWithValue("@ComReg", ComReg)

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



#Region "INSERTS AND UPDATES"
        Public Function ModificaPredio(ByVal Predio As String, ByVal Campana As String,
                                    ByVal ComisionRegante As String, ByVal Unidad_Catastral As String, ByVal Predio_Nombre As String,
                                    ByVal PredioNro As String, ByVal Codigo As String, ByVal HaLicencia As Decimal, ByVal HaPermiso As Decimal,
                                    ByVal HaFiltracion As Decimal, ByVal HaBajo_Riego As Decimal, ByVal HaTotal As Decimal, ByVal Canal As String,
                                    ByVal Bloque_Riego As String, ByVal Comite_Regante As String, ByVal Orden_Riego As Decimal,
                                    ByVal Horas_Riego As Decimal, ByVal Volumen_Anual As Decimal, ByVal Resolucion As String, ByVal Fecha As String,
                                    ByVal Nuevo As String, ByVal Sancionado_Multa As String, ByVal Activo As String,
                                    ByVal CampanatoActualizar As String, ByVal Identidad As String, ByVal Observaciones As String,
                                    ByVal User As String) As Boolean
            Dim CMD As New SqlCommand
            Dim Retorno As Boolean
            Dim DR As SqlDataReader = Nothing
            Try
                With CMD
                    .CommandText = "RADA_UPDATE_PREDIO"
                    .Connection = TSQL.ConexionPermanente
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@Predio", Predio)
                    .Parameters.AddWithValue("@Campana", Campana)
                    .Parameters.AddWithValue("@ComisionRegante", ComisionRegante)
                    .Parameters.AddWithValue("@Unidad_Catastral", Unidad_Catastral)
                    .Parameters.AddWithValue("@Predio_Nombre", Predio_Nombre)
                    .Parameters.AddWithValue("@PredioNro", PredioNro)
                    .Parameters.AddWithValue("@Codigo", Codigo)
                    .Parameters.AddWithValue("@HaLicencia", IIf(HaLicencia = 0, DBNull.Value, HaLicencia))
                    .Parameters.AddWithValue("@HaPermiso", IIf(HaPermiso = 0, DBNull.Value, HaPermiso))
                    .Parameters.AddWithValue("@HaFiltracion", IIf(HaFiltracion = 0, DBNull.Value, HaFiltracion))
                    .Parameters.AddWithValue("@HaBajo_Riego", IIf(HaBajo_Riego = 0, DBNull.Value, HaBajo_Riego))
                    .Parameters.AddWithValue("@HaTotal", IIf(HaTotal = 0, DBNull.Value, HaTotal))
                    .Parameters.AddWithValue("@Canal", Canal)
                    .Parameters.AddWithValue("@Bloque_Riego", Bloque_Riego)
                    .Parameters.AddWithValue("@Comite_Regante", Comite_Regante)
                    .Parameters.AddWithValue("@Orden_Riego", IIf(Orden_Riego = 0, DBNull.Value, Orden_Riego))
                    .Parameters.AddWithValue("@Horas_Riego", IIf(Horas_Riego = 0, DBNull.Value, Horas_Riego))
                    .Parameters.AddWithValue("@Volumen_Anual", IIf(Volumen_Anual = 0, DBNull.Value, Volumen_Anual))
                    .Parameters.AddWithValue("@Resolucion", Resolucion)
                    .Parameters.AddWithValue("@Fecha", Fecha)
                    .Parameters.AddWithValue("@Nuevo", Nuevo)
                    .Parameters.AddWithValue("@Sancionado_Multa", Sancionado_Multa)
                    .Parameters.AddWithValue("@Activo", Activo)
                    .Parameters.AddWithValue("@CampanatoActualizar", CampanatoActualizar)
                    .Parameters.AddWithValue("@Identidad", Identidad)
                    .Parameters.AddWithValue("@Observaciones", Observaciones)
                    .Parameters.AddWithValue("@User", User)
                    If .Connection.State = ConnectionState.Closed Then
                        .Connection.Open()
                    End If
                    DR = .ExecuteReader(CommandBehavior.CloseConnection)
                    DR.Read()
                    Retorno = TSQL.CodigoRetorno(DR.GetString(0), Advertencia)
                End With
                If Retorno Then
                    MsgBox(Advertencia, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ACTUALIZACION DE PREDIO")
                Else
                    MsgBox(Advertencia, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ACTUALIZACION DE PREDIO")
                End If
            Catch ex As Exception
                MsgBox("ERROR : " & ex.ToString)
                Advertencia = "Fuente: " & ex.Source & vbCrLf & "Mensaje : " & ex.Message
                Retorno = False
            Finally
                If Not IsNothing(DR) Then
                    DR.Close()
                End If
                DR = Nothing
                CMD.Dispose()
                CMD = Nothing
            End Try
            Return Retorno
        End Function



        Public Function Registra_NuevaSoc(ByVal xml_identidad As String, ByVal User As String) As Boolean
            Dim CMD As New SqlCommand
            Dim Retorno As Boolean
            Dim DR As SqlDataReader = Nothing
            Try
                With CMD
                    .CommandText = "RADA_REG_NUEVA_SOCIEDAD"
                    .Connection = TSQL.ConexionPermanente
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@XML_Sociedad", xml_identidad)
                    .Parameters.AddWithValue("@Usuario", User)
                    If .Connection.State = ConnectionState.Closed Then
                        .Connection.Open()
                    End If
                    DR = .ExecuteReader(CommandBehavior.CloseConnection)
                    DR.Read()
                    Retorno = TSQL.CodigoRetorno(DR.GetString(0), Advertencia)
                End With
                If Retorno Then
                    MsgBox(Advertencia, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "REGISTRA NUEVA SOCIEDAD")
                Else
                    MsgBox(Advertencia, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "REGISTRA NUEVA SOCIEDAD")
                End If
            Catch ex As Exception
                MsgBox("ERROR : " & ex.ToString)
                Advertencia = "Fuente: " & ex.Source & vbCrLf & "Mensaje : " & ex.Message
                Retorno = False
            Finally
                If Not IsNothing(DR) Then
                    DR.Close()
                End If
                DR = Nothing
                CMD.Dispose()
                CMD = Nothing
            End Try
            Return Retorno
        End Function



#End Region









    End Class

End Namespace



