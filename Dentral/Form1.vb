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
    Dim tble_ucp As New DataTable("Table")

    Dim index As Integer

    Dim connection As New SqlConnection("Data Source=tcp:192.168.6.11, 1433;Database=sedentral;User ID=se_admin;Password=Dentis1234;")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SedentralDataSet2.medi_show' table. You can move, or remove it, as needed.
        Me.Medi_showTableAdapter.Fill(Me.SedentralDataSet2.medi_show)
        'TODO: This line of code loads data into the 'SedentralDataSet1.show_fin' table. You can move, or remove it, as needed.
        Me.Show_finTableAdapter.Fill(Me.SedentralDataSet1.show_fin)
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

    Private Sub Login(Status As Boolean)
        If Status Then
            'U.Visible = True
            'Login_p.Visible = False
        Else
            'Login_p.Visible = True
            'U.Visible = False
        End If
    End Sub
    Private Sub Taskbar_MouseDown(sender As Object, e As MouseEventArgs) Handles Taskbar.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub search_fin_TextChanged(sender As Object, e As EventArgs) Handles search_fin.TextChanged
        Me.Show_finTableAdapter.FillBy(Me.SedentralDataSet.show_fin, search_fin.Text)

    End Sub

    Private Sub rec_add_med_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rec_add_med_name.SelectedIndexChanged
        'rec_add_med_cnt.Text = rec_add_med_name.SelectedValue
    End Sub

    Private Sub data_User_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles data_User.RowsAdded
        If data_User.Rows(e.RowIndex).Cells(3).Value = 2 Then
            data_User.Rows(e.RowIndex).Cells(3).Value = "แอดมิน"
            'End If
        ElseIf data_User.Rows(e.RowIndex).Cells(3).Value = 1 Then
            data_User.Rows(e.RowIndex).Cells(3).Value = "หมอ"
            'End If
        ElseIf data_User.Rows(e.RowIndex).Cells(3).Value = 0 Then
            data_User.Rows(e.RowIndex).Cells(3).Value = "ทั่วไป"
        End If


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
        Home.Visible = False
        Finan.Visible = False
        Finan_aftersel.Visible = False
        Drug.Visible = False
        Employee.Visible = False
        Admin.Visible = False
        Pn.Visible = True
    End Sub

    Private Sub btn_Record_Click(sender As Object, e As EventArgs) Handles btn_Record.Click
        Set_Hold(btn_Record, 1)
        Set_Panel(Record_main)
    End Sub

    Private Sub btn_Drug_Click(sender As Object, e As EventArgs) Handles btn_Drug.Click
        Set_Hold(btn_Drug, 1)
        Set_Panel(Drug)
    End Sub

    Private Sub btn_Finan_Click(sender As Object, e As EventArgs) Handles btn_Finan.Click
        Set_Hold(btn_Finan, 1)
        Set_Panel(Finan)
    End Sub

    Private Sub btn_Emp_Click(sender As Object, e As EventArgs) Handles btn_Emp.Click
        Set_Hold(btn_Emp, 1)
        Set_Panel(Employee)
    End Sub

    Private Sub btn_Admin_Click(sender As Object, e As EventArgs) Handles btn_Admin.Click
        Set_Hold(btn_Admin, 1)
        Set_Panel(Admin)
    End Sub

    Private Sub btn_search_rec_Click(sender As Object, e As EventArgs) Handles btn_search_rec.Click
        Dim text_search As String = tb_idcard_search.Text
        connection.Open()
        Dim tb_search_command As New SqlCommand("Select * from [dbo].[Patient] where [patient_id_card] = '" & text_search & "'", connection)
        Dim read_record As SqlDataReader = tb_search_command.ExecuteReader()

        If read_record.Read() Then
            rec_fname.Text = read_record("patient_Fname").ToString
            rec_lname.Text = read_record("patient_Lname").ToString
            cb_rec_sex.Text = read_record("patient_Gender").ToString
            date_time_rec.Value = read_record("patient_Birth").ToString.Replace("-", "/")
            'date_time_rec.Value.ToShortDateString
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
            rec_id_card.Text = text_search
            question_add.Text = " ไม่พบในรายการ จะเพิ่มรายการหรือไม่?"
            add_file.Visible = True
            IsPatient = False
        End If
        Set_Panel(Record_search_pat)
        connection.Close()
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
                rec_save.Text = "เพิ่มแฟ้มข้อมูลใหม่"
                Dim str_insert As String = "Insert into [dbo].[Patient] Values ('NULL'
                                                                               ,'" & rec_fname.Text & "'
                                                                               ,'" & rec_lname.Text & "'
                                                                               ,'" & cb_rec_sex.Text & "'
                                                                               ,'" & date_time_rec.Value & "'
                                                                               ,'" & rec_weight.Text & "'
                                                                               ,'" & rec_height.Text & "'
                                                                               ,'" & rec_allergic.Text & "'
                                                                               ,'" & rec_nation.Text & "'
                                                                               ,'" & rec_race.Text & "'
                                                                               ,'" & rec_ligion.Text & "'
                                                                               ,'" & rec_tel2.Text & "'
                                                                               ,'" & rec_tel1.Text & "'
                                                                               ,'" & rec_other_fname.Text & "'
                                                                               ,'" & rec_other_lname.Text & "'
                                                                               ,'" & rec_other_relation.Text & "'
                                                                               ,'" & rec_id_card.Text & "'
                                                                               ,'" & rec_fname.Text & "'
                                                                               ,'" & rec_fname.Text & "'
                                                                               )"
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
        If IsNewReport Then
            name_1.Text = rec_fname.Text + " " + rec_lname.Text
        Else

        End If
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
            Set_Panel(Record_searchrec_list)
        Else
            MsgBox("ไม่พบเลขใบรายการนี้")
        End If
        connection.Close()
    End Sub

    Private Sub btn_med_add_Click(sender As Object, e As EventArgs) Handles btn_med_add.Click

    End Sub

    Private Sub data_record_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles data_record.CellMouseClick
        Try
            tb_list.Text = data_record.Rows(e.RowIndex).Cells(0).Value.ToString
            tb_idcard_search.Text = data_record.Rows(e.RowIndex).Cells(1).Value.ToString
        Catch ex As Exception

        End Try
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