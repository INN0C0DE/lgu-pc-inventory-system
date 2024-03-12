Imports MySql.Data.MySqlClient
Public Class Form3
    Dim combinedValuesFromForm2 As String
    Dim peripheralsArrayFromForm2 As String()
    Dim connectionString As String = "Server=3.3.2.121;Database=pc_inventory;Userid=root;Password='';"
    Dim connection As MySqlConnection

    'Dim peri1 As String = "Mouse/ "
    'Dim peri2 As String = "Keyboard/ "
    'Dim peri3 As String = "UPS/ "

    Public Sub New(combinedValues As String, peripheralsArray As String())
        InitializeComponent()
        combinedValuesFromForm2 = combinedValues
        peripheralsArrayFromForm2 = peripheralsArray
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection(connectionString)
        CheckCheckboxes(peripheralsArrayFromForm2)
        'pc_osLicense.Enabled = False
        'pc_msLicense.Enabled = False
    End Sub
    Private Sub CheckCheckboxes(peripheralsArray As String())
        ' Check checkboxes based on the received combined values
        pc_periMouse.Checked = peripheralsArray.Contains("Mouse")
        pc_periKeyboard.Checked = peripheralsArray.Contains("Keyboard")
        pc_periUPS.Checked = peripheralsArray.Contains("UPS")
    End Sub
    Private Sub pc_osYes_Click(sender As Object, e As EventArgs)
        If pc_osYes.Checked = True Then
            pc_osLicense.Enabled = True
            yesNotxt1.Text = "YES"
        End If
    End Sub

    Private Sub pc_osNo_Click(sender As Object, e As EventArgs)
        If pc_osNo.Checked = True Then
            pc_osLicense.Enabled = False
            pc_osLicense.Clear()
            yesNotxt1.Text = "NO"
        End If
    End Sub

    Private Sub pc_msYes_Click(sender As Object, e As EventArgs)
        If pc_msYes.Checked = True Then
            pc_msLicense.Enabled = True
            yesNotxt2.Text = "YES"
        End If
    End Sub

    Private Sub pc_msNo_Click(sender As Object, e As EventArgs)
        If pc_msNo.Checked = True Then
            pc_msLicense.Enabled = False
            pc_msLicense.Clear()
            yesNotxt2.Text = "NO"
        End If
    End Sub

    Private Sub pc_periMouse_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs)
        If pc_periMouse.Checked = True Then
            peri01.Text = "Mouse /"
            pc_peripherals.Text = peri01.Text + peri02.Text + peri03.Text
        End If
        If pc_periMouse.Checked = False Then
            peri01.Text = ""
            pc_peripherals.Text = peri01.Text + peri02.Text + peri03.Text
        End If
    End Sub

    Private Sub pc_periKeyboard_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs)
        If pc_periKeyboard.Checked = True Then
            peri02.Text = "Keyboard /"
            pc_peripherals.Text = peri01.Text + peri02.Text + peri03.Text
        End If
        If pc_periKeyboard.Checked = False Then
            peri02.Text = ""
            pc_peripherals.Text = peri01.Text + peri02.Text + peri03.Text
        End If
    End Sub

    Private Sub pc_periUPS_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs)
        If pc_periUPS.Checked = True Then
            peri03.Text = "UPS /"
            pc_peripherals.Text = peri01.Text + peri02.Text + peri03.Text
        End If
        If pc_periUPS.Checked = False Then
            peri03.Text = ""
            pc_peripherals.Text = peri01.Text + peri02.Text + peri03.Text
        End If
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Try
            ' Open the database connection
            connection.Open()

            ' Combine checkbox values into the 'peripherals' string
            Dim peripheralsList As New List(Of String)
            If pc_periMouse.Checked Then peripheralsList.Add("Mouse")
            If pc_periKeyboard.Checked Then peripheralsList.Add("Keyboard")
            If pc_periUPS.Checked Then peripheralsList.Add("UPS")

            ' Create the 'peripheralsValue' string with "/" separator
            Dim peripheralsValue As String = String.Join("/", peripheralsList)

            ' Get the selected radio button value
            Dim osLicenseValue As String = If(pc_osYes.Checked, "YES", "NO")
            Dim msLicenseValue As String = If(pc_msYes.Checked, "YES", "NO")

            ' SQL query with placeholders for the parameters
            Dim query As String = "UPDATE pc_information_table " &
                              "SET type_of_unit = @param1, pc_name = @param2, ip = @param3, " &
                              "user_name = @param4, owner_name = @param5, processor = @param6, " &
                              "motherboard = @param7, memory = @param8, videocard = @param9, " &
                              "psu = @param10, peripherals = @param11, monitor_brand_size = @param12, " &
                              "with_os = @param13, os_license = @param14, with_ms = @param15, " &
                              "ms_license = @param16, anti_virus = @param17, " &
                              "department = @param18, storageType1 = @param19, storage1 = @param20, " &
                              "storageType2 = @param21, storage2 = @param22, memorySpeed = @param23, " &
                              "monitor_brand = @param24, anti_virusCode = @param25, osVersion = @param26, msVersion = @param27 " &
                              "WHERE no = @param28"

            Using cmd As New MySqlCommand(query, connection)
                ' Set the parameter values from the TextBoxes and DropDownList
                cmd.Parameters.AddWithValue("@param1", pc_compType.Text)
                cmd.Parameters.AddWithValue("@param2", pc_compName.Text)
                cmd.Parameters.AddWithValue("@param3", pc_CompIP.Text)
                cmd.Parameters.AddWithValue("@param4", pc_userName.Text)
                cmd.Parameters.AddWithValue("@param5", pc_ownerName.Text)
                cmd.Parameters.AddWithValue("@param6", pc_procie.Text)
                cmd.Parameters.AddWithValue("@param7", pc_mobo.Text)
                cmd.Parameters.AddWithValue("@param8", pc_memory.Text)
                cmd.Parameters.AddWithValue("@param9", pc_videocard.Text)
                cmd.Parameters.AddWithValue("@param10", pc_psu.Text)
                cmd.Parameters.AddWithValue("@param11", peripheralsValue)
                cmd.Parameters.AddWithValue("@param12", pc_monitor.Text)
                cmd.Parameters.AddWithValue("@param13", osLicenseValue)
                cmd.Parameters.AddWithValue("@param14", pc_osLicense.Text)
                cmd.Parameters.AddWithValue("@param15", msLicenseValue)
                cmd.Parameters.AddWithValue("@param16", pc_msLicense.Text)
                cmd.Parameters.AddWithValue("@param17", pc_antiVirus.Text)
                cmd.Parameters.AddWithValue("@param18", pc_department.Text)
                cmd.Parameters.AddWithValue("@param19", pc_storageType1.Text)
                cmd.Parameters.AddWithValue("@param20", pc_storage1.Text)
                cmd.Parameters.AddWithValue("@param21", pc_storageType2.Text)
                cmd.Parameters.AddWithValue("@param22", pc_storage2.Text)
                cmd.Parameters.AddWithValue("@param23", pc_memorySpeed.Text)
                cmd.Parameters.AddWithValue("@param24", pc_monitorBrand.Text)
                cmd.Parameters.AddWithValue("@param25", pc_antiVirusCode.Text)
                cmd.Parameters.AddWithValue("@param26", pc_osVersion.Text)
                cmd.Parameters.AddWithValue("@param27", pc_msVersion.Text)
                cmd.Parameters.AddWithValue("@param28", pc_no.Text) ' Assuming pc_no is the primary key

                ' Execute the query
                Dim affectedRows As Integer = cmd.ExecuteNonQuery()

                ' Check the result of the update operation
                If affectedRows > 0 Then
                    MsgBox("Inventory updated successfully!", vbInformation, "Inventory Status:")
                    Form2.LoadData()
                    Me.Close()
                Else
                    MsgBox("Failed to update inventory.", vbExclamation, "Inventory Status:")
                End If
            End Using
        Catch ex As Exception
            ' Display an error message in case of an exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the database connection
            connection.Close()
        End Try
    End Sub


    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        'uncheckBoxes()
        Me.Close()


    End Sub

    Private Sub addItemBtn_Click(sender As Object, e As EventArgs)
        addDDItem.Show()
    End Sub

    Private Sub pc_storage2_TextChanged(sender As Object, e As EventArgs) Handles pc_storage2.TextChanged

    End Sub

    Private Sub pc_osYes_Click_1(sender As Object, e As EventArgs) Handles pc_osYes.Click
        If pc_osYes.Checked = True Then
            pc_osLicense.Enabled = True
            pc_osVersion.Enabled = True
            yesNotxt1.Text = "YES"
        End If
    End Sub

    Private Sub pc_osNo_Click_1(sender As Object, e As EventArgs) Handles pc_osNo.Click
        If pc_osNo.Checked = True Then
            pc_osLicense.Enabled = False
            pc_osLicense.Clear()
            pc_osVersion.Text = ""
            pc_osVersion.Enabled = False
            yesNotxt1.Text = "NO"
        End If
    End Sub

    Private Sub pc_msYes_Click_1(sender As Object, e As EventArgs) Handles pc_msYes.Click
        If pc_msYes.Checked = True Then
            pc_msLicense.Enabled = True
            pc_msVersion.Enabled = True
            yesNotxt2.Text = "YES"
        End If
    End Sub

    Private Sub pc_msNo_Click_1(sender As Object, e As EventArgs) Handles pc_msNo.Click
        If pc_msNo.Checked = True Then
            pc_msLicense.Enabled = False
            pc_msLicense.Clear()
            pc_msVersion.Text = ""
            pc_msVersion.Enabled = False
            yesNotxt2.Text = "NO"
        End If
    End Sub




    Private Sub uncheckBoxes()
        pc_periMouse.Checked = False
        pc_periKeyboard.Checked = False
        pc_periUPS.Checked = False
    End Sub

End Class