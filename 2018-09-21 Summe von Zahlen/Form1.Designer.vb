<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdErgebnis = New System.Windows.Forms.Button()
        Me.txtUG = New System.Windows.Forms.TextBox()
        Me.txtOG = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUebersicht = New System.Windows.Forms.Label()
        Me.txtSchritt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOhne = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdGeradeZ = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdErgebnis
        '
        Me.cmdErgebnis.Location = New System.Drawing.Point(364, 29)
        Me.cmdErgebnis.Name = "cmdErgebnis"
        Me.cmdErgebnis.Size = New System.Drawing.Size(185, 202)
        Me.cmdErgebnis.TabIndex = 0
        Me.cmdErgebnis.Text = "Knopf"
        Me.cmdErgebnis.UseVisualStyleBackColor = True
        '
        'txtUG
        '
        Me.txtUG.Location = New System.Drawing.Point(137, 137)
        Me.txtUG.Name = "txtUG"
        Me.txtUG.Size = New System.Drawing.Size(154, 26)
        Me.txtUG.TabIndex = 1
        '
        'txtOG
        '
        Me.txtOG.Location = New System.Drawing.Point(137, 187)
        Me.txtOG.Name = "txtOG"
        Me.txtOG.Size = New System.Drawing.Size(154, 26)
        Me.txtOG.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "UG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "OG"
        '
        'lblUebersicht
        '
        Me.lblUebersicht.AutoSize = True
        Me.lblUebersicht.Location = New System.Drawing.Point(346, 365)
        Me.lblUebersicht.Name = "lblUebersicht"
        Me.lblUebersicht.Size = New System.Drawing.Size(0, 20)
        Me.lblUebersicht.TabIndex = 5
        '
        'txtSchritt
        '
        Me.txtSchritt.Location = New System.Drawing.Point(137, 237)
        Me.txtSchritt.Name = "txtSchritt"
        Me.txtSchritt.Size = New System.Drawing.Size(154, 26)
        Me.txtSchritt.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Schritt"
        '
        'txtOhne
        '
        Me.txtOhne.Location = New System.Drawing.Point(137, 286)
        Me.txtOhne.Name = "txtOhne"
        Me.txtOhne.Size = New System.Drawing.Size(154, 26)
        Me.txtOhne.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ohne"
        '
        'cmdGeradeZ
        '
        Me.cmdGeradeZ.Location = New System.Drawing.Point(555, 29)
        Me.cmdGeradeZ.Name = "cmdGeradeZ"
        Me.cmdGeradeZ.Size = New System.Drawing.Size(185, 202)
        Me.cmdGeradeZ.TabIndex = 10
        Me.cmdGeradeZ.Text = "gerade Zahlen"
        Me.cmdGeradeZ.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdGeradeZ)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOhne)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSchritt)
        Me.Controls.Add(Me.lblUebersicht)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOG)
        Me.Controls.Add(Me.txtUG)
        Me.Controls.Add(Me.cmdErgebnis)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdErgebnis As Button
    Friend WithEvents txtUG As TextBox
    Friend WithEvents txtOG As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUebersicht As Label
    Friend WithEvents txtSchritt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOhne As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdGeradeZ As Button
End Class
