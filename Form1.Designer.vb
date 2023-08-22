<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.Username = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.txtstudentname = New System.Windows.Forms.TextBox()
        Me.txtStudentnumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnVerify
        '
        Me.btnVerify.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerify.Location = New System.Drawing.Point(138, 255)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(120, 40)
        Me.btnVerify.TabIndex = 0
        Me.btnVerify.Text = "&Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(94, 116)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(105, 24)
        Me.Username.TabIndex = 1
        Me.Username.Text = "Username"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(97, 161)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(100, 24)
        Me.Password.TabIndex = 2
        Me.Password.Text = "Password"
        '
        'txtstudentname
        '
        Me.txtstudentname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudentname.Location = New System.Drawing.Point(220, 108)
        Me.txtstudentname.Name = "txtstudentname"
        Me.txtstudentname.Size = New System.Drawing.Size(145, 29)
        Me.txtstudentname.TabIndex = 3
        '
        'txtStudentnumber
        '
        Me.txtStudentnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentnumber.Location = New System.Drawing.Point(220, 146)
        Me.txtStudentnumber.Name = "txtStudentnumber"
        Me.txtStudentnumber.Size = New System.Drawing.Size(145, 29)
        Me.txtStudentnumber.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtStudentnumber)
        Me.Controls.Add(Me.txtstudentname)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.btnVerify)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVerify As Button
    Friend WithEvents Username As Label
    Friend WithEvents Password As Label
    Friend WithEvents txtstudentname As TextBox
    Friend WithEvents txtStudentnumber As TextBox
End Class
