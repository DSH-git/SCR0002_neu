Public Class Form1
    'Hier beginnt der Code von neuem

    Private Sub ButtonListeAnzeigen_Click(sender As Object, e As EventArgs) Handles ButtonListeAnzeigen.Click
        ListView1.Items.Clear()
        ListBox1.Items.Clear()

        Try
            '-----------------------------------Fragt nach dem Dateityp .jpg ab---------------------------------------------------------------------
            Dim myDict As New Dictionary(Of String, String) 'Dictonary erstellen um Sortieren zu können
            For Each Datei As String In My.Computer.FileSystem.GetFiles(TextBoxDateiPfad.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
                Dim DateiSize As String = My.Computer.FileSystem.GetFileInfo(Datei).Length 'Fragt die Dateigröße der Datei ab
                DateiSize = Math.Round(DateiSize / 1000000, 2) 'DateiSize / 1000000 'Rechnet Bytes in MB um und Rundet auf zwei Nachkommastellen
                myDict.Add(Datei, DateiSize) 'Fügt den Dateipfad mit der Dateigröße an
            Next
            '-----------------------------------Fragt nach dem Dateityp .tif ab---------------------------------------------------------------------
            For Each Dateitif As String In My.Computer.FileSystem.GetFiles(TextBoxDateiPfad.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.tif")
                Dim DateiSizetif As String = My.Computer.FileSystem.GetFileInfo(Dateitif).Length 'Fragt die Dateigröße der Datei ab
                DateiSizetif = Math.Round(DateiSizetif / 1000000, 2) 'DateiSize / 1000000 'Rechnet Bytes in MB um und Rundet auf zwei Nachkommastellen
                myDict.Add(Dateitif, DateiSizetif) 'Fügt den Dateipfad mit der Dateigröße an
            Next

            Dim sortedDict = (From entry In myDict Order By entry.Value Ascending).ToDictionary(Function(pair) pair.Key, Function(pair) pair.Value) 'Hier wird festgelegt wonach sortiert werden soll


            For Each entry As KeyValuePair(Of String, String) In sortedDict
                If CheckBoxUngeradeAnzeige.Checked = True Then 'Abfrage nach Checkbox1 auf Ungerade

                    Select Case entry.Key.Substring(entry.Key.Length - 5, 1) 'Fragt nach ungeraden Dateiendungen ab
                        Case 1
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case 3
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case 5
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case 7
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case 9
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case Else
                    End Select

                Else
                End If
                If CheckGeradeAnzeigen.Checked = True Then 'Abfrage nach Checkbox2 auf Gerade

                    Select Case entry.Key.Substring(entry.Key.Length - 5, 1) 'Fragt nach ungeraden Dateiendungen ab
                        Case 0
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case 2
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case 4
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case 6
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case 8
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case Else
                    End Select

                Else
                End If

            Next

        Catch
            MsgBox("Bitte erst einen Ordner auswählen")
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            Dim pfad As String = ListView1.SelectedItems.Item(0).Text

            Dim myStream As System.IO.FileStream = New System.IO.FileStream(pfad, IO.FileMode.Open)
            Dim myImage As Image = Image.FromStream(myStream)
            myStream.Close()
            PictureBox1.Image = myImage
        Catch

        End Try
    End Sub

    Private Sub ListView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListView1.KeyPress
        'Hier wird das ausgewählte Element gefärbt und in eine Listbox kopiert
        Dim Markierfarbe As String

        If ComboBox2.SelectedItem = "Keine Markierung" Then
            Markierfarbe = "white"
        End If
        If ComboBox2.SelectedItem = "Rot" Then
            Markierfarbe = "red"
        End If
        If ComboBox2.SelectedItem = "Grün" Then
            Markierfarbe = "green"
        End If
        '------> Wenn eine Datei bereits Markiert ist also Haken gesetzt ist nicht noch einmal kopieren!!!!!!!!!!!!!!!!!!!!!!!!!!
        If ListView1.SelectedItems(0).Checked = True Then 'Hier wird überprüft ob die Datei bereits in der Liste enthalen ist. Wenn nicht dann wird diese hinzugeügt
            Dim Source As String = ListView1.SelectedItems(0).ToString
            Source = Source.Substring(15)
            Source = Source.Substring(0, Source.Length - 1)
            ListBox1.Items.Add(Source)
            If ComboBox2.SelectedItem = "Keine Markierung" Then
                ListView1.SelectedItems(0).BackColor = Color.White
            End If
            If ComboBox2.SelectedItem = "Rot" Then
                ListView1.SelectedItems(0).BackColor = Color.Red
            End If
            If ComboBox2.SelectedItem = "Grün" Then
                ListView1.SelectedItems(0).BackColor = Color.Green
            End If
            If ComboBox2.SelectedItem = "Blau" Then
                ListView1.SelectedItems(0).BackColor = Color.Blue
            End If
            If ComboBox2.SelectedItem = "Grau" Then
                ListView1.SelectedItems(0).BackColor = Color.Gray
            End If
            If ComboBox2.SelectedItem = "Gelb" Then
                ListView1.SelectedItems(0).BackColor = Color.Yellow
            End If
        Else 'Wenn die Datei bereits in der Liste ist, wird diese wieder gelöscht.
            'Hier wird die bereits in die Listbox1 (Zu löschende Elemente) hinzugefügte Datei wieder aus der Liste entfernt
            Dim Source As String = ListView1.SelectedItems(0).ToString
            Source = Source.Substring(15)
            Source = Source.Substring(0, Source.Length - 1)
            ListBox1.Items.Remove(Source)
            ListView1.SelectedItems(0).BackColor = Color.White
        End If
    End Sub

    Private Sub CheckAnsichtAendern_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAnsichtAendern.CheckedChanged
        If CheckAnsichtAendern.Checked = True Then
            ListView1.Visible = False
        Else
            ListView1.Visible = True
        End If
    End Sub

    Private Sub ButtonListeLoeschen_Click(sender As Object, e As EventArgs) Handles ButtonListeLoeschen.Click
        'Hier werden alle in der Listbox enthaltenen Dateien in .rue umbenannt
        Dim i As Integer

        For i = 0 To ListBox1.Items.Count() - 1
            '
            Dim dest As String = ListBox1.Items(i)
            Dim del As String = ListBox1.Items(i)
            dest = dest.Substring(0, dest.Length - 3) + "rue"


            Try
                System.IO.File.Copy(ListBox1.Items(i), dest, True)
                Kill(del) 'Datei löschen ( Fehler liegt bei dem Zwischenspeicher vom Bilder anzeigen.
            Catch
                MsgBox("Die Dateien sind bereits in RUE Dateien konvertiert")
            End Try
            'My.Computer.FileSystem.RenameFile(ListBox1.Items(i), dest)




        Next
        'Nachdem alle Dateien Umbenannt wurden soll die Seite neu aufgebaut werden
        ListView1.Items.Clear()
        Try
            '-----------------------------------Fragt nach dem Dateityp .jpg ab---------------------------------------------------------------------
            Dim myDict As New Dictionary(Of String, String) 'Dictonary erstellen um Sortieren zu können
            For Each Datei As String In My.Computer.FileSystem.GetFiles(TextBoxDateiPfad.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
                Dim DateiSize As String = My.Computer.FileSystem.GetFileInfo(Datei).Length 'Fragt die Dateigröße der Datei ab
                DateiSize = Math.Round(DateiSize / 1000000, 2) 'DateiSize / 1000000 'Rechnet Bytes in MB um und Rundet auf zwei Nachkommastellen
                myDict.Add(Datei, DateiSize) 'Fügt den Dateipfad mit der Dateigröße an
            Next
            '-----------------------------------Fragt nach dem Dateityp .tif ab---------------------------------------------------------------------
            For Each Dateitif As String In My.Computer.FileSystem.GetFiles(TextBoxDateiPfad.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.tif")
                Dim DateiSizetif As String = My.Computer.FileSystem.GetFileInfo(Dateitif).Length 'Fragt die Dateigröße der Datei ab
                DateiSizetif = Math.Round(DateiSizetif / 1000000, 2) 'DateiSize / 1000000 'Rechnet Bytes in MB um und Rundet auf zwei Nachkommastellen
                myDict.Add(Dateitif, DateiSizetif) 'Fügt den Dateipfad mit der Dateigröße an
            Next

            Dim sortedDict = (From entry In myDict Order By entry.Value Ascending).ToDictionary(Function(pair) pair.Key, Function(pair) pair.Value) 'Hier wird festgelegt wonach sortiert werden soll


            For Each entry As KeyValuePair(Of String, String) In sortedDict
                If CheckBoxUngeradeAnzeige.Checked = True Then 'Abfrage nach Checkbox1 auf Ungerade

                    Select Case entry.Key.Substring(entry.Key.Length - 5, 1) 'Fragt nach ungeraden Dateiendungen ab
                        Case 1
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case 3
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case 5
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case 7
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case 9
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case Else
                    End Select

                Else
                End If
                If CheckGeradeAnzeigen.Checked = True Then 'Abfrage nach Checkbox2 auf Gerade

                    Select Case entry.Key.Substring(entry.Key.Length - 5, 1) 'Fragt nach ungeraden Dateiendungen ab
                        Case 0
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case 2
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case 4
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case 6
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case 8
                            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
                            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
                            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
                            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
                        Case Else
                    End Select

                Else
                End If

            Next

        Catch
            MsgBox("Bitte erst einen Ordner auswählen")
        End Try
        ListBox1.Items.Clear()
    End Sub

    Private Sub ButtonPfadAuswaehlen_Click(sender As Object, e As EventArgs) Handles ButtonPfadAuswaehlen.Click
        'Hier wird der Dateipfad ausgewählt
        Dim FolderBrowser As FolderBrowserDialog = New FolderBrowserDialog

        FolderBrowser.ShowDialog()

        TextBoxDateiPfad.Text = FolderBrowser.SelectedPath
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Hier kann ausgewählt werden, welcher Anzeigemodus verwendet werden soll
        If ComboBox1.SelectedItem = "Automatische Größenanpassung" Then
            PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        End If
        If ComboBox1.SelectedItem = "Foto wird Angepasst (Verzerrt)" Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If ComboBox1.SelectedItem = "Foto wird Zentral angezeigt" Then
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

    End Sub

    Private Sub ListView1_ItemChecked(sender As Object, e As ItemCheckedEventArgs)

    End Sub

    Private Sub ListView1_ItemCheck(sender As Object, e As ItemCheckEventArgs)

    End Sub

    Private Sub ListView1_ItemCheck_1(sender As Object, e As ItemCheckEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListView1.Items.Clear()
        Dim myDict As New Dictionary(Of String, String) 'Dictonary erstellen um Sortieren zu können
        For Each Datei As String In My.Computer.FileSystem.GetFiles(TextBoxDateiPfad.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
            Dim DateiSize As String = My.Computer.FileSystem.GetFileInfo(Datei).Length 'Fragt die Dateigröße der Datei ab
            DateiSize = Math.Round(DateiSize / 1000000, 2) 'DateiSize / 1000000 'Rechnet Bytes in MB um und Rundet auf zwei Nachkommastellen

            myDict.Add(Datei, DateiSize)
        Next


        Dim sortedDict = (From entry In myDict Order By entry.Value Ascending).ToDictionary(Function(pair) pair.Key, Function(pair) pair.Value) 'Hier wird festgelegt wonach sortiert werden soll

        For Each entry As KeyValuePair(Of String, String) In sortedDict
            Dim lwi As New ListViewItem() 'Erstellt ein anfügbares List Item
            lwi.Text = entry.Key 'Fügt den Dateipfad dem Item an
            lwi.SubItems.Add(entry.Value) 'String.Format("{0,10} {1,10}", entry.Key, entry.Value)) 'Fügt der Datei für die zweite Spalte die Dateigröße an
            ListView1.Items.Add(lwi) 'Fügt das List Item der Listbox zu
            'Console.WriteLine(String.Format("{0,10} {1,10}", entry.Key, entry.Value))
        Next
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim Markierfarbe As String

        If ComboBox1.SelectedItem = "Keine Markierung" Then
            Markierfarbe = "white"
        End If
        If ComboBox1.SelectedItem = "Rot" Then
            Markierfarbe = "red"
        End If
        If ComboBox1.SelectedItem = "Grün" Then
            Markierfarbe = "green"
        End If

    End Sub
End Class
