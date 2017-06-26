Option Strict Off
Option Explicit On
Friend Class frmQBCalculator
	Inherits System.Windows.Forms.Form
    Dim Comp, Att, Yds, TDs, Ints
    Dim CompPct, YPA, TDPct, IntPct
    Dim QBRtng
    Dim C, Y, T, I
    Dim QBName
    Private Function Min(ByVal ParamArray values() As Object) As Object
        Dim i As Short
        Dim min_value As Object
        min_value = values(LBound(values))
        For i = LBound(values) + 1 To UBound(values)
            If min_value > values(i) Then min_value = values(i)
        Next i
        Min = min_value
    End Function
    Private Function Max(ByVal ParamArray values() As Object) As Object
        Dim i As Short
        Dim max_value As Object
        max_value = values(LBound(values))
        For i = LBound(values) + 1 To UBound(values)
            If max_value < values(i) Then max_value = values(i)
        Next i
        Max = max_value
    End Function

	
	Private Sub cmdCalculate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalculate.Click

        Comp = Val(txtComp.Text)
        Att = Val(txtAtt.Text)
        Yds = Val(txtYds.Text)
        TDs = Val(txtTDs.Text)
        Ints = Val(txtInts.Text)
        QBName = txtQBName.Text

        CompPct = CDbl((Comp / Att) * 100)
        TDPct = CDbl(VB6.Format(TDs / Att))
        IntPct = CDbl(VB6.Format(Ints / Att))
        YPA = CDbl(VB6.Format(Yds / Att))

        C = (CompPct - 30) / 20
        Y = (YPA - 3) * 0.25
        T = TDPct * 20
        I = 2.375 - (IntPct * 25)

        QBRtng = ((Max(Min(C, 2.375), 0) + Max(Min(Y, 2.375), 0) + Max(Min(T, 2.375), 0) + Max(Min(I, 2.375), 0)) / 6) * 100

        lblComp.Text = VB6.Format(Comp / Att, "##.#%")
        lblYPA.Text = VB6.Format(Yds / Att, "##.#")
        lblTDs.Text = VB6.Format(TDs / Att, "##.######%")
        lblInts.Text = VB6.Format(Ints / Att, "##.######")
        lblQBRtng.Text = VB6.Format(QBRtng, "##.#")

        If QBRtng >= 158.3 Then
            lblMessage.Text = QBName + " has a PERFECT PASSER RATING!!!"
        ElseIf QBRtng >= 120 Then
            lblMessage.Text = "Wow, " + QBName + " is an excellent passer!"
        ElseIf QBRtng >= 95 Then
            lblMessage.Text = QBName + " is a great passer."
        ElseIf QBRtng >= 70 Then
            lblMessage.Text = "Well, " + QBName + " is a good passer."
        ElseIf QBRtng < 70 Then
            lblMessage.Text = QBName + " needs more practice."
        End If

    End Sub

End Class

