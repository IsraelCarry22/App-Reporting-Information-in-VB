Imports System.IO
Imports System.Xml

Module Open_Save
    Public Sub GetFileExtension(ByVal isOpen As Boolean, ByRef filePath As String, ByVal ListFilesData As DataGridView)
        If isOpen Then
            Select Case Path.GetExtension(filePath).ToLower()
                Case ".csv"
                    OpenFileCSV(filePath, ListFilesData)
                Case ".xml"
                    OpenFileXML(filePath, ListFilesData)
                Case ".json"
                    OpenFileJSON(filePath, ListFilesData)
            End Select
        Else
            Select Case Path.GetExtension(filePath).ToLower()
                Case ".csv"
                    SaveFileCSV(filePath, ListFilesData)
                Case ".xml"
                    SaveFileXML(filePath, ListFilesData)
                Case ".json"
                    SaveFileJSON(filePath, ListFilesData)
            End Select
        End If
    End Sub

    Public Sub OpenFileCSV(ByRef filePath As String, ByVal ListFilesData As DataGridView)
        Using CSVReader As New StreamReader(filePath)
            Dim primeraLinea As String = CSVReader.ReadLine()

            If primeraLinea Is Nothing Then
                Return
            End If

            Dim encabezados As String() = primeraLinea.Split(","c)

            ListFilesData.Columns.Clear()

            For Each encabezado In encabezados
                ListFilesData.Columns.Add(encabezado, encabezado)
            Next

            While Not CSVReader.EndOfStream
                Dim line As String = CSVReader.ReadLine()
                Dim propertyless As String() = line.Split(","c)

                ListFilesData.Rows.Add(propertyless)
            End While

            MessageBox.Show("Datos cargados desde el archivo CSV correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using
    End Sub

    Public Sub OpenFileJSON(ByRef filePath As String, ByVal ListFilesData As DataGridView)
        Dim jsonDatos As String = File.ReadAllText(filePath)

        Dim listaObjetos = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, Object)))(jsonDatos)

        If listaObjetos IsNot Nothing AndAlso listaObjetos.Count > 0 Then
            For Each clave As String In listaObjetos(0).Keys
                ListFilesData.Columns.Add(clave, clave)
            Next

            For Each objetoFila In listaObjetos
                Dim valores As Object() = objetoFila.Values.ToArray()
                ListFilesData.Rows.Add(valores)
            Next

            MessageBox.Show("Datos cargados desde el archivo JSON correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub OpenFileXML(ByRef filePath As String, ByVal ListFilesData As DataGridView)
        Dim dataSet As New DataSet()

        dataSet.ReadXml(filePath)

        If dataSet.Tables.Count > 0 Then
            Dim dataTable As DataTable = dataSet.Tables(0)

            For Each column As DataColumn In dataTable.Columns
                ListFilesData.Columns.Add(column.ColumnName, column.ColumnName)
            Next

            For Each row As DataRow In dataTable.Rows
                ListFilesData.Rows.Add(row.ItemArray)
            Next

            MessageBox.Show("Datos cargados desde el archivo XML correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub SaveFileCSV(ByRef filePath As String, ByVal ListFilesData As DataGridView)
        Using CSVwriter As New StreamWriter(filePath)
            For i As Integer = 0 To ListFilesData.Columns.Count - 1
                CSVwriter.Write(ListFilesData.Columns(i).HeaderText)

                If i < ListFilesData.Columns.Count - 1 Then
                    CSVwriter.Write(",")
                End If
            Next

            CSVwriter.WriteLine()

            For i As Integer = 0 To ListFilesData.Rows.Count - 1
                For j As Integer = 0 To ListFilesData.Columns.Count - 1
                    CSVwriter.Write(ListFilesData.Rows(i).Cells(j).Value)

                    If j < ListFilesData.Columns.Count - 1 Then
                        CSVwriter.Write(",")
                    End If
                Next

                CSVwriter.WriteLine()
            Next
        End Using

        MessageBox.Show("Archivo CSV guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub SaveFileXML(ByRef filePath As String, ByVal ListFilesData As DataGridView)
        Dim xmlDoc As New XmlDocument()
        Dim xmlDeclaration As XmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
        xmlDoc.AppendChild(xmlDeclaration)

        Dim rootElement As XmlElement = xmlDoc.CreateElement("Datos")
        xmlDoc.AppendChild(rootElement)

        For i As Integer = 0 To ListFilesData.Rows.Count - 1
            Dim rowElement As XmlElement = xmlDoc.CreateElement("Fila")

            For j As Integer = 0 To ListFilesData.Columns.Count - 1
                Dim columnName As String = ListFilesData.Columns(j).HeaderText
                Dim xmlElementName As String = GetValidXmlElementName(columnName)
                Dim cellValue As String = Convert.ToString(ListFilesData.Rows(i).Cells(j).Value)

                Dim cellElement As XmlElement = xmlDoc.CreateElement(xmlElementName)
                cellElement.InnerText = cellValue

                rowElement.AppendChild(cellElement)
            Next

            rootElement.AppendChild(rowElement)
        Next

        xmlDoc.Save(filePath)

        MessageBox.Show("Datos guardados como archivo XML correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function GetValidXmlElementName(ByVal input As String) As String
        Dim validName As String = input.Replace(" ", "_")

        validName = New String(validName.Where(Function(c) Char.IsLetterOrDigit(c) OrElse c = "_").ToArray())

        If Char.IsDigit(validName(0)) Then
            validName = "_" + validName
        End If

        Return validName
    End Function

    Public Sub SaveFileJSON(ByRef filePath As String, ByVal ListFilesData As DataGridView)
        Dim listaObjetos As New List(Of Object)()

        For Each fila As DataGridViewRow In ListFilesData.Rows
            If Not fila.IsNewRow Then
                Dim objetoFila As New Dictionary(Of String, Object)()

                For Each celda As DataGridViewCell In fila.Cells
                    Dim nombreColumna As String = ListFilesData.Columns(celda.ColumnIndex).HeaderText
                    objetoFila(nombreColumna) = celda.Value
                Next

                listaObjetos.Add(objetoFila)
            End If
        Next

        Dim jsonDatos As String = Newtonsoft.Json.JsonConvert.SerializeObject(listaObjetos, Newtonsoft.Json.Formatting.Indented)

        System.IO.File.WriteAllText(filePath, jsonDatos)

        MessageBox.Show("Datos guardados como archivo JSON correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Module
