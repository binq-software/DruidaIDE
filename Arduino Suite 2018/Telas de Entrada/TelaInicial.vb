﻿Imports System.ComponentModel
Imports Druida_IDE_Lite
Imports System.Web
Imports System.Text

Public Class TelaInicial

    Public taskButtonRef As TaskButton

    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer

    Protected regionHandle As IntPtr

    Public Sub carregaVisualComponente(ByVal componente As Object)
        regionHandle = New IntPtr(CreateRoundRectRgn(0, 0, componente.Width, componente.Height, 30, 30))
        componente.Region = Region.FromHrgn(regionHandle)
        componente.Region.ReleaseHrgn(regionHandle)
    End Sub

    Private Sub TelaInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String = appIni & "\AppList.txt"
        Dim name As String = HttpUtility.UrlEncode(AppName, Encoding.GetEncoding(28597)).Replace("+", " ")
        MainCodeName = name.Replace(" ", "_")
        LoadPictures()
        SwitchProgrammingMethod()
        CabecalhoTelaInicial.Text = CabecalhoTelaInicial.Text & " <" & AppName & ">"
        DelegDeskIcons()
        carregaVisualComponente(Panel1)
        carregaVisualComponente(Panel2)
        'Gerenciador_de_Trechos_de_Código.CarregarCodigos()
    End Sub

    Private Sub DelegDeskIcons()
        Deleg(ÍconeProgramação, AddressOf OpenProgram)
        Deleg(ÍconeComando, AddressOf OpenComando)
        Deleg(ÍconeAlarmes, AddressOf OpenAlarmes)
        Deleg(ÍconeAbrirPasta, AddressOf openFolder)
        Deleg(ÍconeSair, AddressOf DruidaSuiteMain.PictureBoxSair_Click)
        Deleg(ÍconeHome, AddressOf HomePages)
        Deleg(ÍconeNovo, AddressOf DruidaSuiteMain.PictureBoxNova_Click)
        Deleg(ÍconeAbrir, AddressOf DruidaSuiteMain.PictureBoxAbrir_Click)
        Deleg(ÍconeSalvar, AddressOf DruidaSuiteMain.PictureBoxSalvar_Click)
        Deleg(ÍconeSalvarComo, AddressOf DruidaSuiteMain.PictureBox4_Click)
        'Deleg(ÍconeDruidaIDE, AddressOf TestarNovaIDE)
    End Sub

    Private Sub SwitchProgrammingMethod()
        LabelMaximize.Visible = appProgrammingMethod = "Avançado"
        LabelMin.Visible = appProgrammingMethod = "Avançado"
        DruidaSuiteMain.PanelTaskBar.Visible = appProgrammingMethod = "Avançado"
        'LabelInfo.Visible = appProgrammingMethod = "Avançado"
        'Label.Visible = appProgrammingMethod = "Avançado"
        ÍconeAbrirPasta.Visible = appProgrammingMethod = "Avançado"
        ÍconeProgramação.Visible = appProgrammingMethod = "Avançado"
        ÍconeComando.Visible = appProgrammingMethod = "Avançado"
        ÍconeAlarmes.Visible = appProgrammingMethod = "Avançado"
        DruidaSuiteMain.GroupBox1.Visible = appProgrammingMethod <> "Avançado"
        DruidaSuiteMain.GroupBox2.Visible = appProgrammingMethod <> "Avançado"
        If appProgrammingMethod = "Avançado" Then
            checkNumRegs()
        End If
        'If appProgrammingMethod = "Avançado" Then
        '    'If Not My.Computer.FileSystem.DirectoryExists(applicationDirectory & "\CustomSourceCode") Then
        '    '    SplashScreen.LabelStatusAbertura.Text = "Carregando Navegador..."
        '    '    SplashScreen.TopMost = False
        '    '    'If DialogNewCode.ShowDialog() = DialogResult.Cancel Then
        '    '    'SplashScreen.TopMost = True
        '    '    'Exit Sub
        '    '    'End If
        '    '    SplashScreen.LabelStatusAbertura.Text = "Carregando Interfaces..."
        '    '    SplashScreen.TopMost = True
        '    'End If
        '    SplashScreen.LabelStatusAbertura.Text = "Carregando Interfaces..."
        '    Cursor = Cursors.AppStarting
        '    Cursor = Cursors.Arrow
        'End If
    End Sub

    Private Sub LoadPictures()
        If System.IO.File.Exists(applicationDirectory & "\Logo 1.png") Then
            'PictureBoxLogo.Image = SafeImageFromFile(applicationDirectory & "\Logo 1.png")
        Else
            'PictureBoxLogo.Image = My.Resources.Logo_1
        End If
        If System.IO.File.Exists(applicationDirectory & "\Wallpaper.png") Then
            BackgroundImage = Image.FromFile(applicationDirectory & "\Wallpaper.png")
        Else
            BackgroundImage = Nothing
        End If
    End Sub

    Delegate Sub buttonAction(sender As Object, e As EventArgs)

    Private Sub Deleg(ByVal item As Ícone, ByVal metodo As buttonAction)
        AddHandler item.PictureBoxIcon.MouseClick, AddressOf metodo.Invoke
        AddHandler item.LabelNome.MouseClick, AddressOf metodo.Invoke
    End Sub

    Private Sub HomePages()
        Process.Start("https://binary-quantum.com")
    End Sub

    Public Sub OpenForm(ByRef formToOpen As Form)
        formToOpen.IsMdiContainer = False
        formToOpen.MdiParent = DruidaSuiteMain
        formToOpen.Show()
        formToOpen.Dock = DockStyle.Fill
        formToOpen.BringToFront()
    End Sub

    Private Sub openFolder(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start(applicationDirectory)
    End Sub

    Private Sub TestarNovaIDE()
        If Not My.Computer.FileSystem.DirectoryExists(applicationDirectory & "\CustomSourceCode") Then
            If DialogNewCode.ShowDialog() = DialogResult.Cancel Then
                Exit Sub
            End If
        End If
        'Cursor = Cursors.AppStarting
        'OpenForm(DruidaIDE)
        'Cursor = Cursors.Arrow
    End Sub

    Dim create As Boolean = True
    Private Sub OpenProgram(sender As Object, e As EventArgs)
        'If Not My.Computer.FileSystem.DirectoryExists(applicationDirectory & applicationCode & AppName) Then
        '    If DialogNewCode.ShowDialog() = DialogResult.Cancel Then
        '        Exit Sub
        '    End If
        'End If
        OpenDruida()
    End Sub

    Public Sub OpenDruida()
        If create Then
            DruidaInterface.Project.SetProjectName(AppName)
            DruidaInterface.InitializeDruidaOnPath(applicationDirectory & applicationCode & MainCodeName)
        End If
        DruidaInterface.DruidaIDE.Show()
        DruidaInterface.DruidaIDE.BringToFront()
        Cursor = Cursors.AppStarting
        Cursor = Cursors.Arrow
        If create Then
            AddHandler DruidaInterface.DruidaIDE.FormClosing, AddressOf CloseDruidaIDE
            taskButtonRef = DruidaSuiteMain.taskButtons(DruidaSuiteMain.windowsOpened)
            DruidaSuiteMain.windowsOpened += 1
            taskButtonRef.Show()
            taskButtonRef.PictureBoxItem.Image = My.Resources.scriptScreen
            taskButtonRef.SetForm(DruidaInterface.DruidaIDE)
            taskButtonRef.LabelNomeItem.Text = "Druida IDE Lite"
            create = False
        End If
    End Sub

    Public Sub CloseDruidaIDE()
        create = True
        If DruidaSuiteMain.windowsOpened > 0 Then
            DruidaSuiteMain.windowsOpened -= 1
        End If
        RemoveHandler DruidaInterface.DruidaIDE.FormClosing, AddressOf CloseDruidaIDE
        taskButtonRef.Hide()
    End Sub

    Public Sub OpenComando(sender As Object, e As EventArgs)
        If (My.Computer.FileSystem.FileExists(applicationDirectory & "\Comando\ListaTelas.list")) Then
            OpenForm(ComandoAvancado)
        Else
            Criar_Tela_de_Comando.ShowDialog()
        End If
    End Sub

    Private Sub OpenAlarmes(sender As Object, e As EventArgs)
        OpenForm(Alarmes)
    End Sub

    Private Sub OpenArduino(sender As Object, e As EventArgs)

    End Sub

    Private Sub TelaInicial_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        For Each icone In Controls
            If icone.GetType = GetType(Ícone) Then
                icone.DeselectMe
            End If
        Next
        DruidaSuiteMain.MenuInterativo.Hide()
    End Sub

    Private Sub TelaInicial_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
    End Sub

    Private Sub ÍconeAbrirPasta_Selected() Handles ÍconeAbrirPasta.Selected
        'LabelInfo.Text = "Abrir a pasta onde o projeto está localizado."
    End Sub

    Private Sub ÍconeProgramação_Selected() Handles ÍconeProgramação.Selected
        'LabelInfo.Text = "Abrir o Druida IDE, software de desenvolvimento dedicado para a programação de placas arduino, e derivadas."
    End Sub

    Private Sub ÍconeComando_Selected() Handles ÍconeComando.Selected
        'LabelInfo.Text = "Abrir o Druida SCADA Editor, software para o desenvolvimento SCADA, capaz de projetar interfaces de controle e monitoramento compatíveis com placas arduino, e derivadas."
    End Sub

    Private Sub ÍconeAlarmes_Selected() Handles ÍconeAlarmes.Selected
        'LabelInfo.Text = "Abrir o gerenciador de alarmes, software para criar uma fila de eventos a serem monitorados."
    End Sub

    Private Sub checkNumRegs()
        Dim filePath As String = applicationDirectory & "\CustomSourceCode\Main\Druida.ino"
        If System.IO.File.Exists(filePath) Then
            Dim linhas() As String = System.IO.File.ReadAllLines(filePath)
            For Each lin In linhas
                If lin.Contains("numRegs") And lin.Split(" ").Count >= 2 Then
                    If lin.Split(" ")(1) = ("numRegs") Then
                        If lin.Contains(vbTab) Then
                            numMaxRegs = lin.Split(" ")(2).Split(vbTab)(0)
                        Else
                            numMaxRegs = lin.Split(" ")(2)
                        End If
                    End If
                End If
            Next
        Else
            numMaxRegs = 10
        End If
    End Sub

    Private Sub LabelClose_Click(sender As Object, e As EventArgs) Handles LabelClose.Click
        DruidaSuiteMain.PictureBoxSair_Click(sender, e)
    End Sub

    Private Sub LabelClose_MouseEnter(sender As Object, e As EventArgs) Handles LabelClose.MouseEnter
        LabelClose.Image = Nothing
    End Sub

    Private Sub LabelClose_MouseLeave(sender As Object, e As EventArgs) Handles LabelClose.MouseLeave
        LabelClose.Image = My.Resources.TaskBar
    End Sub

    Private Sub LabelMaximize_MouseEnter(sender As Object, e As EventArgs) Handles LabelMaximize.MouseEnter
        LabelMaximize.Image = Nothing
    End Sub

    Private Sub LabelMaximize_MouseLeave(sender As Object, e As EventArgs) Handles LabelMaximize.MouseLeave
        LabelMaximize.Image = My.Resources.TaskBar
    End Sub

    Private Sub LabelMin_MouseEnter(sender As Object, e As EventArgs) Handles LabelMin.MouseEnter
        LabelMin.Image = Nothing
    End Sub

    Private Sub LabelMin_MouseLeave(sender As Object, e As EventArgs) Handles LabelMin.MouseLeave
        LabelMin.Image = My.Resources.TaskBar
    End Sub

    Private Sub LabelMaximize_Click(sender As Object, e As EventArgs) Handles LabelMaximize.Click
        If DruidaSuiteMain.FormBorderStyle = FormBorderStyle.None Then
            DruidaSuiteMain.FormBorderStyle = FormBorderStyle.Sizable
        Else
            DruidaSuiteMain.FormBorderStyle = FormBorderStyle.None
            DruidaSuiteMain.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub LabelMin_Click(sender As Object, e As EventArgs) Handles LabelMin.Click
        DruidaSuiteMain.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub AlterarLogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarLogoToolStripMenuItem.Click
        Dim openImage As New OpenFileDialog With {
            .Filter = "Imagens|*.png",
            .InitialDirectory = My.Application.Info.DirectoryPath & "\Imagens\",
            .Title = "Selecionar Logo Personalizada"
        }
        If (openImage.ShowDialog() = DialogResult.OK) Then
            System.IO.File.Copy(openImage.FileName, applicationDirectory & "\Logo 1.png", True)
            'PictureBoxLogo.Image = SafeImageFromFile(applicationDirectory & "\Logo 1.png")
        End If
    End Sub

    Public Shared Function SafeImageFromFile(path As String) As Image
        Using fs As New System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read)
            Dim img = Image.FromStream(fs)
            Return img
        End Using
    End Function

    Private Sub SobreDruidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreDruidaToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        AboutBinary.Show()
    End Sub

    'Private Sub WebViewAprendizado_ContentLoading(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebViewAprendizado.Navigated
    '    If WebViewAprendizado.Url.ToString <> "https://binary-quantum.com/aprendizado/" Then
    '        WebViewTelaPrincipal.Navigate(WebViewAprendizado.Url)
    '        WebViewAprendizado.Navigate("https://binary-quantum.com/aprendizado/")
    '    End If
    'End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        'carregaVisualComponente(Panel1)
    End Sub
End Class