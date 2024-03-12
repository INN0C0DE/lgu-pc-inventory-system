Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connectionString As String = "Server=3.3.2.121;Database=pc_inventory;Userid=root;Password='';"
    Dim connection As MySqlConnection
    Dim peri1 As String = "Mouse/ "
    Dim peri2 As String = "Keyboard/ "
    Dim peri3 As String = "UPS/ "

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection(connectionString)
        pc_osYes.Checked = False
        pc_osNo.Checked = False
        pc_msYes.Checked = False
        pc_msNo.Checked = False
        pc_osLicense.Enabled = False
        pc_msLicense.Enabled = False
        pc_osVersion.Enabled = False
        pc_msVersion.Enabled = False
    End Sub

    Private Sub BunifuLabel3_Click(sender As Object, e As EventArgs) Handles BunifuLabel3.Click

    End Sub

    Private Sub BunifuTextBox2_TextChanged(sender As Object, e As EventArgs) Handles pc_compName.TextChanged

    End Sub

    Private Sub BunifuLabel2_Click(sender As Object, e As EventArgs) Handles BunifuLabel2.Click

    End Sub

    Private Sub pc_osYes_Click(sender As Object, e As EventArgs) Handles pc_osYes.Click
        If pc_osYes.Checked = True Then
            pc_osLicense.Enabled = True
            pc_osVersion.Enabled = True
            yesNotxt1.Text = "YES"
        End If
    End Sub

    Private Sub pc_osNo_Click(sender As Object, e As EventArgs) Handles pc_osNo.Click
        If pc_osNo.Checked = True Then
            pc_osLicense.Enabled = False
            pc_osVersion.Enabled = False
            pc_osLicense.Clear()
            pc_osVersion.Text = ""
            yesNotxt1.Text = "NO"
        End If
    End Sub

    Private Sub pc_msYes_Click(sender As Object, e As EventArgs) Handles pc_msYes.Click
        If pc_msYes.Checked = True Then
            pc_msLicense.Enabled = True
            pc_msVersion.Enabled = True
            yesNotxt2.Text = "YES"
        End If
    End Sub

    Private Sub pc_msNo_Click(sender As Object, e As EventArgs) Handles pc_msNo.Click
        If pc_msNo.Checked = True Then
            pc_msLicense.Enabled = False
            pc_msVersion.Enabled = False
            pc_msLicense.Clear()
            pc_msVersion.Text = ""
            yesNotxt2.Text = "NO"
        End If
    End Sub

    Private Sub pc_periMouse_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs) Handles pc_periMouse.CheckedChanged
        If pc_periMouse.Checked = True Then
            peri01.Text = "Mouse /"
            pc_peripherals.Text = peri01.Text + peri02.Text + peri03.Text
        End If
        If pc_periMouse.Checked = False Then
            peri01.Text = ""
            pc_peripherals.Text = peri01.Text + peri02.Text + peri03.Text
        End If
    End Sub

    Private Sub pc_periKeyboard_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs) Handles pc_periKeyboard.CheckedChanged
        If pc_periKeyboard.Checked = True Then
            peri02.Text = "Keyboard /"
            pc_peripherals.Text = peri01.Text + peri02.Text + peri03.Text
        End If
        If pc_periKeyboard.Checked = False Then
            peri02.Text = ""
            pc_peripherals.Text = peri01.Text + peri02.Text + peri03.Text
        End If
    End Sub

    Private Sub pc_periUPS_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs) Handles pc_periUPS.CheckedChanged
        If pc_periUPS.Checked = True Then
            peri03.Text = "UPS /"
            pc_peripherals.Text = peri01.Text + peri02.Text + peri03.Text
        End If
        If pc_periUPS.Checked = False Then
            peri03.Text = ""
            pc_peripherals.Text = peri01.Text + peri02.Text + peri03.Text
        End If
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If ValidateInputs() Then
            Try
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
                Dim query As String = "INSERT INTO pc_information_table (type_of_unit, pc_name, ip, user_name, owner_name, processor, motherboard, memory, videocard, psu, peripherals, monitor_brand_size, with_os, os_license, with_ms, ms_license, anti_virus, department, storageType1, storage1, storageType2, storage2, memorySpeed, monitor_brand, anti_virusCode, osVersion, msVersion) VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9, @param10, @param11, @param12, @param13, @param14, @param15, @param16, @param17, @param18, @param19, @param20, @param21, @param22, @param23, @param24, @param25, @param26, @param27)"

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

                    ' Execute the query
                    Dim affectedRows As Integer = cmd.ExecuteNonQuery()

                    If affectedRows > 0 Then
                        MsgBox("Inventory saved successfully!", vbInformation, "Inventory Status:")
                        Form2.LoadData()
                        Me.Close()
                    Else
                        MsgBox("Failed to save inventory.", vbExclamation, "Inventory Status:")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MessageBox.Show("Please fill in all required fields.", "You forgot something!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub

    Private Sub addItemBtn_Click(sender As Object, e As EventArgs) Handles addItemBtn.Click
        addDDItem.Show()
    End Sub

    Private Sub addItemBtn2_Click(sender As Object, e As EventArgs) Handles addItemBtn2.Click
        addDDItem2.Show()
    End Sub

    Private Sub addItemBtn3_Click(sender As Object, e As EventArgs) Handles addItemBtn3.Click
        addDDItem3.Show()
    End Sub

    Private Sub addItemBtn4_Click(sender As Object, e As EventArgs) Handles addItemBtn4.Click
        addDDItem4.Show()
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Check if required textboxes are not empty
        If String.IsNullOrEmpty(pc_compType.Text) OrElse
           String.IsNullOrEmpty(pc_compName.Text) OrElse
           String.IsNullOrEmpty(pc_CompIP.Text) OrElse
           String.IsNullOrEmpty(pc_userName.Text) OrElse
           String.IsNullOrEmpty(pc_ownerName.Text) OrElse
           String.IsNullOrEmpty(pc_procie.Text) OrElse
           String.IsNullOrEmpty(pc_mobo.Text) OrElse
           String.IsNullOrEmpty(pc_memory.Text) OrElse
           String.IsNullOrEmpty(pc_psu.Text) OrElse
           String.IsNullOrEmpty(pc_antiVirus.Text) OrElse
           String.IsNullOrEmpty(pc_department.Text) OrElse
           String.IsNullOrEmpty(pc_storageType1.Text) OrElse
           String.IsNullOrEmpty(pc_storage1.Text) OrElse
            String.IsNullOrEmpty(pc_storageType2.Text) OrElse
           String.IsNullOrEmpty(pc_storage2.Text) Then
            Return False
        End If

        ' Add any additional validation as needed

        Return True
    End Function

    Private Sub addItemBtn5_Click(sender As Object, e As EventArgs) Handles addItemBtn5.Click
        addDDItem5.Show()

    End Sub

    Private Sub addItemBtn6_Click(sender As Object, e As EventArgs) Handles addItemBtn6.Click
        addDDItem6.Show()
    End Sub
End Class
