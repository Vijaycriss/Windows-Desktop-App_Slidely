<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class submit_google_form
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
        components = New ComponentModel.Container()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(304, 263)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(312, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(304, 194)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(312, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(304, 123)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(312, 27)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(304, 59)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(312, 27)
        TextBox4.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(164, 392)
        Button1.Name = "Button1"
        Button1.Size = New Size(389, 29)
        Button1.TabIndex = 4
        Button1.Text = "SUBMIT (CTRL + S)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(95, 324)
        Button2.Name = "Button2"
        Button2.Size = New Size(393, 29)
        Button2.TabIndex = 5
        Button2.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(538, 328)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 6
        Label1.Text = "00:00:00"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(173, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 7
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(164, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 8
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(176, 130)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 9
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(118, 270)
        Label5.Name = "Label5"
        Label5.Size = New Size(151, 20)
        Label5.TabIndex = 10
        Label5.Text = "Github Link For Task 2"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' submit_google_form
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "submit_google_form"
        Text = "submit google form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer

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
        AddHandler Timer1.Tick, AddressOf Timer1_Tick

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs)

        If e.Control AndAlso e.KeyCode = Keys.S Then
            Button1.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.T Then
            Button2.PerformClick()
        End If

    End Sub


End Class
