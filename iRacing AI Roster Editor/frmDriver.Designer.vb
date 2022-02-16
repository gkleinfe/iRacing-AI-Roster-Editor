<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDriver
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim CustomLabel15 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel16 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel17 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel18 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel19 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel20 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel21 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.ChartAI = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblDriver = New System.Windows.Forms.Label()
        Me.lblCarNumber = New System.Windows.Forms.Label()
        Me.numAge = New System.Windows.Forms.NumericUpDown()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblSkill = New System.Windows.Forms.Label()
        Me.numSkill = New System.Windows.Forms.NumericUpDown()
        Me.lblAgression = New System.Windows.Forms.Label()
        Me.numAggression = New System.Windows.Forms.NumericUpDown()
        Me.lblOptimism = New System.Windows.Forms.Label()
        Me.numOptimism = New System.Windows.Forms.NumericUpDown()
        Me.lblCrewSkill = New System.Windows.Forms.Label()
        Me.numCrewSkill = New System.Windows.Forms.NumericUpDown()
        Me.lblRiskiness = New System.Windows.Forms.Label()
        Me.numRiskiness = New System.Windows.Forms.NumericUpDown()
        Me.lblSmoothness = New System.Windows.Forms.Label()
        Me.numSmoothness = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ChartAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSkill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAggression, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numOptimism, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCrewSkill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRiskiness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSmoothness, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 237)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'ChartAI
        '
        Me.ChartAI.BackColor = System.Drawing.Color.Transparent
        CustomLabel15.Text = "Skill"
        CustomLabel16.Text = "Aggression"
        CustomLabel17.Text = "Optimism"
        CustomLabel18.Text = "Smoothness"
        CustomLabel19.Text = "Age"
        CustomLabel20.Text = "Crew Skill"
        CustomLabel21.Text = "Pit Strategy"
        ChartArea3.AxisX.CustomLabels.Add(CustomLabel15)
        ChartArea3.AxisX.CustomLabels.Add(CustomLabel16)
        ChartArea3.AxisX.CustomLabels.Add(CustomLabel17)
        ChartArea3.AxisX.CustomLabels.Add(CustomLabel18)
        ChartArea3.AxisX.CustomLabels.Add(CustomLabel19)
        ChartArea3.AxisX.CustomLabels.Add(CustomLabel20)
        ChartArea3.AxisX.CustomLabels.Add(CustomLabel21)
        ChartArea3.AxisX.IsLabelAutoFit = False
        ChartArea3.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea3.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea3.AxisY.Interval = 30.0R
        ChartArea3.AxisY.LabelStyle.Enabled = False
        ChartArea3.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea3.AxisY.MajorTickMark.Enabled = False
        ChartArea3.AxisY.Maximum = 100.0R
        ChartArea3.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea3.Name = "ChartArea1"
        Me.ChartAI.ChartAreas.Add(ChartArea3)
        Me.ChartAI.Location = New System.Drawing.Point(133, -10)
        Me.ChartAI.Name = "ChartAI"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar
        Series3.Name = "s1Drivers"
        Me.ChartAI.Series.Add(Series3)
        Me.ChartAI.Size = New System.Drawing.Size(303, 253)
        Me.ChartAI.TabIndex = 3
        Me.ChartAI.Text = "ChartAI"
        '
        'lblDriver
        '
        Me.lblDriver.AutoSize = True
        Me.lblDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriver.Location = New System.Drawing.Point(53, 9)
        Me.lblDriver.Name = "lblDriver"
        Me.lblDriver.Size = New System.Drawing.Size(102, 18)
        Me.lblDriver.TabIndex = 4
        Me.lblDriver.Text = "Driver Name"
        '
        'lblCarNumber
        '
        Me.lblCarNumber.AutoSize = True
        Me.lblCarNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarNumber.Location = New System.Drawing.Point(12, 9)
        Me.lblCarNumber.Name = "lblCarNumber"
        Me.lblCarNumber.Size = New System.Drawing.Size(35, 18)
        Me.lblCarNumber.TabIndex = 5
        Me.lblCarNumber.Text = "#88"
        '
        'numAge
        '
        Me.numAge.Location = New System.Drawing.Point(88, 41)
        Me.numAge.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.numAge.Minimum = New Decimal(New Integer() {13, 0, 0, 0})
        Me.numAge.Name = "numAge"
        Me.numAge.Size = New System.Drawing.Size(39, 20)
        Me.numAge.TabIndex = 6
        Me.numAge.Value = New Decimal(New Integer() {13, 0, 0, 0})
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(12, 43)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(26, 13)
        Me.lblAge.TabIndex = 7
        Me.lblAge.Text = "Age"
        '
        'lblSkill
        '
        Me.lblSkill.AutoSize = True
        Me.lblSkill.Location = New System.Drawing.Point(12, 69)
        Me.lblSkill.Name = "lblSkill"
        Me.lblSkill.Size = New System.Drawing.Size(26, 13)
        Me.lblSkill.TabIndex = 9
        Me.lblSkill.Text = "Skill"
        '
        'numSkill
        '
        Me.numSkill.Location = New System.Drawing.Point(88, 67)
        Me.numSkill.Name = "numSkill"
        Me.numSkill.Size = New System.Drawing.Size(39, 20)
        Me.numSkill.TabIndex = 8
        Me.numSkill.Value = New Decimal(New Integer() {13, 0, 0, 0})
        '
        'lblAgression
        '
        Me.lblAgression.AutoSize = True
        Me.lblAgression.Location = New System.Drawing.Point(12, 121)
        Me.lblAgression.Name = "lblAgression"
        Me.lblAgression.Size = New System.Drawing.Size(59, 13)
        Me.lblAgression.TabIndex = 13
        Me.lblAgression.Text = "Aggression"
        '
        'numAggression
        '
        Me.numAggression.Location = New System.Drawing.Point(88, 119)
        Me.numAggression.Name = "numAggression"
        Me.numAggression.Size = New System.Drawing.Size(39, 20)
        Me.numAggression.TabIndex = 12
        Me.numAggression.Value = New Decimal(New Integer() {13, 0, 0, 0})
        '
        'lblOptimism
        '
        Me.lblOptimism.AutoSize = True
        Me.lblOptimism.Location = New System.Drawing.Point(12, 95)
        Me.lblOptimism.Name = "lblOptimism"
        Me.lblOptimism.Size = New System.Drawing.Size(49, 13)
        Me.lblOptimism.TabIndex = 11
        Me.lblOptimism.Text = "Optimism"
        '
        'numOptimism
        '
        Me.numOptimism.Location = New System.Drawing.Point(88, 93)
        Me.numOptimism.Name = "numOptimism"
        Me.numOptimism.Size = New System.Drawing.Size(39, 20)
        Me.numOptimism.TabIndex = 10
        Me.numOptimism.Value = New Decimal(New Integer() {13, 0, 0, 0})
        '
        'lblCrewSkill
        '
        Me.lblCrewSkill.AutoSize = True
        Me.lblCrewSkill.Location = New System.Drawing.Point(12, 199)
        Me.lblCrewSkill.Name = "lblCrewSkill"
        Me.lblCrewSkill.Size = New System.Drawing.Size(53, 13)
        Me.lblCrewSkill.TabIndex = 19
        Me.lblCrewSkill.Text = "Crew Skill"
        '
        'numCrewSkill
        '
        Me.numCrewSkill.Location = New System.Drawing.Point(88, 197)
        Me.numCrewSkill.Name = "numCrewSkill"
        Me.numCrewSkill.Size = New System.Drawing.Size(39, 20)
        Me.numCrewSkill.TabIndex = 18
        Me.numCrewSkill.Value = New Decimal(New Integer() {13, 0, 0, 0})
        '
        'lblRiskiness
        '
        Me.lblRiskiness.AutoSize = True
        Me.lblRiskiness.Location = New System.Drawing.Point(12, 173)
        Me.lblRiskiness.Name = "lblRiskiness"
        Me.lblRiskiness.Size = New System.Drawing.Size(52, 13)
        Me.lblRiskiness.TabIndex = 17
        Me.lblRiskiness.Text = "Riskiness"
        '
        'numRiskiness
        '
        Me.numRiskiness.Location = New System.Drawing.Point(88, 171)
        Me.numRiskiness.Name = "numRiskiness"
        Me.numRiskiness.Size = New System.Drawing.Size(39, 20)
        Me.numRiskiness.TabIndex = 16
        Me.numRiskiness.Value = New Decimal(New Integer() {13, 0, 0, 0})
        '
        'lblSmoothness
        '
        Me.lblSmoothness.AutoSize = True
        Me.lblSmoothness.Location = New System.Drawing.Point(12, 147)
        Me.lblSmoothness.Name = "lblSmoothness"
        Me.lblSmoothness.Size = New System.Drawing.Size(65, 13)
        Me.lblSmoothness.TabIndex = 15
        Me.lblSmoothness.Text = "Smoothness"
        '
        'numSmoothness
        '
        Me.numSmoothness.Location = New System.Drawing.Point(88, 145)
        Me.numSmoothness.Name = "numSmoothness"
        Me.numSmoothness.Size = New System.Drawing.Size(39, 20)
        Me.numSmoothness.TabIndex = 14
        Me.numSmoothness.Value = New Decimal(New Integer() {13, 0, 0, 0})
        '
        'frmDriver
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 278)
        Me.Controls.Add(Me.lblCrewSkill)
        Me.Controls.Add(Me.numCrewSkill)
        Me.Controls.Add(Me.lblRiskiness)
        Me.Controls.Add(Me.numRiskiness)
        Me.Controls.Add(Me.lblSmoothness)
        Me.Controls.Add(Me.numSmoothness)
        Me.Controls.Add(Me.lblAgression)
        Me.Controls.Add(Me.numAggression)
        Me.Controls.Add(Me.lblOptimism)
        Me.Controls.Add(Me.numOptimism)
        Me.Controls.Add(Me.lblSkill)
        Me.Controls.Add(Me.numSkill)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.numAge)
        Me.Controls.Add(Me.lblCarNumber)
        Me.Controls.Add(Me.lblDriver)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ChartAI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDriver"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialog1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ChartAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSkill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAggression, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numOptimism, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCrewSkill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRiskiness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSmoothness, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents ChartAI As DataVisualization.Charting.Chart
    Friend WithEvents lblDriver As Label
    Friend WithEvents lblCarNumber As Label
    Friend WithEvents numAge As NumericUpDown
    Friend WithEvents lblAge As Label
    Friend WithEvents lblSkill As Label
    Friend WithEvents numSkill As NumericUpDown
    Friend WithEvents lblAgression As Label
    Friend WithEvents numAggression As NumericUpDown
    Friend WithEvents lblOptimism As Label
    Friend WithEvents numOptimism As NumericUpDown
    Friend WithEvents lblCrewSkill As Label
    Friend WithEvents numCrewSkill As NumericUpDown
    Friend WithEvents lblRiskiness As Label
    Friend WithEvents numRiskiness As NumericUpDown
    Friend WithEvents lblSmoothness As Label
    Friend WithEvents numSmoothness As NumericUpDown
End Class
