Public Class addDDItem

    Private Sub dd_addBtn_Click(sender As Object, e As EventArgs) Handles dd_addBtn.Click
        ' Get the text from the TextBox
        Dim newText As String = dd_item.Text.Trim()

        ' Check if the text is not empty
        If Not String.IsNullOrEmpty(newText) Then
            ' Add the text to the ComboBox items
            Form1.pc_compType.Items.Add(newText)


            ' Optional: Clear the TextBox after adding the text
            dd_item.Clear()
            Me.Close()
        Else
            MessageBox.Show("Please enter a valid text before adding.")
        End If
    End Sub

    Private Sub addDDItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class