Public Module modMain

    Public Structure ARGS
        Dim JSON_Name As String
        Dim Text As String
        Dim Type As String
        Dim Desc As String
        Dim MinValue As String
        Dim MaxValue As String
        Dim Decimals As String
        Dim DefaultValue As String
        Dim ArgOptions As Dictionary(Of String, String)
    End Structure

    Public Structure PCM
        Dim FuncName As String
        Dim Text As String
        Dim Desc As String
        Dim Arguments As List(Of ARGS)
    End Structure

    Public Structure RM_STRUCT
        Dim StructName As String
        Dim FuncName As String
        Dim Arguments As List(Of ARGS)
    End Structure

    Public CurrentCommands As New List(Of PCM)
    Public CurrentStructs As New List(Of RM_STRUCT)

    Public Sub OpenArgument(frm As Form, arg As ARGS, list_item As ListViewItem)

        frm.Enabled = False

        If InStr(arg.Type, "[]") > 0 Then
            OpenArray(frm, arg, list_item)
            Exit Sub
        ElseIf InStr(arg.Type, "struct") > 0 Then
            OpenStruct(frm, arg, list_item)
            Exit Sub
        Else

            Dim value As String = list_item.SubItems(2).Text

            Dim frmArg As New frmArgument()

            frmArg.FormOpener = frm
            frmArg.LvwItem = list_item

            frmArg.Text = arg.Text
            frmArg.txtDesc.Text = arg.Desc

            frmArg.txtValue.Text = value

            frmArg.cmbValue.Visible = False
            frmArg.txtValue.Visible = True
            frmArg.chkOFF.Visible = False
            frmArg.chkON.Visible = False

            frmArg.MinValue = arg.MinValue
            frmArg.MaxValue = arg.MaxValue
            frmArg.Decimals = arg.Decimals
            frmArg.cmbValue.Items.Clear()
            frmArg.ArgType = arg.Type
            frmArg.ArgOptions = arg.ArgOptions

            Select Case LCase(arg.Type)
                Case "boolean"
                    frmArg.txtValue.Visible = False
                    frmArg.chkOFF.Visible = True
                    frmArg.chkON.Visible = True
                    If LCase(value) = "false" Then
                        frmArg.chkOFF.Checked = True
                        frmArg.chkON.Checked = False
                    Else
                        frmArg.chkOFF.Checked = False
                        frmArg.chkON.Checked = True
                    End If
                Case "number"
                    If Not arg.MinValue Is Nothing And Not arg.MaxValue Is Nothing Then
                        frmArg.txtDesc.Text = frmArg.txtDesc.Text & vbNewLine & "Min: " & arg.MinValue & " / Max: " & arg.MaxValue
                    Else
                        If Not arg.MinValue Is Nothing Then
                            frmArg.txtDesc.Text = frmArg.txtDesc.Text & vbNewLine & "Min: " & arg.MinValue
                        End If
                        If Not arg.MaxValue Is Nothing Then
                            frmArg.txtDesc.Text = frmArg.txtDesc.Text & vbNewLine & "Max: " & arg.MaxValue
                        End If
                    End If
                Case "select"
                    If Not arg.ArgOptions Is Nothing Then
                        If arg.ArgOptions.Count > 0 Then
                            For Each kvp In arg.ArgOptions
                                frmArg.cmbValue.Items.Add(kvp.Key)
                                If kvp.Value = value Then
                                    frmArg.cmbValue.SelectedIndex = frmArg.cmbValue.Items.Count - 1
                                End If
                            Next
                            frmArg.cmbValue.Visible = True
                            frmArg.txtValue.Visible = False
                        End If
                    End If
                Case Else ' Nothing to see here ;)
            End Select

            frmArg.Show(frm)
            frmArg.Left = frm.Left + frm.Width * 0.5 - frmArg.Width * 0.5
            frmArg.Top = frm.Top + frm.Height * 0.5 - frmArg.Height * 0.5

        End If

    End Sub

    Public Sub OpenArray(frm As Form, arg As ARGS, list_item As ListViewItem)

        Dim value As String = list_item.SubItems(2).Text

        Dim frmArray As New frmArray()

        frmArray.FormOpener = frm
        frmArray.LvwItem = list_item
        frmArray.Text = arg.Text
        frmArray.txtDesc.Text = arg.Desc
        frmArray.lstArguments.Items.Clear()
        frmArray.BaseArg = arg

        Dim parsedJSON As Object = JSON.Deserialize(value)
        If Not parsedJSON Is Nothing Then
            Dim i As Long = 1
            For Each itm In parsedJSON
                Dim list_itm As New ListViewItem
                list_itm.Text = "#" & i
                list_itm.Tag = i
                list_itm.SubItems.Add(Replace(arg.Type, "[]", ""))
                list_itm.SubItems(0).Tag = ""
                list_itm.SubItems.Add(itm)
                frmArray.lstArguments.Items.Add(list_itm)
                i += 1
            Next
        End If

        Dim list_itm_new As New ListViewItem
        list_itm_new.Text = " "
        list_itm_new.SubItems.Add("")
        list_itm_new.SubItems.Add("[Add new]")
        frmArray.lstArguments.Items.Add(list_itm_new)

        frmArray.Show(frm)
        frmArray.Left = frm.Left + frm.Width * 0.5 - frmArray.Width * 0.5
        frmArray.Top = frm.Top + frm.Height * 0.5 - frmArray.Height * 0.5

    End Sub

    Public Function Dqt(pstrInput As String) As String
        Return Chr(34) & pstrInput & Chr(34)
    End Function

    Public Sub OpenStruct(frm As Form, arg As ARGS, list_item As ListViewItem)

        Dim value As String = list_item.SubItems(2).Text

        Dim frmStruct As New frmStruct()

        frmStruct.FormOpener = frm
        frmStruct.LvwItem = list_item
        frmStruct.Text = arg.Type

        Dim parsedJSON As Object = JSON.Deserialize(value)

        For Each s In CurrentStructs
            If LCase(s.FuncName) = LCase(arg.Type) Then
                frmStruct.lstArguments.Items.Clear()
                If Not s.Arguments Is Nothing Then
                    frmStruct.Arguments = s.Arguments
                    For Each a In s.Arguments
                        Dim itm As New ListViewItem
                        itm.Text = a.Text
                        itm.Tag = a.JSON_Name
                        itm.SubItems.Add(a.Type)
                        itm.SubItems(0).Tag = a.Desc
                        If parsedJSON Is Nothing Then
                            itm.SubItems.Add(a.DefaultValue)
                        Else
                            Try
                                If parsedJSON.ContainsKey(a.JSON_Name) Then
                                    itm.SubItems.Add(parsedJSON(a.JSON_Name))
                                Else
                                    itm.SubItems.Add(a.DefaultValue)
                                End If
                            Catch ex As Exception
                                itm.SubItems.Add(a.DefaultValue)
                            End Try
                        End If
                        frmStruct.lstArguments.Items.Add(itm)
                    Next
                Else
                    frmStruct.Arguments = New List(Of ARGS)
                End If
            End If
        Next

        frmStruct.Show(frm)
        frmStruct.Left = frm.Left + frm.Width * 0.5 - frmStruct.Width * 0.5
        frmStruct.Top = frm.Top + frm.Height * 0.5 - frmStruct.Height * 0.5

    End Sub

    Public Function Get_Files(pstrPath As String, Optional pblnReturnFullPath As Boolean = False) As List(Of String)
        Return Get_Files(pstrPath, "", pblnReturnFullPath)
    End Function

    Public Function Get_Files(pstrPath As String, pstrExtension As String, Optional pblnReturnFullPath As Boolean = False) As List(Of String)

        Dim lstBuild As New List(Of String)
        Dim objFiles As ObjectModel.ReadOnlyCollection(Of String) = FileIO.FileSystem.GetFiles(pstrPath)

        If Not pblnReturnFullPath Then
            Dim arrFiles As Array
            If pstrExtension <> "" Then
                For Each strFile In objFiles
                    If LCase(Get_FileExt(strFile)) = LCase(pstrExtension) Then
                        arrFiles = Split(strFile, "\")
                        strFile = arrFiles(arrFiles.Length - 1)
                        lstBuild.Add(strFile)
                    End If
                Next
            Else
                For Each strFile In objFiles
                    arrFiles = Split(strFile, "\")
                    strFile = arrFiles(arrFiles.Length - 1)
                    lstBuild.Add(strFile)
                Next
            End If
        Else
            If pstrExtension <> "" Then
                For Each strFile In objFiles
                    If LCase(Get_FileExt(strFile)) = LCase(pstrExtension) Then lstBuild.Add(strFile)
                Next
            Else
                For Each strFile In objFiles
                    lstBuild.Add(strFile)
                Next
            End If
        End If

        Return lstBuild

    End Function

    Public Function Get_FileExt(pstrFileName As String) As String
        If InStr(pstrFileName, ".") > 0 Then
            Dim arrTmp As Array = Split(pstrFileName, ".")
            Get_FileExt = arrTmp(arrTmp.Length - 1)
        Else : Get_FileExt = "" : End If
    End Function

    Public Function GetPrevDir(pstrDir As String) As String

        Dim strBuild As String = pstrDir

        If Len(strBuild) < 4 Then Return strBuild
        If Right(strBuild, 1) = "\" Then strBuild = Left(strBuild, Len(strBuild) - 1)

        If InStr(strBuild, "\") < 1 Then Return pstrDir

        Dim arrPath As Array = Split(strBuild, "\")
        strBuild = ""

        For i = 0 To arrPath.Length - 2
            strBuild &= arrPath(i) & "\"
        Next

        strBuild = Left(strBuild, Len(strBuild) - 1)

        Return strBuild

    End Function

    Public Function Read_File(pstrFile As String, ByVal Optional utf8 As Boolean = False) As String
        If Dir(pstrFile) = "" Then Return ""
        Dim ba() As Byte = IO.File.ReadAllBytes(pstrFile)
        If utf8 Then
            Return System.Text.Encoding.UTF8.GetString(ba)
        Else ' READ BYTES >> ENCODING WITH DEFAULT CODEPAGE!
            Return System.Text.Encoding.Default.GetString(ba)
        End If
    End Function

End Module

Public Module JSON

    Private Serializer As System.Web.Script.Serialization.JavaScriptSerializer

    Public Function Deserialize(input As String) As Object
        If Serializer Is Nothing Then Serializer = New System.Web.Script.Serialization.JavaScriptSerializer()
        If input Is Nothing Or input = "" Then Return Nothing
        input = Replace(input, "\", "\\")
        input = Replace(input, "\\""", "\""")
        Return Serializer.Deserialize(Of Object)(input)
    End Function

    Public Function Deserialize(Of T)(input As String) As T
        If Serializer Is Nothing Then Serializer = New System.Web.Script.Serialization.JavaScriptSerializer()
        If input Is Nothing Or input = "" Then Return Nothing
        input = Replace(input, "\", "\\")
        input = Replace(input, "\\""", "\""")
        Return Serializer.Deserialize(Of T)(input)
    End Function

End Module