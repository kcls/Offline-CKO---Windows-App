Imports System.ComponentModel

Public Class form_no_card
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim closewindow As Boolean = True


        If txtPatronName.Text = "" Then
            MsgBox("Patron Name Required!")
            closewindow = False

        End If
        If txtDOB.Text = "" Then
            MsgBox("Date of Birth Required!")
            closewindow = False

        End If


        If closewindow = True Then


            PatronName = txtPatronName.Text

            PatronPhone = txtPhone.Text
            PatronDOB = txtDOB.Text
            PatronNotes = txtNotes.Text
            Form1.txt_Patron_barcode.Text = PatronName
            NoCard = True

            Me.Close()

        End If





    End Sub

    Private Sub form_no_card_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub form_no_card_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Form1.Enabled = False

    End Sub

    Private Sub form_no_card_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If txtPatronName.Text = "" Then NoCard = False
        Form1.Enabled = True
        Form1.txt_item_barcode.Focus()


    End Sub
End Class