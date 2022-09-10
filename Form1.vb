Public Class Form1
    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        '' End the program
        End

    End Sub

    Private Sub CopyrightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyrightToolStripMenuItem.Click
        ' Generate a program that says copyright [Flames LLC 20XX] As a messagebox
        MessageBox.Show("Copyright [Flames LLC 20XX]")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '' add it to the textnbox then calculate it to the richtextbox
        RichTextBox1.Text = TextBox1.Text
        RichTextBox1.Text = RichTextBox1.Text.Replace("a", "1")
        RichTextBox1.Text = RichTextBox1.Text.Replace("a", "1")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '' add 1 digit to textbox1
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '' add digit to textbox1
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.Text = TextBox1.Text
        RichTextBox1.Text = RichTextBox1.Text.Replace("b", "5")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' TA TA
        RichTextBox1.Text = TextBox1.Text

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '' MAKE ALL THE PEMDAS
        RichTextBox1.Text = TextBox1.Text
        '' now add the digit of the button
        RichTextBox1.Text = RichTextBox1.Text.Replace("c", "6")
    End Sub
End Class
