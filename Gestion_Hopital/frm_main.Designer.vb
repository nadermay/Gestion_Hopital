<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PatientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriseDeRDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RDVJourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RDVsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientsToolStripMenuItem, Me.RDVToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PatientsToolStripMenuItem
        '
        Me.PatientsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem, Me.AfficherToolStripMenuItem})
        Me.PatientsToolStripMenuItem.Name = "PatientsToolStripMenuItem"
        Me.PatientsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.PatientsToolStripMenuItem.Text = "Patients"
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.AjouterToolStripMenuItem.Text = "Ajouter"
        '
        'AfficherToolStripMenuItem
        '
        Me.AfficherToolStripMenuItem.Name = "AfficherToolStripMenuItem"
        Me.AfficherToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.AfficherToolStripMenuItem.Text = "Afficher"
        '
        'RDVToolStripMenuItem
        '
        Me.RDVToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PriseDeRDVToolStripMenuItem, Me.RDVJourToolStripMenuItem, Me.RDVsToolStripMenuItem})
        Me.RDVToolStripMenuItem.Name = "RDVToolStripMenuItem"
        Me.RDVToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.RDVToolStripMenuItem.Text = "RDV"
        '
        'PriseDeRDVToolStripMenuItem
        '
        Me.PriseDeRDVToolStripMenuItem.Name = "PriseDeRDVToolStripMenuItem"
        Me.PriseDeRDVToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.PriseDeRDVToolStripMenuItem.Text = "Prise de RDV"
        '
        'RDVJourToolStripMenuItem
        '
        Me.RDVJourToolStripMenuItem.Name = "RDVJourToolStripMenuItem"
        Me.RDVJourToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.RDVJourToolStripMenuItem.Text = "RDVJour"
        '
        'RDVsToolStripMenuItem
        '
        Me.RDVsToolStripMenuItem.Name = "RDVsToolStripMenuItem"
        Me.RDVsToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.RDVsToolStripMenuItem.Text = "RDVs"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 625)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_main"
        Me.Text = "frm_main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PatientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RDVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PriseDeRDVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RDVJourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RDVsToolStripMenuItem As ToolStripMenuItem
End Class
