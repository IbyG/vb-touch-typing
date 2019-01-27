Public Class details
    Dim subject As String = Nothing
    Dim line As String = " has done " & form1.win.ToString & " words" & " In " & form1.hoho.ToString & " Seconds"

    '   form1.win.ToString & " words" & " In " & form1.hoho.ToString & " Seconds"


    Public Sub details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label1.Text = "you have completed " & form1.win.ToString & " words in " & form1.hoho.ToString & " seconds"
        Label3.Text = subject & "has done" & form1.win.ToString & " words" & " In " & form1.hoho.ToString & " Seconds"
        Timer1.Start()
        ' Label3.Text = My.Settings.a

    End Sub

  

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        subject = TextBox1.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = subject & line
        My.Settings.a = Label3.Text
        My.Settings.Save()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class