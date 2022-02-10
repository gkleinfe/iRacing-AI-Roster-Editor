<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim CustomLabel8 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel9 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel10 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel11 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel12 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel13 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel14 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.dgDrivers = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.ChartAI = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnOpenAIFolder = New System.Windows.Forms.Button()
        Me.cboAIRoster = New System.Windows.Forms.ComboBox()
        Me.lblAIRoster = New System.Windows.Forms.Label()
        Me.lblAIRosterFolder = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOpenFolderDialog = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCrewSkillDown = New System.Windows.Forms.Button()
        Me.btnCrewSkillUp = New System.Windows.Forms.Button()
        Me.btnRiskinessDown = New System.Windows.Forms.Button()
        Me.btnRiskinessUp = New System.Windows.Forms.Button()
        Me.btnSmoothnessDown = New System.Windows.Forms.Button()
        Me.btnSmoothnessUp = New System.Windows.Forms.Button()
        Me.btnAgressionDown = New System.Windows.Forms.Button()
        Me.btnAgressionUp = New System.Windows.Forms.Button()
        Me.btnOptimismDown = New System.Windows.Forms.Button()
        Me.btnOptimismUp = New System.Windows.Forms.Button()
        Me.btnSkillDown = New System.Windows.Forms.Button()
        Me.btnSkillUp = New System.Windows.Forms.Button()
        Me.btnAgeDown = New System.Windows.Forms.Button()
        Me.btnAgeUp = New System.Windows.Forms.Button()
        Me.lblBulkEdit = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.dgDrivers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgDrivers
        '
        Me.dgDrivers.AllowUserToAddRows = False
        Me.dgDrivers.AllowUserToResizeColumns = False
        Me.dgDrivers.AllowUserToResizeRows = False
        Me.dgDrivers.BackgroundColor = System.Drawing.Color.White
        Me.dgDrivers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDrivers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgDrivers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDrivers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDrivers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDrivers.Location = New System.Drawing.Point(0, 0)
        Me.dgDrivers.Name = "dgDrivers"
        Me.dgDrivers.RowHeadersVisible = False
        Me.dgDrivers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgDrivers.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDrivers.Size = New System.Drawing.Size(918, 417)
        Me.dgDrivers.TabIndex = 0
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(12, 152)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Save Roster"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'ChartAI
        '
        Me.ChartAI.BackColor = System.Drawing.Color.Transparent
        CustomLabel8.Text = "Skill"
        CustomLabel9.Text = "Aggression"
        CustomLabel10.Text = "Optimism"
        CustomLabel11.Text = "Smoothness"
        CustomLabel12.Text = "Age"
        CustomLabel13.Text = "Crew Skill"
        CustomLabel14.Text = "Pit Strategy"
        ChartArea2.AxisX.CustomLabels.Add(CustomLabel8)
        ChartArea2.AxisX.CustomLabels.Add(CustomLabel9)
        ChartArea2.AxisX.CustomLabels.Add(CustomLabel10)
        ChartArea2.AxisX.CustomLabels.Add(CustomLabel11)
        ChartArea2.AxisX.CustomLabels.Add(CustomLabel12)
        ChartArea2.AxisX.CustomLabels.Add(CustomLabel13)
        ChartArea2.AxisX.CustomLabels.Add(CustomLabel14)
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea2.AxisY.Interval = 30.0R
        ChartArea2.AxisY.LabelStyle.Enabled = False
        ChartArea2.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea2.AxisY.MajorTickMark.Enabled = False
        ChartArea2.AxisY.Maximum = 100.0R
        ChartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea2.Name = "ChartArea1"
        Me.ChartAI.ChartAreas.Add(ChartArea2)
        Me.ChartAI.Location = New System.Drawing.Point(697, -9)
        Me.ChartAI.Name = "ChartAI"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar
        Series2.Name = "s1Drivers"
        Me.ChartAI.Series.Add(Series2)
        Me.ChartAI.Size = New System.Drawing.Size(221, 178)
        Me.ChartAI.TabIndex = 2
        Me.ChartAI.Text = "ChartAI"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOpenAIFolder)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboAIRoster)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblAIRoster)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblAIRosterFolder)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOpenFolderDialog)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCrewSkillDown)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCrewSkillUp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRiskinessDown)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRiskinessUp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSmoothnessDown)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSmoothnessUp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAgressionDown)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAgressionUp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOptimismDown)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOptimismUp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSkillDown)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSkillUp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAgeDown)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAgeUp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblBulkEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ChartAI)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnUpdate)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgDrivers)
        Me.SplitContainer1.Size = New System.Drawing.Size(918, 601)
        Me.SplitContainer1.SplitterDistance = 180
        Me.SplitContainer1.TabIndex = 3
        '
        'btnOpenAIFolder
        '
        Me.btnOpenAIFolder.Location = New System.Drawing.Point(220, 77)
        Me.btnOpenAIFolder.Name = "btnOpenAIFolder"
        Me.btnOpenAIFolder.Size = New System.Drawing.Size(130, 23)
        Me.btnOpenAIFolder.TabIndex = 24
        Me.btnOpenAIFolder.Text = "Open AI Roster Folder"
        Me.btnOpenAIFolder.UseVisualStyleBackColor = True
        '
        'cboAIRoster
        '
        Me.cboAIRoster.FormattingEnabled = True
        Me.cboAIRoster.Location = New System.Drawing.Point(15, 123)
        Me.cboAIRoster.Name = "cboAIRoster"
        Me.cboAIRoster.Size = New System.Drawing.Size(350, 21)
        Me.cboAIRoster.TabIndex = 23
        '
        'lblAIRoster
        '
        Me.lblAIRoster.AutoSize = True
        Me.lblAIRoster.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAIRoster.Location = New System.Drawing.Point(12, 106)
        Me.lblAIRoster.Name = "lblAIRoster"
        Me.lblAIRoster.Size = New System.Drawing.Size(90, 13)
        Me.lblAIRoster.TabIndex = 22
        Me.lblAIRoster.Text = "Choose Roster"
        '
        'lblAIRosterFolder
        '
        Me.lblAIRosterFolder.AutoSize = True
        Me.lblAIRosterFolder.Location = New System.Drawing.Point(12, 60)
        Me.lblAIRosterFolder.Name = "lblAIRosterFolder"
        Me.lblAIRosterFolder.Size = New System.Drawing.Size(39, 13)
        Me.lblAIRosterFolder.TabIndex = 21
        Me.lblAIRosterFolder.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(322, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "AI Roster Folder (Usually Documents\iRacing\airosters)"
        '
        'btnOpenFolderDialog
        '
        Me.btnOpenFolderDialog.Location = New System.Drawing.Point(12, 76)
        Me.btnOpenFolderDialog.Name = "btnOpenFolderDialog"
        Me.btnOpenFolderDialog.Size = New System.Drawing.Size(130, 23)
        Me.btnOpenFolderDialog.TabIndex = 19
        Me.btnOpenFolderDialog.Text = "Select AI Roster Folder"
        Me.btnOpenFolderDialog.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(390, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "The radar chart won't reflect any changes until you save the roster."
        '
        'btnCrewSkillDown
        '
        Me.btnCrewSkillDown.Location = New System.Drawing.Point(819, 152)
        Me.btnCrewSkillDown.Name = "btnCrewSkillDown"
        Me.btnCrewSkillDown.Size = New System.Drawing.Size(27, 23)
        Me.btnCrewSkillDown.TabIndex = 17
        Me.btnCrewSkillDown.Tag = "CrewSkillDown"
        Me.btnCrewSkillDown.Text = "-1"
        Me.btnCrewSkillDown.UseVisualStyleBackColor = True
        '
        'btnCrewSkillUp
        '
        Me.btnCrewSkillUp.Location = New System.Drawing.Point(846, 152)
        Me.btnCrewSkillUp.Name = "btnCrewSkillUp"
        Me.btnCrewSkillUp.Size = New System.Drawing.Size(27, 23)
        Me.btnCrewSkillUp.TabIndex = 16
        Me.btnCrewSkillUp.Tag = "CrewSkillUp"
        Me.btnCrewSkillUp.Text = "+1"
        Me.btnCrewSkillUp.UseVisualStyleBackColor = True
        '
        'btnRiskinessDown
        '
        Me.btnRiskinessDown.Location = New System.Drawing.Point(722, 152)
        Me.btnRiskinessDown.Name = "btnRiskinessDown"
        Me.btnRiskinessDown.Size = New System.Drawing.Size(27, 23)
        Me.btnRiskinessDown.TabIndex = 15
        Me.btnRiskinessDown.Tag = "RiskinessDown"
        Me.btnRiskinessDown.Text = "-1"
        Me.btnRiskinessDown.UseVisualStyleBackColor = True
        '
        'btnRiskinessUp
        '
        Me.btnRiskinessUp.Location = New System.Drawing.Point(749, 152)
        Me.btnRiskinessUp.Name = "btnRiskinessUp"
        Me.btnRiskinessUp.Size = New System.Drawing.Size(27, 23)
        Me.btnRiskinessUp.TabIndex = 14
        Me.btnRiskinessUp.Tag = "RiskinessUp"
        Me.btnRiskinessUp.Text = "+1"
        Me.btnRiskinessUp.UseVisualStyleBackColor = True
        '
        'btnSmoothnessDown
        '
        Me.btnSmoothnessDown.Location = New System.Drawing.Point(622, 152)
        Me.btnSmoothnessDown.Name = "btnSmoothnessDown"
        Me.btnSmoothnessDown.Size = New System.Drawing.Size(27, 23)
        Me.btnSmoothnessDown.TabIndex = 13
        Me.btnSmoothnessDown.Tag = "SmoothnessDown"
        Me.btnSmoothnessDown.Text = "-1"
        Me.btnSmoothnessDown.UseVisualStyleBackColor = True
        '
        'btnSmoothnessUp
        '
        Me.btnSmoothnessUp.Location = New System.Drawing.Point(649, 152)
        Me.btnSmoothnessUp.Name = "btnSmoothnessUp"
        Me.btnSmoothnessUp.Size = New System.Drawing.Size(27, 23)
        Me.btnSmoothnessUp.TabIndex = 12
        Me.btnSmoothnessUp.Tag = "SmoothnessUp"
        Me.btnSmoothnessUp.Text = "+1"
        Me.btnSmoothnessUp.UseVisualStyleBackColor = True
        '
        'btnAgressionDown
        '
        Me.btnAgressionDown.Location = New System.Drawing.Point(521, 152)
        Me.btnAgressionDown.Name = "btnAgressionDown"
        Me.btnAgressionDown.Size = New System.Drawing.Size(27, 23)
        Me.btnAgressionDown.TabIndex = 11
        Me.btnAgressionDown.Tag = "AggressionDown"
        Me.btnAgressionDown.Text = "-1"
        Me.btnAgressionDown.UseVisualStyleBackColor = True
        '
        'btnAgressionUp
        '
        Me.btnAgressionUp.Location = New System.Drawing.Point(548, 152)
        Me.btnAgressionUp.Name = "btnAgressionUp"
        Me.btnAgressionUp.Size = New System.Drawing.Size(27, 23)
        Me.btnAgressionUp.TabIndex = 10
        Me.btnAgressionUp.Tag = "AggressionUp"
        Me.btnAgressionUp.Text = "+1"
        Me.btnAgressionUp.UseVisualStyleBackColor = True
        '
        'btnOptimismDown
        '
        Me.btnOptimismDown.Location = New System.Drawing.Point(422, 152)
        Me.btnOptimismDown.Name = "btnOptimismDown"
        Me.btnOptimismDown.Size = New System.Drawing.Size(27, 23)
        Me.btnOptimismDown.TabIndex = 9
        Me.btnOptimismDown.Tag = "OptimismDown"
        Me.btnOptimismDown.Text = "-1"
        Me.btnOptimismDown.UseVisualStyleBackColor = True
        '
        'btnOptimismUp
        '
        Me.btnOptimismUp.Location = New System.Drawing.Point(449, 152)
        Me.btnOptimismUp.Name = "btnOptimismUp"
        Me.btnOptimismUp.Size = New System.Drawing.Size(27, 23)
        Me.btnOptimismUp.TabIndex = 8
        Me.btnOptimismUp.Tag = "OptimismUp"
        Me.btnOptimismUp.Text = "+1"
        Me.btnOptimismUp.UseVisualStyleBackColor = True
        '
        'btnSkillDown
        '
        Me.btnSkillDown.Location = New System.Drawing.Point(323, 152)
        Me.btnSkillDown.Name = "btnSkillDown"
        Me.btnSkillDown.Size = New System.Drawing.Size(27, 23)
        Me.btnSkillDown.TabIndex = 7
        Me.btnSkillDown.Tag = "SkillDown"
        Me.btnSkillDown.Text = "-1"
        Me.btnSkillDown.UseVisualStyleBackColor = True
        '
        'btnSkillUp
        '
        Me.btnSkillUp.Location = New System.Drawing.Point(350, 152)
        Me.btnSkillUp.Name = "btnSkillUp"
        Me.btnSkillUp.Size = New System.Drawing.Size(27, 23)
        Me.btnSkillUp.TabIndex = 6
        Me.btnSkillUp.Tag = "SkillUp"
        Me.btnSkillUp.Text = "+1"
        Me.btnSkillUp.UseVisualStyleBackColor = True
        '
        'btnAgeDown
        '
        Me.btnAgeDown.Location = New System.Drawing.Point(226, 152)
        Me.btnAgeDown.Name = "btnAgeDown"
        Me.btnAgeDown.Size = New System.Drawing.Size(27, 23)
        Me.btnAgeDown.TabIndex = 5
        Me.btnAgeDown.Tag = "AgeDown"
        Me.btnAgeDown.Text = "-1"
        Me.btnAgeDown.UseVisualStyleBackColor = True
        '
        'btnAgeUp
        '
        Me.btnAgeUp.Location = New System.Drawing.Point(253, 152)
        Me.btnAgeUp.Name = "btnAgeUp"
        Me.btnAgeUp.Size = New System.Drawing.Size(27, 23)
        Me.btnAgeUp.TabIndex = 4
        Me.btnAgeUp.Tag = "AgeUp"
        Me.btnAgeUp.Text = "+1"
        Me.btnAgeUp.UseVisualStyleBackColor = True
        '
        'lblBulkEdit
        '
        Me.lblBulkEdit.AutoSize = True
        Me.lblBulkEdit.Location = New System.Drawing.Point(148, 157)
        Me.lblBulkEdit.Name = "lblBulkEdit"
        Me.lblBulkEdit.Size = New System.Drawing.Size(49, 13)
        Me.lblBulkEdit.TabIndex = 3
        Me.lblBulkEdit.Text = "Bulk Edit"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(918, 601)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(934, 2000)
        Me.MinimumSize = New System.Drawing.Size(934, 500)
        Me.Name = "Main"
        Me.Text = "iRacing AI Roster Editor"
        CType(Me.dgDrivers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartAI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgDrivers As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents ChartAI As DataVisualization.Charting.Chart
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnAgeDown As Button
    Friend WithEvents btnAgeUp As Button
    Friend WithEvents lblBulkEdit As Label
    Friend WithEvents btnCrewSkillDown As Button
    Friend WithEvents btnCrewSkillUp As Button
    Friend WithEvents btnRiskinessDown As Button
    Friend WithEvents btnRiskinessUp As Button
    Friend WithEvents btnSmoothnessDown As Button
    Friend WithEvents btnSmoothnessUp As Button
    Friend WithEvents btnAgressionDown As Button
    Friend WithEvents btnAgressionUp As Button
    Friend WithEvents btnOptimismDown As Button
    Friend WithEvents btnOptimismUp As Button
    Friend WithEvents btnSkillDown As Button
    Friend WithEvents btnSkillUp As Button
    Friend WithEvents btnOpenFolderDialog As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lblAIRosterFolder As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboAIRoster As ComboBox
    Friend WithEvents lblAIRoster As Label
    Friend WithEvents btnOpenAIFolder As Button
End Class
