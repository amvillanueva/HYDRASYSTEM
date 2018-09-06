Imports HYDRASysTemDatosSQL.DAORada


Namespace ControlRada
    Public Class WFControlRAda : Inherits CentralBase


        Private Shared _Instancia As WFControlRAda = Nothing

        '-- Instancia unica de la clase
        Public Shared ReadOnly Property Instancia() As WFControlRAda
            Get
                If _Instancia Is Nothing Then
                    _Instancia = New WFControlRAda
                End If
                Return _Instancia
            End Get
        End Property





        Public Function fdu_Rada_Padron_Sociedad(ByVal incluirSociedad As Boolean) As DataTable
            Dim dt As DataTable
            Try
                dt = DAOControlRada.Instancia.fdu_Rada_Padron_Sociedad(incluirSociedad)
                ' DAOControlAlmacen.Instancia.fdu_ALM_ListarProductoAlmacen(periodoRecibido, idAlmacen)
                Advertencia = DAOControlRada.Instancia.Advertencia
            Catch ex As Exception
                Advertencia = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
                Return Nothing
            End Try
            Return dt
        End Function


        Public Function fdu_cargarCampañas() As DataTable
            Dim dt As DataTable
            Try
                dt = DAOControlRada.Instancia.fdu_cargarCampañas
                ' DAOControlAlmacen.Instancia.fdu_ALM_ListarProductoAlmacen(periodoRecibido, idAlmacen)
                Advertencia = DAOControlRada.Instancia.Advertencia
            Catch ex As Exception
                Advertencia = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
                Return Nothing
            End Try
            Return dt
        End Function

        Public Function fdu_cargarTipoIdentidad() As DataTable
            Dim dt As DataTable
            Try
                dt = DAOControlRada.Instancia.fdu_cargarTipoIdentidad
                ' DAOControlAlmacen.Instancia.fdu_ALM_ListarProductoAlmacen(periodoRecibido, idAlmacen)
                Advertencia = DAOControlRada.Instancia.Advertencia
            Catch ex As Exception
                Advertencia = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
                Return Nothing
            End Try
            Return dt
        End Function

        Public Function fdu_cargarComReg() As DataTable
            Dim dt As DataTable
            Try
                dt = DAOControlRada.Instancia.fdu_cargarComReg
                ' DAOControlAlmacen.Instancia.fdu_ALM_ListarProductoAlmacen(periodoRecibido, idAlmacen)
                Advertencia = DAOControlRada.Instancia.Advertencia
            Catch ex As Exception
                Advertencia = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
                Return Nothing
            End Try
            Return dt
        End Function


        Public Function fdu_CanalBLoqueComReg(ByVal comision As String) As DataTable
            Dim dt As DataTable
            Try
                dt = DAOControlRada.Instancia.fdu_CanalBLoqueComReg(comision)

                Advertencia = DAOControlRada.Instancia.Advertencia
            Catch ex As Exception
                Advertencia = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
                Return Nothing
            End Try
            Return dt
        End Function


        Public Function fdu_Predio_x_Id(ByVal campaña As String, ByVal identidad As String) As DataTable
            Dim dt As DataTable
            Try
                dt = DAOControlRada.Instancia.fdu_Predio_x_Id(identidad, campaña)
                ' DAOControlAlmacen.Instancia.fdu_ALM_ListarProductoAlmacen(periodoRecibido, idAlmacen)
                Advertencia = DAOControlRada.Instancia.Advertencia
            Catch ex As Exception
                Advertencia = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
                Return Nothing
            End Try
            Return dt
        End Function

        Public Function fdu_Predio_x_UnidadCatastral(ByVal campaña As String, ByVal uc As String) As DataTable
            Dim dt As DataTable
            Try
                dt = DAOControlRada.Instancia.fdu_Predio_x_UnidadCatastral(campaña, uc)
                ' DAOControlAlmacen.Instancia.fdu_ALM_ListarProductoAlmacen(periodoRecibido, idAlmacen)
                Advertencia = DAOControlRada.Instancia.Advertencia
            Catch ex As Exception
                Advertencia = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
                Return Nothing
            End Try
            Return dt
        End Function

        Public Function fdu_Predio_xCanal_OrdenA(ByVal campaña As String, ByVal ComReg As String) As DataTable
            Dim dt As DataTable
            Try
                dt = DAOControlRada.Instancia.fdu_Predio_x_Canal_OrdenA(campaña, ComReg)

                'Instancia.fdu_Predio_x_Id(identidad, campaña)
                ' DAOControlAlmacen.Instancia.fdu_ALM_ListarProductoAlmacen(periodoRecibido, idAlmacen)
                Advertencia = DAOControlRada.Instancia.Advertencia
            Catch ex As Exception
                Advertencia = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
                Return Nothing
            End Try
            Return dt
        End Function


        Public Function fdu_cargaCanales_Comision(ByVal cr As String, ByVal canal As String, ByVal tamarbol As Integer) As DataTable
            Dim dt As DataTable
            Try
                dt = DAOControlRada.Instancia.fdu_cargaCanales_Comision(cr, canal, tamarbol)

                'Instancia.fdu_Predio_x_Id(identidad, campaña)
                ' DAOControlAlmacen.Instancia.fdu_ALM_ListarProductoAlmacen(periodoRecibido, idAlmacen)
                Advertencia = DAOControlRada.Instancia.Advertencia
            Catch ex As Exception
                Advertencia = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
                Return Nothing
            End Try
            Return dt
        End Function




        Public Function fdu_cargaDatosPredio_Mantenimiento(ByVal predio As String, ByVal campana As String, ByVal comision As String) As DataTable
            Dim dt As DataTable
            Try
                dt = DAOControlRada.Instancia.fdu_cargaDatosPredio_Mantenimiento(predio, campana, comision)

                'Instancia.fdu_Predio_x_Id(identidad, campaña)
                ' DAOControlAlmacen.Instancia.fdu_ALM_ListarProductoAlmacen(periodoRecibido, idAlmacen)
                Advertencia = DAOControlRada.Instancia.Advertencia
            Catch ex As Exception
                Advertencia = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
                Return Nothing
            End Try
            Return dt
        End Function

