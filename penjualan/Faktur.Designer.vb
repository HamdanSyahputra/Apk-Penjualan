<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Faktur
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtDeskripsi = New System.Windows.Forms.TextBox()
        Me.txtKodePelanggan = New System.Windows.Forms.TextBox()
        Me.txtNoFaktur = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBersih = New System.Windows.Forms.Button()
        Me.dtpTglJual = New System.Windows.Forms.DateTimePicker()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(54, 321)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(614, 130)
        Me.ListView1.TabIndex = 67
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.Location = New System.Drawing.Point(201, 195)
        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.Size = New System.Drawing.Size(244, 20)
        Me.txtDeskripsi.TabIndex = 66
        '
        'txtKodePelanggan
        '
        Me.txtKodePelanggan.Location = New System.Drawing.Point(201, 117)
        Me.txtKodePelanggan.Name = "txtKodePelanggan"
        Me.txtKodePelanggan.Size = New System.Drawing.Size(154, 20)
        Me.txtKodePelanggan.TabIndex = 64
        '
        'txtNoFaktur
        '
        Me.txtNoFaktur.Location = New System.Drawing.Point(201, 72)
        Me.txtNoFaktur.Name = "txtNoFaktur"
        Me.txtNoFaktur.Size = New System.Drawing.Size(154, 20)
        Me.txtNoFaktur.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kalinga", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(50, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Deskripsi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kalinga", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(50, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Tanggal Jual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kalinga", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(50, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Kode Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kalinga", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(50, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Nomor Faktur" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raavi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(288, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 33)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Data Faktur" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Crimson
        Me.btnExit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(593, 472)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 33)
        Me.btnExit.TabIndex = 57
        Me.btnExit.Text = "keluar"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(54, 472)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 33)
        Me.btnDelete.TabIndex = 56
        Me.btnDelete.Text = "hapus"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Orange
        Me.btnEdit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(440, 472)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 33)
        Me.btnEdit.TabIndex = 55
        Me.btnEdit.Text = "edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.LawnGreen
        Me.btnSimpan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(153, 472)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 33)
        Me.btnSimpan.TabIndex = 54
        Me.btnSimpan.Text = "simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnBersih
        '
        Me.btnBersih.BackColor = System.Drawing.Color.MediumBlue
        Me.btnBersih.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBersih.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBersih.Location = New System.Drawing.Point(337, 472)
        Me.btnBersih.Name = "btnBersih"
        Me.btnBersih.Size = New System.Drawing.Size(75, 33)
        Me.btnBersih.TabIndex = 53
        Me.btnBersih.Text = "refresh"
        Me.btnBersih.UseVisualStyleBackColor = False
        '
        'dtpTglJual
        '
        Me.dtpTglJual.Font = New System.Drawing.Font("Kalinga", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglJual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTglJual.Location = New System.Drawing.Point(201, 155)
        Me.dtpTglJual.Name = "dtpTglJual"
        Me.dtpTglJual.Size = New System.Drawing.Size(179, 28)
        Me.dtpTglJual.TabIndex = 68
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.Crimson
        Me.btnCari.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCari.Location = New System.Drawing.Point(593, 278)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 37)
        Me.btnCari.TabIndex = 106
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Kristen ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(349, 278)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(225, 28)
        Me.txtCari.TabIndex = 105
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Kalinga", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(221, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Pencarian Data"
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 1
        Me.LineShape1.X2 = 697
        Me.LineShape1.Y1 = 47
        Me.LineShape1.Y2 = 44
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(699, 538)
        Me.ShapeContainer1.TabIndex = 107
        Me.ShapeContainer1.TabStop = False
        '
        'Faktur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(699, 538)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpTglJual)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtDeskripsi)
        Me.Controls.Add(Me.txtKodePelanggan)
        Me.Controls.Add(Me.txtNoFaktur)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBersih)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Faktur"
        Me.Text = "Faktur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents txtDeskripsi As System.Windows.Forms.TextBox
    Friend WithEvents txtKodePelanggan As System.Windows.Forms.TextBox
    Friend WithEvents txtNoFaktur As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBersih As System.Windows.Forms.Button
    Friend WithEvents dtpTglJual As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class
