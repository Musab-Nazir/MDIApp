<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageWeeklyUnitsByEmployee
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAverageWeeklyUnitsByEmployee))
        Me.LblUnits = New System.Windows.Forms.Label()
        Me.TbUnitEntry = New System.Windows.Forms.TextBox()
        Me.lblDayCounter = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbEmployee1Sales = New System.Windows.Forms.RichTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblEmployee1Average = New System.Windows.Forms.Label()
        Me.lblEmployee2Average = New System.Windows.Forms.Label()
        Me.lblEmployee3Average = New System.Windows.Forms.Label()
        Me.lblFinalAverage = New System.Windows.Forms.Label()
        Me.tbEmployee2Sales = New System.Windows.Forms.RichTextBox()
        Me.tbEmployee3Sales = New System.Windows.Forms.RichTextBox()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblUnits
        '
        Me.LblUnits.Location = New System.Drawing.Point(19, 29)
        Me.LblUnits.Name = "LblUnits"
        Me.LblUnits.Size = New System.Drawing.Size(100, 23)
        Me.LblUnits.TabIndex = 0
        Me.LblUnits.Text = "U&nits"
        Me.LblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TbUnitEntry
        '
        Me.TbUnitEntry.Location = New System.Drawing.Point(140, 30)
        Me.TbUnitEntry.Name = "TbUnitEntry"
        Me.TbUnitEntry.Size = New System.Drawing.Size(100, 20)
        Me.TbUnitEntry.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TbUnitEntry, "Enter Sales for the day here")
        '
        'lblDayCounter
        '
        Me.lblDayCounter.Location = New System.Drawing.Point(260, 29)
        Me.lblDayCounter.Name = "lblDayCounter"
        Me.lblDayCounter.Size = New System.Drawing.Size(85, 23)
        Me.lblDayCounter.TabIndex = 2
        Me.lblDayCounter.Text = "&Day: 1"
        Me.lblDayCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblDayCounter, "Displays the current day of the week")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(56, 332)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "Enter data per day and calculate average")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(164, 332)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Reset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(272, 332)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Close form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbEmployee1Sales
        '
        Me.tbEmployee1Sales.Location = New System.Drawing.Point(22, 90)
        Me.tbEmployee1Sales.Name = "tbEmployee1Sales"
        Me.tbEmployee1Sales.ReadOnly = True
        Me.tbEmployee1Sales.Size = New System.Drawing.Size(97, 151)
        Me.tbEmployee1Sales.TabIndex = 6
        Me.tbEmployee1Sales.TabStop = False
        Me.tbEmployee1Sales.Text = ""
        Me.ToolTip1.SetToolTip(Me.tbEmployee1Sales, "Displays a record of sales for Employee 1")
        '
        'lblEmployee1Average
        '
        Me.lblEmployee1Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee1Average.Location = New System.Drawing.Point(22, 255)
        Me.lblEmployee1Average.Name = "lblEmployee1Average"
        Me.lblEmployee1Average.Size = New System.Drawing.Size(97, 23)
        Me.lblEmployee1Average.TabIndex = 9
        Me.lblEmployee1Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblEmployee1Average, "Displays the average units sold in the week by Employee 1")
        '
        'lblEmployee2Average
        '
        Me.lblEmployee2Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee2Average.Location = New System.Drawing.Point(151, 255)
        Me.lblEmployee2Average.Name = "lblEmployee2Average"
        Me.lblEmployee2Average.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployee2Average.TabIndex = 10
        Me.lblEmployee2Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblEmployee2Average, "Displays the average units sold in the week by Employee 2")
        '
        'lblEmployee3Average
        '
        Me.lblEmployee3Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee3Average.Location = New System.Drawing.Point(283, 255)
        Me.lblEmployee3Average.Name = "lblEmployee3Average"
        Me.lblEmployee3Average.Size = New System.Drawing.Size(97, 23)
        Me.lblEmployee3Average.TabIndex = 11
        Me.lblEmployee3Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblEmployee3Average, "Displays the average units sold in the week by Employee 3")
        '
        'lblFinalAverage
        '
        Me.lblFinalAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinalAverage.Location = New System.Drawing.Point(22, 288)
        Me.lblFinalAverage.Name = "lblFinalAverage"
        Me.lblFinalAverage.Size = New System.Drawing.Size(359, 31)
        Me.lblFinalAverage.TabIndex = 12
        Me.lblFinalAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblFinalAverage, "Displays the Average per day across all Employees")
        '
        'tbEmployee2Sales
        '
        Me.tbEmployee2Sales.Location = New System.Drawing.Point(153, 90)
        Me.tbEmployee2Sales.Name = "tbEmployee2Sales"
        Me.tbEmployee2Sales.ReadOnly = True
        Me.tbEmployee2Sales.Size = New System.Drawing.Size(97, 151)
        Me.tbEmployee2Sales.TabIndex = 7
        Me.tbEmployee2Sales.TabStop = False
        Me.tbEmployee2Sales.Text = ""
        Me.ToolTip1.SetToolTip(Me.tbEmployee2Sales, "Displays a record of sales for Employee 2")
        '
        'tbEmployee3Sales
        '
        Me.tbEmployee3Sales.Location = New System.Drawing.Point(284, 90)
        Me.tbEmployee3Sales.Name = "tbEmployee3Sales"
        Me.tbEmployee3Sales.ReadOnly = True
        Me.tbEmployee3Sales.Size = New System.Drawing.Size(97, 151)
        Me.tbEmployee3Sales.TabIndex = 8
        Me.tbEmployee3Sales.TabStop = False
        Me.tbEmployee3Sales.Text = ""
        Me.ToolTip1.SetToolTip(Me.tbEmployee3Sales, "Displays a record of sales for Employee 3")
        '
        'lblEmployee1
        '
        Me.lblEmployee1.Location = New System.Drawing.Point(19, 64)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee &1:"
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployee2
        '
        Me.lblEmployee2.Location = New System.Drawing.Point(147, 64)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployee2.TabIndex = 4
        Me.lblEmployee2.Text = "Employee &2:"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployee3
        '
        Me.lblEmployee3.Location = New System.Drawing.Point(281, 64)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployee3.TabIndex = 5
        Me.lblEmployee3.Text = "Employee &3:"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmAverageWeeklyUnitsByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(405, 367)
        Me.Controls.Add(Me.lblFinalAverage)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.lblEmployee3Average)
        Me.Controls.Add(Me.lblEmployee2Average)
        Me.Controls.Add(Me.tbEmployee3Sales)
        Me.Controls.Add(Me.tbEmployee2Sales)
        Me.Controls.Add(Me.lblEmployee1Average)
        Me.Controls.Add(Me.tbEmployee1Sales)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblDayCounter)
        Me.Controls.Add(Me.TbUnitEntry)
        Me.Controls.Add(Me.LblUnits)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageWeeklyUnitsByEmployee"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped by Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUnits As Label
    Friend WithEvents TbUnitEntry As TextBox
    Friend WithEvents lblDayCounter As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbEmployee1Sales As RichTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblEmployee1Average As Label
    Friend WithEvents tbEmployee2Sales As RichTextBox
    Friend WithEvents tbEmployee3Sales As RichTextBox
    Friend WithEvents lblEmployee2Average As Label
    Friend WithEvents lblEmployee3Average As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents lblFinalAverage As Label
End Class
