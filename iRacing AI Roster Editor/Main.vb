Imports System.Configuration
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json.Converters
Imports Newtonsoft.Json.Serialization
Imports System.Collections.Specialized

Public Class Main
    Dim ds As DataSet
    Dim dt As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAIRosterFolder.Text = ConfigurationManager.AppSettings("aiRosterFolder")

        'Check to see if ai roster folder  is empty and populate it with a default value
        If lblAIRosterFolder.Text.Length = 0 Then
            WriteConfigKey("aiRosterFolder", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\iRacing\airosters")
            lblAIRosterFolder.Text = ConfigurationManager.AppSettings("aiRosterFolder")
            'End If

            'If lblAIRosterFolder.Text.Length = 0 Then
            '    MsgBox("You must select your iRacing AI roster folder.  It's usually Documents\iRacing\airosters.")
            'GetAIRosterFolder()
            FindAIRosters()
        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        WriteAIRoster(cboAIRoster.SelectedItem.ToString)
        BindAIRoster()
    End Sub
    Private Sub btnSkillDown_Click(sender As Object, e As EventArgs) Handles btnSkillDown.Click, btnSkillUp.Click, btnAgressionDown.Click, btnAggressionUp.Click, btnOptimismDown.Click, btnOptimismUp.Click, btnSmoothnessDown.Click, btnSmoothnessUp.Click, btnCrewSkillDown.Click, btnCrewSkillUp.Click, btnRiskinessDown.Click, btnRiskinessUp.Click, btnAgeDown.Click, btnAgeUp.Click
        Dim strColumnName As String = String.Empty
        Dim intIncrement As Int16
        Dim intMinValue As Integer = 1
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
                intMinValue = 15
                intMaxValue = 70
                strColumnName = "driverAge"
                intIncrement = -1
            Case "AgeUp"
                intMinValue = 15
                intMaxValue = 70
                strColumnName = "driverAge"
                intIncrement = +1

        End Select
        For Each row As DataGridViewRow In dgDrivers.Rows
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
        If Not cboAIRoster.Items(0).ToString = "No Rosters Found" Then
            ds = JObject.Parse(ReadJSON(cboAIRoster.SelectedItem.ToString)).ToObject(Of DataSet)()
            dt = ds.Tables("drivers")
            BindAIRoster()
        End If
    End Sub


    Private Sub WriteAIRoster(FolderName As String)
        CreateBackup(FolderName)
        Dim outputjson As String = JsonConvert.SerializeObject(ds, Formatting.Indented)
        File.WriteAllText(lblAIRosterFolder.Text & "\" & FolderName & "\roster.json", outputjson)
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
        FolderBrowserDialog1.ShowDialog()

        WriteConfigKey("aiRosterFolder", FolderBrowserDialog1.SelectedPath)

        lblAIRosterFolder.Text = ConfigurationManager.AppSettings("aiRosterFolder")

        'If lblAIRosterFolder.Text.Length = 0 Then
        '    MsgBox("You didn't select a folder.  Please try again.")
        '    ChooseRosterState(False)
        '    RosterViewState(False)
        'Else
        ChooseRosterState(True)
            RosterViewState(True)
        'End If
        'If Not lblAIRosterFolder.Text.Length = 0 Then
        FindAIRosters()
        ' End If
    End Sub
    Private Sub ChooseRosterState(bEnabled As Boolean)
        cboAIRoster.Visible = bEnabled
        lblAIRoster.Visible = bEnabled
    End Sub
    Private Sub RosterViewState(benabled As Boolean)
        btnSkillDown.Visible = benabled
        btnSkillUp.Visible = benabled
        btnAgressionDown.Visible = benabled
        btnAggressionUp.Visible = benabled
        btnOptimismDown.Visible = benabled
        btnOptimismUp.Visible = benabled
        btnSmoothnessDown.Visible = benabled
        btnSmoothnessUp.Visible = benabled
        btnCrewSkillDown.Visible = benabled
        btnCrewSkillUp.Visible = benabled
        btnRiskinessDown.Visible = benabled
        btnRiskinessUp.Visible = benabled
        btnAgeDown.Visible = benabled
        btnAgeUp.Visible = benabled
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
    Private Sub FindAIRosters()
        cboAIRoster.Items.Clear()

        For Each Dir As String In Directory.GetDirectories(lblAIRosterFolder.Text)
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

End Class
