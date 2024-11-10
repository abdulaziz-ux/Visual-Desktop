Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click



    End Sub

    Private Sub CbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenis.SelectedIndexChanged
        Select Case cbJenis.Text
            Case "VIP"
                Txtharga.Text = 750000
            Case "Kelas I"
                Txtharga.Text = 450000
            Case "Kelas II"
                Txtharga.Text = 350000
            Case "Kelas III"
                Txtharga.Text = 150000
        End Select
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Txtbiaya_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtbiaya.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.Txtjumlah.Focus()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txtbiaya.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Txtlama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtlama.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.Txtbiaya.Focus()

            Dim A, B, C As New Long
            A = Val(Txtharga.Text)
            B = Val(Txtlama.Text)

            C = A * B
            Txtbiaya.Text = C
        End If
    End Sub

    Private Sub Txtjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtjumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.Txtkembali.Focus()

            Dim D, C, F As New Long
            D = Val(Txtjumlah.Text)
            C = Val(Txtbiaya.Text)

            F = D - C
            Txtkembali.Text = F
        End If
    End Sub

    Private Sub Txtharga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtharga.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.Txtlama.Focus()

        End If
    End Sub

    Private Sub Txtnama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtnama.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.Txtnomer.Focus()
        End If

    End Sub

    Private Sub Txtnomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtnomer.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.Txtalamat.Focus()
        End If

    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
        Me.Close()
    End Sub

    Private Sub BtNew_Click(sender As Object, e As EventArgs) Handles BtNew.Click
        Me.Txtnama.Text = ""

        Me.Txtnomer.Text = ""

        Me.Txtalamat.Text = ""

        Me.cbJenis.Text = ""

        Me.Txtharga.Text = ""

        Me.Txtlama.Text = ""

        Me.Txtbiaya.Text = ""

        Me.Txtjumlah.Text = ""

        Me.Txtkembali.Text = ""

        Me.Txtnama.Focus()
    End Sub
End Class
