Public Class frmCredits

    Private Sub butOK_Click(sender As Object, e As EventArgs) Handles butOK.Click
        frmMain.Enabled = True
        Me.Close()
    End Sub

    Private Sub lblOcRam_Click(sender As Object, e As EventArgs) Handles lblOcRam.Click
        Try
            Cursor = Cursors.AppStarting
            Process.Start(lblOcRam.Text)
        Catch ex As Exception

        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lblRETRO_Click(sender As Object, e As EventArgs) Handles lblRETRO.Click
        Try
            Cursor = Cursors.AppStarting
            Process.Start(lblRETRO.Text)
        Catch ex As Exception

        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

End Class