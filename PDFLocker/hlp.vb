Public Class hs

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Try
            Process.Start("https://www.facebook.com/rvnd.balaji")
        Catch ex As Exception
            MessageBox.Show("Oops! Something's wrong" & vbNewLine & "Err : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        Try
            Process.Start("https://www.fiverr.com/users/rvndbalaji")
        Catch ex As Exception
            MessageBox.Show("Oops! Something's wrong" & vbNewLine & "Err : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
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