' Name =        Musab Nazir
' Project =     Lab 5 Text Editor
' Date =        4th April 2018
' Description = Basic text editor program that allows the user to open, close
'               and save text files. Copy, cut and paste functionality is also provided
Option Strict On

'import for the use of FileStreams
Imports System.IO
Public Class frmTextEditor
    Dim FullFilePath As String = String.Empty   ' hold the file path
    Dim isModified As Boolean = False          ' flag used to track if file was changed
    Private Sub mnuNew_Click(sender As Object, e As EventArgs) 
        FileModified()
        tbTextArea.Text = String.Empty  'reset text area
        FullFilePath = String.Empty     'reset file path
        Me.Text = "Text Editor"         'change form title back to default
        isModified = False             'reset text changed flag
    End Sub

    'Friend Function FilePathSet() As Boolean
    '    If FullFilePath = String.Empty Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
    Friend Sub OpenFile(filePath As String)
        'instantiate new OpenFileDialog object
        Dim openFileDialog As New OpenFileDialog
        'check if the file still exist, just in case
        If File.Exists(filePath) Then
            'Call the open Function And pass it the file path
            tbTextArea.Text = open(filePath)
            'Update the title bar of the editor with the path of the newly opened file
            Me.Text += " " + filePath + " Open"
        End If

        'End If
    End Sub

    Friend Sub SaveFile(path As String)
        'Instantiate new SaveFileDialog object
        Dim saveFileDialog As New SaveFileDialog
        'set filter to text files
        saveFileDialog.Filter = "txt files (*.txt)|*.txt"

        'if the global filePath variable is empty then there is no existing file, so we 
        'need to open a save dialog box
        If (path = String.Empty) Then
            If saveFileDialog.ShowDialog() = DialogResult.OK Then   'once user hits ok in the dialog
                'save the file path into the variable created
                path = saveFileDialog.FileName
            End If
        End If
        If (path <> String.Empty) Then
            'send the path and the text in the text area to the save subroutine
            save(path, tbTextArea.Text)
            'update the title bar of the ditor with the path of the newly saved file
            Me.Text += " " + saveFileDialog.FileName
        End If

    End Sub

    'The Save As event is a simpler version of the save even that shows the dialog box everytime
    'as such the implemtation is almost exactly the same without the check to see if the file
    'exists already
    Friend Sub SaveAs()
        'instantiate new SaveDialogBox object
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "txt files (*.txt)|*.txt"   'set filter

        'For Save As, we display the dialog box everytime
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            'save the file path into the variable created
            FullFilePath = saveFileDialog.FileName
            save(FullFilePath, tbTextArea.Text)
            Me.Text += " " + saveFileDialog.FileName
        End If
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) 
        FileModified()
        tbTextArea.Text = String.Empty  'reset text area
        FullFilePath = String.Empty     'reset file path
        Me.Text = "Text Editor"         'change form title back to default
        isModified = False              'reset text changed flag
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) 
        FileModified()
        Close()     'close the form
    End Sub

    Private Sub save(filePath As String, output As String)
        'instantiate a new FileStream object with mode set to create (it will overwrite if
        'the file exists already, and access set to write as we are saving. The file path is
        'passed to the FileStream as well
        Dim fileStream As New FileStream(filePath, FileMode.Create, FileAccess.Write)

        'instantiate a StreamWriter object and pass the FileStream object we just created
        Dim writeStream As New StreamWriter(fileStream)

        'write the provided output to the file
        writeStream.Write(output)

        'close the stream
        writeStream.Close()
    End Sub

    Private Function open(filePath As String) As String
        'create a string variable to old the file contents (container variable)
        Dim fileContent As String = String.Empty

        'instantiate a new FileStream object with mode set to Open and access set to read
        'as we are only opening the file. The file path is passed to the FileStream as well
        Dim fileStream As New FileStream(filePath, FileMode.Open, FileAccess.Read)

        'instantiate a StreamReader object and pass the FileStream object to it
        Dim readStream As New StreamReader(fileStream)

        'read the file till the end and save the contents in the container variable
        fileContent = readStream.ReadToEnd()

        'close the stream
        readStream.Close()
        Return fileContent
    End Function

    Friend Sub Copy()

        tbTextArea.Copy()
    End Sub

    Friend Sub Paste()
        'return the contents of the clipboard
        'tbTextArea.Text = tbTextArea.Text.Insert(tbTextArea.SelectionStart, My.Computer.Clipboard.GetText())
        tbTextArea.Paste()
        Me.Text += " Paste"
    End Sub

    Private Sub tbTextArea_TextChanged(sender As Object, e As EventArgs) Handles tbTextArea.TextChanged
        isModified = True
    End Sub

    Private Sub FileModified()
        'check if the file was modified
        If (isModified = True) Then
            'if the user selected to save do the same routine as save click event
            If DialogResult.Yes = MessageBox.Show("Would you like to save?", "File was changed", MessageBoxButtons.YesNo) Then
                'Instantiate new SaveFileDialog object
                Dim saveFileDialog As New SaveFileDialog
                'set filter to text files
                saveFileDialog.Filter = "txt files (*.txt)|*.txt"

                'if the global filePath variable is empty then there is no existing file, so we 
                'need to open a save dialog box
                If (FullFilePath = String.Empty) Then
                    If saveFileDialog.ShowDialog() = DialogResult.OK Then   'once user hits ok in the dialog
                        'save the file path into the variable created
                        FullFilePath = saveFileDialog.FileName
                    End If
                End If
                If (FullFilePath <> String.Empty) Then
                    'send the path and the text in the text area to the save subroutine
                    save(FullFilePath, tbTextArea.Text)
                    'update the title bar of the ditor with the path of the newly saved file
                    Me.Text += " " + saveFileDialog.FileName
                End If
            End If
        End If
    End Sub


End Class
