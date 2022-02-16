Imports System.Windows.Forms

Public Class frmDriver

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        UpdateGrid()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmDriver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDriver.Text = frmMain.dgDrivers.SelectedRows(0).Cells(0).Value
        lblCarNumber.Text = "#" & frmMain.dgDrivers.SelectedRows(0).Cells(1).Value
        numAge.Value = frmMain.dgDrivers.SelectedRows(0).Cells(2).Value
        numSkill.Value = frmMain.dgDrivers.SelectedRows(0).Cells(3).Value
        numOptimism.Value = frmMain.dgDrivers.SelectedRows(0).Cells(4).Value
        numAggression.Value = frmMain.dgDrivers.SelectedRows(0).Cells(5).Value
        numSmoothness.Value = frmMain.dgDrivers.SelectedRows(0).Cells(6).Value
        numRiskiness.Value = frmMain.dgDrivers.SelectedRows(0).Cells(7).Value
        numCrewSkill.Value = frmMain.dgDrivers.SelectedRows(0).Cells(8).Value
        LoadChart()
    End Sub

    Private Sub LoadChart()
        ClearChart()
        ChartAI.Series("s1Drivers").Points.AddXY(0, numSkill.Value)
        ChartAI.Series("s1Drivers").Points.AddXY(1, numAggression.Value)
        ChartAI.Series("s1Drivers").Points.AddXY(2, numOptimism.Value)
        ChartAI.Series("s1Drivers").Points.AddXY(3, numSmoothness.Value)
        ChartAI.Series("s1Drivers").Points.AddXY(4, numAge.Value)
        ChartAI.Series("s1Drivers").Points.AddXY(5, numCrewSkill.Value)
        ChartAI.Series("s1Drivers").Points.AddXY(6, numRiskiness.Value)
    End Sub
    Private Sub ClearChart()
        ChartAI.Series("s1Drivers").Points.Clear()
    End Sub
    Private Sub UpdateGrid()
        frmMain.dgDrivers.SelectedRows(0).Cells(2).Value = numAge.Value
        frmMain.dgDrivers.SelectedRows(0).Cells(3).Value = numSkill.Value
        frmMain.dgDrivers.SelectedRows(0).Cells(4).Value = numOptimism.Value
        frmMain.dgDrivers.SelectedRows(0).Cells(5).Value = numAggression.Value
        frmMain.dgDrivers.SelectedRows(0).Cells(6).Value = numSmoothness.Value
        frmMain.dgDrivers.SelectedRows(0).Cells(7).Value = numRiskiness.Value
        frmMain.dgDrivers.SelectedRows(0).Cells(8).Value = numCrewSkill.Value
    End Sub

    Private Sub numAge_ValueChanged(sender As Object, e As EventArgs) Handles numAge.ValueChanged, numSkill.ValueChanged, numOptimism.ValueChanged, numAggression.ValueChanged, numSmoothness.ValueChanged, numRiskiness.ValueChanged, numCrewSkill.ValueChanged
        LoadChart()
    End Sub
End Class
