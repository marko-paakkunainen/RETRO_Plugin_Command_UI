Public Class frmArray

    Public Property FormOpener As Object
    Public Property LvwItem As ListViewItem
    Public Property BaseArg As ARGS

    Dim mstrStructJSON As String = ""

    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        FormOpener.Enabled = True
        Me.Close()
    End Sub

    Private Sub butOK_Click(sender As Object, e As EventArgs) Handles butOK.Click
        Refresh_RETRO()
        LvwItem.SubItems(2).Text = mstrStructJSON
        FormOpener.Refresh_RETRO()
        FormOpener.Enabled = True
        Me.Close()
    End Sub

    Public Sub Refresh_RETRO()

        mstrStructJSON = "["

        For Each itm In lstArguments.Items
            If Trim(itm.Text) <> "" Then
                Select Case LCase(itm.SubItems(1).Text)
                    Case "text", "string"
                        mstrStructJSON = mstrStructJSON & DqtEsc(itm.Subitems(2).Text) & ","
                    Case Else
                        mstrStructJSON = mstrStructJSON & Dqt(itm.Subitems(2).Text) & ","
                End Select
            End If
        Next

        If mstrStructJSON <> "" Then
            mstrStructJSON = Microsoft.VisualBasic.Left(mstrStructJSON, Len(mstrStructJSON) - 1)
        End If

        mstrStructJSON &= "]"

    End Sub

    Private Sub lstArguments_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstArguments.MouseDoubleClick

        Dim arg As New ARGS

        arg.ArgOptions = BaseArg.ArgOptions
        arg.Decimals = BaseArg.Decimals
        arg.DefaultValue = BaseArg.DefaultValue
        arg.Desc = BaseArg.Desc
        arg.JSON_Name = BaseArg.JSON_Name
        arg.MaxValue = BaseArg.MaxValue
        arg.MinValue = BaseArg.MinValue
        arg.Text = BaseArg.Text
        arg.Type = Replace(BaseArg.Type, "[]", "")

        If Trim(lstArguments.SelectedItems(0).Text) = "" Then
            Dim itm As New ListViewItem
            itm.Text = "#" & lstArguments.Items.Count
            itm.SubItems.Add(arg.Type)
            itm.SubItems.Add("")
            lstArguments.Items.Insert(lstArguments.Items.Count - 1, itm)
            OpenArgument(Me, arg, itm)
        Else
            OpenArgument(Me, arg, lstArguments.SelectedItems(0))
        End If

    End Sub

    Private Sub lstArguments_KeyUp(sender As Object, e As KeyEventArgs) Handles lstArguments.KeyUp
        If e.KeyCode = 46 Then
            If Not lstArguments.SelectedItems(0) Is Nothing Then
                If Trim(lstArguments.SelectedItems(0).Text) <> "" Then
                    Dim idx As Integer = lstArguments.SelectedItems(0).Index
                    lstArguments.Items.Remove(lstArguments.SelectedItems(0))
                    lstArguments.Items(idx).Selected = True
                End If
            End If
        End If
    End Sub

End Class