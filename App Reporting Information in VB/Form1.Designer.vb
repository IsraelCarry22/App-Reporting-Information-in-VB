<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveHpwToolStripMenuItem = New ToolStripMenuItem()
        GraphicsToolStripMenuItem = New ToolStripMenuItem()
        AñoToolStripMenuItem = New ToolStripMenuItem()
        ConsolasToolStripMenuItem = New ToolStripMenuItem()
        GneracionToolStripMenuItem = New ToolStripMenuItem()
        RegionToolStripMenuItem = New ToolStripMenuItem()
        GeneracionToolStripMenuItem = New ToolStripMenuItem()
        ActuallyFileLBL = New Label()
        ListDataFileDGV = New DataGridView()
        Label1 = New Label()
        PanelAño = New Panel()
        PanelConsolas = New Panel()
        PanelGenero = New Panel()
        PanelRegion = New Panel()
        PanelGeneracion = New Panel()
        Chart5 = New DataVisualization.Charting.Chart()
        Label4 = New Label()
        Chart4 = New DataVisualization.Charting.Chart()
        Label3 = New Label()
        Chart3 = New DataVisualization.Charting.Chart()
        Label6 = New Label()
        Chart2 = New DataVisualization.Charting.Chart()
        Label2 = New Label()
        Chart1 = New DataVisualization.Charting.Chart()
        MenuStrip1.SuspendLayout()
        CType(ListDataFileDGV, ComponentModel.ISupportInitialize).BeginInit()
        PanelAño.SuspendLayout()
        PanelConsolas.SuspendLayout()
        PanelGenero.SuspendLayout()
        PanelRegion.SuspendLayout()
        PanelGeneracion.SuspendLayout()
        CType(Chart5, ComponentModel.ISupportInitialize).BeginInit()
        CType(Chart4, ComponentModel.ISupportInitialize).BeginInit()
        CType(Chart3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Chart2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, GraphicsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 29)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OpenToolStripMenuItem, SaveToolStripMenuItem, SaveHpwToolStripMenuItem})
        FileToolStripMenuItem.Font = New Font("Segoe UI", 12.0F)
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 25)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(149, 26)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(149, 26)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' SaveHpwToolStripMenuItem
        ' 
        SaveHpwToolStripMenuItem.Name = "SaveHpwToolStripMenuItem"
        SaveHpwToolStripMenuItem.Size = New Size(149, 26)
        SaveHpwToolStripMenuItem.Text = "Save How"
        ' 
        ' GraphicsToolStripMenuItem
        ' 
        GraphicsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AñoToolStripMenuItem, ConsolasToolStripMenuItem, GneracionToolStripMenuItem, RegionToolStripMenuItem, GeneracionToolStripMenuItem})
        GraphicsToolStripMenuItem.Font = New Font("Segoe UI", 12.0F)
        GraphicsToolStripMenuItem.Name = "GraphicsToolStripMenuItem"
        GraphicsToolStripMenuItem.Size = New Size(83, 25)
        GraphicsToolStripMenuItem.Text = "Graphics"
        ' 
        ' AñoToolStripMenuItem
        ' 
        AñoToolStripMenuItem.Name = "AñoToolStripMenuItem"
        AñoToolStripMenuItem.Size = New Size(159, 26)
        AñoToolStripMenuItem.Text = "Año"
        ' 
        ' ConsolasToolStripMenuItem
        ' 
        ConsolasToolStripMenuItem.Name = "ConsolasToolStripMenuItem"
        ConsolasToolStripMenuItem.Size = New Size(159, 26)
        ConsolasToolStripMenuItem.Text = "Consolas"
        ' 
        ' GneracionToolStripMenuItem
        ' 
        GneracionToolStripMenuItem.Name = "GneracionToolStripMenuItem"
        GneracionToolStripMenuItem.Size = New Size(159, 26)
        GneracionToolStripMenuItem.Text = "Genero"
        ' 
        ' RegionToolStripMenuItem
        ' 
        RegionToolStripMenuItem.Name = "RegionToolStripMenuItem"
        RegionToolStripMenuItem.Size = New Size(159, 26)
        RegionToolStripMenuItem.Text = "Region"
        ' 
        ' GeneracionToolStripMenuItem
        ' 
        GeneracionToolStripMenuItem.Name = "GeneracionToolStripMenuItem"
        GeneracionToolStripMenuItem.Size = New Size(159, 26)
        GeneracionToolStripMenuItem.Text = "Generacion"
        ' 
        ' ActuallyFileLBL
        ' 
        ActuallyFileLBL.AutoSize = True
        ActuallyFileLBL.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ActuallyFileLBL.Location = New Point(12, 53)
        ActuallyFileLBL.Name = "ActuallyFileLBL"
        ActuallyFileLBL.Size = New Size(80, 25)
        ActuallyFileLBL.TabIndex = 1
        ActuallyFileLBL.Text = "Archivo:"
        ' 
        ' ListDataFileDGV
        ' 
        ListDataFileDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ListDataFileDGV.Location = New Point(12, 93)
        ListDataFileDGV.Name = "ListDataFileDGV"
        ListDataFileDGV.Size = New Size(631, 345)
        ListDataFileDGV.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(64, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 21)
        Label1.TabIndex = 0
        Label1.Text = "Grafica de Año"
        ' 
        ' PanelAño
        ' 
        PanelAño.BackColor = SystemColors.ButtonHighlight
        PanelAño.Controls.Add(PanelConsolas)
        PanelAño.Controls.Add(Chart1)
        PanelAño.Controls.Add(Label1)
        PanelAño.Dock = DockStyle.Fill
        PanelAño.Location = New Point(0, 29)
        PanelAño.Name = "PanelAño"
        PanelAño.Size = New Size(800, 421)
        PanelAño.TabIndex = 3
        PanelAño.Visible = False
        ' 
        ' PanelConsolas
        ' 
        PanelConsolas.BackColor = SystemColors.ButtonHighlight
        PanelConsolas.Controls.Add(PanelGenero)
        PanelConsolas.Controls.Add(Chart2)
        PanelConsolas.Controls.Add(Label2)
        PanelConsolas.Dock = DockStyle.Fill
        PanelConsolas.Location = New Point(0, 0)
        PanelConsolas.Name = "PanelConsolas"
        PanelConsolas.Size = New Size(800, 421)
        PanelConsolas.TabIndex = 4
        ' 
        ' PanelGenero
        ' 
        PanelGenero.BackColor = SystemColors.ButtonHighlight
        PanelGenero.Controls.Add(PanelRegion)
        PanelGenero.Controls.Add(Chart3)
        PanelGenero.Controls.Add(Label6)
        PanelGenero.Dock = DockStyle.Fill
        PanelGenero.Location = New Point(0, 0)
        PanelGenero.Name = "PanelGenero"
        PanelGenero.Size = New Size(800, 421)
        PanelGenero.TabIndex = 5
        ' 
        ' PanelRegion
        ' 
        PanelRegion.BackColor = SystemColors.ButtonHighlight
        PanelRegion.Controls.Add(PanelGeneracion)
        PanelRegion.Controls.Add(Chart4)
        PanelRegion.Controls.Add(Label3)
        PanelRegion.Dock = DockStyle.Fill
        PanelRegion.Location = New Point(0, 0)
        PanelRegion.Name = "PanelRegion"
        PanelRegion.Size = New Size(800, 421)
        PanelRegion.TabIndex = 6
        ' 
        ' PanelGeneracion
        ' 
        PanelGeneracion.BackColor = SystemColors.ButtonHighlight
        PanelGeneracion.Controls.Add(Chart5)
        PanelGeneracion.Controls.Add(Label4)
        PanelGeneracion.Dock = DockStyle.Fill
        PanelGeneracion.Location = New Point(0, 0)
        PanelGeneracion.Name = "PanelGeneracion"
        PanelGeneracion.Size = New Size(800, 421)
        PanelGeneracion.TabIndex = 7
        ' 
        ' Chart5
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart5.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart5.Legends.Add(Legend1)
        Chart5.Location = New Point(12, 64)
        Chart5.Name = "Chart5"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Chart5.Series.Add(Series1)
        Chart5.Size = New Size(752, 345)
        Chart5.TabIndex = 1
        Chart5.Text = "Chart5"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(64, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(163, 21)
        Label4.TabIndex = 0
        Label4.Text = "Grafica de Generacion"
        ' 
        ' Chart4
        ' 
        ChartArea2.Name = "ChartArea1"
        Chart4.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Chart4.Legends.Add(Legend2)
        Chart4.Location = New Point(12, 64)
        Chart4.Name = "Chart4"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Chart4.Series.Add(Series2)
        Chart4.Size = New Size(752, 345)
        Chart4.TabIndex = 1
        Chart4.Text = "Chart4"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(64, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(133, 21)
        Label3.TabIndex = 0
        Label3.Text = "Grafica de Region"
        ' 
        ' Chart3
        ' 
        ChartArea3.Name = "ChartArea1"
        Chart3.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Chart3.Legends.Add(Legend3)
        Chart3.Location = New Point(12, 64)
        Chart3.Name = "Chart3"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Chart3.Series.Add(Series3)
        Chart3.Size = New Size(752, 345)
        Chart3.TabIndex = 1
        Chart3.Text = "Chart3"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(64, 24)
        Label6.Name = "Label6"
        Label6.Size = New Size(135, 21)
        Label6.TabIndex = 0
        Label6.Text = "Grafica de Genero"
        ' 
        ' Chart2
        ' 
        ChartArea4.Name = "ChartArea1"
        Chart2.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Chart2.Legends.Add(Legend4)
        Chart2.Location = New Point(12, 64)
        Chart2.Name = "Chart2"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Chart2.Series.Add(Series4)
        Chart2.Size = New Size(752, 345)
        Chart2.TabIndex = 1
        Chart2.Text = "Chart2"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(64, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 21)
        Label2.TabIndex = 0
        Label2.Text = "Grafica de Consolas"
        ' 
        ' Chart1
        ' 
        ChartArea5.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Chart1.Legends.Add(Legend5)
        Chart1.Location = New Point(12, 64)
        Chart1.Name = "Chart1"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Chart1.Series.Add(Series5)
        Chart1.Size = New Size(752, 345)
        Chart1.TabIndex = 1
        Chart1.Text = "Chart1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PanelAño)
        Controls.Add(ListDataFileDGV)
        Controls.Add(ActuallyFileLBL)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(ListDataFileDGV, ComponentModel.ISupportInitialize).EndInit()
        PanelAño.ResumeLayout(False)
        PanelAño.PerformLayout()
        PanelConsolas.ResumeLayout(False)
        PanelConsolas.PerformLayout()
        PanelGenero.ResumeLayout(False)
        PanelGenero.PerformLayout()
        PanelRegion.ResumeLayout(False)
        PanelRegion.PerformLayout()
        PanelGeneracion.ResumeLayout(False)
        PanelGeneracion.PerformLayout()
        CType(Chart5, ComponentModel.ISupportInitialize).EndInit()
        CType(Chart4, ComponentModel.ISupportInitialize).EndInit()
        CType(Chart3, ComponentModel.ISupportInitialize).EndInit()
        CType(Chart2, ComponentModel.ISupportInitialize).EndInit()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveHpwToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GraphicsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActuallyFileLBL As Label
    Friend WithEvents ListDataFileDGV As DataGridView
    Friend WithEvents AñoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsolasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GneracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelAño As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelConsolas As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelGenero As Panel
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelRegion As Panel
    Friend WithEvents PanelGeneracion As Panel
    Friend WithEvents Chart5 As DataVisualization.Charting.Chart
    Friend WithEvents Chart4 As DataVisualization.Charting.Chart

End Class
