Imports System.Drawing
Imports DAL1
Imports System.ComponentModel
Imports System.Drawing.Printing
Imports Microsoft.Office.Interop.Word
Imports System.Windows.Forms

Public Class KanbanPrinting
    Public PN As String
    Public kanbanLocation As String
    Public yellowID As String
    Public redID As String
    Public replStrat As String
    Public binSize As Integer
    Public description As String
    Public numCards As Integer = 1
    Public multiple As Integer = 0
    Public bundleInfo As DataRowCollection

    Private Sub KanbanPrinting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDefaultPrinter()
        Timer1.Start()
    End Sub

    Private Sub btnChangePrinter_Click(sender As Object, e As EventArgs) Handles btnChangePrinter.Click
        Try
            PrintDialog1.ShowDialog()
            Dim activePrinter = PrintDialog1.PrinterSettings.PrinterName
            lblActivePrinter.Text = "Active Printer: " & activePrinter
        Catch ex As Exception
            MsgBox("Error when attempting to change the active printer: " & ex.Message)
        End Try

    End Sub

    Public Sub GetDefaultPrinter()
        Try
            Dim activePrinter = PrintDialog1.PrinterSettings.PrinterName
            lblActivePrinter.Text &= activePrinter
        Catch ex As Exception
            MsgBox("Error retrieving the computer's default printer: " & ex.Message)
        End Try

    End Sub

    Private Sub btnPrintOne_Click(sender As Object, e As EventArgs) Handles btnPrintOne.Click
        Try
            PN = TextPN.Text
            kanbanLocation = TextLocation.Text

            If PN = "" Or kanbanLocation = "" Then
                MsgBox("You must provide a partnumber and a location!")
                Exit Sub
            End If
            PrintingThread.RunWorkerAsync()
        Catch ex As Exception
            MsgBox("Error beginning the printer process: " & ex.Message)
        End Try

    End Sub

    Private Sub btnPrintBundle_Click(sender As Object, e As EventArgs) Handles btnPrintBundle.Click
        Try
            kanbanLocation = TextBundleLocation.Text

            If kanbanLocation = "" Then
                MsgBox("You must provide a location!")
                Exit Sub
            End If

            bundleInfo = DatabaseQueries.GetBundleKanbanInfo(kanbanLocation)

            If bundleInfo Is Nothing Then
                MsgBox("The location you entered may be invalid, make sure you typed in a valid kanban location")
                Exit Sub
            End If

            BundlePrintingThread.RunWorkerAsync()
        Catch ex As Exception
            MsgBox("Error when trying to create the bundle preview")
        End Try

    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            'Add a loop statement here that will loop until all cards in a location are printed
            Dim count = 0
            While count < numCards
                If numCards <> 1 Then
                    ChangeActiveCard(count, multiple)
                End If
                Dim extra As Integer = (count) * 215
                Dim Barcode As New System.Drawing.Font("IDAHC39M Code 39 Barcode", 9, FontStyle.Regular)
                Dim Title = New Drawing.Font("Arial", 9, FontStyle.Bold)
                Dim partNum = New Drawing.Font("Arial", 18, FontStyle.Bold)
                Dim Body = New Drawing.Font("Arial", 7, FontStyle.Regular)

                Dim blackPen As New Pen(Brushes.Black)
                Dim redPen As New Pen(Brushes.Red)
                Dim yellowPen As New Pen(Brushes.Yellow)
                Dim whitePen As New Pen(Brushes.White)
                Dim redRec As New System.Drawing.Rectangle(70, 50 + extra, 50, 200)
                Dim mainRec As New System.Drawing.Rectangle(120, 50 + extra, 230, 200)
                Dim yellowRec As New System.Drawing.Rectangle(350, 50 + extra, 50, 200)
                Dim whiteRec As New System.Drawing.Rectangle(74, 100 + extra, 44, 96)
                Dim whiteRec2 As New System.Drawing.Rectangle(354, 100 + extra, 44, 96)

                e.Graphics.DrawRectangle(redPen, redRec)
                e.Graphics.DrawRectangle(blackPen, mainRec)
                e.Graphics.DrawRectangle(yellowPen, yellowRec)
                e.Graphics.DrawRectangle(whitePen, whiteRec)
                e.Graphics.DrawRectangle(whitePen, whiteRec2)

                e.Graphics.FillRectangle(Brushes.Red, redRec)
                e.Graphics.FillRectangle(Brushes.Yellow, yellowRec)
                e.Graphics.FillRectangle(Brushes.White, whiteRec)
                e.Graphics.FillRectangle(Brushes.White, whiteRec2)



                If description.Length > 29 Then
                    e.Graphics.DrawString("DESC: ", Title, Brushes.Black, 121, 95 + extra)
                    e.Graphics.DrawString("Kanban Qty: ", Title, Brushes.Black, 121, 145 + extra)
                    e.Graphics.DrawString("Supply Area: ", Title, Brushes.Black, 121, 175 + extra)
                    e.Graphics.DrawString("Repl Strat: ", Title, Brushes.Black, 121, 205 + extra)

                    e.Graphics.DrawString(PN, partNum, Brushes.Black, 135, 57 + extra)
                    e.Graphics.DrawString(description.Substring(0, 29), Body, Brushes.Black, 161, 97 + extra)
                    e.Graphics.DrawString(description.Substring(29, description.Length - 29), Body, Brushes.Black, 161, 117 + extra)
                    e.Graphics.DrawString(binSize, Body, Brushes.Black, 197, 147 + extra)
                    e.Graphics.DrawString(kanbanLocation, Body, Brushes.Black, 197, 177 + extra)
                    If replStrat.Length > 30 Then
                        e.Graphics.DrawString(replStrat.Substring(0, 30), Body, Brushes.Black, 185, 207 + extra)
                        e.Graphics.DrawString(replStrat.Substring(30, replStrat.Length - 30), Body, Brushes.Black, 185, 227 + extra)
                    Else
                        e.Graphics.DrawString(replStrat, Body, Brushes.Black, 185, 207 + extra)
                    End If

                Else
                    e.Graphics.DrawString("DESC: ", Title, Brushes.Black, 121, 95 + extra)
                    e.Graphics.DrawString("Kanban Qty: ", Title, Brushes.Black, 121, 125 + extra)
                    e.Graphics.DrawString("Supply Area: ", Title, Brushes.Black, 121, 155 + extra)
                    e.Graphics.DrawString("Repl Strat: ", Title, Brushes.Black, 121, 185 + extra)

                    e.Graphics.DrawString(PN, partNum, Brushes.Black, 135, 57 + extra)
                    e.Graphics.DrawString(description, Body, Brushes.Black, 161, 97 + extra)
                    e.Graphics.DrawString(binSize, Body, Brushes.Black, 197, 127 + extra)
                    e.Graphics.DrawString(kanbanLocation, Body, Brushes.Black, 197, 157 + extra)
                    If replStrat.Length > 30 Then
                        e.Graphics.DrawString(replStrat.Substring(0, 30), Body, Brushes.Black, 185, 187 + extra)
                        e.Graphics.DrawString(replStrat.Substring(30, replStrat.Length - 30), Body, Brushes.Black, 185, 207 + extra)
                    Else
                        e.Graphics.DrawString(replStrat, Body, Brushes.Black, 185, 187 + extra)
                    End If
                End If

                e.Graphics.TranslateTransform(200, 300 + extra)
                e.Graphics.RotateTransform(-90)
                e.Graphics.DrawString("*" & redID & "*", Barcode, Brushes.Black, 105, -127) '65, 120)

                e.Graphics.DrawString("*" & yellowID & "*", Barcode, Brushes.Black, 105, 154) '390, 120)
                e.Graphics.RotateTransform(90)
                e.Graphics.TranslateTransform(-200, -300 - extra)

                count += 1
            End While
        Catch ex As Exception
            MsgBox("Error while generating the document: " & ex.Message)
            Exit Sub
        End Try


    End Sub

    Private Sub PrintingThread_DoWork(sender As Object, e As DoWorkEventArgs) Handles PrintingThread.DoWork
        Try
            Dim kanbanInfo As DataRowCollection = DatabaseQueries.GetKanbanInfo(PN, kanbanLocation)

            description = DatabaseQueries.GetDescription(PN)

            If kanbanInfo Is Nothing Or description Is Nothing Then
                MsgBox("Something went wrong when searching for that partnumber, make sure it is valid on SAP before continuing", "Error")
                Exit Sub
            End If

            yellowID = kanbanInfo(0).Item(0).ToString.Trim()
            redID = kanbanInfo(1).Item(0).ToString.Trim()
            replStrat = kanbanInfo(0).Item(1).ToString.Trim()
            binSize = kanbanInfo(0).Item(2)

            PrintPreviewControl1.Document = PrintDocument1
        Catch ex As Exception
            MsgBox("Error retrieving kanban information from the database: " & ex.Message)
        End Try
    End Sub

    Private Sub BundlePrintingThread_DoWork(sender As Object, e As DoWorkEventArgs) Handles BundlePrintingThread.DoWork
        Try
            Dim count2 = 0
            While count2 < bundleInfo.Count
                Console.WriteLine(bundleInfo(count2).Item(0) & bundleInfo(count2).Item(1) & bundleInfo(count2).Item(2) & bundleInfo(count2).Item(3) & bundleInfo(count2).Item(4))
                count2 += 1
            End While
            If bundleInfo.Count >= 4 Then
                numCards = 4
                Dim count As Integer = 0
                While count < bundleInfo.Count - 3
                    PrintPreviewControl1.Document = PrintDocument1
                    Threading.Thread.Sleep(250)
                    Dim response = MsgBox("Do you want to print this document?", vbYesNo)
                    If response = MsgBoxResult.Yes Then
                        PrintDocument1.Print()
                    End If
                    Threading.Thread.Sleep(250)
                    Dim response2 = MsgBox("Do you want to continue?", vbYesNo)
                    If response2 = vbNo Then
                        multiple = 0
                        numCards = 1
                        Exit Sub
                    End If
                    count += 8
                    multiple += 1
                End While
                numCards = (bundleInfo.Count Mod 4) / 2
                ChangeActiveCard(0, multiple)
                PrintPreviewControl1.Document = PrintDocument1
                PrintDocument1.Print()
            Else
                numCards = bundleInfo.Count
                ChangeActiveCard(0, multiple)
                PrintPreviewControl1.Document = PrintDocument1
                Dim response = MsgBox("Do you want to print this document?", vbYesNo)
                If response = MsgBoxResult.Yes Then
                    PrintDocument1.Print()
                End If
            End If

            multiple = 0
            numCards = 1
        Catch ex As Exception
            MsgBox("Error while trying to generate the bundle: " & ex.Message)
        End Try
    End Sub

    Public Sub ChangeActiveCard(count As Integer, multiple As Integer)
        If bundleInfo((multiple * 8) + (count * 2)).Item(0).ToString.Trim() <> bundleInfo((multiple * 8) + (count * 2) + 1).Item(0).ToString.Trim() Then
            bundleInfo((multiple * 8) + (count * 2)).Delete()
            bundleInfo((multiple * 8) + (count * 2)).AcceptChanges()
            ChangeActiveCard(count, multiple)
            Exit Sub
        End If
        PN = bundleInfo((multiple * 8) + (count * 2)).Item(0).ToString.Trim()
        yellowID = bundleInfo((multiple * 8) + (count * 2)).Item(1).ToString.Trim()
        redID = bundleInfo((multiple * 8) + (count * 2) + 1).Item(1).ToString.Trim()
        replStrat = bundleInfo((multiple * 8) + (count * 2)).Item(2).ToString.Trim()
        binSize = bundleInfo((multiple * 8) + (count * 2)).Item(3)
        description = DatabaseQueries.GetDescription(PN)

    End Sub

    Private Sub btnRealPrint_Click(sender As Object, e As EventArgs) Handles btnRealPrint.Click
        Try
            If PrintPreviewControl1.Document Is Nothing Then
                MsgBox("Nothing has been prepared to print yet")
                Exit Sub
            End If
            Dim answer = MsgBox("Does the preview look good?", vbYesNo)
            If answer = vbYes Then
                PrintDocument1.Print()
            End If
        Catch ex As Exception
            MsgBox("Error printing the document: " & ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If PrintingThread.IsBusy() Or BundlePrintingThread.IsBusy() Then
            PreviewingLbl.Text = "Generating Preview..."
        Else
            PreviewingLbl.Text = Nothing
        End If
        Timer1.Start()
    End Sub

End Class
