# Visual-Desktop

Nama : Abdul Aziz
Nim : 312210022
Kelas : TI 22.C3

# Tampilan Awal Sistem
![image](https://github.com/user-attachments/assets/ca771465-1f57-4ce6-9aae-38250279a004)

# Tampilan Running
![image](https://github.com/user-attachments/assets/da653275-2053-4840-9102-6e44909eb4d0)

Terdapat Button Dengan Fungsi Click Pada New dan Close
Berikut Codingan pada New dengan maksud menghapus semuanya dan memulai input dari awal
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


Penjelasan : Dengan memasukan Txt yang sudah di create dan menambahkan fungsi txtnama(untuk yang dituju).Focus


Sedangkan Untuk Close sangat Simple Hanya 

      Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
              Me.Close()
          End Sub




