<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KanbanPrinting
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
        Me.components = New System.ComponentModel.Container()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnChangePrinter = New System.Windows.Forms.Button()
        Me.lblActivePrinter = New System.Windows.Forms.Label()
        Me.btnPrintBundle = New System.Windows.Forms.Button()
        Me.TextBundleLocation = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPrintOne = New System.Windows.Forms.Button()
        Me.TextLocation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextPN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.PrintingThread = New System.ComponentModel.BackgroundWorker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRealPrint = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PreviewingLbl = New System.Windows.Forms.Label()
        Me.BundlePrintingThread = New System.ComponentModel.BackgroundWorker()
        Me.PanelTitle.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'LabelTitle
        '
        Me.LabelTitle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelTitle.Font = New System.Drawing.Font("Georgia", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.White
        Me.LabelTitle.Location = New System.Drawing.Point(0, 0)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(1118, 100)
        Me.LabelTitle.TabIndex = 1
        Me.LabelTitle.Text = "Kanban Printing"
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelTitle
        '
        Me.PanelTitle.Controls.Add(Me.LabelTitle)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(1118, 100)
        Me.PanelTitle.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PreviewingLbl)
        Me.Panel1.Controls.Add(Me.btnChangePrinter)
        Me.Panel1.Controls.Add(Me.lblActivePrinter)
        Me.Panel1.Controls.Add(Me.btnPrintBundle)
        Me.Panel1.Controls.Add(Me.TextBundleLocation)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnPrintOne)
        Me.Panel1.Controls.Add(Me.TextLocation)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextPN)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 567)
        Me.Panel1.TabIndex = 4
        '
        'btnChangePrinter
        '
        Me.btnChangePrinter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnChangePrinter.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnChangePrinter.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePrinter.ForeColor = System.Drawing.Color.White
        Me.btnChangePrinter.Location = New System.Drawing.Point(337, 529)
        Me.btnChangePrinter.Name = "btnChangePrinter"
        Me.btnChangePrinter.Size = New System.Drawing.Size(130, 32)
        Me.btnChangePrinter.TabIndex = 18
        Me.btnChangePrinter.Text = "Change Printer"
        Me.btnChangePrinter.UseVisualStyleBackColor = False
        '
        'lblActivePrinter
        '
        Me.lblActivePrinter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblActivePrinter.AutoSize = True
        Me.lblActivePrinter.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivePrinter.Location = New System.Drawing.Point(11, 541)
        Me.lblActivePrinter.Name = "lblActivePrinter"
        Me.lblActivePrinter.Size = New System.Drawing.Size(118, 16)
        Me.lblActivePrinter.TabIndex = 17
        Me.lblActivePrinter.Text = "Active Printer: "
        '
        'btnPrintBundle
        '
        Me.btnPrintBundle.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPrintBundle.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintBundle.ForeColor = System.Drawing.Color.White
        Me.btnPrintBundle.Location = New System.Drawing.Point(194, 288)
        Me.btnPrintBundle.Name = "btnPrintBundle"
        Me.btnPrintBundle.Size = New System.Drawing.Size(177, 39)
        Me.btnPrintBundle.TabIndex = 12
        Me.btnPrintBundle.Text = "Preview Bundle"
        Me.btnPrintBundle.UseVisualStyleBackColor = False
        '
        'TextBundleLocation
        '
        Me.TextBundleLocation.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBundleLocation.Location = New System.Drawing.Point(194, 242)
        Me.TextBundleLocation.Name = "TextBundleLocation"
        Me.TextBundleLocation.Size = New System.Drawing.Size(177, 22)
        Me.TextBundleLocation.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Kanban Location:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(191, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Print a Bundle"
        '
        'btnPrintOne
        '
        Me.btnPrintOne.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPrintOne.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintOne.ForeColor = System.Drawing.Color.White
        Me.btnPrintOne.Location = New System.Drawing.Point(194, 137)
        Me.btnPrintOne.Name = "btnPrintOne"
        Me.btnPrintOne.Size = New System.Drawing.Size(177, 39)
        Me.btnPrintOne.TabIndex = 8
        Me.btnPrintOne.Text = "Preview"
        Me.btnPrintOne.UseVisualStyleBackColor = False
        '
        'TextLocation
        '
        Me.TextLocation.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLocation.Location = New System.Drawing.Point(194, 93)
        Me.TextLocation.Name = "TextLocation"
        Me.TextLocation.Size = New System.Drawing.Size(177, 22)
        Me.TextLocation.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Kanban Location:"
        '
        'TextPN
        '
        Me.TextPN.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPN.Location = New System.Drawing.Point(194, 62)
        Me.TextPN.Name = "TextPN"
        Me.TextPN.Size = New System.Drawing.Size(177, 22)
        Me.TextPN.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Part Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(191, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Print Single Card"
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(559, 100)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(559, 567)
        Me.PrintPreviewControl1.TabIndex = 5
        '
        'PrintingThread
        '
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnRealPrint)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(559, 630)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(559, 37)
        Me.Panel2.TabIndex = 6
        '
        'btnRealPrint
        '
        Me.btnRealPrint.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRealPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRealPrint.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRealPrint.ForeColor = System.Drawing.Color.White
        Me.btnRealPrint.Location = New System.Drawing.Point(0, 0)
        Me.btnRealPrint.Name = "btnRealPrint"
        Me.btnRealPrint.Size = New System.Drawing.Size(559, 37)
        Me.btnRealPrint.TabIndex = 19
        Me.btnRealPrint.Text = "Print Document"
        Me.btnRealPrint.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'PreviewingLbl
        '
        Me.PreviewingLbl.AutoSize = True
        Me.PreviewingLbl.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviewingLbl.Location = New System.Drawing.Point(201, 352)
        Me.PreviewingLbl.Name = "PreviewingLbl"
        Me.PreviewingLbl.Size = New System.Drawing.Size(0, 18)
        Me.PreviewingLbl.TabIndex = 19
        '
        'BundlePrintingThread
        '
        '
        'KanbanPrinting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 667)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTitle)
        Me.Name = "KanbanPrinting"
        Me.Text = "Kanban Printing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelTitle.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPrintBundle As Button
    Friend WithEvents TextBundleLocation As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPrintOne As Button
    Friend WithEvents TextLocation As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextPN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents lblActivePrinter As Label
    Friend WithEvents btnChangePrinter As Button
    Friend WithEvents PrintingThread As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRealPrint As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PreviewingLbl As Label
    Friend WithEvents BundlePrintingThread As System.ComponentModel.BackgroundWorker
End Class
