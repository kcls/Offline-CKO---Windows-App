<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_no_card
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_no_card))
        Me.btnDone = New System.Windows.Forms.Button()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.txtPatronName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDone
        '
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(188, 527)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(372, 114)
        Me.btnDone.TabIndex = 17
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(19, 364)
        Me.txtNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(712, 152)
        Me.txtNotes.TabIndex = 16
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(19, 319)
        Me.lblNotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(415, 20)
        Me.lblNotes.TabIndex = 15
        Me.lblNotes.Text = "Notes/DIBs  (Any extra info needed to look up this patron)"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(19, 262)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(272, 33)
        Me.txtPhone.TabIndex = 14
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(19, 238)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(119, 20)
        Me.lblPhone.TabIndex = 13
        Me.lblPhone.Text = "Phone Number:"
        '
        'txtDOB
        '
        Me.txtDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOB.Location = New System.Drawing.Point(19, 165)
        Me.txtDOB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(272, 33)
        Me.txtDOB.TabIndex = 12
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(19, 127)
        Me.lblDOB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(313, 20)
        Me.lblDOB.TabIndex = 11
        Me.lblDOB.Text = "Birthdate : (Month-Day-Year) - REQUIRED"
        '
        'txtPatronName
        '
        Me.txtPatronName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatronName.Location = New System.Drawing.Point(19, 55)
        Me.txtPatronName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPatronName.Name = "txtPatronName"
        Me.txtPatronName.Size = New System.Drawing.Size(712, 33)
        Me.txtPatronName.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Patron Name (Last, First Middle) - REQUIRED"
        '
        'form_no_card
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 657)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.txtPatronName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_no_card"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "No Card - Enter Patron Info"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDone As Button
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents lblDOB As Label
    Friend WithEvents txtPatronName As TextBox
    Friend WithEvents Label1 As Label
End Class
