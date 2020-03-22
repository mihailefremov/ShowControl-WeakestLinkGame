<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProducerQuestionPreset
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NextCont_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContestantNumber_Textbox = New System.Windows.Forms.TextBox()
        Me.LevelUP_Button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Level_Box = New System.Windows.Forms.TextBox()
        Me.deletePresetQ_Button = New System.Windows.Forms.Button()
        Me.Save_BT = New System.Windows.Forms.Button()
        Me.FindA_Box = New System.Windows.Forms.TextBox()
        Me.FindQ_Box = New System.Windows.Forms.TextBox()
        Me.PreSetQuest_DataGridView = New System.Windows.Forms.DataGridView()
        Me.TimesAnswered_TextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RetrieveQA_Button = New System.Windows.Forms.Button()
        Me.QuestionPreview_DataGridView = New System.Windows.Forms.DataGridView()
        Me.QuestionCategory_TextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateOfCreation_TextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.QuestionDifficulty_TextBox = New System.Windows.Forms.TextBox()
        Me.BottomQuest_TextBox = New System.Windows.Forms.TextBox()
        Me.LastOrFirstSelect_Label = New System.Windows.Forms.Label()
        Me.Pronunciation_TextBox = New System.Windows.Forms.TextBox()
        CType(Me.PreSetQuest_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionPreview_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'NextCont_Button
        '
        Me.NextCont_Button.BackColor = System.Drawing.Color.NavajoWhite
        Me.NextCont_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextCont_Button.Location = New System.Drawing.Point(476, 317)
        Me.NextCont_Button.Name = "NextCont_Button"
        Me.NextCont_Button.Size = New System.Drawing.Size(69, 29)
        Me.NextCont_Button.TabIndex = 1231
        Me.NextCont_Button.Text = "Next Cont"
        Me.NextCont_Button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(473, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1229
        Me.Label1.Text = "Contestant:"
        '
        'ContestantNumber_Textbox
        '
        Me.ContestantNumber_Textbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ContestantNumber_Textbox.Location = New System.Drawing.Point(476, 289)
        Me.ContestantNumber_Textbox.Name = "ContestantNumber_Textbox"
        Me.ContestantNumber_Textbox.Size = New System.Drawing.Size(65, 20)
        Me.ContestantNumber_Textbox.TabIndex = 1230
        Me.ContestantNumber_Textbox.Text = "1"
        Me.ContestantNumber_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LevelUP_Button
        '
        Me.LevelUP_Button.BackColor = System.Drawing.Color.Azure
        Me.LevelUP_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelUP_Button.Location = New System.Drawing.Point(569, 317)
        Me.LevelUP_Button.Name = "LevelUP_Button"
        Me.LevelUP_Button.Size = New System.Drawing.Size(69, 29)
        Me.LevelUP_Button.TabIndex = 1228
        Me.LevelUP_Button.Text = "Next Round"
        Me.LevelUP_Button.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(566, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 1226
        Me.Label3.Text = "Round:"
        '
        'Level_Box
        '
        Me.Level_Box.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Level_Box.Location = New System.Drawing.Point(569, 289)
        Me.Level_Box.Name = "Level_Box"
        Me.Level_Box.Size = New System.Drawing.Size(65, 20)
        Me.Level_Box.TabIndex = 1227
        Me.Level_Box.Text = "1"
        Me.Level_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'deletePresetQ_Button
        '
        Me.deletePresetQ_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deletePresetQ_Button.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletePresetQ_Button.ForeColor = System.Drawing.Color.Black
        Me.deletePresetQ_Button.Location = New System.Drawing.Point(363, 346)
        Me.deletePresetQ_Button.Name = "deletePresetQ_Button"
        Me.deletePresetQ_Button.Size = New System.Drawing.Size(92, 48)
        Me.deletePresetQ_Button.TabIndex = 1225
        Me.deletePresetQ_Button.Text = "Delete This PresetQ"
        Me.deletePresetQ_Button.UseVisualStyleBackColor = False
        '
        'Save_BT
        '
        Me.Save_BT.BackColor = System.Drawing.Color.PapayaWhip
        Me.Save_BT.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_BT.ForeColor = System.Drawing.Color.Black
        Me.Save_BT.Location = New System.Drawing.Point(363, 270)
        Me.Save_BT.Name = "Save_BT"
        Me.Save_BT.Size = New System.Drawing.Size(91, 57)
        Me.Save_BT.TabIndex = 1224
        Me.Save_BT.Text = "Insert PresetQ"
        Me.Save_BT.UseVisualStyleBackColor = False
        '
        'FindA_Box
        '
        Me.FindA_Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindA_Box.Location = New System.Drawing.Point(19, 359)
        Me.FindA_Box.Name = "FindA_Box"
        Me.FindA_Box.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.FindA_Box.Size = New System.Drawing.Size(326, 22)
        Me.FindA_Box.TabIndex = 1223
        Me.FindA_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FindQ_Box
        '
        Me.FindQ_Box.AcceptsReturn = True
        Me.FindQ_Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindQ_Box.Location = New System.Drawing.Point(19, 270)
        Me.FindQ_Box.Multiline = True
        Me.FindQ_Box.Name = "FindQ_Box"
        Me.FindQ_Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FindQ_Box.Size = New System.Drawing.Size(326, 86)
        Me.FindQ_Box.TabIndex = 1222
        Me.FindQ_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PreSetQuest_DataGridView
        '
        Me.PreSetQuest_DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PreSetQuest_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PreSetQuest_DataGridView.Location = New System.Drawing.Point(369, 69)
        Me.PreSetQuest_DataGridView.Name = "PreSetQuest_DataGridView"
        Me.PreSetQuest_DataGridView.Size = New System.Drawing.Size(347, 185)
        Me.PreSetQuest_DataGridView.TabIndex = 1221
        '
        'TimesAnswered_TextBox
        '
        Me.TimesAnswered_TextBox.BackColor = System.Drawing.Color.Cornsilk
        Me.TimesAnswered_TextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimesAnswered_TextBox.Location = New System.Drawing.Point(298, 38)
        Me.TimesAnswered_TextBox.Name = "TimesAnswered_TextBox"
        Me.TimesAnswered_TextBox.Size = New System.Drawing.Size(49, 22)
        Me.TimesAnswered_TextBox.TabIndex = 1220
        Me.TimesAnswered_TextBox.Text = "0"
        Me.TimesAnswered_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(162, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 16)
        Me.Label12.TabIndex = 1219
        Me.Label12.Text = "Одговоренo (пати)"
        '
        'RetrieveQA_Button
        '
        Me.RetrieveQA_Button.BackColor = System.Drawing.Color.White
        Me.RetrieveQA_Button.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetrieveQA_Button.ForeColor = System.Drawing.Color.Black
        Me.RetrieveQA_Button.Location = New System.Drawing.Point(353, 35)
        Me.RetrieveQA_Button.Name = "RetrieveQA_Button"
        Me.RetrieveQA_Button.Size = New System.Drawing.Size(120, 28)
        Me.RetrieveQA_Button.TabIndex = 1218
        Me.RetrieveQA_Button.Text = "Reload QA"
        Me.RetrieveQA_Button.UseVisualStyleBackColor = False
        '
        'QuestionPreview_DataGridView
        '
        Me.QuestionPreview_DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.QuestionPreview_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QuestionPreview_DataGridView.Location = New System.Drawing.Point(18, 69)
        Me.QuestionPreview_DataGridView.Name = "QuestionPreview_DataGridView"
        Me.QuestionPreview_DataGridView.Size = New System.Drawing.Size(347, 185)
        Me.QuestionPreview_DataGridView.TabIndex = 1217
        '
        'QuestionCategory_TextBox
        '
        Me.QuestionCategory_TextBox.BackColor = System.Drawing.Color.Cornsilk
        Me.QuestionCategory_TextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionCategory_TextBox.Location = New System.Drawing.Point(94, 11)
        Me.QuestionCategory_TextBox.Name = "QuestionCategory_TextBox"
        Me.QuestionCategory_TextBox.Size = New System.Drawing.Size(55, 22)
        Me.QuestionCategory_TextBox.TabIndex = 1216
        Me.QuestionCategory_TextBox.Text = "0"
        Me.QuestionCategory_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 16)
        Me.Label11.TabIndex = 1215
        Me.Label11.Text = "CategoryID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(277, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 16)
        Me.Label10.TabIndex = 1214
        Me.Label10.Text = "Date Of Creation"
        '
        'DateOfCreation_TextBox
        '
        Me.DateOfCreation_TextBox.BackColor = System.Drawing.Color.Cornsilk
        Me.DateOfCreation_TextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOfCreation_TextBox.Location = New System.Drawing.Point(388, 11)
        Me.DateOfCreation_TextBox.Name = "DateOfCreation_TextBox"
        Me.DateOfCreation_TextBox.Size = New System.Drawing.Size(85, 22)
        Me.DateOfCreation_TextBox.TabIndex = 1213
        Me.DateOfCreation_TextBox.Text = "/"
        Me.DateOfCreation_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(155, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 1212
        Me.Label9.Text = "Difficulty"
        '
        'QuestionDifficulty_TextBox
        '
        Me.QuestionDifficulty_TextBox.BackColor = System.Drawing.Color.Cornsilk
        Me.QuestionDifficulty_TextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionDifficulty_TextBox.Location = New System.Drawing.Point(216, 12)
        Me.QuestionDifficulty_TextBox.Name = "QuestionDifficulty_TextBox"
        Me.QuestionDifficulty_TextBox.Size = New System.Drawing.Size(55, 22)
        Me.QuestionDifficulty_TextBox.TabIndex = 1211
        Me.QuestionDifficulty_TextBox.Text = "1"
        Me.QuestionDifficulty_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BottomQuest_TextBox
        '
        Me.BottomQuest_TextBox.BackColor = System.Drawing.Color.Cornsilk
        Me.BottomQuest_TextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottomQuest_TextBox.Location = New System.Drawing.Point(94, 41)
        Me.BottomQuest_TextBox.Name = "BottomQuest_TextBox"
        Me.BottomQuest_TextBox.Size = New System.Drawing.Size(55, 22)
        Me.BottomQuest_TextBox.TabIndex = 1210
        Me.BottomQuest_TextBox.Text = "50"
        Me.BottomQuest_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LastOrFirstSelect_Label
        '
        Me.LastOrFirstSelect_Label.AutoSize = True
        Me.LastOrFirstSelect_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastOrFirstSelect_Label.Location = New System.Drawing.Point(22, 41)
        Me.LastOrFirstSelect_Label.Name = "LastOrFirstSelect_Label"
        Me.LastOrFirstSelect_Label.Size = New System.Drawing.Size(73, 16)
        Me.LastOrFirstSelect_Label.TabIndex = 1209
        Me.LastOrFirstSelect_Label.Text = "Последни"
        '
        'Pronunciation_TextBox
        '
        Me.Pronunciation_TextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Pronunciation_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pronunciation_TextBox.Location = New System.Drawing.Point(19, 385)
        Me.Pronunciation_TextBox.Name = "Pronunciation_TextBox"
        Me.Pronunciation_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.Pronunciation_TextBox.Size = New System.Drawing.Size(326, 22)
        Me.Pronunciation_TextBox.TabIndex = 1232
        Me.Pronunciation_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProducerQuestionPreset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 417)
        Me.Controls.Add(Me.Pronunciation_TextBox)
        Me.Controls.Add(Me.NextCont_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ContestantNumber_Textbox)
        Me.Controls.Add(Me.LevelUP_Button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Level_Box)
        Me.Controls.Add(Me.deletePresetQ_Button)
        Me.Controls.Add(Me.Save_BT)
        Me.Controls.Add(Me.FindA_Box)
        Me.Controls.Add(Me.FindQ_Box)
        Me.Controls.Add(Me.PreSetQuest_DataGridView)
        Me.Controls.Add(Me.TimesAnswered_TextBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.RetrieveQA_Button)
        Me.Controls.Add(Me.QuestionPreview_DataGridView)
        Me.Controls.Add(Me.QuestionCategory_TextBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateOfCreation_TextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.QuestionDifficulty_TextBox)
        Me.Controls.Add(Me.BottomQuest_TextBox)
        Me.Controls.Add(Me.LastOrFirstSelect_Label)
        Me.Name = "ProducerQuestionPreset"
        Me.Text = "ProducerQuestionPreset"
        CType(Me.PreSetQuest_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionPreview_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents NextCont_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ContestantNumber_Textbox As TextBox
    Friend WithEvents LevelUP_Button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Level_Box As TextBox
    Friend WithEvents deletePresetQ_Button As Button
    Friend WithEvents Save_BT As Button
    Friend WithEvents FindA_Box As TextBox
    Friend WithEvents FindQ_Box As TextBox
    Friend WithEvents PreSetQuest_DataGridView As DataGridView
    Friend WithEvents TimesAnswered_TextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents RetrieveQA_Button As Button
    Friend WithEvents QuestionPreview_DataGridView As DataGridView
    Friend WithEvents QuestionCategory_TextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DateOfCreation_TextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents QuestionDifficulty_TextBox As TextBox
    Friend WithEvents BottomQuest_TextBox As TextBox
    Friend WithEvents LastOrFirstSelect_Label As Label
    Friend WithEvents Pronunciation_TextBox As TextBox
End Class
