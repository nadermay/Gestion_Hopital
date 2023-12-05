<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_authentification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_authentification))
        Me.Login = New System.Windows.Forms.Label()
        Me.Mdp = New System.Windows.Forms.Label()
        Me.txt_utilisateur = New System.Windows.Forms.TextBox()
        Me.txt_mdp = New System.Windows.Forms.TextBox()
        Me.btn_connecter = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.AutoSize = True
        Me.Login.BackColor = System.Drawing.Color.Transparent
        Me.Login.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Login.Location = New System.Drawing.Point(350, 506)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(163, 26)
        Me.Login.TabIndex = 1
        Me.Login.Text = "Nom Utilisateur"
        '
        'Mdp
        '
        Me.Mdp.AutoSize = True
        Me.Mdp.BackColor = System.Drawing.Color.Transparent
        Me.Mdp.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mdp.Location = New System.Drawing.Point(350, 542)
        Me.Mdp.Name = "Mdp"
        Me.Mdp.Size = New System.Drawing.Size(138, 26)
        Me.Mdp.TabIndex = 2
        Me.Mdp.Text = "Mot de passe"
        '
        'txt_utilisateur
        '
        Me.txt_utilisateur.BackColor = System.Drawing.Color.Silver
        Me.txt_utilisateur.Location = New System.Drawing.Point(531, 509)
        Me.txt_utilisateur.Name = "txt_utilisateur"
        Me.txt_utilisateur.Size = New System.Drawing.Size(137, 22)
        Me.txt_utilisateur.TabIndex = 3
        '
        'txt_mdp
        '
        Me.txt_mdp.BackColor = System.Drawing.Color.Silver
        Me.txt_mdp.Location = New System.Drawing.Point(531, 546)
        Me.txt_mdp.Name = "txt_mdp"
        Me.txt_mdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_mdp.Size = New System.Drawing.Size(137, 22)
        Me.txt_mdp.TabIndex = 4
        '
        'btn_connecter
        '
        Me.btn_connecter.BackColor = System.Drawing.Color.Lime
        Me.btn_connecter.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_connecter.Location = New System.Drawing.Point(355, 587)
        Me.btn_connecter.Name = "btn_connecter"
        Me.btn_connecter.Size = New System.Drawing.Size(140, 40)
        Me.btn_connecter.TabIndex = 5
        Me.btn_connecter.Text = "Connecter"
        Me.btn_connecter.UseVisualStyleBackColor = False
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.Red
        Me.btn_annuler.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(531, 587)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(105, 40)
        Me.btn_annuler.TabIndex = 6
        Me.btn_annuler.Text = "annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(674, 493)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 105)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frm_authentification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1019, 697)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_connecter)
        Me.Controls.Add(Me.txt_mdp)
        Me.Controls.Add(Me.txt_utilisateur)
        Me.Controls.Add(Me.Mdp)
        Me.Controls.Add(Me.Login)
        Me.DoubleBuffered = True
        Me.Name = "frm_authentification"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Login As Label
    Friend WithEvents Mdp As Label
    Friend WithEvents txt_utilisateur As TextBox
    Friend WithEvents txt_mdp As TextBox
    Friend WithEvents btn_connecter As Button
    Friend WithEvents btn_annuler As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
