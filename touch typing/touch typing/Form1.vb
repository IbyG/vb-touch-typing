Public Class form1
    Dim level As Integer = 0 ' the persons level
    Dim randomclass As New Random() 'creates random selection not used
    Dim charlist = ("the ,end ,hello ,today ,aswell ,intense ,throughout ,undermining ,this ,time ,new ,releases ,indistructable ,understood ,undefined ,therefore ,unknown ,unrespected ,respected ,disrespected ,through ,out ,neverland ,personification ,koala ,intense ,meeting ,home ,variables ,critical ,thinking ,creative ,reflective ,problem ,solving ,digital ,citizens ,buzz ,hajj ,razz ,jeez ,junk ,phiz ,zonk ,fozy ,fuji ,jowl ,puja ,fuzzed ,puzzle ,mizzly ,mizzen ,about ,after ,again ,air ,all ,along ,also ,an ,and ,another ,any ,are ,around ,as ,at ,away ,back ,be ,because ,been ,before ,below ,between ,noth ,but ,by ,came ,get ,give ,go ,good ,great ,had ,has ,have ,he ,help ,her ,here ,him ,his ,home ,house ,how ,if ,in ,into ,is ,it ,its ,just ,know ,large ,name ,never ,new ,next ,no ,not ,now ,number ,of ,off ,old ,on ,one ,only ,or ,other ,our ,out ,over ,own ,part ,people ,place ,put ,read ,right ,said ,then ,there ,these ,there ,these ,they ,thing ,think ,this ,those ,thought ,three ,through ,time ,to ,together ,two ,under ,up ,us ,use ,very ,want ,water ,way ,we ,well ,went ,activity ,alaska ,appearance ,aren't ,article ,aunt ,automobile ,avoid ,basket ,birthday ,cage ,cake ,canada ,central ,character ,charles ,chicken ,chosen ,club ,cook ,court ,cream ,cutting ,daily ,darkness ,diagram ,dozen ,dream ,driving ,effort ,establish ,exact ,effort ,establish ,exact ,excitement ,fifteen ,flag ,flies ,football ,foreign ,frame ,frequently ,frighten ,function ,gate ,gently ,gradually ,hadn't ,harder ,hide ,hurried ,identity ,importance ,impossible ,india ,jar ,journey ,joy ,lesson ,lincol ,lips ,log ,london ,loose ,message ,minerals ,outer ,paint ,papa ,paris ,particles ,personal ,physical ,pie ,pipe ,pole ,pond ,progress ,querter ,rays ,recent ,recognise ,richard ,robert ,rod ,ruler ,safety ,sally ,sang ,setting ,shells ,sick ,situation ,slightly ,spain ,spirit ,steady ,steped ,strike ,successful ,sudden ,sum ,terrible ,tie ,traffic ,unusual ,volume ,whale ,wise ,hello world ,indangered ,global ,australia ,economics ,year ,edition ,economy ,workbbook ,author ,access ")
    Dim charlist2 = ("there should be enough room for more words ,it's a good day too die hard ,this is done by Ibrahim George ,there is no 'i' in team and so it is made up of many people ,there is no need to swear profanity is wrong ,this is the last one number seven and so this is the practice that i got so far ,harry potter sat on a stone but the stone turns out to be the corpse of his dad ,A neighbourhood brushes the designate chorus inside his stranger ,The captain humbles the prejudice underneath the prospective musical ,The downstairs keeper lusts next to the onion ,A stack forbids a bankrupt in the violate rumor ,The justified rash phases a sterile aunt ,The malicious clue paces the tray before a helpful highlight ,After the race solos the aforementioned revenue ,A publisher jackets the accidental bacterium ,Her industry fakes the hopeful cycle next to the wrath ,How does the ambiguous planet rest upon the urban fish ,When will a sod possess the consumed wine ,The plastered mechanism mutters near the booklet ,A violate mate primes the laughter around a promised bug ,The leak mirrors a degenerate across a preserved request")
    Dim usuablechars() As String 'this is linkedwith charlist and charlist 2 
    Dim number As Integer = 0 ' helps with the randomizing 
    Dim finaltext As String = "" 'this is random that is shown in wordbox at the end of the process
    Dim point1 As String = Nothing 'another term for the the main word box
    Dim point2 As String = Nothing ' another term for typebox.text 
    Public win As Integer = 0 ' the winning score  
    Public lose As Integer = 0 'loose timer not in use
    Public time As Integer = 21 ' the timer
    Public hoho As String = Nothing

    Private Sub form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown


        If e.KeyCode = Keys.A Then
            ba.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.A Then
            ba.BackColor = Color.White

        End If
        
        If e.KeyCode = Keys.B Then
            bb.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.B Then
            bb.BackColor = Color.White
        End If

        If e.KeyCode = Keys.C Then
            bc.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.C Then
            bc.BackColor = Color.White
        End If

        If e.KeyCode = Keys.D Then
            bd.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.D Then
            bd.BackColor = Color.White
        End If
      
        If e.KeyCode = Keys.E Then
            be.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.E Then
            be.BackColor = Color.White
        End If

        If e.KeyCode = Keys.F Then
            bf.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.F Then
            bf.BackColor = Color.White
        End If

        If e.KeyCode = Keys.G Then
            bg.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.G Then
            bg.BackColor = Color.White
        End If

        If e.KeyCode = Keys.H Then
            bh.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.H Then
            bh.BackColor = Color.White
        End If

        If e.KeyCode = Keys.I Then
            bi.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.I Then
            bi.BackColor = Color.White
        End If

        If e.KeyCode = Keys.J Then
            bj.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.J Then
            bj.BackColor = Color.White
        End If

        If e.KeyCode = Keys.K Then
            bk.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.K Then
            bk.BackColor = Color.White
        End If

        If e.KeyCode = Keys.L Then
            bl.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.L Then
            bl.BackColor = Color.White
        End If

        If e.KeyCode = Keys.M Then
            bm.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.M Then
            bm.BackColor = Color.White
        End If

        If e.KeyCode = Keys.N Then
            bn.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.N Then
            bn.BackColor = Color.White
        End If

        If e.KeyCode = Keys.O Then
            bo.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.O Then
            bo.BackColor = Color.White
        End If

        If e.KeyCode = Keys.P Then
            bp.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.P Then
            bp.BackColor = Color.White
        End If

        If e.KeyCode = Keys.Q Then
            bq.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.Q Then
            bq.BackColor = Color.White
        End If

        If e.KeyCode = Keys.R Then
            br.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.R Then
            br.BackColor = Color.White
        End If

        If e.KeyCode = Keys.S Then
            bs.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.S Then
            bs.BackColor = Color.White
        End If

        If e.KeyCode = Keys.T Then
            bt.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.T Then
            bt.BackColor = Color.White
        End If

        If e.KeyCode = Keys.U Then
            bu.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.U Then
            bu.BackColor = Color.White
        End If

        If e.KeyCode = Keys.V Then
            bv.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.V Then
            bv.BackColor = Color.White
        End If

        If e.KeyCode = Keys.W Then
            bw.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.W Then
            bw.BackColor = Color.White
        End If

        If e.KeyCode = Keys.X Then
            bx.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.X Then
            bx.BackColor = Color.White
        End If

        If e.KeyCode = Keys.Y Then
            by.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.Y Then
            by.BackColor = Color.White
        End If

        If e.KeyCode = Keys.Z Then
            bz.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.Z Then
            bz.BackColor = Color.White
        End If

        If e.KeyCode = Keys.Space Then
            Bspace.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.Space Then
            Bspace.BackColor = Color.White
        End If

        If e.KeyCode = Keys.Back Then
            BBack.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.Back Then
            BBack.BackColor = Color.White
        End If

        If e.KeyCode = Keys.Enter Then
            benter.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.Enter Then
            benter.BackColor = Color.White
        End If

        If e.KeyCode = Keys.D1 Then
            b1.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.D1 Then
            b1.BackColor = Color.White
        End If

        If e.KeyCode = Keys.D2 Then
            b2.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.D2 Then
            b2.BackColor = Color.White
        End If

        If e.KeyCode = Keys.D3 Then
            b3.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.D3 Then
            b3.BackColor = Color.White
        End If

        If e.KeyCode = Keys.D4 Then
            b4.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.D4 Then
            b4.BackColor = Color.White
        End If

        If e.KeyCode = Keys.D5 Then
            b5.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.D5 Then
            b5.BackColor = Color.White
        End If

        If e.KeyCode = Keys.D6 Then
            b6.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.D6 Then
            b6.BackColor = Color.White
        End If

        If e.KeyCode = Keys.D7 Then
            b7.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.D7 Then
            b7.BackColor = Color.White
        End If

        If e.KeyCode = Keys.D8 Then
            b8.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.D8 Then
            b8.BackColor = Color.White
        End If

        If e.KeyCode = Keys.D9 Then
            b9.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.D9 Then
            b9.BackColor = Color.White
        End If

        If e.KeyCode = Keys.D0 Then
            b0.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.D0 Then
            b0.BackColor = Color.White
        End If


        If e.KeyCode = Keys.Shift Then
            Button37.BackColor = Color.Green
        ElseIf e.KeyCode <> Keys.Shift Then
            Button37.BackColor = Color.White
        End If

        'If e.KeyCode = Keys.Tab Then
        '    btab.BackColor = Color.Green
        'ElseIf e.KeyCode <> Keys.Tab Then
        '    btab.BackColor = Color.White
        'End If


       



    End Sub
    Private Sub Bnewgame_Click(sender As Object, e As EventArgs) Handles Bnewgame.Click
        Timer1.Start()
        Timer2.Start()
        Timer3.Stop()
        Timer4.Start()
        level = 1
        If time = 0 Then 'this resets the points system and the timer
            time = 21
        End If
        If Texttime.Text = "" Then 'if the number box is not filled with numbers then the default start is 21 seconds.
            time = 21
        Else
            time = Texttime.Text
        End If
        typebox.Focus()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer4.Start()
        Timer3.Start()
        Timer2.Start()
        Timer1.Stop()
        level = 1
        If time = 0 Then 'this resets the points system and the timer
            time = 21
            win = 0
        End If
        If Texttime.Text = "" Then 'if the number box is not filled with numbers then the default start is 21 seconds.
            time = 60
        Else
            time = Texttime.Text
        End If

        typebox.Focus()

    End Sub
    Private Sub checker()
        If typebox.Text = WordBox.Text Then
            level = level + 1
        End If
    End Sub
    Private Sub leveler2()
        'this is for words coming up on the screen 
        number = level
        usuablechars = Split(charlist, ",")
        finaltext = ""
        If typebox.Text = WordBox.Text Then
            number = randomclass.Next(0, 250)
            finaltext = usuablechars(number)
            WordBox.Text = finaltext
            typebox.Text = ""
        End If

    End Sub
    Private Sub leveler3()
        'this is for sentences coming on the screen
        number = level
        usuablechars = Split(charlist2, ",")
        finaltext = ""
        If typebox.Text = WordBox.Text Then
            number = randomclass.Next(0, 15)
            finaltext = usuablechars(number)
            WordBox.Text = finaltext
            typebox.Text = ""
        End If


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'this is meant to add one to the leveler every time you get it right and then it calls leveler 
        If typebox.Text = WordBox.Text Then
            level = level + 1
            Call leveler2()
            finaltext = ""
            Label1.Text = "correct: " & win.ToString
            'ElseIf typebox.Text <> WordBox.Text Then
            '    level = level + 1
            '    Call leveler2()
            '    finaltext = ""
            '    Label4.Text = "Incorect: " & lose.ToString
        End If
    End Sub
    Private Sub pointsystem()


        'point1 = WordBox.Text
        'point2 = typebox.Text
        'If point1 = point2 Then
        '    win = win + 1
        'End If

        'If point1 <> point2 Then
        '    If e.KeyCode = Keys.Space Then
        '        lose = lose + 1
        '    End If
        'End If




    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If typebox.Text <> finaltext Then
            typebox.ForeColor = Color.Black
        Else
            typebox.ForeColor = Color.Red
        End If
        Call pointsystem()
    End Sub 'no use for now 
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If typebox.Text = WordBox.Text Then
            level = level + 1
            Call leveler3()
            finaltext = ""
            Label1.Text = "correct: " & win.ToString
        ElseIf Label2.Text = "incorrect: " & point2.ToString Then
        End If
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        time = time - 1
        If Texttime.Text = "" Then
            hoho = 20
        Else
            hoho = Texttime.Text
        End If
        Label2.Text = "time remaining: " & time.ToString
        If time = 0 Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            details.Show()
            win = -1
            typebox.Text = ""
            WordBox.Text = ""
        End If
    End Sub
    'MsgBox("you have completed " & win.ToString & " words in " & time.ToString & " seconds")

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click

    End Sub
End Class
