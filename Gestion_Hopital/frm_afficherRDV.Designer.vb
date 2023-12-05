<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_afficherRDV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_afficherRDV))
        Me.DGV_RDV = New System.Windows.Forms.DataGridView()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateetHeure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGV_RDV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_RDV
        '
        Me.DGV_RDV.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DGV_RDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_RDV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code, Me.DateetHeure})
        Me.DGV_RDV.Location = New System.Drawing.Point(163, 171)
        Me.DGV_RDV.Name = "DGV_RDV"
        Me.DGV_RDV.RowHeadersWidth = 51
        Me.DGV_RDV.RowTemplate.Height = 24
        Me.DGV_RDV.Size = New System.Drawing.Size(481, 150)
        Me.DGV_RDV.TabIndex = 0
        '
        'Code
        '
        Me.Code.HeaderText = "Code"
        Me.Code.MinimumWidth = 6
        Me.Code.Name = "Code"
        Me.Code.Width = 125
        '
        'DateetHeure
        '
        Me.DateetHeure.HeaderText = "DateetHeure"
        Me.DateetHeure.MinimumWidth = 6
        Me.DateetHeure.Name = "DateetHeure"
        Me.DateetHeure.Width = 125
        '
        'btn_supprimer
        '
        Me.btn_supprimer.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimer.Location = New System.Drawing.Point(388, 362)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(137, 37)
        Me.btn_supprimer.TabIndex = 1
        Me.btn_supprimer.Text = "Supprimer🗑️"
        Me.btn_supprimer.UseVisualStyleBackColor = True
        '
        'btn_annuler
        '
        Me.btn_annuler.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(203, 362)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(113, 37)
        Me.btn_annuler.TabIndex = 2
        Me.btn_annuler.Text = "Annuler🗙"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(312, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 142)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frm_afficherRDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_supprimer)
        Me.Controls.Add(Me.DGV_RDV)
        Me.Name = "frm_afficherRDV"
        Me.Text = "frm_afficherRDV"
        CType(Me.DGV_RDV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_RDV As DataGridView
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents DateetHeure As DataGridViewTextBoxColumn
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents btn_annuler As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
