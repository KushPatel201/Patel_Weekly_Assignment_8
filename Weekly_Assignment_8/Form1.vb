

Option Strict On
Imports System.IO
Public Class frmSmart

    Private _intSizeOfArray As Integer = 11
    Private _strSavings(_intSizeOfArray) As String
    Private _decBill(_intSizeOfArray) As Decimal

    Private Sub frmBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim objReader As IO.StreamReader
        Dim strSavingsAmount As String
        Dim intCount As Integer = 0
        Dim intFill As Integer

        lblSavings.Text = ""
        lblAverageSavings.Text = ""
        lblMaxSavings.Text = ""


        ' My Path is this : C:\Users\levol\OneDrive\Documents\savings.txt.txt
        ' I have implemented the Try Cath and IO exception



        Try
            If IO.File.Exists("C:\Users\levol\OneDrive\Documents\savings.txt.txt") = True Then
                objReader = IO.File.OpenText("C:\Users\levol\OneDrive\Documents\savings.txt.txt")
                Do While objReader.Peek <> -1
                    _strSavings(intCount) = objReader.ReadLine()
                    strSavingsAmount = objReader.ReadLine()
                    _decBill(intCount) = Convert.ToDecimal(strSavingsAmount)
                    intCount += 1
                Loop
                objReader.Close()

                For intFill = 0 To (_strSavings.Length - 1)
                    cboMonths.Items.Add(_strSavings(intFill))
                Next
            Else
                MsgBox("The File is not Found, Restart Program when the File is Available",, "File Not Found Error")
            End If
        Catch ex As IOException
            MsgBox("An IO Exception occurred: " & ex.Message,, "IO Exception Error")
        Catch ex As Exception
            MsgBox("An unexpected error occurred: " & ex.Message,, "General Error")
        Finally
            If objReader IsNot Nothing Then
                objReader.Close()
            End If
        End Try

    End Sub

    Private Sub cboMonths_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonths.SelectedIndexChanged
        Dim intSelectedCityIndex As Integer
        intSelectedCityIndex = cboMonths.SelectedIndex
        lblSavings.Text = "The Electric Savings for " & _strSavings(intSelectedCityIndex) & " is:" & vbNewLine & "$" & _decBill(intSelectedCityIndex).ToString()

        btnStatistics.Enabled = True
        btnStatistics.Visible = True
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        ComputeAverage()
        ComputeMaxSavings()
    End Sub

    Private Sub ComputeMaxSavings()
        Dim intMonths As Integer
        Dim intLargestSavingsValue As Integer = 0
        Dim intIndexValue As Integer = 0
        Dim strYearValue As String = ""

        For Each intMonths In _decBill
            intLargestSavingsValue = Math.Max(intLargestSavingsValue, intMonths)
            If (intMonths >= intLargestSavingsValue) Then
                strYearValue = _strSavings(intIndexValue)

            End If
            intIndexValue += 1
        Next
        lblMaxSavings.Text = strYearValue & vbNewLine & "Had the Most Significant" & vbNewLine & "Monthly Savings"

    End Sub

    Private Sub ComputeAverage()
        Dim intCountYears As Integer
        Dim intyears As Integer = 0
        Dim decTotalBill As Decimal = 0
        Dim decAverageNumberOfBill As Decimal = 0D

        For Each intCountYears In _decBill
            decTotalBill += _decBill(intyears)
            intyears += 1
        Next
        decAverageNumberOfBill = decTotalBill / Convert.ToDecimal(_decBill.Length())
        lblAverageSavings.Text = "The Average Monthly Savings: " & vbNewLine & decAverageNumberOfBill.ToString("C2")

    End Sub
End Class
