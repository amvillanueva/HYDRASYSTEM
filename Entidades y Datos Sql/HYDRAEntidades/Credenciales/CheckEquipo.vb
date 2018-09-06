Public NotInheritable Class CheckEquipo

    Private Shared _EquipoNombre As String = String.Empty
    Private Shared _HDDSerie As String = String.Empty
    Private Shared _PlacaMadreSerie As String = String.Empty
    Private Shared _PlacaMadreTipo As String = String.Empty
    Private Shared _PlacaMadreMarca As String = String.Empty
    Private Shared _ProcesadorSerie As String = String.Empty
    Private Shared _ProcesadorTipo As String = String.Empty
    Private Shared _ProcesadorMarca As String = String.Empty

    'Public Overrides Sub Inicializar()
    '    _EquipoNombre = String.Empty
    '    _HDDSerie = String.Empty
    '    _PlacaMadreSerie = String.Empty
    '    _PlacaMadreTipo = String.Empty
    '    _PlacaMadreMarca = String.Empty
    '    _ProcesadorSerie = String.Empty
    '    _ProcesadorTipo = String.Empty
    '    _ProcesadorMarca = String.Empty
    'End Sub

    Public Shared Property EquipoNombre() As String
        Get
            Return _EquipoNombre
        End Get
        Set(ByVal value As String)
            _EquipoNombre = value
        End Set
    End Property

    Public Shared Property HDDSerie() As String
        Get
            Return _HDDSerie
        End Get
        Set(ByVal value As String)
            _HDDSerie = value
        End Set
    End Property

    Public Shared Property PlacaMadreSerie() As String
        Get
            Return _PlacaMadreSerie
        End Get
        Set(ByVal value As String)
            _PlacaMadreSerie = value
        End Set
    End Property

    Public Shared Property PlacaMadreTipo() As String
        Get
            Return _PlacaMadreTipo
        End Get
        Set(ByVal value As String)
            _PlacaMadreTipo = value
        End Set
    End Property

    Public Shared Property PlacaMadreMarca() As String
        Get
            Return _PlacaMadreMarca
        End Get
        Set(ByVal value As String)
            _PlacaMadreMarca = value
        End Set
    End Property

    Public Shared Property ProcesadorSerie() As String
        Get
            Return _ProcesadorSerie
        End Get
        Set(ByVal value As String)
            _ProcesadorSerie = value
        End Set
    End Property

    Public Shared Property ProcesadorTipo() As String
        Get
            Return _ProcesadorTipo
        End Get
        Set(ByVal value As String)
            _ProcesadorTipo = value
        End Set
    End Property

    Public Shared Property ProcesadorMarca() As String
        Get
            Return _ProcesadorMarca
        End Get
        Set(ByVal value As String)
            _ProcesadorMarca = value
        End Set
    End Property

End Class
