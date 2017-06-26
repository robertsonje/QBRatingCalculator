<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmQBCalculator
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents txtYds As System.Windows.Forms.TextBox
	Public WithEvents cmdCalculate As System.Windows.Forms.Button
	Public WithEvents txtInts As System.Windows.Forms.TextBox
	Public WithEvents txtTDs As System.Windows.Forms.TextBox
	Public WithEvents txtAtt As System.Windows.Forms.TextBox
	Public WithEvents lblQBRtng As System.Windows.Forms.Label
    Public WithEvents fraResults As System.Windows.Forms.GroupBox
    Public WithEvents txtComp As System.Windows.Forms.TextBox
    Public WithEvents txtQBName As System.Windows.Forms.TextBox
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents lblInts As System.Windows.Forms.Label
    Public WithEvents lblTDs As System.Windows.Forms.Label
    Public WithEvents lblYPA As System.Windows.Forms.Label
    Public WithEvents lblComp As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblPassersName As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtYds = New System.Windows.Forms.TextBox
        Me.cmdCalculate = New System.Windows.Forms.Button
        Me.txtInts = New System.Windows.Forms.TextBox
        Me.txtTDs = New System.Windows.Forms.TextBox
        Me.txtAtt = New System.Windows.Forms.TextBox
        Me.fraResults = New System.Windows.Forms.GroupBox
        Me.lblMessage = New System.Windows.Forms.Label
        Me.lblQBRtng = New System.Windows.Forms.Label
        Me.txtComp = New System.Windows.Forms.TextBox
        Me.txtQBName = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblInts = New System.Windows.Forms.Label
        Me.lblTDs = New System.Windows.Forms.Label
        Me.lblYPA = New System.Windows.Forms.Label
        Me.lblComp = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblPassersName = New System.Windows.Forms.Label
        Me.fraResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtYds
        '
        Me.txtYds.AcceptsReturn = True
        Me.txtYds.BackColor = System.Drawing.SystemColors.Window
        Me.txtYds.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYds.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYds.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtYds.Location = New System.Drawing.Point(152, 72)
        Me.txtYds.MaxLength = 0
        Me.txtYds.Name = "txtYds"
        Me.txtYds.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtYds.Size = New System.Drawing.Size(65, 20)
        Me.txtYds.TabIndex = 20
        '
        'cmdCalculate
        '
        Me.cmdCalculate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCalculate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCalculate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCalculate.Location = New System.Drawing.Point(165, 97)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCalculate.Size = New System.Drawing.Size(41, 24)
        Me.cmdCalculate.TabIndex = 11
        Me.cmdCalculate.Text = "Go!"
        Me.cmdCalculate.UseVisualStyleBackColor = False
        '
        'txtInts
        '
        Me.txtInts.AcceptsReturn = True
        Me.txtInts.BackColor = System.Drawing.SystemColors.Window
        Me.txtInts.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInts.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInts.ForeColor = System.Drawing.Color.Red
        Me.txtInts.Location = New System.Drawing.Point(296, 72)
        Me.txtInts.MaxLength = 0
        Me.txtInts.Name = "txtInts"
        Me.txtInts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInts.Size = New System.Drawing.Size(65, 20)
        Me.txtInts.TabIndex = 7
        '
        'txtTDs
        '
        Me.txtTDs.AcceptsReturn = True
        Me.txtTDs.BackColor = System.Drawing.SystemColors.Window
        Me.txtTDs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTDs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTDs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTDs.Location = New System.Drawing.Point(224, 72)
        Me.txtTDs.MaxLength = 0
        Me.txtTDs.Name = "txtTDs"
        Me.txtTDs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTDs.Size = New System.Drawing.Size(65, 20)
        Me.txtTDs.TabIndex = 6
        '
        'txtAtt
        '
        Me.txtAtt.AcceptsReturn = True
        Me.txtAtt.BackColor = System.Drawing.SystemColors.Window
        Me.txtAtt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAtt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAtt.Location = New System.Drawing.Point(80, 72)
        Me.txtAtt.MaxLength = 0
        Me.txtAtt.Name = "txtAtt"
        Me.txtAtt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAtt.Size = New System.Drawing.Size(65, 20)
        Me.txtAtt.TabIndex = 5
        '
        'fraResults
        '
        Me.fraResults.BackColor = System.Drawing.SystemColors.Control
        Me.fraResults.Controls.Add(Me.lblMessage)
        Me.fraResults.Controls.Add(Me.lblQBRtng)
        Me.fraResults.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraResults.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraResults.Location = New System.Drawing.Point(8, 192)
        Me.fraResults.Name = "fraResults"
        Me.fraResults.Padding = New System.Windows.Forms.Padding(0)
        Me.fraResults.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraResults.Size = New System.Drawing.Size(353, 105)
        Me.fraResults.TabIndex = 3
        Me.fraResults.TabStop = False
        Me.fraResults.Text = "Results"
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(4, 13)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(341, 23)
        Me.lblMessage.TabIndex = 23
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQBRtng
        '
        Me.lblQBRtng.BackColor = System.Drawing.SystemColors.Control
        Me.lblQBRtng.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblQBRtng.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQBRtng.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblQBRtng.Location = New System.Drawing.Point(8, 48)
        Me.lblQBRtng.Name = "lblQBRtng"
        Me.lblQBRtng.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQBRtng.Size = New System.Drawing.Size(337, 49)
        Me.lblQBRtng.TabIndex = 22
        Me.lblQBRtng.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtComp
        '
        Me.txtComp.AcceptsReturn = True
        Me.txtComp.BackColor = System.Drawing.SystemColors.Window
        Me.txtComp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtComp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtComp.Location = New System.Drawing.Point(8, 72)
        Me.txtComp.MaxLength = 0
        Me.txtComp.Name = "txtComp"
        Me.txtComp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtComp.Size = New System.Drawing.Size(65, 20)
        Me.txtComp.TabIndex = 2
        '
        'txtQBName
        '
        Me.txtQBName.AcceptsReturn = True
        Me.txtQBName.BackColor = System.Drawing.SystemColors.Window
        Me.txtQBName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQBName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQBName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtQBName.Location = New System.Drawing.Point(72, 8)
        Me.txtQBName.MaxLength = 0
        Me.txtQBName.Name = "txtQBName"
        Me.txtQBName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtQBName.Size = New System.Drawing.Size(225, 20)
        Me.txtQBName.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(152, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(65, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Yards"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(296, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "INT%"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(200, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "TD%"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(104, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "YPA"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "COMP%"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInts
        '
        Me.lblInts.BackColor = System.Drawing.SystemColors.Control
        Me.lblInts.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblInts.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInts.ForeColor = System.Drawing.Color.Red
        Me.lblInts.Location = New System.Drawing.Point(296, 168)
        Me.lblInts.Name = "lblInts"
        Me.lblInts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInts.Size = New System.Drawing.Size(65, 17)
        Me.lblInts.TabIndex = 15
        Me.lblInts.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTDs
        '
        Me.lblTDs.BackColor = System.Drawing.SystemColors.Control
        Me.lblTDs.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTDs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTDs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTDs.Location = New System.Drawing.Point(200, 168)
        Me.lblTDs.Name = "lblTDs"
        Me.lblTDs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTDs.Size = New System.Drawing.Size(65, 17)
        Me.lblTDs.TabIndex = 14
        Me.lblTDs.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblYPA
        '
        Me.lblYPA.BackColor = System.Drawing.SystemColors.Control
        Me.lblYPA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblYPA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYPA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblYPA.Location = New System.Drawing.Point(104, 168)
        Me.lblYPA.Name = "lblYPA"
        Me.lblYPA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblYPA.Size = New System.Drawing.Size(65, 17)
        Me.lblYPA.TabIndex = 13
        Me.lblYPA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblComp
        '
        Me.lblComp.BackColor = System.Drawing.SystemColors.Control
        Me.lblComp.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblComp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblComp.Location = New System.Drawing.Point(8, 168)
        Me.lblComp.Name = "lblComp"
        Me.lblComp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblComp.Size = New System.Drawing.Size(65, 17)
        Me.lblComp.TabIndex = 12
        Me.lblComp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(296, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Interceptions"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(224, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Touchdowns"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(80, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Attempts"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Completions"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPassersName
        '
        Me.lblPassersName.BackColor = System.Drawing.SystemColors.Control
        Me.lblPassersName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPassersName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassersName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPassersName.Location = New System.Drawing.Point(8, 8)
        Me.lblPassersName.Name = "lblPassersName"
        Me.lblPassersName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPassersName.Size = New System.Drawing.Size(57, 40)
        Me.lblPassersName.TabIndex = 1
        Me.lblPassersName.Text = "Passer's Name"
        Me.lblPassersName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmQBCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(366, 301)
        Me.Controls.Add(Me.txtYds)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.txtInts)
        Me.Controls.Add(Me.txtTDs)
        Me.Controls.Add(Me.txtAtt)
        Me.Controls.Add(Me.fraResults)
        Me.Controls.Add(Me.txtComp)
        Me.Controls.Add(Me.txtQBName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblInts)
        Me.Controls.Add(Me.lblTDs)
        Me.Controls.Add(Me.lblYPA)
        Me.Controls.Add(Me.lblComp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPassersName)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmQBCalculator"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Quarterback Rating Calculator"
        Me.fraResults.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
#End Region 
End Class