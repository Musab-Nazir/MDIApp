Option Strict On
' Name =        Musab Nazir
' Project =     Lab 6 MDI Form
' Date =        19th April 2018
' Description = A multi-document interface (MDI) form that incorporates the text Editor and Average units shipped
'               forms previously developed.
Imports System.Windows.Forms

Public Class frmMain
    Dim FileName As String = String.Empty   'form level variable to manage file path
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles mnuNew.Click, btnNew.Click
        ' Create a new instance of the child form.
        Dim txtEditor As New frmTextEditor
        txtEditor.MdiParent = Me
        'show the form
        txtEditor.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles mnuOpen.Click, btnOpen.Click
        'create the open file dialog
        Dim OpenFileDialog As New OpenFileDialog
        'set filter
        OpenFileDialog.Filter = "txt files (*.txt)|*.txt"
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            FileName = OpenFileDialog.FileName
            Dim txtEditor As New frmTextEditor
            'call the openFile sub routine
            txtEditor.OpenFile(FileName)
            txtEditor.MdiParent = Me
            'show the form
            txtEditor.Show()
        End If

    End Sub
    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click, btnSave.Click
        If TypeOf Me.ActiveMdiChild Is frmAverageWeeklyUnitsByEmployee Then
            MessageBox.Show("Cannot Save while Average Units Shipped is active", "Invalid Action")
        Else
            'convert any open forms to text editor object
            Dim txtEditor As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)
            'check if there is a form open
            If Not txtEditor Is Nothing Then
                'call the saveFile sub
                txtEditor.SaveFile(FileName)
            End If
        End If
    End Sub
    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs) Handles mnuSaveAs.Click
        'check if its not the average units shipped form
        If TypeOf Me.ActiveMdiChild Is frmAverageWeeklyUnitsByEmployee Then
            MessageBox.Show("Cannot Save while Average Units Shipped is active", "Invalid Action")
        Else
            'convert any open forms to text editor object
            Dim txtEditor As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)
            'check if there is a form open
            If Not txtEditor Is Nothing Then
                'call the save as sub
                txtEditor.SaveAs()
            End If
        End If
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuExit.Click
        'close the program
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuCut.Click
        If Not TypeOf Me.ActiveMdiChild Is frmAverageWeeklyUnitsByEmployee Then
            Dim txtEditor As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)
            'check if there is a form open
            If Not txtEditor Is Nothing Then
                'call the copy sub
                txtEditor.Copy()
                'remove the selected text
                txtEditor.tbTextArea.SelectedText = ""
            End If
        Else
            MessageBox.Show("Cannot Cut while Average Units Shipped is active", "Invalid Action")
        End If

    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuCopy.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        If Not TypeOf Me.ActiveMdiChild Is frmAverageWeeklyUnitsByEmployee Then
            Dim txtEditor As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)
            'check if there is a form open
            If Not txtEditor Is Nothing Then
                'call copy sub
                txtEditor.Copy()
            End If
        Else
            MessageBox.Show("Cannot Copy while Average Units Shipped is active", "Invalid Action")
        End If

    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuPaste.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
        If Not TypeOf Me.ActiveMdiChild Is frmAverageWeeklyUnitsByEmployee Then
            Dim txtEditor As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)
            'check if there is a form open
            If Not txtEditor Is Nothing Then
                'call paste sub
                txtEditor.Paste()
            End If
        Else
            MessageBox.Show("Cannot Cut while Average Units Shipped is active", "Invalid Action")
        End If
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuTileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuTileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub


    Private m_ChildFormNumber As Integer

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        'close the active child form
        Me.ActiveMdiChild.Close()
    End Sub

    Private Sub mnuAverageUnitsByEmployee_Click(sender As Object, e As EventArgs) Handles mnuAverageUnitsByEmployee.Click
        ' Create a new instance of the child form.
        Dim avgUnitsForm As New frmAverageWeeklyUnitsByEmployee
        avgUnitsForm.MdiParent = Me
        'show the form
        avgUnitsForm.Show()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        'display the course code, lab and author name
        MessageBox.Show("NETD-2202" & vbCrLf & "Lab 6 - MDI Form" & vbCrLf & "M. Nazir", "About")
    End Sub
End Class
