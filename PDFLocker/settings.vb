Public Class settings

    Private Sub settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        no.Text = My.Settings.passlen

        a.Checked = My.Settings.apha
        n.Checked = My.Settings.num

    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click

        If a.Checked = True And n.Checked = True Then

            My.Settings.apha = True
            My.Settings.num = True

        ElseIf a.Checked = False And n.Checked = True Then
            My.Settings.apha = False
            My.Settings.num = True

        ElseIf a.Checked = True And n.Checked = False Then
            My.Settings.apha = True
            My.Settings.num = False


        ElseIf a.Checked = False And n.Checked = False Then

            MessageBox.Show("You must select atleast one format to generate a password!", "Incorrect Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End If

        My.Settings.passlen = no.Text

        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        Me.Close()
    End Sub


    Private Sub saveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.MouseEnter
        save.BackColor = Color.FromArgb(80, 80, 80)
    End Sub
    Private Sub saveClik(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.MouseEnter
        cancel.BackColor = Color.FromArgb(80, 80, 80)
    End Sub

    Private Sub saveClck(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.MouseLeave
        save.BackColor = Color.FromArgb(33, 33, 33)
    End Sub
    Private Sub aveClik(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.MouseLeave
        cancel.BackColor = Color.FromArgb(33, 33, 33)
    End Sub

End Class