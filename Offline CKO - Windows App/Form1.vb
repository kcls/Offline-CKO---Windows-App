Imports System.ComponentModel
Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Xml
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        DatePicker.MinDate = DateTime.Now
        DatePicker.MaxDate = DateAdd("yyyy", 2, DateTime.Today)
        chk_Print_Receipt.Checked = My.Settings.Print_Receipt
        chk_Print_Staff_Receipt.Checked = My.Settings.Print_Staff_Receipt

        chk_strict_barcode.Checked = My.Settings.Strict_Barcode
        cboInstalledPrinters.Text = My.Settings.PrinterToUse
        PrinterToUse = My.Settings.PrinterToUse
        'If PrinterToUse = "" Then
        '  MsgBox("No printer configured for offline use.  If you have one, go to the settings page (gear) in the app and select it, otherwise select 'None'")
        'cboInstalledPrinters.Text = "None"
        'My.Settings.PrinterToUse = cboInstalledPrinters.Text

        '
        ' My.Settings.Save()
        '  PrinterToUse = "None"
        ' Else
        cboInstalledPrinters.Items.Add("None")
            For Each pkInstalledPrinters In
           PrinterSettings.InstalledPrinters
                cboInstalledPrinters.Items.Add(pkInstalledPrinters)
            Next pkInstalledPrinters
            cboInstalledPrinters.Text = PrinterToUse
            '  End If
            PresetDateChosen = True

        rdo28days.Checked = True
        StatusDate.Text = "Today: " & Date.Now.ToShortDateString

        ToolTip_Strict_Barcode.SetToolTip(chk_strict_barcode, "If checked, this will warn if entered barcodes don't match a predefined formula. Not typically used at KCLS")
        ToolTip_Print_Receipt.SetToolTip(chk_Print_Receipt, "If checked, will print the Patron Receipt")
        ToolTip_Print_Staff_Receipt.SetToolTip(chk_Print_Staff_Receipt, "If checked, will print the staff receipt with scannable barcodes for 'No Card' patron entry later")

    End Sub

    Private Sub DatePicker_ValueChanged(sender As Object, e As EventArgs) Handles DatePicker.ValueChanged

        DueDate = DatePicker.Value.Date
            Debug.Print(DueDate)

        If PresetDateChosen = False Then
            rdo_CustomDate.Checked = True


        End If


    End Sub

    Private Sub rdoToday_CheckedChanged(sender As Object, e As EventArgs) Handles rdoToday.CheckedChanged
        DueDate = DateTime.Now
        DatePicker.Value = DueDate
        PresetDateChosen = True
    End Sub

    Private Sub rdo7days_CheckedChanged(sender As Object, e As EventArgs) Handles rdo7days.CheckedChanged
        DueDate = DateAdd("d", 7, DateTime.Today)
        DatePicker.Value = DueDate
        PresetDateChosen = True
    End Sub

    Private Sub rdo28days_CheckedChanged(sender As Object, e As EventArgs) Handles rdo28days.CheckedChanged
        DueDate = DateAdd("d", 28, DateTime.Today)
        DatePicker.Value = DueDate
        PresetDateChosen = True
    End Sub

    Private Sub rdo14days_CheckedChanged(sender As Object, e As EventArgs) Handles rdo14days.CheckedChanged
        DueDate = DateAdd("d", 14, DateTime.Today)
        DatePicker.Value = DueDate
        PresetDateChosen = True
    End Sub

    Private Sub rdo21days_CheckedChanged(sender As Object, e As EventArgs) Handles rdo21days.CheckedChanged
        DueDate = DateAdd("d", 21, DateTime.Today)
        DatePicker.Value = DueDate
        PresetDateChosen = True
    End Sub

    Private Sub rdo42days_CheckedChanged(sender As Object, e As EventArgs) Handles rdo42days.CheckedChanged

        DueDate = DateAdd("d", 42, DateTime.Today)
        DatePicker.Value = DueDate
        PresetDateChosen = True
    End Sub

    Private Sub rdo1Year_CheckedChanged(sender As Object, e As EventArgs) Handles rdo1Year.CheckedChanged

        DueDate = DateAdd("yyyy", 1, DateTime.Today)
        DatePicker.Value = DueDate
        PresetDateChosen = True
    End Sub

    Private Sub rdo_CustomDate_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_CustomDate.CheckedChanged

    End Sub

    Private Sub DatePicker_Click(sender As Object, e As EventArgs) Handles DatePicker.Click
        PresetDateChosen = False

    End Sub

    Private Sub DatePicker_MouseClick(sender As Object, e As MouseEventArgs) Handles DatePicker.MouseClick
        PresetDateChosen = False
    End Sub

    Private Sub DatePicker_MouseDown(sender As Object, e As MouseEventArgs) Handles DatePicker.MouseDown
        PresetDateChosen = False
    End Sub

    Private Sub DatePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles DatePicker.KeyDown
        PresetDateChosen = False
    End Sub

    Private Sub txt_Patron_barcode_TextChanged(sender As Object, e As EventArgs) Handles txt_Patron_barcode.TextChanged
        If txt_item_barcode.Text = "" Then
            btn_Checkout.Enabled = False
        Else
            btn_Checkout.Enabled = True

        End If
        If txt_Patron_barcode.Text = "" Then btn_Checkout.Enabled = False

    End Sub

    Private Sub txt_item_barcode_TextChanged(sender As Object, e As EventArgs) Handles txt_item_barcode.TextChanged
        If txt_Patron_barcode.Text = "" Then
            btn_Checkout.Enabled = False
        Else
            btn_Checkout.Enabled = True
        End If
        If txt_item_barcode.Text = "" Then btn_Checkout.Enabled = False
    End Sub

    Private Sub txt_item_barcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_item_barcode.KeyPress
        If e.KeyChar = Chr(13) Then
            btn_Checkout.PerformClick()


        End If
    End Sub

    Private Sub txt_Patron_barcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Patron_barcode.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_item_barcode.Focus()


        End If
    End Sub

    Private Sub txt_Patron_barcode_LostFocus(sender As Object, e As EventArgs) Handles txt_Patron_barcode.LostFocus
        If chk_strict_barcode.Checked And PatronName = "" Then
            If VerifyBarcode(txt_Patron_barcode.Text) = False Then
                MsgBox("Patron Barcode strict check failed", vbOKOnly, "Patron Barcode Check Failed!")
            End If
        End If
    End Sub
    Private Shared Function VerifyBarcode(ByVal cardNumber As String) As Boolean
        ' ----- Given a barcode number, make sure it is valid. This method
        '       uses the Luhn algorithm to verify the number. This routine
        '       assumes that cardNumber contains only digits.
        Dim counter As Integer
        Dim digitTotal As Integer
        Dim holdValue As Integer
        Dim checkDigit As Integer
        Dim calcDigit As Integer
        Dim useCard As String

        ' ----- Perform some initial checks.
        useCard = Trim(cardNumber)
        If (IsNumeric(useCard) = False) Then Return False

        ' ----- Separate out the last digit, the check digit. For cards with
        '       an odd number of digits, prepend with a zero.
        If ((Len(useCard) Mod 2) <> 0) Then useCard = "0" & useCard
        checkDigit = useCard.Substring(Len(useCard) - 1, 1)
        useCard = useCard.Substring(0, Len(useCard) - 1)

        ' ----- Process each digit.
        digitTotal = 0
        For counter = 1 To Len(useCard)
            If ((counter Mod 2) = 1) Then
                ' ----- This is an odd digit position. Double the number.
                holdValue = CInt(Mid(useCard, counter, 1)) * 2
                If (holdValue > 9) Then
                    ' ----- Break the digits (e.g., 19 becomes 1+9).
                    digitTotal += (holdValue \ 10) + (holdValue - 10)
                Else
                    digitTotal += holdValue
                End If
            Else
                ' ----- This is an even digit position. Simply add it.
                digitTotal += CInt(Mid(useCard, counter, 1))
            End If
        Next counter

        ' ----- Calculate the 10's complement of both values.
        calcDigit = 10 - (digitTotal Mod 10)
        If (calcDigit = 10) Then calcDigit = 0
        If (checkDigit = calcDigit) Then Return True Else Return False
    End Function

    Private Sub btn_Checkout_Click(sender As Object, e As EventArgs) Handles btn_Checkout.Click
        Dim stamp As Integer
        Dim cko_time As String

        Dim myval


        If txt_Patron_barcode.Text = "" Then Exit Sub
        If txt_item_barcode.Text = "" Then Exit Sub

        If chk_strict_barcode.Checked Then
            If VerifyBarcode(txt_item_barcode.Text) = False Then
                myval = MsgBox("Item Strict Check failed " & vbCrLf & txt_item_barcode.Text & vbCrLf & "Use anyway?", vbYesNo, "Item Barcode Check Failed!")

                If myval = 7 Then
                    txt_item_barcode.Text = ""
                    Exit Sub

                End If

            End If
        End If

        Dim currDate As DateTime = DateTime.UtcNow

        Dim uTime As Double

        uTime = (currDate - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        stamp = Math.Floor(uTime)
        cko_time = currDate.ToString("yyyy-MM-ddTHH:mm:ssZ")

        Dim row As String() = New String() {txt_Patron_barcode.Text, txt_item_barcode.Text, DueDate, stamp, cko_time}

        dgv.Rows.Add(row)
        txt_item_barcode.Text = ""
        txt_Patron_barcode.Enabled = False
        btnNoCard.Enabled = False

        btn_Save_Transactions.Enabled = True

    End Sub

    Private Sub btnNoCard_Click(sender As Object, e As EventArgs) Handles btnNoCard.Click
        form_no_card.Show()
    End Sub

    Private Sub chk_strict_barcode_CheckedChanged(sender As Object, e As EventArgs) Handles chk_strict_barcode.CheckedChanged
        My.Settings.Strict_Barcode = chk_strict_barcode.Checked
        My.Settings.Save()

    End Sub

    Private Sub chk_Print_Receipt_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Print_Receipt.CheckedChanged
        My.Settings.Print_Receipt = chk_Print_Receipt.Checked
        My.Settings.Save()

        'If PrinterToUse = "None" Then
        '    If cboInstalledPrinters.Visible = False Then

        '        Dim pkInstalledPrinters As String
        '        cboInstalledPrinters.Visible = True
        '        lblPrinters.Visible = True


        '        ' Find all printers installed
        '        cboInstalledPrinters.Items.Add("None")
        '        For Each pkInstalledPrinters In
        '        PrinterSettings.InstalledPrinters
        '            cboInstalledPrinters.Items.Add(pkInstalledPrinters)
        '        Next pkInstalledPrinters

        '        ' Set the combo to the first printer in the list
        '        cboInstalledPrinters.Text = PrinterToUse

        '    Else

        '        cboInstalledPrinters.Visible = False
        '        lblPrinters.Visible = False

        '        My.Settings.PrinterToUse = cboInstalledPrinters.Text


        '        My.Settings.Save()


        '    End If
        'End If

        If chk_Print_Receipt.Checked = True Then
            lblPrinters.Visible = True
            cboInstalledPrinters.Visible = True
        Else
            cboInstalledPrinters.Visible = False
            lblPrinters.Visible = False

        End If

    End Sub

    Private Sub chk_Print_Receipt_Click(sender As Object, e As EventArgs) Handles chk_Print_Receipt.Click
        My.Settings.Print_Receipt = chk_Print_Receipt.Checked
        My.Settings.Save()

    End Sub

    Private Sub chk_strict_barcode_Click(sender As Object, e As EventArgs) Handles chk_strict_barcode.Click
        My.Settings.Strict_Barcode = chk_strict_barcode.Checked
        My.Settings.Save()

    End Sub

    Private Sub cboInstalledPrinters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInstalledPrinters.SelectedIndexChanged
        My.Settings.PrinterToUse = cboInstalledPrinters.Text
        PrinterToUse = cboInstalledPrinters.Text


        My.Settings.Save()

    End Sub

    Private Sub btn_Save_Transactions_Click(sender As Object, e As EventArgs) Handles btn_Save_Transactions.Click
        If dgv.RowCount = 0 Then
            NoCard = False
            txt_item_barcode.Text = ""
            txt_Patron_barcode.Text = ""
            PatronName = ""
            PatronDOB = ""
            PatronPhone = ""
            PatronNotes = ""
            txt_Patron_barcode.Enabled = True
            btnNoCard.Enabled = True
            Exit Sub
        End If
        txt_Patron_barcode.Enabled = True
        btnNoCard.Enabled = True


        Dim line As String = ""
        'MsgBox(DateTime.Now.ToString("MMM-dd-yyyy"))
        If NoCard = False Then
            FilePath = My.Computer.FileSystem.SpecialDirectories.Desktop & "\OFFLINE_TO_PROCESS_" & DateTime.Now.ToString("MMM-dd-yyyy") & ".txt"

            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(FilePath, True)


            For i = 0 To dgv.RowCount - 1

                '  MsgBox(Form1.dgv.Rows(i).Cells(1).Value.ToString)
                line = "{" & Chr(34) & "timestamp" & Chr(34) & ":" & dgv.Rows(i).Cells(3).Value.ToString & ","
                line = line & """type"":""checkout"",""delta"":0,"
                line = line & """patron_barcode"":""" & dgv.Rows(i).Cells(0).Value.ToString & ""","
                line = line & """barcode"":""" & dgv.Rows(i).Cells(1).Value.ToString & ""","
                '  line = line & """barcode"":""" & dgv.Rows(i).Cells(1).Value.ToString & ""","
                Dim oDate = Convert.ToDateTime(dgv.Rows(i).Cells(2).Value.ToString)
                Debug.Print(oDate.ToString("yyyy-MM-ddT" & "07" & ":mm:ssZ"))
                Dim offset2 As TimeSpan = TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow)
                Dim offsethour = Mid(offset2.ToString, 2, 2)

                line = line & """due_date"":""" & oDate.ToString("yyyy-MM-ddT" & offsethour & ":mm:ssZ") & ""","
                line = line & """checkout_time"":""" & dgv.Rows(i).Cells(4).Value.ToString & """}" & vbLf

                file.Write(line)


                'MsgBox(line)






            Next
            file.Close()
            ' statustext.text = "Last CKO " & DateTime.Now.ToString & "- saved to " & FilePath
            StatusText.Text = "Last CKO " & DateTime.Now.ToString & "- saved to " & FilePath
        End If

        dgv.Sort(dgv.Columns(2), ListSortDirection.Ascending)

        If NoCard = True Then
            FilePathNoCard = My.Computer.FileSystem.SpecialDirectories.Desktop & "\OFFLINE_MANUAL_ENTRY_" & DateTime.Now.ToString("MMM-dd-yyyy") & ".txt"
            Dim fileNoCard As System.IO.StreamWriter
            fileNoCard = My.Computer.FileSystem.OpenTextFileWriter(FilePathNoCard, True)
            line = "CKO Time:" & Date.Now.ToString & vbCrLf
            line = line & "Patron: " & PatronName & vbCrLf
            line = line & "DOB: " & PatronDOB & vbCrLf
            line = line & "Phone: " & PatronPhone & vbCrLf
            line = line & "Notes: " & Replace(PatronNotes, vbCrLf, " - ") & vbCrLf
            fileNoCard.Write(line)
            line = ""

            For i = 0 To dgv.RowCount - 1


                line = line & "Item: " & Replace(dgv.Rows(i).Cells(1).Value.ToString, vbTab, "") & vbCrLf
                line = line & "Due Date: " & dgv.Rows(i).Cells(2).Value.ToString & vbCrLf


                fileNoCard.Write(line)
                line = ""



                'MsgBox(line)






            Next
            fileNoCard.Write("-----------" & vbCrLf)

            fileNoCard.Close()
            StatusText.Text = "Last CKO " & DateTime.Now.ToString & "- saved to " & FilePathNoCard

        End If


        If chk_Print_Receipt.Checked And PrinterToUse <> "None" Then
            Dim pd As New PrintDoc()
            pd.PrinterSettings.PrinterName = PrinterToUse
            pd.PrintController = New StandardPrintController
            pd.Print()
        End If
        If NoCard = True And InStr(UCase(PrinterToUse), "EPSON") >= 1 And chk_Print_Staff_Receipt.Checked Then
            EPOSPrinter(PatronName & vbCrLf)
            EPOSPrinter(PatronDOB & vbCrLf)
            EPOSPrinter(PatronPhone & vbCrLf)
            EPOSPrinter(PatronNotes & vbCrLf)

            For i = 0 To dgv.RowCount - 1
                PrintString = "Due Date: " & dgv.Rows(i).Cells(2).Value.ToString & vbCrLf
                EPOSPrinter(PrintString)
                PrintString = GetBarcodeMulti(dgv.Rows(i).Cells(1).Value.ToString) + vbCrLf
                EPOSPrinter(PrintString)

            Next
            PrintString = getBarcodeStr("") & vbCrLf


            EPOSPrinter(PrintString)
            StatusText.Text = "Last CKO " & DateTime.Now.ToString & "- saved to " & FilePathNoCard

        End If


        dgv.Rows.Clear()
        txt_Patron_barcode.Text = ""
        txt_item_barcode.Text = ""
        btn_Checkout.Enabled = False
        NoCard = False

        rdo28days.Checked = True
        PatronName = ""
        PatronDOB = ""
        PatronPhone = ""
        PatronNotes = ""

    End Sub

    Public Sub EPOSPrinter(ByVal PrintString As String)

        RawPrinterHelper.SendStringToPrinter(PrinterToUse, PrintString)

    End Sub
    Public Function getBarcodeStr(ByVal msg As String) As String

        getBarcodeStr = GS & "h" & Chr(80) 'Bardcode Hieght
        getBarcodeStr = getBarcodeStr & GS & "w" & Chr(2) 'Barcode Width
        getBarcodeStr = getBarcodeStr & GS & "f" & Chr(0) 'Font for HRI characters
        getBarcodeStr = getBarcodeStr & GS & "H" & Chr(2) 'Position of HRI characters
        getBarcodeStr = getBarcodeStr & GS & "k" & Chr(69) & Chr(Len(msg)) 'Print Barcode Smb 39
        getBarcodeStr = getBarcodeStr & msg & Chr(0) & vbCrLf 'Print Text Under
        getBarcodeStr = getBarcodeStr & GS & "d" & Chr(3) & vbCrLf

        getBarcodeStr = getBarcodeStr & GS & "@"
        getBarcodeStr = getBarcodeStr & GS & vbCrLf

        getBarcodeStr = getBarcodeStr & GS & vbCrLf
        getBarcodeStr = getBarcodeStr & GS & "V" & Chr(1)

        Return getBarcodeStr
    End Function

    Public Function GetBarcodeMulti(ByVal msg As String) As String
        GetBarcodeMulti = GS & "h" & Chr(80) 'Bardcode Hieght
        GetBarcodeMulti = GetBarcodeMulti & GS & "w" & Chr(2) 'Barcode Width
        GetBarcodeMulti = GetBarcodeMulti & GS & "f" & Chr(0) 'Font for HRI characters
        GetBarcodeMulti = GetBarcodeMulti & GS & "H" & Chr(2) 'Position of HRI character
        GetBarcodeMulti = GetBarcodeMulti & GS & "k" & Chr(69) & Chr(Len(msg)) 'Print Barcode Smb 39
        GetBarcodeMulti = GetBarcodeMulti & msg & Chr(0) & vbCrLf 'Print Text Under
        GetBarcodeMulti = GetBarcodeMulti & GS & "d" & Chr(3) & vbCrLf

        GetBarcodeMulti = GetBarcodeMulti & GS & "@"
        GetBarcodeMulti = GetBarcodeMulti & GS & vbCrLf

        GetBarcodeMulti = GetBarcodeMulti & GS & vbCrLf
        Return GetBarcodeMulti
    End Function

    Private Sub rdo_CustomDate_Click(sender As Object, e As EventArgs) Handles rdo_CustomDate.Click
        DatePicker.Select()


        SendKeys.Send("%{DOWN}")



    End Sub

    Private Sub chk_Print_Staff_Receipt_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Print_Staff_Receipt.CheckedChanged
        My.Settings.Print_Staff_Receipt = chk_Print_Staff_Receipt.Checked
        My.Settings.Save()
        If chk_Print_Staff_Receipt.Checked = True Then
            lblPrinters.Visible = True
            cboInstalledPrinters.Visible = True
        Else
            cboInstalledPrinters.Visible = False
            lblPrinters.Visible = False

        End If

    End Sub

    Private Sub chk_Print_Staff_Receipt_Click(sender As Object, e As EventArgs) Handles chk_Print_Staff_Receipt.Click
        My.Settings.Print_Staff_Receipt = chk_Print_Staff_Receipt.Checked
        My.Settings.Save()
    End Sub
