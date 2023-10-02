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
        btnSayHi = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnSayHi
        ' 
        btnSayHi.BackColor = SystemColors.Window
        btnSayHi.BackgroundImageLayout = ImageLayout.Center
        btnSayHi.ForeColor = SystemColors.ControlText
        btnSayHi.Location = New Point(200, 159)
        btnSayHi.Name = "btnSayHi"
        btnSayHi.Size = New Size(397, 133)
        btnSayHi.TabIndex = 0
        btnSayHi.Text = "Say Hi!"
        btnSayHi.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Tw Cen MT", 22F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Info
        Label1.Location = New Point(200, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(381, 50)
        Label1.TabIndex = 1
        Label1.Text = "The greeting button!"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(btnSayHi)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSayHi As Button
    Friend WithEvents Label1 As Label
End Class
