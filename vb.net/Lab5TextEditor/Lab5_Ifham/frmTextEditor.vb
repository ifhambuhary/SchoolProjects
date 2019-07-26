'/* *********************************************************************	
'*	Lab 5 - Text Editor
'*
'*	This  Windows Forms application that will be able to open, close, edit,
'*  save, save as, And create New files (.txt).  
'*	
'*	Author 	- 	Ifham Buhary
'*	Date	-	07/26/2019
'*	
'*************************************************************************/

Option Strict On
Imports System.IO
Public Class frmTextEditor

    Dim saveDestination As String
    ''' <summary>
    ''' Open File Dialog
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Dim Reader As New StreamReader(OpenFileDialog1.FileName)
                txtInput.Text = Reader.ReadToEnd
                Reader.Close()
            Catch ex As Exception
                Throw New ApplicationException(ex.ToString)
            End Try
        End If
    End Sub
    ''' <summary>
    ''' Exit Application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub
    ''' <summary>
    ''' Copy Text
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        txtInput.Copy()
    End Sub
    ''' <summary>
    ''' Cut Text
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        txtInput.Cut()
    End Sub
    ''' <summary>
    ''' Paste Text
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        txtInput.Paste()
    End Sub
    ''' <summary>
    ''' About Program - Display in Messagebox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        MessageBox.Show("NETD2302" & vbCrLf & vbCrLf & "Lab 5" & vbCrLf & vbCrLf & "Ifham", "About", MessageBoxButtons.OK)
    End Sub
    ''' <summary>
    ''' Save As Dialog 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs) Handles mnuSaveAs.Click

        SaveFileDialog1.Filter = "TXT Files (*.txt)|.txt"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, txtInput.Text, False)

        End If
    End Sub
    ''' <summary>
    ''' Save Dialog
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        If saveDestination = "" Then

            SaveFileDialog1.Filter = "TXT Files (*.txt)|.txt"

            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, txtInput.Text, False)
            End If
        Else
            My.Computer.FileSystem.WriteAllText(saveDestination, txtInput.Text, False)
        End If

    End Sub
    ''' <summary>
    ''' New File 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        saveDestination = String.Empty
        txtInput.Text = ""
    End Sub
End Class
