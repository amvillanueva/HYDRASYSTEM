'Clase donde se almacena los datos de inicio de sesion de cada usuario del sistema
Public NotInheritable Class SesionUsuario

    'Parametros de inicio de sesion
    Private Shared _IDSistema As Integer  'identificador del programa a validar
    Private Shared _IDPersona As Integer 'identificador del usuario como personal de la empresa
    Private Shared _Usuario As String    'usuario activo
    Private Shared _Nombre As String    'nombre completo del usuario activo
    Private Shared _IDSucursal As Integer 'identificador de la sede
    Private Shared _Sucursal As String  'descripcion de la sede
    Private Shared _SucursalRutaActualiza As String  'Ruta de actualizacion automática (DLLs) segun sede
    Private Shared _RutaTrip As String 'ruta local del .mdb del trip manager por sucursal
    Private Shared _CodEmpresa As String 'cod de la empresa
    Private Shared _Empresa As String  'nombre de la empresa
    'Private Shared _RUC As String  'Ruc de la empresa
    Private Shared _Permisos As DataTable  'lista de permisos y otros parametros del usuario en formato xml
    Private Shared _Remoto As Boolean 'me indica si la conexion al servidor es remota(true) o local(false)
    Private Shared _Administrador As Boolean
    Private Shared _AccesosPorUsuario As DataTable
    Private Shared _ImpresoraMatricial As String = String.Empty

    'PARAMETROS DE PLANILLAS
    Private Shared _CodigoEmpresa As String = String.Empty
    Private Shared _CodigoPlanilla As String = String.Empty
    Private Shared _NombrePlanilla As String = String.Empty
    Private Shared _CodigoTipoTrab As String = String.Empty
    Private Shared _CodigoOperacion As String = String.Empty
    Private Shared _RazonSocialEmpresa As String = String.Empty
    Private Shared _SiglasEmpresa As String = String.Empty
    Private Shared _RucEmpresa As String = String.Empty
    Private Shared _DireccionEmpresa As String = String.Empty
    Private Shared _CodigoCTS As String = String.Empty
    Private Shared _CodPeriocidad As String = String.Empty
    Private Shared _Periocidad As String = String.Empty

    'Parametros GPS
    Private Shared _StrCodsServTransporte As String = String.Empty
    Private Shared _XMLCodsServTransporte As String = String.Empty
    Private Shared _ServidorWeb As String = String.Empty

