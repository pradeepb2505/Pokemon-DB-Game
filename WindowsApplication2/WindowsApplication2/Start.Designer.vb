<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PokemonGOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PokemonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PokeCenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GymToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PokeStopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PokemonGOToolStripMenuItem, Me.GameToolStripMenuItem, Me.AboutUsToolStripMenuItem, Me.ContactUSToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(587, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PokemonGOToolStripMenuItem
        '
        Me.PokemonGOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PokemonToolStripMenuItem, Me.TrainerToolStripMenuItem, Me.PokeCenterToolStripMenuItem, Me.GymToolStripMenuItem, Me.PokeStopToolStripMenuItem})
        Me.PokemonGOToolStripMenuItem.Name = "PokemonGOToolStripMenuItem"
        Me.PokemonGOToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.PokemonGOToolStripMenuItem.Text = "Pokemon GO"
        '
        'PokemonToolStripMenuItem
        '
        Me.PokemonToolStripMenuItem.Name = "PokemonToolStripMenuItem"
        Me.PokemonToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.PokemonToolStripMenuItem.Text = "Pokemon"
        '
        'TrainerToolStripMenuItem
        '
        Me.TrainerToolStripMenuItem.Name = "TrainerToolStripMenuItem"
        Me.TrainerToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.TrainerToolStripMenuItem.Text = "Trainer"
        '
        'PokeCenterToolStripMenuItem
        '
        Me.PokeCenterToolStripMenuItem.Name = "PokeCenterToolStripMenuItem"
        Me.PokeCenterToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.PokeCenterToolStripMenuItem.Text = "Poke Center"
        '
        'GymToolStripMenuItem
        '
        Me.GymToolStripMenuItem.Name = "GymToolStripMenuItem"
        Me.GymToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.GymToolStripMenuItem.Text = "Gym"
        '
        'PokeStopToolStripMenuItem
        '
        Me.PokeStopToolStripMenuItem.Name = "PokeStopToolStripMenuItem"
        Me.PokeStopToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.PokeStopToolStripMenuItem.Text = "Poke-Stop"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoGameToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'GoGameToolStripMenuItem
        '
        Me.GoGameToolStripMenuItem.Name = "GoGameToolStripMenuItem"
        Me.GoGameToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.GoGameToolStripMenuItem.Text = "Go ! Game"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'ContactUSToolStripMenuItem
        '
        Me.ContactUSToolStripMenuItem.Name = "ContactUSToolStripMenuItem"
        Me.ContactUSToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ContactUSToolStripMenuItem.Text = "Contact US"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(587, 367)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Start"
        Me.Text = "Start"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PokemonGOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PokemonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrainerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PokeCenterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GymToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactUSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PokeStopToolStripMenuItem As ToolStripMenuItem
End Class
