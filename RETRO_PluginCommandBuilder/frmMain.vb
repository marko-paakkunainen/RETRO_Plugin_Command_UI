﻿Public Class frmMain

    Dim mlngTries As Long = 0
    Dim mstrPluginsDir As String
    Dim mstrCurrentCommandJSN As String



    Private Function ParseARG(input As String) As ARGS

        Dim a As ARGS
        Dim strRawArg As String = input

        a.JSON_Name = Trim(Split(strRawArg, vbNewLine)(0))
        a.JSON_Name = Replace(a.JSON_Name, " ", "_")

        If InStr(strRawArg, "@text") > 0 Then
            a.Text = Trim(Split(Split(strRawArg, "@text")(1), vbNewLine)(0))
        Else
            a.Text = a.JSON_Name
        End If
        If InStr(strRawArg, "@type") > 0 Then
            a.Type = Trim(Split(Split(strRawArg, "@type")(1), vbNewLine)(0))
        Else
            a.Type = "string"
        End If

        If InStr(strRawArg, "@min") > 0 Then
            a.MinValue = LCase(Trim(Split(Split(strRawArg, "@min")(1), vbNewLine)(0)))
        Else
            a.MinValue = Nothing
        End If

        If InStr(strRawArg, "@max") > 0 Then
            a.MaxValue = LCase(Trim(Split(Split(strRawArg, "@max")(1), vbNewLine)(0)))
        Else
            a.MaxValue = Nothing
        End If

        If InStr(strRawArg, "@decimals") > 0 Then
            a.Decimals = LCase(Trim(Split(Split(strRawArg, "@decimals")(1), vbNewLine)(0)))
        Else
            a.Decimals = Nothing
        End If

        If a.Type = "select" And InStr(strRawArg, "@option") > 0 Then
            Dim opts As New Dictionary(Of String, String)
            Dim rawOpts As String() = Split(strRawArg, "@option")
            For j = 1 To rawOpts.Length - 1
                Dim strOptName As String = Trim(Split(rawOpts(j), vbNewLine)(0))
                Dim strOptVal As String = Trim(Split(Split(rawOpts(j), vbNewLine)(1), "@value")(1))
                If Not opts.Keys.Contains(strOptName) Then
                    opts.Add(strOptName, strOptVal)
                Else
                    MsgBox("WARNING! Argument " & strOptName & " already declared!", vbOKOnly + vbExclamation, Me.Text)
                End If

            Next : a.ArgOptions = opts
        Else
            a.ArgOptions = New Dictionary(Of String, String)
        End If

        If InStr(strRawArg, "@desc") > 0 Then
            a.Desc = Trim(Split(Split(strRawArg, "@desc")(1), vbNewLine)(0))
        Else
            a.Desc = ""
        End If

        If InStr(strRawArg, "@default") > 0 Then
            a.DefaultValue = Trim(Split(Split(strRawArg, "@default")(1), vbNewLine)(0))
        Else
            a.DefaultValue = ""
        End If

        Return a

    End Function

    Private Sub TryPrevDir(pstrPath As String)
        If mlngTries > 3 Then
            MsgBox("Can't seem to find your plugins directory?", vbOKOnly + vbExclamation, Me.Text)
            End
        Else
            mlngTries += 1
            If Dir(mstrPluginsDir & "\js", vbDirectory) = "" Then
                mstrPluginsDir = GetPrevDir(mstrPluginsDir)
                TryPrevDir(mstrPluginsDir)
            End If
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mstrPluginsDir = AppContext.BaseDirectory
        If Microsoft.VisualBasic.Right(mstrPluginsDir, 1) = "\" Then
            mstrPluginsDir = Microsoft.VisualBasic.Left(mstrPluginsDir, Len(mstrPluginsDir) - 1)
        End If

        TryPrevDir(mstrPluginsDir)

        mstrPluginsDir = mstrPluginsDir & "\js\plugins"

        Dim lstPlugins As List(Of String) = Get_Files(mstrPluginsDir, "js", False)
        Dim strFileCont As String = ""
        Dim rex As New System.Text.RegularExpressions.Regex("\/\*.*?\@command.*?\*\/", System.Text.RegularExpressions.RegexOptions.Singleline)

        cmbPlugin.Items.Clear()
        For Each p In lstPlugins
            ' Does this plugin have any plugin commands?
            strFileCont = Read_File(mstrPluginsDir & "\" & p)
            Dim m As System.Text.RegularExpressions.Match = rex.Match(strFileCont)
            If m.Length > 0 Then
                Dim strTmp As String = Replace(p, ".js", "")
                strTmp = Replace(strTmp, ".JS", "")
                strTmp = Replace(strTmp, ".Js", "")
                strTmp = Replace(strTmp, ".jS", "")
                strTmp = Replace(strTmp, " ", "_")
                cmbPlugin.Items.Add(strTmp)
            End If
        Next

    End Sub

    Private Sub GetPluginCommands(pstrPlugin As String)

        If pstrPlugin = "" Then Exit Sub

        Dim strFile As String = mstrPluginsDir & "\" & pstrPlugin & ".js"

        If Dir(strFile) = "" Then
            MsgBox("File " & strFile & " not found!", vbOKOnly + vbExclamation, Me.Text)
            Exit Sub
        End If

        CurrentCommands.Clear()
        CurrentStructs.Clear()
        cmbCommand.Items.Clear()

        txtDesc.Text = "[Please select plugin command]"
        lstArguments.Items.Clear()

        Dim strFileCont As String = Read_File(strFile)

        ' Get command captions
        Dim rexCommands As New System.Text.RegularExpressions.Regex("\*[ ]*?\@command(.*?)" & vbNewLine, System.Text.RegularExpressions.RegexOptions.Singleline)
        Dim matches As System.Text.RegularExpressions.MatchCollection = rexCommands.Matches(strFileCont)
        Dim lstCommands As New List(Of String)
        For Each m In matches
            lstCommands.Add(Trim(m.Groups(1).Value))
        Next

        ' Get structures
        Dim rexStructs As New System.Text.RegularExpressions.Regex("\*[ ]*?\~struct\~(.*?)" & vbNewLine, System.Text.RegularExpressions.RegexOptions.Singleline)
        matches = rexStructs.Matches(strFileCont)
        Dim lstStructs As New List(Of String)
        For Each m In matches
            lstStructs.Add(Trim(Replace(m.Groups(1).Value, ":", "")))
        Next : Dim lstStructsObjects As New List(Of PCM)
        Dim idx As Long = 1
        For Each s In lstStructs
            Dim rexWholeStruct As New System.Text.RegularExpressions.Regex("\*[ ]*?\~struct\~[ ]*?" & s & "[ ]*?\:(.*?)\~|\*\/", System.Text.RegularExpressions.RegexOptions.Singleline)
            matches = rexWholeStruct.Matches(strFileCont)
            Dim strWholeStruct As String = rexWholeStruct.Matches(strFileCont)(idx).Groups(1).Value
            If InStr(strWholeStruct, "@param") > 0 Then
                Dim structObj As New RM_STRUCT
                structObj.FuncName = "struct<" & s & ">"
                structObj.StructName = s
                structObj.Arguments = New List(Of ARGS)
                Dim structParams As String() = Split(strWholeStruct, "@param")
                For i = 1 To structParams.Length - 1
                    Dim strStructParam As String = Trim(Split(structParams(i), vbNewLine)(0))
                    structObj.Arguments.Add(ParseARG(structParams(i)))
                Next
                idx += 1
                CurrentStructs.Add(structObj)
            Else
                Continue For ' No "params" in struct?!?!
            End If
        Next

        ' Get commands
        For Each c In lstCommands
            Dim rexTexts As New System.Text.RegularExpressions.Regex("\*[ ]*?\@command[ ]*?" & c & "(.*?)\*[ ]*?" & vbNewLine, System.Text.RegularExpressions.RegexOptions.Singleline)
            matches = rexTexts.Matches(strFileCont)
            Dim obj As New PCM : obj.FuncName = c
            If InStr(matches(0).Value, "@text") > 0 Then
                obj.Text = Trim(Split(Split(matches(0).Value, "@text")(1), vbNewLine)(0))
            Else
                obj.Text = c
            End If
            If InStr(matches(0).Value, "@desc") > 0 Then
                obj.Desc = Trim(Split(Split(matches(0).Value, "@desc")(1), vbNewLine)(0))
            Else
                obj.Desc = ""
            End If ' End at next: @command / @param / @help
            Dim rexArgs As New System.Text.RegularExpressions.Regex("\*[ ]*?\@command[ ]*?" & c & "(.*?)\@[pch]", System.Text.RegularExpressions.RegexOptions.Singleline)
            matches = rexArgs.Matches(strFileCont)
            If InStr(matches(0).Value, "@arg") > 0 Then
                Dim rawArgs As String() = Split(matches(0).Value, "@arg")
                Dim lstArgs = New List(Of ARGS)
                For i = 1 To rawArgs.Length - 1
                    lstArgs.Add(ParseARG(rawArgs(i)))
                Next
                obj.Arguments = lstArgs
            Else
                obj.Arguments = New List(Of ARGS)
            End If
            cmbCommand.Items.Add(obj.Text)
            CurrentCommands.Add(obj)
        Next

    End Sub

    Private Sub cmbPlugin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlugin.SelectedIndexChanged
        GetPluginCommands(cmbPlugin.Text)
    End Sub

    Private Sub GetCommand(pstrCmd As String)

        mstrCurrentCommandJSN = ""

        For Each c In CurrentCommands
            If pstrCmd = c.Text Then

                txtDesc.Text = c.Desc
                mstrCurrentCommandJSN = c.FuncName

                lstArguments.Items.Clear()

                If Not c.Arguments Is Nothing Then
                    For Each a In c.Arguments
                        Dim itm As New ListViewItem
                        itm.Text = a.Text
                        itm.Tag = a.JSON_Name
                        itm.SubItems.Add(a.Type)
                        itm.SubItems(0).Tag = a.Desc
                        itm.SubItems.Add(a.DefaultValue)
                        lstArguments.Items.Add(itm)
                    Next
                End If

            End If
        Next

        Refresh_RETRO()

    End Sub

    Public Sub Refresh_RETRO()
        Dim strArgs As String = ""
        If lstArguments.Items.Count > 0 Then
            For Each itm As ListViewItem In lstArguments.Items
                If InStr(itm.SubItems(2).Text, " ") > 0 Then
                    'strArgs &= " " & Chr(34) & Replace(itm.SubItems(2).Text, Chr(34), "\""") & Chr(34)
                    strArgs &= " " & Chr(34) & itm.SubItems(2).Text & Chr(34)
                Else
                    'strArgs &= " " & Replace(itm.SubItems(2).Text, Chr(34), "\""")
                    strArgs &= " " & itm.SubItems(2).Text
                End If
            Next
        End If
        txtResult.Text = cmbPlugin.Text & "/" & mstrCurrentCommandJSN & strArgs
    End Sub

    Private Sub cmbCommand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCommand.SelectedIndexChanged
        GetCommand(cmbCommand.Text)
    End Sub

    Private Sub lstArguments_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstArguments.MouseDoubleClick
        For Each c In CurrentCommands
            If c.Text = cmbCommand.Text Then
                For Each a In c.Arguments
                    If a.Text = lstArguments.SelectedItems(0).Text Then
                        OpenArgument(Me, a, lstArguments.SelectedItems(0))
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub butCopy_Click(sender As Object, e As EventArgs) Handles butCopy.Click
        Clipboard.Clear()
        Clipboard.SetText(txtResult.Text)
    End Sub

    Private Sub lstArguments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstArguments.SelectedIndexChanged

    End Sub
End Class