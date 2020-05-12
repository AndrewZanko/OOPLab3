namespace OOP3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.employLabel = new System.Windows.Forms.Label();
            this.factoryWorkerButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.employeesListView = new System.Windows.Forms.ListView();
            this.machineNumberTB = new System.Windows.Forms.TextBox();
            this.rankCB = new System.Windows.Forms.ComboBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.salaryTB = new System.Windows.Forms.TextBox();
            this.machineNumberLabel = new System.Windows.Forms.Label();
            this.rankLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentCB = new System.Windows.Forms.ComboBox();
            this.positionTB = new System.Windows.Forms.TextBox();
            this.researchAreaTB = new System.Windows.Forms.TextBox();
            this.scienseDegreeCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serviseWeaponIDTB = new System.Windows.Forms.TextBox();
            this.toleranceLevelCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.storageNumberTB = new System.Windows.Forms.TextBox();
            this.storageTypeCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.autoTB = new System.Windows.Forms.TextBox();
            this.courierTypeCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.infoTB = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // employLabel
            // 
            this.employLabel.AutoSize = true;
            this.employLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employLabel.Location = new System.Drawing.Point(572, 90);
            this.employLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employLabel.Name = "employLabel";
            this.employLabel.Size = new System.Drawing.Size(94, 25);
            this.employLabel.TabIndex = 1;
            this.employLabel.Text = "НАНЯТЬ:";
            // 
            // factoryWorkerButton
            // 
            this.factoryWorkerButton.Location = new System.Drawing.Point(412, 151);
            this.factoryWorkerButton.Margin = new System.Windows.Forms.Padding(4);
            this.factoryWorkerButton.Name = "factoryWorkerButton";
            this.factoryWorkerButton.Size = new System.Drawing.Size(144, 28);
            this.factoryWorkerButton.TabIndex = 2;
            this.factoryWorkerButton.Text = "Рабочий завода";
            this.factoryWorkerButton.UseVisualStyleBackColor = true;
            this.factoryWorkerButton.Click += new System.EventHandler(this.factoryWorkerButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(700, 151);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Офисный работник";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 299);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ученый";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(712, 299);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "Охрана";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(412, 430);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 28);
            this.button5.TabIndex = 6;
            this.button5.Text = "Работник склада";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(712, 430);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 28);
            this.button6.TabIndex = 7;
            this.button6.Text = "Курьер";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // employeesListView
            // 
            this.employeesListView.HideSelection = false;
            this.employeesListView.Location = new System.Drawing.Point(16, 122);
            this.employeesListView.Margin = new System.Windows.Forms.Padding(4);
            this.employeesListView.MultiSelect = false;
            this.employeesListView.Name = "employeesListView";
            this.employeesListView.Size = new System.Drawing.Size(297, 266);
            this.employeesListView.TabIndex = 8;
            this.employeesListView.UseCompatibleStateImageBehavior = false;
            this.employeesListView.View = System.Windows.Forms.View.List;
            this.employeesListView.SelectedIndexChanged += new System.EventHandler(this.employeesListView_SelectedIndexChanged);
            // 
            // machineNumberTB
            // 
            this.machineNumberTB.Location = new System.Drawing.Point(447, 224);
            this.machineNumberTB.Margin = new System.Windows.Forms.Padding(4);
            this.machineNumberTB.Name = "machineNumberTB";
            this.machineNumberTB.Size = new System.Drawing.Size(132, 22);
            this.machineNumberTB.TabIndex = 16;
            // 
            // rankCB
            // 
            this.rankCB.FormattingEnabled = true;
            this.rankCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.rankCB.Location = new System.Drawing.Point(447, 187);
            this.rankCB.Margin = new System.Windows.Forms.Padding(4);
            this.rankCB.Name = "rankCB";
            this.rankCB.Size = new System.Drawing.Size(132, 24);
            this.rankCB.TabIndex = 15;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(484, 49);
            this.idTB.Margin = new System.Windows.Forms.Padding(4);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(132, 22);
            this.idTB.TabIndex = 14;
            // 
            // salaryTB
            // 
            this.salaryTB.Location = new System.Drawing.Point(484, 17);
            this.salaryTB.Margin = new System.Windows.Forms.Padding(4);
            this.salaryTB.Name = "salaryTB";
            this.salaryTB.Size = new System.Drawing.Size(132, 22);
            this.salaryTB.TabIndex = 13;
            // 
            // machineNumberLabel
            // 
            this.machineNumberLabel.AutoSize = true;
            this.machineNumberLabel.Location = new System.Drawing.Point(327, 233);
            this.machineNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.machineNumberLabel.Name = "machineNumberLabel";
            this.machineNumberLabel.Size = new System.Drawing.Size(100, 17);
            this.machineNumberLabel.TabIndex = 12;
            this.machineNumberLabel.Text = "Номер станка";
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Location = new System.Drawing.Point(327, 197);
            this.rankLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(56, 17);
            this.rankLabel.TabIndex = 11;
            this.rankLabel.Text = "Разряд";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(408, 58);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(42, 17);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "ФИО";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(408, 26);
            this.salaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(72, 17);
            this.salaryLabel.TabIndex = 9;
            this.salaryLabel.Text = "Зарплата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Отдел";
            // 
            // departmentCB
            // 
            this.departmentCB.AutoCompleteCustomSource.AddRange(new string[] {
            "Продаж",
            "Рекламы",
            "Аналитики",
            "Администрация"});
            this.departmentCB.FormattingEnabled = true;
            this.departmentCB.Items.AddRange(new object[] {
            "Отдел Продаж",
            "Отдел Управлени",
            "Отдел Логистики",
            "Отдел Кадров",
            "Отдел Аналитики",
            "Отдел Рекламы"});
            this.departmentCB.Location = new System.Drawing.Point(712, 187);
            this.departmentCB.Margin = new System.Windows.Forms.Padding(4);
            this.departmentCB.Name = "departmentCB";
            this.departmentCB.Size = new System.Drawing.Size(132, 24);
            this.departmentCB.TabIndex = 19;
            // 
            // positionTB
            // 
            this.positionTB.Location = new System.Drawing.Point(712, 224);
            this.positionTB.Margin = new System.Windows.Forms.Padding(4);
            this.positionTB.Name = "positionTB";
            this.positionTB.Size = new System.Drawing.Size(132, 22);
            this.positionTB.TabIndex = 20;
            // 
            // researchAreaTB
            // 
            this.researchAreaTB.Location = new System.Drawing.Point(501, 368);
            this.researchAreaTB.Margin = new System.Windows.Forms.Padding(4);
            this.researchAreaTB.Name = "researchAreaTB";
            this.researchAreaTB.Size = new System.Drawing.Size(132, 22);
            this.researchAreaTB.TabIndex = 24;
            // 
            // scienseDegreeCB
            // 
            this.scienseDegreeCB.AutoCompleteCustomSource.AddRange(new string[] {
            "Бакалавр",
            "Магистр",
            "Доктор"});
            this.scienseDegreeCB.FormattingEnabled = true;
            this.scienseDegreeCB.Items.AddRange(new object[] {
            "Бакалавр",
            "Магистр",
            "Кандидат наук",
            "Доктор"});
            this.scienseDegreeCB.Location = new System.Drawing.Point(501, 335);
            this.scienseDegreeCB.Margin = new System.Windows.Forms.Padding(4);
            this.scienseDegreeCB.Name = "scienseDegreeCB";
            this.scienseDegreeCB.Size = new System.Drawing.Size(132, 24);
            this.scienseDegreeCB.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 377);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Область исследований";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Научная степень";
            // 
            // serviseWeaponIDTB
            // 
            this.serviseWeaponIDTB.Location = new System.Drawing.Point(827, 364);
            this.serviseWeaponIDTB.Margin = new System.Windows.Forms.Padding(4);
            this.serviseWeaponIDTB.Name = "serviseWeaponIDTB";
            this.serviseWeaponIDTB.Size = new System.Drawing.Size(132, 22);
            this.serviseWeaponIDTB.TabIndex = 28;
            // 
            // toleranceLevelCB
            // 
            this.toleranceLevelCB.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.toleranceLevelCB.FormattingEnabled = true;
            this.toleranceLevelCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.toleranceLevelCB.Location = new System.Drawing.Point(827, 331);
            this.toleranceLevelCB.Margin = new System.Windows.Forms.Padding(4);
            this.toleranceLevelCB.Name = "toleranceLevelCB";
            this.toleranceLevelCB.Size = new System.Drawing.Size(132, 24);
            this.toleranceLevelCB.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 373);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "ID служебного оружия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(652, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Уровень допуска";
            // 
            // storageNumberTB
            // 
            this.storageNumberTB.Location = new System.Drawing.Point(484, 521);
            this.storageNumberTB.Margin = new System.Windows.Forms.Padding(4);
            this.storageNumberTB.Name = "storageNumberTB";
            this.storageNumberTB.Size = new System.Drawing.Size(132, 22);
            this.storageNumberTB.TabIndex = 32;
            // 
            // storageTypeCB
            // 
            this.storageTypeCB.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.storageTypeCB.FormattingEnabled = true;
            this.storageTypeCB.Items.AddRange(new object[] {
            "В черте города",
            "За городом"});
            this.storageTypeCB.Location = new System.Drawing.Point(484, 487);
            this.storageTypeCB.Margin = new System.Windows.Forms.Padding(4);
            this.storageTypeCB.Name = "storageTypeCB";
            this.storageTypeCB.Size = new System.Drawing.Size(132, 24);
            this.storageTypeCB.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 524);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Номер склада\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 491);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Тип склада";
            // 
            // autoTB
            // 
            this.autoTB.Location = new System.Drawing.Point(815, 517);
            this.autoTB.Margin = new System.Windows.Forms.Padding(4);
            this.autoTB.Name = "autoTB";
            this.autoTB.Size = new System.Drawing.Size(132, 22);
            this.autoTB.TabIndex = 36;
            // 
            // courierTypeCB
            // 
            this.courierTypeCB.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.courierTypeCB.FormattingEnabled = true;
            this.courierTypeCB.Items.AddRange(new object[] {
            "Дневная смена",
            "Ночная смена"});
            this.courierTypeCB.Location = new System.Drawing.Point(815, 484);
            this.courierTypeCB.Margin = new System.Windows.Forms.Padding(4);
            this.courierTypeCB.Name = "courierTypeCB";
            this.courierTypeCB.Size = new System.Drawing.Size(132, 24);
            this.courierTypeCB.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(640, 526);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Авто курьера";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(640, 490);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Тип курьера";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(60, 90);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 25);
            this.label11.TabIndex = 37;
            this.label11.Text = "Список работников";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(16, 411);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(141, 47);
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "СОХРАНИТЬ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 411);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 47);
            this.button1.TabIndex = 39;
            this.button1.Text = "ЗАГРУЗИТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoTB
            // 
            this.infoTB.Location = new System.Drawing.Point(16, 465);
            this.infoTB.Margin = new System.Windows.Forms.Padding(4);
            this.infoTB.Multiline = true;
            this.infoTB.Name = "infoTB";
            this.infoTB.Size = new System.Drawing.Size(285, 214);
            this.infoTB.TabIndex = 40;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(347, 634);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 47);
            this.button7.TabIndex = 41;
            this.button7.Text = "РЕДАКТИРОВАТЬ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(556, 634);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(141, 47);
            this.button8.TabIndex = 42;
            this.button8.Text = "УВОЛИТЬ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 718);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.infoTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.autoTB);
            this.Controls.Add(this.courierTypeCB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.storageNumberTB);
            this.Controls.Add(this.storageTypeCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.serviseWeaponIDTB);
            this.Controls.Add(this.toleranceLevelCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.researchAreaTB);
            this.Controls.Add(this.scienseDegreeCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.positionTB);
            this.Controls.Add(this.departmentCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.machineNumberTB);
            this.Controls.Add(this.rankCB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.salaryTB);
            this.Controls.Add(this.machineNumberLabel);
            this.Controls.Add(this.rankLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.employeesListView);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.factoryWorkerButton);
            this.Controls.Add(this.employLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label employLabel;
        private System.Windows.Forms.Button factoryWorkerButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListView employeesListView;
        private System.Windows.Forms.TextBox machineNumberTB;
        private System.Windows.Forms.ComboBox rankCB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox salaryTB;
        private System.Windows.Forms.Label machineNumberLabel;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox departmentCB;
        private System.Windows.Forms.TextBox positionTB;
        private System.Windows.Forms.TextBox researchAreaTB;
        private System.Windows.Forms.ComboBox scienseDegreeCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serviseWeaponIDTB;
        private System.Windows.Forms.ComboBox toleranceLevelCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox storageNumberTB;
        private System.Windows.Forms.ComboBox storageTypeCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox autoTB;
        private System.Windows.Forms.ComboBox courierTypeCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox infoTB;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

