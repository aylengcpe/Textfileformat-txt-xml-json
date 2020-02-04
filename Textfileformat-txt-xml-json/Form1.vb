Imports System.IO

Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'sir papalit nalang po ng path. Thanks!
        Dim writer As TextWriter = New StreamWriter("C:\Users\careshiela\out.xml")

        writer.Write("Name: " + TextBox1.Text + Environment.NewLine + "Age: " + TextBox2.Text + Environment.NewLine + "Address: " + TextBox3.Text)

        writer.Close()

        MessageBox.Show("Exported!")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'sir papalit nalang po ng path. Thanks!
        Dim writer As TextWriter = New StreamWriter("C:\Users\careshiela\out.txt")

        writer.Write("Name: " + TextBox1.Text + Environment.NewLine + "Age: " + TextBox2.Text + Environment.NewLine + "Address: " + TextBox3.Text)

        writer.Close()

        MessageBox.Show("Exported!")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'sir papalit nalang po ng path. Thanks!
        Dim writer As TextWriter = New StreamWriter("C:\Users\careshiela\out.json")

        writer.Write("Name: " + TextBox1.Text + Environment.NewLine + "Age: " + TextBox2.Text + Environment.NewLine + "Address: " + TextBox3.Text)

        writer.Close()

        MessageBox.Show("Exported!")
    End Sub
End Class
