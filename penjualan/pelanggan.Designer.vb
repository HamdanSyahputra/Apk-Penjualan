<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pelanggan
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
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtNamaPelanggan = New System.Windows.Forms.TextBox()
        Me.txtKodePelanggan = New System.Windows.Forms.TextBox()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(41, 307)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(553, 126)
        Me.ListView1.TabIndex = 52
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(182, 173)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(177, 20)
        Me.txtTelepon.TabIndex = 51
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(184, 135)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(213, 20)
        Me.txtalamat.TabIndex = 50
        '
        'txtNamaPelanggan
        '
        Me.txtNamaPelanggan.Location = New System.Drawing.Point(184, 98)
        Me.txtNamaPelanggan.Name = "txtNamaPelanggan"
        Me.txtNamaPelanggan.Size = New System.Drawing.Size(194, 20)
        Me.txtNamaPelanggan.TabIndex = 49
        '
        'txtKodePelanggan
        '
        Me.txtKodePelanggan.Location = New System.Drawing.Point(184, 67)
        Me.txtKodePelanggan.Name = "txtKodePelanggan"
        Me.txtKodePelanggan.Size = New System.Drawing.Size(143, 20)
        Me.txtKodePelanggan.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kalinga", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(37, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Telepon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kalinga", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(37, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kalinga", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(37, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Nama Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kalinga", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(37, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Kode Pelanggan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raavi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(232, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 33)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Data Pelanggan"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Crimson
        Me.btnExit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(511, 451)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 33)
        Me.btnExit.TabIndex = 42
        Me.btnExit.Text = "keluar"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(41, 451)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 33)
        Me.btnDelete.TabIndex = 41
        Me.btnDelete.Text = "hapus"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Orange
        Me.btnEdit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEdit.Location = New System.Drawing.Point(388, 451)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 33)
        Me.btnEdit.TabIndex = 40
        Me.btnEdit.Text = "edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.LawnGreen
        Me.btnSimpan.Location = New System.Drawing.Point(139, 451)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 33)
        Me.btnSimpan.TabIndex = 39
        Me.btnSimpan.Text = "simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnBersih
        '
        Me.btnBersih.BackColor = System.Drawing.Color.MediumBlue
        Me.btnBersih.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBersih.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBersih.Location = New System.Drawing.Point(284, 451)
        Me.btnBersih.Name = "btnBersih"
        Me.btnBersih.Size = New System.Drawing.Size(75, 33)
        Me.btnBersih.TabIndex = 38
        Me.btnBersih.Text = "refresh"
        Me.btnBersih.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Kalinga", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(161, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 20)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Pencarian Data"
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Kristen ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(284, 269)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(198, 28)
        Me.txtCari.TabIndex = 82
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.Crimson
        Me.btnCari.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCari.Location = New System.Drawing.Point(520, 269)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(66, 34)
        Me.btnCari.TabIndex = 83
        Me.btnCari.Text = "cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(628, 509)
        Me.ShapeContainer1.TabIndex = 84
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 1
        Me.LineShape1.X2 = 632
        Me.LineShape1.Y1 = 42
        Me.LineShape1.Y2 = 39
        '
        'Pelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(628, 509)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtTelepon)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtNamaPelanggan)
        Me.Controls.Add(Me.txtKodePelanggan)
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
        Me.Name = "Pelanggan"
        Me.Text = "Pelanggan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents txtTelepon As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents txtKodePelanggan As System.Windows.Forms.TextBox
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
