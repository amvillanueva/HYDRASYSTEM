Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Text


Public Class CentralBase
    Public Advertencia As String
    Public Const Titulo_Sistema = "HYDRA SYSTEM"

    Public Sub New()
        Advertencia = String.Empty
    End Sub

    Private Shared _Instancia As CentralBase = Nothing
    Public Shared ReadOnly Property newInstancia() As CentralBase
        Get
            If _Instancia Is Nothing Then
                _Instancia = New CentralBase
            End If
            Return _Instancia
        End Get
    End Property

    Public ReadOnly Property UltimoMensaje() As String
        Get
            Return Advertencia
        End Get
    End Property


    Public Function fdu_Num_Letras(ByVal n As Double) As String
        Dim NRO As String, PTO As Integer, DESC As String
        Dim NROW As String, CuentaNum As Long, ST As String
        Dim X As Integer, Y As Integer, Z As Integer
        Dim CIEN As String, TOS As String, ENT As String, UN As String, MIL As String
        Dim X1 As Integer, SW1 As Integer, SW2 As Integer
        Dim N1 As Integer, N2 As Integer, N3 As Integer
        CIEN = "CIEN"
        TOS = "TOS"
        UN = "UN"
        MIL = "MIL"
        ENT = "ENT"
        NRO = CStr(Format(n, "000000000.00"))
        'PTO = InStr(NRO, ".")
        PTO = NRO.IndexOf(".")
        'DESC = Right(NRO, 2)
        DESC = Mid(NRO, Len(NRO.ToString) - 1, 2)

        NROW = Mid(NRO, 1, Len(NRO.ToString) - 3)
        ST = ""
        X = 1
        Y = 2
        Z = 3
        CuentaNum = 1
        Do While CuentaNum < 4
            X1 = 0
            SW1 = 0
            SW2 = 0
            'N1 = Val(Right(Left(NRO, X), 1))
            N1 = Val(Mid(NRO, X, 1))
            N2 = Val(Mid(NRO, Y, 1))
            N3 = Val(Mid(NRO, Z, 1))
            If N1 = 0 And N2 = 0 And N3 = 0 Then
                CuentaNum = CuentaNum + 1
                X = X + 3
                Y = Y + 3
                Z = Z + 3
            Else
                If N1 > 0 Then
                    SW1 = 1
                    Select Case N1
                        Case 1 And N2 = 0 And N3 = 0
                            ST = ST & Space(1) & CIEN
                        Case 1
                            ST = ST & Space(1) & CIEN & "TO"
                        Case 2
                            ST = ST & Space(1) & "DOS" & CIEN & TOS
                        Case 3
                            ST = ST & Space(1) & "TRE" & CIEN & TOS
                        Case 4
                            ST = ST & Space(1) & "CUATRO" & CIEN & TOS
                        Case 5
                            ST = ST & Space(1) & "QUINI" & ENT & "OS"
                        Case 6
                            ST = ST & Space(1) & "SEIS" & CIEN & TOS
                        Case 7
                            ST = ST & Space(1) & "SETE" & CIEN & TOS
                        Case 8
                            ST = ST & Space(1) & "OCHO" & CIEN & TOS
                        Case 9
                            ST = ST & Space(1) & "NOVE" & CIEN & TOS
                    End Select
                End If
                ' msgbox "ST(n1) = " & ST
                If N2 = 0 And N3 = 0 Then
                    'ST = ST & " "
                    'CuentaNum = CuentaNum + 1
                    'X = X + 3
                    'Y = Y + 3
                    'Z = Z + 3
                Else
                    If N2 > 0 Then
                        SW1 = 1
                        Select Case N2
                            Case 1 And N3 = 0
                                ST = ST & Space(1) & "DIEZ"
                                X1 = 1
                            Case 1 And N3 = 1
                                ST = ST & Space(1) & "ONCE"
                                X1 = 1
                            Case 1 And N3 = 2
                                ST = ST & Space(1) & "DOCE"
                                X1 = 1
                            Case 1 And N3 = 3
                                ST = ST & Space(1) & "TRECE"
                                X1 = 1
                            Case 1 And N3 = 4
                                ST = ST & Space(1) & "CATORCE"
                                X1 = 1
                            Case 1 And N3 = 5
                                ST = ST & Space(1) & "QUINCE"
                                X1 = 1
                            Case 1
                                ST = ST & Space(1) & "DIECI"
                            Case 2 And Not N3 = 0
                                ST = ST & Space(1) & "VEINTI"
                            Case 2 And N3 = 0
                                ST = ST & Space(1) & "VEINTE"
                                X1 = 1
                            Case 3 And Not N3 = 0
                                ST = ST & " TREINTI"
                            Case 3 And N3 = 0
                                ST = ST & "TREINTA"
                                X1 = 1
                            Case 4 And Not N3 = 0
                                ST = ST & Space(1) & "CUAR" & ENT & "I"
                            Case 4 And N3 = 0
                                ST = ST & Space(1) & "CUAR" & ENT & "A"
                                X1 = 1
                            Case 5 And Not N3 = 0
                                ST = ST & Space(1) & "CINCU" & ENT & "I"
                            Case 5 And N3 = 0
                                ST = ST & Space(1) & "CINCU" & ENT & "A"
                                X1 = 1
                            Case 6 And Not N3 = 0
                                ST = ST & Space(1) & "SES" & ENT & "I"
                            Case 6 And N3 = 0
                                ST = ST & Space(1) & "SES" & ENT & "A"
                                X1 = 1
                            Case 7 And Not N3 = 0
                                ST = ST & Space(1) & "SET" & ENT & "I"
                            Case 7 And N3 = 0
                                ST = ST & Space(1) & "SET" & ENT & "A"
                                X1 = 1
                            Case 8 And Not N3 = 0
                                ST = ST & Space(1) & "OCH" & ENT & "I"
                            Case 8 And N3 = 0
                                ST = ST & Space(1) & "OCH" & ENT & "A"
                                X1 = 1
                            Case 9 And Not N3 = 0
                                ST = ST & Space(1) & "NOV" & ENT & "I"
                            Case 9 And N3 = 0
                                ST = ST & Space(1) & "NOV" & ENT & "A"
                                X1 = 1
                        End Select
                    End If
                    If Not N3 = 0 And X1 = 0 Then
                        SW1 = 1
                        Select Case N3
                            Case 1
                                Select Case CuentaNum
                                    Case 1
                                        If N1 = 0 And N2 = 0 Then
                                            ST = ST & UN
                                            SW2 = 1
                                        Else
                                            ST = ST & UN & "O"
                                        End If
                                    Case 2
                                        If N1 = 0 And N2 = 0 Then
                                            SW2 = 0
                                        Else
                                            ST = ST & UN
                                        End If
                                    Case 3 And Not (X1 = 1)
                                        ST = ST & UN & "O"
                                End Select
                            Case 2
                                ST = ST & "DOS"
                            Case 3   'N3 = 3
                                ST = ST & "TRES"
                            Case 4   'N3 = 4
                                ST = ST & "CUATRO"
                            Case 5   'N3 = 5
                                ST = ST & "CINCO"
                            Case 6   'N3 = 6
                                ST = ST & "SEIS"
                            Case 7   'N3 = 7
                                ST = ST & "SIETE"
                            Case 8
                                ST = ST & "OCHO"
                            Case 9
                                ST = ST & "NUEVE"
                        End Select
                    End If
                End If
                ' msgbox "ST(n3) = " & ST
                Select Case CuentaNum
                    Case 1 And SW1 = 1
                        If SW2 = 0 Then
                            ST = ST & Space(1) & MIL & "LONES"
                        Else
                            ST = ST & Space(1) & MIL & "LON"
                        End If
                    Case 2 And SW1 = 1
                        ST = ST & Space(1) & MIL
                End Select
                'ST = ST & " "
                CuentaNum = CuentaNum + 1
                X = X + 3
                Y = Y + 3
                Z = Z + 3
                'End If
            End If
        Loop

        If ST.Length > 0 Then
            ST = ST & " Y "
        End If
        ST = ST & DESC & "/100"
        'If tmoneda = "$" Then
        'ST = ST & Trim(tmoneda)
        'Else
        '   ST = ST & "NUEVOS SOLES"
        'End If

        'If tmoneda = "$" Then
        '   ST = ST & "Y " & DESC & "/100 DOLARES AMERICANOS"
        'Else
        '   ST = ST & "Y " & DESC & "/100 NUEVOS SOLES"
        'End If'

        'CONVERTIDO = "SON|   " & ST & "********"
        fdu_Num_Letras = ST
        'RETURN(CONVERTIDO)
    End Function

    Public Shared Function DataGridViewToDataTable(ByVal dtg As DataGridView, Optional ByVal DataTableName As String = "myDataTable") As DataTable
        Try
            Dim dt As New DataTable(DataTableName)
            Dim row As DataRow
            Dim TotalDatagridviewColumns As Integer = dtg.ColumnCount - 1
            'Add Datacolumn
            For Each c As DataGridViewColumn In dtg.Columns
                Dim idColumn As DataColumn = New DataColumn()
                idColumn.ColumnName = c.Name
                dt.Columns.Add(idColumn)
            Next
            'Now Iterate thru Datagrid and create the data row
            For Each dr As DataGridViewRow In dtg.Rows
                'Iterate thru datagrid
                row = dt.NewRow 'Create new row
                'Iterate thru Column 1 up to the total number of columns
                For cn As Integer = 0 To TotalDatagridviewColumns
                    row.Item(cn) = dr.Cells(cn).Value
                Next
                'Now add the row to Datarow Collection
                dt.Rows.Add(row)
            Next
            'Now return the data table
            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Function QuitarRetornoCarro(ByVal Cad As String) As String
        'Dim sb As New System.Text.StringBuilder(Cad)
        'sb.Replace(" ", "")
        'Cad = sb.ToString.Trim

        'Return Cad
        Dim sb As New System.Text.StringBuilder
        sb.Length = 0
        For Each C As Char In Cad
            If Not Asc(C) = 13 And Not Asc(C) = 10 Then
                sb.Append(C)
            End If
        Next
        Return sb.ToString
    End Function

    Public Function DataTableAXML(ByVal dt As DataTable) As String

        Dim XML As String = String.Empty
        If IsNothing(dt) Then
            Return XML
        End If
        If dt.Rows.Count = 0 Then
            Return XML
        End If

        Dim ds As New DataSet("r")
        dt.TableName = "d"

        'dtAux.Merge(dt)

        For i As Integer = 0 To dt.Columns.Count - 1
            dt.Columns(i).ColumnMapping = MappingType.Attribute
        Next


        Dim SW As New System.IO.StringWriter

        ds.Tables.Add(dt.Copy)
        ds.WriteXml(SW)

        XML = SW.ToString.Trim
        XML = QuitarRetornoCarro(XML) 'quita retorno de carro y espacios

        Return XML

    End Function

    Public Shared Function fdu_DataGridViewToDataTable(ByVal dtg As DataGridView, Optional ByVal DataTableName As String = "myDataTable") As DataTable
        Try
            Dim dt As New DataTable(DataTableName)
            Dim row As DataRow
            Dim TotalDatagridviewColumns As Integer = dtg.ColumnCount - 1
            'Add Datacolumn
            For Each c As DataGridViewColumn In dtg.Columns
                Dim idColumn As DataColumn = New DataColumn()
                idColumn.ColumnName = c.Name
                dt.Columns.Add(idColumn)
            Next
            'Now Iterate thru Datagrid and create the data row
            For Each dr As DataGridViewRow In dtg.Rows
                'Iterate thru datagrid
                row = dt.NewRow 'Create new row
                'Iterate thru Column 1 up to the total number of columns
                For cn As Integer = 0 To TotalDatagridviewColumns
                    row.Item(cn) = dr.Cells(cn).Value
                Next
                'Now add the row to Datarow Collection
                dt.Rows.Add(row)
            Next
            'Now return the data table
            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ListAXML(Of T)(ByVal list As List(Of T)) As String

        Dim _resultDataSet As New DataSet("r")
        Dim _resultDataTable As New DataTable("d")
        Dim _resultDataRow As DataRow = Nothing
        Dim _itemProperties() As PropertyInfo = list.Item(0).GetType().GetProperties()
        Dim cadxml As String = String.Empty

        ' Meta Data. 
        _itemProperties = list.Item(0).GetType().GetProperties()
        For Each p As PropertyInfo In _itemProperties
            _resultDataTable.Columns.Add(p.Name, p.GetGetMethod.ReturnType()).ColumnMapping = MappingType.Attribute
        Next
        ' Data
        For Each item As T In list
            '
            ' Get the data from this item into a DataRow
            ' then add the DataRow to the DataTable.
            ' Eeach items property becomes a colunm.
            '
            _itemProperties = item.GetType().GetProperties()
            _resultDataRow = _resultDataTable.NewRow()
            For Each p As PropertyInfo In _itemProperties
                _resultDataRow(p.Name) = p.GetValue(item, Nothing)
            Next
            _resultDataTable.Rows.Add(_resultDataRow)
        Next
        ' Add the DataTable to the DataSet, We are DONE!
        _resultDataSet.Tables.Add(_resultDataTable)
        cadxml = _resultDataSet.GetXml
        Return cadxml


    End Function

    Public Function ConvertirXMLaDataTable(ByVal StrXML As String) As DataTable

        Dim Bf As Byte()
        Dim MS As MemoryStream
        Dim Ds As New DataSet
        Dim Dt As DataTable

        Try

            If Not StrXML Is Nothing And Not StrXML Is DBNull.Value Then

                If StrXML = String.Empty Then
                    Dt = Nothing
                Else
                    Bf = System.Text.UTF8Encoding.ASCII.GetBytes(StrXML)
                    MS = New MemoryStream(Bf)
                    Ds.ReadXml(MS)
                    Dt = Ds.Tables(0).Copy
                End If

            Else
                Dt = Nothing
            End If

        Catch ex As Exception
            Throw New Exception("Error en ConvertirXMLaDataTable: " & ex.ToString)
        End Try

        Return Dt

    End Function























#Region "Metodos Auxiliares"


    Public Function EsDecimal(ByVal Value As String) As Boolean 'acepta números y el punto decimal
        For Each chr As Char In Value
            If Not Char.IsDigit(chr) And Not Asc(chr) = System.Windows.Forms.Keys.Delete Then
                Return False
            End If
        Next
        Return True
    End Function


#End Region






End Class