#Region "UPDATE Y INSERTS"
        Public Function ModificaPredio(ByVal Predio As String, ByVal Campana As String,
                                    ByVal ComisionRegante As String, ByVal Unidad_Catastral As String, ByVal Predio_Nombre As String,
                                    ByVal PredioNro As String, ByVal Codigo As String, ByVal HaLicencia As Decimal, ByVal HaPermiso As Decimal,
                                    ByVal HaFiltracion As Decimal, ByVal HaBajo_Riego As Decimal, ByVal HaTotal As Decimal, ByVal Canal As String,
                                    ByVal Bloque_Riego As String, ByVal Comite_Regante As String, ByVal Orden_Riego As Decimal,
                                    ByVal Horas_Riego As Decimal, ByVal Volumen_Anual As Decimal, ByVal Resolucion As String, ByVal Fecha As String,
                                    ByVal Nuevo As String, ByVal Sancionado_Multa As String, ByVal Activo As String,
                                    ByVal CampanatoActualizar As String, ByVal Identidad As String, ByVal Observaciones As String,
                                    ByVal User As String) As Boolean
            Dim valor As Boolean = True
            Try
                valor = DAOControlRada.Instancia.ModificaPredio(Predio, Campana, ComisionRegante, Unidad_Catastral, Predio_Nombre,
                                     PredioNro, Codigo, HaLicencia, HaPermiso, HaFiltracion, HaBajo_Riego, HaTotal, Canal,
                                     Bloque_Riego, Comite_Regante, Orden_Riego, Horas_Riego, Volumen_Anual, Resolucion, Fecha,
                                     Nuevo, Sancionado_Multa, Activo, CampanatoActualizar, Identidad, Observaciones, User)
                Return valor
            Catch ex As Exception
                Advertencia = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
                Return Nothing
            End Try
            Return valor
        End Function


        Public Function Registra_NuevaSoc(ByVal xml_identidad As String, ByVal User As String) As Boolean
            Dim valor As Boolean = True
            Try
                valor = DAOControlRada.Instancia.Registra_NuevaSoc(xml_identidad, User)
                Return valor
            Catch ex As Exception
                Advertencia = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
                Return Nothing
            End Try
            Return valor
        End Function

#End Region

    End Class


End Namespace
