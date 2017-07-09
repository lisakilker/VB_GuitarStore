Public Class frmGuitarStore

    Private Sub btnClassical_Click(sender As Object, e As EventArgs) Handles btnClassical.Click
        picClassical.Visible = True
        picSteelString.Visible = False
        picElectric.Visible = False
        btnPurchaseGuitar.Enabled = True

    End Sub

    Private Sub picSteelString_Click(sender As Object, e As EventArgs) Handles picSteelString.Click

    End Sub

    Private Sub btnSteelString_Click(sender As Object, e As EventArgs) Handles btnSteelString.Click
        picSteelString.Visible = True
        picClassical.Visible = False
        picElectric.Visible = False
        btnPurchaseGuitar.Enabled = True

    End Sub

    Private Sub btnElectric_Click(sender As Object, e As EventArgs) Handles btnElectric.Click
        picElectric.Visible = True
        picClassical.Visible = False
        picSteelString.Visible = False
        btnPurchaseGuitar.Enabled = True


    End Sub

    Private Sub btnPurchaseGuitar_Click(sender As Object, e As EventArgs) Handles btnPurchaseGuitar.Click
        lblEnjoyYourGuitar.Visible = True
        btnClassical.Enabled = False
        btnSteelString.Enabled = False
        btnElectric.Enabled = False
        btnPurchaseGuitar.Enabled = False
    End Sub

    Private Sub lblEnjoyYourGuitar_Click(sender As Object, e As EventArgs) Handles lblEnjoyYourGuitar.Click
        
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
