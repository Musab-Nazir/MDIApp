'******************************************************************************
'Author:        Musab Nazir
'Date Written:  01 March 2018
'Project Name:  Average Units Shipped by Employee
'Description:   The form lets a user input sales for each day of the week one
'               employee at a time. Once all the data is added it calculates
'               the average per day across all employees
'******************************************************************************
Option Strict On
Public Class frmAverageWeeklyUnitsByEmployee
    'Variable Declarations
    Private Const DAYS_IN_A_WEEK As Integer = 7
    Private Const EMPLOYEE_COUNT As Integer = 3
    Private Const MINIMUM_INPUT As Integer = 0
    Private Const MAXIMUM_INPUT As Integer = 1000

    Dim salesData(DAYS_IN_A_WEEK - 1, EMPLOYEE_COUNT - 1) As Double
    Dim dayCount As Integer = 1
    Dim currentEmployee As Integer = 0


    ''' <summary>
    ''' This is the average calculator method. It will take 2 required and one optional input
    ''' The optional input determines the starting column the loop begins depending on whether
    ''' the average is only needed for a single employee or all three
    ''' </summary>
    ''' <param name="inputArray"> array holding the sales data</param>
    ''' <param name="employeeIndex"> Tdetermines till which column the loop runs</param>
    ''' <param name="startingIndex"> this is optional and by default starts at first column</param>
    ''' <returns name="average"> this is the double variable holding the average value</returns>
    Private Function AverageCalculator(inputArray(,) As Double, employeeIndex As Integer,
                                       Optional startingIndex As Integer = 0) As Double
        Dim average As Double = 0
        Dim sum As Double = 0
        For employee As Integer = startingIndex To employeeIndex
            For counter As Integer = 0 To (DAYS_IN_A_WEEK - 1)
                sum += inputArray(counter, employee)
            Next counter
        Next
        If (startingIndex = 0 And employeeIndex = 2) Then
            average = sum / Convert.ToDouble(DAYS_IN_A_WEEK * EMPLOYEE_COUNT)
        Else
            average = sum / Convert.ToDouble(DAYS_IN_A_WEEK)
        End If
        Return average
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim salesNumber As String
        Dim userInput As Integer = 0
        Dim salesAverage As Double = 0
        'Input Validation - Check if the input is a whole number first
        If (Int32.TryParse(TbUnitEntry.Text, userInput) = True) Then
            'Input Validation - Check the range of the input
            If (userInput >= MINIMUM_INPUT And userInput <= MAXIMUM_INPUT) Then

                'Once the input passes the validation, store the data and display in the 
                'correct display box corresponding the employee
                salesData(dayCount - 1, currentEmployee) = userInput
                salesNumber = Convert.ToString(salesData(dayCount - 1, currentEmployee))
                If (currentEmployee = 0) Then
                    tbEmployee1Sales.AppendText(salesNumber & vbCrLf)

                ElseIf (currentEmployee = 1) Then
                    tbEmployee2Sales.AppendText(salesNumber & vbCrLf)

                ElseIf (currentEmployee = 2) Then
                    tbEmployee3Sales.AppendText(salesNumber & vbCrLf)

                End If

                TbUnitEntry.Clear()
                'if the last day of the week is not reached, increment day counter
                If (dayCount <> DAYS_IN_A_WEEK) Then
                    lblDayCounter.Text = String.Concat("&Day: ", dayCount + 1)
                    dayCount += 1
                    'last day of the week is reached, reset counter
                Else
                    dayCount = 0
                    lblDayCounter.Text = String.Concat("&Day: ", dayCount + 1)
                    'Display the average depending on the employee
                    If (currentEmployee = 0) Then
                        salesAverage = AverageCalculator(salesData, currentEmployee)
                        lblEmployee1Average.Text = "Average: " + salesAverage.ToString("N2")

                    ElseIf (currentEmployee = 1) Then
                        salesAverage = AverageCalculator(salesData, currentEmployee, currentEmployee)
                        lblEmployee2Average.Text = "Average: " + salesAverage.ToString("N2")

                    ElseIf (currentEmployee = 2) Then
                        salesAverage = AverageCalculator(salesData, currentEmployee, currentEmployee)
                        lblEmployee3Average.Text = "Average: " + salesAverage.ToString("N2")

                        salesAverage = 0
                        'Display the average per day across all employees
                        salesAverage = AverageCalculator(salesData, currentEmployee)
                        lblFinalAverage.Text = "Average per day: " + salesAverage.ToString("N2")
                        TbUnitEntry.ReadOnly = True
                        btnEnter.Enabled = False
                    End If
                    'Increment day counter and move to next employee
                    currentEmployee += 1
                    dayCount += 1
                End If
            Else
                'Range error
                MessageBox.Show("Units entered must be between 0 and 1000", "Input Out of Range")
                TbUnitEntry.Focus()
                TbUnitEntry.SelectAll()
            End If
        Else
            'Input was not an integer, error
            MessageBox.Show("Please enter a whole number", "Invalid Entry")
            TbUnitEntry.Focus()
            TbUnitEntry.SelectAll()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset all labels and textboxes
        TbUnitEntry.Clear()
        TbUnitEntry.ReadOnly = False
        btnEnter.Enabled = True

        tbEmployee1Sales.Clear()
        tbEmployee2Sales.Clear()
        tbEmployee3Sales.Clear()
        lblEmployee1Average.ResetText()
        lblEmployee2Average.ResetText()
        lblEmployee3Average.ResetText()
        lblFinalAverage.ResetText()

        'Reset form level variables
        dayCount = 1
        currentEmployee = 0
        Array.Clear(salesData, index:=0, length:=salesData.Length)

        'Set the day counter to first day
        lblDayCounter.Text = String.Concat("&Day: ", dayCount)
    End Sub
End Class
