Public Class frmStruct

    Public Property FormOpener As Object
    Public Property LvwItem As ListViewItem
    Public Property Arguments As List(Of ARGS)

    Dim mstrStructJSON As String = ""

    Public Sub Refresh_RETRO()

        mstrStructJSON = "{"

        For Each itm In lstArguments.Items
            mstrStructJSON = mstrStructJSON & Dqt(itm.Tag) & ":" & Dqt(itm.Subitems(2).Text) & ","
        Next

        If mstrStructJSON <> "" Then
            mstrStructJSON = Microsoft.VisualBasic.Left(mstrStructJSON, Len(mstrStructJSON) - 1)
        End If

        mstrStructJSON &= "}"

    End Sub

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

    Private Sub lstArguments_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstArguments.MouseDoubleClick

        For Each a In Arguments
            If a.Text = lstArguments.SelectedItems(0).Text Then
                OpenArgument(Me, a, lstArguments.SelectedItems(0))
                Exit For
            End If
        Next

    End Sub

    Private Sub lstArguments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstArguments.SelectedIndexChanged

    End Sub

    Private Sub frmStruct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class