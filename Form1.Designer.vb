<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer10 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer11 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer12 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer13 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer14 = New System.Windows.Forms.Timer(Me.components)
        Me.Pf = New System.Windows.Forms.PictureBox()
        Me.Timer15 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Pf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 2
        '
        'Timer2
        '
        Me.Timer2.Interval = 5000
        '
        'Timer3
        '
        Me.Timer3.Interval = 3
        '
        'Timer4
        '
        Me.Timer4.Interval = 3500
        '
        'Timer5
        '
        Me.Timer5.Interval = 2
        '
        'Timer6
        '
        Me.Timer6.Interval = 50
        '
        'Timer7
        '
        Me.Timer7.Interval = 5000
        '
        'Timer9
        '
        Me.Timer9.Interval = 50
        '
        'Timer8
        '
        Me.Timer8.Interval = 111000
        '
        'Timer10
        '
        Me.Timer10.Interval = 250
        '
        'Timer11
        '
        Me.Timer11.Interval = 160000
        '
        'Timer12
        '
        Me.Timer12.Interval = 6000
        '
        'Timer13
        '
        Me.Timer13.Interval = 200000
        '
        'Timer14
        '
        Me.Timer14.Interval = 380000
        '
        'Pf
        '
        Me.Pf.BackgroundImage = Global.Good_Game_s.My.Resources.Resources._6oYXyA
        Me.Pf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pf.Location = New System.Drawing.Point(109, 71)
        Me.Pf.Name = "Pf"
        Me.Pf.Size = New System.Drawing.Size(309, 291)
        Me.Pf.TabIndex = 0
        Me.Pf.TabStop = False
        Me.Pf.Visible = False
        '
        'Timer15
        '
        Me.Timer15.Interval = 10000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(1333, 623)
        Me.Controls.Add(Me.Pf)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Pf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Timer9 As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents Timer10 As Timer
    Friend WithEvents Timer11 As Timer
    Friend WithEvents Timer12 As Timer
    Friend WithEvents Timer13 As Timer
    Friend WithEvents Timer14 As Timer
    Friend WithEvents Pf As PictureBox
    Friend WithEvents Timer15 As Timer
End Class
