Imports System.Xml
Imports System.Windows.Forms
Imports System.IO


Public Class MainForm

    Dim ChangeFlag As Integer = 0
    Dim local_time As String = Today.ToLongDateString
    Dim xmlFileName As String = ".\日志文件\ToDoList_todayData" + local_time + ".xml"


    Sub TimeRefresh()
        TimeLabel1.Text = Now.ToLongDateString
        TimeLabel2.Text = SearchDateTimePicker.Value.ToLongDateString
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If ToDoList_today.Items.Contains(ItemTextBox.Text) = False Then
            ToDoList_today.Items.Add(ItemTextBox.Text)
        Else
            MsgBox("已有该事项，请勿重复添加")
        End If
        ChangeFlag = 1
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadCodes()
        TimeRefresh()

    End Sub

    Sub LoadCodes(Optional selectedTime = Nothing)

        ToDoList_today.Items.Clear()
        Dim loadFilePath As String

        If selectedTime = Nothing Then
            loadFilePath = xmlFileName
        Else
            loadFilePath = ".\日志文件\ToDoList_todayData" + selectedTime + ".xml"
        End If

        ' 检查文件是否存在
        If File.Exists(loadFilePath) Then
            ' 加载 XML 文档
            Dim xmlDoc As New XmlDocument()
            xmlDoc.Load(loadFilePath)

            ' 遍历 XML 中的项元素并添加到 CheckedListBox
            Dim itemNodes As XmlNodeList = xmlDoc.SelectNodes("//Item")
            For Each itemNode As XmlNode In itemNodes
                Dim itemText As String = itemNode.Attributes("Text").Value
                Dim isChecked As Boolean = Boolean.Parse(itemNode.Attributes("Checked").Value)

                ToDoList_today.Items.Add(itemText, isChecked)
            Next
        Else
            MessageBox.Show("XML 文件不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub SaveCodes(Optional selectedTime = Nothing)

        Dim saveFilePath As String

        If selectedTime = Nothing Then
            saveFilePath = xmlFileName
        Else
            saveFilePath = ".\日志文件\ToDoList_todayData" + selectedTime + ".xml"
        End If

        ' 创建 XML 文档
        Dim xmlDoc As New XmlDocument()
        Dim root As XmlElement = xmlDoc.CreateElement("CheckedListBoxItems")
        xmlDoc.AppendChild(root)

        ' 遍历 CheckedListBox 中的项并添加到 XML
        For i As Integer = 0 To ToDoList_today.Items.Count - 1
            Dim itemElement As XmlElement = xmlDoc.CreateElement("Item")
            itemElement.SetAttribute("Text", ToDoList_today.Items(i).ToString())
            itemElement.SetAttribute("Checked", ToDoList_today.CheckedItems.Contains(ToDoList_today.Items(i)).ToString())
            root.AppendChild(itemElement)
        Next

        ' 保存 XML 文档到文件
        xmlDoc.Save(saveFilePath)

        ChangeFlag = 0
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim temp As Integer
        If ChangeFlag = 1 Then
            temp = MsgBox("是否要在关闭前保存修改的内容", vbYesNo)
            If temp = vbYes Then
                SaveCodes()
            End If
        End If

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Dim selectedTime As String

        If SearchDateTimePicker.Value.ToLongDateString = Today.ToLongDateString Then
            selectedTime = Nothing
        Else
            selectedTime = SearchDateTimePicker.Value.ToLongDateString
        End If

        SaveCodes(selectedTime)

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Dim temp As Integer
        MsgBox("此操作将清空所有事项，是否继续？", vbYesNo)
        If temp = vbYes Then
            ChangeFlag = 1
            ToDoList_today.Items.Clear()
        End If

    End Sub

    Private Sub DelButton_Click(sender As Object, e As EventArgs) Handles DelButton.Click
        ChangeFlag = 1

        Dim delItem As String

        Try
            delItem = ToDoList_today.Items(LineNum.Value - 1)
            Dim temp = MsgBox("确认删除" & vbCrLf & "[ " & delItem & " ]" & vbCrLf & "这一项吗?", vbYesNo)
            If temp = vbYes Then
                ToDoList_today.Items.RemoveAt(LineNum.Value - 1)
            End If
        Catch ex As System.ArgumentOutOfRangeException
            MsgBox("删除对象超出范围，请确认行数是否正确")
        End Try

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        ChangeFlag = 1

        Dim searchTime As String = SearchDateTimePicker.Value.ToLongDateString
        LoadCodes(searchTime)
        TimeRefresh()
    End Sub

    Private Sub ToDoList_today_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToDoList_today.SelectedIndexChanged

        If ToDoList_today.SelectedIndex >= 0 Then
            LineNum.Value = ToDoList_today.SelectedIndex + 1
        End If

        'MsgBox("你选中了" & (ToDoList_today.SelectedIndex + 1) & "项,它是" & vbCrLf & ToDoList_today.SelectedItem.ToString)
    End Sub

End Class

'TODO: 明天可以试试用一个隐形的CheckListBox保存修改之前的数据，当用户点击保存时，将两个CheckListBox的数据进行比对，如果不同则进行保存
'      这样就可以实现实时判断关闭前是否需要保存的功能了
'TODO: 看看能不能找时间把保存方式从XML文件改成数据库
'      这样就可以实现多用户同时使用，并且可以查看历史记录的功能了，而且可以避免日志文件过多的问题
