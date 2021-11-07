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
        Me.btnRegisterStudent = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRegisterStudent
        '
        Me.btnRegisterStudent.Location = New System.Drawing.Point(12, 12)
        Me.btnRegisterStudent.Name = "btnRegisterStudent"
        Me.btnRegisterStudent.Size = New System.Drawing.Size(122, 31)
        Me.btnRegisterStudent.TabIndex = 0
        Me.btnRegisterStudent.Text = "Register Student"
        Me.btnRegisterStudent.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 364)
        Me.Controls.Add(Me.btnRegisterStudent)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRegisterStudent As Button
End Class
