Imports System.Data.SqlClient
Public Class Form1
    Dim MaxRe As Boolean = False
    Dim point As New System.Drawing.Point()
    Dim X, Y As Integer
    Dim Default_Gray As Color
    Dim User_ID As String
    Dim User_name As String
    Dim Priv_Class As String
    Dim IsPatient As Boolean
    Dim IsNewReport As Boolean
    Dim id_patient As Integer
    Dim hasAppoint As Boolean
    Dim uid As String
    Dim tble_ucp As New DataTable("Table")

    Dim index As Integer

    Dim connection As New SqlConnection(Dentral.My.Settings.Dentral_Conn)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SedentralDataSet2.user_type' table. You can move, or remove it, as needed.
        Me.User_typeTableAdapter.Fill(Me.SedentralDataSet2.user_type)
        'TODO: This line of code loads data into the 'SedentralDataSet2.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.SedentralDataSet2.Employee)

        'TODO: This line of code loads data into the 'SedentralDataSet2.sup_type' table. You can move, or remove it, as needed.
        Me.Sup_typeTableAdapter.Fill(Me.SedentralDataSet2.sup_type)

        'TODO: This line of code loads data into the 'SedentralDataSet2.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.SedentralDataSet2.Department)


        'TODO: This line of code loads data into the 'SedentralDataSet2.getDoctor' table. You can move, or remove it, as needed.
        Me.GetDoctorTableAdapter.Fill(Me.SedentralDataSet2.getDoctor)
        'TODO: This line of code loads data into the 'SedentralDataSet2.getDoctor' table. You can move, or remove it, as needed.
        Me.GetDoctorTableAdapter.Fill(Me.SedentralDataSet2.getDoctor)


        'Me.Show_finTableAdapter.Fill1(Me.SedentralDataSe)
        'TODO: This line of code loads data into the 'SedentralDataSet2.medi_show' table. You can move, or remove it, as needed.
        Me.Medi_showTableAdapter.Fill(Me.SedentralDataSet2.medi_show)

        'TODO: This line of code loads data into the 'SedentralDataSet.show_fin' table. You can move, or remove it, as needed.
        Me.Show_finTableAdapter.Fill(Me.SedentralDataSet.show_fin)


        connection.Open()
        'Login Load'
        Dim username_load_command As New SqlCommand("Select [User_ID] from [dbo].[User]", connection)
        Dim username_load As New SqlDataAdapter(username_load_command)
        Dim username_table As New DataTable()

        username_load.Fill(username_table)
        Username.DataSource = username_table
        Username.DisplayMember = "User_ID"
        Username.ValueMember = "User_ID"
        'End Login Load'
        connection.Close()
    End Sub

    Private Sub btn_exit_MouseHover(sender As Object, e As EventArgs) Handles btn_exit.MouseHover
        btn_exit.Image = New Bitmap(My.Resources.exit_hover)
    End Sub

    Private Sub btn_exit_MouseLeave(sender As Object, e As EventArgs) Handles btn_exit.MouseLeave
        btn_exit.Image = New Bitmap(My.Resources._exit)
    End Sub

    Private Sub btn_exit_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_exit.MouseDown
        btn_exit.Image = New Bitmap(My.Resources.exit_down)
    End Sub

    Private Sub btn_exit_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_exit.MouseUp
        btn_exit.Image = New Bitmap(My.Resources.exit_hover)
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.MouseClick
        Close()
    End Sub

    Private Sub btn_min_MouseHover(sender As Object, e As EventArgs) Handles btn_min.MouseHover
        btn_min.Image = New Bitmap(My.Resources.min_hover)
    End Sub

    Private Sub btn_min_MouseLeave(sender As Object, e As EventArgs) Handles btn_min.MouseLeave
        btn_min.Image = New Bitmap(My.Resources.min)
    End Sub

    Private Sub btn_min_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_min.MouseDown
        btn_min.Image = New Bitmap(My.Resources.min_down)
    End Sub

    Private Sub btn_min_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_min.MouseUp
        btn_min.Image = New Bitmap(My.Resources.min_hover)
    End Sub

    Private Sub btn_min_MouseClick(sender As Object, e As MouseEventArgs) Handles btn_min.MouseClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Taskbar_MouseMove(sender As Object, e As MouseEventArgs) Handles Taskbar.MouseMove
        If e.Button = MouseButtons.Left Then
            point = Control.MousePosition
            point.X -= (X)
            point.Y -= (Y)
            Me.Location = point
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As MouseEventArgs) Handles btn_exit.MouseClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs)
        connection.Open()
        Dim load_user As New SqlCommand("Select * from [dbo].[User] Where ([User_ID]='" & Username.SelectedValue & "') AND ([User_Pass] = '" & Password.Text & "')", connection)
        Dim read As SqlDataReader = load_user.ExecuteReader()

        If read.Read() Then

            User_ID = read("User_ID").ToString()
            If read("User_Access").ToString() = 2 Then
                Priv_Class = 2
                'btn_Admin.BackColor = TransparencyKey
                'btn_Admin.Cursor = Cursors.Hand
            Else
                'btn_Admin.BackColor = Default_Gray
                'btn_Admin.Cursor = Cursors.Default
            End If

            Dim load_name As New SqlCommand("Select [Emp_Fname],[Emp_Lname] from [dbo].[Employee] Where [Emp_ID] = '" & read("Fori_User_Id").ToString & "'", connection)
            read.Close()
            Dim read_emp As SqlDataReader = load_name.ExecuteReader()
            If read_emp.Read() Then
                Dim fname As String = read_emp("Emp_Fname").ToString()
                Dim lname As String = read_emp("Emp_Lname").ToString()
                User_name = fname + " " + lname
                'usern.Text = User_name
                Set_Panel(Home)
                btn_home.FlatAppearance.BorderSize = 1
                Login(True)
            End If
            read_emp.Close()
        Else
            MessageBox.Show("กรอกรหัสผ่านผิด.", "Wrong Password.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        connection.Close()
    End Sub
    Private Sub btn_Login_MouseDown(sender As Object, e As MouseEventArgs)
        btn_Login.BackgroundImage = New Bitmap(My.Resources.Login_Down)
    End Sub

    Private Sub btn_Login_MouseUp(sender As Object, e As MouseEventArgs)
        btn_Login.BackgroundImage = New Bitmap(My.Resources.Login_Default)
    End Sub

    Private Sub Taskbar_MouseDown(sender As Object, e As MouseEventArgs) Handles Taskbar.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub search_fin_TextChanged(sender As Object, e As EventArgs) Handles search_fin.TextChanged
        Me.Show_finTableAdapter.FillBy(Me.SedentralDataSet.show_fin, search_fin.Text)

    End Sub

    Private Sub rec_add_med_name_SelectedIndexChanged(sender As Object, e As EventArgs)
        'rec_add_med_cnt.Text = rec_add_med_name.SelectedValue
    End Sub


    Private Sub show_finan_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles show_finan.CellMouseDoubleClick
        Dim data_fin As DataGridViewRow = show_finan.Rows(e.RowIndex)
        Me.After_sel_finTableAdapter.Fill(Me.SedentralDataSet.after_sel_fin, data_fin.Cells(6).Value.ToString)
        Set_Panel(Finan_aftersel)
    End Sub

    Private Sub btn_back_after_Click(sender As Object, e As EventArgs) Handles btn_back_after.Click
        Set_Panel(Finan)
    End Sub

    Private Sub Set_Panel(Pn As DblBufferedPanel)
        Record_main.Visible = False
        Record_searchrec_list.Visible = False
        Record_search_pat.Visible = False
        Record_after_sel_his.Visible = False
        Record_history.Visible = False
        Home.Visible = False
        Finan.Visible = False
        Finan_aftersel.Visible = False
        Drug.Visible = False
        Employee.Visible = False
        Admin.Visible = False
        Pn.Visible = True
    End Sub

    Private Sub Login(Status As Boolean)
        If Status Then
            GUI.Visible = True
            Login_p.Visible = False
        Else
            Login_p.Visible = True
            GUI.Visible = False
        End If
    End Sub

    Private Sub btn_Record_Click(sender As Object, e As EventArgs) Handles btn_Record.Click
        Set_Hold(btn_Record, 1)
        Set_Panel(Record_main)
        'TODO: This line of code loads data into the 'SedentralDataSet2.data_rec' table. You can move, or remove it, as needed.
        Me.Data_recTableAdapter.Fill1(Me.SedentralDataSet2.data_rec)
    End Sub

    Private Sub btn_Drug_Click(sender As Object, e As EventArgs) Handles btn_Drug.Click
        Set_Hold(btn_Drug, 1)
        Set_Panel(Drug)
        'TODO: This line of code loads data into the 'SedentralDataSet2.medi_s1' table. You can move, or remove it, as needed.
        Me.Medi_s1TableAdapter.Fill(Me.SedentralDataSet2.medi_s1)
    End Sub

    Private Sub btn_Finan_Click(sender As Object, e As EventArgs) Handles btn_Finan.Click
        Set_Hold(btn_Finan, 1)
        Set_Panel(Finan)
        'TODO: This line of code loads data into the 'SedentralDataSet1.show_fin' table. You can move, or remove it, as needed.
        Me.Show_finTableAdapter.Fill(Me.SedentralDataSet1.show_fin)
    End Sub

    Private Sub btn_Emp_Click(sender As Object, e As EventArgs) Handles btn_Emp.Click
        Set_Hold(btn_Emp, 1)
        Set_Panel(Employee)
        'TODO: This line of code loads data into the 'SedentralDataSet2.Emp_dep' table. You can move, or remove it, as needed.
        Me.Emp_depTableAdapter.Fill(Me.SedentralDataSet2.Emp_dep)
    End Sub

    Private Sub btn_Admin_Click(sender As Object, e As EventArgs) Handles btn_Admin.Click
        If Priv_Class = 2 Then
            Set_Hold(btn_Admin, 1)
            Set_Panel(Admin)
            'TODO: This line of code loads data into the 'SedentralDataSet2.U_a' table. You can move, or remove it, as needed.
            Me.U_aTableAdapter.Fill(Me.SedentralDataSet2.U_a)
        Else
            MessageBox.Show("เข้าใช้ได้เฉพาะ Admin เท่านั้น", "Admin Only", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btn_search_rec_Click(sender As Object, e As EventArgs) Handles btn_search_rec.Click
        If IsNumeric(tb_idcard_search.Text) Then
            If tb_idcard_search.TextLength = 13 Then
                Dim text_search As String = tb_idcard_search.Text
                connection.Open()
                Dim tb_search_command As New SqlCommand("Select * from [dbo].[Patient] where [patient_id_card] = '" & text_search & "'", connection)
                Dim read_record As SqlDataReader = tb_search_command.ExecuteReader()

                If read_record.Read() Then
                    rec_fname.Text = read_record("patient_Fname").ToString
                    rec_lname.Text = read_record("patient_Lname").ToString
                    cb_rec_sex.Text = read_record("patient_Gender").ToString
                    date_time_rec.Value = read_record("patient_Birth").ToString.Replace("-", "/")
                    rec_weight.Text = read_record("patient_Wight").ToString 'Weight
                    rec_height.Text = read_record("patient_Height").ToString
                    rec_allergic.Text = read_record("patient_allergic_druge").ToString
                    rec_id_card.Text = read_record("patient_id_card").ToString
                    rec_nation.Text = read_record("patient_nation").ToString
                    rec_race.Text = read_record("patient_ethticity").ToString
                    rec_ligion.Text = read_record("patient_regal").ToString
                    rec_tel2.Text = read_record("patient_tel").ToString
                    rec_tel1.Text = read_record("patient_tel_home").ToString
                    rec_other_fname.Text = read_record("contact_fname").ToString
                    rec_other_lname.Text = read_record("contact_lname").ToString
                    rec_other_tel.Text = read_record("contact_tel").ToString
                    rec_other_relation.Text = read_record("contact_relation").ToString
                    IsPatient = True
                    his_rec.Visible = True
                    question_add.Text = ""
                    rec_next.Visible = True
                Else
                    rec_fname.Text = ""
                    rec_lname.Text = ""
                    cb_rec_sex.Text = ""
                    date_time_rec.Value = DateTime.Now
                    rec_weight.Text = ""
                    rec_height.Text = ""
                    rec_allergic.Text = ""
                    rec_id_card.Text = ""
                    rec_nation.Text = ""
                    rec_race.Text = ""
                    rec_ligion.Text = ""
                    rec_tel2.Text = ""
                    rec_tel1.Text = ""
                    rec_other_fname.Text = ""
                    rec_other_lname.Text = ""
                    rec_other_tel.Text = ""
                    rec_other_relation.Text = ""
                    rec_id_card.Text = text_search
                    question_add.Text = " ไม่พบในรายการ จะเพิ่มรายการหรือไม่?"
                    add_file.Visible = True
                    IsPatient = False
                    his_rec.Visible = False
                    rec_save.Text = "เพิ่มแฟ้มข้อมูลใหม่"
                End If
                Set_Panel(Record_search_pat)
                connection.Close()
            Else
                MsgBox("กรุณาระบุให้ครบ 13 ตัว")
            End If
        Else
            MsgBox("กรุณาระบุเฉพาะตัวเลข")
        End If
    End Sub

    Private Sub his_rec_Paint(sender As Object, e As PaintEventArgs) Handles his_rec.Paint

    End Sub

    Private Sub rec_save_Click(sender As Object, e As EventArgs) Handles rec_save.Click
        Dim msg_vad As String = "กรุณาระบุ "
        If check_text(rec_fname) Then
            msg_vad += "-นามสกุล "
        End If
        If check_text(rec_fname) Then
            msg_vad += "-เชื้อชาติ "
        End If
        If check_text(rec_fname) Then
            msg_vad += "-สัญชาติ "
        End If
        If check_text(rec_fname) Then
            msg_vad += "-ศาสนา "
        End If
        If check_text(rec_fname) Then
            msg_vad += "-โทรศัพท์มือถือ "
        End If
        If check_text(rec_fname) Then
            msg_vad += "-ส่วนสูง "
        End If
        If check_text(rec_fname) Then
            msg_vad += "-ประวัติการแพ้ยา "
        End If
        If msg_vad IsNot "กรุณาระบุ " Then
            MsgBox(msg_vad)
        Else
            If IsPatient Then
                Dim str_update As String = " UPDATE [dbo].[Patient] SET [patient_Fname] = '" & rec_fname.Text & "'
                                                  ,[patient_Lname] = '" & rec_lname.Text & "'
                                                  ,[patient_Gender] = '" & cb_rec_sex.Text & "'
                                                  ,[patient_Birth] = '" & date_time_rec.Value & "'
                                                  ,[patient_Wight] = '" & rec_weight.Text & "'
                                                  ,[patient_Height] = '" & rec_height.Text & "'
                                                  ,[patient_allergic_druge] = '" & rec_allergic.Text & "'
                                                  ,[patient_nation] = '" & rec_nation.Text & "'
                                                  ,[patient_ethticity] = '" & rec_race.Text & "'
                                                  ,[patient_regal] = '" & rec_ligion.Text & "'
                                                  ,[patient_tel] = '" & rec_tel2.Text & "'
                                                  ,[patient_tel_home] = '" & rec_tel1.Text & "'
                                                  ,[contact_fname] = '" & rec_other_fname.Text & "'
                                                  ,[contact_lname] = '" & rec_other_lname.Text & "'
                                                  ,[contact_tel] = '" & rec_other_tel.Text & "'
                                                  ,[contact_relation] = '" & rec_other_relation.Text & "'
                                             WHERE [patient_id_card] = '" & rec_id_card.Text & "'"
                Dim sql_update_record As New SqlCommand(str_update, connection)
                connection.Open()
                If sql_update_record.ExecuteNonQuery Then
                    MsgBox("บันทึกสำเร็จ")
                Else
                    MsgBox("บันทึกไม่สำเร็จ")
                End If
                connection.Close()
            Else

                Dim str_insert As String = "Insert into [dbo].[Patient] Values ('" & rec_fname.Text & "'
                                                                               ,'" & rec_lname.Text & "'
                                                                               ,'" & cb_rec_sex.Text & "'
                                                                               ,'" & date_time_rec.Value.ToString("yyyy-MM-dd") & "'
                                                                               ,'" & rec_weight.Text & "'
                                                                               ,'" & rec_height.Text & "'
                                                                               ,'" & rec_allergic.Text & "'
                                                                               ,'" & rec_id_card.Text & "'
                                                                               ,'" & rec_nation.Text & "'
                                                                               ,'" & rec_race.Text & "'
                                                                               ,'" & rec_ligion.Text & "'
                                                                               ,'" & rec_tel2.Text & "'
                                                                               ,'" & rec_tel1.Text & "'
                                                                               ,'" & rec_other_fname.Text & "'
                                                                               ,'" & rec_other_lname.Text & "'
                                                                               ,'" & rec_other_tel.Text & "'
                                                                               ,'" & rec_other_relation.Text & "')"
                Dim sql_insert_record As New SqlCommand(str_insert, connection)
                connection.Open()
                If sql_insert_record.ExecuteNonQuery Then
                    MsgBox("เพิ่มแฟ้มสำเร็จ")
                    IsPatient = True
                    IsNewReport = True
                    rec_next.Visible = True
                Else
                    MsgBox("เพิ่มแฟ้มไม่สำเร็จ")
                End If
                connection.Close()
                rec_save.Text = "บันทึกแฟ้มข้อมูล"
            End If

        End If

    End Sub

    Function check_text(tb As TextBox)
        Return tb.Text = ""
    End Function

    Private Sub rec_btn_add_Click(sender As Object, e As EventArgs) Handles rec_btn_add.Click
        his_rec.Visible = True
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Set_Panel(Home)
        Set_Hold(btn_home, 0)
        btn_home.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub rec_next_Click(sender As Object, e As EventArgs) Handles rec_next.Click
        appoint.Visible = False
        name_1.Text = rec_fname.Text + " " + rec_lname.Text
        id_patient = Me.Query_b1.GetPatient_Id(rec_id_card.Text)
        Me.Query_b1.Create_report(id_patient)
        record_id_list.Text = Me.Query_b1.Get_Current_id
        Set_Panel(Record_searchrec_list)
    End Sub

    Private Sub Set_Hold(btn_sel As Button, on_off As Integer)
        btn_Record.BackgroundImage = My.Resources.menu_1
        btn_Drug.BackgroundImage = My.Resources.menu_2
        btn_Finan.BackgroundImage = My.Resources.menu_1
        btn_Emp.BackgroundImage = My.Resources.menu_2
        btn_Admin.BackgroundImage = My.Resources.menu_1
        btn_home.FlatAppearance.BorderSize = 0
        If on_off = 0 Then

        Else
            btn_sel.BackgroundImage = My.Resources.btn_Hold
        End If

    End Sub

    Private Sub btn_search_report_Click(sender As Object, e As EventArgs) Handles btn_search_report.Click
        If IsNumeric(tb_list.Text) Then
            Dim text_search As String = tb_list.Text
            connection.Open()
            Dim sql_search = "SELECT        report.*, Patient.patient_Fname, Patient.patient_Lname
                            FROM            Patient INNER JOIN
                                                     report ON Patient.patient_Id = report.report_patient
                            WHERE        (report.report_id = '" & text_search & "')"
            Dim tb_search_command As New SqlCommand(sql_search, connection)
            Dim read_report As SqlDataReader = tb_search_command.ExecuteReader()

            If read_report.Read() Then
                name_1.Text = read_report("patient_fname").ToString + " " + read_report("patient_lname").ToString
                'tb_detail.Text = read_report("report_detail").ToString()
                'TODO: This line of code loads data into the 'SedentralDataSet2.list_med' table. You can move, or remove it, as needed.
                Me.List_medTableAdapter.FillBy(Me.SedentralDataSet2.list_med, text_search)
                record_id_list.Text = text_search
                Set_Panel(Record_searchrec_list)
                appoint.Visible = True
                If read_report("report_appoint_has").ToString = "Y" Then
                    appoint.Text = "มีนัดวันที่ " + read_report("report_appoint_date").ToString + " เวลา " + read_report("report_appoint_time").ToString
                Else
                    appoint.Text = "ไม่มีการนัดพบ"
                End If
                IsNewReport = False
            Else
                MsgBox("ไม่พบเลขใบรายการนี้")
            End If
            connection.Close()
        Else
            MsgBox("กรุณาระบเฉพาะตัวเลข")
        End If
    End Sub

    Private Sub btn_med_add_Click(sender As Object, e As EventArgs) Handles btn_med_add.MouseClick
        If Me.List_medTableAdapter.Count(rec_add_med_name.SelectedValue, record_id_list.Text) = 1 Then
            Dim ls_d = Me.List_medTableAdapter.getID(record_id_list.Text, rec_add_med_name.SelectedValue)
            Me.List_medTableAdapter.UpdateQuery(rec_add_med_cnt.Text, ls_d)
        Else
            Me.List_medTableAdapter.InsertQuery(record_id_list.Text, rec_add_med_name.SelectedValue, rec_add_med_cnt.Text)
        End If
        data_med_list.DataSource = Nothing
        Me.List_medTableAdapter.FillBy(Me.SedentralDataSet2.list_med, record_id_list.Text)
        data_med_list.DataSource = Me.SedentralDataSet2.list_med.CopyToDataTable()
        data_med_list.Refresh()
    End Sub

    Private Sub data_record_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles data_record.CellMouseClick
        Try
            tb_list.Text = data_record.Rows(e.RowIndex).Cells(0).Value.ToString
            tb_idcard_search.Text = data_record.Rows(e.RowIndex).Cells(1).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Record_searchrec_list_Paint(sender As Object, e As PaintEventArgs) Handles Record_searchrec_list.Paint

    End Sub

    Private Sub ชื่อ_Click(sender As Object, e As EventArgs) Handles ชื่อ.Click

    End Sub

    Private Sub rec_add_med_cnt_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub record_id_list_Click(sender As Object, e As EventArgs) Handles record_id_list.Click

    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click

    End Sub

    Private Sub name_1_Click(sender As Object, e As EventArgs) Handles name_1.Click

    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub rec_med_date_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_rec_med_fin_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub date_time_rec_ValueChanged(sender As Object, e As EventArgs) Handles date_time_rec.ValueChanged
        Label7.Text = date_time_rec.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub btn_rec_med_fin_Click_1(sender As Object, e As EventArgs) Handles btn_rec_med_fin.Click
        If check_appoint.Checked = True Then
            Dim time As String = appoint_hr.Text + ":" + appoint_min.Text + ":00"
            Me.Query_b1.UpdateQuery("Y", rec_med_date.Value.ToString("yyyy-MM-dd"), time, appoint_doctor.SelectedValue.ToString, record_id_list.Text)
        Else
            Me.Query_b1.Set_No_ap(record_id_list.Text)
        End If
        Set_Panel(Record_main)
        Set_Hold(btn_Record, 1)
    End Sub

    Private Sub data_med_list_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_med_list.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        Dim grid = DirectCast(sender, DataGridView)

        If TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            If grid.Columns(e.ColumnIndex).Name = "list_med_del" Then
                Dim check As MsgBoxResult = MessageBox.Show("คุณแน่ใจไหมว่าจะลบ", "เตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If check = MsgBoxResult.Yes Then
                    Me.List_medTableAdapter.DeleteQuery(data_med_list.Rows(e.RowIndex).Cells(5).Value.ToString)
                    MsgBox("Deleted")
                End If
                data_med_list.DataSource = Nothing
                Me.List_medTableAdapter.FillBy(Me.SedentralDataSet2.list_med, record_id_list.Text)
                data_med_list.DataSource = Me.SedentralDataSet2.list_med.CopyToDataTable()
                data_med_list.Refresh()
            End If
        End If
    End Sub

    Private Sub history_rec_Click(sender As Object, e As EventArgs) Handles history_rec.Click
        'TODO: This line of code loads data into the 'SedentralDataSet2.history_record' table. You can move, or remove it, as needed.
        Me.History_recordTableAdapter.FillBy(Me.SedentralDataSet2.history_record, Me.Query_b1.Get_PID_RID(tb_list.Text))
        Set_Panel(Record_history)
    End Sub

    Private Sub btn_his_back_Click(sender As Object, e As EventArgs) Handles btn_his_back.Click
        Set_Panel(Record_history)
    End Sub

    Private Sub btn_his_bk_Click(sender As Object, e As EventArgs)
        Set_Panel(Record_main)
    End Sub

    Private Sub update_emp_Click(sender As Object, e As EventArgs) Handles update_emp.Click
        Emp_depTableAdapter.UpdateQuery(emp_fname.Text, emp_lname.Text, emp_sex.Text, emp_salary.Text, emp_dep.SelectedValue, emp_idd.Text)
        data_emp.DataSource = Nothing
        Me.Emp_depTableAdapter.Fill(Me.SedentralDataSet2.Emp_dep)
        data_emp.DataSource = Me.SedentralDataSet2.Emp_dep.CopyToDataTable()
        data_emp.Refresh()
    End Sub

    Private Sub data_history_rec_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles data_history_rec.CellMouseDoubleClick
        'TODO: This line of code loads data into the 'SedentralDataSet2.after_sel_rec' table. You can move, or remove it, as needed.
        Me.After_sel_recTableAdapter.FillBy(Me.SedentralDataSet2.after_sel_rec, data_history_rec.Rows(e.RowIndex).Cells(1).Value.ToString)
        Set_Panel(Record_after_sel_his)
    End Sub

    Private Sub emp_insert_Click(sender As Object, e As EventArgs) Handles emp_insert.Click
        Emp_depTableAdapter.InsertQuery(emp_fname.Text, emp_lname.Text, emp_sex.Text, emp_salary.Text, emp_dep.SelectedValue)
        data_emp.DataSource = Nothing
        Me.Emp_depTableAdapter.Fill(Me.SedentralDataSet2.Emp_dep)
        data_emp.DataSource = Me.SedentralDataSet2.Emp_dep.CopyToDataTable()
        data_emp.Refresh()
    End Sub

    Private Sub emp_del_Click(sender As Object, e As EventArgs) Handles emp_del.Click
        If MsgBox("คุณแน่ใจหรือไม่ที่ต้องการลบ " + emp_idd.Text, MsgBoxStyle.OkCancel) Then
            Emp_depTableAdapter.DeleteQuery(emp_idd.Text)
            data_emp.DataSource = Nothing
            Me.Emp_depTableAdapter.Fill(Me.SedentralDataSet2.Emp_dep)
            data_emp.DataSource = Me.SedentralDataSet2.Emp_dep.CopyToDataTable()
            data_emp.Refresh()
        End If
    End Sub

    Private Sub medi_insert_Click(sender As Object, e As EventArgs) Handles medi_insert.Click

        Medi_s1TableAdapter.InsertQuery(medi_name.Text, medi_price.Text, medi_detail.Text, medi_count.Text, medi_status.SelectedValue.ToString)
        data_medic.DataSource = Nothing
        Me.Medi_s1TableAdapter.Fill(Me.SedentralDataSet2.medi_s1)
        data_medic.DataSource = Me.SedentralDataSet2.medi_s1.CopyToDataTable()
        data_medic.Refresh()
    End Sub

    Private Sub medi_update_Click(sender As Object, e As EventArgs) Handles medi_update.Click
        Medi_s1TableAdapter.UpdateQuery(medi_name.Text, medi_price.Text, medi_detail.Text, medi_count.Text, medi_status.SelectedValue.ToString, medi_idd.Text)
        data_medic.DataSource = Nothing
        Me.Medi_s1TableAdapter.Fill(Me.SedentralDataSet2.medi_s1)
        data_medic.DataSource = Me.SedentralDataSet2.medi_s1.CopyToDataTable()
        data_medic.Refresh()
    End Sub

    Private Sub medi_delete_Click(sender As Object, e As EventArgs) Handles medi_delete.Click
        If MsgBox("คุณแน่ใจหรือไม่ที่ต้องการลบ " + medi_idd.Text, MsgBoxStyle.OkCancel) Then
            Medi_s1TableAdapter.DeleteQuery(medi_idd.Text)
            data_medic.DataSource = Nothing
            Me.Medi_s1TableAdapter.Fill(Me.SedentralDataSet2.medi_s1)
            data_medic.DataSource = Me.SedentralDataSet2.medi_s1.CopyToDataTable()
            data_medic.Refresh()
        End If
    End Sub

    Private Sub data_emp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_emp.CellClick
        emp_idd.Text = data_emp.Rows(e.RowIndex).Cells(0).Value.ToString
        emp_fname.Text = data_emp.Rows(e.RowIndex).Cells(1).Value.ToString
        emp_lname.Text = data_emp.Rows(e.RowIndex).Cells(2).Value.ToString
        emp_sex.Text = data_emp.Rows(e.RowIndex).Cells(3).Value.ToString
        emp_salary.Text = data_emp.Rows(e.RowIndex).Cells(4).Value.ToString
        emp_dep.Text = data_emp.Rows(e.RowIndex).Cells(5).Value.ToString
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        U_aTableAdapter.InsertQuery(tb_add_user.Text, tb_add_pass.Text, cb_add_emp.SelectedValue.ToString, cb_add_access.SelectedValue.ToString)
        data_User.DataSource = Nothing
        Me.U_aTableAdapter.Fill(Me.SedentralDataSet2.U_a)
        data_User.DataSource = Me.SedentralDataSet2.U_a.CopyToDataTable()
        data_User.Refresh()
    End Sub

    Private Sub user_edits_Click(sender As Object, e As EventArgs) Handles user_edits.Click
        U_aTableAdapter.UpdateQuery(tb_add_user.Text, tb_add_pass.Text, cb_add_emp.SelectedValue.ToString, cb_add_access.SelectedValue.ToString, admin_old_id.Text)
        data_User.DataSource = Nothing
        Me.U_aTableAdapter.Fill(Me.SedentralDataSet2.U_a)
        data_User.DataSource = Me.SedentralDataSet2.U_a.CopyToDataTable()
        data_User.Refresh()
    End Sub

    Private Sub user_remove_Click(sender As Object, e As EventArgs) Handles user_remove.Click
        If MsgBox("คุณแน่ใจหรือไม่ที่ต้องการลบ " + admin_old_id.Text, MsgBoxStyle.OkCancel) Then
            U_aTableAdapter.DeleteQuery(admin_old_id.Text)
            data_User.DataSource = Nothing
            Me.U_aTableAdapter.Fill(Me.SedentralDataSet2.U_a)
            data_User.DataSource = Me.SedentralDataSet2.U_a.CopyToDataTable()
            data_User.Refresh()
        End If
    End Sub

    Private Sub data_medic_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles data_medic.CellMouseClick
        medi_idd.Text = data_medic.Rows(e.RowIndex).Cells(0).Value.ToString
        medi_name.Text = data_medic.Rows(e.RowIndex).Cells(1).Value.ToString
        medi_detail.Text = data_medic.Rows(e.RowIndex).Cells(2).Value.ToString
        medi_price.Text = data_medic.Rows(e.RowIndex).Cells(3).Value.ToString
        medi_count.Text = data_medic.Rows(e.RowIndex).Cells(4).Value.ToString
        medi_status.Text = data_medic.Rows(e.RowIndex).Cells(5).Value.ToString
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click

    End Sub

    Private Sub btn_Login_Click_1(sender As Object, e As EventArgs) Handles btn_Login.Click
        connection.Open()
        Dim load_user As New SqlCommand("Select * from [dbo].[User] Where ([User_ID]='" & Username.SelectedValue & "') AND ([User_Pass] = '" & Password.Text & "')", connection)
        Dim read As SqlDataReader = load_user.ExecuteReader()

        If read.Read() Then
            uid = read("id").ToString()
            User_ID = read("User_ID").ToString()
            If read("User_Access").ToString() = "2" Then
                Priv_Class = 2
            Else
                Priv_Class = read("User_Access").ToString()
            End If

            Dim load_name As New SqlCommand("Select [Emp_Fname],[Emp_Lname] from [dbo].[Employee] Where [Emp_ID] = '" & read("Fori_User_Id").ToString & "'", connection)
            read.Close()
            Dim read_emp As SqlDataReader = load_name.ExecuteReader()
            If read_emp.Read() Then
                Dim fname As String = read_emp("Emp_Fname").ToString()
                Dim lname As String = read_emp("Emp_Lname").ToString()
                User_name = fname + " " + lname
                usern.Text = User_name
                Set_Panel(Home)
                Set_Hold(btn_Admin, 0)
                Login(True)
            End If
            read_emp.Close()
        Else
            MessageBox.Show("กรอกรหัสผ่านผิด.", "Wrong Password.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        connection.Close()
    End Sub

    Private Sub btn_med_add_Click(sender As Object, e As MouseEventArgs) Handles btn_med_add.MouseClick

    End Sub

    ' Private Sub profile_image_Click(sender As Object, e As EventArgs) Handles profile_image.Click
    '    Dim OpenFileDialog1 As New OpenFileDialog
    '
    '
    '   With OpenFileDialog1
    '      .CheckFileExists = True
    '     .ShowReadOnly = False
    '    .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg;*.png"
    '   .FilterIndex = 2
    '  If .ShowDialog = DialogResult.OK Then
    '     ' Load the specified file into a PictureBox control.
    '    profile_image.Image = Image.FromFile(.FileName)
    '   connection.Open()
    '
    '           Dim pic_sql As New SqlCommand("select [dbo].[id] from [dbo].[User] where [dbo].[User_ID] = '" & Username.Text & "'", connection)
    '          Dim read_pic As SqlDataReader = pic_sql.ExecuteReader
    ''         If read_pic.Read() Then
    '           profile_image.Image.Save("\pic\" + read_pic("id").ToString + ".jpg")
    '      End If
    '     read_pic.Close()
    '    connection.Close()
    'End If
    '   .Dispose()
    '  End With
    ' End Sub

    Private Sub data_User_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles data_User.CellMouseClick
        admin_old_id.Text = data_User.Rows(e.RowIndex).Cells(0).Value.ToString
        tb_add_user.Text = data_User.Rows(e.RowIndex).Cells(0).Value.ToString
        tb_add_pass.Text = data_User.Rows(e.RowIndex).Cells(1).Value.ToString
        cb_add_emp.SelectedValue = data_User.Rows(e.RowIndex).Cells(4).Value.ToString
        cb_add_access.Text = data_User.Rows(e.RowIndex).Cells(3).Value.ToString
    End Sub
End Class
Public Class DblBufferedPanel
    Inherits Panel
    Public Sub New()
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub
End Class