#Region "Sesion Usuario"

    Public Shared Property IDSistema() As Integer
        Get
            Return _IDSistema
        End Get
        Set(ByVal value As Integer)
            _IDSistema = value
        End Set
    End Property

    Public Shared Property IDPersona() As Integer
        Get
            Return _IDPersona
        End Get
        Set(ByVal value As Integer)
            _IDPersona = value
        End Set
    End Property

    Public Shared Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property

    Public Shared Property NombreUsuario() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Shared Property IDSucursal() As Integer
        Get
            Return _IDSucursal
        End Get
        Set(ByVal value As Integer)
            _IDSucursal = value
        End Set
    End Property

    Public Shared Property Sucursal() As String
        Get
            Return _Sucursal
        End Get
        Set(ByVal value As String)
            _Sucursal = value
        End Set
    End Property

    Public Shared Property SucursalRutaActualiza() As String
        Get
            Return _SucursalRutaActualiza
        End Get
        Set(ByVal value As String)
            _SucursalRutaActualiza = value
        End Set
    End Property

    Public Shared Property RutaTrip() As String
        Get
            Return _RutaTrip
        End Get
        Set(ByVal value As String)
            _RutaTrip = value
        End Set
    End Property

    Public Shared Property CodEmpresa() As String
        Get
            Return _CodEmpresa
        End Get
        Set(ByVal value As String)
            _CodEmpresa = value
        End Set
    End Property

    Public Shared Property Empresa() As String
        Get
            Return _Empresa
        End Get
        Set(ByVal value As String)
            _Empresa = value
        End Set
    End Property

    'Public Shared Property RUC() As String
    '    Get
    '        Return _RUC
    '    End Get
    '    Set(ByVal value As String)
    '        _RUC = value
    '    End Set
    'End Property


    Public Shared Property Permisos() As DataTable
        Get
            Return _Permisos
        End Get
        Set(ByVal value As DataTable)
            _AccesosPorUsuario = Nothing
            If Not value Is Nothing Then
                If Not IsDBNull(value) Then
                    If Not IsDBNull(value.Rows(0)("Permisos")) Then
                        _AccesosPorUsuario = XMLADataTable(value.Rows(0)("Permisos").ToString)
                        Dim cols(1) As DataColumn
                        'Creando el PrimaryKey (columna)para la Tabla
                        With _AccesosPorUsuario
                            If Not .Columns("Modulo") Is Nothing And Not .Columns("Nivel") Is Nothing Then
                                'indexa columna
                                cols(0) = .Columns("Modulo")
                                cols(1) = .Columns("Nivel")
                                .PrimaryKey = cols
                            End If
                        End With
                    End If

                    'Sectoristas
                    If Not IsDBNull(value.Rows(0)("Sectoristas")) Then
                        _StrCodsServTransporte = value.Rows(0)("Sectoristas").ToString().Trim() 'concatenado con comas
                        _XMLCodsServTransporte = XMLearST(value.Rows(0)("Sectoristas").ToString().Trim) 'en xml
                    End If
                End If
            End If
            _Permisos = value
        End Set
    End Property

    Public Shared Property Remoto() As Boolean
        Get
            Return _Remoto
        End Get
        Set(ByVal value As Boolean)
            _Remoto = value
        End Set
    End Property

    Public Shared Property Administrador() As Boolean
        Get
            Return _Administrador
        End Get
        Set(ByVal value As Boolean)
            _Administrador = value
        End Set
    End Property

    Public Shared Function udfActivarOpcion(ByVal pCodModulo As String) As Boolean
        Dim xDr() As DataRow
        xDr = _AccesosPorUsuario.Select("Modulo='" & pCodModulo & "'")
        If xDr.Length > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function udfActivarOpcion(ByVal pCodModulo As String, ByVal pCodNivel As String) As Boolean
        Dim wBuscarPK(1) As Object
        wBuscarPK(0) = pCodModulo
        wBuscarPK(1) = pCodNivel
        Dim foundRow As DataRow = _AccesosPorUsuario.Rows.Find(wBuscarPK)
        If Not (foundRow Is Nothing) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Cadena XML se recibe o en formato de atributos o de elementos
    Private Shared Function XMLADataTable(ByVal StrXML As String) As DataTable
        If StrXML.Length > 0 Then
            Dim Lector As IO.StringReader
            Dim DtaSetParaXML As New DataSet

            Lector = New IO.StringReader(StrXML) 'probar si aceopta directamente un DataTablke o haty que inzsertarle un dataset
            DtaSetParaXML.ReadXml(Lector)
            If DtaSetParaXML.Tables.Count > 0 Then
                Return DtaSetParaXML.Tables(0)
            End If
        End If
        Return Nothing
    End Function

    Public Shared Property ImpresoraMatricial() As String
        Get
            Return _ImpresoraMatricial
        End Get
        Set(ByVal value As String)
            _ImpresoraMatricial = value
        End Set
    End Property

#End Region

