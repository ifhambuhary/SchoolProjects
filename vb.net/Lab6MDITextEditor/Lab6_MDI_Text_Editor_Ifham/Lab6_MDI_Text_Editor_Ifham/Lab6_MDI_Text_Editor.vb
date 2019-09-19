Option Strict On
Imports System.IO
Public Class frmMain
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub mnuHorizontal_Click(sender As Object, e As EventArgs) Handles mnuHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        Dim newForm As New frmText
        newForm.MdiParent = Me
        newForm.Show()
    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click
        Dim openFile As New OpenFileDialog()

        Dim newForm As New frmText

        newForm.MdiParent = Me

        openFile.CheckFileExists = True
        openFile.DefaultExt = "txt"
        openFile.InitialDirectory = "C:\"
        openFile.Multiselect = False

        If openFile.ShowDialog = DialogResult.OK Then
            Try
                Dim reader As New StreamReader(openFile.FileName)
                newForm.txtBox.Text = reader.ReadToEnd
                newForm.Text = openFile.FileName
                reader.Close()
                newForm.Show()
            Catch ex As Exception
                Throw New ApplicationException(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        Dim saveFile As New SaveFileDialog()
        Dim activeForm As frmText = DirectCast(Me.ActiveMdiChild, frmText)
        Dim writer As StreamWriter

        saveFile.Filter = "TXT Files (*.txt*)|*.txt"

        If activeForm.Text = "Text" Then
            saveFile.ShowDialog()
            My.Computer.FileSystem.WriteAllText(saveFile.FileName, activeForm.txtBox.Text, False)
            activeForm.Text = saveFile.FileName
        Else
            writer = New StreamWriter(activeForm.Text)
            writer.Write(activeForm.txtBox.Text)
            writer.Close()
        End If
    End Sub

    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs) Handles mnuSaveAs.Click
        Dim saveFile As New SaveFileDialog()
        Dim activeForm As frmText = DirectCast(Me.ActiveMdiChild, frmText)

        saveFile.Filter = "TXT Files (*.txt*)|*.txt"

        saveFile.ShowDialog()
        My.Computer.FileSystem.WriteAllText(saveFile.FileName, activeForm.txtBox.Text, False)
        activeForm.Text = saveFile.FileName
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Dim activeForm As frmText = DirectCast(Me.ActiveMdiChild, frmText)

        Try
            activeForm.Close()
        Catch ex As Exception
            MessageBox.Show("No file to close.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Dim activeForm As frmText = DirectCast(Me.ActiveMdiChild, frmText)
        activeForm.txtBox.Cut()
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        Dim activeForm As frmText = DirectCast(Me.ActiveMdiChild, frmText)
        activeForm.txtBox.Copy()
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        Dim activeForm As frmText = DirectCast(Me.ActiveMdiChild, frmText)
        activeForm.txtBox.Paste()
    End Sub

    Private Sub mnuCascade_Click(sender As Object, e As EventArgs) Handles mnuCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuVertical_Click(sender As Object, e As EventArgs) Handles mnuVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuAverageUnits_Click(sender As Object, e As EventArgs) Handles mnuAverageUnits.Click
        Dim newForm As New AverageUnits
        newForm.MdiParent = Me
        newForm.Show()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click

        MessageBox.Show("MDI Text Editor created by Ifham Buhary.", "About Program", MessageBoxButtons.OK)

    End Sub
End Class