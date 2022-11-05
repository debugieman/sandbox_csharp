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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FirstNameTb = New System.Windows.Forms.TextBox()
        Me.LastNameTb = New System.Windows.Forms.TextBox()
        Me.adressTb = New System.Windows.Forms.TextBox()
        Me.GenderCB = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "adress"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender "
        '
        'FirstNameTb
        '
        Me.FirstNameTb.Location = New System.Drawing.Point(123, 35)
        Me.FirstNameTb.Name = "FirstNameTb"
        Me.FirstNameTb.Size = New System.Drawing.Size(405, 23)
        Me.FirstNameTb.TabIndex = 4
        '
        'LastNameTb
        '
        Me.LastNameTb.Location = New System.Drawing.Point(123, 68)
        Me.LastNameTb.Name = "LastNameTb"
        Me.LastNameTb.Size = New System.Drawing.Size(405, 23)
        Me.LastNameTb.TabIndex = 5
        '
        'adressTb
        '
        Me.adressTb.Location = New System.Drawing.Point(123, 104)
        Me.adressTb.Multiline = True
        Me.adressTb.Name = "adressTb"
        Me.adressTb.Size = New System.Drawing.Size(405, 72)
        Me.adressTb.TabIndex = 6
        '
        'GenderCB
        '
        Me.GenderCB.CausesValidation = False
        Me.GenderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderCB.FormattingEnabled = True
        Me.GenderCB.Items.AddRange(New Object() {"<empty>", "Male", "Female"})
        Me.GenderCB.Location = New System.Drawing.Point(123, 189)
        Me.GenderCB.Name = "GenderCB"
        Me.GenderCB.Size = New System.Drawing.Size(405, 23)
        Me.GenderCB.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(340, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 82)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Add person"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(656, 35)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(650, 360)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1345, 516)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GenderCB)
        Me.Controls.Add(Me.adressTb)
        Me.Controls.Add(Me.LastNameTb)
        Me.Controls.Add(Me.FirstNameTb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Tag = "Read Files"
        Me.Text = "Write/Read/Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FirstNameTb As TextBox
    Friend WithEvents LastNameTb As TextBox
    Friend WithEvents adressTb As TextBox
    Friend WithEvents GenderCB As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
