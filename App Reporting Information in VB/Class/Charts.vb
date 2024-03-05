Imports System.Windows.Forms.DataVisualization.Charting

Module Charts
    Public Sub ConfigurationPieForYear(ByVal PieYear As Chart, ByVal ListFilesData As DataGridView)
        PieYear.Series.Clear()
        PieYear.Series.Add(New Series("Año"))
        PieYear.Series("Año").ChartType = SeriesChartType.Pie

        ShowPieDataYear(PieYear, ListFilesData)
    End Sub

    Public Sub ConfigurationPie(ByVal NameColumn As String, ByVal PieConsole As Chart, ByVal ListFilesData As DataGridView)
        PieConsole.Series.Clear()
        PieConsole.Series.Add(New Series(NameColumn))
        PieConsole.Series(NameColumn).ChartType = SeriesChartType.Pie

        ShowColumn(NameColumn, PieConsole, ListFilesData)
    End Sub

    Private Sub ShowPieDataYear(ByVal PieYear As Chart, ByVal ListFilesData As DataGridView)
        PieYear.Series("Año").Points.Clear()

        Dim periodoContador As New Dictionary(Of String, Integer)()

        For Each row As DataGridViewRow In ListFilesData.Rows
            Dim valorCelda As Object = row.Cells(1).Value

            If valorCelda IsNot Nothing AndAlso valorCelda.ToString() <> "" Then
                Dim año As Integer = Convert.ToInt32(valorCelda)
                Dim intervalo As Integer = (año \ 10) * 10

                Dim clave As String = $"{intervalo} - {intervalo + 9}"

                If Not periodoContador.ContainsKey(clave) Then
                    periodoContador(clave) = 1
                Else
                    periodoContador(clave) += 1
                End If
            End If
        Next

        For Each kvp As KeyValuePair(Of String, Integer) In periodoContador
            PieYear.Series("Año").Points.AddXY(kvp.Key, kvp.Value)
        Next
    End Sub

    Private Sub ShowColumn(ByVal NameColumn As String, ByVal PieConsole As Chart, ByVal ListFilesData As DataGridView)
        PieConsole.Series(NameColumn).Points.Clear()

        Dim consolaContador As New Dictionary(Of String, Integer)()

        For Each row As DataGridViewRow In ListFilesData.Rows
            Dim valorCelda As Object = row.Cells(NameColumn).Value

            If valorCelda IsNot Nothing Then
                Dim consola As String = valorCelda.ToString()

                If Not consolaContador.ContainsKey(consola) Then
                    consolaContador(consola) = 1
                Else
                    consolaContador(consola) += 1
                End If
            End If
        Next

        For Each kvp As KeyValuePair(Of String, Integer) In consolaContador
            PieConsole.Series(NameColumn).Points.AddXY(kvp.Key, kvp.Value)
        Next
    End Sub
End Module
