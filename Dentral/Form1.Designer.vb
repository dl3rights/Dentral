﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GUI = New Dentral.DblBufferedPanel()
        Me.Record_main = New Dentral.DblBufferedPanel()
        Me.history_rec = New System.Windows.Forms.Button()
        Me.data_record = New System.Windows.Forms.DataGridView()
        Me.ReportidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientidcardDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชอนามสกลDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportdateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportappointdateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportappointtimeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชอหมอDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypenameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatarecBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SedentralDataSet2 = New Dentral.sedentralDataSet()
        Me.btn_search_rec = New System.Windows.Forms.Button()
        Me.tb_idcard_search = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btn_search_report = New System.Windows.Forms.Button()
        Me.tb_list = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Finan_aftersel = New Dentral.DblBufferedPanel()
        Me.btn_back_after = New System.Windows.Forms.Button()
        Me.after_sel_fin_d = New System.Windows.Forms.DataGridView()
        Me.MedisuppliesnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedisuppliesdetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedisuppliespriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListcountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypenameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AfterselfinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SedentralDataSet = New Dentral.sedentralDataSet()
        Me.Finan = New Dentral.DblBufferedPanel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.search_fin = New System.Windows.Forms.TextBox()
        Me.show_finan = New System.Windows.Forms.DataGridView()
        Me.ชอนามสกลDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportappointdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportappointtimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชอหมอDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientidcardDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowfinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SedentralDataSet1 = New Dentral.sedentralDataSet()
        Me.Record_search_pat = New Dentral.DblBufferedPanel()
        Me.question_add = New System.Windows.Forms.Label()
        Me.rec_id_card = New System.Windows.Forms.Label()
        Me.label00123 = New System.Windows.Forms.Label()
        Me.add_file = New Dentral.DblBufferedPanel()
        Me.rec_btn_add = New System.Windows.Forms.Button()
        Me.his_rec = New Dentral.DblBufferedPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rec_next = New System.Windows.Forms.Button()
        Me.rec_save = New System.Windows.Forms.Button()
        Me.rec_other_relation = New System.Windows.Forms.TextBox()
        Me.rec_other_tel = New System.Windows.Forms.TextBox()
        Me.rec_other_lname = New System.Windows.Forms.TextBox()
        Me.rec_other_fname = New System.Windows.Forms.TextBox()
        Me.rec_allergic = New System.Windows.Forms.TextBox()
        Me.rec_height = New System.Windows.Forms.TextBox()
        Me.rec_tel2 = New System.Windows.Forms.TextBox()
        Me.rec_tel1 = New System.Windows.Forms.TextBox()
        Me.rec_ligion = New System.Windows.Forms.TextBox()
        Me.rec_nation = New System.Windows.Forms.TextBox()
        Me.rec_race = New System.Windows.Forms.TextBox()
        Me.date_time_rec = New System.Windows.Forms.DateTimePicker()
        Me.rec_weight = New System.Windows.Forms.TextBox()
        Me.cb_rec_sex = New System.Windows.Forms.ComboBox()
        Me.rec_lname = New System.Windows.Forms.TextBox()
        Me.rec_fname = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Record_searchrec_list = New Dentral.DblBufferedPanel()
        Me.appoint = New System.Windows.Forms.Label()
        Me.Is_NewReport = New Dentral.DblBufferedPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.appoint_doctor = New System.Windows.Forms.ComboBox()
        Me.GetDoctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label37 = New System.Windows.Forms.Label()
        Me.appoint_min = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.appoint_hr = New System.Windows.Forms.ComboBox()
        Me.rec_add_med_cnt = New System.Windows.Forms.TextBox()
        Me.rec_add_med_name = New System.Windows.Forms.ComboBox()
        Me.MedishowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rec_med_date = New System.Windows.Forms.DateTimePicker()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.check_appoint = New System.Windows.Forms.CheckBox()
        Me.btn_rec_med_fin = New System.Windows.Forms.Button()
        Me.btn_med_add = New System.Windows.Forms.Button()
        Me.name_1 = New System.Windows.Forms.Label()
        Me.ชื่อ = New System.Windows.Forms.Label()
        Me.record_id_list = New System.Windows.Forms.Label()
        Me.data_med_list = New System.Windows.Forms.DataGridView()
        Me.MedisuppliesnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedisuppliesIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListcountDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.list_med_del = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ReportidDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.List_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListmedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Record_after_sel_his = New Dentral.DblBufferedPanel()
        Me.btn_his_back = New System.Windows.Forms.Button()
        Me.data_after_sel_his = New System.Windows.Forms.DataGridView()
        Me.MedisuppliesnameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedisuppliesdetailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedisuppliespriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListcountDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypenameDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AfterselrecBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Record_history = New Dentral.DblBufferedPanel()
        Me.btn_his_bk = New System.Windows.Forms.Button()
        Me.data_history_rec = New System.Windows.Forms.DataGridView()
        Me.ชอนามสกลDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportidDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportdateDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypenameDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HistoryrecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Drug = New Dentral.DblBufferedPanel()
        Me.medi_idd = New System.Windows.Forms.Label()
        Me.medi_status = New System.Windows.Forms.ComboBox()
        Me.SuptypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.medi_count = New System.Windows.Forms.TextBox()
        Me.medi_price = New System.Windows.Forms.TextBox()
        Me.medi_detail = New System.Windows.Forms.TextBox()
        Me.medi_name = New System.Windows.Forms.TextBox()
        Me.medi_delete = New System.Windows.Forms.Button()
        Me.medi_update = New System.Windows.Forms.Button()
        Me.data_medic = New System.Windows.Forms.DataGridView()
        Me.MedisuppliesIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedisuppliesnameDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedisuppliesdetailDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedisuppliespriceDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedisuppliescountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medis1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.medi_insert = New System.Windows.Forms.Button()
        Me.drug_1 = New System.Windows.Forms.Label()
        Me.Employee = New Dentral.DblBufferedPanel()
        Me.emp_idd = New System.Windows.Forms.Label()
        Me.emp_del = New System.Windows.Forms.Button()
        Me.emp_insert = New System.Windows.Forms.Button()
        Me.emp_dep = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.emp_sex = New System.Windows.Forms.ComboBox()
        Me.emp_salary = New System.Windows.Forms.TextBox()
        Me.emp_lname = New System.Windows.Forms.TextBox()
        Me.emp_fname = New System.Windows.Forms.TextBox()
        Me.update_emp = New System.Windows.Forms.Button()
        Me.data_emp = New System.Windows.Forms.DataGridView()
        Me.EmpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpFnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpLnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpGenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpdepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Admin = New Dentral.DblBufferedPanel()
        Me.admin_old_id = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.user_remove = New System.Windows.Forms.Button()
        Me.user_edits = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.cb_add_access = New System.Windows.Forms.ComboBox()
        Me.UsertypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_add_emp = New System.Windows.Forms.ComboBox()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_add_pass = New System.Windows.Forms.TextBox()
        Me.tb_add_user = New System.Windows.Forms.TextBox()
        Me.data_User = New System.Windows.Forms.DataGridView()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserPassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.พนกงานDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypenameDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Home = New Dentral.DblBufferedPanel()
        Me.Home_intro = New System.Windows.Forms.PictureBox()
        Me.Menubar = New Dentral.DblBufferedPanel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btn_Admin = New System.Windows.Forms.Button()
        Me.btn_Emp = New System.Windows.Forms.Button()
        Me.btn_Finan = New System.Windows.Forms.Button()
        Me.btn_Drug = New System.Windows.Forms.Button()
        Me.btn_Record = New System.Windows.Forms.Button()
        Me.tab_username = New Dentral.DblBufferedPanel()
        Me.usern = New System.Windows.Forms.Label()
        Me.profile_image = New System.Windows.Forms.PictureBox()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.Login_p = New Dentral.DblBufferedPanel()
        Me.login_p2 = New Dentral.DblBufferedPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.Taskbar = New Dentral.DblBufferedPanel()
        Me.tasktools = New Dentral.DblBufferedPanel()
        Me.btn_min = New System.Windows.Forms.PictureBox()
        Me.btn_exit = New System.Windows.Forms.PictureBox()
        Me.After_sel_finTableAdapter = New Dentral.sedentralDataSetTableAdapters.after_sel_finTableAdapter()
        Me.Show_finTableAdapter = New Dentral.sedentralDataSetTableAdapters.show_finTableAdapter()
        Me.Medi_showTableAdapter = New Dentral.sedentralDataSetTableAdapters.medi_showTableAdapter()
        Me.List_medTableAdapter = New Dentral.sedentralDataSetTableAdapters.list_medTableAdapter()
        Me.SedentralDataSet3 = New Dentral.sedentralDataSet()
        Me.Data_recTableAdapter = New Dentral.sedentralDataSetTableAdapters.data_recTableAdapter()
        Me.Query_b1 = New Dentral.sedentralDataSetTableAdapters.Query_b()
        Me.GetDoctorTableAdapter = New Dentral.sedentralDataSetTableAdapters.getDoctorTableAdapter()
        Me.History_recordTableAdapter = New Dentral.sedentralDataSetTableAdapters.history_recordTableAdapter()
        Me.After_sel_recTableAdapter = New Dentral.sedentralDataSetTableAdapters.after_sel_recTableAdapter()
        Me.Emp_depTableAdapter = New Dentral.sedentralDataSetTableAdapters.Emp_depTableAdapter()
        Me.DepartmentTableAdapter = New Dentral.sedentralDataSetTableAdapters.DepartmentTableAdapter()
        Me.Medi_s1TableAdapter = New Dentral.sedentralDataSetTableAdapters.medi_s1TableAdapter()
        Me.Sup_typeTableAdapter = New Dentral.sedentralDataSetTableAdapters.sup_typeTableAdapter()
        Me.U_aTableAdapter = New Dentral.sedentralDataSetTableAdapters.U_aTableAdapter()
        Me.EmployeeTableAdapter = New Dentral.sedentralDataSetTableAdapters.EmployeeTableAdapter()
        Me.User_typeTableAdapter = New Dentral.sedentralDataSetTableAdapters.user_typeTableAdapter()
        Me.Query_b2 = New Dentral.sedentralDataSetTableAdapters.Query_b()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GUI.SuspendLayout()
        Me.Record_main.SuspendLayout()
        CType(Me.data_record, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatarecBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SedentralDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Finan_aftersel.SuspendLayout()
        CType(Me.after_sel_fin_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AfterselfinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SedentralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Finan.SuspendLayout()
        CType(Me.show_finan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowfinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SedentralDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Record_search_pat.SuspendLayout()
        Me.add_file.SuspendLayout()
        Me.his_rec.SuspendLayout()
        Me.Record_searchrec_list.SuspendLayout()
        Me.Is_NewReport.SuspendLayout()
        CType(Me.GetDoctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedishowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_med_list, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListmedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Record_after_sel_his.SuspendLayout()
        CType(Me.data_after_sel_his, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AfterselrecBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Record_history.SuspendLayout()
        CType(Me.data_history_rec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryrecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Drug.SuspendLayout()
        CType(Me.SuptypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_medic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Medis1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Employee.SuspendLayout()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpdepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Admin.SuspendLayout()
        CType(Me.UsertypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Home.SuspendLayout()
        CType(Me.Home_intro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menubar.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_username.SuspendLayout()
        CType(Me.profile_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Login_p.SuspendLayout()
        Me.login_p2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Taskbar.SuspendLayout()
        Me.tasktools.SuspendLayout()
        CType(Me.btn_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SedentralDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GUI
        '
        Me.GUI.BackgroundImage = Global.Dentral.My.Resources.Resources.Panel
        Me.GUI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GUI.Controls.Add(Me.Finan_aftersel)
        Me.GUI.Controls.Add(Me.Finan)
        Me.GUI.Controls.Add(Me.Employee)
        Me.GUI.Controls.Add(Me.Drug)
        Me.GUI.Controls.Add(Me.Record_main)
        Me.GUI.Controls.Add(Me.Record_search_pat)
        Me.GUI.Controls.Add(Me.Record_searchrec_list)
        Me.GUI.Controls.Add(Me.Record_after_sel_his)
        Me.GUI.Controls.Add(Me.Record_history)
        Me.GUI.Controls.Add(Me.Admin)
        Me.GUI.Controls.Add(Me.Home)
        Me.GUI.Controls.Add(Me.Menubar)
        Me.GUI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GUI.Location = New System.Drawing.Point(0, 32)
        Me.GUI.Name = "GUI"
        Me.GUI.Size = New System.Drawing.Size(1024, 736)
        Me.GUI.TabIndex = 1
        Me.GUI.Visible = False
        '
        'Record_main
        '
        Me.Record_main.BackColor = System.Drawing.Color.Transparent
        Me.Record_main.Controls.Add(Me.history_rec)
        Me.Record_main.Controls.Add(Me.data_record)
        Me.Record_main.Controls.Add(Me.btn_search_rec)
        Me.Record_main.Controls.Add(Me.tb_idcard_search)
        Me.Record_main.Controls.Add(Me.Label28)
        Me.Record_main.Controls.Add(Me.Label29)
        Me.Record_main.Controls.Add(Me.PictureBox4)
        Me.Record_main.Controls.Add(Me.PictureBox5)
        Me.Record_main.Controls.Add(Me.btn_search_report)
        Me.Record_main.Controls.Add(Me.tb_list)
        Me.Record_main.Controls.Add(Me.Label30)
        Me.Record_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Record_main.Location = New System.Drawing.Point(211, 0)
        Me.Record_main.Name = "Record_main"
        Me.Record_main.Size = New System.Drawing.Size(813, 736)
        Me.Record_main.TabIndex = 2
        '
        'history_rec
        '
        Me.history_rec.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.history_rec.FlatAppearance.BorderSize = 0
        Me.history_rec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.history_rec.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.history_rec.Location = New System.Drawing.Point(644, 230)
        Me.history_rec.Name = "history_rec"
        Me.history_rec.Size = New System.Drawing.Size(131, 38)
        Me.history_rec.TabIndex = 44
        Me.history_rec.Text = "ประวัติการรักษา"
        Me.history_rec.UseVisualStyleBackColor = False
        '
        'data_record
        '
        Me.data_record.AllowUserToAddRows = False
        Me.data_record.AllowUserToDeleteRows = False
        Me.data_record.AutoGenerateColumns = False
        Me.data_record.BackgroundColor = System.Drawing.Color.LightBlue
        Me.data_record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_record.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReportidDataGridViewTextBoxColumn1, Me.PatientidcardDataGridViewTextBoxColumn1, Me.ชอนามสกลDataGridViewTextBoxColumn1, Me.ReportdateDataGridViewTextBoxColumn1, Me.ReportappointdateDataGridViewTextBoxColumn1, Me.ReportappointtimeDataGridViewTextBoxColumn1, Me.ชอหมอDataGridViewTextBoxColumn1, Me.TypenameDataGridViewTextBoxColumn2})
        Me.data_record.DataSource = Me.DatarecBindingSource
        Me.data_record.Location = New System.Drawing.Point(29, 281)
        Me.data_record.Name = "data_record"
        Me.data_record.ReadOnly = True
        Me.data_record.Size = New System.Drawing.Size(747, 411)
        Me.data_record.TabIndex = 27
        '
        'ReportidDataGridViewTextBoxColumn1
        '
        Me.ReportidDataGridViewTextBoxColumn1.DataPropertyName = "report_id"
        Me.ReportidDataGridViewTextBoxColumn1.HeaderText = "report_id"
        Me.ReportidDataGridViewTextBoxColumn1.Name = "ReportidDataGridViewTextBoxColumn1"
        Me.ReportidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ReportidDataGridViewTextBoxColumn1.Visible = False
        '
        'PatientidcardDataGridViewTextBoxColumn1
        '
        Me.PatientidcardDataGridViewTextBoxColumn1.DataPropertyName = "patient_id_card"
        Me.PatientidcardDataGridViewTextBoxColumn1.HeaderText = "patient_id_card"
        Me.PatientidcardDataGridViewTextBoxColumn1.Name = "PatientidcardDataGridViewTextBoxColumn1"
        Me.PatientidcardDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PatientidcardDataGridViewTextBoxColumn1.Visible = False
        '
        'ชอนามสกลDataGridViewTextBoxColumn1
        '
        Me.ชอนามสกลDataGridViewTextBoxColumn1.DataPropertyName = "ชื่อนามสกุล"
        Me.ชอนามสกลDataGridViewTextBoxColumn1.HeaderText = "ชื่อนามสกุล"
        Me.ชอนามสกลDataGridViewTextBoxColumn1.Name = "ชอนามสกลDataGridViewTextBoxColumn1"
        Me.ชอนามสกลDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ชอนามสกลDataGridViewTextBoxColumn1.Width = 150
        '
        'ReportdateDataGridViewTextBoxColumn1
        '
        Me.ReportdateDataGridViewTextBoxColumn1.DataPropertyName = "report_date"
        Me.ReportdateDataGridViewTextBoxColumn1.HeaderText = "วันที่มา"
        Me.ReportdateDataGridViewTextBoxColumn1.Name = "ReportdateDataGridViewTextBoxColumn1"
        Me.ReportdateDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ReportappointdateDataGridViewTextBoxColumn1
        '
        Me.ReportappointdateDataGridViewTextBoxColumn1.DataPropertyName = "report_appoint_date"
        Me.ReportappointdateDataGridViewTextBoxColumn1.HeaderText = "วันที่นัด"
        Me.ReportappointdateDataGridViewTextBoxColumn1.Name = "ReportappointdateDataGridViewTextBoxColumn1"
        Me.ReportappointdateDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ReportappointtimeDataGridViewTextBoxColumn1
        '
        Me.ReportappointtimeDataGridViewTextBoxColumn1.DataPropertyName = "report_appoint_time"
        Me.ReportappointtimeDataGridViewTextBoxColumn1.HeaderText = "เวลาที่นัด"
        Me.ReportappointtimeDataGridViewTextBoxColumn1.Name = "ReportappointtimeDataGridViewTextBoxColumn1"
        Me.ReportappointtimeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ชอหมอDataGridViewTextBoxColumn1
        '
        Me.ชอหมอDataGridViewTextBoxColumn1.DataPropertyName = "ชื่อหมอ"
        Me.ชอหมอDataGridViewTextBoxColumn1.HeaderText = "ชื่อหมอ"
        Me.ชอหมอDataGridViewTextBoxColumn1.Name = "ชอหมอDataGridViewTextBoxColumn1"
        Me.ชอหมอDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ชอหมอDataGridViewTextBoxColumn1.Width = 150
        '
        'TypenameDataGridViewTextBoxColumn2
        '
        Me.TypenameDataGridViewTextBoxColumn2.DataPropertyName = "type_name"
        Me.TypenameDataGridViewTextBoxColumn2.HeaderText = "สถานะ"
        Me.TypenameDataGridViewTextBoxColumn2.Name = "TypenameDataGridViewTextBoxColumn2"
        Me.TypenameDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DatarecBindingSource
        '
        Me.DatarecBindingSource.DataMember = "data_rec"
        Me.DatarecBindingSource.DataSource = Me.SedentralDataSet2
        '
        'SedentralDataSet2
        '
        Me.SedentralDataSet2.DataSetName = "sedentralDataSet"
        Me.SedentralDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_search_rec
        '
        Me.btn_search_rec.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_search_rec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_search_rec.Location = New System.Drawing.Point(614, 148)
        Me.btn_search_rec.Name = "btn_search_rec"
        Me.btn_search_rec.Size = New System.Drawing.Size(127, 33)
        Me.btn_search_rec.TabIndex = 26
        Me.btn_search_rec.Text = "ค้นหาเเฟ้มข้อมูล"
        Me.btn_search_rec.UseVisualStyleBackColor = False
        '
        'tb_idcard_search
        '
        Me.tb_idcard_search.Location = New System.Drawing.Point(235, 148)
        Me.tb_idcard_search.MaxLength = 13
        Me.tb_idcard_search.Name = "tb_idcard_search"
        Me.tb_idcard_search.Size = New System.Drawing.Size(360, 37)
        Me.tb_idcard_search.TabIndex = 25
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(30, 235)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(342, 31)
        Me.Label28.TabIndex = 23
        Me.Label28.Text = "รายการดำเนินการ (คลิกในตารางเพื่อเลือกเลขใบนัด)"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(25, 151)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(204, 31)
        Me.Label29.TabIndex = 24
        Me.Label29.Text = "รหัสบัตรประจำตัวประชาชน : "
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(1, 217)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(774, 2)
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(1, 113)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(774, 2)
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'btn_search_report
        '
        Me.btn_search_report.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_search_report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_search_report.Location = New System.Drawing.Point(614, 53)
        Me.btn_search_report.Name = "btn_search_report"
        Me.btn_search_report.Size = New System.Drawing.Size(86, 33)
        Me.btn_search_report.TabIndex = 20
        Me.btn_search_report.Text = "ค้นหา"
        Me.btn_search_report.UseVisualStyleBackColor = False
        '
        'tb_list
        '
        Me.tb_list.Location = New System.Drawing.Point(235, 53)
        Me.tb_list.Name = "tb_list"
        Me.tb_list.Size = New System.Drawing.Size(360, 37)
        Me.tb_list.TabIndex = 19
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(85, 56)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(139, 31)
        Me.Label30.TabIndex = 18
        Me.Label30.Text = "เลขใบรายการนัด : "
        '
        'Finan_aftersel
        '
        Me.Finan_aftersel.BackColor = System.Drawing.Color.Transparent
        Me.Finan_aftersel.Controls.Add(Me.Label13)
        Me.Finan_aftersel.Controls.Add(Me.btn_back_after)
        Me.Finan_aftersel.Controls.Add(Me.after_sel_fin_d)
        Me.Finan_aftersel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Finan_aftersel.Location = New System.Drawing.Point(211, 0)
        Me.Finan_aftersel.Name = "Finan_aftersel"
        Me.Finan_aftersel.Size = New System.Drawing.Size(813, 736)
        Me.Finan_aftersel.TabIndex = 30
        '
        'btn_back_after
        '
        Me.btn_back_after.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_back_after.Location = New System.Drawing.Point(31, 22)
        Me.btn_back_after.Name = "btn_back_after"
        Me.btn_back_after.Size = New System.Drawing.Size(106, 36)
        Me.btn_back_after.TabIndex = 3
        Me.btn_back_after.Text = "ย้อนกลับ"
        Me.btn_back_after.UseVisualStyleBackColor = False
        '
        'after_sel_fin_d
        '
        Me.after_sel_fin_d.AllowUserToAddRows = False
        Me.after_sel_fin_d.AllowUserToDeleteRows = False
        Me.after_sel_fin_d.AutoGenerateColumns = False
        Me.after_sel_fin_d.BackgroundColor = System.Drawing.Color.LightBlue
        Me.after_sel_fin_d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.after_sel_fin_d.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.after_sel_fin_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.after_sel_fin_d.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedisuppliesnameDataGridViewTextBoxColumn, Me.MedisuppliesdetailDataGridViewTextBoxColumn, Me.MedisuppliespriceDataGridViewTextBoxColumn, Me.ListcountDataGridViewTextBoxColumn, Me.TypenameDataGridViewTextBoxColumn1})
        Me.after_sel_fin_d.DataSource = Me.AfterselfinBindingSource
        Me.after_sel_fin_d.GridColor = System.Drawing.Color.OrangeRed
        Me.after_sel_fin_d.Location = New System.Drawing.Point(32, 110)
        Me.after_sel_fin_d.Name = "after_sel_fin_d"
        Me.after_sel_fin_d.ReadOnly = True
        Me.after_sel_fin_d.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.after_sel_fin_d.Size = New System.Drawing.Size(743, 466)
        Me.after_sel_fin_d.TabIndex = 2
        '
        'MedisuppliesnameDataGridViewTextBoxColumn
        '
        Me.MedisuppliesnameDataGridViewTextBoxColumn.DataPropertyName = "medi_supplies_name"
        Me.MedisuppliesnameDataGridViewTextBoxColumn.HeaderText = "ชื่อ ยา/บริการ"
        Me.MedisuppliesnameDataGridViewTextBoxColumn.Name = "MedisuppliesnameDataGridViewTextBoxColumn"
        Me.MedisuppliesnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedisuppliesnameDataGridViewTextBoxColumn.Width = 150
        '
        'MedisuppliesdetailDataGridViewTextBoxColumn
        '
        Me.MedisuppliesdetailDataGridViewTextBoxColumn.DataPropertyName = "medi_supplies_detail"
        Me.MedisuppliesdetailDataGridViewTextBoxColumn.HeaderText = "รายละเอียด"
        Me.MedisuppliesdetailDataGridViewTextBoxColumn.Name = "MedisuppliesdetailDataGridViewTextBoxColumn"
        Me.MedisuppliesdetailDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedisuppliesdetailDataGridViewTextBoxColumn.Width = 250
        '
        'MedisuppliespriceDataGridViewTextBoxColumn
        '
        Me.MedisuppliespriceDataGridViewTextBoxColumn.DataPropertyName = "medi_supplies_price"
        Me.MedisuppliespriceDataGridViewTextBoxColumn.HeaderText = "ราคา/หน่วย"
        Me.MedisuppliespriceDataGridViewTextBoxColumn.Name = "MedisuppliespriceDataGridViewTextBoxColumn"
        Me.MedisuppliespriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListcountDataGridViewTextBoxColumn
        '
        Me.ListcountDataGridViewTextBoxColumn.DataPropertyName = "List_count"
        Me.ListcountDataGridViewTextBoxColumn.HeaderText = "จำนวน"
        Me.ListcountDataGridViewTextBoxColumn.Name = "ListcountDataGridViewTextBoxColumn"
        Me.ListcountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypenameDataGridViewTextBoxColumn1
        '
        Me.TypenameDataGridViewTextBoxColumn1.DataPropertyName = "type_name"
        Me.TypenameDataGridViewTextBoxColumn1.HeaderText = "ประเภท"
        Me.TypenameDataGridViewTextBoxColumn1.Name = "TypenameDataGridViewTextBoxColumn1"
        Me.TypenameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'AfterselfinBindingSource
        '
        Me.AfterselfinBindingSource.DataMember = "after_sel_fin"
        Me.AfterselfinBindingSource.DataSource = Me.SedentralDataSet
        '
        'SedentralDataSet
        '
        Me.SedentralDataSet.DataSetName = "sedentralDataSet"
        Me.SedentralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Finan
        '
        Me.Finan.BackColor = System.Drawing.Color.Transparent
        Me.Finan.Controls.Add(Me.Label38)
        Me.Finan.Controls.Add(Me.search_fin)
        Me.Finan.Controls.Add(Me.show_finan)
        Me.Finan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Finan.Location = New System.Drawing.Point(211, 0)
        Me.Finan.Name = "Finan"
        Me.Finan.Size = New System.Drawing.Size(813, 736)
        Me.Finan.TabIndex = 29
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(166, 52)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(62, 31)
        Me.Label38.TabIndex = 4
        Me.Label38.Text = "ค้นหา :"
        '
        'search_fin
        '
        Me.search_fin.Location = New System.Drawing.Point(238, 49)
        Me.search_fin.Name = "search_fin"
        Me.search_fin.Size = New System.Drawing.Size(332, 37)
        Me.search_fin.TabIndex = 3
        '
        'show_finan
        '
        Me.show_finan.AllowUserToAddRows = False
        Me.show_finan.AllowUserToDeleteRows = False
        Me.show_finan.AutoGenerateColumns = False
        Me.show_finan.BackgroundColor = System.Drawing.Color.LightBlue
        Me.show_finan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.show_finan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.show_finan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.show_finan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ชอนามสกลDataGridViewTextBoxColumn, Me.ReportdateDataGridViewTextBoxColumn, Me.ReportappointdateDataGridViewTextBoxColumn, Me.ReportappointtimeDataGridViewTextBoxColumn, Me.ชอหมอDataGridViewTextBoxColumn, Me.TypenameDataGridViewTextBoxColumn, Me.ReportidDataGridViewTextBoxColumn, Me.PatientidcardDataGridViewTextBoxColumn})
        Me.show_finan.DataSource = Me.ShowfinBindingSource
        Me.show_finan.GridColor = System.Drawing.Color.OrangeRed
        Me.show_finan.Location = New System.Drawing.Point(6, 113)
        Me.show_finan.Name = "show_finan"
        Me.show_finan.ReadOnly = True
        Me.show_finan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.show_finan.Size = New System.Drawing.Size(798, 466)
        Me.show_finan.TabIndex = 2
        '
        'ชอนามสกลDataGridViewTextBoxColumn
        '
        Me.ชอนามสกลDataGridViewTextBoxColumn.DataPropertyName = "ชื่อนามสกุล"
        Me.ชอนามสกลDataGridViewTextBoxColumn.HeaderText = "ชื่อนามสกุล"
        Me.ชอนามสกลDataGridViewTextBoxColumn.Name = "ชอนามสกลDataGridViewTextBoxColumn"
        Me.ชอนามสกลDataGridViewTextBoxColumn.ReadOnly = True
        Me.ชอนามสกลDataGridViewTextBoxColumn.Width = 150
        '
        'ReportdateDataGridViewTextBoxColumn
        '
        Me.ReportdateDataGridViewTextBoxColumn.DataPropertyName = "report_date"
        Me.ReportdateDataGridViewTextBoxColumn.HeaderText = "วันที่มา"
        Me.ReportdateDataGridViewTextBoxColumn.Name = "ReportdateDataGridViewTextBoxColumn"
        Me.ReportdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReportdateDataGridViewTextBoxColumn.Width = 125
        '
        'ReportappointdateDataGridViewTextBoxColumn
        '
        Me.ReportappointdateDataGridViewTextBoxColumn.DataPropertyName = "report_appoint_date"
        Me.ReportappointdateDataGridViewTextBoxColumn.HeaderText = "วันที่นัด"
        Me.ReportappointdateDataGridViewTextBoxColumn.Name = "ReportappointdateDataGridViewTextBoxColumn"
        Me.ReportappointdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReportappointdateDataGridViewTextBoxColumn.Width = 120
        '
        'ReportappointtimeDataGridViewTextBoxColumn
        '
        Me.ReportappointtimeDataGridViewTextBoxColumn.DataPropertyName = "report_appoint_time"
        Me.ReportappointtimeDataGridViewTextBoxColumn.HeaderText = "เวลานัด"
        Me.ReportappointtimeDataGridViewTextBoxColumn.Name = "ReportappointtimeDataGridViewTextBoxColumn"
        Me.ReportappointtimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReportappointtimeDataGridViewTextBoxColumn.Width = 110
        '
        'ชอหมอDataGridViewTextBoxColumn
        '
        Me.ชอหมอDataGridViewTextBoxColumn.DataPropertyName = "ชื่อหมอ"
        Me.ชอหมอDataGridViewTextBoxColumn.HeaderText = "ชื่อหมอ"
        Me.ชอหมอDataGridViewTextBoxColumn.Name = "ชอหมอDataGridViewTextBoxColumn"
        Me.ชอหมอDataGridViewTextBoxColumn.ReadOnly = True
        Me.ชอหมอDataGridViewTextBoxColumn.Width = 150
        '
        'TypenameDataGridViewTextBoxColumn
        '
        Me.TypenameDataGridViewTextBoxColumn.DataPropertyName = "type_name"
        Me.TypenameDataGridViewTextBoxColumn.HeaderText = "สถานะ"
        Me.TypenameDataGridViewTextBoxColumn.Name = "TypenameDataGridViewTextBoxColumn"
        Me.TypenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReportidDataGridViewTextBoxColumn
        '
        Me.ReportidDataGridViewTextBoxColumn.DataPropertyName = "report_id"
        Me.ReportidDataGridViewTextBoxColumn.HeaderText = "report_id"
        Me.ReportidDataGridViewTextBoxColumn.Name = "ReportidDataGridViewTextBoxColumn"
        Me.ReportidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReportidDataGridViewTextBoxColumn.Visible = False
        '
        'PatientidcardDataGridViewTextBoxColumn
        '
        Me.PatientidcardDataGridViewTextBoxColumn.DataPropertyName = "patient_id_card"
        Me.PatientidcardDataGridViewTextBoxColumn.HeaderText = "patient_id_card"
        Me.PatientidcardDataGridViewTextBoxColumn.Name = "PatientidcardDataGridViewTextBoxColumn"
        Me.PatientidcardDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientidcardDataGridViewTextBoxColumn.Visible = False
        '
        'ShowfinBindingSource
        '
        Me.ShowfinBindingSource.DataMember = "show_fin"
        Me.ShowfinBindingSource.DataSource = Me.SedentralDataSet1
        '
        'SedentralDataSet1
        '
        Me.SedentralDataSet1.DataSetName = "sedentralDataSet"
        Me.SedentralDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Record_search_pat
        '
        Me.Record_search_pat.BackColor = System.Drawing.Color.Transparent
        Me.Record_search_pat.Controls.Add(Me.question_add)
        Me.Record_search_pat.Controls.Add(Me.rec_id_card)
        Me.Record_search_pat.Controls.Add(Me.label00123)
        Me.Record_search_pat.Controls.Add(Me.add_file)
        Me.Record_search_pat.Controls.Add(Me.his_rec)
        Me.Record_search_pat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Record_search_pat.Location = New System.Drawing.Point(211, 0)
        Me.Record_search_pat.Name = "Record_search_pat"
        Me.Record_search_pat.Size = New System.Drawing.Size(813, 736)
        Me.Record_search_pat.TabIndex = 29
        '
        'question_add
        '
        Me.question_add.AutoSize = True
        Me.question_add.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Bold)
        Me.question_add.ForeColor = System.Drawing.Color.Red
        Me.question_add.Location = New System.Drawing.Point(212, 100)
        Me.question_add.Name = "question_add"
        Me.question_add.Size = New System.Drawing.Size(37, 27)
        Me.question_add.TabIndex = 123
        Me.question_add.Text = "Test"
        '
        'rec_id_card
        '
        Me.rec_id_card.AutoSize = True
        Me.rec_id_card.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Bold)
        Me.rec_id_card.Location = New System.Drawing.Point(211, 74)
        Me.rec_id_card.Name = "rec_id_card"
        Me.rec_id_card.Size = New System.Drawing.Size(37, 27)
        Me.rec_id_card.TabIndex = 122
        Me.rec_id_card.Text = "Test"
        '
        'label00123
        '
        Me.label00123.AutoSize = True
        Me.label00123.Location = New System.Drawing.Point(83, 71)
        Me.label00123.Name = "label00123"
        Me.label00123.Size = New System.Drawing.Size(135, 31)
        Me.label00123.TabIndex = 121
        Me.label00123.Text = "เลขบัตรประชาชน :"
        '
        'add_file
        '
        Me.add_file.Controls.Add(Me.rec_btn_add)
        Me.add_file.Dock = System.Windows.Forms.DockStyle.Right
        Me.add_file.Location = New System.Drawing.Point(499, 0)
        Me.add_file.Name = "add_file"
        Me.add_file.Size = New System.Drawing.Size(314, 151)
        Me.add_file.TabIndex = 1
        Me.add_file.Visible = False
        '
        'rec_btn_add
        '
        Me.rec_btn_add.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.rec_btn_add.Location = New System.Drawing.Point(77, 61)
        Me.rec_btn_add.Name = "rec_btn_add"
        Me.rec_btn_add.Size = New System.Drawing.Size(144, 46)
        Me.rec_btn_add.TabIndex = 1
        Me.rec_btn_add.Text = "เพิ่มแฟ้มข้อมูล"
        Me.rec_btn_add.UseVisualStyleBackColor = False
        '
        'his_rec
        '
        Me.his_rec.Controls.Add(Me.Label7)
        Me.his_rec.Controls.Add(Me.rec_next)
        Me.his_rec.Controls.Add(Me.rec_save)
        Me.his_rec.Controls.Add(Me.rec_other_relation)
        Me.his_rec.Controls.Add(Me.rec_other_tel)
        Me.his_rec.Controls.Add(Me.rec_other_lname)
        Me.his_rec.Controls.Add(Me.rec_other_fname)
        Me.his_rec.Controls.Add(Me.rec_allergic)
        Me.his_rec.Controls.Add(Me.rec_height)
        Me.his_rec.Controls.Add(Me.rec_tel2)
        Me.his_rec.Controls.Add(Me.rec_tel1)
        Me.his_rec.Controls.Add(Me.rec_ligion)
        Me.his_rec.Controls.Add(Me.rec_nation)
        Me.his_rec.Controls.Add(Me.rec_race)
        Me.his_rec.Controls.Add(Me.date_time_rec)
        Me.his_rec.Controls.Add(Me.rec_weight)
        Me.his_rec.Controls.Add(Me.cb_rec_sex)
        Me.his_rec.Controls.Add(Me.rec_lname)
        Me.his_rec.Controls.Add(Me.rec_fname)
        Me.his_rec.Controls.Add(Me.Label24)
        Me.his_rec.Controls.Add(Me.Label10)
        Me.his_rec.Controls.Add(Me.Label15)
        Me.his_rec.Controls.Add(Me.Label27)
        Me.his_rec.Controls.Add(Me.Label5)
        Me.his_rec.Controls.Add(Me.Label26)
        Me.his_rec.Controls.Add(Me.Label6)
        Me.his_rec.Controls.Add(Me.Label25)
        Me.his_rec.Controls.Add(Me.Label21)
        Me.his_rec.Controls.Add(Me.Label20)
        Me.his_rec.Controls.Add(Me.Label11)
        Me.his_rec.Controls.Add(Me.Label12)
        Me.his_rec.Controls.Add(Me.Label23)
        Me.his_rec.Controls.Add(Me.Label14)
        Me.his_rec.Controls.Add(Me.Label16)
        Me.his_rec.Controls.Add(Me.Label19)
        Me.his_rec.Controls.Add(Me.Label31)
        Me.his_rec.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.his_rec.Location = New System.Drawing.Point(0, 151)
        Me.his_rec.Name = "his_rec"
        Me.his_rec.Size = New System.Drawing.Size(813, 585)
        Me.his_rec.TabIndex = 0
        Me.his_rec.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(592, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 31)
        Me.Label7.TabIndex = 241
        Me.Label7.Text = "Label7"
        '
        'rec_next
        '
        Me.rec_next.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.rec_next.Location = New System.Drawing.Point(639, 508)
        Me.rec_next.Name = "rec_next"
        Me.rec_next.Size = New System.Drawing.Size(144, 46)
        Me.rec_next.TabIndex = 240
        Me.rec_next.Text = "เพิ่มรายการรักษา"
        Me.rec_next.UseVisualStyleBackColor = False
        Me.rec_next.Visible = False
        '
        'rec_save
        '
        Me.rec_save.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.rec_save.Location = New System.Drawing.Point(489, 508)
        Me.rec_save.Name = "rec_save"
        Me.rec_save.Size = New System.Drawing.Size(144, 46)
        Me.rec_save.TabIndex = 239
        Me.rec_save.Text = "บันทึกแฟ้มข้อมูล"
        Me.rec_save.UseVisualStyleBackColor = False
        '
        'rec_other_relation
        '
        Me.rec_other_relation.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.rec_other_relation.Location = New System.Drawing.Point(133, 480)
        Me.rec_other_relation.Name = "rec_other_relation"
        Me.rec_other_relation.Size = New System.Drawing.Size(139, 37)
        Me.rec_other_relation.TabIndex = 238
        '
        'rec_other_tel
        '
        Me.rec_other_tel.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.rec_other_tel.Location = New System.Drawing.Point(134, 438)
        Me.rec_other_tel.MaxLength = 10
        Me.rec_other_tel.Name = "rec_other_tel"
        Me.rec_other_tel.Size = New System.Drawing.Size(139, 37)
        Me.rec_other_tel.TabIndex = 237
        '
        'rec_other_lname
        '
        Me.rec_other_lname.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.rec_other_lname.Location = New System.Drawing.Point(366, 394)
        Me.rec_other_lname.Name = "rec_other_lname"
        Me.rec_other_lname.Size = New System.Drawing.Size(139, 37)
        Me.rec_other_lname.TabIndex = 235
        '
        'rec_other_fname
        '
        Me.rec_other_fname.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.rec_other_fname.Location = New System.Drawing.Point(134, 395)
        Me.rec_other_fname.Name = "rec_other_fname"
        Me.rec_other_fname.Size = New System.Drawing.Size(139, 37)
        Me.rec_other_fname.TabIndex = 234
        '
        'rec_allergic
        '
        Me.rec_allergic.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.rec_allergic.Location = New System.Drawing.Point(134, 245)
        Me.rec_allergic.Multiline = True
        Me.rec_allergic.Name = "rec_allergic"
        Me.rec_allergic.Size = New System.Drawing.Size(463, 113)
        Me.rec_allergic.TabIndex = 232
        '
        'rec_height
        '
        Me.rec_height.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.rec_height.Location = New System.Drawing.Point(134, 202)
        Me.rec_height.MaxLength = 3
        Me.rec_height.Name = "rec_height"
        Me.rec_height.Size = New System.Drawing.Size(83, 37)
        Me.rec_height.TabIndex = 230
        '
        'rec_tel2
        '
        Me.rec_tel2.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.rec_tel2.Location = New System.Drawing.Point(390, 160)
        Me.rec_tel2.MaxLength = 10
        Me.rec_tel2.Name = "rec_tel2"
        Me.rec_tel2.Size = New System.Drawing.Size(163, 37)
        Me.rec_tel2.TabIndex = 229
        '
        'rec_tel1
        '
        Me.rec_tel1.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.rec_tel1.Location = New System.Drawing.Point(134, 159)
        Me.rec_tel1.MaxLength = 9
        Me.rec_tel1.Name = "rec_tel1"
        Me.rec_tel1.Size = New System.Drawing.Size(139, 37)
        Me.rec_tel1.TabIndex = 228
        '
        'rec_ligion
        '
        Me.rec_ligion.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.rec_ligion.Location = New System.Drawing.Point(600, 118)
        Me.rec_ligion.Name = "rec_ligion"
        Me.rec_ligion.Size = New System.Drawing.Size(146, 37)
        Me.rec_ligion.TabIndex = 226
        '
        'rec_nation
        '
        Me.rec_nation.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.rec_nation.Location = New System.Drawing.Point(390, 116)
        Me.rec_nation.Name = "rec_nation"
        Me.rec_nation.Size = New System.Drawing.Size(139, 37)
        Me.rec_nation.TabIndex = 225
        '
        'rec_race
        '
        Me.rec_race.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.rec_race.Location = New System.Drawing.Point(134, 116)
        Me.rec_race.Name = "rec_race"
        Me.rec_race.Size = New System.Drawing.Size(139, 37)
        Me.rec_race.TabIndex = 224
        '
        'date_time_rec
        '
        Me.date_time_rec.CalendarFont = New System.Drawing.Font("RSU TEXT", 12.0!)
        Me.date_time_rec.CustomFormat = ""
        Me.date_time_rec.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_time_rec.Location = New System.Drawing.Point(390, 70)
        Me.date_time_rec.Name = "date_time_rec"
        Me.date_time_rec.Size = New System.Drawing.Size(258, 37)
        Me.date_time_rec.TabIndex = 220
        Me.date_time_rec.Value = New Date(2017, 12, 18, 0, 0, 0, 0)
        '
        'rec_weight
        '
        Me.rec_weight.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.rec_weight.Location = New System.Drawing.Point(390, 202)
        Me.rec_weight.MaxLength = 3
        Me.rec_weight.Name = "rec_weight"
        Me.rec_weight.Size = New System.Drawing.Size(83, 37)
        Me.rec_weight.TabIndex = 219
        '
        'cb_rec_sex
        '
        Me.cb_rec_sex.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.cb_rec_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_rec_sex.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.cb_rec_sex.FormattingEnabled = True
        Me.cb_rec_sex.Items.AddRange(New Object() {"ชาย", "หญิง"})
        Me.cb_rec_sex.Location = New System.Drawing.Point(134, 73)
        Me.cb_rec_sex.Name = "cb_rec_sex"
        Me.cb_rec_sex.Size = New System.Drawing.Size(98, 39)
        Me.cb_rec_sex.TabIndex = 218
        '
        'rec_lname
        '
        Me.rec_lname.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.rec_lname.Location = New System.Drawing.Point(390, 27)
        Me.rec_lname.Name = "rec_lname"
        Me.rec_lname.Size = New System.Drawing.Size(146, 37)
        Me.rec_lname.TabIndex = 217
        '
        'rec_fname
        '
        Me.rec_fname.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.rec_fname.Location = New System.Drawing.Point(134, 27)
        Me.rec_fname.Name = "rec_fname"
        Me.rec_fname.Size = New System.Drawing.Size(146, 37)
        Me.rec_fname.TabIndex = 216
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label24.Location = New System.Drawing.Point(30, 483)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(106, 31)
        Me.Label24.TabIndex = 215
        Me.Label24.Text = "เกี่ยวข้องเป็น :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label10.Location = New System.Drawing.Point(318, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 31)
        Me.Label10.TabIndex = 207
        Me.Label10.Text = "สัญชาติ : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label15.Location = New System.Drawing.Point(69, 207)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(195, 31)
        Me.Label15.TabIndex = 214
        Me.Label15.Text = "ส่วนสูง :               ซม."
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label27.Location = New System.Drawing.Point(91, 31)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(50, 31)
        Me.Label27.TabIndex = 213
        Me.Label27.Text = "ชื่อ : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label5.Location = New System.Drawing.Point(318, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 31)
        Me.Label5.TabIndex = 212
        Me.Label5.Text = "น้ำหนัก :                กก."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label26.Location = New System.Drawing.Point(313, 31)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(86, 31)
        Me.Label26.TabIndex = 193
        Me.Label26.Text = "นามสกุล : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label6.Location = New System.Drawing.Point(268, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 31)
        Me.Label6.TabIndex = 211
        Me.Label6.Text = "วัน เดือน ปีเกิด : "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label25.Location = New System.Drawing.Point(79, 400)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(50, 31)
        Me.Label25.TabIndex = 194
        Me.Label25.Text = "ชื่อ : "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label21.Location = New System.Drawing.Point(288, 400)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 31)
        Me.Label21.TabIndex = 195
        Me.Label21.Text = "นามสกุล : "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label20.Location = New System.Drawing.Point(85, 78)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 31)
        Me.Label20.TabIndex = 196
        Me.Label20.Text = "เพศ : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label11.Location = New System.Drawing.Point(531, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 31)
        Me.Label11.TabIndex = 208
        Me.Label11.Text = "ศาสนา : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label12.Location = New System.Drawing.Point(60, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 31)
        Me.Label12.TabIndex = 198
        Me.Label12.Text = "เชื้อชาติ : "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label23.Location = New System.Drawing.Point(24, 442)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(112, 31)
        Me.Label23.TabIndex = 206
        Me.Label23.Text = "โทรศัพท์มือถือ :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label14.Location = New System.Drawing.Point(282, 162)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 31)
        Me.Label14.TabIndex = 205
        Me.Label14.Text = "โทรศัพท์มือถือ :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label16.Location = New System.Drawing.Point(61, 162)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 31)
        Me.Label16.TabIndex = 200
        Me.Label16.Text = "โทรศัพท์ :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label19.Location = New System.Drawing.Point(45, 364)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(172, 31)
        Me.Label19.TabIndex = 204
        Me.Label19.Text = "บุคคลที่สามารถติดต่อได้ :"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label31.Location = New System.Drawing.Point(11, 248)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(128, 31)
        Me.Label31.TabIndex = 203
        Me.Label31.Text = "ประวัติการเเพ้ยา :"
        '
        'Record_searchrec_list
        '
        Me.Record_searchrec_list.BackColor = System.Drawing.Color.Transparent
        Me.Record_searchrec_list.Controls.Add(Me.appoint)
        Me.Record_searchrec_list.Controls.Add(Me.Is_NewReport)
        Me.Record_searchrec_list.Controls.Add(Me.name_1)
        Me.Record_searchrec_list.Controls.Add(Me.ชื่อ)
        Me.Record_searchrec_list.Controls.Add(Me.record_id_list)
        Me.Record_searchrec_list.Controls.Add(Me.data_med_list)
        Me.Record_searchrec_list.Controls.Add(Me.Label35)
        Me.Record_searchrec_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Record_searchrec_list.Location = New System.Drawing.Point(211, 0)
        Me.Record_searchrec_list.Name = "Record_searchrec_list"
        Me.Record_searchrec_list.Size = New System.Drawing.Size(813, 736)
        Me.Record_searchrec_list.TabIndex = 30
        '
        'appoint
        '
        Me.appoint.AutoSize = True
        Me.appoint.Location = New System.Drawing.Point(415, 135)
        Me.appoint.Name = "appoint"
        Me.appoint.Size = New System.Drawing.Size(58, 31)
        Me.appoint.TabIndex = 45
        Me.appoint.Text = "Appoint"
        Me.appoint.Visible = False
        '
        'Is_NewReport
        '
        Me.Is_NewReport.Controls.Add(Me.Label9)
        Me.Is_NewReport.Controls.Add(Me.Label8)
        Me.Is_NewReport.Controls.Add(Me.appoint_doctor)
        Me.Is_NewReport.Controls.Add(Me.Label37)
        Me.Is_NewReport.Controls.Add(Me.appoint_min)
        Me.Is_NewReport.Controls.Add(Me.Label36)
        Me.Is_NewReport.Controls.Add(Me.appoint_hr)
        Me.Is_NewReport.Controls.Add(Me.rec_add_med_cnt)
        Me.Is_NewReport.Controls.Add(Me.rec_add_med_name)
        Me.Is_NewReport.Controls.Add(Me.rec_med_date)
        Me.Is_NewReport.Controls.Add(Me.Label34)
        Me.Is_NewReport.Controls.Add(Me.check_appoint)
        Me.Is_NewReport.Controls.Add(Me.btn_rec_med_fin)
        Me.Is_NewReport.Controls.Add(Me.btn_med_add)
        Me.Is_NewReport.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Is_NewReport.Location = New System.Drawing.Point(0, 546)
        Me.Is_NewReport.Name = "Is_NewReport"
        Me.Is_NewReport.Size = New System.Drawing.Size(813, 190)
        Me.Is_NewReport.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(468, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 31)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "นัดกับหมอ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(82, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 31)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "(เดือน/วัน/ปี)"
        '
        'appoint_doctor
        '
        Me.appoint_doctor.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.appoint_doctor.DataSource = Me.GetDoctorBindingSource
        Me.appoint_doctor.DisplayMember = "ชื่อนามสกุล"
        Me.appoint_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.appoint_doctor.FormattingEnabled = True
        Me.appoint_doctor.Location = New System.Drawing.Point(552, 87)
        Me.appoint_doctor.Name = "appoint_doctor"
        Me.appoint_doctor.Size = New System.Drawing.Size(231, 39)
        Me.appoint_doctor.TabIndex = 51
        Me.appoint_doctor.ValueMember = "Emp_ID"
        '
        'GetDoctorBindingSource
        '
        Me.GetDoctorBindingSource.DataMember = "getDoctor"
        Me.GetDoctorBindingSource.DataSource = Me.SedentralDataSet2
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(414, 90)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(28, 31)
        Me.Label37.TabIndex = 50
        Me.Label37.Text = "น."
        '
        'appoint_min
        '
        Me.appoint_min.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.appoint_min.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.appoint_min.FormattingEnabled = True
        Me.appoint_min.Items.AddRange(New Object() {"05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.appoint_min.Location = New System.Drawing.Point(339, 87)
        Me.appoint_min.Name = "appoint_min"
        Me.appoint_min.Size = New System.Drawing.Size(69, 39)
        Me.appoint_min.TabIndex = 49
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(322, 90)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(18, 31)
        Me.Label36.TabIndex = 48
        Me.Label36.Text = ":"
        '
        'appoint_hr
        '
        Me.appoint_hr.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.appoint_hr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.appoint_hr.FormattingEnabled = True
        Me.appoint_hr.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.appoint_hr.Location = New System.Drawing.Point(247, 87)
        Me.appoint_hr.Name = "appoint_hr"
        Me.appoint_hr.Size = New System.Drawing.Size(69, 39)
        Me.appoint_hr.TabIndex = 47
        '
        'rec_add_med_cnt
        '
        Me.rec_add_med_cnt.Location = New System.Drawing.Point(435, 10)
        Me.rec_add_med_cnt.Name = "rec_add_med_cnt"
        Me.rec_add_med_cnt.Size = New System.Drawing.Size(170, 37)
        Me.rec_add_med_cnt.TabIndex = 46
        '
        'rec_add_med_name
        '
        Me.rec_add_med_name.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.rec_add_med_name.DataSource = Me.MedishowBindingSource
        Me.rec_add_med_name.DisplayMember = "ชื่อยา"
        Me.rec_add_med_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rec_add_med_name.FormattingEnabled = True
        Me.rec_add_med_name.Location = New System.Drawing.Point(58, 9)
        Me.rec_add_med_name.Name = "rec_add_med_name"
        Me.rec_add_med_name.Size = New System.Drawing.Size(342, 39)
        Me.rec_add_med_name.TabIndex = 45
        Me.rec_add_med_name.ValueMember = "รหัสยา"
        '
        'MedishowBindingSource
        '
        Me.MedishowBindingSource.DataMember = "medi_show"
        Me.MedishowBindingSource.DataSource = Me.SedentralDataSet2
        '
        'rec_med_date
        '
        Me.rec_med_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rec_med_date.Location = New System.Drawing.Point(85, 88)
        Me.rec_med_date.Name = "rec_med_date"
        Me.rec_med_date.Size = New System.Drawing.Size(132, 37)
        Me.rec_med_date.TabIndex = 44
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(49, 95)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(37, 27)
        Me.Label34.TabIndex = 43
        Me.Label34.Text = "วันที่"
        '
        'check_appoint
        '
        Me.check_appoint.AutoSize = True
        Me.check_appoint.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_appoint.Location = New System.Drawing.Point(54, 54)
        Me.check_appoint.Name = "check_appoint"
        Me.check_appoint.Size = New System.Drawing.Size(169, 31)
        Me.check_appoint.TabIndex = 42
        Me.check_appoint.Text = "ลงเวลานัดหมายครั้งต่อไป"
        Me.check_appoint.UseVisualStyleBackColor = True
        '
        'btn_rec_med_fin
        '
        Me.btn_rec_med_fin.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_rec_med_fin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_rec_med_fin.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rec_med_fin.Location = New System.Drawing.Point(656, 140)
        Me.btn_rec_med_fin.Name = "btn_rec_med_fin"
        Me.btn_rec_med_fin.Size = New System.Drawing.Size(127, 34)
        Me.btn_rec_med_fin.TabIndex = 41
        Me.btn_rec_med_fin.Text = "เสร็จสิ้น"
        Me.btn_rec_med_fin.UseVisualStyleBackColor = False
        '
        'btn_med_add
        '
        Me.btn_med_add.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_med_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_med_add.Font = New System.Drawing.Font("RSU TEXT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_med_add.Location = New System.Drawing.Point(620, 10)
        Me.btn_med_add.Name = "btn_med_add"
        Me.btn_med_add.Size = New System.Drawing.Size(112, 36)
        Me.btn_med_add.TabIndex = 40
        Me.btn_med_add.Text = "เพิ่มรายการ"
        Me.btn_med_add.UseVisualStyleBackColor = False
        '
        'name_1
        '
        Me.name_1.AutoSize = True
        Me.name_1.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.name_1.Location = New System.Drawing.Point(101, 86)
        Me.name_1.Name = "name_1"
        Me.name_1.Size = New System.Drawing.Size(39, 31)
        Me.name_1.TabIndex = 40
        Me.name_1.Text = "Test"
        '
        'ชื่อ
        '
        Me.ชื่อ.AutoSize = True
        Me.ชื่อ.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.ชื่อ.Location = New System.Drawing.Point(55, 86)
        Me.ชื่อ.Name = "ชื่อ"
        Me.ชื่อ.Size = New System.Drawing.Size(32, 31)
        Me.ชื่อ.TabIndex = 41
        Me.ชื่อ.Text = "ชื่อ"
        '
        'record_id_list
        '
        Me.record_id_list.AutoSize = True
        Me.record_id_list.Location = New System.Drawing.Point(155, 135)
        Me.record_id_list.Name = "record_id_list"
        Me.record_id_list.Size = New System.Drawing.Size(236, 31)
        Me.record_id_list.TabIndex = 33
        Me.record_id_list.Text = "จำนวนรายการที่จะบันทึก/เพิ่มล่าสุด"
        '
        'data_med_list
        '
        Me.data_med_list.AllowUserToAddRows = False
        Me.data_med_list.AllowUserToDeleteRows = False
        Me.data_med_list.AutoGenerateColumns = False
        Me.data_med_list.BackgroundColor = System.Drawing.Color.LightBlue
        Me.data_med_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_med_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedisuppliesnameDataGridViewTextBoxColumn1, Me.MedisuppliesIdDataGridViewTextBoxColumn, Me.ListcountDataGridViewTextBoxColumn1, Me.list_med_del, Me.ReportidDataGridViewTextBoxColumn2, Me.List_Id})
        Me.data_med_list.DataSource = Me.ListmedBindingSource
        Me.data_med_list.Location = New System.Drawing.Point(53, 174)
        Me.data_med_list.Name = "data_med_list"
        Me.data_med_list.ReadOnly = True
        Me.data_med_list.Size = New System.Drawing.Size(693, 365)
        Me.data_med_list.TabIndex = 32
        '
        'MedisuppliesnameDataGridViewTextBoxColumn1
        '
        Me.MedisuppliesnameDataGridViewTextBoxColumn1.DataPropertyName = "medi_supplies_name"
        Me.MedisuppliesnameDataGridViewTextBoxColumn1.HeaderText = "ชื่อ ยา/บริการ"
        Me.MedisuppliesnameDataGridViewTextBoxColumn1.Name = "MedisuppliesnameDataGridViewTextBoxColumn1"
        Me.MedisuppliesnameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MedisuppliesnameDataGridViewTextBoxColumn1.Width = 400
        '
        'MedisuppliesIdDataGridViewTextBoxColumn
        '
        Me.MedisuppliesIdDataGridViewTextBoxColumn.DataPropertyName = "medi_supplies_Id"
        Me.MedisuppliesIdDataGridViewTextBoxColumn.HeaderText = "medi_supplies_Id"
        Me.MedisuppliesIdDataGridViewTextBoxColumn.Name = "MedisuppliesIdDataGridViewTextBoxColumn"
        Me.MedisuppliesIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedisuppliesIdDataGridViewTextBoxColumn.Visible = False
        '
        'ListcountDataGridViewTextBoxColumn1
        '
        Me.ListcountDataGridViewTextBoxColumn1.DataPropertyName = "List_count"
        Me.ListcountDataGridViewTextBoxColumn1.HeaderText = "จำนวน"
        Me.ListcountDataGridViewTextBoxColumn1.Name = "ListcountDataGridViewTextBoxColumn1"
        Me.ListcountDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ListcountDataGridViewTextBoxColumn1.Width = 150
        '
        'list_med_del
        '
        Me.list_med_del.HeaderText = "Delete"
        Me.list_med_del.Name = "list_med_del"
        Me.list_med_del.ReadOnly = True
        Me.list_med_del.Text = "Delete"
        '
        'ReportidDataGridViewTextBoxColumn2
        '
        Me.ReportidDataGridViewTextBoxColumn2.DataPropertyName = "report_id"
        Me.ReportidDataGridViewTextBoxColumn2.HeaderText = "report_id"
        Me.ReportidDataGridViewTextBoxColumn2.Name = "ReportidDataGridViewTextBoxColumn2"
        Me.ReportidDataGridViewTextBoxColumn2.ReadOnly = True
        Me.ReportidDataGridViewTextBoxColumn2.Visible = False
        '
        'List_Id
        '
        Me.List_Id.DataPropertyName = "List_Id"
        Me.List_Id.HeaderText = "List_Id"
        Me.List_Id.Name = "List_Id"
        Me.List_Id.ReadOnly = True
        Me.List_Id.Visible = False
        '
        'ListmedBindingSource
        '
        Me.ListmedBindingSource.DataMember = "list_med"
        Me.ListmedBindingSource.DataSource = Me.SedentralDataSet2
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(53, 138)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(96, 27)
        Me.Label35.TabIndex = 26
        Me.Label35.Text = "ใบรายการเลขที่"
        '
        'Record_after_sel_his
        '
        Me.Record_after_sel_his.BackColor = System.Drawing.Color.Transparent
        Me.Record_after_sel_his.Controls.Add(Me.btn_his_back)
        Me.Record_after_sel_his.Controls.Add(Me.data_after_sel_his)
        Me.Record_after_sel_his.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Record_after_sel_his.Location = New System.Drawing.Point(211, 0)
        Me.Record_after_sel_his.Name = "Record_after_sel_his"
        Me.Record_after_sel_his.Size = New System.Drawing.Size(813, 736)
        Me.Record_after_sel_his.TabIndex = 1
        '
        'btn_his_back
        '
        Me.btn_his_back.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_his_back.Location = New System.Drawing.Point(35, 33)
        Me.btn_his_back.Name = "btn_his_back"
        Me.btn_his_back.Size = New System.Drawing.Size(75, 33)
        Me.btn_his_back.TabIndex = 1
        Me.btn_his_back.Text = "ย้อนกลับ"
        Me.btn_his_back.UseVisualStyleBackColor = False
        '
        'data_after_sel_his
        '
        Me.data_after_sel_his.AutoGenerateColumns = False
        Me.data_after_sel_his.BackgroundColor = System.Drawing.Color.LightBlue
        Me.data_after_sel_his.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_after_sel_his.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedisuppliesnameDataGridViewTextBoxColumn2, Me.MedisuppliesdetailDataGridViewTextBoxColumn1, Me.MedisuppliespriceDataGridViewTextBoxColumn1, Me.ListcountDataGridViewTextBoxColumn2, Me.TypenameDataGridViewTextBoxColumn4})
        Me.data_after_sel_his.DataSource = Me.AfterselrecBindingSource
        Me.data_after_sel_his.Location = New System.Drawing.Point(17, 121)
        Me.data_after_sel_his.Name = "data_after_sel_his"
        Me.data_after_sel_his.Size = New System.Drawing.Size(774, 384)
        Me.data_after_sel_his.TabIndex = 0
        '
        'MedisuppliesnameDataGridViewTextBoxColumn2
        '
        Me.MedisuppliesnameDataGridViewTextBoxColumn2.DataPropertyName = "medi_supplies_name"
        Me.MedisuppliesnameDataGridViewTextBoxColumn2.HeaderText = "ชื่อ ยา/บริการ"
        Me.MedisuppliesnameDataGridViewTextBoxColumn2.Name = "MedisuppliesnameDataGridViewTextBoxColumn2"
        Me.MedisuppliesnameDataGridViewTextBoxColumn2.Width = 200
        '
        'MedisuppliesdetailDataGridViewTextBoxColumn1
        '
        Me.MedisuppliesdetailDataGridViewTextBoxColumn1.DataPropertyName = "medi_supplies_detail"
        Me.MedisuppliesdetailDataGridViewTextBoxColumn1.HeaderText = "รายละเอียด"
        Me.MedisuppliesdetailDataGridViewTextBoxColumn1.Name = "MedisuppliesdetailDataGridViewTextBoxColumn1"
        Me.MedisuppliesdetailDataGridViewTextBoxColumn1.Width = 225
        '
        'MedisuppliespriceDataGridViewTextBoxColumn1
        '
        Me.MedisuppliespriceDataGridViewTextBoxColumn1.DataPropertyName = "medi_supplies_price"
        Me.MedisuppliespriceDataGridViewTextBoxColumn1.HeaderText = "ราคา/หน่วย"
        Me.MedisuppliespriceDataGridViewTextBoxColumn1.Name = "MedisuppliespriceDataGridViewTextBoxColumn1"
        '
        'ListcountDataGridViewTextBoxColumn2
        '
        Me.ListcountDataGridViewTextBoxColumn2.DataPropertyName = "List_count"
        Me.ListcountDataGridViewTextBoxColumn2.HeaderText = "จำนวน"
        Me.ListcountDataGridViewTextBoxColumn2.Name = "ListcountDataGridViewTextBoxColumn2"
        '
        'TypenameDataGridViewTextBoxColumn4
        '
        Me.TypenameDataGridViewTextBoxColumn4.DataPropertyName = "type_name"
        Me.TypenameDataGridViewTextBoxColumn4.HeaderText = "ประเภท"
        Me.TypenameDataGridViewTextBoxColumn4.Name = "TypenameDataGridViewTextBoxColumn4"
        '
        'AfterselrecBindingSource
        '
        Me.AfterselrecBindingSource.DataMember = "after_sel_rec"
        Me.AfterselrecBindingSource.DataSource = Me.SedentralDataSet2
        '
        'Record_history
        '
        Me.Record_history.BackColor = System.Drawing.Color.Transparent
        Me.Record_history.Controls.Add(Me.btn_his_bk)
        Me.Record_history.Controls.Add(Me.data_history_rec)
        Me.Record_history.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Record_history.Location = New System.Drawing.Point(211, 0)
        Me.Record_history.Name = "Record_history"
        Me.Record_history.Size = New System.Drawing.Size(813, 736)
        Me.Record_history.TabIndex = 46
        '
        'btn_his_bk
        '
        Me.btn_his_bk.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_his_bk.Location = New System.Drawing.Point(17, 48)
        Me.btn_his_bk.Name = "btn_his_bk"
        Me.btn_his_bk.Size = New System.Drawing.Size(93, 39)
        Me.btn_his_bk.TabIndex = 1
        Me.btn_his_bk.Text = "Back"
        Me.btn_his_bk.UseVisualStyleBackColor = False
        '
        'data_history_rec
        '
        Me.data_history_rec.AllowUserToAddRows = False
        Me.data_history_rec.AllowUserToDeleteRows = False
        Me.data_history_rec.AutoGenerateColumns = False
        Me.data_history_rec.BackgroundColor = System.Drawing.Color.LightBlue
        Me.data_history_rec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_history_rec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ชอนามสกลDataGridViewTextBoxColumn2, Me.ReportidDataGridViewTextBoxColumn3, Me.ReportdateDataGridViewTextBoxColumn2, Me.TypenameDataGridViewTextBoxColumn3})
        Me.data_history_rec.DataSource = Me.HistoryrecordBindingSource
        Me.data_history_rec.Location = New System.Drawing.Point(75, 160)
        Me.data_history_rec.Name = "data_history_rec"
        Me.data_history_rec.ReadOnly = True
        Me.data_history_rec.Size = New System.Drawing.Size(644, 452)
        Me.data_history_rec.TabIndex = 0
        '
        'ชอนามสกลDataGridViewTextBoxColumn2
        '
        Me.ชอนามสกลDataGridViewTextBoxColumn2.DataPropertyName = "ชื่อนามสกุล"
        Me.ชอนามสกลDataGridViewTextBoxColumn2.HeaderText = "ชื่อนามสกุล"
        Me.ชอนามสกลDataGridViewTextBoxColumn2.Name = "ชอนามสกลDataGridViewTextBoxColumn2"
        Me.ชอนามสกลDataGridViewTextBoxColumn2.ReadOnly = True
        Me.ชอนามสกลDataGridViewTextBoxColumn2.Width = 200
        '
        'ReportidDataGridViewTextBoxColumn3
        '
        Me.ReportidDataGridViewTextBoxColumn3.DataPropertyName = "report_id"
        Me.ReportidDataGridViewTextBoxColumn3.HeaderText = "รหัสรายงาน"
        Me.ReportidDataGridViewTextBoxColumn3.Name = "ReportidDataGridViewTextBoxColumn3"
        Me.ReportidDataGridViewTextBoxColumn3.ReadOnly = True
        Me.ReportidDataGridViewTextBoxColumn3.Width = 150
        '
        'ReportdateDataGridViewTextBoxColumn2
        '
        Me.ReportdateDataGridViewTextBoxColumn2.DataPropertyName = "report_date"
        Me.ReportdateDataGridViewTextBoxColumn2.HeaderText = "วันที่ออกรายงาน"
        Me.ReportdateDataGridViewTextBoxColumn2.Name = "ReportdateDataGridViewTextBoxColumn2"
        Me.ReportdateDataGridViewTextBoxColumn2.ReadOnly = True
        Me.ReportdateDataGridViewTextBoxColumn2.Width = 150
        '
        'TypenameDataGridViewTextBoxColumn3
        '
        Me.TypenameDataGridViewTextBoxColumn3.DataPropertyName = "type_name"
        Me.TypenameDataGridViewTextBoxColumn3.HeaderText = "สถานะ"
        Me.TypenameDataGridViewTextBoxColumn3.Name = "TypenameDataGridViewTextBoxColumn3"
        Me.TypenameDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'HistoryrecordBindingSource
        '
        Me.HistoryrecordBindingSource.DataMember = "history_record"
        Me.HistoryrecordBindingSource.DataSource = Me.SedentralDataSet2
        '
        'Drug
        '
        Me.Drug.BackColor = System.Drawing.Color.Transparent
        Me.Drug.Controls.Add(Me.medi_idd)
        Me.Drug.Controls.Add(Me.medi_status)
        Me.Drug.Controls.Add(Me.medi_count)
        Me.Drug.Controls.Add(Me.medi_price)
        Me.Drug.Controls.Add(Me.medi_detail)
        Me.Drug.Controls.Add(Me.medi_name)
        Me.Drug.Controls.Add(Me.medi_delete)
        Me.Drug.Controls.Add(Me.medi_update)
        Me.Drug.Controls.Add(Me.data_medic)
        Me.Drug.Controls.Add(Me.medi_insert)
        Me.Drug.Controls.Add(Me.drug_1)
        Me.Drug.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Drug.Location = New System.Drawing.Point(211, 0)
        Me.Drug.Name = "Drug"
        Me.Drug.Size = New System.Drawing.Size(813, 736)
        Me.Drug.TabIndex = 28
        '
        'medi_idd
        '
        Me.medi_idd.AutoSize = True
        Me.medi_idd.Location = New System.Drawing.Point(487, 667)
        Me.medi_idd.Name = "medi_idd"
        Me.medi_idd.Size = New System.Drawing.Size(24, 31)
        Me.medi_idd.TabIndex = 16
        Me.medi_idd.Text = "id"
        '
        'medi_status
        '
        Me.medi_status.AutoCompleteCustomSource.AddRange(New String() {"medic", "service"})
        Me.medi_status.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.medi_status.DataSource = Me.SuptypeBindingSource
        Me.medi_status.DisplayMember = "type_name"
        Me.medi_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.medi_status.FormattingEnabled = True
        Me.medi_status.Location = New System.Drawing.Point(708, 584)
        Me.medi_status.Name = "medi_status"
        Me.medi_status.Size = New System.Drawing.Size(96, 39)
        Me.medi_status.TabIndex = 15
        Me.medi_status.ValueMember = "sup_type"
        '
        'SuptypeBindingSource
        '
        Me.SuptypeBindingSource.DataMember = "sup_type"
        Me.SuptypeBindingSource.DataSource = Me.SedentralDataSet2
        '
        'medi_count
        '
        Me.medi_count.Location = New System.Drawing.Point(565, 585)
        Me.medi_count.Name = "medi_count"
        Me.medi_count.Size = New System.Drawing.Size(137, 37)
        Me.medi_count.TabIndex = 14
        '
        'medi_price
        '
        Me.medi_price.Location = New System.Drawing.Point(450, 585)
        Me.medi_price.Name = "medi_price"
        Me.medi_price.Size = New System.Drawing.Size(111, 37)
        Me.medi_price.TabIndex = 13
        '
        'medi_detail
        '
        Me.medi_detail.Location = New System.Drawing.Point(248, 585)
        Me.medi_detail.Name = "medi_detail"
        Me.medi_detail.Size = New System.Drawing.Size(198, 37)
        Me.medi_detail.TabIndex = 12
        '
        'medi_name
        '
        Me.medi_name.Location = New System.Drawing.Point(48, 585)
        Me.medi_name.Name = "medi_name"
        Me.medi_name.Size = New System.Drawing.Size(198, 37)
        Me.medi_name.TabIndex = 11
        '
        'medi_delete
        '
        Me.medi_delete.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.medi_delete.Location = New System.Drawing.Point(726, 667)
        Me.medi_delete.Name = "medi_delete"
        Me.medi_delete.Size = New System.Drawing.Size(75, 31)
        Me.medi_delete.TabIndex = 10
        Me.medi_delete.Text = "ลบ"
        Me.medi_delete.UseVisualStyleBackColor = False
        '
        'medi_update
        '
        Me.medi_update.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.medi_update.Location = New System.Drawing.Point(645, 667)
        Me.medi_update.Name = "medi_update"
        Me.medi_update.Size = New System.Drawing.Size(75, 31)
        Me.medi_update.TabIndex = 9
        Me.medi_update.Text = "บันทึก"
        Me.medi_update.UseVisualStyleBackColor = False
        '
        'data_medic
        '
        Me.data_medic.AutoGenerateColumns = False
        Me.data_medic.BackgroundColor = System.Drawing.Color.LightBlue
        Me.data_medic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_medic.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedisuppliesIdDataGridViewTextBoxColumn1, Me.MedisuppliesnameDataGridViewTextBoxColumn3, Me.MedisuppliesdetailDataGridViewTextBoxColumn2, Me.MedisuppliespriceDataGridViewTextBoxColumn2, Me.MedisuppliescountDataGridViewTextBoxColumn, Me.type_name})
        Me.data_medic.DataSource = Me.Medis1BindingSource
        Me.data_medic.Location = New System.Drawing.Point(10, 105)
        Me.data_medic.Name = "data_medic"
        Me.data_medic.Size = New System.Drawing.Size(794, 474)
        Me.data_medic.TabIndex = 8
        '
        'MedisuppliesIdDataGridViewTextBoxColumn1
        '
        Me.MedisuppliesIdDataGridViewTextBoxColumn1.DataPropertyName = "medi_supplies_Id"
        Me.MedisuppliesIdDataGridViewTextBoxColumn1.HeaderText = "รหัสยา"
        Me.MedisuppliesIdDataGridViewTextBoxColumn1.Name = "MedisuppliesIdDataGridViewTextBoxColumn1"
        Me.MedisuppliesIdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MedisuppliesIdDataGridViewTextBoxColumn1.Visible = False
        '
        'MedisuppliesnameDataGridViewTextBoxColumn3
        '
        Me.MedisuppliesnameDataGridViewTextBoxColumn3.DataPropertyName = "medi_supplies_name"
        Me.MedisuppliesnameDataGridViewTextBoxColumn3.HeaderText = "ชื่อ ยา/บริการ"
        Me.MedisuppliesnameDataGridViewTextBoxColumn3.Name = "MedisuppliesnameDataGridViewTextBoxColumn3"
        Me.MedisuppliesnameDataGridViewTextBoxColumn3.Width = 200
        '
        'MedisuppliesdetailDataGridViewTextBoxColumn2
        '
        Me.MedisuppliesdetailDataGridViewTextBoxColumn2.DataPropertyName = "medi_supplies_detail"
        Me.MedisuppliesdetailDataGridViewTextBoxColumn2.HeaderText = "รายละเอียด"
        Me.MedisuppliesdetailDataGridViewTextBoxColumn2.Name = "MedisuppliesdetailDataGridViewTextBoxColumn2"
        Me.MedisuppliesdetailDataGridViewTextBoxColumn2.Width = 250
        '
        'MedisuppliespriceDataGridViewTextBoxColumn2
        '
        Me.MedisuppliespriceDataGridViewTextBoxColumn2.DataPropertyName = "medi_supplies_price"
        Me.MedisuppliespriceDataGridViewTextBoxColumn2.HeaderText = "ราคา/หน่วย"
        Me.MedisuppliespriceDataGridViewTextBoxColumn2.Name = "MedisuppliespriceDataGridViewTextBoxColumn2"
        '
        'MedisuppliescountDataGridViewTextBoxColumn
        '
        Me.MedisuppliescountDataGridViewTextBoxColumn.DataPropertyName = "medi_supplies_count"
        Me.MedisuppliescountDataGridViewTextBoxColumn.HeaderText = "จำนวน"
        Me.MedisuppliescountDataGridViewTextBoxColumn.Name = "MedisuppliescountDataGridViewTextBoxColumn"
        '
        'type_name
        '
        Me.type_name.DataPropertyName = "type_name"
        Me.type_name.HeaderText = "ประเภท"
        Me.type_name.Name = "type_name"
        '
        'Medis1BindingSource
        '
        Me.Medis1BindingSource.DataMember = "medi_s1"
        Me.Medis1BindingSource.DataSource = Me.SedentralDataSet2
        '
        'medi_insert
        '
        Me.medi_insert.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.medi_insert.Location = New System.Drawing.Point(564, 667)
        Me.medi_insert.Name = "medi_insert"
        Me.medi_insert.Size = New System.Drawing.Size(75, 31)
        Me.medi_insert.TabIndex = 7
        Me.medi_insert.Text = "เพิ่ม"
        Me.medi_insert.UseVisualStyleBackColor = False
        '
        'drug_1
        '
        Me.drug_1.AutoSize = True
        Me.drug_1.Location = New System.Drawing.Point(336, 75)
        Me.drug_1.Name = "drug_1"
        Me.drug_1.Size = New System.Drawing.Size(119, 31)
        Me.drug_1.TabIndex = 6
        Me.drug_1.Text = "รายการเวชภัณฑ์"
        '
        'Employee
        '
        Me.Employee.BackColor = System.Drawing.Color.Transparent
        Me.Employee.Controls.Add(Me.emp_idd)
        Me.Employee.Controls.Add(Me.emp_del)
        Me.Employee.Controls.Add(Me.emp_insert)
        Me.Employee.Controls.Add(Me.emp_dep)
        Me.Employee.Controls.Add(Me.emp_sex)
        Me.Employee.Controls.Add(Me.emp_salary)
        Me.Employee.Controls.Add(Me.emp_lname)
        Me.Employee.Controls.Add(Me.emp_fname)
        Me.Employee.Controls.Add(Me.update_emp)
        Me.Employee.Controls.Add(Me.data_emp)
        Me.Employee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Employee.Location = New System.Drawing.Point(211, 0)
        Me.Employee.Name = "Employee"
        Me.Employee.Size = New System.Drawing.Size(813, 736)
        Me.Employee.TabIndex = 29
        '
        'emp_idd
        '
        Me.emp_idd.AutoSize = True
        Me.emp_idd.Location = New System.Drawing.Point(42, 603)
        Me.emp_idd.Name = "emp_idd"
        Me.emp_idd.Size = New System.Drawing.Size(24, 31)
        Me.emp_idd.TabIndex = 14
        Me.emp_idd.Text = "id"
        Me.emp_idd.Visible = False
        '
        'emp_del
        '
        Me.emp_del.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.emp_del.Location = New System.Drawing.Point(682, 678)
        Me.emp_del.Name = "emp_del"
        Me.emp_del.Size = New System.Drawing.Size(75, 39)
        Me.emp_del.TabIndex = 13
        Me.emp_del.Text = "ลบ"
        Me.emp_del.UseVisualStyleBackColor = False
        '
        'emp_insert
        '
        Me.emp_insert.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.emp_insert.Location = New System.Drawing.Point(521, 678)
        Me.emp_insert.Name = "emp_insert"
        Me.emp_insert.Size = New System.Drawing.Size(75, 39)
        Me.emp_insert.TabIndex = 12
        Me.emp_insert.Text = "เพิ่ม"
        Me.emp_insert.UseVisualStyleBackColor = False
        '
        'emp_dep
        '
        Me.emp_dep.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.emp_dep.DataSource = Me.DepartmentBindingSource
        Me.emp_dep.DisplayMember = "Dep_Name"
        Me.emp_dep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.emp_dep.FormattingEnabled = True
        Me.emp_dep.Location = New System.Drawing.Point(654, 597)
        Me.emp_dep.Name = "emp_dep"
        Me.emp_dep.Size = New System.Drawing.Size(103, 39)
        Me.emp_dep.TabIndex = 11
        Me.emp_dep.ValueMember = "Dep_ID"
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.SedentralDataSet2
        '
        'emp_sex
        '
        Me.emp_sex.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.emp_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.emp_sex.FormattingEnabled = True
        Me.emp_sex.Items.AddRange(New Object() {"Male", "Female"})
        Me.emp_sex.Location = New System.Drawing.Point(460, 598)
        Me.emp_sex.Name = "emp_sex"
        Me.emp_sex.Size = New System.Drawing.Size(92, 39)
        Me.emp_sex.TabIndex = 10
        '
        'emp_salary
        '
        Me.emp_salary.Location = New System.Drawing.Point(555, 599)
        Me.emp_salary.Name = "emp_salary"
        Me.emp_salary.Size = New System.Drawing.Size(96, 37)
        Me.emp_salary.TabIndex = 9
        '
        'emp_lname
        '
        Me.emp_lname.Location = New System.Drawing.Point(282, 600)
        Me.emp_lname.Name = "emp_lname"
        Me.emp_lname.Size = New System.Drawing.Size(173, 37)
        Me.emp_lname.TabIndex = 8
        '
        'emp_fname
        '
        Me.emp_fname.Location = New System.Drawing.Point(107, 600)
        Me.emp_fname.Name = "emp_fname"
        Me.emp_fname.Size = New System.Drawing.Size(173, 37)
        Me.emp_fname.TabIndex = 7
        '
        'update_emp
        '
        Me.update_emp.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.update_emp.Location = New System.Drawing.Point(602, 678)
        Me.update_emp.Name = "update_emp"
        Me.update_emp.Size = New System.Drawing.Size(75, 39)
        Me.update_emp.TabIndex = 6
        Me.update_emp.Text = "บันทึก"
        Me.update_emp.UseVisualStyleBackColor = False
        '
        'data_emp
        '
        Me.data_emp.AllowUserToAddRows = False
        Me.data_emp.AllowUserToDeleteRows = False
        Me.data_emp.AutoGenerateColumns = False
        Me.data_emp.BackgroundColor = System.Drawing.Color.LightBlue
        Me.data_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_emp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpIDDataGridViewTextBoxColumn, Me.EmpFnameDataGridViewTextBoxColumn, Me.EmpLnameDataGridViewTextBoxColumn, Me.EmpGenderDataGridViewTextBoxColumn, Me.EmpSalaryDataGridViewTextBoxColumn, Me.DepNameDataGridViewTextBoxColumn})
        Me.data_emp.DataSource = Me.EmpdepBindingSource
        Me.data_emp.Location = New System.Drawing.Point(64, 113)
        Me.data_emp.Name = "data_emp"
        Me.data_emp.ReadOnly = True
        Me.data_emp.Size = New System.Drawing.Size(693, 471)
        Me.data_emp.TabIndex = 5
        '
        'EmpIDDataGridViewTextBoxColumn
        '
        Me.EmpIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID"
        Me.EmpIDDataGridViewTextBoxColumn.HeaderText = "รหัสพนักงาน"
        Me.EmpIDDataGridViewTextBoxColumn.Name = "EmpIDDataGridViewTextBoxColumn"
        Me.EmpIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpIDDataGridViewTextBoxColumn.Visible = False
        Me.EmpIDDataGridViewTextBoxColumn.Width = 150
        '
        'EmpFnameDataGridViewTextBoxColumn
        '
        Me.EmpFnameDataGridViewTextBoxColumn.DataPropertyName = "Emp_Fname"
        Me.EmpFnameDataGridViewTextBoxColumn.HeaderText = "ชื่อ"
        Me.EmpFnameDataGridViewTextBoxColumn.Name = "EmpFnameDataGridViewTextBoxColumn"
        Me.EmpFnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpFnameDataGridViewTextBoxColumn.Width = 175
        '
        'EmpLnameDataGridViewTextBoxColumn
        '
        Me.EmpLnameDataGridViewTextBoxColumn.DataPropertyName = "Emp_Lname"
        Me.EmpLnameDataGridViewTextBoxColumn.HeaderText = "นามสกุล"
        Me.EmpLnameDataGridViewTextBoxColumn.Name = "EmpLnameDataGridViewTextBoxColumn"
        Me.EmpLnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpLnameDataGridViewTextBoxColumn.Width = 175
        '
        'EmpGenderDataGridViewTextBoxColumn
        '
        Me.EmpGenderDataGridViewTextBoxColumn.DataPropertyName = "Emp_Gender"
        Me.EmpGenderDataGridViewTextBoxColumn.HeaderText = "เพศ"
        Me.EmpGenderDataGridViewTextBoxColumn.Name = "EmpGenderDataGridViewTextBoxColumn"
        Me.EmpGenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpSalaryDataGridViewTextBoxColumn
        '
        Me.EmpSalaryDataGridViewTextBoxColumn.DataPropertyName = "Emp_Salary"
        Me.EmpSalaryDataGridViewTextBoxColumn.HeaderText = "เงินเดือน"
        Me.EmpSalaryDataGridViewTextBoxColumn.Name = "EmpSalaryDataGridViewTextBoxColumn"
        Me.EmpSalaryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepNameDataGridViewTextBoxColumn
        '
        Me.DepNameDataGridViewTextBoxColumn.DataPropertyName = "Dep_Name"
        Me.DepNameDataGridViewTextBoxColumn.HeaderText = "แผนก"
        Me.DepNameDataGridViewTextBoxColumn.Name = "DepNameDataGridViewTextBoxColumn"
        Me.DepNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpdepBindingSource
        '
        Me.EmpdepBindingSource.DataMember = "Emp_dep"
        Me.EmpdepBindingSource.DataSource = Me.SedentralDataSet2
        '
        'Admin
        '
        Me.Admin.BackColor = System.Drawing.Color.Transparent
        Me.Admin.Controls.Add(Me.admin_old_id)
        Me.Admin.Controls.Add(Me.Label4)
        Me.Admin.Controls.Add(Me.user_remove)
        Me.Admin.Controls.Add(Me.user_edits)
        Me.Admin.Controls.Add(Me.btn_add)
        Me.Admin.Controls.Add(Me.cb_add_access)
        Me.Admin.Controls.Add(Me.cb_add_emp)
        Me.Admin.Controls.Add(Me.tb_add_pass)
        Me.Admin.Controls.Add(Me.tb_add_user)
        Me.Admin.Controls.Add(Me.data_User)
        Me.Admin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Admin.Location = New System.Drawing.Point(211, 0)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(813, 736)
        Me.Admin.TabIndex = 29
        '
        'admin_old_id
        '
        Me.admin_old_id.AutoSize = True
        Me.admin_old_id.Location = New System.Drawing.Point(107, 507)
        Me.admin_old_id.Name = "admin_old_id"
        Me.admin_old_id.Size = New System.Drawing.Size(53, 31)
        Me.admin_old_id.TabIndex = 24
        Me.admin_old_id.Text = "old_id"
        Me.admin_old_id.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("RSU TEXT", 38.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(307, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 56)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "จัดการ User"
        '
        'user_remove
        '
        Me.user_remove.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.user_remove.Location = New System.Drawing.Point(542, 546)
        Me.user_remove.Name = "user_remove"
        Me.user_remove.Size = New System.Drawing.Size(103, 35)
        Me.user_remove.TabIndex = 22
        Me.user_remove.Text = "Remove"
        Me.user_remove.UseVisualStyleBackColor = False
        '
        'user_edits
        '
        Me.user_edits.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.user_edits.Location = New System.Drawing.Point(433, 546)
        Me.user_edits.Name = "user_edits"
        Me.user_edits.Size = New System.Drawing.Size(103, 35)
        Me.user_edits.TabIndex = 21
        Me.user_edits.Text = "Edit"
        Me.user_edits.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_add.Location = New System.Drawing.Point(324, 546)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(103, 35)
        Me.btn_add.TabIndex = 19
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'cb_add_access
        '
        Me.cb_add_access.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.cb_add_access.DataSource = Me.UsertypeBindingSource
        Me.cb_add_access.DisplayMember = "type_name"
        Me.cb_add_access.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_add_access.FormattingEnabled = True
        Me.cb_add_access.Location = New System.Drawing.Point(542, 504)
        Me.cb_add_access.Name = "cb_add_access"
        Me.cb_add_access.Size = New System.Drawing.Size(102, 39)
        Me.cb_add_access.TabIndex = 18
        Me.cb_add_access.ValueMember = "user_type"
        '
        'UsertypeBindingSource
        '
        Me.UsertypeBindingSource.DataMember = "user_type"
        Me.UsertypeBindingSource.DataSource = Me.SedentralDataSet2
        '
        'cb_add_emp
        '
        Me.cb_add_emp.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.cb_add_emp.DataSource = Me.EmployeeBindingSource
        Me.cb_add_emp.DisplayMember = "Emp_Fname"
        Me.cb_add_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_add_emp.FormattingEnabled = True
        Me.cb_add_emp.Location = New System.Drawing.Point(381, 505)
        Me.cb_add_emp.Name = "cb_add_emp"
        Me.cb_add_emp.Size = New System.Drawing.Size(155, 39)
        Me.cb_add_emp.TabIndex = 17
        Me.cb_add_emp.ValueMember = "Emp_ID"
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.SedentralDataSet2
        '
        'tb_add_pass
        '
        Me.tb_add_pass.Location = New System.Drawing.Point(275, 507)
        Me.tb_add_pass.Multiline = True
        Me.tb_add_pass.Name = "tb_add_pass"
        Me.tb_add_pass.Size = New System.Drawing.Size(100, 32)
        Me.tb_add_pass.TabIndex = 16
        '
        'tb_add_user
        '
        Me.tb_add_user.Location = New System.Drawing.Point(172, 507)
        Me.tb_add_user.Multiline = True
        Me.tb_add_user.Name = "tb_add_user"
        Me.tb_add_user.Size = New System.Drawing.Size(100, 32)
        Me.tb_add_user.TabIndex = 15
        '
        'data_User
        '
        Me.data_User.AllowUserToAddRows = False
        Me.data_User.AllowUserToDeleteRows = False
        Me.data_User.AutoGenerateColumns = False
        Me.data_User.BackgroundColor = System.Drawing.Color.LightBlue
        Me.data_User.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.data_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_User.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.UserPassDataGridViewTextBoxColumn, Me.พนกงานDataGridViewTextBoxColumn, Me.TypenameDataGridViewTextBoxColumn5, Me.Emp_ID})
        Me.data_User.DataSource = Me.UaBindingSource
        Me.data_User.Location = New System.Drawing.Point(89, 160)
        Me.data_User.Name = "data_User"
        Me.data_User.ReadOnly = True
        Me.data_User.Size = New System.Drawing.Size(652, 330)
        Me.data_User.TabIndex = 13
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "User_ID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserIDDataGridViewTextBoxColumn.Width = 150
        '
        'UserPassDataGridViewTextBoxColumn
        '
        Me.UserPassDataGridViewTextBoxColumn.DataPropertyName = "User_Pass"
        Me.UserPassDataGridViewTextBoxColumn.HeaderText = "User_Pass"
        Me.UserPassDataGridViewTextBoxColumn.Name = "UserPassDataGridViewTextBoxColumn"
        Me.UserPassDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserPassDataGridViewTextBoxColumn.Width = 150
        '
        'พนกงานDataGridViewTextBoxColumn
        '
        Me.พนกงานDataGridViewTextBoxColumn.DataPropertyName = "พนักงาน"
        Me.พนกงานDataGridViewTextBoxColumn.HeaderText = "พนักงาน"
        Me.พนกงานDataGridViewTextBoxColumn.Name = "พนกงานDataGridViewTextBoxColumn"
        Me.พนกงานDataGridViewTextBoxColumn.ReadOnly = True
        Me.พนกงานDataGridViewTextBoxColumn.Width = 200
        '
        'TypenameDataGridViewTextBoxColumn5
        '
        Me.TypenameDataGridViewTextBoxColumn5.DataPropertyName = "type_name"
        Me.TypenameDataGridViewTextBoxColumn5.HeaderText = "ประเภท"
        Me.TypenameDataGridViewTextBoxColumn5.Name = "TypenameDataGridViewTextBoxColumn5"
        Me.TypenameDataGridViewTextBoxColumn5.ReadOnly = True
        Me.TypenameDataGridViewTextBoxColumn5.Width = 110
        '
        'Emp_ID
        '
        Me.Emp_ID.DataPropertyName = "Emp_ID"
        Me.Emp_ID.HeaderText = "Emp_ID"
        Me.Emp_ID.Name = "Emp_ID"
        Me.Emp_ID.ReadOnly = True
        Me.Emp_ID.Visible = False
        '
        'UaBindingSource
        '
        Me.UaBindingSource.DataMember = "U_a"
        Me.UaBindingSource.DataSource = Me.SedentralDataSet2
        '
        'Home
        '
        Me.Home.Controls.Add(Me.Home_intro)
        Me.Home.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home.Location = New System.Drawing.Point(211, 0)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(813, 736)
        Me.Home.TabIndex = 29
        '
        'Home_intro
        '
        Me.Home_intro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Home_intro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home_intro.Image = Global.Dentral.My.Resources.Resources.logo1
        Me.Home_intro.Location = New System.Drawing.Point(0, 0)
        Me.Home_intro.Name = "Home_intro"
        Me.Home_intro.Size = New System.Drawing.Size(813, 736)
        Me.Home_intro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Home_intro.TabIndex = 1
        Me.Home_intro.TabStop = False
        '
        'Menubar
        '
        Me.Menubar.BackColor = System.Drawing.Color.Transparent
        Me.Menubar.BackgroundImage = Global.Dentral.My.Resources.Resources.bg_menu
        Me.Menubar.Controls.Add(Me.PictureBox6)
        Me.Menubar.Controls.Add(Me.btn_Admin)
        Me.Menubar.Controls.Add(Me.btn_Emp)
        Me.Menubar.Controls.Add(Me.btn_Finan)
        Me.Menubar.Controls.Add(Me.btn_Drug)
        Me.Menubar.Controls.Add(Me.btn_Record)
        Me.Menubar.Controls.Add(Me.tab_username)
        Me.Menubar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Menubar.Location = New System.Drawing.Point(0, 0)
        Me.Menubar.Name = "Menubar"
        Me.Menubar.Size = New System.Drawing.Size(211, 736)
        Me.Menubar.TabIndex = 0
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Dentral.My.Resources.Resources.mascot
        Me.PictureBox6.Location = New System.Drawing.Point(9, 546)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(196, 178)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 6
        Me.PictureBox6.TabStop = False
        '
        'btn_Admin
        '
        Me.btn_Admin.BackColor = System.Drawing.Color.Transparent
        Me.btn_Admin.BackgroundImage = Global.Dentral.My.Resources.Resources.menu_1
        Me.btn_Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Admin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Admin.FlatAppearance.BorderSize = 0
        Me.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Admin.Font = New System.Drawing.Font("RSU TEXT", 25.0!)
        Me.btn_Admin.Location = New System.Drawing.Point(0, 469)
        Me.btn_Admin.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Admin.Name = "btn_Admin"
        Me.btn_Admin.Size = New System.Drawing.Size(211, 66)
        Me.btn_Admin.TabIndex = 5
        Me.btn_Admin.Text = "แอดมิน"
        Me.btn_Admin.UseVisualStyleBackColor = False
        '
        'btn_Emp
        '
        Me.btn_Emp.BackColor = System.Drawing.Color.Transparent
        Me.btn_Emp.BackgroundImage = Global.Dentral.My.Resources.Resources.menu_2
        Me.btn_Emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Emp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Emp.FlatAppearance.BorderSize = 0
        Me.btn_Emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Emp.Font = New System.Drawing.Font("RSU TEXT", 25.0!)
        Me.btn_Emp.Location = New System.Drawing.Point(0, 403)
        Me.btn_Emp.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Emp.Name = "btn_Emp"
        Me.btn_Emp.Size = New System.Drawing.Size(211, 66)
        Me.btn_Emp.TabIndex = 4
        Me.btn_Emp.Text = "บุคลากร"
        Me.btn_Emp.UseVisualStyleBackColor = False
        '
        'btn_Finan
        '
        Me.btn_Finan.BackColor = System.Drawing.Color.Transparent
        Me.btn_Finan.BackgroundImage = Global.Dentral.My.Resources.Resources.menu_1
        Me.btn_Finan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Finan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Finan.FlatAppearance.BorderSize = 0
        Me.btn_Finan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Finan.Font = New System.Drawing.Font("RSU TEXT", 25.0!)
        Me.btn_Finan.Location = New System.Drawing.Point(0, 337)
        Me.btn_Finan.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Finan.Name = "btn_Finan"
        Me.btn_Finan.Size = New System.Drawing.Size(211, 66)
        Me.btn_Finan.TabIndex = 3
        Me.btn_Finan.Text = "การเงิน"
        Me.btn_Finan.UseVisualStyleBackColor = False
        '
        'btn_Drug
        '
        Me.btn_Drug.BackColor = System.Drawing.Color.Transparent
        Me.btn_Drug.BackgroundImage = Global.Dentral.My.Resources.Resources.menu_2
        Me.btn_Drug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Drug.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Drug.FlatAppearance.BorderSize = 0
        Me.btn_Drug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Drug.Font = New System.Drawing.Font("RSU TEXT", 25.0!)
        Me.btn_Drug.Location = New System.Drawing.Point(0, 271)
        Me.btn_Drug.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Drug.Name = "btn_Drug"
        Me.btn_Drug.Size = New System.Drawing.Size(211, 66)
        Me.btn_Drug.TabIndex = 2
        Me.btn_Drug.Text = "เวชภัณฑ์"
        Me.btn_Drug.UseVisualStyleBackColor = False
        '
        'btn_Record
        '
        Me.btn_Record.BackColor = System.Drawing.Color.Transparent
        Me.btn_Record.BackgroundImage = Global.Dentral.My.Resources.Resources.menu_1
        Me.btn_Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Record.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Record.FlatAppearance.BorderSize = 0
        Me.btn_Record.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Record.Font = New System.Drawing.Font("RSU TEXT", 25.0!)
        Me.btn_Record.Location = New System.Drawing.Point(0, 205)
        Me.btn_Record.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Record.Name = "btn_Record"
        Me.btn_Record.Size = New System.Drawing.Size(211, 66)
        Me.btn_Record.TabIndex = 1
        Me.btn_Record.Text = "เวชระเบียน"
        Me.btn_Record.UseVisualStyleBackColor = False
        '
        'tab_username
        '
        Me.tab_username.BackgroundImage = Global.Dentral.My.Resources.Resources.username
        Me.tab_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tab_username.Controls.Add(Me.usern)
        Me.tab_username.Controls.Add(Me.profile_image)
        Me.tab_username.Controls.Add(Me.btn_logout)
        Me.tab_username.Controls.Add(Me.btn_home)
        Me.tab_username.Dock = System.Windows.Forms.DockStyle.Top
        Me.tab_username.Location = New System.Drawing.Point(0, 0)
        Me.tab_username.Margin = New System.Windows.Forms.Padding(0)
        Me.tab_username.Name = "tab_username"
        Me.tab_username.Size = New System.Drawing.Size(211, 205)
        Me.tab_username.TabIndex = 0
        '
        'usern
        '
        Me.usern.AutoSize = True
        Me.usern.Location = New System.Drawing.Point(25, 127)
        Me.usern.Name = "usern"
        Me.usern.Size = New System.Drawing.Size(72, 31)
        Me.usern.TabIndex = 3
        Me.usern.Text = "username"
        '
        'profile_image
        '
        Me.profile_image.Image = Global.Dentral.My.Resources.Resources.person
        Me.profile_image.Location = New System.Drawing.Point(0, 0)
        Me.profile_image.Name = "profile_image"
        Me.profile_image.Size = New System.Drawing.Size(118, 124)
        Me.profile_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.profile_image.TabIndex = 2
        Me.profile_image.TabStop = False
        '
        'btn_logout
        '
        Me.btn_logout.BackgroundImage = Global.Dentral.My.Resources.Resources.exit1
        Me.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Location = New System.Drawing.Point(174, 168)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(31, 29)
        Me.btn_logout.TabIndex = 1
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.BackgroundImage = Global.Dentral.My.Resources.Resources.btn_home
        Me.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_home.FlatAppearance.BorderSize = 0
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Location = New System.Drawing.Point(130, 160)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(38, 38)
        Me.btn_home.TabIndex = 0
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'Login_p
        '
        Me.Login_p.BackColor = System.Drawing.Color.Transparent
        Me.Login_p.Controls.Add(Me.login_p2)
        Me.Login_p.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Login_p.Location = New System.Drawing.Point(0, 32)
        Me.Login_p.Name = "Login_p"
        Me.Login_p.Size = New System.Drawing.Size(1024, 736)
        Me.Login_p.TabIndex = 2
        '
        'login_p2
        '
        Me.login_p2.Controls.Add(Me.PictureBox2)
        Me.login_p2.Controls.Add(Me.PictureBox1)
        Me.login_p2.Controls.Add(Me.Label1)
        Me.login_p2.Controls.Add(Me.Username)
        Me.login_p2.Controls.Add(Me.Label2)
        Me.login_p2.Controls.Add(Me.Label3)
        Me.login_p2.Controls.Add(Me.Password)
        Me.login_p2.Controls.Add(Me.PictureBox3)
        Me.login_p2.Controls.Add(Me.btn_Login)
        Me.login_p2.Dock = System.Windows.Forms.DockStyle.Right
        Me.login_p2.Location = New System.Drawing.Point(500, 0)
        Me.login_p2.Name = "login_p2"
        Me.login_p2.Size = New System.Drawing.Size(524, 736)
        Me.login_p2.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = Global.Dentral.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(158, 54)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(190, 181)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-9, 325)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5, 14, 5, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(601, 1)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("RSU TEXT", 40.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(133, 238)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 60)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "ลงชื่อเข้าสู่ระบบ"
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Username.FormattingEnabled = True
        Me.Username.Location = New System.Drawing.Point(158, 345)
        Me.Username.Margin = New System.Windows.Forms.Padding(5, 14, 5, 14)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(287, 39)
        Me.Username.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("RSU TEXT", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(42, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 36)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "ชื่อผู้ใช้งาน :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("RSU TEXT", 24.0!)
        Me.Label3.Location = New System.Drawing.Point(59, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 36)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "รหัสผ่าน :"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(158, 408)
        Me.Password.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(287, 37)
        Me.Password.TabIndex = 40
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(-9, 521)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(5, 14, 5, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(601, 1)
        Me.PictureBox3.TabIndex = 41
        Me.PictureBox3.TabStop = False
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.Transparent
        Me.btn_Login.BackgroundImage = Global.Dentral.My.Resources.Resources.Login_Default
        Me.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Login.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Login.FlatAppearance.BorderSize = 0
        Me.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Login.ForeColor = System.Drawing.Color.Transparent
        Me.btn_Login.Location = New System.Drawing.Point(352, 459)
        Me.btn_Login.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(116, 50)
        Me.btn_Login.TabIndex = 42
        Me.btn_Login.UseVisualStyleBackColor = False
        '
        'Taskbar
        '
        Me.Taskbar.BackgroundImage = Global.Dentral.My.Resources.Resources.taskbar
        Me.Taskbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Taskbar.Controls.Add(Me.tasktools)
        Me.Taskbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Taskbar.Location = New System.Drawing.Point(0, 0)
        Me.Taskbar.Margin = New System.Windows.Forms.Padding(0)
        Me.Taskbar.Name = "Taskbar"
        Me.Taskbar.Size = New System.Drawing.Size(1024, 32)
        Me.Taskbar.TabIndex = 0
        '
        'tasktools
        '
        Me.tasktools.BackColor = System.Drawing.Color.Transparent
        Me.tasktools.Controls.Add(Me.btn_min)
        Me.tasktools.Controls.Add(Me.btn_exit)
        Me.tasktools.Dock = System.Windows.Forms.DockStyle.Right
        Me.tasktools.Location = New System.Drawing.Point(942, 0)
        Me.tasktools.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.tasktools.Name = "tasktools"
        Me.tasktools.Size = New System.Drawing.Size(82, 32)
        Me.tasktools.TabIndex = 0
        '
        'btn_min
        '
        Me.btn_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_min.Image = Global.Dentral.My.Resources.Resources.min
        Me.btn_min.Location = New System.Drawing.Point(8, 4)
        Me.btn_min.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(27, 25)
        Me.btn_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btn_min.TabIndex = 1
        Me.btn_min.TabStop = False
        '
        'btn_exit
        '
        Me.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_exit.Image = Global.Dentral.My.Resources.Resources._exit
        Me.btn_exit.Location = New System.Drawing.Point(46, 4)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(27, 25)
        Me.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_exit.TabIndex = 0
        Me.btn_exit.TabStop = False
        '
        'After_sel_finTableAdapter
        '
        Me.After_sel_finTableAdapter.ClearBeforeFill = True
        '
        'Show_finTableAdapter
        '
        Me.Show_finTableAdapter.ClearBeforeFill = True
        '
        'Medi_showTableAdapter
        '
        Me.Medi_showTableAdapter.ClearBeforeFill = True
        '
        'List_medTableAdapter
        '
        Me.List_medTableAdapter.ClearBeforeFill = True
        '
        'SedentralDataSet3
        '
        Me.SedentralDataSet3.DataSetName = "sedentralDataSet"
        Me.SedentralDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Data_recTableAdapter
        '
        Me.Data_recTableAdapter.ClearBeforeFill = True
        '
        'GetDoctorTableAdapter
        '
        Me.GetDoctorTableAdapter.ClearBeforeFill = True
        '
        'History_recordTableAdapter
        '
        Me.History_recordTableAdapter.ClearBeforeFill = True
        '
        'After_sel_recTableAdapter
        '
        Me.After_sel_recTableAdapter.ClearBeforeFill = True
        '
        'Emp_depTableAdapter
        '
        Me.Emp_depTableAdapter.ClearBeforeFill = True
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'Medi_s1TableAdapter
        '
        Me.Medi_s1TableAdapter.ClearBeforeFill = True
        '
        'Sup_typeTableAdapter
        '
        Me.Sup_typeTableAdapter.ClearBeforeFill = True
        '
        'U_aTableAdapter
        '
        Me.U_aTableAdapter.ClearBeforeFill = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'User_typeTableAdapter
        '
        Me.User_typeTableAdapter.ClearBeforeFill = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(376, 584)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(177, 31)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "จำนวนเงินที่ชำระทั้งหมด :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dentral.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.GUI)
        Me.Controls.Add(Me.Login_p)
        Me.Controls.Add(Me.Taskbar)
        Me.Font = New System.Drawing.Font("RSU TEXT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GUI.ResumeLayout(False)
        Me.Record_main.ResumeLayout(False)
        Me.Record_main.PerformLayout()
        CType(Me.data_record, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatarecBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SedentralDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Finan_aftersel.ResumeLayout(False)
        Me.Finan_aftersel.PerformLayout()
        CType(Me.after_sel_fin_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AfterselfinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SedentralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Finan.ResumeLayout(False)
        Me.Finan.PerformLayout()
        CType(Me.show_finan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowfinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SedentralDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Record_search_pat.ResumeLayout(False)
        Me.Record_search_pat.PerformLayout()
        Me.add_file.ResumeLayout(False)
        Me.his_rec.ResumeLayout(False)
        Me.his_rec.PerformLayout()
        Me.Record_searchrec_list.ResumeLayout(False)
        Me.Record_searchrec_list.PerformLayout()
        Me.Is_NewReport.ResumeLayout(False)
        Me.Is_NewReport.PerformLayout()
        CType(Me.GetDoctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedishowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_med_list, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListmedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Record_after_sel_his.ResumeLayout(False)
        CType(Me.data_after_sel_his, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AfterselrecBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Record_history.ResumeLayout(False)
        CType(Me.data_history_rec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryrecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Drug.ResumeLayout(False)
        Me.Drug.PerformLayout()
        CType(Me.SuptypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_medic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Medis1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Employee.ResumeLayout(False)
        Me.Employee.PerformLayout()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_emp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpdepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Admin.ResumeLayout(False)
        Me.Admin.PerformLayout()
        CType(Me.UsertypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Home.ResumeLayout(False)
        CType(Me.Home_intro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menubar.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_username.ResumeLayout(False)
        Me.tab_username.PerformLayout()
        CType(Me.profile_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Login_p.ResumeLayout(False)
        Me.login_p2.ResumeLayout(False)
        Me.login_p2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Taskbar.ResumeLayout(False)
        Me.tasktools.ResumeLayout(False)
        CType(Me.btn_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SedentralDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    
End Class
