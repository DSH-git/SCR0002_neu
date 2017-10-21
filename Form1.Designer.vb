<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CheckBoxUngeradeAnzeige = New System.Windows.Forms.CheckBox()
        Me.CheckGeradeAnzeigen = New System.Windows.Forms.CheckBox()
        Me.TextBoxDateiPfad = New System.Windows.Forms.TextBox()
        Me.ButtonListeAnzeigen = New System.Windows.Forms.Button()
        Me.CheckAnsichtAendern = New System.Windows.Forms.CheckBox()
        Me.ButtonListeLoeschen = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Dateiname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Dateigröße = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonPfadAuswaehlen = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBoxUngeradeAnzeige
        '
        Me.CheckBoxUngeradeAnzeige.AutoSize = True
        Me.CheckBoxUngeradeAnzeige.Checked = True
        Me.CheckBoxUngeradeAnzeige.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxUngeradeAnzeige.Location = New System.Drawing.Point(688, 111)
        Me.CheckBoxUngeradeAnzeige.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxUngeradeAnzeige.Name = "CheckBoxUngeradeAnzeige"
        Me.CheckBoxUngeradeAnzeige.Size = New System.Drawing.Size(155, 21)
        Me.CheckBoxUngeradeAnzeige.TabIndex = 0
        Me.CheckBoxUngeradeAnzeige.Text = "Ungerade anzeigen"
        Me.CheckBoxUngeradeAnzeige.UseVisualStyleBackColor = True
        '
        'CheckGeradeAnzeigen
        '
        Me.CheckGeradeAnzeigen.AutoSize = True
        Me.CheckGeradeAnzeigen.Location = New System.Drawing.Point(688, 128)
        Me.CheckGeradeAnzeigen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckGeradeAnzeigen.Name = "CheckGeradeAnzeigen"
        Me.CheckGeradeAnzeigen.Size = New System.Drawing.Size(140, 21)
        Me.CheckGeradeAnzeigen.TabIndex = 1
        Me.CheckGeradeAnzeigen.Text = "Gerade anzeigen"
        Me.CheckGeradeAnzeigen.UseVisualStyleBackColor = True
        '
        'TextBoxDateiPfad
        '
        Me.TextBoxDateiPfad.Location = New System.Drawing.Point(173, 122)
        Me.TextBoxDateiPfad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxDateiPfad.Name = "TextBoxDateiPfad"
        Me.TextBoxDateiPfad.Size = New System.Drawing.Size(267, 22)
        Me.TextBoxDateiPfad.TabIndex = 2
        Me.TextBoxDateiPfad.Text = "C:\test"
        '
        'ButtonListeAnzeigen
        '
        Me.ButtonListeAnzeigen.Location = New System.Drawing.Point(13, 116)
        Me.ButtonListeAnzeigen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonListeAnzeigen.Name = "ButtonListeAnzeigen"
        Me.ButtonListeAnzeigen.Size = New System.Drawing.Size(141, 31)
        Me.ButtonListeAnzeigen.TabIndex = 3
        Me.ButtonListeAnzeigen.Text = "Liste Aktualisieren"
        Me.ButtonListeAnzeigen.UseVisualStyleBackColor = True
        '
        'CheckAnsichtAendern
        '
        Me.CheckAnsichtAendern.AutoSize = True
        Me.CheckAnsichtAendern.Location = New System.Drawing.Point(1609, 123)
        Me.CheckAnsichtAendern.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckAnsichtAendern.Name = "CheckAnsichtAendern"
        Me.CheckAnsichtAendern.Size = New System.Drawing.Size(125, 21)
        Me.CheckAnsichtAendern.TabIndex = 14
        Me.CheckAnsichtAendern.Text = "Ansicht ändern"
        Me.CheckAnsichtAendern.UseVisualStyleBackColor = True
        Me.CheckAnsichtAendern.Visible = False
        '
        'ButtonListeLoeschen
        '
        Me.ButtonListeLoeschen.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonListeLoeschen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonListeLoeschen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonListeLoeschen.Location = New System.Drawing.Point(916, 116)
        Me.ButtonListeLoeschen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonListeLoeschen.Name = "ButtonListeLoeschen"
        Me.ButtonListeLoeschen.Size = New System.Drawing.Size(321, 30)
        Me.ButtonListeLoeschen.TabIndex = 15
        Me.ButtonListeLoeschen.Text = "Ausgewählte Elemente Löschen"
        Me.ButtonListeLoeschen.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(13, 169)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(901, 836)
        Me.ListBox1.TabIndex = 16
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Dateiname, Me.Dateigröße})
        Me.ListView1.FullRowSelect = True
        ListViewItem1.StateImageIndex = 0
        ListViewItem2.StateImageIndex = 0
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.ListView1.Location = New System.Drawing.Point(13, 164)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(901, 890)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Dateiname
        '
        Me.Dateiname.Text = "Dateiname"
        Me.Dateiname.Width = 580
        '
        'Dateigröße
        '
        Me.Dateigröße.Text = "Dateigröße MB"
        Me.Dateigröße.Width = 200
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(921, 164)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1000, 891)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'ButtonPfadAuswaehlen
        '
        Me.ButtonPfadAuswaehlen.Location = New System.Drawing.Point(459, 116)
        Me.ButtonPfadAuswaehlen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonPfadAuswaehlen.Name = "ButtonPfadAuswaehlen"
        Me.ButtonPfadAuswaehlen.Size = New System.Drawing.Size(155, 31)
        Me.ButtonPfadAuswaehlen.TabIndex = 19
        Me.ButtonPfadAuswaehlen.Text = "Dateipfad auswählen"
        Me.ButtonPfadAuswaehlen.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Foto wird Angepasst (Verzerrt)", "Automatische Größenanpassung", "Foto wird Zentral angezeigt"})
        Me.ComboBox1.Location = New System.Drawing.Point(1256, 118)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(284, 24)
        Me.ComboBox1.TabIndex = 20
        Me.ComboBox1.Text = "Foto wird Angepasst (Verzerrt)"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, -5)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(679, 98)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1072, 54)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Keine Markierung", "Rot", "Grün", "Blau", "Grau", "Gelb"})
        Me.ComboBox2.Location = New System.Drawing.Point(1256, 55)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(284, 24)
        Me.ComboBox2.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1936, 1065)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ButtonPfadAuswaehlen)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ButtonListeLoeschen)
        Me.Controls.Add(Me.CheckAnsichtAendern)
        Me.Controls.Add(Me.ButtonListeAnzeigen)
        Me.Controls.Add(Me.TextBoxDateiPfad)
        Me.Controls.Add(Me.CheckGeradeAnzeigen)
        Me.Controls.Add(Me.CheckBoxUngeradeAnzeige)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "SCR_Witten_P002"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxUngeradeAnzeige As CheckBox
    Friend WithEvents CheckGeradeAnzeigen As CheckBox
    Friend WithEvents TextBoxDateiPfad As TextBox
    Friend WithEvents ButtonListeAnzeigen As Button
    Friend WithEvents CheckAnsichtAendern As CheckBox
    Friend WithEvents ButtonListeLoeschen As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Dateiname As ColumnHeader
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Dateigröße As ColumnHeader
    Friend WithEvents ButtonPfadAuswaehlen As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox2 As ComboBox
End Class
