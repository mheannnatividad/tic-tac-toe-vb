Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim turnPoint As Boolean = True

    Private Sub clickButton1_Click(sender As Object, e As EventArgs) Handles clickButton1.Click
        If turnPoint = True Then
            clickButton1.Text = "X"
            turnPoint = False
        Else
            clickButton1.Text = "O"
            turnPoint = True
        End If

        If clickButton1.Text = "X" And clickButton2.Text = "X" And clickButton3.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton4.Text = "X" And clickButton5.Text = "X" And clickButton6.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton7.Text = "X" And clickButton8.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton4.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton2.Text = "X" And clickButton5.Text = "X" And clickButton8.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton6.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton5.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton5.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        End If

        If clickButton1.Text = "O" And clickButton2.Text = "O" And clickButton3.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton4.Text = "O" And clickButton5.Text = "O" And clickButton6.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton7.Text = "O" And clickButton8.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton4.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton2.Text = "O" And clickButton5.Text = "O" And clickButton8.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton6.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton5.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton5.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        End If

        clickButton1.Enabled = False
    End Sub

    Private Sub clickButton2_Click(sender As Object, e As EventArgs) Handles clickButton2.Click
        If turnPoint = True Then
            clickButton2.Text = "X"
            turnPoint = False
        Else
            clickButton2.Text = "O"
            turnPoint = True
        End If

        If clickButton1.Text = "X" And clickButton2.Text = "X" And clickButton3.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton4.Text = "X" And clickButton5.Text = "X" And clickButton6.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton7.Text = "X" And clickButton8.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton4.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton2.Text = "X" And clickButton5.Text = "X" And clickButton8.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton6.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton5.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton5.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        End If

        If clickButton1.Text = "O" And clickButton2.Text = "O" And clickButton3.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton4.Text = "O" And clickButton5.Text = "O" And clickButton6.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton7.Text = "O" And clickButton8.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton4.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton2.Text = "O" And clickButton5.Text = "O" And clickButton8.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton6.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton5.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton5.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        End If

        clickButton2.Enabled = False
    End Sub

    Private Sub clickButton3_Click(sender As Object, e As EventArgs) Handles clickButton3.Click
        If turnPoint = True Then
            clickButton3.Text = "X"
            turnPoint = False
        Else
            clickButton3.Text = "O"
            turnPoint = True
        End If

        If clickButton1.Text = "X" And clickButton2.Text = "X" And clickButton3.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton4.Text = "X" And clickButton5.Text = "X" And clickButton6.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton7.Text = "X" And clickButton8.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton4.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton2.Text = "X" And clickButton5.Text = "X" And clickButton8.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton6.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton5.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton5.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        End If

        If clickButton1.Text = "O" And clickButton2.Text = "O" And clickButton3.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton4.Text = "O" And clickButton5.Text = "O" And clickButton6.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton7.Text = "O" And clickButton8.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton4.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton2.Text = "O" And clickButton5.Text = "O" And clickButton8.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton6.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton5.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton5.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        End If

        clickButton3.Enabled = False
    End Sub

    Private Sub clickButton4_Click(sender As Object, e As EventArgs) Handles clickButton4.Click
        If turnPoint = True Then
            clickButton4.Text = "X"
            turnPoint = False
        Else
            clickButton4.Text = "O"
            turnPoint = True
        End If

        If clickButton1.Text = "X" And clickButton2.Text = "X" And clickButton3.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton4.Text = "X" And clickButton5.Text = "X" And clickButton6.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton7.Text = "X" And clickButton8.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton4.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton2.Text = "X" And clickButton5.Text = "X" And clickButton8.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton6.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton5.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton5.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        End If

        If clickButton1.Text = "O" And clickButton2.Text = "O" And clickButton3.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton4.Text = "O" And clickButton5.Text = "O" And clickButton6.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton7.Text = "O" And clickButton8.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton4.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton2.Text = "O" And clickButton5.Text = "O" And clickButton8.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton6.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton5.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton5.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        End If

        clickButton4.Enabled = False
    End Sub

    Private Sub clickButton5_Click(sender As Object, e As EventArgs) Handles clickButton5.Click
        If turnPoint = True Then
            clickButton5.Text = "X"
            turnPoint = False
        Else
            clickButton5.Text = "O"
            turnPoint = True
        End If

        If clickButton1.Text = "X" And clickButton2.Text = "X" And clickButton3.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton4.Text = "X" And clickButton5.Text = "X" And clickButton6.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton7.Text = "X" And clickButton8.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton4.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton2.Text = "X" And clickButton5.Text = "X" And clickButton8.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton6.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton5.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton5.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        End If

        If clickButton1.Text = "O" And clickButton2.Text = "O" And clickButton3.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton4.Text = "O" And clickButton5.Text = "O" And clickButton6.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton7.Text = "O" And clickButton8.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton4.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton2.Text = "O" And clickButton5.Text = "O" And clickButton8.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton6.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton5.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton5.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        End If

        clickButton5.Enabled = False
    End Sub

    Private Sub clickButton6_Click(sender As Object, e As EventArgs) Handles clickButton6.Click
        If turnPoint = True Then
            clickButton6.Text = "X"
            turnPoint = False
        Else
            clickButton6.Text = "O"
            turnPoint = True
        End If

        If clickButton1.Text = "X" And clickButton2.Text = "X" And clickButton3.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton4.Text = "X" And clickButton5.Text = "X" And clickButton6.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton7.Text = "X" And clickButton8.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton4.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton2.Text = "X" And clickButton5.Text = "X" And clickButton8.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton6.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton5.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton5.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        End If

        If clickButton1.Text = "O" And clickButton2.Text = "O" And clickButton3.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton4.Text = "O" And clickButton5.Text = "O" And clickButton6.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton7.Text = "O" And clickButton8.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton4.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton2.Text = "O" And clickButton5.Text = "O" And clickButton8.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton6.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton5.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton5.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        End If

        clickButton6.Enabled = False
    End Sub

    Private Sub clickButton7_Click(sender As Object, e As EventArgs) Handles clickButton7.Click
        If turnPoint = True Then
            clickButton7.Text = "X"
            turnPoint = False
        Else
            clickButton7.Text = "O"
            turnPoint = True
        End If

        If clickButton1.Text = "X" And clickButton2.Text = "X" And clickButton3.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton4.Text = "X" And clickButton5.Text = "X" And clickButton6.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton7.Text = "X" And clickButton8.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton4.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton2.Text = "X" And clickButton5.Text = "X" And clickButton8.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton6.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton5.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton5.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        End If

        If clickButton1.Text = "O" And clickButton2.Text = "O" And clickButton3.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton4.Text = "O" And clickButton5.Text = "O" And clickButton6.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton7.Text = "O" And clickButton8.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton4.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton2.Text = "O" And clickButton5.Text = "O" And clickButton8.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton6.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton5.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton5.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        End If

        clickButton7.Enabled = False
    End Sub

    Private Sub clickButton8_Click(sender As Object, e As EventArgs) Handles clickButton8.Click
        If turnPoint = True Then
            clickButton8.Text = "X"
            turnPoint = False
        Else
            clickButton8.Text = "O"
            turnPoint = True
        End If

        If clickButton1.Text = "X" And clickButton2.Text = "X" And clickButton3.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton4.Text = "X" And clickButton5.Text = "X" And clickButton6.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton7.Text = "X" And clickButton8.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton4.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton2.Text = "X" And clickButton5.Text = "X" And clickButton8.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton6.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton5.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton5.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        End If

        If clickButton1.Text = "O" And clickButton2.Text = "O" And clickButton3.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton4.Text = "O" And clickButton5.Text = "O" And clickButton6.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton7.Text = "O" And clickButton8.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton4.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton2.Text = "O" And clickButton5.Text = "O" And clickButton8.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton6.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton5.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton5.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        End If

        clickButton8.Enabled = False
    End Sub

    Private Sub clickButton9_Click(sender As Object, e As EventArgs) Handles clickButton9.Click
        If turnPoint = True Then
            clickButton9.Text = "X"
            turnPoint = False
        Else
            clickButton9.Text = "O"
            turnPoint = True
        End If

        If clickButton1.Text = "X" And clickButton2.Text = "X" And clickButton3.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton4.Text = "X" And clickButton5.Text = "X" And clickButton6.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton7.Text = "X" And clickButton8.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton4.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton2.Text = "X" And clickButton5.Text = "X" And clickButton8.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton6.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton1.Text = "X" And clickButton5.Text = "X" And clickButton9.Text = "X" Then
            MessageBox.Show("Player X win")
        ElseIf clickButton3.Text = "X" And clickButton5.Text = "X" And clickButton7.Text = "X" Then
            MessageBox.Show("Player X win")
        End If

        If clickButton1.Text = "O" And clickButton2.Text = "O" And clickButton3.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton4.Text = "O" And clickButton5.Text = "O" And clickButton6.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton7.Text = "O" And clickButton8.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton4.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton2.Text = "O" And clickButton5.Text = "O" And clickButton8.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton6.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton1.Text = "O" And clickButton5.Text = "O" And clickButton9.Text = "O" Then
            MessageBox.Show("Player O win")
        ElseIf clickButton3.Text = "O" And clickButton5.Text = "O" And clickButton7.Text = "O" Then
            MessageBox.Show("Player O win")
        End If

        clickButton9.Enabled = False
    End Sub

    Private Sub buttonReset_Click(sender As Object, e As EventArgs) Handles buttonReset.Click
        turnPoint = True

        clickButton1.Text = ""
        clickButton2.Text = ""
        clickButton3.Text = ""
        clickButton4.Text = ""
        clickButton5.Text = ""
        clickButton6.Text = ""
        clickButton7.Text = ""
        clickButton8.Text = ""
        clickButton9.Text = ""

        clickButton1.Enabled = True
        clickButton2.Enabled = True
        clickButton3.Enabled = True
        clickButton4.Enabled = True
        clickButton5.Enabled = True
        clickButton6.Enabled = True
        clickButton7.Enabled = True
        clickButton8.Enabled = True
        clickButton9.Enabled = True
    End Sub
End Class
