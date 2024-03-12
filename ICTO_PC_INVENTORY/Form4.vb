Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient

Public Class Form4
    Private Sub printBTN_Click(sender As Object, e As EventArgs) Handles printBTN.Click
        Dim connectionString As String = "Server=3.3.2.121;Database=pc_inventory;Userid=root;Password='';"
        Dim departmentName As String = pc_department.SelectedItem.ToString()

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "SELECT * FROM pc_information_table WHERE department = @Department"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Department", departmentName)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10) ' Landscape layout with no margins

                        Dim saveFileDialog1 As New SaveFileDialog()
                        saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
                        saveFileDialog1.FilterIndex = 2
                        saveFileDialog1.RestoreDirectory = True

                        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                            Dim filePath As String = saveFileDialog1.FileName
                            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(filePath, FileMode.Create))
                            doc.Open()

                            ' Add text before the table
                            Dim text As String = "PC Inventory for the Department: " & departmentName
                            Dim paragraph As New Paragraph(text)
                            paragraph.Alignment = Element.ALIGN_CENTER ' Align text to the center
                            paragraph.SpacingAfter = 10 ' Add margin below the paragraph
                            doc.Add(paragraph)

                            ' Create table with 25 columns
                            Dim table As New PdfPTable(7)

                            ' Add column headers
                            'table.AddCell("No.")
                            table.AddCell("Type of Unit")
                            table.AddCell("PC Name")
                            'table.AddCell("IP")
                            'table.AddCell("User's Name")
                            table.AddCell("Owner's Name")
                            'table.AddCell("Department")
                            'table.AddCell("Processor")
                            'table.AddCell("Motherboard")
                            'table.AddCell("Storage Type 1")
                            'table.AddCell("Storage 1 Size")
                            'table.AddCell("Storage Type 2")
                            'table.AddCell("Storage 2 Size")
                            'table.AddCell("Storage Type 1")
                            'table.AddCell("Memory")
                            'table.AddCell("Memory Speed")
                            'table.AddCell("Videocard")
                            'table.AddCell("PSU")
                            'table.AddCell("Peripherals")
                            'table.AddCell("Monitor Brand")
                            'table.AddCell("Monitor Size")
                            'table.AddCell("w/ OS")
                            table.AddCell("OS Version")
                            table.AddCell("OS License")
                            'table.AddCell("w/ Office")
                            table.AddCell("Office Version")
                            table.AddCell("Office License")
                            'table.AddCell("Anti-Virus")
                            'table.AddCell("Anti-Virus Activation Code")

                            ' Add data from database to the table
                            While reader.Read()
                                'table.AddCell(reader(0).ToString()) 'table no.
                                table.AddCell(reader(1).ToString())
                                table.AddCell(reader(2).ToString())
                                'table.AddCell(reader(3).ToString())
                                'table.AddCell(reader(4).ToString())
                                table.AddCell(reader(5).ToString())
                                'table.AddCell(reader(6).ToString())
                                'table.AddCell(reader(7).ToString())
                                'table.AddCell(reader(8).ToString())
                                'table.AddCell(reader(9).ToString())
                                'table.AddCell(reader(10).ToString())
                                'table.AddCell(reader(11).ToString())
                                'table.AddCell(reader(12).ToString())
                                'table.AddCell(reader(13).ToString())
                                'table.AddCell(reader(14).ToString())
                                'table.AddCell(reader(15).ToString())
                                'table.AddCell(reader(16).ToString())
                                'table.AddCell(reader(17).ToString())
                                'table.AddCell(reader(18).ToString())
                                'table.AddCell(reader(19).ToString())
                                'table.AddCell(reader(20).ToString()) 'if with OS
                                table.AddCell(reader(21).ToString())
                                table.AddCell(reader(22).ToString())
                                'table.AddCell(reader(23).ToString()) 'if with Office
                                table.AddCell(reader(24).ToString())
                                table.AddCell(reader(25).ToString())
                                'table.AddCell(reader(26).ToString())
                                'table.AddCell(reader(27).ToString()) 'Activation code of anti-virus
                            End While

                            ' Add the table to the document
                            doc.Add(table)

                            doc.Close()

                            MessageBox.Show("PDF file generated successfully. File saved to " & filePath, "Print Data Status:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
