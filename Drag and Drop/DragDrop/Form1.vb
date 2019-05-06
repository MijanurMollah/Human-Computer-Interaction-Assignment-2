Public Class Form1

    Public x As Integer
    Public x1 As Integer
    Public y As Integer
    Public y1 As Integer
    Public m As Boolean
    Public m1 As Boolean
    Shared HandMoveCursor As Cursor = New Cursor(GetType(Form1), "H_MOVE.CUR")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        x = e.X
        y = e.Y
        m = PictureBox1.Capture
        PictureBox1.BringToFront()
    End Sub

    Private Sub picturebox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If (m) Then
            Cursor = HandMoveCursor
            Dim difx = e.X - x
            Dim dify = e.Y - y
            PictureBox1.Location = New Drawing.Point(PictureBox1.Location.X + difx, PictureBox1.Location.Y + dify)
            If (PictureBox1.Bounds.IntersectsWith(PictureBox2.Bounds)) Then
                ToolStripStatusLabel1.Text = "PictureBox1: " + PictureBox1.Location.X.ToString + "," + PictureBox1.Location.Y.ToString +
                    " - PictureBox1 is on PictureBox2"
            Else
                ToolStripStatusLabel1.Text = "PictureBox1: " + PictureBox1.Location.X.ToString + "," + PictureBox1.Location.Y.ToString
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        m = False
        Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        x1 = e.X
        y1 = e.Y
        m1 = PictureBox2.Capture
        PictureBox2.BringToFront()
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        If (m1) Then
            Cursor = HandMoveCursor
            Dim difx = e.X - x1
            Dim dify = e.Y - y1
            PictureBox2.Location = New Drawing.Point(PictureBox2.Location.X + difx, PictureBox2.Location.Y + dify)
            If (PictureBox2.Bounds.IntersectsWith(PictureBox1.Bounds)) Then
                ToolStripStatusLabel1.Text = "PictureBox2: " + PictureBox2.Location.X.ToString + "," + PictureBox2.Location.Y.ToString +
                    " - PictureBox2 is on PictureBox1"
            Else
                ToolStripStatusLabel1.Text = "PictureBox2: " + PictureBox2.Location.X.ToString + "," + PictureBox2.Location.Y.ToString
            End If
        End If
    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        m1 = False
        Cursor = Cursors.Default
    End Sub

End Class