#Region "Credenciales de Conexión a Datos"

    Public Class SesionConexion

        Private Shared _ServidorSQL As String = String.Empty
        Private Shared _ServidorRpt As String = String.Empty
        Private Shared _ServidorRptNombre As String = String.Empty
        Private Shared _BaseDatos As String = String.Empty
        Private Shared _LoginUser As String = String.Empty 'sera usado para los reportes
        Private Shared _LoginClave As String = String.Empty 'sera usado para los reportes
        Private Shared _DsnNombre As String = String.Empty
        Private Shared _LoginUser_MAIN As String = String.Empty 'apunta al servidor principal
        Private Shared _LoginClave_MAIN As String = String.Empty
        Private Shared _DsnNombre_MAIN As String = String.Empty

        Public Shared Property ServidorDatos() As String
            Get
                Return _ServidorSQL
            End Get
            Set(ByVal value As String)
                _ServidorSQL = value
            End Set
        End Property

        Public Shared Property ServidorReportes() As String
            Get
                Return _ServidorRpt
            End Get
            Set(ByVal value As String)
                _ServidorRpt = value
            End Set
        End Property

        Public Shared Property ServidorRptNombre() As String
            Get
                Return _ServidorRptNombre
            End Get
            Set(ByVal value As String)
                _ServidorRptNombre = value
            End Set
        End Property

        Public Shared Property BaseDatos() As String
            Get
                Return _BaseDatos
            End Get
            Set(ByVal value As String)
                _BaseDatos = value
            End Set
        End Property

        Public Shared Property LoginUser() As String
            Get
                Return _LoginUser
            End Get
            Set(ByVal value As String)
                _LoginUser = value
            End Set
        End Property

        Public Shared Property LoginClave() As String
            Get
                Return _LoginClave
            End Get
            Set(ByVal value As String)
                _LoginClave = value
            End Set
        End Property

        Public Shared Property DsnNombre() As String
            Get
                Return _DsnNombre
            End Get
            Set(ByVal value As String)
                _DsnNombre = value
            End Set
        End Property

        Public Shared Property LoginUser_MAIN() As String
            Get
                Return _LoginUser_MAIN
            End Get
            Set(ByVal value As String)
                _LoginUser_MAIN = value
            End Set
        End Property

        Public Shared Property LoginClave_MAIN() As String
            Get
                Return _LoginClave_MAIN
            End Get
            Set(ByVal value As String)
                _LoginClave_MAIN = value
            End Set
        End Property

        Public Shared Property DsnNombre_MAIN() As String
            Get
                Return _DsnNombre_MAIN
            End Get
            Set(ByVal value As String)
                _DsnNombre_MAIN = value
            End Set
        End Property


        Public Sub New()

        End Sub
    End Class

#End Region

#Region "Sub-Clase para CAJA"

    Public Class SesionCaja

        'Parametros de aplicacion 'Caja'
        Private Shared _CodCaja As String = String.Empty
        Private Shared _NombreCaja As String = String.Empty
        Private Shared _FondoFijo As Decimal = 0
        Private Shared _Moneda As String = String.Empty
        Private Shared _SimboloMoneda As String = String.Empty
        Private Shared _CodEmpresaCaja As String = String.Empty
        Private Shared _EmpresaCaja As String = String.Empty
        Private Shared _LugarCaja As String = String.Empty
        Private Shared _FechaAperturaActiva As Date
        Private Shared _NroAperturaActiva As String
        Private Shared _MontoDisponibleAperturaActiva As Double


        Public Shared Property p_CodCaja() As String
            Get
                Return _CodCaja
            End Get
            Set(ByVal value As String)
                _CodCaja = value
            End Set
        End Property

        Public Shared Property p_NombreCaja() As String
            Get
                Return _NombreCaja
            End Get
            Set(ByVal value As String)
                _NombreCaja = value
            End Set
        End Property

        Public Shared Property p_FondoFijo() As Decimal
            Get
                Return _FondoFijo
            End Get
            Set(ByVal value As Decimal)
                _FondoFijo = value
            End Set
        End Property

        Public Shared Property p_Moneda() As String
            Get
                Return _Moneda
            End Get
            Set(ByVal value As String)
                _Moneda = value
            End Set
        End Property

        Public Shared Property p_SimboloMoneda() As String
            Get
                Return _SimboloMoneda
            End Get
            Set(ByVal value As String)
                _SimboloMoneda = value
            End Set
        End Property

        Public Shared Property p_EmpresaCaja() As String
            Get
                Return _EmpresaCaja
            End Get
            Set(ByVal value As String)
                _EmpresaCaja = value
            End Set
        End Property

        Public Shared Property p_CodEmpresaCaja() As String
            Get
                Return _CodEmpresaCaja
            End Get
            Set(ByVal value As String)
                _CodEmpresaCaja = value
            End Set
        End Property

        Public Shared Property p_FechaAperturaActiva() As Date
            Get
                Return _FechaAperturaActiva
            End Get
            Set(ByVal value As Date)
                _FechaAperturaActiva = value
            End Set
        End Property

        Public Shared Property p_Lugar() As String
            Get
                Return _LugarCaja
            End Get
            Set(ByVal value As String)
                _LugarCaja = value
            End Set
        End Property

        Public Shared Property p_NroAperuraActiva() As String
            Get
                Return _NroAperturaActiva
            End Get
            Set(ByVal value As String)
                _NroAperturaActiva = value
            End Set
        End Property

        Public Shared Property p_MontoDisponibleAperturaActiva() As Double
            Get
                Return _MontoDisponibleAperturaActiva
            End Get
            Set(ByVal value As Double)
                _MontoDisponibleAperturaActiva = value
            End Set
        End Property

    End Class

