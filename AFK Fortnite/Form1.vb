Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Random

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
    Private Const VK_W As Byte = &H57
    Private Const VK_A As Byte = &H41
    Private Const VK_S As Byte = &H53
    Private Const VK_D As Byte = &H44

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

    ' Randomness Object Initilise
    Private random As New Random()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If jamloopRunning Then
            ' If loop is running, stop it
            jamloopRunning = False
            Button1.BackColor = Color.Empty ' Reset button color
            ResetCountdown() ' Reset countdown timer
            ResetTimerLabels() ' Reset timer labels
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
            ResetTimerLabels() ' Reset timer labels
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
        Dim fortniteWindowTitle As String = "Fortnite" ' Adjust this if the actual window title is different
        Dim lastKnownTitle As String = ""

        Try
            While True
                Dim foregroundWindowHandle As IntPtr = GetForegroundWindow()
                If foregroundWindowHandle <> IntPtr.Zero Then
                    Dim titleBuilder As New System.Text.StringBuilder(256)
                    If GetWindowText(foregroundWindowHandle, titleBuilder, titleBuilder.Capacity) > 0 Then
                        Dim currentTitle As String = titleBuilder.ToString()
                        If currentTitle.Contains(fortniteWindowTitle) Then
                            ' Fortnite window is in focus
                            lastKnownTitle = currentTitle
                            Return True
                        Else
                            ' Another window is in focus
                            lastKnownTitle = currentTitle
                            Return False
                        End If
                    End If
                End If

                ' Sleep for a short duration before checking again
                Thread.Sleep(1000) ' Adjust sleep duration as needed
            End While
        Catch ex As Exception
            ' Handle or log the error
            Return False ' Return false if an error occurs
        End Try
    End Function

    Private Sub JamLoopRoutine()
        While jamloopRunning
            If IsFortniteInFocus() Then
                ' Fortnite is in focus, execute loop

                ' Countdown until next action
                Dim randomSleepDuration = random.Next(60000, 150000)
                Dim remainingTime = TimeSpan.FromMilliseconds(randomSleepDuration)

                ' Display countdown until the next action
                Do While remainingTime.TotalMilliseconds > 0 AndAlso jamloopRunning
                    Me.Invoke(Sub() Label2.Text = remainingTime.ToString("mm\:ss"))
                    Thread.Sleep(1000)
                    remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1))
                Loop

                ' Check if the loop is still running after the countdown
                If jamloopRunning Then
                    ' Perform actions if Fortnite is still in focus
                    If IsFortniteInFocus() Then
                        ' Hold the "B" key
                        keybd_event(VK_B, 0, KEYEVENTF_KEYDOWN, 0)
                        Thread.Sleep(random.Next(100, 500)) ' 0.2 seconds

                        ' Simulate tapping the "Space" key
                        keybd_event(VK_SPACE, 0, KEYEVENTF_KEYDOWN, 0)
                        keybd_event(VK_SPACE, 0, KEYEVENTF_KEYUP, 0)
                        Thread.Sleep(random.Next(100, 500)) ' 0.5 seconds

                        ' Release the "B" key
                        keybd_event(VK_B, 0, KEYEVENTF_KEYUP, 0)
                    End If
                End If

            Else
                ' Fortnite is not in focus, wait before checking again
                Thread.Sleep(1000) ' 1 second
            End If
        End While
    End Sub

    Private Sub LegoLoopRoutine()
        Dim wasdKeys As Byte() = {VK_W, VK_A, VK_S, VK_D}
        While legoloopRunning
            If IsFortniteInFocus() Then
                ' Fortnite is in focus, execute loop

                ' Countdown until next action
                Dim randomSleepDuration = random.Next(60000, 600000)
                Dim remainingTime = TimeSpan.FromMilliseconds(randomSleepDuration)

                ' Display countdown until the next action
                Do While remainingTime.TotalMilliseconds > 0 AndAlso legoloopRunning
                    Me.Invoke(Sub() Label4.Text = remainingTime.ToString("mm\:ss"))
                    Thread.Sleep(1000)
                    remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1))
                Loop

                ' Check if the loop is still running after the countdown
                If legoloopRunning Then
                    ' Perform actions if Fortnite is still in focus
                    If IsFortniteInFocus() Then
                        ' Simulate pressing a random WASD key
                        Dim randomKeyIndex = random.Next(wasdKeys.Length)
                        Dim randomKeyCode = wasdKeys(randomKeyIndex)
                        keybd_event(randomKeyCode, 0, KEYEVENTF_KEYDOWN, 0)

                        ' Hold the key for a random duration
                        Thread.Sleep(random.Next(1000, 5000))

                        ' Release the key
                        keybd_event(randomKeyCode, 0, KEYEVENTF_KEYUP, 0)
                    End If
                End If

            Else
                ' Fortnite is not in focus, wait before checking again
                Thread.Sleep(1000) ' 1 second
            End If
        End While
    End Sub
    Private Sub ResetTimerLabels()
        ' Reset the text of Label2 and Label4 to the initial state
        Me.Invoke(Sub() Label2.Text = "00:00")
        Me.Invoke(Sub() Label4.Text = "00:00")
    End Sub

    Private Sub StartCountdown()
        If countdownRunning Then
            ' Stop existing countdown thread
            countdownThread.Abort()
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
        If Me.IsHandleCreated Then
            Dim formattedTime As String = String.Format("{0:00}:{1:00}:{2:00}", Math.Floor(time.TotalHours), time.Minutes, time.Seconds)
            Me.Invoke(Sub() lblCountdown.Text = formattedTime)
        End If
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
