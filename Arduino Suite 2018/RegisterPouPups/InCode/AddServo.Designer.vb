﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddServo
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPorta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxRegister = New System.Windows.Forms.ComboBox()
        Me.CheckBoxCriar = New System.Windows.Forms.CheckBox()
        Me.GroupBoxAcionamento = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TextBoxDescrição = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBoxAcionamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(108, 254)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(82, 16)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(160, 20)
        Me.TextBoxNome.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pino:"
        '
        'TextBoxPorta
        '
        Me.TextBoxPorta.Location = New System.Drawing.Point(82, 46)
        Me.TextBoxPorta.Name = "TextBoxPorta"
        Me.TextBoxPorta.Size = New System.Drawing.Size(160, 20)
        Me.TextBoxPorta.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Registrador:"
        '
        'ComboBoxRegister
        '
        Me.ComboBoxRegister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRegister.FormattingEnabled = True
        Me.ComboBoxRegister.Location = New System.Drawing.Point(84, 157)
        Me.ComboBoxRegister.Name = "ComboBoxRegister"
        Me.ComboBoxRegister.Size = New System.Drawing.Size(160, 21)
        Me.ComboBoxRegister.TabIndex = 4
        '
        'CheckBoxCriar
        '
        Me.CheckBoxCriar.AutoSize = True
        Me.CheckBoxCriar.Location = New System.Drawing.Point(33, 129)
        Me.CheckBoxCriar.Name = "CheckBoxCriar"
        Me.CheckBoxCriar.Size = New System.Drawing.Size(201, 17)
        Me.CheckBoxCriar.TabIndex = 3
        Me.CheckBoxCriar.Text = "Criar Elemento na Tela de Comandos"
        Me.CheckBoxCriar.UseVisualStyleBackColor = True
        '
        'GroupBoxAcionamento
        '
        Me.GroupBoxAcionamento.Controls.Add(Me.RadioButton2)
        Me.GroupBoxAcionamento.Controls.Add(Me.RadioButton1)
        Me.GroupBoxAcionamento.Enabled = False
        Me.GroupBoxAcionamento.Location = New System.Drawing.Point(33, 196)
        Me.GroupBoxAcionamento.Name = "GroupBoxAcionamento"
        Me.GroupBoxAcionamento.Size = New System.Drawing.Size(196, 44)
        Me.GroupBoxAcionamento.TabIndex = 5
        Me.GroupBoxAcionamento.TabStop = False
        Me.GroupBoxAcionamento.Text = "Elemento Gráfico"
        Me.GroupBoxAcionamento.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(127, 17)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(57, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Escrita"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 17)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(57, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Leitura"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TextBoxDescrição
        '
        Me.TextBoxDescrição.Location = New System.Drawing.Point(82, 77)
        Me.TextBoxDescrição.Multiline = True
        Me.TextBoxDescrição.Name = "TextBoxDescrição"
        Me.TextBoxDescrição.Size = New System.Drawing.Size(160, 42)
        Me.TextBoxDescrição.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descrição:"
        '
        'AddServo
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(266, 295)
        Me.Controls.Add(Me.GroupBoxAcionamento)
        Me.Controls.Add(Me.CheckBoxCriar)
        Me.Controls.Add(Me.ComboBoxRegister)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxDescrição)
        Me.Controls.Add(Me.TextBoxPorta)
        Me.Controls.Add(Me.TextBoxNome)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddServo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adicionar Servo"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBoxAcionamento.ResumeLayout(False)
        Me.GroupBoxAcionamento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TextBoxNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPorta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxRegister As ComboBox
    Friend WithEvents CheckBoxCriar As CheckBox
    Friend WithEvents GroupBoxAcionamento As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBoxDescrição As TextBox
    Friend WithEvents Label4 As Label
End Class
