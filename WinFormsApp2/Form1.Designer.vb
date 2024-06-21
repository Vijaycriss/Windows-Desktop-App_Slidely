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
        Me.Button1 = New Button()
        Me.Button2 = New Button()
        Me.SuspendLayout()
        ' 
        ' Button1
        ' 
        Me.Button1.Location = New Point(223, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New Size(269, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "View Submissions (CTRL + V)"
        Me.Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Me.Button2.Location = New Point(223, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New Size(269, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Create New Submission (CTRL + N)"
        Me.Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

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

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs)

        If e.Control AndAlso e.KeyCode = Keys.V Then
            Button1.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
        End If
    End Sub

End Class