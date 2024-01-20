<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Label1 = New Label()
        ListBox1 = New ListBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        GroupBox1 = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        GroupBox2 = New GroupBox()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(316, 106)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 23)
        Button1.TabIndex = 0
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(180, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter a Word:"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"Hello", "Bye", "Good Morning", "Goei dag"})
        ListBox1.Location = New Point(316, 155)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(120, 154)
        ListBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(327, 312)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(316, 56)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(135, 23)
        TextBox1.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(180, 455)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(147, 125)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Case"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(6, 57)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(72, 19)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "To Lower"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 32)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(72, 19)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "To Upper"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton4)
        GroupBox2.Controls.Add(RadioButton3)
        GroupBox2.Location = New Point(450, 455)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(120, 125)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Color"
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(6, 57)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(48, 19)
        RadioButton4.TabIndex = 1
        RadioButton4.TabStop = True
        RadioButton4.Text = "Blue"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(6, 32)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(59, 19)
        RadioButton3.TabIndex = 0
        RadioButton3.TabStop = True
        RadioButton3.Text = "Purple"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(763, 662)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "blue"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton

End Class
