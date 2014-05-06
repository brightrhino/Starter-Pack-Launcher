<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DFDirList
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
        Me.VersionListBox = New System.Windows.Forms.ListView
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'VersionListBox
        '
        Me.VersionListBox.LabelWrap = False
        Me.VersionListBox.Location = New System.Drawing.Point(11, 52)
        Me.VersionListBox.MultiSelect = False
        Me.VersionListBox.Name = "VersionListBox"
        Me.VersionListBox.Size = New System.Drawing.Size(297, 115)
        Me.VersionListBox.TabIndex = 0
        Me.VersionListBox.UseCompatibleStateImageBehavior = False
        Me.VersionListBox.View = System.Windows.Forms.View.List
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Multiple Dwarf Fortress versions detected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Double click to select version" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DFDirList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 178)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VersionListBox)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(333, 196)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(333, 196)
        Me.Name = "DFDirList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VersionListBox As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
