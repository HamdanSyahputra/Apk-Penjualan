<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CariDataProduk
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
        Me.txtCariData = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtCariData
        '
        Me.txtCariData.Location = New System.Drawing.Point(368, 66)
        Me.txtCariData.Name = "txtCariData"
        Me.txtCariData.Size = New System.Drawing.Size(141, 20)
        Me.txtCariData.TabIndex = 60
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(517, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 37)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "cari"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kalinga", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(229, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Cari Data produk"
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(53, 100)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(539, 146)
        Me.ListView1.TabIndex = 57
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(374, 71)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 20)
        Me.TextBox1.TabIndex = 60
        '
        'CariDataProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(669, 274)
        Me.Controls.Add(Me.txtCariData)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "CariDataProduk"
        Me.Text = "Cari_Data_Produk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCariData As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
