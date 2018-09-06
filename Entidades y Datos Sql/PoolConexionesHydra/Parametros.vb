Module Parametros

#Region "Comentarios"
    ' 1. Indicar el puerto despues del IP si no fuera el 1433 por defecto
    ' 2. Encriptar este dll para más seguridad
    ' 3. Luego cambiar el IP por el de 2005 y los usuarios por cada sucursal conectada al servidor de datos
    ' 4. El caracter # sera reemplazado por el usuario de inicio de sesion
    ' 5. Se iniciaria sesion siempre con el usuario por defecto, luego es otro usuario el que continua la conexion

#End Region

#Region "Credenciales de Inicio de Sesión"

    'Cadena de conexión incial al servidor de datos usada al iniciar una sesión
    Private Const SQL_LOGIN As String = "server=100.100.100.202,1433;database=CENTRAL;" & _
        "user id=guardian;password=5637#&cindex;connect timeout=100"
    Private Const ODBC_LOGIN As String = "dsn=cnnLogin;uid=guardian;pwd=5637#&cindex"

    ''-- Pruebas en PC Irving --
    'Private Const SQL_LOGIN As String = "server=100.100.100.176\developer;database=CENTRAL;" & _
    '    "user id=test;password=guardian@2013;connect timeout=100"
    'Private Const ODBC_LOGIN As String = "dsn=cnnGEAC_1;uid=test;pwd=guardian@2013"

    ''-- Pruebas PC Milton --
    'Private Const SQL_LOGIN As String = "server=100.100.100.13\SQLSERVER2008;database=CENTRAL;" & _
    '    "user id=test;password=guardian@2013;connect timeout=100"
    'Private Const ODBC_LOGIN As String = "dsn=cnnGEAC_2;uid=test;pwd=guardian@2013"

    'Private Const SQL_LOGIN As String = "server=190.81.24.129,1433;database=CENTRAL;" & _
    '"user id=guardian;password=5637#&cindex;connect timeout=300" 'remoto

#End Region

#Region "Conexiona FoxPro"

    'esta consulta seraq probada para ver su consistencia en los demas tipos de consultas externas
    Public Const Cnn_Fox As String = "Driver=Microsoft Visual FoxPro " & _
    "Driver;UID=;SourceType=DBF;SourceDb=F:\TRC000\MAESTRO"

#End Region

#Region "Propiedades de Acceso a Bases de Datos"

    ReadOnly Property CnnSQLServer() As String
        Get
            Return SQL_LOGIN
        End Get
    End Property

    ReadOnly Property DsnODBC() As String
        Get
            Return ODBC_LOGIN
        End Get
    End Property
#End Region

#Region "Acciones a realizar sobre una Base de Datos"

    'Defino los tipos de sistemas o aplicaciones físicas que hacen uso del servidor de datos
    Enum LoginsSistema
        ADMINISTRACION_CENTRAL = 1
        OPERACIONES_TRC = 2
        OPERACIONES_ATSA = 3
        OPERACIONES_SYR = 4
    End Enum

    'Cadena de coenxion al sql

    'Identificadores de las empresas del grupo (tabla CENTRAL.dbo.EMPRESAS)
    'Esta list atambien existe un amestro, modiifcar esrta realcion
    Enum Empresas
        TRC = 1
        SYR = 2
        ATSA = 3
    End Enum

    'Tipo de operación a realizar sobre un conjunto de tranasacciones de datos
    Enum SQL
        INSERTAR = 1
        MODIFICAR = 2
        ELIMINAR = 3
        CONSULTAR = 4
    End Enum

    'Los identificadores asignados a cada sucursal es de acuerdo a la base de datos (CENTRAL.dbo.rtpsEstablecimientos)
    ' se van añadiendo conforme se vayan necesitando

    'Esta lista ya no es del sistema, xq exizte un mestro , mnodificar esta relacion
    Enum Sucursales
        TRUJILLO = 1
        PACASMAYO = 2
        LIMA = 3
        CAJAMARCA = 4
    End Enum


#End Region

End Module