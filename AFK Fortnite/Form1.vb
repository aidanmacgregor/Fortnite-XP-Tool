Imports System.Runtime.InteropServices
Imports System.Threading

Public Class Form1
    ' Importing the keybd_event function from user32.dll
    <DllImport("user32.dll")>
    Private Shared Sub keybd_event(ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    End Sub

    ' Importing the GetForegroundWindow function from user32.dll
    <DllImport("user32.dll")>
    Private Shared Function GetForegroundWindow() As IntPtr
    End Function

    ' Importing the GetWindowText function from user32.dll
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function GetWindowText(ByVal hWnd As IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer
    End Function

    ' Virtual key codes for the keys we want to use
    Private Const VK_B As Byte = &H42
    Private Const VK_SPACE As Byte = &H20

    ' Flags for key press and key release
    Private Const KEYEVENTF_KEYDOWN As Integer = &H0
    Private Const KEYEVENTF_KEYUP As Integer = &H2

    ' Variables to track if the loops are running
    Private jamloopRunning As Boolean = False
    Private legoloopRunning As Boolean = False

    ' Countdown timer variables
    Private countdownTime As TimeSpan = TimeSpan.FromHours(3) + TimeSpan.FromMinutes(30)
    Private countdownThread As Thread
    Private countdownRunning As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If jamloopRunning Then
            ' If loop is running, stop it
            jamloopRunning = False
            Button1.BackColor = Color.Empty ' Reset button color
            ResetCountdown() ' Reset countdown timer
        Else
            ' If loop is not running, start it
            jamloopRunning = True
            Button1.BackColor = Color.Green ' Set button color to green

            ' Start the loop in a separate thread
            Dim t As New Thread(AddressOf JamLoopRoutine)
            t.Start()

            ' Start or reset the countdown timer
            StartCountdown()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If legoloopRunning Then
            ' If loop is running, stop it
            legoloopRunning = False
            Button2.BackColor = Color.Empty ' Reset button color
            ResetCountdown() ' Reset countdown timer
        Else
            ' If loop is not running, start it
            legoloopRunning = True
            Button2.BackColor = Color.Green ' Set button color to green

            ' Start the loop in a separate thread
            Dim t As New Thread(AddressOf LegoLoopRoutine)
            t.Start()

            ' Start or reset the countdown timer
            StartCountdown()
        End If
    End Sub

    Private Function IsFortniteInFocus() As Boolean
        Dim foregroundWindowHandle As IntPtr = GetForegroundWindow()
        If foregroundWindowHandle <> IntPtr.Zero Then
            Dim titleBuilder As New System.Text.StringBuilder(256)
            If GetWindowText(foregroundWindowHandle, titleBuilder, titleBuilder.Capacity) > 0 Then
                Return titleBuilder.ToString().Contains("Fortnite")
            End If
        End If
        Return False
    End Function

    Private Sub JamLoopRoutine()
        While jamloopRunning
            If IsFortniteInFocus() Then
                ' Fortnite is in focus, execute loop
                Thread.Sleep(10000) ' 10 seconds
                ' Hold the "B" key
                keybd_event(VK_B, 0, KEYEVENTF_KEYDOWN, 0)
                Thread.Sleep(200) ' 0.2 seconds
                ' Simulate tapping the "Space" key
                keybd_event(VK_SPACE, 0, KEYEVENTF_KEYDOWN, 0)
                keybd_event(VK_SPACE, 0, KEYEVENTF_KEYUP, 0)
                Thread.Sleep(500) ' 0.5 seconds
                ' Release the "B" key
                keybd_event(VK_B, 0, KEYEVENTF_KEYUP, 0)
                Thread.Sleep(80000) ' 80 seconds
            Else
                ' Fortnite is not in focus, wait before checking again
                Thread.Sleep(1000) ' 1 second
            End If
        End While
    End Sub

    Private Sub LegoLoopRoutine()
        While legoloopRunning
            If IsFortniteInFocus() Then
                ' Fortnite is in focus, execute loop
                Thread.Sleep(10000) ' 10 seconds
                ' Hold the "B" key
                keybd_event(VK_B, 0, KEYEVENTF_KEYDOWN, 0)
                Thread.Sleep(500) ' 0.5 seconds

                ' Release the "B" key
                keybd_event(VK_B, 0, KEYEVENTF_KEYUP, 0)
                Thread.Sleep(80000) ' 80 seconds
            Else
                ' Fortnite is not in focus, wait before checking again
                Thread.Sleep(1000) ' 1 second
            End If
        End While
    End Sub

    Private Sub StartCountdown()
        If countdownRunning Then
            countdownThread.Abort() ' Stop existing countdown thread
        End If

        countdownRunning = True
        countdownThread = New Thread(AddressOf CountdownRoutine)
        countdownThread.Start()
    End Sub

    Private Sub ResetCountdown()
        countdownRunning = False
        countdownTime = TimeSpan.FromHours(3) + TimeSpan.FromMinutes(30)
        UpdateCountdownLabel(countdownTime)
    End Sub

    Private Sub CountdownRoutine()
        While countdownRunning AndAlso countdownTime.TotalSeconds > 0
            Thread.Sleep(1000) ' 1 second
            countdownTime = countdownTime.Subtract(TimeSpan.FromSeconds(1))
            UpdateCountdownLabel(countdownTime)
        End While
    End Sub

    Private Sub UpdateCountdownLabel(time As TimeSpan)
        Dim formattedTime As String = String.Format("{0:00}:{1:00}:{2:00}", Math.Floor(time.TotalHours), time.Minutes, time.Seconds)
        Me.Invoke(Sub() lblCountdown.Text = formattedTime)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ensure all threads are stopped before closing the form
        If jamloopRunning Then
            jamloopRunning = False
        End If
        If legoloopRunning Then
            legoloopRunning = False
        End If
        If countdownRunning Then
            countdownRunning = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub
End Class
