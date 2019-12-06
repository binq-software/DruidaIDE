﻿Public Class hardwareNANO
    Private configs() As String = {"Desativada", "Entrada", "Entrada PullUp", "Saída"}
    Public file As New GerenciamentoHardware(applicationDirectory & "\CustomSourceCode\Main\Pinout.cfg")

    Private Sub hardwareNANO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AssignConfigTypes()
        AssignControlsList()
        file.Load()
    End Sub

    Private Sub AssignControlsList()
        file.SetTextBoxList(SplitContainer2.Panel1.Controls)
        file.SetComboBoxList(SplitContainer2.Panel2.Controls)
    End Sub

    Private Sub AssignConfigTypes()
        For Each control In SplitContainer2.Panel2.Controls
            If control.GetType() = GetType(ComboBox) Then
                control.Items.Clear()
                control.Items.AddRange(configs)
                control.SelectedIndex = 0
            End If
        Next
    End Sub
End Class
