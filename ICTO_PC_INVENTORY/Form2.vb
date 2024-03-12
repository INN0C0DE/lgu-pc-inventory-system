Imports MySql.Data.MySqlClient

Public Class Form2
    Dim connectionString As String = "Server=3.3.2.121;Database=pc_inventory;Userid=root;Password='';"
    Dim connection As MySqlConnection
    Dim searchTimer As Timer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the connection
        connection = New MySqlConnection(connectionString)
        ' Load data into the DataGridView on form load
        LoadData()

        ' Initialize the timer
        searchTimer = New Timer()
        searchTimer.Interval = 300 ' Set the interval (milliseconds) according to your preference
        AddHandler searchTimer.Tick, AddressOf SearchTimer_Tick
    End Sub

    Public Sub LoadData()
        ' Clear existing rows in the DataGridView
        Inventory_dgv.Rows.Clear()

        Using connection As New MySqlConnection(connectionString)
            ' Open the connection
            connection.Open()

            ' SQL query to select data from the Inventory table
            Dim query As String = "SELECT no, type_of_unit, pc_name, ip, user_name, owner_name, department, processor, motherboard, storageType1, storage1, storageType2, storage2, memory, memorySpeed, videocard, psu, peripherals, monitor_brand, monitor_brand_size, with_os, osVersion, os_license, with_ms, msVersion, ms_license, anti_virus, anti_virusCode FROM pc_information_table"

            ' Create a new data adapter
            Using adapter As New MySqlDataAdapter(query, connection)
                ' Create a new DataTable to hold the data
                Dim dataTable As New DataTable()

                ' Map the columns from the database to the existing columns in the DataTable
                dataTable.Columns.Add("no", GetType(Integer))
                dataTable.Columns.Add("type_of_unit", GetType(String))
                dataTable.Columns.Add("pc_name", GetType(String))
                dataTable.Columns.Add("ip", GetType(String))
                dataTable.Columns.Add("user_name", GetType(String))
                dataTable.Columns.Add("owner_name", GetType(String))
                dataTable.Columns.Add("department", GetType(String))
                dataTable.Columns.Add("processor", GetType(String))
                dataTable.Columns.Add("motherboard", GetType(String))
                dataTable.Columns.Add("storageType1", GetType(String))
                dataTable.Columns.Add("storage1", GetType(String))
                dataTable.Columns.Add("storageType2", GetType(String))
                dataTable.Columns.Add("storage2", GetType(String))
                dataTable.Columns.Add("memory", GetType(String))
                dataTable.Columns.Add("memorySpeed", GetType(String))
                dataTable.Columns.Add("videocard", GetType(String))
                dataTable.Columns.Add("psu", GetType(String))
                dataTable.Columns.Add("peripherals", GetType(String))
                dataTable.Columns.Add("monitor_brand", GetType(String))
                dataTable.Columns.Add("monitor_brand_size", GetType(String))
                dataTable.Columns.Add("with_os", GetType(String))
                dataTable.Columns.Add("osVersion", GetType(String))
                dataTable.Columns.Add("os_license", GetType(String))
                dataTable.Columns.Add("with_ms", GetType(String))
                dataTable.Columns.Add("msVersion", GetType(String))
                dataTable.Columns.Add("ms_license", GetType(String))
                dataTable.Columns.Add("anti_virus", GetType(String))
                dataTable.Columns.Add("anti_virusCode", GetType(String))

                ' Fill the DataTable with data from the database
                adapter.Fill(dataTable)

                ' Loop through rows and columns to populate DataGridView manually
                For Each row As DataRow In dataTable.Rows
                    Dim dgvRow As DataGridViewRow = New DataGridViewRow()

                    For Each col As DataColumn In dataTable.Columns
                        ' Find the corresponding column in the DataGridView
                        Dim dgvCol As DataGridViewColumn = Inventory_dgv.Columns(col.ColumnName)

                        ' Check if the column exists in the DataGridView
                        If dgvCol IsNot Nothing Then
                            ' Add a cell to the DataGridViewRow
                            dgvRow.Cells.Add(New DataGridViewTextBoxCell With {
                            .Value = row(col.ColumnName)
                        })
                        End If
                    Next

                    ' Add the DataGridViewRow to the DataGridView
                    Inventory_dgv.Rows.Add(dgvRow)
                Next
            End Using
        End Using

        ' Auto-resize columns to fit the content
        Inventory_dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        ' Enable horizontal scrollbar
        Inventory_dgv.ScrollBars = ScrollBars.Both

        ' Align header and cells to the center
        For Each column As DataGridViewColumn In Inventory_dgv.Columns
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub


    Private Sub pc_search_TextChanged(sender As Object, e As EventArgs) Handles pc_search.TextChanged
        ' Restart the timer whenever the user types in the search box
        searchTimer.Stop()
        searchTimer.Start()
    End Sub

    Private Sub SearchTimer_Tick(sender As Object, e As EventArgs)
        ' Stop the timer
        searchTimer.Stop()

        ' Perform the search
        If Not String.IsNullOrEmpty(pc_search.Text.Trim()) Then
            SearchData(pc_search.Text.Trim())
        Else
            LoadData()
        End If
    End Sub

    Private Sub SearchData(searchText As String)
        ' Query to select data based on the search text
        Dim query As String = "SELECT no, type_of_unit, pc_name, ip, user_name, owner_name, department, processor, motherboard, storageType1, storage1, storageType2, storage2, memory, memorySpeed, videocard, psu, peripherals, monitor_brand, monitor_brand_size, with_os, osVersion, os_license, with_ms, msVersion, ms_license, anti_virus, anti_virusCode FROM pc_information_table WHERE pc_name LIKE @SearchText OR user_name LIKE @SearchText OR ip LIKE @SearchText OR owner_name LIKE @SearchText OR processor LIKE @SearchText OR motherboard LIKE @SearchText OR memory LIKE @SearchText OR videocard LIKE @SearchText OR psu LIKE @SearchText OR peripherals LIKE @SearchText OR monitor_brand_size LIKE @SearchText OR os_license LIKE @SearchText OR ms_license LIKE @SearchText OR anti_virus LIKE @SearchText OR type_of_unit LIKE @SearchText OR department LIKE @SearchText OR storageType1 LIKE @SearchText OR storage1 LIKE @SearchText OR storageType2 LIKE @SearchText OR storage2 LIKE @SearchText OR memorySpeed LIKE @SearchText OR monitor_brand LIKE @SearchText OR anti_virusCode LIKE @SearchText OR osVersion LIKE @SearchText OR msVersion LIKE @SearchText"

        ' Create a new connection
        Using connection As New MySqlConnection(connectionString)
            ' Open the connection
            connection.Open()

            ' Create a new data adapter
            Using adapter As New MySqlDataAdapter(query, connection)
                ' Add a parameter for the search text
                adapter.SelectCommand.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")

                ' Create a new DataTable to hold the data
                Dim dataTable As New DataTable()

                ' Fill the DataTable with data from the database
                adapter.Fill(dataTable)

                ' Clear existing rows in the DataGridView
                Inventory_dgv.Rows.Clear()

                ' Loop through rows and columns to populate DataGridView manually
                For Each row As DataRow In dataTable.Rows
                    Dim dgvRow As DataGridViewRow = New DataGridViewRow()

                    For Each col As DataColumn In dataTable.Columns
                        ' Find the corresponding column in the DataGridView
                        Dim dgvCol As DataGridViewColumn = Inventory_dgv.Columns(col.ColumnName)

                        ' Check if the column exists in the DataGridView
                        If dgvCol IsNot Nothing Then
                            ' Add a cell to the DataGridViewRow
                            dgvRow.Cells.Add(New DataGridViewTextBoxCell With {
                            .Value = row(col.ColumnName)
                        })
                        End If
                    Next

                    ' Add the DataGridViewRow to the DataGridView
                    Inventory_dgv.Rows.Add(dgvRow)
                Next
            End Using
        End Using
    End Sub

    Private Sub BunifuButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Form1.Show()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs)
        LoadData()
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Try
            If Inventory_dgv.SelectedRows.Count > 0 Then
                ' Extract combined values from the 'peripherals' column
                Dim combinedValues As String = Inventory_dgv.SelectedRows.Item(0).Cells(17).Value.ToString()

                ' Split the combined values based on the delimiter (e.g., "/")
                Dim peripheralsArray As String() = combinedValues.Split("/"c)

                ' Open Form3 and pass the combined values
                Dim form3 As New Form3(combinedValues, peripheralsArray)
                form3.pc_no.Text = Inventory_dgv.SelectedRows.Item(0).Cells(0).Value
                form3.pc_compType.Text = Inventory_dgv.SelectedRows.Item(0).Cells(1).Value
                form3.pc_compName.Text = Inventory_dgv.SelectedRows.Item(0).Cells(2).Value
                form3.pc_CompIP.Text = Inventory_dgv.SelectedRows.Item(0).Cells(3).Value
                form3.pc_userName.Text = Inventory_dgv.SelectedRows.Item(0).Cells(4).Value
                form3.pc_ownerName.Text = Inventory_dgv.SelectedRows.Item(0).Cells(5).Value
                form3.pc_department.Text = Inventory_dgv.SelectedRows.Item(0).Cells(6).Value
                form3.pc_procie.Text = Inventory_dgv.SelectedRows.Item(0).Cells(7).Value
                form3.pc_mobo.Text = Inventory_dgv.SelectedRows.Item(0).Cells(8).Value
                form3.pc_storageType1.Text = Inventory_dgv.SelectedRows.Item(0).Cells(9).Value
                form3.pc_storage1.Text = Inventory_dgv.SelectedRows.Item(0).Cells(10).Value
                form3.pc_storageType2.Text = Inventory_dgv.SelectedRows.Item(0).Cells(11).Value
                form3.pc_storage2.Text = Inventory_dgv.SelectedRows.Item(0).Cells(12).Value
                form3.pc_memory.Text = Inventory_dgv.SelectedRows.Item(0).Cells(13).Value
                form3.pc_memorySpeed.Text = Inventory_dgv.SelectedRows.Item(0).Cells(14).Value
                form3.pc_videocard.Text = Inventory_dgv.SelectedRows.Item(0).Cells(15).Value
                form3.pc_psu.Text = Inventory_dgv.SelectedRows.Item(0).Cells(16).Value
                form3.pc_peripherals.Text = combinedValues
                form3.pc_monitorBrand.Text = Inventory_dgv.SelectedRows.Item(0).Cells(18).Value
                form3.pc_monitor.Text = Inventory_dgv.SelectedRows.Item(0).Cells(19).Value

                form3.pc_osVersion.Text = Inventory_dgv.SelectedRows.Item(0).Cells(21).Value
                form3.pc_msVersion.Text = Inventory_dgv.SelectedRows.Item(0).Cells(24).Value

                form3.pc_msLicense.Text = Inventory_dgv.SelectedRows.Item(0).Cells(25).Value
                form3.pc_antiVirus.Text = Inventory_dgv.SelectedRows.Item(0).Cells(26).Value
                form3.pc_antiVirusCode.Text = Inventory_dgv.SelectedRows.Item(0).Cells(27).Value


                ' Set radio button values based on database values
                form3.pc_osYes.Checked = (Inventory_dgv.SelectedRows.Item(0).Cells(20).Value.ToString() = "YES")
                form3.pc_osNo.Checked = (Inventory_dgv.SelectedRows.Item(0).Cells(20).Value.ToString() = "NO")
                form3.pc_osLicense.Text = Inventory_dgv.SelectedRows.Item(0).Cells(22).Value
                form3.pc_msYes.Checked = (Inventory_dgv.SelectedRows.Item(0).Cells(23).Value.ToString() = "YES")
                form3.pc_msNo.Checked = (Inventory_dgv.SelectedRows.Item(0).Cells(23).Value.ToString() = "NO")

                ' Check the values of pc_osYes.Checked and pc_msYes.Checked
                If form3.pc_osYes.Checked Then
                    ' If both are "YES," enable the controls
                    form3.pc_osLicense.Enabled = True
                    form3.pc_osVersion.Enabled = True
                Else
                    ' If any of them is "NO," disable the controls
                    form3.pc_osLicense.Enabled = False
                    form3.pc_osVersion.Enabled = False
                End If
                If form3.pc_msYes.Checked Then
                    ' If both are "YES," enable the controls
                    form3.pc_msLicense.Enabled = True
                    form3.pc_msVersion.Enabled = True
                Else
                    ' If any of them is "NO," disable the controls
                    form3.pc_msLicense.Enabled = False
                    form3.pc_msVersion.Enabled = False
                End If

                form3.ShowDialog()
            Else
                MsgBox("Please select account to edit.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            'MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Try
            ' Check if any row is selected
            If Inventory_dgv.SelectedRows.Count > 0 Then
                ' Ask for confirmation before deleting
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this inventory?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Get the value from the first cell of the selected row (assuming it's the primary key)
                    Dim primaryKeyValue As Integer = Convert.ToInt32(Inventory_dgv.SelectedRows(0).Cells("no").Value)

                    ' Open the connection
                    connection.Open()

                    ' SQL query to delete the selected record
                    Dim query As String = "DELETE FROM pc_information_table WHERE no = @param1"

                    Using cmd As New MySqlCommand(query, connection)
                        ' Set the parameter value
                        cmd.Parameters.AddWithValue("@param1", primaryKeyValue)

                        ' Execute the query
                        Dim affectedRows As Integer = cmd.ExecuteNonQuery()

                        If affectedRows > 0 Then
                            MsgBox("Record deleted successfully!", vbInformation, "Delete Status:")
                            ' Refresh the DataGridView
                            LoadData()
                        Else
                            MsgBox("Failed to delete record.", vbExclamation, "Delete Status:")
                        End If
                    End Using
                End If
            Else
                MsgBox("Please select a record to delete.", vbExclamation, "Delete Status:")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            connection.Close()
        End Try
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Form4.Show()

    End Sub
End Class
