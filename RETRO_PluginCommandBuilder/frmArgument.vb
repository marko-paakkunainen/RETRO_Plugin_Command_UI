Public Class frmArgument

    Public Property MinValue As String = Nothing
    Public Property MaxValue As String = Nothing
    Public Property Decimals As String = Nothing
    Public Property ArgType As String = "string"
    Public Property ArgOptions As New Dictionary(Of String, String)
    Public Property FormOpener As Object
    Public Property LvwItem As ListViewItem

    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        FormOpener.Enabled = True
        Me.Close()
    End Sub

    Private Sub butOK_Click(sender As Object, e As EventArgs) Handles butOK.Click

        If cmbValue.Visible Then
            For Each kvp In ArgOptions
                If kvp.Key = cmbValue.Text Then
                    LvwItem.SubItems(2).Text = kvp.Value
                End If
            Next
        ElseIf chkOFF.Visible Then
            If chkOFF.Checked Then
                LvwItem.SubItems(2).Text = "false"
            Else
                LvwItem.SubItems(2).Text = "true"
            End If
        ElseIf Me.ArgType = "number" Then

            Dim strVal As String = txtValue.Text

            If Not Me.Decimals Is Nothing And Val(Me.Decimals) > 0 Then
                Dim strDec As String = Microsoft.VisualBasic.Left(Split(txtValue.Text & ".", ".")(1), Val(Me.Decimals))
                If strDec = "" Then strDec = "0"
                Do While Len(strDec) < Val(Me.Decimals)
                    strDec = strDec & "0"
                Loop
                strVal = Val(Microsoft.VisualBasic.Left(Split(txtValue.Text & ".", ".")(0), 24)) & "." & strDec
            End If

            If Not Me.MinValue Is Nothing Then
                If Val(Me.MinValue) > Val(strVal) Then strVal = Me.MinValue
            End If

            If Not Me.MaxValue Is Nothing Then
                If Val(Me.MaxValue) < Val(strVal) Then strVal = Me.MaxValue
            End If

            LvwItem.SubItems(2).Text = strVal

        Else
            LvwItem.SubItems(2).Text = txtValue.Text
        End If

        FormOpener.Refresh_RETRO()
        FormOpener.Enabled = True

        Me.Close()

    End Sub

    Private Sub frmArgument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbValue.Top = txtValue.Top
        chkOFF.Top = txtValue.Top
        chkON.Top = txtValue.Top
    End Sub

    Private Sub chkOFF_CheckedChanged(sender As Object, e As EventArgs) Handles chkOFF.CheckedChanged
        chkON.Checked = Not chkOFF.Checked
    End Sub

    Private Sub chkON_CheckedChanged(sender As Object, e As EventArgs) Handles chkON.CheckedChanged
        chkOFF.Checked = Not chkON.Checked
    End Sub
End Class