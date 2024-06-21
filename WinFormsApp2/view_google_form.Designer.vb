<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_google_form
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox6 = New TextBox()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(48, 373)
        Button1.Name = "Button1"
        Button1.Size = New Size(171, 29)
        Button1.TabIndex = 0
        Button1.Text = "Previous(CTRL + P)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(556, 373)
        Button2.Name = "Button2"
        Button2.Size = New Size(173, 29)
        Button2.TabIndex = 1
        Button2.Text = "Next(CTRL + N)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(338, 256)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(271, 27)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(338, 195)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(271, 27)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(338, 132)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(271, 27)
        TextBox3.TabIndex = 4
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(338, 71)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(271, 27)
        TextBox4.TabIndex = 5
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(338, 311)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(271, 27)
        TextBox5.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(170, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 7
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(170, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 8
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(157, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 9
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(136, 263)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 20)
        Label4.TabIndex = 10
        Label4.Text = "Github Link for task 2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(148, 318)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 20)
        Label5.TabIndex = 11
        Label5.Text = "StopWatch time"
        ' 
        ' TextBox6
        ' 
        TextBox6.AutoCompleteMode = AutoCompleteMode.Suggest
        TextBox6.Location = New Point(439, 12)
        TextBox6.Name = "TextBox6"
        TextBox6.PlaceholderText = "search here using email"
        TextBox6.Size = New Size(207, 27)
        TextBox6.TabIndex = 12
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(652, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(77, 29)
        Button3.TabIndex = 13
        Button3.Text = "search"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(325, 373)
        Button4.Name = "Button4"
        Button4.Size = New Size(109, 29)
        Button4.TabIndex = 14
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' view_google_form
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(TextBox6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "view_google_form"
        Text = "view google form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

    'Constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'Add KeyDown event handler for the form
        AddHandler Me.KeyDown, AddressOf Form1_KeyDown

        Me.KeyPreview = True

        'Add Click event handler for the buttons
        AddHandler Button1.Click, AddressOf Button1_Click
        AddHandler Button2.Click, AddressOf Button2_Click
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs)

        If e.Control AndAlso e.KeyCode = Keys.P Then
            Button1.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
        End If
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
