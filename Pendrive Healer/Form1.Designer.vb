<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.silentmodeicon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FacebookDoDesenvolvedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pendrivessilent = New System.Windows.Forms.ToolStripComboBox()
        Me.exibeform = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharPendriveHealerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.removerpastacheck = New System.Windows.Forms.CheckBox()
        Me.silentbutton = New System.Windows.Forms.Button()
        Me.removerautoruncheck = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LIMPEZABT = New System.Windows.Forms.Button()
        Me.autocleancheck = New System.Windows.Forms.CheckBox()
        Me.formatbutton = New System.Windows.Forms.Button()
        Me.silentshortbutton = New System.Windows.Forms.Button()
        Me.specificclean = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.abasgerais = New System.Windows.Forms.TabControl()
        Me.TOOLSTAB = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pendrives = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.formatbuttonreal = New System.Windows.Forms.Button()
        Me.barrastatus = New System.Windows.Forms.StatusStrip()
        Me.barraprogresso = New System.Windows.Forms.ToolStripProgressBar()
        Me.action = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LOGTAB = New System.Windows.Forms.TabPage()
        Me.log = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.abasgerais.SuspendLayout()
        Me.TOOLSTAB.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.barrastatus.SuspendLayout()
        Me.LOGTAB.SuspendLayout()
        Me.SuspendLayout()
        '
        'silentmodeicon
        '
        Me.silentmodeicon.ContextMenuStrip = Me.ContextMenuStrip1
        Me.silentmodeicon.Icon = CType(resources.GetObject("silentmodeicon.Icon"), System.Drawing.Icon)
        Me.silentmodeicon.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacebookDoDesenvolvedorToolStripMenuItem, Me.UToolStripMenuItem, Me.exibeform, Me.FecharPendriveHealerToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(224, 92)
        '
        'FacebookDoDesenvolvedorToolStripMenuItem
        '
        Me.FacebookDoDesenvolvedorToolStripMenuItem.Name = "FacebookDoDesenvolvedorToolStripMenuItem"
        Me.FacebookDoDesenvolvedorToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.FacebookDoDesenvolvedorToolStripMenuItem.Text = "Facebook do Desenvolvedor"
        '
        'UToolStripMenuItem
        '
        Me.UToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pendrivessilent})
        Me.UToolStripMenuItem.Name = "UToolStripMenuItem"
        Me.UToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.UToolStripMenuItem.Text = "Executar limpeza"
        '
        'pendrivessilent
        '
        Me.pendrivessilent.Name = "pendrivessilent"
        Me.pendrivessilent.Size = New System.Drawing.Size(121, 23)
        Me.pendrivessilent.Text = "Selecione o pendrive..."
        '
        'exibeform
        '
        Me.exibeform.Name = "exibeform"
        Me.exibeform.Size = New System.Drawing.Size(223, 22)
        Me.exibeform.Text = "Exibir Janela Principal"
        '
        'FecharPendriveHealerToolStripMenuItem
        '
        Me.FecharPendriveHealerToolStripMenuItem.Name = "FecharPendriveHealerToolStripMenuItem"
        Me.FecharPendriveHealerToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.FecharPendriveHealerToolStripMenuItem.Text = "Fechar Pendrive Healer"
        '
        'removerpastacheck
        '
        Me.removerpastacheck.AutoSize = True
        Me.removerpastacheck.Checked = True
        Me.removerpastacheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.removerpastacheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removerpastacheck.ForeColor = System.Drawing.Color.Black
        Me.removerpastacheck.Location = New System.Drawing.Point(6, 19)
        Me.removerpastacheck.Name = "removerpastacheck"
        Me.removerpastacheck.Size = New System.Drawing.Size(207, 22)
        Me.removerpastacheck.TabIndex = 3
        Me.removerpastacheck.Text = "Remover Pastas Vazias"
        Me.removerpastacheck.UseVisualStyleBackColor = True
        '
        'silentbutton
        '
        Me.silentbutton.Location = New System.Drawing.Point(787, 6)
        Me.silentbutton.Name = "silentbutton"
        Me.silentbutton.Size = New System.Drawing.Size(115, 55)
        Me.silentbutton.TabIndex = 4
        Me.silentbutton.Text = "Iniciar o Modo Silencioso"
        Me.ToolTip1.SetToolTip(Me.silentbutton, "O modo silencioso esconde a janela atual e executa a recuperação automatica dos d" & _
        "ados imediatamente ao plugar o pendrive." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.silentbutton.UseVisualStyleBackColor = True
        '
        'removerautoruncheck
        '
        Me.removerautoruncheck.AutoSize = True
        Me.removerautoruncheck.Checked = True
        Me.removerautoruncheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.removerautoruncheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removerautoruncheck.ForeColor = System.Drawing.Color.Black
        Me.removerautoruncheck.Location = New System.Drawing.Point(6, 45)
        Me.removerautoruncheck.Name = "removerautoruncheck"
        Me.removerautoruncheck.Size = New System.Drawing.Size(158, 22)
        Me.removerautoruncheck.TabIndex = 3
        Me.removerautoruncheck.Text = "Remover Autorun"
        Me.ToolTip1.SetToolTip(Me.removerautoruncheck, "recome todos os arquivos com o nome  AUTORUN")
        Me.removerautoruncheck.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'LIMPEZABT
        '
        Me.LIMPEZABT.Location = New System.Drawing.Point(225, 19)
        Me.LIMPEZABT.Name = "LIMPEZABT"
        Me.LIMPEZABT.Size = New System.Drawing.Size(138, 36)
        Me.LIMPEZABT.TabIndex = 6
        Me.LIMPEZABT.Text = "Recuperar"
        Me.ToolTip1.SetToolTip(Me.LIMPEZABT, "Clique aqui para recuperar as pastas escondidas e excluir os atalhos formados no " & _
        "seu pendreive")
        Me.LIMPEZABT.UseVisualStyleBackColor = True
        '
        'autocleancheck
        '
        Me.autocleancheck.AutoSize = True
        Me.autocleancheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.autocleancheck.ForeColor = System.Drawing.Color.Black
        Me.autocleancheck.Location = New System.Drawing.Point(6, 73)
        Me.autocleancheck.Name = "autocleancheck"
        Me.autocleancheck.Size = New System.Drawing.Size(207, 22)
        Me.autocleancheck.TabIndex = 3
        Me.autocleancheck.Text = "Iniciar Automaticamente"
        Me.ToolTip1.SetToolTip(Me.autocleancheck, "inicia a recuperação imediatamente ao plugar o pendrive")
        Me.autocleancheck.UseVisualStyleBackColor = True
        '
        'formatbutton
        '
        Me.formatbutton.Location = New System.Drawing.Point(6, 19)
        Me.formatbutton.Name = "formatbutton"
        Me.formatbutton.Size = New System.Drawing.Size(183, 44)
        Me.formatbutton.TabIndex = 6
        Me.formatbutton.Text = "Apagar todos os arquivos"
        Me.ToolTip1.SetToolTip(Me.formatbutton, "Este procedimento pode ser irreversivel, tenha cuidado ao apagar todos os dados d" & _
        "o seu pendrive!")
        Me.formatbutton.UseVisualStyleBackColor = True
        '
        'silentshortbutton
        '
        Me.silentshortbutton.Location = New System.Drawing.Point(592, 6)
        Me.silentshortbutton.Name = "silentshortbutton"
        Me.silentshortbutton.Size = New System.Drawing.Size(189, 55)
        Me.silentshortbutton.TabIndex = 11
        Me.silentshortbutton.Text = "Assistente para criação de atalhos para o Modo Silencioso"
        Me.ToolTip1.SetToolTip(Me.silentshortbutton, "Cria atalhos em locais diversos do PC para executar o modo silencioso")
        Me.silentshortbutton.UseVisualStyleBackColor = True
        '
        'specificclean
        '
        Me.specificclean.Location = New System.Drawing.Point(6, 101)
        Me.specificclean.Name = "specificclean"
        Me.specificclean.Size = New System.Drawing.Size(357, 23)
        Me.specificclean.TabIndex = 12
        Me.specificclean.Text = "Limpar Pendrives Especificos/ HDs Externos"
        Me.ToolTip1.SetToolTip(Me.specificclean, resources.GetString("specificclean.ToolTip"))
        Me.specificclean.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.specificclean)
        Me.GroupBox1.Controls.Add(Me.removerpastacheck)
        Me.GroupBox1.Controls.Add(Me.LIMPEZABT)
        Me.GroupBox1.Controls.Add(Me.autocleancheck)
        Me.GroupBox1.Controls.Add(Me.removerautoruncheck)
        Me.GroupBox1.Location = New System.Drawing.Point(217, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 131)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RECUPERAÇÃO DE PASTAS ESCONDIDAS"
        '
        'abasgerais
        '
        Me.abasgerais.Controls.Add(Me.TOOLSTAB)
        Me.abasgerais.Controls.Add(Me.LOGTAB)
        Me.abasgerais.Dock = System.Windows.Forms.DockStyle.Fill
        Me.abasgerais.Location = New System.Drawing.Point(0, 0)
        Me.abasgerais.Name = "abasgerais"
        Me.abasgerais.SelectedIndex = 0
        Me.abasgerais.Size = New System.Drawing.Size(919, 196)
        Me.abasgerais.TabIndex = 7
        '
        'TOOLSTAB
        '
        Me.TOOLSTAB.Controls.Add(Me.silentshortbutton)
        Me.TOOLSTAB.Controls.Add(Me.GroupBox3)
        Me.TOOLSTAB.Controls.Add(Me.GroupBox2)
        Me.TOOLSTAB.Controls.Add(Me.barrastatus)
        Me.TOOLSTAB.Controls.Add(Me.GroupBox1)
        Me.TOOLSTAB.Controls.Add(Me.silentbutton)
        Me.TOOLSTAB.Location = New System.Drawing.Point(4, 22)
        Me.TOOLSTAB.Name = "TOOLSTAB"
        Me.TOOLSTAB.Padding = New System.Windows.Forms.Padding(3)
        Me.TOOLSTAB.Size = New System.Drawing.Size(911, 170)
        Me.TOOLSTAB.TabIndex = 0
        Me.TOOLSTAB.Text = "FERRAMENTAS"
        Me.TOOLSTAB.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.pendrives)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(203, 134)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PENDRIVE"
        '
        'pendrives
        '
        Me.pendrives.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pendrives.FormattingEnabled = True
        Me.pendrives.Location = New System.Drawing.Point(3, 16)
        Me.pendrives.Name = "pendrives"
        Me.pendrives.Size = New System.Drawing.Size(197, 115)
        Me.pendrives.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.formatbuttonreal)
        Me.GroupBox2.Controls.Add(Me.formatbutton)
        Me.GroupBox2.Location = New System.Drawing.Point(592, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 73)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LIMPEZA TOTAL"
        '
        'formatbuttonreal
        '
        Me.formatbuttonreal.Enabled = False
        Me.formatbuttonreal.Location = New System.Drawing.Point(195, 19)
        Me.formatbuttonreal.Name = "formatbuttonreal"
        Me.formatbuttonreal.Size = New System.Drawing.Size(109, 44)
        Me.formatbuttonreal.TabIndex = 7
        Me.formatbuttonreal.Text = "Formatar"
        Me.ToolTip1.SetToolTip(Me.formatbuttonreal, "em breve...")
        Me.formatbuttonreal.UseVisualStyleBackColor = True
        '
        'barrastatus
        '
        Me.barrastatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.barraprogresso, Me.action})
        Me.barrastatus.Location = New System.Drawing.Point(3, 145)
        Me.barrastatus.Name = "barrastatus"
        Me.barrastatus.Size = New System.Drawing.Size(905, 22)
        Me.barrastatus.TabIndex = 7
        Me.barrastatus.Text = "StatusStrip1"
        '
        'barraprogresso
        '
        Me.barraprogresso.Name = "barraprogresso"
        Me.barraprogresso.Size = New System.Drawing.Size(100, 16)
        '
        'action
        '
        Me.action.Name = "action"
        Me.action.Size = New System.Drawing.Size(70, 17)
        Me.action.Text = "Ultima ação"
        '
        'LOGTAB
        '
        Me.LOGTAB.Controls.Add(Me.log)
        Me.LOGTAB.Location = New System.Drawing.Point(4, 22)
        Me.LOGTAB.Name = "LOGTAB"
        Me.LOGTAB.Padding = New System.Windows.Forms.Padding(3)
        Me.LOGTAB.Size = New System.Drawing.Size(911, 170)
        Me.LOGTAB.TabIndex = 1
        Me.LOGTAB.Text = "LOG - DETALHES DA OPERAÇÃO"
        Me.LOGTAB.UseVisualStyleBackColor = True
        '
        'log
        '
        Me.log.BackColor = System.Drawing.Color.White
        Me.log.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.log.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log.ForeColor = System.Drawing.Color.Black
        Me.log.FormattingEnabled = True
        Me.log.HorizontalScrollbar = True
        Me.log.ItemHeight = 17
        Me.log.Location = New System.Drawing.Point(3, 3)
        Me.log.Name = "log"
        Me.log.Size = New System.Drawing.Size(905, 164)
        Me.log.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(919, 196)
        Me.Controls.Add(Me.abasgerais)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kaizonaro Pendrive Healer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.abasgerais.ResumeLayout(False)
        Me.TOOLSTAB.ResumeLayout(False)
        Me.TOOLSTAB.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.barrastatus.ResumeLayout(False)
        Me.barrastatus.PerformLayout()
        Me.LOGTAB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents silentmodeicon As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FecharPendriveHealerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacebookDoDesenvolvedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exibeform As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pendrivessilent As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents removerpastacheck As System.Windows.Forms.CheckBox
    Friend WithEvents silentbutton As System.Windows.Forms.Button
    Friend WithEvents removerautoruncheck As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents formatbutton As System.Windows.Forms.Button
    Friend WithEvents LIMPEZABT As System.Windows.Forms.Button
    Friend WithEvents autocleancheck As System.Windows.Forms.CheckBox
    Friend WithEvents abasgerais As System.Windows.Forms.TabControl
    Friend WithEvents TOOLSTAB As System.Windows.Forms.TabPage
    Friend WithEvents LOGTAB As System.Windows.Forms.TabPage
    Friend WithEvents log As System.Windows.Forms.ListBox
    Friend WithEvents barrastatus As System.Windows.Forms.StatusStrip
    Friend WithEvents action As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents barraprogresso As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents pendrives As System.Windows.Forms.ListBox
    Friend WithEvents silentshortbutton As System.Windows.Forms.Button
    Friend WithEvents specificclean As System.Windows.Forms.Button
    Friend WithEvents formatbuttonreal As System.Windows.Forms.Button

End Class
