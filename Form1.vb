Imports Gecko
Imports Gecko.Events
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rand As New Random()
        Dim qNumber = rand.Next(1, 45)
        Dim Quote As String = System.IO.File.ReadAllLines(Application.StartupPath & "\Quotes.txt")(qNumber)
        wbMain.LoadHtml("<!DOCTYPE html><html><head><title>WebJump Startpage</title></head><body><h1>Welcome to WebJump!</h1><p>" & Quote & "</p></body></html>")
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        tbAddress.Size = New Size(Width - 192, 25)
        tsBrowse.Refresh()
    End Sub

    Function navigate(ByVal address As String)
        Try
            wbMain.Navigate(address)
        Catch ex As Exception
            wbMain.LoadHtml("<h1>An error has occurred!</h1><p>Description: " & ex.Message & "</p>")
        End Try
    End Function

    Private Sub tbAddress_KeyPress(sender As Object, e As KeyEventArgs) Handles tbAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            navigate(tbAddress.Text)
        End If
    End Sub

    Private Sub wbMain_Navigated(sender As Object, e As GeckoNavigatedEventArgs) Handles wbMain.Navigated
        Me.Text = "WebJump Web Browser - " & wbMain.DocumentTitle
        tbAddress.Text = wbMain.Url.ToString()
        pbProgress.Visible = False
        If wbMain.CanGoBack Then
            bBack.Enabled = True
        Else
            bBack.Enabled = False
        End If
        If wbMain.CanGoForward Then
            bForward.Enabled = True
        Else
            bForward.Enabled = False
        End If
    End Sub

    Private Sub bBack_Click(sender As Object, e As EventArgs) Handles bBack.Click
        wbMain.GoBack()
        If wbMain.CanGoBack Then
            bBack.Enabled = True
        Else
            bBack.Enabled = False
        End If
        If wbMain.CanGoForward Then
            bForward.Enabled = True
        Else
            bForward.Enabled = False
        End If
    End Sub

    Private Sub bForward_Click(sender As Object, e As EventArgs) Handles bForward.Click
        wbMain.GoForward()
        If wbMain.CanGoBack Then
            bBack.Enabled = True
        Else
            bBack.Enabled = False
        End If
        If wbMain.CanGoForward Then
            bForward.Enabled = True
        Else
            bForward.Enabled = False
        End If
    End Sub

    Private Sub wbMain_ReadyStateChange(sender As Object, e As EventArgs) Handles wbMain.ReadyStateChange
        lStatus.Text = wbMain.StatusText
    End Sub

    Private Sub wbMain_Navigating(sender As Object, e As GeckoNavigatingEventArgs) Handles wbMain.Navigating
        pbProgress.Visible = True
    End Sub

    Private Sub bRefresh_Click(sender As Object, e As EventArgs) Handles bRefresh.Click
        wbMain.Reload()
    End Sub

    Private Sub bLMT_Click(sender As Object, e As EventArgs) Handles bLMT.Click
        navigate("luca009.github.io")
    End Sub

    Private Sub bDarkTheme_Click(sender As Object, e As EventArgs) Handles bDarkTheme.Click
        If My.Settings.darkTheme Then
            tsBrowse.BackColor = Color.White
            tbAddress.ForeColor = Color.Black
            tbAddress.BackColor = Color.White
            ssStatus.BackColor = Color.White
            lStatus.BackColor = Color.White
            lStatus.ForeColor = Color.Black
            bDarkTheme.Text = "Enable Dark Theme"
            My.Settings.darkTheme = False
            My.Settings.Save()
        Else
            tsBrowse.BackColor = Color.Black
            tbAddress.ForeColor = Color.White
            tbAddress.BackColor = Color.Black
            ssStatus.BackColor = Color.Black
            lStatus.BackColor = Color.Black
            lStatus.ForeColor = Color.White
            bDarkTheme.Text = "Disable Dark Theme"
            My.Settings.darkTheme = True
            My.Settings.Save()
        End If
    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        Application.Exit()
    End Sub
    Private Sub tbAddress_DoubleClick(sender As Object, e As EventArgs) Handles tbAddress.DoubleClick
        tbAddress.SelectAll()
    End Sub
End Class
