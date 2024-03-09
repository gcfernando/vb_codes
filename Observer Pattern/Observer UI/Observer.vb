Public Class FormBinary

    Private _hr As Integer = 0
    Private _mt As Integer = 0
    Private _sc As Integer = 0

    Private _thr As Integer = 0
    Private _tmt As Integer = 0
    Private _tsc As Integer = 0

    Private LoopI As Integer

    Private MLocation As Point

    Private Arr As New ArrayList()

    Private HourColour As Color = Color.Red
    Private MiniuteColor As Color = Color.FromArgb(255, 255, 128)
    Private SecondsColor As Color = Color.Lime

    Private Sub TimerUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerUpdate.Tick

        LabelDisplayTime.Text = Date.Now.ToLongTimeString()
        LabelDisplayTime.Refresh()

        _hr = Date.Now.Hour()
        If _thr <> _hr Then
            Call SetColourIndex(_hr)
            Call SetBackColour(Arr, HourColour, "H")
        End If

        _mt = Date.Now.Minute()
        If _tmt <> _mt Then
            Call SetColourIndex(_mt)
            Call SetBackColour(Arr, MiniuteColor, "M")
        End If

        _sc = Date.Now.Second()
        If _tsc <> _sc Then
            Call SetColourIndex(_sc)
            Call SetBackColour(Arr, SecondsColor, "S")
        End If

    End Sub

    Private Sub FormBinary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call TimerUpdate_Tick(sender, e)
        Dim _Pnt As New Point(0, 0)
        Location = _Pnt

    End Sub

    Private Sub FormBinary_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        MLocation = e.Location

    End Sub

    Private Sub FormBinary_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        If String.Compare(Control.MouseButtons.ToString(), "Left") = 0 Then
            Dim MSize As New Size(MLocation) With {
                .Width = e.X - MLocation.X,
                .Height = e.Y - MLocation.Y
            }
            Location = Point.Add(Me.Location, MSize)
        End If

    End Sub

    Private Sub SetColourIndex(ByVal Passvalue As Integer)

        Arr.Clear()
        If Passvalue = 0 Then Exit Sub

        For LoopI = 5 To 0 Step -1
            Dim PowerValue As Integer = 2 ^ LoopI
            If (Passvalue - PowerValue) >= 0 Then
                Dim BalVaue As Integer = Passvalue - PowerValue
                Arr.Add(LoopI)
                Passvalue = BalVaue
                If BalVaue = 0 Then Exit For
            End If
        Next

    End Sub

    Private Sub SetBackColour(ByVal PassArray As ArrayList, ByVal Colour As Color, ByVal Type As String)

        If Type.ToString() = "H".ToString() Then

            Label1.BackColor = Color.Black
            Label2.BackColor = Color.Black
            Label3.BackColor = Color.Black
            Label4.BackColor = Color.Black
            Label5.BackColor = Color.Black

            For i As Integer = 0 To PassArray.Count - 1
                Dim ArrValue As Integer = PassArray(i)
                If ArrValue = 0 Then Label1.BackColor = Colour
                If ArrValue = 1 Then Label2.BackColor = Colour
                If ArrValue = 2 Then Label3.BackColor = Colour
                If ArrValue = 3 Then Label4.BackColor = Colour
                If ArrValue = 4 Then Label5.BackColor = Colour
            Next

        ElseIf Type.ToString() = "M".ToString() Then

            Label6.BackColor = Color.Black
            Label7.BackColor = Color.Black
            Label8.BackColor = Color.Black
            Label9.BackColor = Color.Black
            Label10.BackColor = Color.Black
            Label11.BackColor = Color.Black

            For i As Integer = 0 To PassArray.Count - 1
                Dim ArrValue As Integer = PassArray(i)
                If ArrValue = 0 Then Label6.BackColor = Colour
                If ArrValue = 1 Then Label7.BackColor = Colour
                If ArrValue = 2 Then Label8.BackColor = Colour
                If ArrValue = 3 Then Label9.BackColor = Colour
                If ArrValue = 4 Then Label10.BackColor = Colour
                If ArrValue = 5 Then Label11.BackColor = Colour
            Next

        ElseIf Type.ToString() = "S".ToString() Then

            Label12.BackColor = Color.Black
            Label13.BackColor = Color.Black
            Label14.BackColor = Color.Black
            Label15.BackColor = Color.Black
            Label16.BackColor = Color.Black
            Label17.BackColor = Color.Black

            For i As Integer = 0 To PassArray.Count - 1
                Dim ArrValue As Integer = PassArray(i)
                If ArrValue = 0 Then Label12.BackColor = Colour
                If ArrValue = 1 Then Label13.BackColor = Colour
                If ArrValue = 2 Then Label14.BackColor = Colour
                If ArrValue = 3 Then Label15.BackColor = Colour
                If ArrValue = 4 Then Label16.BackColor = Colour
                If ArrValue = 5 Then Label17.BackColor = Colour
            Next

        End If

    End Sub

    Private Sub FormBinary_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDoubleClick

        Application.Exit()

    End Sub

End Class