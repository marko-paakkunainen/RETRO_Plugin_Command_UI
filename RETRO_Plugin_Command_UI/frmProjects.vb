Public Class frmProjects

    Dim mstrProjectDir As String = ""

    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        frmMain.Enabled = True
        Me.Close()
    End Sub

    Private Sub LoadSettings()

        cmbProject.Items.Clear()
        If gstrProjectDir <> "" Then
            cmbProject.Items.Add(gstrProjectDir)
            cmbProject.SelectedIndex = cmbProject.Items.Count - 1
        End If

        Dim strProjects As String = My.Settings.Projects
        If strProjects Is Nothing Then strProjects = ""
        If strProjects = "" Then Exit Sub

        Dim arrProjects As String() = (strProjects & ";").Split(";")

        For Each proj In arrProjects
            If proj <> "" Then
                If Not cmbProject.Items.Contains(proj) Then
                    cmbProject.Items.Add(proj)
                End If
            End If
        Next

        If cmbProject.Text = "" And cmbProject.Items.Count > 0 Then
            cmbProject.SelectedIndex = cmbProject.Items.Count - 1
        End If

    End Sub

    Private Sub SaveSettings()

        Dim sb As New System.Text.StringBuilder()
        For Each itm In cmbProject.Items
            sb.Append(itm & ";")
        Next

        My.Settings.Projects = sb.ToString()
        My.Settings.CurrentProject = cmbProject.Text

    End Sub

    Private Sub butOK_Click(sender As Object, e As EventArgs) Handles butOK.Click

        If cmbProject.Text = "" Then
            MsgBox("Please select project first or press 'Cancel'!", vbOKOnly, frmMain.Text)
            Exit Sub
        End If

        SaveSettings()

        frmMain.SetProjectDir(mstrProjectDir)
        frmMain.Enabled = True
        Me.Close()

    End Sub

    Private Sub butNew_Click(sender As Object, e As EventArgs) Handles butNew.Click

        Dim strPath As String = AppContext.BaseDirectory

        Dim fd As OpenFileDialog = New OpenFileDialog
        fd.FileName = ""
        fd.InitialDirectory = strPath
        fd.Filter = "RPG Maker MV projects|*.rpgproject"
        fd.Title = "Select a file"
        If fd.ShowDialog() <> DialogResult.Cancel Then
            If fd.FileName <> "" Then
                If InStr(fd.FileName, "\") > 0 Then
                    Dim strProject As String = GetPathFromFile(fd.FileName)
                    If Dir(strProject & "\js", vbDirectory) <> "" Then
                        cmbProject.Items.Add(strProject)
                        cmbProject.SelectedIndex = cmbProject.Items.Count - 1
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub cmbProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProject.SelectedIndexChanged
        mstrProjectDir = cmbProject.Text
    End Sub

    Private Sub frmProjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub

End Class