#End Region

#Region "Sub-Clase para ALMACEN"

    Public Class SesionAlmacen
        Private Shared _CodAlmacen As String = String.Empty
        Private Shared _Almacen As String = String.Empty

        Public Structure sCentroCostos
            Dim i As Integer
            Private Shared _IDCCostoN1 As Integer = -1
            Private Shared _CCostoN1 As String = String.Empty
            Private Shared _IDCCostoN2 As Integer = -1
            Private Shared _CCostoN2 As String = String.Empty
            Private Shared _IDCCostoN3 As Integer = -1
            Private Shared _CCostoN3 As String = String.Empty
            Private Shared _IDCCostoN4 As Integer = -1
            Private Shared _CCostoN4 As String = String.Empty
            Private Shared _IDCCostoV2 As Integer = -1
            Private Shared _CCostoV2 As String = String.Empty

            Public Shared Property IDCCN1() As Integer
                Get
                    Return _IDCCostoN1
                End Get
                Set(ByVal value As Integer)
                    _IDCCostoN1 = value
                End Set
            End Property

            Public Shared Property IDCCN2() As Integer
                Get
                    Return _IDCCostoN2
                End Get
                Set(ByVal value As Integer)
                    _IDCCostoN2 = value
                End Set
            End Property

            Public Shared Property IDCCN3() As Integer
                Get
                    Return _IDCCostoN3
                End Get
                Set(ByVal value As Integer)
                    _IDCCostoN3 = value
                End Set
            End Property

            Public Shared Property IDCCN4() As Integer
                Get
                    Return _IDCCostoN4
                End Get
                Set(ByVal value As Integer)
                    _IDCCostoN4 = value
                End Set
            End Property

            Public Shared Property IDCCostoV2() As Integer
                Get
                    Return _IDCCostoV2
                End Get
                Set(ByVal value As Integer)
                    _IDCCostoV2 = value
                End Set
            End Property

            Public Shared Property CCN1() As String
                Get
                    Return _CCostoN1
                End Get
                Set(ByVal value As String)
                    _CCostoN1 = value
                End Set
            End Property

            Public Shared Property CCN2() As String
                Get
                    Return _CCostoN2
                End Get
                Set(ByVal value As String)
                    _CCostoN2 = value
                End Set
            End Property

            Public Shared Property CCN3() As String
                Get
                    Return _CCostoN3
                End Get
                Set(ByVal value As String)
                    _CCostoN3 = value
                End Set
            End Property

            Public Shared Property CCN4() As String
                Get
                    Return _CCostoN4
                End Get
                Set(ByVal value As String)
                    _CCostoN4 = value
                End Set
            End Property

            Public Shared Property CCostoV2() As String
                Get
                    Return _CCostoV2
                End Get
                Set(ByVal value As String)
                    _CCostoV2 = value
                End Set
            End Property

        End Structure

        Public Shared Property CodAlmacen() As String
            Get
                Return _CodAlmacen
            End Get
            Set(ByVal value As String)
                _CodAlmacen = value
            End Set
        End Property

        Public Shared Property Almacen() As String
            Get
                Return _Almacen
            End Get
            Set(ByVal value As String)
                _Almacen = value
            End Set
        End Property

    End Class

#End Region

