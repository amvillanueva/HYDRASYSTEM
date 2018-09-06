
Imports System.Text
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports System.Drawing
Imports HYDRASysTemDatosSQL.DAOAlmacen

Namespace ControlALmacen
    Public Class WFControlAlmacen : Inherits CentralBase


        Public Function fdu_ALM_ListarProductoAlmacen(ByVal periodoRecibido As String, ByVal idAlmacen As Integer) As DataTable
            Dim dt As DataTable
            Try
                dt = DAOControlAlmacen.Instancia.fdu_ALM_ListarProductoAlmacen(periodoRecibido, idAlmacen)
                Advertencia = DAOControlAlmacen.Instancia.Advertencia
            Catch ex As Exception
                Advertencia = "Fuente: " & ex.Source & vbCrLf & "Mensaje: " & ex.Message
                Return Nothing
            End Try
            Return dt
        End Function
    End Class



End Namespace

