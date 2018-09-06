
'Esta clase debe desaparecer porque ya no se esta usando en adelante

Public Class PropiedadesConexion

    Private Mensaje As String = String.Empty
    Private ModoConexion As Integer = MODO_DE_CONEXION.PORSOLICITUD 'por defecto no permanente
    Private CerrarConexion As Boolean = False 'por defecto no cierra la conexion

    Enum MODO_DE_CONEXION
        PORSOLICITUD = 0
        PERMANENTE = 1
    End Enum

    'El inicio y cierre de la conexion compartida se decide en la capa de interfaces
    Public Property TipoConexion() As MODO_DE_CONEXION
        Get
            Return ModoConexion
        End Get
        Set(ByVal value As MODO_DE_CONEXION)
            ModoConexion = value
        End Set
    End Property

    Public Property EjecutarCerrandoConexion() As Boolean
        Get
            Return CerrarConexion
        End Get
        Set(ByVal value As Boolean)
            CerrarConexion = value
        End Set
    End Property

    Public Property UltimoMensaje() As String
        Get
            Return Mensaje
        End Get
        Set(ByVal value As String)
            Mensaje = value.Trim
        End Set
    End Property

End Class