#Region "Modulo de Recursos Humanos"
    Public Shared Property CodigoEmpresa() As String
        Get
            Return _CodigoEmpresa
        End Get
        Set(ByVal value As String)
            _CodigoEmpresa = value
        End Set
    End Property
    Public Shared Property CodigoPlanilla() As String
        Get
            Return _CodigoPlanilla
        End Get
        Set(ByVal value As String)
            _CodigoPlanilla = value
        End Set
    End Property
    Public Shared Property NombrePlanilla() As String
        Get
            Return _NombrePlanilla
        End Get
        Set(ByVal value As String)
            _NombrePlanilla = value
        End Set
    End Property
    Public Shared Property CodigoTipoTrab() As String
        Get
            Return _CodigoTipoTrab
        End Get
        Set(ByVal value As String)
            _CodigoTipoTrab = value
        End Set
    End Property
    Public Shared Property CodigoOperacion() As String
        Get
            Return _CodigoOperacion
        End Get
        Set(ByVal value As String)
            _CodigoOperacion = value
        End Set
    End Property
    Public Shared Property DireccionEmpresa() As String
        Get
            Return _DireccionEmpresa
        End Get
        Set(ByVal value As String)
            _DireccionEmpresa = value
        End Set
    End Property
    Public Shared Property RazonSocialEmpresa() As String
        Get
            Return _RazonSocialEmpresa
        End Get
        Set(ByVal value As String)
            _RazonSocialEmpresa = value
        End Set
    End Property
    Public Shared Property SiglasEmpresa() As String
        Get
            Return _SiglasEmpresa
        End Get
        Set(ByVal value As String)
            _SiglasEmpresa = value
        End Set
    End Property
    Public Shared Property RucEmpresa() As String
        Get
            Return _RucEmpresa
        End Get
        Set(ByVal value As String)
            _RucEmpresa = value
        End Set
    End Property
    Public Shared Property CodigoCTS() As String
        Get
            Return _CodigoCTS
        End Get
        Set(ByVal value As String)
            _CodigoCTS = value
        End Set
    End Property
    Public Shared Property CodigoPeriocidad() As String
        Get
            Return _CodPeriocidad
        End Get
        Set(ByVal value As String)
            _CodPeriocidad = value
        End Set
    End Property
    Public Shared Property Periocidad() As String
        Get
            Return _Periocidad
        End Get
        Set(ByVal value As String)
            _Periocidad = value
        End Set
    End Property
#End Region

#Region "Módulo GPS"

    Public Shared ReadOnly Property StrCodsServTransporte() As String
        Get
            Return _StrCodsServTransporte
        End Get
    End Property

    Public Shared ReadOnly Property XMLCodsServTransporte() As String
        Get
            Return _XMLCodsServTransporte
        End Get
    End Property

    Private Shared Function XMLearST(ByVal CST As String) As String
        Dim oStrXML As String = String.Empty

        oStrXML = CST
        Select Case CST
            Case "T"
            Case String.Empty
            Case Else
                Dim x As Integer = 0
                Dim oArr() As String = CST.Split(",")
                oStrXML = "<r>"
                For x = 0 To oArr.GetUpperBound(0)
                    'oStrXML = String.Format("{0}<d CodServicio=""{1}""", oArr(x), oStrXML)
                    oStrXML = oStrXML & String.Format("<d CodServicio=""{0}"" />", oArr(x))
                Next
                oStrXML &= "</r>"
        End Select

        Return oStrXML
    End Function

    'Este luego puede ser reemplazado por un dominio
    Public Shared ReadOnly Property ServidorWeb() As String
        Get
            If _Remoto = False Then
                '     _ServidorWeb = "http://100.100.100.202:8081/LocalGPS/"
            Else
                '     _ServidorWeb = "http://190.81.24.129:8081/RemotoGPS/"
            End If
            Return _ServidorWeb
        End Get

    End Property

    'Solo pra efectos de prueba local
    Public Shared ReadOnly Property ServidorPruebaWeb() As String
        Get
            If _Remoto = False Then
                _ServidorWeb = "http://localhost/LocalGPS/"
            Else
                _ServidorWeb = "http://localhost/RemotoGPS/"
            End If
            Return _ServidorWeb
        End Get

    End Property

#End Region

