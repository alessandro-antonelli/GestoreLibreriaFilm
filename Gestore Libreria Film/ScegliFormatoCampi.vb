Public Class ScegliFormatoCampi

    Private Sub ScegliFormatoCampi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SceltaStileAnteprima.SelectedIndex = 0
        ElencoCampi.SetItemChecked(0, True)
    End Sub

    Sub AggiornaCampiEsempio()
        '
        For Each elemento In ElencoCampi.CheckedItems
            '
        Next
    End Sub

    'Function GeneraDidascaliaNonTabellare(Film As Film)
    '
    'End Function

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ElencoCampi.SelectedIndexChanged
        Dim QualcosaSelezionato As Boolean = (ElencoCampi.SelectedIndices.Count > 0)
        GroupOpzioni.Visible = QualcosaSelezionato
        GroupOpzioniNoTabella.Visible = QualcosaSelezionato
        ButtSpostaSu.Enabled = QualcosaSelezionato
        ButtSpostaGiu.Enabled = QualcosaSelezionato
    End Sub

    Private Sub SceltaStileAnteprima_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SceltaStileAnteprima.SelectedIndexChanged
        Select Case SceltaStileAnteprima.SelectedIndex
            Case 0
                ElencoEsempio.View = View.LargeIcon
            Case 1
                ElencoEsempio.View = View.SmallIcon
            Case 2
                ElencoEsempio.View = View.List
            Case 3
                ElencoEsempio.View = View.Details
        End Select
    End Sub

    Private Sub ElencoCampi_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ElencoCampi.ItemCheck
        'Evita che si possano deselezionare tutti gli elementi
        If (ElencoCampi.CheckedItems.Count = 1 And e.CurrentValue = CheckState.Checked And e.NewValue = CheckState.Unchecked) Then
            e.NewValue = CheckState.Checked
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        NumericUpDown2.Enabled = CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        NumericUpDown1.Enabled = CheckBox2.Checked
    End Sub

    Private Sub ButtSpostaSu_Click(sender As Object, e As EventArgs) Handles ButtSpostaSu.Click
        Dim IndSel As UShort = ElencoCampi.SelectedIndex
        If (IndSel < 1) Then Exit Sub
        Dim ElemSel As String = ElencoCampi.SelectedItem
        ElencoCampi.Items.RemoveAt(IndSel)
        ElencoCampi.Items.Insert(IndSel - 1, ElemSel)
        ElencoCampi.SelectedIndex = IndSel - 1
    End Sub

    Private Sub ButtSpostaGiu_Click(sender As Object, e As EventArgs) Handles ButtSpostaGiu.Click
        Dim IndSel As UShort = ElencoCampi.SelectedIndex
        If (IndSel < 0 OrElse IndSel >= (ElencoCampi.Items.Count - 1)) Then Exit Sub
        Dim ElemSel As String = ElencoCampi.SelectedItem
        ElencoCampi.Items.RemoveAt(IndSel)
        ElencoCampi.Items.Insert(IndSel + 1, ElemSel)
        ElencoCampi.SelectedIndex = IndSel + 1
    End Sub
End Class