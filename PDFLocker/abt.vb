Public Class abtbox

    Private Sub close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quit.Click
        Me.Close()
    End Sub


    Private Sub close_Cick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quit.MouseEnter
        quit.BackColor = Color.FromArgb(239, 154, 154)

    End Sub

    Private Sub clse_Cick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quit.MouseLeave
        quit.BackColor = Color.White

    End Sub

End Class