#Region "Modulo Mercaderias"

    Public Class Mercaderia

        Private Shared _CodServTransp As String = String.Empty
        Private Shared _ServicioTransporte As String = String.Empty
        Private Shared _IDSerie As Integer = -1
        Private Shared _Serie As String = String.Empty
        Private Shared _Descripcion As String = String.Empty
        Private Shared _CodEmpresa As String = String.Empty
        Private Shared _Empresa As String = String.Empty
        Private Shared _IDCliente As Integer = -1
        Private Shared _Cliente As String = String.Empty
        Private Shared _IDPuntoControl As Integer = -1
        Private Shared _IDUsuario As Integer = -1

        Public Shared Property CodServTransp() As String
            Get
                Return _CodServTransp
            End Get
            Set(ByVal value As String)
                _CodServTransp = value
            End Set
        End Property

        Public Shared ReadOnly Property ServicioTransporte() As String
            Get
                Return _ServicioTransporte
            End Get
        End Property

        Public Shared ReadOnly Property IDSerie() As Integer
            Get
                Return _IDSerie
            End Get
        End Property

        Public Shared ReadOnly Property Serie() As String
            Get
                Return _Serie
            End Get
        End Property

        Public Shared ReadOnly Property Descripcion() As String
            Get
                Return _Descripcion
            End Get
        End Property

        Public Shared ReadOnly Property CodEmpresa() As String
            Get
                Return _CodEmpresa
            End Get
        End Property

        Public Shared ReadOnly Property RucEmpresa() As String
            Get
                Return _RucEmpresa
            End Get
        End Property

        Public Shared ReadOnly Property IDCliente() As Integer
            Get
                Return _IDCliente
            End Get
        End Property

        Public Shared ReadOnly Property Cliente() As String
            Get
                Return _Cliente
            End Get
        End Property

        Public Shared ReadOnly Property IDPuntoControl() As Integer
            Get
                Return _IDPuntoControl
            End Get
        End Property

        Public Shared ReadOnly Property IDUsuario() As Integer
            Get
                Return _IDUsuario
            End Get
        End Property

        ''Public Shared Function SeleccionarSerieGRT(ByVal oDtSeries As DataTable, ByVal IDSerie As Integer) As Boolean
        ''    _CodServTransp = String.Empty
        ''    _ServicioTransporte = String.Empty
        ''    _IDSerie = -1
        ''    _Serie = String.Empty
        ''    _Descripcion = String.Empty
        ''    _CodEmpresa = String.Empty
        ''    _Empresa = String.Empty
        ''    _IDPuntoControl = -1
        ''    If oDtSeries Is Nothing Then Return False
        ''    Try
        ''        Dim oDV As New DataView(oDtSeries, String.Format("IDSerieGRT={0}", IDSerie), "", DataViewRowState.OriginalRows)
        ''        If oDV.Count = 1 Then
        ''            With oDV.Item(0)
        ''                _CodServTransp = .Item("CodServTransp")
        ''                _ServicioTransporte = .Item("Servicio")
        ''                _IDSerie = .Item("IDSerieGRT")
        ''                _Serie = .Item("Serie")
        ''                _Descripcion = .Item("Descripcion")
        ''                _CodEmpresa = .Item("CodEmpresa")
        ''                _Empresa = .Item("Empresa")
        ''                _IDCliente = If(.Item("IDCliente") Is DBNull.Value, -1, .Item("IDCliente"))
        ''                _Cliente = If(.Item("Cliente") Is DBNull.Value, String.Empty, .Item("Cliente"))
        ''                _IDPuntoControl = .Item("IDPunto")
        ''                _IDUsuario = .Item("IDUsuario")
        ''                ' _RucEmpresa = .Item("RUC")
        ''            End With
        ''            oDV = Nothing
        ''            Return True
        ''        ElseIf oDV.Count = 0 Then
        ''            MsgBox("Existen identificadores de Series Duplicados...", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        ''            Return False
        ''        End If
        ''    Catch ex As Exception
        ''        MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, "Error")
        ''        Return False
        ''    End Try
        ''End Function

        Public Sub New()

        End Sub


        Public Shared Function VerificarSeieGRT() As Boolean
            Return _IDSerie > 0
        End Function

    End Class

#End Region

End Class
