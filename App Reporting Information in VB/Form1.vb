Imports System.IO

Public Class Form1
    Public filePath As String

    Public Function OpenDialog(ByRef filePath As String, ByVal filter As String) As Boolean
        ListDataFileDGV.Rows.Clear()
        ListDataFileDGV.Columns.Clear()

        Dim fileDialog As New OpenFileDialog()
        fileDialog.Filter = filter

        If fileDialog.ShowDialog() <> DialogResult.OK Then
            Return True
        End If

        filePath = fileDialog.FileName

        ActuallyFileLBL.Text = $"Archivo: {fileDialog.SafeFileName}"

        Return False
    End Function

    Public Function SaveDialog(ByRef filePath As String, ByVal filter As String) As Boolean
        If ListDataFileDGV.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = filter

        If saveFileDialog.ShowDialog() <> DialogResult.OK Then
            MessageBox.Show($"Datos no guardados desde el archivo {Path.GetFileName(saveFileDialog.FileName)} incorrectamente.", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return True
        End If

        filePath = saveFileDialog.FileName

        ActuallyFileLBL.Text = $"Archivo: {Path.GetFileName(saveFileDialog.FileName)}"

        Return False
    End Function

    Private Sub OpenMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenDialog(filePath, "Archivos CSV (*.csv)|*.csv|Archivos XML (*.xml)|*.xml|Archivos JSON (*.json)|*.json") Then
            Return
        End If

        Open_Save.GetFileExtension(True, filePath, ListDataFileDGV)

        Charts.ConfigurationPieForYear(Chart1, ListDataFileDGV)
        Charts.ConfigurationPie("Consola", Chart2, ListDataFileDGV)
        Charts.ConfigurationPie("Género", Chart3, ListDataFileDGV)
        Charts.ConfigurationPie("Región", Chart4, ListDataFileDGV)
        Charts.ConfigurationPie("Generación", Chart5, ListDataFileDGV)
    End Sub

    Private Sub SaveMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If String.IsNullOrEmpty(filePath) Then
            If SaveDialog(filePath, "Archivos CSV (*.csv)|*.csv|Archivos XML (*.xml)|*.xml|Archivos JSON (*.json)|*.json") Then
                Return
            End If

            Open_Save.GetFileExtension(False, filePath, ListDataFileDGV)
        Else
            Open_Save.GetFileExtension(False, filePath, ListDataFileDGV)
        End If

    End Sub

    Private Sub SaveHowMenuItem_Click(sender As Object, e As EventArgs) Handles SaveHpwToolStripMenuItem.Click
        If SaveDialog(filePath, "Archivos CSV (*.csv)|*.csv|Archivos XML (*.xml)|*.xml|Archivos JSON (*.json)|*.json") Then
            Return
        End If

        Open_Save.GetFileExtension(False, filePath, ListDataFileDGV)
    End Sub

    Private Sub AñoSubMenuItem_Click(sender As Object, e As EventArgs) Handles AñoToolStripMenuItem.Click
        PanelAño.Visible = True
        PanelConsolas.Visible = False
    End Sub

    Private Sub ConsolasSubMenuItem_Click(sender As Object, e As EventArgs) Handles ConsolasToolStripMenuItem.Click
        PanelAño.Visible = True
        PanelConsolas.Visible = True
        PanelGenero.Visible = False
    End Sub

    Private Sub GeneroSubMenuItem_Click(sender As Object, e As EventArgs) Handles GneracionToolStripMenuItem.Click
        PanelAño.Visible = True
        PanelConsolas.Visible = True
        PanelGenero.Visible = True
        PanelRegion.Visible = False
    End Sub

    Private Sub RegionSubMenuItem_Click(sender As Object, e As EventArgs) Handles RegionToolStripMenuItem.Click
        PanelAño.Visible = True
        PanelConsolas.Visible = True
        PanelGenero.Visible = True
        PanelRegion.Visible = True
        PanelGeneracion.Visible = False
    End Sub

    Private Sub GeneraciónSubMenuItem_Click(sender As Object, e As EventArgs) Handles GeneracionToolStripMenuItem.Click
        PanelAño.Visible = True
        PanelConsolas.Visible = True
        PanelGenero.Visible = True
        PanelRegion.Visible = True
        PanelGeneracion.Visible = True
    End Sub

    Private Sub FileSubMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        PanelAño.Visible = False
    End Sub
End Class
