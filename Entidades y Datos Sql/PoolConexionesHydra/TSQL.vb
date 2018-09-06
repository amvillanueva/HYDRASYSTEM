
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.Odbc
Imports HYDRAEntidades

Public Class TSQL

    'Conexion global compartida al servidor de datos
    Private Shared Mensaje As String = String.Empty
    Private Shared WithEvents temporizador As Timers.Timer
    Private Shadows Const TESPERA As Short = 10 '10 minutos

    Private Shared _conexionPerm_PRUEBA As SqlConnection


    Private Shared Sub ControlarTiempoInactividad(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles temporizador.Elapsed
        If VigilanteConexion.TiempoInactividad.Minutes > TESPERA Then
            If Not VigilanteConexion.CnnActual Is Nothing Then
                VigilanteConexion.CnnActual.Close()
                VigilanteConexion.CnnActual = Nothing
            End If
            temporizador.Stop() 'ver si esta accion no hace inestable la aplicacion
        End If
    End Sub

    Public NotInheritable Class VigilanteConexion
        Private Shared _HoraUltimaGestion As Date = #12:00:00 AM# 'ulitmo registro de operacion con la base de datos
        Private Shared _CnnActual As SqlConnection = Nothing 'conexion al servidor de datos
        Private Shared _CadenaConexion As String = String.Empty 'cadena de conexion del usuario al servidor de datos

        Public Shared Property HoraUltimaOperacion() As Date
            Get
                Return _HoraUltimaGestion
            End Get
            Set(ByVal value As Date)
                _HoraUltimaGestion = value
            End Set
        End Property

        Public Shared ReadOnly Property TiempoInactividad() As TimeSpan
            Get
                Return Date.Now - _HoraUltimaGestion 'propio de cada PC particular
            End Get
        End Property

        Public Shared Property CnnActual() As SqlConnection
            Get
                Return _CnnActual
            End Get
            Set(ByVal value As SqlConnection)
                _CnnActual = value
            End Set
        End Property

        Public Shared Property CadenaConexion() As String
            Get
                Return _CadenaConexion
            End Get
            Set(ByVal value As String)
                _CadenaConexion = value
            End Set
        End Property

    End Class



    'Establece una conexion permanente al servidor de datos en caso no exista una
    Public Shared Property ConexionPermanente() As SqlConnection
        Get
            'Try
            '    If VigilanteConexion.CnnActual Is Nothing Then

            '        VigilanteConexion.CnnActual = New SqlConnection(VigilanteConexion.CadenaConexion)
            '        VigilanteConexion.CnnActual.Open()
            '        'Lanzo temporizador
            '        VigilanteConexion.HoraUltimaOperacion = Date.Now
            '        temporizador.Start()

            '    Else
            '        If VigilanteConexion.CnnActual.State = ConnectionState.Closed Then
            '            VigilanteConexion.CnnActual.Open()
            '            'Lanzo temporizador
            '            VigilanteConexion.HoraUltimaOperacion = Date.Now
            '            temporizador.Start()
            '        End If

            '    End If
            'Catch ex As Exception
            '    Mensaje = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
            '    VigilanteConexion.CnnActual = Nothing
            '    If temporizador.Enabled Then
            '        temporizador.Stop()
            '    End If
            'End Try
            'Return VigilanteConexion.CnnActual
            Return _conexionPerm_PRUEBA
        End Get
        'esto se agrego solo para prueba
        Set(ByVal value As SqlConnection)
            _conexionPerm_PRUEBA = value
        End Set
        'eliminar hasta aca
    End Property

    'Dar por concluida una conexion permanente al servidor de datos
    Public ReadOnly Property CerrarConexionPermanente() As Boolean
        Get
            If VigilanteConexion.CnnActual Is Nothing Then 'verifico si la conexion es valida
                Try
                    If VigilanteConexion.CnnActual.State <> ConnectionState.Closed Then
                        VigilanteConexion.CnnActual.Close()
                    End If
                    VigilanteConexion.CnnActual = Nothing

                Catch ex As Exception
                    Mensaje = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
                    VigilanteConexion.CnnActual = Nothing
                    Return False
                End Try
            End If
            If temporizador.Enabled Then
                temporizador.Stop()
            End If
            Return True
        End Get
    End Property

    'Retorna el ultimo mensaje dado por la clase o por el servidor de datos
    Public Shared ReadOnly Property UltimoMensaje() As String
        Get
            Return Mensaje
        End Get
    End Property

#Region "Validacion al servidor"


    'Public Function SolicitarConexionAlSistema(ByVal User As String, ByVal ClaveEnc As String, ByRef Validado As Boolean) As DataTable
    ''Dim dt As New DataTable
    ''Dim SqlCmd As New SqlCommand
    ''Dim SqlDt As SqlDataAdapter

    ''Validado = False
    ''Try
    ''    'Creo una conexion al servidor de datos
    ''    Dim SqlCnn As New SqlConnection(CnnSQLServer())
    ''    SqlCnn.Open()

    ''    'Asigno el comando de solicitud de inicio de sesion
    ''    SqlCmd.CommandText = "Sistemas.SpSis_SolicitarConexionAlSistema"
    ''    SqlCmd.CommandTimeout = 300
    ''    SqlCmd.CommandType = CommandType.StoredProcedure
    ''    SqlCmd.Connection = SqlCnn

    ''    '-- Adiciono los parametros de entrada --
    ''    Dim SqlPrm As New SqlParameter("@IdSistema", SesionUsuario.IDSistema) ' idaplicacion
    ''    SqlCmd.Parameters.Add(SqlPrm)

    ''    SqlPrm = New SqlParameter("@Usuario", User)
    ''    SqlCmd.Parameters.Add(SqlPrm)

    ''    SqlPrm = New SqlParameter("@ClaveEnc", ClaveEnc)
    ''    SqlCmd.Parameters.Add(SqlPrm)

    ''    'Datos de equipo que intenta conectarse...            
    ''    If CheckEquipo.EquipoNombre.Length > 0 Then
    ''        SqlCmd.Parameters.AddWithValue("@EquipoNombre", CheckEquipo.EquipoNombre)
    ''        SqlCmd.Parameters.AddWithValue("@HDDSerie", CheckEquipo.HDDSerie)
    ''        SqlCmd.Parameters.AddWithValue("@PlacaMadreSerie", CheckEquipo.PlacaMadreSerie)
    ''        SqlCmd.Parameters.AddWithValue("@PlacaMadreTipo", CheckEquipo.PlacaMadreTipo)
    ''        SqlCmd.Parameters.AddWithValue("@PlacaMadreMarca", CheckEquipo.PlacaMadreMarca)
    ''        SqlCmd.Parameters.AddWithValue("@ProcesadorSerie", CheckEquipo.ProcesadorSerie)
    ''        SqlCmd.Parameters.AddWithValue("@ProcesadorTipo", CheckEquipo.ProcesadorTipo)
    ''        SqlCmd.Parameters.AddWithValue("@ProcesadorMarca", CheckEquipo.ProcesadorMarca)
    ''    End If

    ''    '-- Adiciono variables de retorno --
    ''    SqlPrm = New SqlParameter("@IdLocal", SqlDbType.Int)
    ''    SqlPrm.Direction = ParameterDirection.Output
    ''    SqlCmd.Parameters.Add(SqlPrm)

    ''    SqlPrm = New SqlParameter("@Local", SqlDbType.VarChar, 100)
    ''    SqlPrm.Direction = ParameterDirection.Output
    ''    SqlCmd.Parameters.Add(SqlPrm)


    ''    SqlPrm = New SqlParameter("@RutaTrip", SqlDbType.VarChar, 250)
    ''    SqlPrm.Direction = ParameterDirection.Output
    ''    SqlCmd.Parameters.Add(SqlPrm)


    ''    SqlPrm = New SqlParameter("@NombreUser", SqlDbType.VarChar, 100)
    ''    SqlPrm.Direction = ParameterDirection.Output
    ''    SqlCmd.Parameters.Add(SqlPrm)

    ''    SqlPrm = New SqlParameter("@IdPersona", SqlDbType.Int)
    ''    SqlPrm.Direction = ParameterDirection.Output
    ''    SqlCmd.Parameters.Add(SqlPrm)

    ''    SqlPrm = New SqlParameter("@CodEmpresa", SqlDbType.Char, 2)
    ''    SqlPrm.Direction = ParameterDirection.Output
    ''    SqlCmd.Parameters.Add(SqlPrm)

    ''    SqlPrm = New SqlParameter("@Empresa", SqlDbType.VarChar, 100)
    ''    SqlPrm.Direction = ParameterDirection.Output
    ''    SqlCmd.Parameters.Add(SqlPrm)

    ''    SqlPrm = New SqlParameter("@Credenciales", SqlDbType.VarChar, 200)
    ''    SqlPrm.Direction = ParameterDirection.Output
    ''    SqlCmd.Parameters.Add(SqlPrm)

    ''    SqlPrm = New SqlParameter("@Remoto", SqlDbType.Bit)
    ''    SqlPrm.Direction = ParameterDirection.Output
    ''    SqlCmd.Parameters.Add(SqlPrm)

    ''    SqlPrm = New SqlParameter("@Exito", SqlDbType.VarChar, 250)
    ''    SqlPrm.Direction = ParameterDirection.Output
    ''    SqlCmd.Parameters.Add(SqlPrm)

    ''    'Ejecuto el SP
    ''    SqlDt = New SqlDataAdapter(SqlCmd)
    ''    SqlDt.Fill(dt)

    ''    'Capturar los valores de retorno si el usuario fue autenticado
    ''    If CodigoRetorno(SqlCmd.Parameters("@Exito").Value, Mensaje) Then
    ''        SesionUsuario.IDSucursal = SqlCmd.Parameters("@IdLocal").Value
    ''        SesionUsuario.Sucursal = SqlCmd.Parameters("@Local").Value
    ''        SesionUsuario.RutaTrip = SqlCmd.Parameters("@RutaTrip").Value
    ''        SesionUsuario.Usuario = User
    ''        SesionUsuario.NombreUsuario = SqlCmd.Parameters("@NombreUser").Value
    ''        SesionUsuario.IDPersona = SqlCmd.Parameters("@IdPersona").Value
    ''        SesionUsuario.CodEmpresa = SqlCmd.Parameters("@CodEmpresa").Value
    ''        SesionUsuario.Empresa = SqlCmd.Parameters("@Empresa").Value
    ''        VigilanteConexion.CadenaConexion = SqlCmd.Parameters("@Credenciales").Value
    ''        SesionUsuario.Remoto = SqlCmd.Parameters("@Remoto").Value

    ''        'Desdoblamos la cadena de conexión es sus partes
    ''        Dim strCnx As String = VigilanteConexion.CadenaConexion
    ''        Dim Prms() As String = Nothing

    ''        Prms = strCnx.Split(";")
    ''        If Prms.Length >= 4 Then
    ''            'El orden como se espera que este formada la cadena de conexión
    ''            'es importante que se mantenga
    ''            SesionUsuario.SesionConexion.ServidorDatos = Prms(0).Trim.Substring(Prms(0).Trim.IndexOf("=") + 1).Trim()
    ''            SesionUsuario.SesionConexion.BaseDatos = Prms(1).Trim.Substring(Prms(1).Trim.IndexOf("=") + 1).Trim()
    ''            SesionUsuario.SesionConexion.LoginUser = Prms(2).Trim.Substring(Prms(2).Trim.IndexOf("=") + 1).Trim()
    ''            SesionUsuario.SesionConexion.LoginClave = Prms(3).Trim.Substring(Prms(3).Trim.IndexOf("=") + 1).Trim()
    ''        End If

    ''        Validado = True
    ''    Else
    ''        dt = Nothing
    ''    End If

    ''Catch ex As Exception
    ''    Mensaje = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
    ''    Validado = False
    ''    dt = Nothing
    ''Finally
    ''    SqlDt = Nothing
    ''    SqlCmd = Nothing
    ''End Try

    ''Return dt

    ''End Function


    Public Function fdu_SolicitarConexionAlSistema(ByVal User As String, ByVal ClaveEnc As String, ByRef Validado As Boolean) As DataTable
        Dim dt As New DataTable
        Dim mconn As New OdbcConnection(DsnODBC)
        Dim xEsPruebas As Boolean = False

        'Create the ODBC objects
        Dim OdbcCmd As System.Data.Odbc.OdbcCommand
        'Instantiate new instances
        OdbcCmd = New System.Data.Odbc.OdbcCommand
        OdbcCmd.CommandText = "{call central.[Sistemas].[SpSis_SolicitarConexionAlSistemaV2] (?,?,?,?,?,?,?,?,?,?,?,?,?)}"
        OdbcCmd.CommandType = CommandType.StoredProcedure
        OdbcCmd.Connection = mconn

        Validado = False

        Try
            '-- Adiciono los parametros de entrada --
            OdbcCmd.Parameters.AddWithValue("@IdSistema", SesionUsuario.IDSistema) ' idaplicacion
            OdbcCmd.Parameters.AddWithValue("@Usuario", User)
            OdbcCmd.Parameters.AddWithValue("@ClaveEnc", ClaveEnc)
            '-- Adiciono variables de retorno --
            OdbcCmd.Parameters.Add("@IdLocal", Odbc.OdbcType.Int).Direction = ParameterDirection.Output
            OdbcCmd.Parameters.Add("@Local", Odbc.OdbcType.VarChar, 100).Direction = ParameterDirection.Output
            OdbcCmd.Parameters.Add("@RutaTrip", Odbc.OdbcType.VarChar, 250).Direction = ParameterDirection.Output
            OdbcCmd.Parameters.Add("@NombreUser", Odbc.OdbcType.VarChar, 100).Direction = ParameterDirection.Output
            OdbcCmd.Parameters.Add("@IdPersona", Odbc.OdbcType.Int).Direction = ParameterDirection.Output
            OdbcCmd.Parameters.Add("@CodEmpresa", Odbc.OdbcType.Char, 2).Direction = ParameterDirection.Output
            OdbcCmd.Parameters.Add("@Empresa", Odbc.OdbcType.VarChar, 100).Direction = ParameterDirection.Output
            OdbcCmd.Parameters.Add("@Credenciales", Odbc.OdbcType.VarChar, 200).Direction = ParameterDirection.Output
            OdbcCmd.Parameters.Add("@Remoto", Odbc.OdbcType.Bit).Direction = ParameterDirection.Output
            OdbcCmd.Parameters.Add("@Exito", Odbc.OdbcType.VarChar, 250).Direction = ParameterDirection.Output


            '-- Chequea si conexión es de pruebas --
            If InStr(DsnODBC, "uid=test") > 0 Or InStr(DsnODBC, "uid=sa") > 0 Then
                xEsPruebas = True
            End If
            'Datos de equipo que intenta conectarse...            
            If CheckEquipo.EquipoNombre.Length > 0 And xEsPruebas = False Then
                '-- Configurando nuevos parámetros --
                OdbcCmd.CommandText = OdbcCmd.CommandText.Replace("?)", "?,?,?,?,?,?,?,?,?)")
                '-- agrega los nuevos parámetros --
                OdbcCmd.Parameters.AddWithValue("@EquipoNombre", CheckEquipo.EquipoNombre)
                OdbcCmd.Parameters.AddWithValue("@PlacaMadreSerie", CheckEquipo.PlacaMadreSerie)
                OdbcCmd.Parameters.AddWithValue("@PlacaMadreTipo", CheckEquipo.PlacaMadreTipo)
                OdbcCmd.Parameters.AddWithValue("@PlacaMadreMarca", CheckEquipo.PlacaMadreMarca)
                OdbcCmd.Parameters.AddWithValue("@ProcesadorSerie", CheckEquipo.ProcesadorSerie)
                OdbcCmd.Parameters.AddWithValue("@ProcesadorTipo", CheckEquipo.ProcesadorTipo)
                OdbcCmd.Parameters.AddWithValue("@ProcesadorMarca", CheckEquipo.ProcesadorMarca)
                OdbcCmd.Parameters.AddWithValue("@HDDSerie", CheckEquipo.HDDSerie)
            Else
                '-- Configurando nuevos parámetros --
                OdbcCmd.CommandText = OdbcCmd.CommandText.Replace("?)", "?,?,?,?,?,?,?,?,?)")
                '-- agrega los nuevos parámetros --
                OdbcCmd.Parameters.AddWithValue("@EquipoNombre", "DESCONOCIDO")
                OdbcCmd.Parameters.AddWithValue("@PlacaMadreSerie", "DESCONOCIDO")
                OdbcCmd.Parameters.AddWithValue("@PlacaMadreTipo", "DESCONOCIDO")
                OdbcCmd.Parameters.AddWithValue("@PlacaMadreMarca", "DESCONOCIDO")
                OdbcCmd.Parameters.AddWithValue("@ProcesadorSerie", "DESCONOCIDO")
                OdbcCmd.Parameters.AddWithValue("@ProcesadorTipo", "DESCONOCIDO")
                OdbcCmd.Parameters.AddWithValue("@ProcesadorMarca", "DESCONOCIDO")
                OdbcCmd.Parameters.AddWithValue("@HDDSerie", "DESCONOCIDO")
            End If

            OdbcCmd.CommandText = OdbcCmd.CommandText.Replace("?)", "?,?,?,?,?)")
            OdbcCmd.Parameters.Add("@NomServSecundario", Odbc.OdbcType.VarChar, 50).Direction = ParameterDirection.Output
            OdbcCmd.Parameters.Add("@NroIPReportes", Odbc.OdbcType.VarChar, 50).Direction = ParameterDirection.Output
            OdbcCmd.Parameters.Add("@LoginRpt", Odbc.OdbcType.VarChar, 20).Direction = ParameterDirection.Output
            OdbcCmd.Parameters.Add("@ClaveRpt", Odbc.OdbcType.VarChar, 20).Direction = ParameterDirection.Output

            mconn.Open()

            Dim OdbcDt As OdbcDataAdapter
            OdbcDt = New OdbcDataAdapter(OdbcCmd)
            OdbcDt.Fill(dt)


            'close the connection
            mconn.Close()

            'Capturar los valores de retorno si el usuario fue autenticado
            If CodigoRetorno(OdbcCmd.Parameters("@Exito").Value, Mensaje) Then
                SesionUsuario.IDSucursal = OdbcCmd.Parameters("@IdLocal").Value
                SesionUsuario.Sucursal = OdbcCmd.Parameters("@Local").Value
                SesionUsuario.RutaTrip = OdbcCmd.Parameters("@RutaTrip").Value
                SesionUsuario.Usuario = User
                SesionUsuario.NombreUsuario = OdbcCmd.Parameters("@NombreUser").Value
                SesionUsuario.IDPersona = OdbcCmd.Parameters("@IdPersona").Value
                SesionUsuario.CodEmpresa = OdbcCmd.Parameters("@CodEmpresa").Value
                SesionUsuario.Empresa = OdbcCmd.Parameters("@Empresa").Value
                VigilanteConexion.CadenaConexion = OdbcCmd.Parameters("@Credenciales").Value
                SesionUsuario.Remoto = OdbcCmd.Parameters("@Remoto").Value

                'Desdoblamos la cadena de conexión es sus partes
                Dim strCnx As String = VigilanteConexion.CadenaConexion
                Dim Prms() As String = Nothing

                Prms = strCnx.Split(";")
                If Prms.Length >= 4 Then
                    'El orden como se espera que este formada la cadena de conexión
                    'es importante que se mantenga
                    SesionUsuario.SesionConexion.ServidorDatos = Prms(0).Trim.Substring(Prms(0).Trim.IndexOf("=") + 1).Trim()
                    SesionUsuario.SesionConexion.BaseDatos = Prms(1).Trim.Substring(Prms(1).Trim.IndexOf("=") + 1).Trim()
                    'Credenciales servidor secundario
                    SesionUsuario.SesionConexion.DsnNombre = "CnnGEAC"
                    SesionUsuario.SesionConexion.LoginUser = OdbcCmd.Parameters("@LoginRpt").Value
                    SesionUsuario.SesionConexion.LoginClave = OdbcCmd.Parameters("@ClaveRpt").Value
                    SesionUsuario.SesionConexion.ServidorReportes = OdbcCmd.Parameters("@NroIPReportes").Value
                    SesionUsuario.SesionConexion.ServidorRptNombre = OdbcCmd.Parameters("@NomServSecundario").Value
                    '''''''
                    '
                    'Credenciales servidor principal
                    SesionUsuario.SesionConexion.LoginUser_MAIN = Prms(2).Trim.Substring(Prms(2).Trim.IndexOf("=") + 1).Trim()
                    SesionUsuario.SesionConexion.LoginClave_MAIN = Prms(3).Trim.Substring(Prms(3).Trim.IndexOf("=") + 1).Trim()
                    SesionUsuario.SesionConexion.DsnNombre_MAIN = "CnnLogin"
                    '''''''
                    'Select Case User
                    '    Case "ecastillo", "rloyola"
                    '        SesionUsuario.SesionConexion.LoginUser = "user_rptgeac"
                    '        SesionUsuario.SesionConexion.LoginClave = "u$ser_rptgea1c"
                    '    Case Else
                    '        SesionUsuario.SesionConexion.LoginUser = Prms(2).Trim.Substring(Prms(2).Trim.IndexOf("=") + 1).Trim()
                    '        SesionUsuario.SesionConexion.LoginClave = Prms(3).Trim.Substring(Prms(3).Trim.IndexOf("=") + 1).Trim()
                    'End Select

                End If


                '-- extrayendo DSN de cadena ODBC
                'Dim dsn() As String = DsnODBC.Split(";")
                'If dsn.Length > 0 Then
                '    SesionUsuario.SesionConexion.DsnNombre = dsn(0).Trim.Substring(dsn(0).Trim.IndexOf("=") + 1).Trim()
                'End If

                Validado = True
            Else
                dt = Nothing
            End If

        Catch ex As Exception
            Mensaje = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
            Validado = False
            dt = Nothing
        Finally
            mconn.Close()
        End Try
        Return dt
    End Function

    'Cambiar la clave de un usuario
    'Public Function SolicitarCambioDeClave(ByVal Usuario As String, ByVal OldClaveEnc As String, ByVal NewClaveEnc As String) As Boolean
    '    ''Dim Retorno As Boolean = True
    '    ''Dim SqlCmd As New SqlCommand
    '    ''Dim SqlPrm As SqlParameter
    '    ''Dim Dr As SqlDataReader = Nothing

    '    ''Try
    '    ''    Dim dt As New DataTable
    '    ''    'Creo una conexion al servidor de datos
    '    ''    Dim SqlCnn As New SqlConnection(CnnSQLServer())
    '    ''    SqlCnn.Open()

    '    ''    'Asigno el comando de solicitud de inicio de sesion
    '    ''    SqlCmd.CommandText = "Sistemas.SpSis_CambiarClaveDeUsuario"
    '    ''    SqlCmd.CommandTimeout = 300
    '    ''    SqlCmd.CommandType = CommandType.StoredProcedure
    '    ''    SqlCmd.Connection = SqlCnn

    '    ''    'Adiciono los parametros de entrada
    '    ''    SqlPrm = New SqlParameter("@Usuario", Usuario)
    '    ''    SqlCmd.Parameters.Add(SqlPrm)

    '    ''    SqlPrm = New SqlParameter("@ClaveOld", OldClaveEnc)
    '    ''    SqlCmd.Parameters.Add(SqlPrm)

    '    ''    SqlPrm = New SqlParameter("@ClaveNew", NewClaveEnc)
    '    ''    SqlCmd.Parameters.Add(SqlPrm)

    '    ''    'Ejecuto el SP
    '    ''    Dr = SqlCmd.ExecuteReader()
    '    ''    Dr.Read()

    '    ''    Retorno = CodigoRetorno(Dr.GetString(0), Mensaje)

    '    ''Catch ex As Exception
    '    ''    Mensaje = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
    '    ''    Retorno = False
    '    ''Finally
    '    ''    If Not Dr Is Nothing Then
    '    ''        Dr.Close()
    '    ''    End If
    '    ''    Dr = Nothing
    '    ''    SqlPrm = Nothing
    '    ''    SqlCmd.Dispose()
    '    ''    SqlCmd = Nothing
    '    ''End Try

    '    ''Return Retorno

    'End Function

    Public Function fdu_SolicitarCambioDeClave(ByVal Usuario As String, ByVal OldClaveEnc As String, ByVal NewClaveEnc As String) As Boolean
        Dim Retorno As Boolean = False
        Dim dr As OdbcDataReader = Nothing
        Dim mconn As New OdbcConnection(DsnODBC)

        Try
            Dim OdbcCmd As System.Data.Odbc.OdbcCommand

            'Instantiate new instances
            OdbcCmd = New System.Data.Odbc.OdbcCommand
            OdbcCmd.CommandText = "{call central.Sistemas.SpSis_CambiarClaveDeUsuario (?,?,?)}"
            OdbcCmd.CommandType = CommandType.StoredProcedure
            OdbcCmd.Connection = mconn

            OdbcCmd.Parameters.AddWithValue("@Usuario", Usuario)
            OdbcCmd.Parameters.AddWithValue("@ClaveOld", OldClaveEnc)
            OdbcCmd.Parameters.AddWithValue("@ClaveNew", NewClaveEnc)

            mconn.Open()

            dr = OdbcCmd.ExecuteReader()
            dr.Read()
            Retorno = CodigoRetorno(dr.GetString(0), Mensaje)
        Catch ex As Exception
            Mensaje = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
            Retorno = False
            mconn.Close()
        Finally
            If Not dr Is Nothing Then
                dr.Close()
            End If
            dr = Nothing
            mconn.Close()
        End Try
        Return Retorno

    End Function

#End Region


    'Inicia una sesion con el servidor para validar el acceso del usuario solicitante
    'Public Function SolicitarConexion(ByVal user As String, ByVal claveenc As String) As DataTable

    '    Try
    '        Dim dt As New DataTable
    '        'Creo una conexion al servidor de datos
    '        Dim sqlcnn As New SqlConnection(CnnSQLServer())
    '        sqlcnn.Open()

    '        'Asigno el comando de solicitud de inicio de sesion
    '        Dim sqlcmd As New SqlCommand
    '        sqlcmd.CommandText = "SpSis_SolicitarConexion"
    '        sqlcmd.CommandTimeout = 100
    '        sqlcmd.CommandType = CommandType.StoredProcedure
    '        sqlcmd.Connection = sqlcnn

    '        'Adiciono los parametros de entrada
    '        Dim sqlprm As New SqlParameter("@idsistema", SqlDbType.Int)
    '        sqlprm.Value = SesionUsuario.IDSistema ' idaplicacion
    '        sqlcmd.Parameters.Add(sqlprm)
    '        sqlprm = New SqlParameter("@usuario", SqlDbType.VarChar, 20)
    '        sqlprm.Value = user
    '        sqlcmd.Parameters.Add(sqlprm)
    '        sqlprm = New SqlParameter("@clave", SqlDbType.VarChar, 50)
    '        sqlprm.Value = claveenc
    '        sqlcmd.Parameters.Add(sqlprm)

    '        'Adiciono variables de retorno
    '        sqlprm = New SqlParameter("@idsucursal", SqlDbType.Int)
    '        sqlprm.Direction = ParameterDirection.Output
    '        sqlcmd.Parameters.Add(sqlprm)
    '        sqlprm = New SqlParameter("@sucursal", SqlDbType.VarChar, 100)
    '        sqlprm.Direction = ParameterDirection.Output
    '        sqlcmd.Parameters.Add(sqlprm)
    '        'sqlprm = New SqlParameter("@idpersona", SqlDbType.Int)
    '        'sqlprm.Direction = ParameterDirection.Output
    '        sqlprm = New SqlParameter("@nombreuser", SqlDbType.VarChar, 100)
    '        sqlprm.Direction = ParameterDirection.Output
    '        sqlcmd.Parameters.Add(sqlprm)
    '        sqlprm = New SqlParameter("@idempresa", SqlDbType.Int)
    '        sqlprm.Direction = ParameterDirection.Output
    '        sqlcmd.Parameters.Add(sqlprm)
    '        sqlprm = New SqlParameter("@empresa", SqlDbType.VarChar, 100)
    '        sqlprm.Direction = ParameterDirection.Output
    '        sqlcmd.Parameters.Add(sqlprm)
    '        sqlprm = New SqlParameter("@credenciales", SqlDbType.VarChar, 200)
    '        sqlprm.Direction = ParameterDirection.Output
    '        sqlcmd.Parameters.Add(sqlprm)

    '        'Ejecuto el SP
    '        Dim sqldt As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
    '        sqldt.Fill(dt)

    '        'Capturar los valores de retorno

    '        SesionUsuario.IDSucursal = sqlcmd.Parameters("@idsucursal").Value
    '        SesionUsuario.Sucursal = sqlcmd.Parameters("@sucursal").Value
    '        SesionUsuario.IDEmpresa = sqlcmd.Parameters("@idempresa").Value
    '        SesionUsuario.Empresa = sqlcmd.Parameters("@empresa").Value
    '        'SesionUsuario.IDPersona = sqlcmd.Parameters("@idpersona").Value
    '        SesionUsuario.NombreUsuario = sqlcmd.Parameters("@nombreuser").Value
    '        VigilanteConexion.CadenaConexion = sqlcmd.Parameters("@credenciales").Value
    '        Mensaje = String.Empty 'sin errores

    '        SesionUsuario.XMLCodsServTransporte = "T"
    '        'SesionUsuario.ServidorWeb = sqlcmd.Parameters("@IpWeb").Value
    '        'SesionUsuario.ServidorWeb = "http://100.100.100.228/GpsLocal"

    '        Return dt

    '    Catch ex As Exception
    '        'Mensaje personalizado de accesoa  datos desde el servidor
    '        Mensaje = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
    '        Return Nothing
    '    End Try

    'End Function

    'Decodifica el mensaje de transacción retornado por el servidor de datos
    Public Shared Function CodigoRetorno(ByVal codigo As String, ByRef resultado As String, _
                                         Optional ByRef Interbloqueo As Boolean = False) As Boolean
        ' Formato: NroCodigo=MensajeDelServidor
        ' Siempre se definirá los códigos de retorno como exitoso con el valor "0"
        Dim pos As Short
        pos = codigo.IndexOf("=")
        Interbloqueo = False

        If pos > 0 Then
            resultado = codigo.Substring(pos + 1)

            If CInt(codigo.Substring(0, pos)) = 0 Then ' numero de codigo 0 es exito
                Return True
            Else
                ' Retornar el mensaje completo con su código
                resultado = "[Código: " & codigo.Substring(0, pos) & "] " & resultado
                'Veo si se trata de un interbloqueo
                If Math.Abs(CInt(codigo.Substring(0, pos))) = 1205 Then
                    Interbloqueo = True
                End If

                Return False
            End If
        Else
            resultado = "No se pudo determinar el código de retorno desde el servidor."
            Return False
        End If

    End Function

    'Elimina el código sql malicioso que pudiera presentarse
    Public Function EliminarInyeccionSQL(ByVal cadena As String) As String
        ' Evitar inyección de código SQL
        cadena = cadena.Trim.Replace("'", "''")
        cadena = cadena.Replace("--", "==")
        Return cadena

    End Function

    '//---> Encriptar clave ingresada del usuario
    Public Shared Function EncriptarClaveSHA(ByVal palabra As String) As String

        If palabra.Length = 0 Then
            Return palabra 'sin clave
        End If
        '
        'Función de encriptación utilizando SHA1
        Dim i As Integer
        Dim enc As New UTF8Encoding()
        Dim data() As Byte = enc.GetBytes(palabra)
        Dim result() As Byte
        Dim sha As New SHA1CryptoServiceProvider()
        '
        result = sha.ComputeHash(data)
        Dim sb As New StringBuilder()
        '
        For i = 0 To result.Length - 1
            If result(i) < 16 Then
                sb.Append("0")
            End If
            sb.Append(result(i).ToString("x"))
        Next
        Return sb.ToString.ToUpper

    End Function

    Public Sub New()
        If TSQL.temporizador Is Nothing Then
            TSQL.temporizador = New Timers.Timer
        End If
        TSQL.temporizador.Interval = 2 * 60 * 1000 '1000 = 1 segundo, timer dado cada 2 minutos
    End Sub
End Class


