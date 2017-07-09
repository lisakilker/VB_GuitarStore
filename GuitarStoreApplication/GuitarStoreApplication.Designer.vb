<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuitarStore
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
        Me.btnClassical = New System.Windows.Forms.Button()
        Me.btnSteelString = New System.Windows.Forms.Button()
        Me.btnElectric = New System.Windows.Forms.Button()
        Me.btnPurchaseGuitar = New System.Windows.Forms.Button()
        Me.lblChooseAGuitar = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblClassicalAcoustic = New System.Windows.Forms.Label()
        Me.lblSteelStringAcoustic = New System.Windows.Forms.Label()
        Me.lblElectric = New System.Windows.Forms.Label()
        Me.lblEnjoyYourGuitar = New System.Windows.Forms.Label()
        Me.picElectric = New System.Windows.Forms.PictureBox()
        Me.picSteelString = New System.Windows.Forms.PictureBox()
        Me.picClassical = New System.Windows.Forms.PictureBox()
        CType(Me.picElectric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSteelString, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClassical, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClassical
        '
        Me.btnClassical.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassical.Location = New System.Drawing.Point(40, 252)
        Me.btnClassical.Name = "btnClassical"
        Me.btnClassical.Size = New System.Drawing.Size(75, 23)
        Me.btnClassical.TabIndex = 3
        Me.btnClassical.Text = "Select"
        Me.btnClassical.UseVisualStyleBackColor = True
        '
        'btnSteelString
        '
        Me.btnSteelString.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSteelString.Location = New System.Drawing.Point(203, 252)
        Me.btnSteelString.Name = "btnSteelString"
        Me.btnSteelString.Size = New System.Drawing.Size(75, 23)
        Me.btnSteelString.TabIndex = 4
        Me.btnSteelString.Text = "Select"
        Me.btnSteelString.UseVisualStyleBackColor = True
        '
        'btnElectric
        '
        Me.btnElectric.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElectric.Location = New System.Drawing.Point(366, 252)
        Me.btnElectric.Name = "btnElectric"
        Me.btnElectric.Size = New System.Drawing.Size(75, 23)
        Me.btnElectric.TabIndex = 5
        Me.btnElectric.Text = "Select"
        Me.btnElectric.UseVisualStyleBackColor = True
        '
        'btnPurchaseGuitar
        '
        Me.btnPurchaseGuitar.Enabled = False
        Me.btnPurchaseGuitar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchaseGuitar.Location = New System.Drawing.Point(178, 312)
        Me.btnPurchaseGuitar.Name = "btnPurchaseGuitar"
        Me.btnPurchaseGuitar.Size = New System.Drawing.Size(125, 37)
        Me.btnPurchaseGuitar.TabIndex = 6
        Me.btnPurchaseGuitar.Text = "Purchase"
        Me.btnPurchaseGuitar.UseVisualStyleBackColor = True
        '
        'lblChooseAGuitar
        '
        Me.lblChooseAGuitar.AutoSize = True
        Me.lblChooseAGuitar.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseAGuitar.Location = New System.Drawing.Point(16, 19)
        Me.lblChooseAGuitar.Name = "lblChooseAGuitar"
        Me.lblChooseAGuitar.Size = New System.Drawing.Size(166, 25)
        Me.lblChooseAGuitar.TabIndex = 7
        Me.lblChooseAGuitar.Text = "Select a Guitar"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(368, 410)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 34)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblClassicalAcoustic
        '
        Me.lblClassicalAcoustic.AutoSize = True
        Me.lblClassicalAcoustic.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassicalAcoustic.Location = New System.Drawing.Point(45, 94)
        Me.lblClassicalAcoustic.Name = "lblClassicalAcoustic"
        Me.lblClassicalAcoustic.Size = New System.Drawing.Size(64, 32)
        Me.lblClassicalAcoustic.TabIndex = 10
        Me.lblClassicalAcoustic.Text = "Classical" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Acoustic"
        Me.lblClassicalAcoustic.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSteelStringAcoustic
        '
        Me.lblSteelStringAcoustic.AutoSize = True
        Me.lblSteelStringAcoustic.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSteelStringAcoustic.Location = New System.Drawing.Point(197, 94)
        Me.lblSteelStringAcoustic.Name = "lblSteelStringAcoustic"
        Me.lblSteelStringAcoustic.Size = New System.Drawing.Size(86, 32)
        Me.lblSteelStringAcoustic.TabIndex = 11
        Me.lblSteelStringAcoustic.Text = "Steel-String" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Acoustic"
        Me.lblSteelStringAcoustic.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblElectric
        '
        Me.lblElectric.AutoSize = True
        Me.lblElectric.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElectric.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblElectric.Location = New System.Drawing.Point(376, 110)
        Me.lblElectric.Name = "lblElectric"
        Me.lblElectric.Size = New System.Drawing.Size(55, 16)
        Me.lblElectric.TabIndex = 12
        Me.lblElectric.Text = "Electric"
        Me.lblElectric.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEnjoyYourGuitar
        '
        Me.lblEnjoyYourGuitar.AutoSize = True
        Me.lblEnjoyYourGuitar.Location = New System.Drawing.Point(196, 366)
        Me.lblEnjoyYourGuitar.Name = "lblEnjoyYourGuitar"
        Me.lblEnjoyYourGuitar.Size = New System.Drawing.Size(88, 13)
        Me.lblEnjoyYourGuitar.TabIndex = 16
        Me.lblEnjoyYourGuitar.Text = "Enjoy your guitar!"
        Me.lblEnjoyYourGuitar.Visible = False
        '
        'picElectric
        '
        Me.picElectric.Image = Global.GuitarStoreApplication.My.Resources.Resources.Electric
        Me.picElectric.Location = New System.Drawing.Point(347, 134)
        Me.picElectric.Name = "picElectric"
        Me.picElectric.Size = New System.Drawing.Size(112, 110)
        Me.picElectric.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picElectric.TabIndex = 2
        Me.picElectric.TabStop = False
        Me.picElectric.Visible = False
        '
        'picSteelString
        '
        Me.picSteelString.Image = Global.GuitarStoreApplication.My.Resources.Resources.Steel
        Me.picSteelString.Location = New System.Drawing.Point(184, 134)
        Me.picSteelString.Name = "picSteelString"
        Me.picSteelString.Size = New System.Drawing.Size(112, 110)
        Me.picSteelString.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSteelString.TabIndex = 1
        Me.picSteelString.TabStop = False
        Me.picSteelString.Visible = False
        '
        'picClassical
        '
        Me.picClassical.Image = Global.GuitarStoreApplication.My.Resources.Resources.Classical
        Me.picClassical.Location = New System.Drawing.Point(21, 134)
        Me.picClassical.Name = "picClassical"
        Me.picClassical.Size = New System.Drawing.Size(112, 110)
        Me.picClassical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picClassical.TabIndex = 0
        Me.picClassical.TabStop = False
        Me.picClassical.Visible = False
        '
        'frmGuitarStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 456)
        Me.Controls.Add(Me.lblEnjoyYourGuitar)
        Me.Controls.Add(Me.lblElectric)
        Me.Controls.Add(Me.lblSteelStringAcoustic)
        Me.Controls.Add(Me.lblClassicalAcoustic)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblChooseAGuitar)
        Me.Controls.Add(Me.btnPurchaseGuitar)
        Me.Controls.Add(Me.btnElectric)
        Me.Controls.Add(Me.btnSteelString)
        Me.Controls.Add(Me.btnClassical)
        Me.Controls.Add(Me.picElectric)
        Me.Controls.Add(Me.picSteelString)
        Me.Controls.Add(Me.picClassical)
        Me.Name = "frmGuitarStore"
        Me.Text = "Guitar Store"
        CType(Me.picElectric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSteelString, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClassical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picClassical As System.Windows.Forms.PictureBox
    Friend WithEvents picSteelString As System.Windows.Forms.PictureBox
    Friend WithEvents picElectric As System.Windows.Forms.PictureBox
    Friend WithEvents btnClassical As System.Windows.Forms.Button
    Friend WithEvents btnSteelString As System.Windows.Forms.Button
    Friend WithEvents btnElectric As System.Windows.Forms.Button
    Friend WithEvents btnPurchaseGuitar As System.Windows.Forms.Button
    Friend WithEvents lblChooseAGuitar As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblClassicalAcoustic As System.Windows.Forms.Label
    Friend WithEvents lblSteelStringAcoustic As System.Windows.Forms.Label
    Friend WithEvents lblElectric As System.Windows.Forms.Label
    Friend WithEvents lblEnjoyYourGuitar As System.Windows.Forms.Label

End Class
