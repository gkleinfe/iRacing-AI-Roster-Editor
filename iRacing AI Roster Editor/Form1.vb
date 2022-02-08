Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json.Converters
Imports Newtonsoft.Json.Serialization
Public Class Form1
    Dim ds As DataSet = JObject.Parse(ReadJSON).ToObject(Of DataSet)()
    Dim dt As DataTable = ds.Tables("drivers")
    Dim DriversBindingSource As New BindingSource
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DriversBindingSource.DataSource = dt
        dgDrivers.DataSource = DriversBindingSource

        dgDrivers.Columns("driverName").ReadOnly = True
        dgDrivers.Columns("carNumber").ReadOnly = True
        dgDrivers.Columns(2).Visible = False
        dgDrivers.Columns(3).Visible = False
        dgDrivers.Columns(4).Visible = False
        dgDrivers.Columns(5).Visible = False
        dgDrivers.Columns(6).Visible = False
        dgDrivers.Columns(7).Visible = False
        dgDrivers.Columns(8).Visible = False
        dgDrivers.Columns(9).Visible = False
        dgDrivers.Columns(10).Visible = False
        dgDrivers.Columns(18).Visible = False
        dgDrivers.Columns(19).Visible = False
        Dim t As String = dgDrivers.Rows(2).Cells(2).Value

        LoadChart()
    End Sub
    '
    Private Function ReadJSON() As String
        Dim returnjson As String = File.ReadAllText("C:\Users\Gary\Documents\iRacing\airosters\Garys Gander Outdoors Truck Series\roster.json")
        Return returnjson
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim outputjson As String = JsonConvert.SerializeObject(ds, Formatting.Indented)
        System.IO.File.WriteAllText("C:\Users\Gary\Documents\iRacing\airosters\Garys Gander Outdoors Truck Series\roster.json", outputjson)
    End Sub

    Private Sub LoadChart()
        Chart1.Series("s1Drivers").Points.AddXY(0, GetAverage("driverSkill"))
        Chart1.Series("s1Drivers").Points.AddXY(1, GetAverage("driverAggression"))
        Chart1.Series("s1Drivers").Points.AddXY(2, GetAverage("driverOptimism"))
        Chart1.Series("s1Drivers").Points.AddXY(3, GetAverage("driverSmoothness"))
        Chart1.Series("s1Drivers").Points.AddXY(4, GetAverage("pitCrewSkill"))
        Chart1.Series("s1Drivers").Points.AddXY(5, GetAverage("strategyRiskiness"))
        Chart1.Series("s1Drivers").Points.AddXY(6, GetAverage("driverAge"))
    End Sub
    Private Function GetAverage(ColumnName As String) As Short
        Dim iSum As Integer
        For Each row As DataGridViewRow In dgDrivers.Rows
            iSum = iSum + row.Cells(ColumnName).Value
        Next
        Return iSum / dgDrivers.Rows.Count
    End Function
End Class
