Imports System.Configuration
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Collections.Specialized

Public Class frmMain
    Dim ds As DataSet
    Dim dt As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAIRosterFolder.Text = ConfigurationManager.AppSettings("aiRosterFolder")

        'Check to see if ai roster folder is empty and populate it with a default value. Then attempts to populate roster combobox
        If lblAIRosterFolder.Text.Length = 0 Then
            GetValidFolderPath(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\iRacing\airosters")
            lblAIRosterFolder.Text = ConfigurationManager.AppSettings("aiRosterFolder")
        End If
        FillAIRosters()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        WriteAIRoster(cboAIRoster.SelectedItem.ToString)
        BindAIRoster()
    End Sub
    Private Sub btnSkillDown_Click(sender As Object, e As EventArgs) Handles btnAgeDown.Click, btnAgeUp.Click, btnSkillDown.Click, btnSkillUp.Click, btnOptimismDown.Click, btnOptimismUp.Click, btnAgressionDown.Click, btnAgressionUp.Click, btnSmoothnessDown.Click, btnSmoothnessUp.Click, btnRiskinessDown.Click, btnRiskinessUp.Click, btnCrewSkillDown.Click, btnCrewSkillUp.Click
        Dim strColumnName As String = String.Empty
        Dim intIncrement As Int16
        Dim intMinValue As Integer = 0
        Dim intMaxValue As Integer = 100
        Select Case sender.tag
            Case "SkillDown"
                strColumnName = "driverSkill"
                intIncrement = -1
            Case "SkillUp"
                strColumnName = "driverSkill"
                intIncrement = +1
            Case "AggressionDown"
                strColumnName = "driverAggression"
                intIncrement = -1
            Case "AggressionUp"
                strColumnName = "driverAggression"
                intIncrement = +1
            Case "OptimismDown"
                strColumnName = "driverOptimism"
                intIncrement = -1
            Case "OptimismUp"
                strColumnName = "driverOptimism"
                intIncrement = +1
            Case "SmoothnessDown"
                strColumnName = "driverSmoothness"
                intIncrement = -1
            Case "SmoothnessUp"
                strColumnName = "driverSmoothness"
                intIncrement = +1
            Case "CrewSkillDown"
                strColumnName = "pitCrewSkill"
                intIncrement = -1
            Case "CrewSkillUp"
                strColumnName = "pitCrewSkill"
                intIncrement = +1
            Case "RiskinessDown"
                strColumnName = "strategyRiskiness"
                intIncrement = -1
            Case "RiskinessUp"
                strColumnName = "strategyRiskiness"
                intIncrement = +1
            Case "AgeDown"
                intMinValue = 13
                intMaxValue = 90
                strColumnName = "driverAge"
                intIncrement = -1
            Case "AgeUp"
                intMinValue = 13
                intMaxValue = 90
                strColumnName = "driverAge"
                intIncrement = +1

        End Select

        For Each row As DataGridViewRow In dgDrivers.SelectedRows
            If (intIncrement = -1 And row.Cells(strColumnName).Value > intMinValue) Or (intIncrement = +1 And row.Cells(strColumnName).Value < intMaxValue) Then
                row.Cells(strColumnName).Value = row.Cells(strColumnName).Value + intIncrement
            End If
        Next
    End Sub
    Private Sub btnOpenFolderDialog_Click(sender As Object, e As EventArgs) Handles btnOpenFolderDialog.Click
        GetAIRosterFolder()
    End Sub
    Private Sub btnOpenAIFolder_Click(sender As Object, e As EventArgs) Handles btnOpenAIFolder.Click
        If lblAIRosterFolder.Text.Length = 0 Then
            MsgBox("You have not specified a folder to find AI rosters.  Please click on 'Select AI Roster Folder' button to select a folder.")
        Else
            Process.Start(lblAIRosterFolder.Text)
        End If

    End Sub
    Private Sub cboAIRoster_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAIRoster.SelectedIndexChanged
        If cboAIRoster.Items(0).ToString = "No Rosters Found" Then
            ClearChart()
        Else
            ds = JObject.Parse(ReadJSON(cboAIRoster.SelectedItem.ToString)).ToObject(Of DataSet)()
            dt = ds.Tables("drivers")

            dt.Columns("driverName").SetOrdinal(0)
            dt.Columns("carNumber").SetOrdinal(1)
            dt.Columns("driverAge").SetOrdinal(2)
            dt.Columns("driverSkill").SetOrdinal(3)
            dt.Columns("driverOptimism").SetOrdinal(4)
            dt.Columns("driverAggression").SetOrdinal(5)
            dt.Columns("driverSmoothness").SetOrdinal(6)
            dt.Columns("strategyRiskiness").SetOrdinal(7)
            dt.Columns("pitCrewSkill").SetOrdinal(8)

            BindAIRoster()
        End If
    End Sub

    Private Sub LoadChart()
        ClearChart()
        ChartAI.Series("s1Drivers").Points.AddXY(0, GetAverage("driverSkill"))
        ChartAI.Series("s1Drivers").Points.AddXY(1, GetAverage("driverAggression"))
        ChartAI.Series("s1Drivers").Points.AddXY(2, GetAverage("driverOptimism"))
        ChartAI.Series("s1Drivers").Points.AddXY(3, GetAverage("driverSmoothness"))
        ChartAI.Series("s1Drivers").Points.AddXY(4, GetAverage("driverAge"))
        ChartAI.Series("s1Drivers").Points.AddXY(5, GetAverage("pitCrewSkill"))
        ChartAI.Series("s1Drivers").Points.AddXY(6, GetAverage("strategyRiskiness"))
    End Sub
    Private Sub ClearChart()
        ChartAI.Series("s1Drivers").Points.Clear()
    End Sub
    Private Sub WriteConfigKey(key As String, value As String)
        Dim configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim settings = configFile.AppSettings.Settings
        settings.Remove(key)
        settings.Add(key, value)
        configFile.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name)
    End Sub
    Private Sub GetAIRosterFolder()
        Dim dlgResult As DialogResult
        With FolderBrowserDialog1
            .SelectedPath = lblAIRosterFolder.Text
            .ShowNewFolderButton = False
            .Description = "Choose AI folder"
            dlgResult = .ShowDialog()
        End With
        If Not dlgResult = Windows.Forms.DialogResult.Cancel Then
            WriteConfigKey("aiRosterFolder", FolderBrowserDialog1.SelectedPath)

            lblAIRosterFolder.Text = ConfigurationManager.AppSettings("aiRosterFolder")

            ChooseRosterState(True)
            RosterViewState(True)
            FillAIRosters()
        End If
    End Sub
    Private Sub ChooseRosterState(bEnabled As Boolean)
        cboAIRoster.Visible = bEnabled
        lblAIRoster.Visible = bEnabled
    End Sub
    Private Sub RosterViewState(benabled As Boolean)
        btnAgeDown.Visible = benabled
        btnAgeUp.Visible = benabled
        btnSkillDown.Visible = benabled
        btnSkillUp.Visible = benabled
        btnOptimismDown.Visible = benabled
        btnOptimismUp.Visible = benabled
        btnAgressionDown.Visible = benabled
        btnAgressionUp.Visible = benabled
        btnSmoothnessDown.Visible = benabled
        btnSmoothnessUp.Visible = benabled
        btnRiskinessDown.Visible = benabled
        btnRiskinessUp.Visible = benabled
        btnCrewSkillDown.Visible = benabled
        btnCrewSkillUp.Visible = benabled
        btnUpdate.Visible = benabled
        btnUpdate.Visible = benabled
        lblBulkEdit.Visible = benabled
        dgDrivers.DataSource = Nothing
    End Sub
    Private Sub BindAIRoster()
        Dim DriversBindingSource As New BindingSource
        DriversBindingSource.DataSource = dt
        dgDrivers.DataSource = DriversBindingSource

        Dim myCol As StringCollection = New StringCollection()
        Dim myArr As String() = New String() {"driverName", "carNumber", "driverSkill", "driverAggression", "driverOptimism", "driverSmoothness", "pitCrewSkill", "strategyRiskiness", "driverAge"}
        myCol.AddRange(myArr)

        For Each column As DataGridViewColumn In dgDrivers.Columns
            If Not myCol.Contains(column.Name) Then
                dgDrivers.Columns(column.Name).Visible = False
            End If
        Next
        dgDrivers.Columns("driverName").ReadOnly = True
        dgDrivers.Columns("driverName").DefaultCellStyle.BackColor = Color.LightGray
        dgDrivers.Columns("carNumber").ReadOnly = True
        dgDrivers.Columns("carNumber").DefaultCellStyle.BackColor = Color.LightGray

        LoadChart()
    End Sub
    Private Sub FillAIRosters()
        ' Fills AI roster combo box.  If no valid rostes found, it polulates the combo with no roster found message, disables it, and diables roster viewer controls
        cboAIRoster.Items.Clear()

        For Each Dir As String In Directory.GetDirectories(GetValidFolderPath(lblAIRosterFolder.Text))
            If File.Exists(Dir & "\roster.json") Then
                Dim split As String() = Dir.Split("\")
                Dim foldername As String = split(split.Length - 1)
                cboAIRoster.Items.Add(foldername)
            End If
        Next
        'Look for valid roster folders and enable the appropriate controls
        If cboAIRoster.Items.Count = 0 Then
            cboAIRoster.Items.Add("No Rosters Found")
            cboAIRoster.Enabled = False
            RosterViewState(False)
        Else
            cboAIRoster.Enabled = True
            RosterViewState(True)
        End If
        cboAIRoster.SelectedIndex = 0
    End Sub
    Private Sub CreateBackup(FolderName As String)
        If Not File.Exists(lblAIRosterFolder.Text & "\" & FolderName & "\roster.bak") Then
            File.Copy(lblAIRosterFolder.Text & "\" & FolderName & "\roster.json", lblAIRosterFolder.Text & "\" & FolderName & "\roster.bak")
        End If
    End Sub
    Private Function GetAverage(ColumnName As String) As Short
        Dim iSum As Integer
        For Each row As DataGridViewRow In dgDrivers.Rows
            iSum = iSum + row.Cells(ColumnName).Value
        Next
        Return iSum / dgDrivers.Rows.Count
    End Function
    Private Function ReadJSON(FolderName As String) As String
        Dim returnjson As String = File.ReadAllText(lblAIRosterFolder.Text & "\" & FolderName & "\roster.json")
        Return returnjson
    End Function
    Private Sub WriteAIRoster(FolderName As String)
        CreateBackup(FolderName)
        Dim outputjson As String = JsonConvert.SerializeObject(ds, Formatting.Indented)
        File.WriteAllText(lblAIRosterFolder.Text & "\" & FolderName & "\roster.json", outputjson)
    End Sub
    Private Function GetValidFolderPath(myFolderPath As String) As String
        ' Will return current if valid or recurse to parent folders until a valid path is returned
        Do Until Directory.Exists(myFolderPath)
            myFolderPath = Directory.GetParent(myFolderPath).FullName
        Loop
        WriteConfigKey("aiRosterFolder", myFolderPath)
        lblAIRosterFolder.Text = myFolderPath
        Return myFolderPath
    End Function

    Private Sub dgDrivers_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgDrivers.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If (dgDrivers.SelectedCells.Count > 0) Then
                dgDrivers.EndEdit()
                frmDriver.ShowDialog()
            End If
        End If
    End Sub
End Class