End Class
Public Class PrintDoc
    Inherits PrintDocument

    Protected Overrides Sub OnPrintPage(ByVal e As PrintPageEventArgs)
        MyBase.OnPrintPage(e)
        Dim printstr As String = ""
        Dim bcstring As String = ""

        ' Draw text to the printer graphics device.
        Dim fnt As New Font("Arial", 10, FontStyle.Regular,
         GraphicsUnit.Point)
        Dim yPos As Single = 20
        If NoCard = False Then
            printstr = "Patron ending in .." & Right(Form1.txt_Patron_barcode.Text, 4)
        Else

            printstr = "Patron ending in .." & Right(Form1.txt_Patron_barcode.Text, 6)
        End If

        e.Graphics.DrawString(printstr, fnt, Brushes.Black, 5, yPos)
        yPos += e.Graphics.MeasureString(printstr, fnt).Height
        yPos += e.Graphics.MeasureString(printstr, fnt).Height
        printstr = "Item Barcode" & vbTab & vbTab & "Due Date"
        e.Graphics.DrawString(printstr, fnt, Brushes.Black, 5, yPos)
        yPos += e.Graphics.MeasureString(printstr, fnt).Height

        For i = 0 To Form1.dgv.RowCount - 1

            '  MsgBox(Form1.dgv.Rows(i).Cells(1).Value.ToString)
            printstr = Form1.dgv.Rows(i).Cells(1).Value.ToString
            Select Case Len(printstr)
                Case 1 To 6
                    printstr += vbTab & vbTab & vbTab

                Case 7 To 12
                    printstr += vbTab & vbTab
                Case 12 To 16
                    printstr += vbTab


                Case Else
                    printstr += vbTab
            End Select

            printstr += Form1.dgv.Rows(i).Cells(2).Value.ToString()

            e.Graphics.DrawString(printstr, fnt, Brushes.Black, 5, yPos)
            yPos += e.Graphics.MeasureString(printstr, fnt).Height


        Next
        printstr = vbCrLf & vbCrLf & DateTime.Now.ToString
        e.Graphics.DrawString(printstr, fnt, Brushes.Black, 5, yPos)
        ' e.Graphics.DrawString("Hello, Printer!", fnt, Brushes.Black, 0, 0)
        fnt.Dispose()

        ' Indicate that there are no more pages.
        e.HasMorePages = False
    End Sub

