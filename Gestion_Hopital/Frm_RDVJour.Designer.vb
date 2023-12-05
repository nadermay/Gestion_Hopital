<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RDVJour
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RDVJour))
        Me.DGV_rdvJour = New System.Windows.Forms.DataGridView()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateRDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Annuler = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGV_rdvJour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_rdvJour
        '
        Me.DGV_rdvJour.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGV_rdvJour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_rdvJour.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code, Me.DateRDV})
        Me.DGV_rdvJour.Location = New System.Drawing.Point(180, 53)
        Me.DGV_rdvJour.Name = "DGV_rdvJour"
        Me.DGV_rdvJour.RowHeadersWidth = 51
        Me.DGV_rdvJour.RowTemplate.Height = 24
        Me.DGV_rdvJour.Size = New System.Drawing.Size(490, 292)
        Me.DGV_rdvJour.TabIndex = 0
        '
        'Code
        '
        Me.Code.HeaderText = "Code"
        Me.Code.MinimumWidth = 6
        Me.Code.Name = "Code"
        Me.Code.Width = 125
        '
        'DateRDV
        '
        Me.DateRDV.HeaderText = "DateRDV"
        Me.DateRDV.MinimumWidth = 6
        Me.DateRDV.Name = "DateRDV"
        Me.DateRDV.Width = 125
        '
        'btn_Annuler
        '
        Me.btn_Annuler.Location = New System.Drawing.Point(373, 366)
        Me.btn_Annuler.Name = "btn_Annuler"
        Me.btn_Annuler.Size = New System.Drawing.Size(116, 48)
        Me.btn_Annuler.TabIndex = 1
        Me.btn_Annuler.Text = "Annuler"
        Me.btn_Annuler.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(505, 252)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 93)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frm_RDVJour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(839, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_Annuler)
        Me.Controls.Add(Me.DGV_rdvJour)
        Me.Name = "frm_RDVJour"
        Me.Text = "Frm_RDVJour"
        CType(Me.DGV_rdvJour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_rdvJour As DataGridView
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents DateRDV As DataGridViewTextBoxColumn
    Friend WithEvents btn_Annuler As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
