<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ButtonOtherStuff = New System.Windows.Forms.Button()
        Me.ButtonDonate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.TextBoxBy = New System.Windows.Forms.TextBox()
        Me.TextBoxVersion = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonOtherStuff
        '
        Me.ButtonOtherStuff.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonOtherStuff.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonOtherStuff.Location = New System.Drawing.Point(184, 168)
        Me.ButtonOtherStuff.Name = "ButtonOtherStuff"
        Me.ButtonOtherStuff.Size = New System.Drawing.Size(180, 23)
        Me.ButtonOtherStuff.TabIndex = 27
        Me.ButtonOtherStuff.Text = "Other Projects"
        Me.ButtonOtherStuff.UseVisualStyleBackColor = True
        '
        'ButtonDonate
        '
        Me.ButtonDonate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDonate.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonDonate.Location = New System.Drawing.Point(12, 170)
        Me.ButtonDonate.Name = "ButtonDonate"
        Me.ButtonDonate.Size = New System.Drawing.Size(166, 23)
        Me.ButtonDonate.TabIndex = 26
        Me.ButtonDonate.Text = "Donate!"
        Me.ButtonDonate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(181, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(181, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "By:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(181, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Version:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Program Name:"
        '
        'TextBoxDate
        '
        Me.TextBoxDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxDate.Location = New System.Drawing.Point(184, 142)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.ReadOnly = True
        Me.TextBoxDate.Size = New System.Drawing.Size(180, 21)
        Me.TextBoxDate.TabIndex = 21
        Me.TextBoxDate.Text = "March 2024"
        '
        'TextBoxBy
        '
        Me.TextBoxBy.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxBy.Location = New System.Drawing.Point(184, 103)
        Me.TextBoxBy.Name = "TextBoxBy"
        Me.TextBoxBy.ReadOnly = True
        Me.TextBoxBy.Size = New System.Drawing.Size(180, 21)
        Me.TextBoxBy.TabIndex = 20
        Me.TextBoxBy.Text = "Aidan Macgregor"
        '
        'TextBoxVersion
        '
        Me.TextBoxVersion.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxVersion.Location = New System.Drawing.Point(184, 64)
        Me.TextBoxVersion.Name = "TextBoxVersion"
        Me.TextBoxVersion.ReadOnly = True
        Me.TextBoxVersion.Size = New System.Drawing.Size(180, 21)
        Me.TextBoxVersion.TabIndex = 19
        Me.TextBoxVersion.Text = "1.0.0.3"
        '
        'TextBoxName
        '
        Me.TextBoxName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(184, 25)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.ReadOnly = True
        Me.TextBoxName.Size = New System.Drawing.Size(180, 21)
        Me.TextBoxName.TabIndex = 18
        Me.TextBoxName.Text = "Aidan's Fortnite XP+ Tool"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-17, -23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 185)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 212)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(221, 17)
        Me.CheckBox1.TabIndex = 28
        Me.CheckBox1.Text = "1.Launch Fortnite Into Festival Jam Mode"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(12, 235)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(287, 17)
        Me.CheckBox2.TabIndex = 29
        Me.CheckBox2.Text = "2. Find Quiet Place To Play (SOFDEEZ Upstairs Good) "
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(12, 258)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(286, 17)
        Me.CheckBox3.TabIndex = 30
        Me.CheckBox3.Text = "3. Run The Tool In Jam Mode (Untill Countdown Done)"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(12, 281)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(191, 17)
        Me.CheckBox4.TabIndex = 31
        Me.CheckBox4.Text = "4. Switch To Lego Mode (Creative)"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(12, 304)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(150, 17)
        Me.CheckBox5.TabIndex = 32
        Me.CheckBox5.Text = "5. Run Tool In Lego mode"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(12, 327)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(348, 17)
        Me.CheckBox8.TabIndex = 35
        Me.CheckBox8.Text = "6. After 3h 30m Profit! Gain About 10 Level Daily (Resets 2PM GMT)"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Instructions Tracker"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 350)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ButtonOtherStuff)
        Me.Controls.Add(Me.ButtonDonate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxDate)
        Me.Controls.Add(Me.TextBoxBy)
        Me.Controls.Add(Me.TextBoxVersion)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "About Box"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonOtherStuff As Button
    Friend WithEvents ButtonDonate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxDate As TextBox
    Friend WithEvents TextBoxBy As TextBox
    Friend WithEvents TextBoxVersion As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents Label5 As Label
End Class
