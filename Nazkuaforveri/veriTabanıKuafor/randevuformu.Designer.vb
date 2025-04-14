<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class randevuformu
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.KAYDETBTN = New System.Windows.Forms.Button()
        Me.LİSTBTN = New System.Windows.Forms.Button()
        Me.GUNCELLEME = New System.Windows.Forms.Button()
        Me.SİLBTN = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ARABTN = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tcnotb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.KuaforVtDataSet1 = New veriTabanıKuafor.kuaforVtDataSet1()
        Me.KuaforVtDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RandevuTablosuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RandevuTablosuTableAdapter = New veriTabanıKuafor.kuaforVtDataSet1TableAdapters.RandevuTablosuTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KuaforVtDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KuaforVtDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RandevuTablosuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.veriTabanıKuafor.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(348, 322)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 228)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'KAYDETBTN
        '
        Me.KAYDETBTN.Location = New System.Drawing.Point(447, 2)
        Me.KAYDETBTN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.KAYDETBTN.Name = "KAYDETBTN"
        Me.KAYDETBTN.Size = New System.Drawing.Size(106, 43)
        Me.KAYDETBTN.TabIndex = 4
        Me.KAYDETBTN.Text = "KAYDET"
        Me.KAYDETBTN.UseVisualStyleBackColor = True
        '
        'LİSTBTN
        '
        Me.LİSTBTN.Location = New System.Drawing.Point(336, 2)
        Me.LİSTBTN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LİSTBTN.Name = "LİSTBTN"
        Me.LİSTBTN.Size = New System.Drawing.Size(105, 43)
        Me.LİSTBTN.TabIndex = 3
        Me.LİSTBTN.Text = "LİSTELE"
        Me.LİSTBTN.UseVisualStyleBackColor = True
        '
        'GUNCELLEME
        '
        Me.GUNCELLEME.Location = New System.Drawing.Point(225, 2)
        Me.GUNCELLEME.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GUNCELLEME.Name = "GUNCELLEME"
        Me.GUNCELLEME.Size = New System.Drawing.Size(105, 43)
        Me.GUNCELLEME.TabIndex = 2
        Me.GUNCELLEME.Text = "GÜNCELLE"
        Me.GUNCELLEME.UseVisualStyleBackColor = True
        '
        'SİLBTN
        '
        Me.SİLBTN.Location = New System.Drawing.Point(114, 2)
        Me.SİLBTN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SİLBTN.Name = "SİLBTN"
        Me.SİLBTN.Size = New System.Drawing.Size(105, 43)
        Me.SİLBTN.TabIndex = 1
        Me.SİLBTN.Text = "SİLME"
        Me.SİLBTN.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.KAYDETBTN, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LİSTBTN, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GUNCELLEME, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SİLBTN, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ARABTN, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 235)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(556, 49)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'ARABTN
        '
        Me.ARABTN.Location = New System.Drawing.Point(3, 2)
        Me.ARABTN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ARABTN.Name = "ARABTN"
        Me.ARABTN.Size = New System.Drawing.Size(105, 43)
        Me.ARABTN.TabIndex = 0
        Me.ARABTN.Text = "ARAMA"
        Me.ARABTN.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Tc Kimlik Numarası:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Randevu Saati:"
        '
        'tcnotb
        '
        Me.tcnotb.Location = New System.Drawing.Point(166, 448)
        Me.tcnotb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tcnotb.Name = "tcnotb"
        Me.tcnotb.Size = New System.Drawing.Size(145, 22)
        Me.tcnotb.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "RANDEVU LİSTESİ"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Honeydew
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 80)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(556, 127)
        Me.DataGridView1.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(135, 384)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 24
        '
        'KuaforVtDataSet1
        '
        Me.KuaforVtDataSet1.DataSetName = "kuaforVtDataSet1"
        Me.KuaforVtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KuaforVtDataSet1BindingSource
        '
        Me.KuaforVtDataSet1BindingSource.DataSource = Me.KuaforVtDataSet1
        Me.KuaforVtDataSet1BindingSource.Position = 0
        '
        'RandevuTablosuBindingSource
        '
        Me.RandevuTablosuBindingSource.DataMember = "RandevuTablosu"
        Me.RandevuTablosuBindingSource.DataSource = Me.KuaforVtDataSet1BindingSource
        '
        'RandevuTablosuTableAdapter
        '
        Me.RandevuTablosuTableAdapter.ClearBeforeFill = True
        '
        'randevuformu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(599, 593)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tcnotb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "randevuformu"
        Me.Text = "randevuformu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KuaforVtDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KuaforVtDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RandevuTablosuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents KAYDETBTN As Button
    Friend WithEvents LİSTBTN As Button
    Friend WithEvents GUNCELLEME As Button
    Friend WithEvents SİLBTN As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ARABTN As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tcnotb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents KuaforVtDataSet1BindingSource As BindingSource
    Friend WithEvents KuaforVtDataSet1 As kuaforVtDataSet1
    Friend WithEvents RandevuTablosuBindingSource As BindingSource
    Friend WithEvents RandevuTablosuTableAdapter As kuaforVtDataSet1TableAdapters.RandevuTablosuTableAdapter
End Class
