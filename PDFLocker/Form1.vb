Imports System.Windows.Forms.OpenFileDialog
Imports System.Windows.Forms.FolderBrowserDialog
Imports System.IO
Imports System.Diagnostics
Imports com.itextpdf.text.pdf
Imports iTextSharp.text.pdf




Public Class Strt

    Dim filepath As String
    Dim filename As String
    Dim dest As String
    Dim dir As String
    Dim ext As String
    Dim num As Integer
    Dim temp As String
    Dim files() As String
    Dim fpath() As String
    Dim passy() As String






    Private Sub slct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slct.Click
        table.Rows.Clear()

        Dim dlog As New OpenFileDialog

        dlog.DefaultExt = "pdf"
        dlog.Filter = "PDF Files(*.pdf)|*.pdf|All Files(*.*)|*.*"
        dlog.RestoreDirectory = True
        dlog.Title = "Select a PDF file"
        If dlog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '
            Try
                If UCase(Path.GetExtension(dlog.FileName)) = ".PDF" Then
                    filepath = dlog.FileName
                    ext = Path.GetExtension(filepath)
                    filename = Path.GetFileNameWithoutExtension(filepath)
                    dir = Path.GetDirectoryName(filepath) + "\"

                    notif.Text = "File selected : " + filename

                Else
                    MessageBox.Show("Only PDF files are supported " + Path.GetExtension(dlog.FileName), "File type not supported", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    slct_Click(sender, e)
                    notif.Text = ""
                End If

            Catch ex As System.IO.IOException
                MessageBox.Show("Something went wrong while your files were being selected. Make sure the file or the location actually exist", "File selection failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End Try

        End If





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpy.Click
          table.Rows.Clear()
        Dim n As Integer
        Dim i As Integer



        Try
            If no.Text <> Nothing Then


                If no.Text = "0" Then
                    ' MessageBox.Show("Number of copies can't be Zero (0)", "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    notif.Text = "Please mention the number of copies to be made"
                    Exit Sub
                End If

                Dim saver As New FolderBrowserDialog
                saver.ShowNewFolderButton = True
                saver.Description = "Select a location to copy files"
                If saver.ShowDialog() = Windows.Forms.DialogResult.OK Then


                    i = 1
                    n = no.Text
                    num = n

                    ReDim files(num)
                    ReDim passy(num)

                    dest = saver.SelectedPath


                    While i <= n

                        temp = dest + "\" + filename + i.ToString() + ".pdf"
                        My.Computer.FileSystem.CopyFile(filepath, temp, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)

                        files(i - 1) = filename + i.ToString() + ".pdf"

                        i = i + 1

                    End While



                    If n = "1" Then

                        notif.Text = n.ToString() + " copy made"
                    Else
                        notif.Text = n.ToString() + " copies made"
                    End If


                    lock.Enabled = True
                    Exit Sub

                End If

            Else
                'MessageBox.Show("Please mention the number of copies to be made", "Blank field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                notif.Text = "Please mention the number of copies to be made"
                no.Focus()

                Exit Sub
            End If
        Catch ex As ArgumentNullException

            notif.Text = "Please select a file"

        Catch exc As InvalidCastException

            notif.Text = "Enter the 'number' of copies to be made"

        Catch exce As Exception

            notif.Text = "Oops! Something went wrong" + vbNewLine + "Error : " + exce.Message
        End Try

    End Sub


    Public Sub lock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lock.Click

        Dim i As Integer
        Dim len As Integer = My.Settings.passlen

        Try

            If My.Settings.apha = True And My.Settings.num = True Then


                For i = 0 To num - 1
                    passy(i) = Gen_AN(len)
                    EncryptPdf(filepath, dest + "\" + files(i), passy(i))

                Next i

            ElseIf My.Settings.apha = True And My.Settings.num = False Then

                For i = 0 To num - 1
                    passy(i) = Gen_A(len)
                    EncryptPdf(filepath, dest + "\" + files(i), passy(i))

                Next i

            ElseIf My.Settings.apha = False And My.Settings.num = True Then

                For i = 0 To num - 1
                    passy(i) = Gen_N(len)
                    EncryptPdf(filepath, dest + "\" + files(i), passy(i))

                Next i

            ElseIf My.Settings.apha = False And My.Settings.num = False Then

                MessageBox.Show("You haven't chosen a proper format for your password generation. Please go to 'App Settings' and select atleast one format. ", "Incorrect Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub


            End If


            ListOut()

            notif.Text = "Files encrypted successfully"
            lock.Enabled = False
            save.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Encryption was not successful. Err : " + ex.Message, "Encryption failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


    End Sub

    Sub EncryptPdf(ByVal sInFilePath As String, ByVal sOutFilePath As String, ByVal sPassword As String)

        Dim oPdfReader As iTextSharp.text.pdf.PdfReader = New iTextSharp.text.pdf.PdfReader(sInFilePath)
        Dim oPdfDoc As New iTextSharp.text.Document()
        Dim oPdfWriter As PdfWriter = PdfWriter.GetInstance(oPdfDoc, New FileStream(sOutFilePath, FileMode.Create))

        oPdfWriter.SetEncryption(PdfWriter.STRENGTH40BITS, sPassword, "", PdfWriter.AllowCopy)

        oPdfDoc.Open()

        oPdfDoc.SetPageSize(iTextSharp.text.PageSize.LEDGER.Rotate())

        Dim oDirectContent As iTextSharp.text.pdf.PdfContentByte = oPdfWriter.DirectContent
        Dim iNumberOfPages As Integer = oPdfReader.NumberOfPages
        Dim iPage As Integer = 0

        Do While (iPage < iNumberOfPages)
            iPage += 1
            oPdfDoc.SetPageSize(oPdfReader.GetPageSizeWithRotation(iPage))
            oPdfDoc.NewPage()

            Dim oPdfImportedPage As iTextSharp.text.pdf.PdfImportedPage = oPdfWriter.GetImportedPage(oPdfReader, iPage)

            Dim iRotation As Integer = oPdfReader.GetPageRotation(iPage)

            If (iRotation = 90) Or (iRotation = 270) Then
                oDirectContent.AddTemplate(oPdfImportedPage, 0, -1.0F, 1.0F, 0, 0, oPdfReader.GetPageSizeWithRotation(iPage).Height)
            Else
                oDirectContent.AddTemplate(oPdfImportedPage, 1.0F, 0, 0, 1.0F, 0, 0)
            End If
        Loop

        oPdfDoc.Close()

    End Sub

    Sub ListOut()
        Dim i As Integer
        For i = 0 To num - 1

            table.Rows.Insert(0, files(i), passy(i))

        Next i

    End Sub


    Public Function Gen_AN(ByVal lngLength As Long) As String
        ' Parameters : lngLength - the length of the password to be 


        On Error GoTo Err_Proc

        Dim iChr As Integer
        Dim c As Long
        Dim strResult As String
        strResult = ""
        Dim iAsc As String

        Randomize()

        For c = 1 To lngLength

            ' Randomly decide what set of ASCII chars we will use
            iAsc = Int(3 * Rnd() + 1)

            'Randomly pick a char from the random set
            Select Case iAsc
                Case 1
                    iChr = Int((Asc("Z") - Asc("A") + 1) * Rnd() + Asc("A"))
                Case 2
                    iChr = Int((Asc("z") - Asc("a") + 1) * Rnd() + Asc("a"))
                Case 3
                    iChr = Int((Asc("9") - Asc("0") + 1) * Rnd() + Asc("0"))
                Case Else
                    Err.Raise(20000, , "Password failed to generate...")
            End Select

            strResult = strResult & Chr(iChr)

        Next c


        Gen_AN = strResult


Exit_Proc:
        Exit Function

Err_Proc:
        MsgBox(Err.Number & ": " & Err.Description, vbOKOnly + vbCritical)
        Gen_AN = vbNullString
        Resume Exit_Proc

    End Function




    Public Function Gen_A(ByVal lngLength As Long) As String
        ' Parameters : lngLength - the length of the password to be 


        On Error GoTo Err_Proc

        Dim iChr As Integer
        Dim c As Long
        Dim strResult As String
        strResult = ""
        Dim iAsc As String

        Randomize()

        For c = 1 To lngLength

            ' Randomly decide what set of ASCII chars we will use
            iAsc = Int(2 * Rnd() + 1)

            'Randomly pick a char from the random set
            Select Case iAsc
                Case 1
                    iChr = Int((Asc("Z") - Asc("A") + 1) * Rnd() + Asc("A"))
                Case 2
                    iChr = Int((Asc("z") - Asc("a") + 1) * Rnd() + Asc("a"))
               
                Case Else
                    Err.Raise(20000, , "Password failed to generate...")
            End Select

            strResult = strResult & Chr(iChr)

        Next c


        Gen_A = strResult


Exit_Proc:
        Exit Function

Err_Proc:
        MsgBox(Err.Number & ": " & Err.Description, vbOKOnly + vbCritical)
        Gen_A = vbNullString
        Resume Exit_Proc

    End Function

    Public Function Gen_N(ByVal lngLength As Long) As String
        ' Parameters : lngLength - the length of the password to be 


        On Error GoTo Err_Proc

        Dim iChr As Integer
        Dim c As Long
        Dim strResult As String
        strResult = ""
        Dim iAsc As String

        Randomize()

        For c = 1 To lngLength

            ' Randomly decide what set of ASCII chars we will use
            iAsc = Int(3 * Rnd() + 1)

            'Randomly pick a char from the random set
           iChr = Int((Asc("9") - Asc("0") + 1) * Rnd() + Asc("0"))

            strResult = strResult & Chr(iChr)

        Next c


        Gen_N = strResult


Exit_Proc:
        Exit Function

Err_Proc:
        MsgBox(Err.Number & ": " & Err.Description, vbOKOnly + vbCritical)
        Gen_N = vbNullString
        Resume Exit_Proc

    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        no.Focus()
        closemenu()

    End Sub

    Private Sub slct_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slct.MouseEnter
        slct.BackColor = Color.FromArgb(255, 185, 195)
    End Sub

    Private Sub slct_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slct.MouseLeave
        slct.BackColor = Color.FromArgb(255, 160, 160)
    End Sub


    Private Sub cpy_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpy.MouseEnter
        cpy.BackColor = Color.FromArgb(255, 185, 195)
    End Sub

    Private Sub cpy_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpy.MouseLeave
        cpy.BackColor = Color.FromArgb(255, 160, 160)
    End Sub

    Private Sub lock_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lock.MouseEnter
        lock.BackColor = Color.FromArgb(197, 225, 165)
    End Sub
    Private Sub lock_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lock.MouseLeave

        lock.BackColor = Color.FromArgb(174, 213, 129)

    End Sub

    Private Sub lock_MouseOver(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lock.MouseDown
        lock.BackColor = Color.FromArgb(139, 195, 74)
    End Sub


    Sub openmenu()


        bar.Visible = True
        bar.Size = New System.Drawing.Size(191, 448)
        menu.Size = New System.Drawing.Size(191, 53)
        menu.ImageAlign = ContentAlignment.MiddleLeft
        menu.Text = "Menu"
    End Sub


    Sub closemenu()
        menu.Text = Nothing
        bar.Visible = False
        bar.Size = New System.Drawing.Size(0, 53)
        menu.Size = New System.Drawing.Size(55, 53)
        menu.ImageAlign = ContentAlignment.MiddleCenter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu.Click

        If bar.Size.Width = 0 Then

            openmenu()

        Else
            closemenu()

        End If
        cpy.Focus()
    End Sub

    Private Sub Label1_DragEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sett.MouseEnter
        sett.BackColor = Color.FromArgb(197, 202, 233)
    End Sub

    Private Sub Label_DragEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlp.MouseEnter
        hlp.BackColor = Color.FromArgb(197, 202, 233)
    End Sub

    Private Sub Label1_DraEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt.MouseEnter
        abt.BackColor = Color.FromArgb(197, 202, 233)
    End Sub

    Private Sub Labe_DragEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tut.MouseEnter
        tut.BackColor = Color.FromArgb(197, 202, 233)
    End Sub


    Private Sub Label1_DragEter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sett.MouseLeave
        sett.BackColor = Color.FromArgb(121, 134, 203)
    End Sub

    Private Sub Lbel_DragEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlp.MouseLeave
        hlp.BackColor = Color.FromArgb(121, 134, 203)
    End Sub

    Private Sub Labe1_DraEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt.MouseLeave
        abt.BackColor = Color.FromArgb(121, 134, 203)
    End Sub

    Private Sub Labe_DragEter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tut.MouseLeave
        tut.BackColor = Color.FromArgb(121, 134, 203)
    End Sub

    Private Sub tut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tut.Click
        closemenu()
        Me.WindowState = FormWindowState.Minimized
        tutor.ShowDialog()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub lock_MouseOver(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lock.MouseDown

    End Sub

    Private Sub abt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt.Click
        closemenu()
        Me.WindowState = FormWindowState.Minimized
        abtbox.ShowDialog()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub sett_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sett.Click
        settings.ShowDialog()
    End Sub

    Private Sub hlp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlp.Click
        closemenu()
        Me.WindowState = FormWindowState.Minimized
        hs.ShowDialog()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click

        Dim d As New SaveFileDialog()
        Dim file As System.IO.StreamWriter
        Dim path As String

        If d.ShowDialog() = Windows.Forms.DialogResult.OK Then

            path = d.FileName
            d.RestoreDirectory = True

            If path.Contains(".txt") Then


            Else
                path = path + ".txt"
            End If

            file = My.Computer.FileSystem.OpenTextFileWriter(path, True)

            file.WriteLine("List of PDFLocker generated files and associated passwords" & vbNewLine)


            Dim i As Integer
            Dim n As Integer
            n = 1
            For i = 0 To num - 1

                file.WriteLine(n.ToString() + ". " + files(i) + " :  " + passy(i))
                n = n + 1
            Next i

            file.Close()
        End If
       


    End Sub
End Class