End Class

Public Class RawPrinterHelper
    ' Structure and API declarions:
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Structure DOCINFOW
        <MarshalAs(UnmanagedType.LPWStr)> Public pDocName As String
        <MarshalAs(UnmanagedType.LPWStr)> Public pOutputFile As String
        <MarshalAs(UnmanagedType.LPWStr)> Public pDataType As String
    End Structure

    <DllImport("winspool.Drv", EntryPoint:="OpenPrinterW",
       SetLastError:=True, CharSet:=CharSet.Unicode,
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function OpenPrinter(ByVal src As String, ByRef hPrinter As IntPtr, ByVal pd As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="ClosePrinter",
       SetLastError:=True, CharSet:=CharSet.Unicode,
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterW",
       SetLastError:=True, CharSet:=CharSet.Unicode,
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32, ByRef pDI As DOCINFOW) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter",
       SetLastError:=True, CharSet:=CharSet.Unicode,
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter",
       SetLastError:=True, CharSet:=CharSet.Unicode,
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter",
       SetLastError:=True, CharSet:=CharSet.Unicode,
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="WritePrinter",
       SetLastError:=True, CharSet:=CharSet.Unicode,
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Int32, ByRef dwWritten As Int32) As Boolean
    End Function

    ' SendBytesToPrinter()
    ' When the function is given a printer name and an unmanaged array of  
    ' bytes, the function sends those bytes to the print queue.
    ' Returns True on success or False on failure.
    Public Shared Function SendBytesToPrinter(ByVal szPrinterName As String, ByVal pBytes As IntPtr, ByVal dwCount As Int32) As Boolean
        Dim hPrinter As IntPtr      ' The printer handle.
        Dim dwError As Int32        ' Last error - in case there was trouble.
        Dim di As DOCINFOW          ' Describes your document (name, port, data type).
        Dim dwWritten As Int32      ' The number of bytes written by WritePrinter().
        Dim bSuccess As Boolean     ' Your success code.

        ' Set up the DOCINFO structure.
        With di
            .pDocName = "My Visual Basic .NET RAW Document"
            .pDataType = "RAW"
        End With
        ' Assume failure unless you specifically succeed.
        bSuccess = False
        If OpenPrinter(szPrinterName, hPrinter, IntPtr.Zero) Then
            If StartDocPrinter(hPrinter, 1, di) Then
                If StartPagePrinter(hPrinter) Then
                    ' Write your printer-specific bytes to the printer.
                    bSuccess = WritePrinter(hPrinter, pBytes, dwCount, dwWritten)
                    EndPagePrinter(hPrinter)
                End If
                EndDocPrinter(hPrinter)
            End If
            ClosePrinter(hPrinter)
        End If
        ' If you did not succeed, GetLastError may give more information
        ' about why not.
        If bSuccess = False Then
            dwError = Marshal.GetLastWin32Error()
        End If
        Return bSuccess
    End Function ' SendBytesToPrinter()

    ' SendFileToPrinter()
    ' When the function is given a file name and a printer name, 
    ' the function reads the contents of the file and sends the
    ' contents to the printer.
    ' Presumes that the file contains printer-ready data.
    ' Shows how to use the SendBytesToPrinter function.
    ' Returns True on success or False on failure.
    Public Shared Function SendFileToPrinter(ByVal szPrinterName As String, ByVal szFileName As String) As Boolean
        ' Open the file.
        Dim fs As New FileStream(szFileName, FileMode.Open)
        ' Create a BinaryReader on the file.
        Dim br As New BinaryReader(fs)
        ' Dim an array of bytes large enough to hold the file's contents.
        Dim bytes(fs.Length) As Byte
        Dim bSuccess As Boolean
        ' Your unmanaged pointer.
        Dim pUnmanagedBytes As IntPtr

        ' Read the contents of the file into the array.
        bytes = br.ReadBytes(fs.Length)
        ' Allocate some unmanaged memory for those bytes.
        pUnmanagedBytes = Marshal.AllocCoTaskMem(fs.Length)
        ' Copy the managed byte array into the unmanaged array.
        Marshal.Copy(bytes, 0, pUnmanagedBytes, fs.Length)
        ' Send the unmanaged bytes to the printer.
        bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, fs.Length)
        ' Free the unmanaged memory that you allocated earlier.
        Marshal.FreeCoTaskMem(pUnmanagedBytes)
        Return bSuccess
    End Function ' SendFileToPrinter()

    ' When the function is given a string and a printer name,
    ' the function sends the string to the printer as raw bytes.
    Public Shared Function SendStringToPrinter(ByVal szPrinterName As String, ByVal szString As String)
        Dim pBytes As IntPtr
        Dim dwCount As Int32
        ' How many characters are in the string?
        dwCount = szString.Length()
        ' Assume that the printer is expecting ANSI text, and then convert
        ' the string to ANSI text.
        pBytes = Marshal.StringToCoTaskMemAnsi(szString)
        ' Send the converted ANSI string to the printer.
        SendBytesToPrinter(szPrinterName, pBytes, dwCount)
        Marshal.FreeCoTaskMem(pBytes)
    End Function

End Class
