<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TimeLabel1 = New System.Windows.Forms.Label()
        Me.ToDoList_today = New System.Windows.Forms.CheckedListBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DelButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ItemTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.LineNum = New System.Windows.Forms.NumericUpDown()
        Me.SearchDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TimeLabel2 = New System.Windows.Forms.Label()
        CType(Me.LineNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimeLabel1
        '
        Me.TimeLabel1.AutoSize = True
        Me.TimeLabel1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TimeLabel1.Location = New System.Drawing.Point(396, 413)
        Me.TimeLabel1.Name = "TimeLabel1"
        Me.TimeLabel1.Size = New System.Drawing.Size(111, 16)
        Me.TimeLabel1.TabIndex = 1
        Me.TimeLabel1.Text = "2025年5月19日"
        '
        'ToDoList_today
        '
        Me.ToDoList_today.FormattingEnabled = True
        Me.ToDoList_today.HorizontalScrollbar = True
        Me.ToDoList_today.Items.AddRange(New Object() {"测试用1", "测试用2", "测试用3"})
        Me.ToDoList_today.Location = New System.Drawing.Point(17, 41)
        Me.ToDoList_today.Name = "ToDoList_today"
        Me.ToDoList_today.Size = New System.Drawing.Size(298, 388)
        Me.ToDoList_today.TabIndex = 2
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(334, 41)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 3
        Me.AddButton.Text = "添加新事项"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'DelButton
        '
        Me.DelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DelButton.Location = New System.Drawing.Point(334, 71)
        Me.DelButton.Name = "DelButton"
        Me.DelButton.Size = New System.Drawing.Size(86, 23)
        Me.DelButton.TabIndex = 4
        Me.DelButton.Text = "删除指定事项"
        Me.DelButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(426, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "行数："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(415, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "事项内容："
        '
        'ItemTextBox
        '
        Me.ItemTextBox.Location = New System.Drawing.Point(486, 43)
        Me.ItemTextBox.Name = "ItemTextBox"
        Me.ItemTextBox.Size = New System.Drawing.Size(287, 21)
        Me.ItemTextBox.TabIndex = 8
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(334, 101)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 9
        Me.SaveButton.Text = "保存列表"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(334, 130)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "清空列表"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'LineNum
        '
        Me.LineNum.Location = New System.Drawing.Point(473, 73)
        Me.LineNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LineNum.Name = "LineNum"
        Me.LineNum.Size = New System.Drawing.Size(44, 21)
        Me.LineNum.TabIndex = 11
        Me.LineNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'SearchDateTimePicker
        '
        Me.SearchDateTimePicker.Location = New System.Drawing.Point(523, 161)
        Me.SearchDateTimePicker.Name = "SearchDateTimePicker"
        Me.SearchDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.SearchDateTimePicker.TabIndex = 12
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(334, 159)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(183, 23)
        Me.SearchButton.TabIndex = 13
        Me.SearchButton.Text = "查找指定日期的待完成事项"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "待办事项："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(321, 413)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "今日日期："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(523, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "待办事项日期："
        '
        'TimeLabel2
        '
        Me.TimeLabel2.AutoSize = True
        Me.TimeLabel2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TimeLabel2.Location = New System.Drawing.Point(630, 413)
        Me.TimeLabel2.Name = "TimeLabel2"
        Me.TimeLabel2.Size = New System.Drawing.Size(111, 16)
        Me.TimeLabel2.TabIndex = 17
        Me.TimeLabel2.Text = "2025年5月19日"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TimeLabel2)
        Me.Controls.Add(Me.TimeLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchDateTimePicker)
        Me.Controls.Add(Me.LineNum)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ItemTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DelButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ToDoList_today)
        Me.Name = "MainForm"
        Me.Text = "苍兰君的ToDo清单"
        CType(Me.LineNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimeLabel1 As Label
    Friend WithEvents ToDoList_today As CheckedListBox
    Friend WithEvents AddButton As Button
    Friend WithEvents DelButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ItemTextBox As TextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents LineNum As NumericUpDown
    Friend WithEvents SearchDateTimePicker As DateTimePicker
    Friend WithEvents SearchButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TimeLabel2 As Label
End Class
