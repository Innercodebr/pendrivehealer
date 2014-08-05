Imports System.IO
Imports IWshRuntimeLibrary

Public Class Form1
    Dim letra As String
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg.ToString = "537" Then ' DETECTA DISCOS AMOVIVEIS
            If (m.WParam.ToString = "32772") Or (m.WParam.ToString = "32768") Then ' 32772=EJECTAR   32768=INTRODUZIR
                Dim drives As System.Collections.ObjectModel.ReadOnlyCollection(Of IO.DriveInfo) = My.Computer.FileSystem.Drives
                Dim nome As String = String.Empty
                Dim temp As Integer = pendrives.SelectedIndex
                Dim temp1 As String = pendrives.Text
                pendrives.Items.Clear()
                pendrivessilent.Items.Clear()
                For i As Integer = 0 To drives.Count - 1

                    If (drives(i).IsReady AndAlso drives(i).DriveType = IO.DriveType.Removable) Then
                        nome = drives(i).VolumeLabel
                        pendrives.Items.Add(drives(i).Name & " (" & nome & ")")
                        pendrivessilent.Items.Add(drives(i).Name & " (" & nome & ")")
                    End If

                Next
                If pendrives.Items.Count < 1 Then
                    LIMPEZABT.Enabled = False
                    formatbutton.Enabled = False
                Else
                    LIMPEZABT.Enabled = True
                    formatbutton.Enabled = False
                End If
                If pendrives.Items.Count = 1 And autocleancheck.Checked = True Then
                    pendrives.SelectedItem = pendrives.Items.Item(0).ToString
                End If
                If pendrivessilent.Items.Count = 1 And autocleancheck.Checked = True Then
                    pendrivessilent.Text = pendrives.Items.Item(0).ToString
                End If

            End If
        Else
            MyBase.WndProc(m)
        End If

    End Sub

    Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim atalho_ = New IWshShell_Class
        escreve_log("iniciando Kaizonaro Pendrive Healer...", ToolTipIcon.Info)
        escreve_log("OBS.: o programa pode parar de responder durante a operação, mantenha a calma e aguarde...", ToolTipIcon.Info)
        If autocleancheck.Checked Then escreve_log("Aguardando Pendrive...", ToolTipIcon.Info)
        checkdrives()
        If Command().ToLower = "silent" Or Command().ToLower = "-silent" Then
            Me.Hide()
            Me.WindowState = FormWindowState.Minimized
            silentmodeicon.Visible = True
            escreve_log("Iniciando o modo silencioso...", ToolTipIcon.Info)
        ElseIf Command().ToLower = "" Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            silentmodeicon.Visible = False
        Else
            Me.Hide()
            Me.WindowState = FormWindowState.Minimized
            Dim letratemp As String = Command.Replace(":\", "")
            limpar(letratemp & ":\")
            End
        End If

    End Sub

    Private Sub limpar(pastadrive As String)
        log.Items.Clear()
        abasgerais.SelectedTab = LOGTAB
        letra = Path.GetPathRoot(pastadrive)
        escreve_log("Pendrive selecionado: " & letra, ToolTipIcon.Info)
        If letra = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.Windows)) Then
            escreve_log("Instalação do windows detectada! Anulando operação.", ToolTipIcon.Warning)
            escreve_log("Operação anulada, Consulte o arquivo '" & letra & "Pendrive_Healer_logs.txt' para detalhes da operação", ToolTipIcon.Info)
        Else
            escreve_log(" Aplicando Attrib... Recuperando pastas e arquivos..", ToolTipIcon.Info)
            Shell("cmd.exe /c attrib -h -r -s /s /d " & letra & "*.*", AppWinStyle.Hide)
            Try

                For Each arquivo As String In My.Computer.FileSystem.GetFiles(letra, FileIO.SearchOption.SearchAllSubDirectories, "*.lnk")
                    Try
                        System.IO.File.Delete(arquivo)
                        escreve_log(" Apagando " & arquivo, ToolTipIcon.Info)



                    Catch ex As Exception
                        escreve_log(ex.Message, ToolTipIcon.Error)


                    End Try
                Next
                If removerautoruncheck.Checked Then
                    For Each arquivo As String In My.Computer.FileSystem.GetFiles(letra, FileIO.SearchOption.SearchAllSubDirectories, "autorun.*")
                        Try
                            System.IO.File.Delete(arquivo)
                            escreve_log(" Apagando " & arquivo, ToolTipIcon.Info)

                        Catch ex As Exception
                            escreve_log(ex.Message, ToolTipIcon.Error)

                        End Try
                    Next
                End If

                For Each arquivo As String In My.Computer.FileSystem.GetFiles(letra, FileIO.SearchOption.SearchAllSubDirectories, "IndexerVolumeGuid")
                    Try
                        System.IO.File.Delete(arquivo)
                        escreve_log(" Apagando " & arquivo, ToolTipIcon.Info)

                    Catch ex As Exception
                        escreve_log(ex.Message, ToolTipIcon.Error)

                    End Try
                Next

                For Each arquivo As String In My.Computer.FileSystem.GetFiles(letra, FileIO.SearchOption.SearchAllSubDirectories, "IntroOfuscado.*")
                    Try
                        System.IO.File.Delete(arquivo)
                        escreve_log(" Apagando " & arquivo, ToolTipIcon.Info)

                    Catch ex As Exception
                        escreve_log(ex.Message, ToolTipIcon.Error)

                    End Try
                Next
                If removerpastacheck.Checked = True Then
                    For Each diretorio In Directory.GetDirectories(letra, "*.*", SearchOption.AllDirectories)
                        Try
                            Dim arquivos As String = Directory.GetFiles(diretorio).Length
                            Dim dirs As String = Directory.GetDirectories(diretorio).Length
                            If arquivos = 0 And dirs = 0 Then
                                Directory.Delete(diretorio, True)
                                escreve_log(" Apagando diretório vazio " & diretorio, ToolTipIcon.Info)
                            End If

                        Catch ex As Exception
                            escreve_log(ex.Message, ToolTipIcon.Error)

                        End Try
                    Next
                End If

            Catch ex As Exception
                escreve_log(ex.Message, ToolTipIcon.Error)
            End Try
            escreve_log("Abrindo Pendrive " & letra & "...", ToolTipIcon.Info)
            Shell("explorer " & letra, AppWinStyle.MaximizedFocus)
            Me.WindowState = FormWindowState.Minimized
            Me.Focus()
            escreve_log("Operação Concluida, Consulte o arquivo '" & letra & "Pendrive_Healer_logs.txt' para detalhes da operação", ToolTipIcon.Info)
            escritor(log)
        End If

    End Sub

    Private Sub pendrives_KeyDown(sender As Object, e As KeyEventArgs) Handles pendrivessilent.KeyDown
        If e.KeyCode = Keys.Enter Then limpar(sender.text)
    End Sub


    Sub escritor(listbox As ListBox)
        Try
            Dim escreve_logr_txt As New StreamWriter(letra & "Pendrive_Healer_logs.txt", True)
            For Each linha In listbox.Items
                escreve_logr_txt.WriteLine(linha)
            Next
            escreve_logr_txt.WriteLine(vbNewLine)
            escreve_logr_txt.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Source)
        End Try

    End Sub

    Private Sub pendrives_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pendrivessilent.SelectedIndexChanged
        limpar(sender.text)
    End Sub

    Sub escreve_log(ByVal texto As String, icone As ToolTipIcon)
        Me.Update()
        log.Items.Add(Date.Now.ToString & " - " & Environment.UserName & " - " & texto)
        action.Text = Date.Now.ToString & " - " & Environment.UserName & " - " & texto
        silentmodeicon.ShowBalloonTip(9000, "PENDRIVE HEALER", Date.Now.ToString & " " & texto, icone)
        log.SelectedIndex = log.Items.Count - 1
        Me.Update()
    End Sub

    Private Sub FacebookDoDesenvolvedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacebookDoDesenvolvedorToolStripMenuItem.Click
        Process.Start("http://facebook.com/kaizonaro")
    End Sub

    Private Sub silentmodeicon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles silentmodeicon.Click, silentbutton.Click
        If Me.Visible = True Then
            Me.Hide()
            autocleancheck.CheckState = CheckState.Checked
            silentmodeicon.Visible = True
            escreve_log("Iniciando Modo Silencioso, Inicio automático ativado...", ToolTipIcon.Info)
        Else
            ContextMenuStrip1.Show(MousePosition)
        End If
    End Sub

    Private Sub FecharPendriveHealerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharPendriveHealerToolStripMenuItem.Click
        End
    End Sub


    Sub checkdrives()
        Dim drives As System.Collections.ObjectModel.ReadOnlyCollection(Of IO.DriveInfo) = My.Computer.FileSystem.Drives
        Dim nome As String = String.Empty
        Dim temp As Integer = pendrives.SelectedIndex
        Dim temp1 As String = pendrives.Text
        pendrives.Items.Clear()
        For i As Integer = 0 To drives.Count - 1

            If (drives(i).IsReady AndAlso drives(i).DriveType = IO.DriveType.Removable) Then
                nome = drives(i).VolumeLabel
                pendrives.Items.Add(drives(i).Name & " (" & nome & ")")
                pendrivessilent.Items.Add(drives(i).Name & " (" & nome & ")")
            End If

        Next
        pendrives.Text = temp1
        pendrivessilent.Text = temp1
        If pendrives.Items.Count < 1 Then
            LIMPEZABT.Enabled = False
            formatbutton.Enabled = False
        Else
            LIMPEZABT.Enabled = True
            formatbutton.Enabled = False
        End If
    End Sub

    Private Sub silentmodeicon_BalloonTipClicked(sender As Object, e As EventArgs) Handles silentmodeicon.BalloonTipClicked, exibeform.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        silentmodeicon.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles LIMPEZABT.Click
        If pendrives.SelectedItem.ToString.Count < 1 Then pendrives.SelectedItem = pendrives.Items.Item(0)
        limpar(pendrives.SelectedItem.ToString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles formatbutton.Click
        log.Items.Clear()
        letra = Path.GetPathRoot(pendrives.Text)
        If MsgBox("Deseja realmente EXCLUIR TODOS OS ARQUIVOS do pendrive?" & vbNewLine & "Esta operação não pode ser desfeita!", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Limpar Pendrive! o.O") = MsgBoxResult.Yes Then

            For Each arquivo As String In My.Computer.FileSystem.GetFiles(letra, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                Try
                    escreve_log(" Apagando " & arquivo, ToolTipIcon.Info)
                    System.IO.File.Delete(arquivo)
                    escreve_log(arquivo & " Apagado", ToolTipIcon.Info)
                Catch ex As Exception
                    escreve_log(ex.Message, ToolTipIcon.Error)
                End Try
            Next
            For Each Diretorio In Directory.GetDirectories(letra, "*.*", SearchOption.TopDirectoryOnly)
                Try
                    escreve_log(" Apagando diretório " & Diretorio, ToolTipIcon.Info)
                    Directory.Delete(Diretorio, True)
                    escreve_log(Diretorio & " Apagado", ToolTipIcon.Info)
                Catch ex As Exception
                    escreve_log(ex.Message, ToolTipIcon.Error)
                End Try
            Next
            escreve_log("Operação Concluida, Consulte o arquivo '" & letra & "Pendrive_Healer_logs.txt' para detalhes da operação", ToolTipIcon.Info)
            escritor(log)
            Process.Start(Path.GetPathRoot(pendrives.Text))
        End If
    End Sub

    Private Sub autocleancheck_CheckedChanged(sender As Object, e As EventArgs) Handles autocleancheck.CheckedChanged
        If autocleancheck.Checked Then LIMPEZABT.Visible = False Else LIMPEZABT.Visible = True
    End Sub

    Private Sub pendrives_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles pendrives.MouseDoubleClick
        Process.Start(Path.GetPathRoot(pendrives.SelectedItem.ToString))
    End Sub

    Private Sub pendrives_MouseClick(sender As Object, e As MouseEventArgs) Handles pendrives.MouseClick
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Right
                checkdrives()
        End Select

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles silentshortbutton.Click
        MsgBox("Este assistente irá criar atalhos para o modo silencioso do Pendrive Healer. O Modo silencioso permite a execução do programa em segundo plano e a limpeza automatica ao plugar o pendrive.", MsgBoxStyle.Information, Me.Text)
        Dim WshShell As New IWshRuntimeLibrary.WshShell
        criaratalho(CType(WshShell.SpecialFolders.Item("Desktop"), String), "Modo Silencioso", "Permite iniciar o programa em modo silencioso", "-silent")
        criaratalho(CType(WshShell.SpecialFolders.Item("startmenu"), String), "Modo Silencioso", "Permite iniciar o programa em modo silencioso", "-silent")
    End Sub

    Private Sub assistentebt_Click(sender As Object, e As EventArgs)
        Dim WshShell As New IWshRuntimeLibrary.WshShell
        Process.Start(CType(WshShell.SpecialFolders.Item("Startup"), String))
    End Sub

    Sub criaratalho(local As String, nome As String, descricao As String, argumentos As String)
        If MsgBox("Deseja criar atalho em " & local & "?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            Try
                Dim WshShell As New IWshRuntimeLibrary.WshShell
                Dim atalho As IWshRuntimeLibrary.IWshShortcut
                ' o arquivo de atalho possui uma extensão .lnk
                atalho = CType(WshShell.CreateShortcut(local & "\PENDRIVE HEALER - " & nome & ".lnk"), IWshRuntimeLibrary.IWshShortcut)
                Dim processo = System.Reflection.Assembly.GetExecutingAssembly.Location()
                ' define as propriedades do atalho
                With atalho
                    .TargetPath = processo
                    .Arguments = argumentos
                    .Description = descricao
                    .WorkingDirectory = local
                    ' obtem o primeiro icon a partiro do programa executor
                    .IconLocation = processo & ", 0"
                    'salva o arquivo de atalho
                    .Save()
                End With
                'deu tudo certo
                escreve_log("Atalho: " & local & "\PENDRIVE HEALER - " & nome & ".lnk criados com sucesso", ToolTipIcon.Info)
            Catch ex As System.Exception
                escreve_log(ex.Message, ToolTipIcon.Error)
            End Try
        End If
    End Sub

    Private Sub specificclean_Click(sender As Object, e As EventArgs) Handles specificclean.Click
        Try
            Dim local As String = InputBox("Digite a letra do Pendrive que deseja executar a limpeza", "Especificar Pendrive", "X:\")
            If Not String.IsNullOrEmpty(local) Then limpar(local)
        Catch ex As Exception
            escreve_log(ex.Message, ToolTipIcon.Error)
        End Try
        
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles formatbuttonreal.Click
        Dim startInfo As New ProcessStartInfo()
        startInfo.FileName = "cmd"
        startInfo.Arguments = "format /fs:FAT /v:MyVolume /q " & log.SelectedItem.ToString.Remove(2)
        startInfo.UseShellExecute = False
        startInfo.CreateNoWindow = True
        startInfo.RedirectStandardOutput = True
        startInfo.RedirectStandardInput = True
        Dim p As Process = Process.Start(startInfo)
    End Sub
End Class
