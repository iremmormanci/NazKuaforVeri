<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnaForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MüşteriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MüşteriİşlemleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonelİşlemleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RandevuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RandevuİşlemleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModelİşlemleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MüşteriToolStripMenuItem, Me.PersonelToolStripMenuItem, Me.RandevuToolStripMenuItem, Me.ModelToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(766, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MüşteriToolStripMenuItem
        '
        Me.MüşteriToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MüşteriİşlemleriToolStripMenuItem})
        Me.MüşteriToolStripMenuItem.Name = "MüşteriToolStripMenuItem"
        Me.MüşteriToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.MüşteriToolStripMenuItem.Text = "&Müşteri"
        '
        'MüşteriİşlemleriToolStripMenuItem
        '
        Me.MüşteriİşlemleriToolStripMenuItem.Name = "MüşteriİşlemleriToolStripMenuItem"
        Me.MüşteriİşlemleriToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.MüşteriİşlemleriToolStripMenuItem.Text = "Müşteri &İşlemleri"
        '
        'PersonelToolStripMenuItem
        '
        Me.PersonelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonelİşlemleriToolStripMenuItem})
        Me.PersonelToolStripMenuItem.Name = "PersonelToolStripMenuItem"
        Me.PersonelToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.PersonelToolStripMenuItem.Text = "&Personel"
        '
        'PersonelİşlemleriToolStripMenuItem
        '
        Me.PersonelİşlemleriToolStripMenuItem.Name = "PersonelİşlemleriToolStripMenuItem"
        Me.PersonelİşlemleriToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PersonelİşlemleriToolStripMenuItem.Text = "Personel &İşlemleri"
        '
        'RandevuToolStripMenuItem
        '
        Me.RandevuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RandevuİşlemleriToolStripMenuItem})
        Me.RandevuToolStripMenuItem.Name = "RandevuToolStripMenuItem"
        Me.RandevuToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.RandevuToolStripMenuItem.Text = "&Randevu "
        '
        'RandevuİşlemleriToolStripMenuItem
        '
        Me.RandevuİşlemleriToolStripMenuItem.Name = "RandevuİşlemleriToolStripMenuItem"
        Me.RandevuİşlemleriToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RandevuİşlemleriToolStripMenuItem.Text = "Randevu &İşlemleri"
        '
        'ModelToolStripMenuItem
        '
        Me.ModelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModelİşlemleriToolStripMenuItem})
        Me.ModelToolStripMenuItem.Name = "ModelToolStripMenuItem"
        Me.ModelToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.ModelToolStripMenuItem.Text = "&Model"
        '
        'ModelİşlemleriToolStripMenuItem
        '
        Me.ModelİşlemleriToolStripMenuItem.Name = "ModelİşlemleriToolStripMenuItem"
        Me.ModelİşlemleriToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ModelİşlemleriToolStripMenuItem.Text = "&Model İşlemleri"
        '
        'AnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.veriTabanıKuafor.My.Resources.Resources.istockphoto_1246328123_612x612
        Me.ClientSize = New System.Drawing.Size(766, 555)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AnaForm"
        Me.Text = "AnaForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MüşteriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MüşteriİşlemleriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonelİşlemleriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RandevuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RandevuİşlemleriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModelİşlemleriToolStripMenuItem As ToolStripMenuItem
End Class
