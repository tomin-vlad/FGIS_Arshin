namespace FGIS_Arshin
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.buttonHelp = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFilter = new System.Windows.Forms.TabPage();
            this.comboBoxApplicability = new System.Windows.Forms.ComboBox();
            this.labelApplicability = new System.Windows.Forms.Label();
            this.checkBoxSticker = new System.Windows.Forms.CheckBox();
            this.textBoxSticker = new System.Windows.Forms.TextBox();
            this.labelSticker = new System.Windows.Forms.Label();
            this.checkBoxDocnum = new System.Windows.Forms.CheckBox();
            this.textBoxDocnum = new System.Windows.Forms.TextBox();
            this.labelDocnum = new System.Windows.Forms.Label();
            this.labelValid = new System.Windows.Forms.Label();
            this.dateTimePickerValidStart = new System.Windows.Forms.DateTimePicker();
            this.labelValidTo = new System.Windows.Forms.Label();
            this.dateTimePickerValidEnd = new System.Windows.Forms.DateTimePicker();
            this.labelYear = new System.Windows.Forms.Label();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.labelVerification = new System.Windows.Forms.Label();
            this.dateTimePickerVerificationStart = new System.Windows.Forms.DateTimePicker();
            this.labelVerificationTo = new System.Windows.Forms.Label();
            this.dateTimePickerVerificationEnd = new System.Windows.Forms.DateTimePicker();
            this.checkBoxMiNumber = new System.Windows.Forms.CheckBox();
            this.textBoxMiNumber = new System.Windows.Forms.TextBox();
            this.labelMiNumber = new System.Windows.Forms.Label();
            this.checkBoxMiModification = new System.Windows.Forms.CheckBox();
            this.textBoxMiModification = new System.Windows.Forms.TextBox();
            this.labelMiModification = new System.Windows.Forms.Label();
            this.checkBoxMitNotation = new System.Windows.Forms.CheckBox();
            this.textBoxMitNotation = new System.Windows.Forms.TextBox();
            this.labelMitNotation = new System.Windows.Forms.Label();
            this.checkBoxMitTitle = new System.Windows.Forms.CheckBox();
            this.textBoxMitTitle = new System.Windows.Forms.TextBox();
            this.labelMitTitle = new System.Windows.Forms.Label();
            this.checkBoxMitNumber = new System.Windows.Forms.CheckBox();
            this.textBoxMitNumber = new System.Windows.Forms.TextBox();
            this.labelMitNumber = new System.Windows.Forms.Label();
            this.checkBoxOrgTitle = new System.Windows.Forms.CheckBox();
            this.textBoxOrgTitle = new System.Windows.Forms.TextBox();
            this.labelOrgTitle = new System.Windows.Forms.Label();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.buttonUnload = new System.Windows.Forms.Button();
            this.textBoxUnload = new System.Windows.Forms.TextBox();
            this.labelUnload = new System.Windows.Forms.Label();
            this.labelTries = new System.Windows.Forms.Label();
            this.numericUpDownTries = new System.Windows.Forms.NumericUpDown();
            this.labelRepeat = new System.Windows.Forms.Label();
            this.groupBoxFields = new System.Windows.Forms.GroupBox();
            this.checkBoxField11 = new System.Windows.Forms.CheckBox();
            this.checkBoxField10 = new System.Windows.Forms.CheckBox();
            this.checkBoxField9 = new System.Windows.Forms.CheckBox();
            this.checkBoxField8 = new System.Windows.Forms.CheckBox();
            this.checkBoxField7 = new System.Windows.Forms.CheckBox();
            this.checkBoxField6 = new System.Windows.Forms.CheckBox();
            this.checkBoxField5 = new System.Windows.Forms.CheckBox();
            this.checkBoxField4 = new System.Windows.Forms.CheckBox();
            this.checkBoxField3 = new System.Windows.Forms.CheckBox();
            this.checkBoxField2 = new System.Windows.Forms.CheckBox();
            this.checkBoxField1 = new System.Windows.Forms.CheckBox();
            this.labelItems = new System.Windows.Forms.Label();
            this.labelSort = new System.Windows.Forms.Label();
            this.labelMs = new System.Windows.Forms.Label();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.numericUpDownPause = new System.Windows.Forms.NumericUpDown();
            this.checkBoxSorted = new System.Windows.Forms.CheckBox();
            this.labelPause = new System.Windows.Forms.Label();
            this.labelRows = new System.Windows.Forms.Label();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.progressBarProcess = new System.Windows.Forms.ProgressBar();
            this.labelPercent = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageFilter.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTries)).BeginInit();
            this.groupBoxFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.Location = new System.Drawing.Point(478, 16);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(96, 28);
            this.buttonHelp.TabIndex = 32;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFilter);
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 439);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPageFilter
            // 
            this.tabPageFilter.Controls.Add(this.comboBoxApplicability);
            this.tabPageFilter.Controls.Add(this.labelApplicability);
            this.tabPageFilter.Controls.Add(this.checkBoxSticker);
            this.tabPageFilter.Controls.Add(this.textBoxSticker);
            this.tabPageFilter.Controls.Add(this.labelSticker);
            this.tabPageFilter.Controls.Add(this.checkBoxDocnum);
            this.tabPageFilter.Controls.Add(this.textBoxDocnum);
            this.tabPageFilter.Controls.Add(this.labelDocnum);
            this.tabPageFilter.Controls.Add(this.labelValid);
            this.tabPageFilter.Controls.Add(this.dateTimePickerValidStart);
            this.tabPageFilter.Controls.Add(this.labelValidTo);
            this.tabPageFilter.Controls.Add(this.dateTimePickerValidEnd);
            this.tabPageFilter.Controls.Add(this.labelYear);
            this.tabPageFilter.Controls.Add(this.dateTimePickerYear);
            this.tabPageFilter.Controls.Add(this.labelVerification);
            this.tabPageFilter.Controls.Add(this.dateTimePickerVerificationStart);
            this.tabPageFilter.Controls.Add(this.labelVerificationTo);
            this.tabPageFilter.Controls.Add(this.dateTimePickerVerificationEnd);
            this.tabPageFilter.Controls.Add(this.checkBoxMiNumber);
            this.tabPageFilter.Controls.Add(this.textBoxMiNumber);
            this.tabPageFilter.Controls.Add(this.labelMiNumber);
            this.tabPageFilter.Controls.Add(this.checkBoxMiModification);
            this.tabPageFilter.Controls.Add(this.textBoxMiModification);
            this.tabPageFilter.Controls.Add(this.labelMiModification);
            this.tabPageFilter.Controls.Add(this.checkBoxMitNotation);
            this.tabPageFilter.Controls.Add(this.textBoxMitNotation);
            this.tabPageFilter.Controls.Add(this.labelMitNotation);
            this.tabPageFilter.Controls.Add(this.checkBoxMitTitle);
            this.tabPageFilter.Controls.Add(this.textBoxMitTitle);
            this.tabPageFilter.Controls.Add(this.labelMitTitle);
            this.tabPageFilter.Controls.Add(this.checkBoxMitNumber);
            this.tabPageFilter.Controls.Add(this.textBoxMitNumber);
            this.tabPageFilter.Controls.Add(this.labelMitNumber);
            this.tabPageFilter.Controls.Add(this.checkBoxOrgTitle);
            this.tabPageFilter.Controls.Add(this.textBoxOrgTitle);
            this.tabPageFilter.Controls.Add(this.labelOrgTitle);
            this.tabPageFilter.Location = new System.Drawing.Point(4, 25);
            this.tabPageFilter.Name = "tabPageFilter";
            this.tabPageFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilter.Size = new System.Drawing.Size(558, 410);
            this.tabPageFilter.TabIndex = 1;
            this.tabPageFilter.Text = "Фильтр";
            this.tabPageFilter.UseVisualStyleBackColor = true;
            // 
            // comboBoxApplicability
            // 
            this.comboBoxApplicability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApplicability.FormattingEnabled = true;
            this.comboBoxApplicability.Items.AddRange(new object[] {
            "Нет",
            "Да",
            "Не выбрано"});
            this.comboBoxApplicability.Location = new System.Drawing.Point(233, 347);
            this.comboBoxApplicability.Name = "comboBoxApplicability";
            this.comboBoxApplicability.Size = new System.Drawing.Size(235, 24);
            this.comboBoxApplicability.TabIndex = 39;
            this.comboBoxApplicability.SelectedIndexChanged += new System.EventHandler(this.comboBoxApplicability_SelectedIndexChanged);
            // 
            // labelApplicability
            // 
            this.labelApplicability.AutoSize = true;
            this.labelApplicability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelApplicability.Location = new System.Drawing.Point(16, 350);
            this.labelApplicability.Name = "labelApplicability";
            this.labelApplicability.Size = new System.Drawing.Size(92, 16);
            this.labelApplicability.TabIndex = 36;
            this.labelApplicability.Text = "Пригодность";
            // 
            // checkBoxSticker
            // 
            this.checkBoxSticker.AutoSize = true;
            this.checkBoxSticker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSticker.Location = new System.Drawing.Point(474, 323);
            this.checkBoxSticker.Name = "checkBoxSticker";
            this.checkBoxSticker.Size = new System.Drawing.Size(67, 20);
            this.checkBoxSticker.TabIndex = 35;
            this.checkBoxSticker.Text = "Точно";
            this.checkBoxSticker.UseVisualStyleBackColor = true;
            this.checkBoxSticker.CheckedChanged += new System.EventHandler(this.checkBoxSticker_CheckedChanged);
            // 
            // textBoxSticker
            // 
            this.textBoxSticker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSticker.Location = new System.Drawing.Point(233, 319);
            this.textBoxSticker.Name = "textBoxSticker";
            this.textBoxSticker.Size = new System.Drawing.Size(235, 22);
            this.textBoxSticker.TabIndex = 34;
            this.textBoxSticker.TextChanged += new System.EventHandler(this.textBoxSticker_TextChanged);
            // 
            // labelSticker
            // 
            this.labelSticker.AutoSize = true;
            this.labelSticker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSticker.Location = new System.Drawing.Point(16, 322);
            this.labelSticker.Name = "labelSticker";
            this.labelSticker.Size = new System.Drawing.Size(115, 16);
            this.labelSticker.TabIndex = 33;
            this.labelSticker.Text = "Номер наклейки";
            // 
            // checkBoxDocnum
            // 
            this.checkBoxDocnum.AutoSize = true;
            this.checkBoxDocnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDocnum.Location = new System.Drawing.Point(474, 295);
            this.checkBoxDocnum.Name = "checkBoxDocnum";
            this.checkBoxDocnum.Size = new System.Drawing.Size(67, 20);
            this.checkBoxDocnum.TabIndex = 32;
            this.checkBoxDocnum.Text = "Точно";
            this.checkBoxDocnum.UseVisualStyleBackColor = true;
            this.checkBoxDocnum.CheckedChanged += new System.EventHandler(this.checkBoxDocnum_CheckedChanged);
            // 
            // textBoxDocnum
            // 
            this.textBoxDocnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDocnum.Location = new System.Drawing.Point(233, 291);
            this.textBoxDocnum.Name = "textBoxDocnum";
            this.textBoxDocnum.Size = new System.Drawing.Size(235, 22);
            this.textBoxDocnum.TabIndex = 31;
            this.textBoxDocnum.TextChanged += new System.EventHandler(this.textBoxDocnum_TextChanged);
            // 
            // labelDocnum
            // 
            this.labelDocnum.AutoSize = true;
            this.labelDocnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDocnum.Location = new System.Drawing.Point(16, 294);
            this.labelDocnum.Name = "labelDocnum";
            this.labelDocnum.Size = new System.Drawing.Size(156, 16);
            this.labelDocnum.TabIndex = 30;
            this.labelDocnum.Text = "Номер свидет. / извещ.";
            // 
            // labelValid
            // 
            this.labelValid.AutoSize = true;
            this.labelValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValid.Location = new System.Drawing.Point(16, 266);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(127, 16);
            this.labelValid.TabIndex = 26;
            this.labelValid.Text = "Действительна до";
            // 
            // dateTimePickerValidStart
            // 
            this.dateTimePickerValidStart.Checked = false;
            this.dateTimePickerValidStart.CustomFormat = "";
            this.dateTimePickerValidStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerValidStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerValidStart.Location = new System.Drawing.Point(233, 263);
            this.dateTimePickerValidStart.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerValidStart.Name = "dateTimePickerValidStart";
            this.dateTimePickerValidStart.ShowCheckBox = true;
            this.dateTimePickerValidStart.Size = new System.Drawing.Size(106, 22);
            this.dateTimePickerValidStart.TabIndex = 27;
            this.dateTimePickerValidStart.ValueChanged += new System.EventHandler(this.dateTimePickerValidStart_ValueChanged);
            // 
            // labelValidTo
            // 
            this.labelValidTo.AutoSize = true;
            this.labelValidTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValidTo.Location = new System.Drawing.Point(345, 268);
            this.labelValidTo.Name = "labelValidTo";
            this.labelValidTo.Size = new System.Drawing.Size(11, 16);
            this.labelValidTo.TabIndex = 28;
            this.labelValidTo.Text = "-";
            // 
            // dateTimePickerValidEnd
            // 
            this.dateTimePickerValidEnd.Checked = false;
            this.dateTimePickerValidEnd.CustomFormat = "";
            this.dateTimePickerValidEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerValidEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerValidEnd.Location = new System.Drawing.Point(362, 263);
            this.dateTimePickerValidEnd.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerValidEnd.Name = "dateTimePickerValidEnd";
            this.dateTimePickerValidEnd.ShowCheckBox = true;
            this.dateTimePickerValidEnd.Size = new System.Drawing.Size(106, 22);
            this.dateTimePickerValidEnd.TabIndex = 29;
            this.dateTimePickerValidEnd.ValueChanged += new System.EventHandler(this.dateTimePickerValidEnd_ValueChanged);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.Location = new System.Drawing.Point(16, 44);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(30, 16);
            this.labelYear.TabIndex = 24;
            this.labelYear.Text = "Год";
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.Checked = false;
            this.dateTimePickerYear.CustomFormat = "yyyy";
            this.dateTimePickerYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.Location = new System.Drawing.Point(233, 41);
            this.dateTimePickerYear.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.ShowCheckBox = true;
            this.dateTimePickerYear.Size = new System.Drawing.Size(106, 22);
            this.dateTimePickerYear.TabIndex = 25;
            this.dateTimePickerYear.ValueChanged += new System.EventHandler(this.dateTimePickerYear_ValueChanged);
            // 
            // labelVerification
            // 
            this.labelVerification.AutoSize = true;
            this.labelVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVerification.Location = new System.Drawing.Point(16, 238);
            this.labelVerification.Name = "labelVerification";
            this.labelVerification.Size = new System.Drawing.Size(97, 16);
            this.labelVerification.TabIndex = 18;
            this.labelVerification.Text = "Дата поверки";
            // 
            // dateTimePickerVerificationStart
            // 
            this.dateTimePickerVerificationStart.Checked = false;
            this.dateTimePickerVerificationStart.CustomFormat = "";
            this.dateTimePickerVerificationStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerVerificationStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVerificationStart.Location = new System.Drawing.Point(233, 235);
            this.dateTimePickerVerificationStart.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerVerificationStart.Name = "dateTimePickerVerificationStart";
            this.dateTimePickerVerificationStart.ShowCheckBox = true;
            this.dateTimePickerVerificationStart.Size = new System.Drawing.Size(106, 22);
            this.dateTimePickerVerificationStart.TabIndex = 20;
            this.dateTimePickerVerificationStart.ValueChanged += new System.EventHandler(this.dateTimePickerVerificationStart_ValueChanged);
            // 
            // labelVerificationTo
            // 
            this.labelVerificationTo.AutoSize = true;
            this.labelVerificationTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVerificationTo.Location = new System.Drawing.Point(345, 240);
            this.labelVerificationTo.Name = "labelVerificationTo";
            this.labelVerificationTo.Size = new System.Drawing.Size(11, 16);
            this.labelVerificationTo.TabIndex = 21;
            this.labelVerificationTo.Text = "-";
            // 
            // dateTimePickerVerificationEnd
            // 
            this.dateTimePickerVerificationEnd.Checked = false;
            this.dateTimePickerVerificationEnd.CustomFormat = "";
            this.dateTimePickerVerificationEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerVerificationEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVerificationEnd.Location = new System.Drawing.Point(362, 235);
            this.dateTimePickerVerificationEnd.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerVerificationEnd.Name = "dateTimePickerVerificationEnd";
            this.dateTimePickerVerificationEnd.ShowCheckBox = true;
            this.dateTimePickerVerificationEnd.Size = new System.Drawing.Size(106, 22);
            this.dateTimePickerVerificationEnd.TabIndex = 22;
            this.dateTimePickerVerificationEnd.ValueChanged += new System.EventHandler(this.dateTimePickerVerificationEnd_ValueChanged);
            // 
            // checkBoxMiNumber
            // 
            this.checkBoxMiNumber.AutoSize = true;
            this.checkBoxMiNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMiNumber.Location = new System.Drawing.Point(474, 211);
            this.checkBoxMiNumber.Name = "checkBoxMiNumber";
            this.checkBoxMiNumber.Size = new System.Drawing.Size(67, 20);
            this.checkBoxMiNumber.TabIndex = 17;
            this.checkBoxMiNumber.Text = "Точно";
            this.checkBoxMiNumber.UseVisualStyleBackColor = true;
            this.checkBoxMiNumber.CheckedChanged += new System.EventHandler(this.checkBoxMiNumber_CheckedChanged);
            // 
            // textBoxMiNumber
            // 
            this.textBoxMiNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiNumber.Location = new System.Drawing.Point(233, 207);
            this.textBoxMiNumber.Name = "textBoxMiNumber";
            this.textBoxMiNumber.Size = new System.Drawing.Size(235, 22);
            this.textBoxMiNumber.TabIndex = 16;
            this.textBoxMiNumber.TextChanged += new System.EventHandler(this.textBoxMiNumber_TextChanged);
            // 
            // labelMiNumber
            // 
            this.labelMiNumber.AutoSize = true;
            this.labelMiNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiNumber.Location = new System.Drawing.Point(16, 210);
            this.labelMiNumber.Name = "labelMiNumber";
            this.labelMiNumber.Size = new System.Drawing.Size(173, 16);
            this.labelMiNumber.TabIndex = 15;
            this.labelMiNumber.Text = "Зав. № / цифр-бук. обозн.";
            // 
            // checkBoxMiModification
            // 
            this.checkBoxMiModification.AutoSize = true;
            this.checkBoxMiModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMiModification.Location = new System.Drawing.Point(474, 183);
            this.checkBoxMiModification.Name = "checkBoxMiModification";
            this.checkBoxMiModification.Size = new System.Drawing.Size(67, 20);
            this.checkBoxMiModification.TabIndex = 14;
            this.checkBoxMiModification.Text = "Точно";
            this.checkBoxMiModification.UseVisualStyleBackColor = true;
            this.checkBoxMiModification.CheckedChanged += new System.EventHandler(this.checkBoxMiModification_CheckedChanged);
            // 
            // textBoxMiModification
            // 
            this.textBoxMiModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiModification.Location = new System.Drawing.Point(233, 179);
            this.textBoxMiModification.Name = "textBoxMiModification";
            this.textBoxMiModification.Size = new System.Drawing.Size(235, 22);
            this.textBoxMiModification.TabIndex = 13;
            this.textBoxMiModification.TextChanged += new System.EventHandler(this.textBoxMiModification_TextChanged);
            // 
            // labelMiModification
            // 
            this.labelMiModification.AutoSize = true;
            this.labelMiModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiModification.Location = new System.Drawing.Point(16, 182);
            this.labelMiModification.Name = "labelMiModification";
            this.labelMiModification.Size = new System.Drawing.Size(121, 16);
            this.labelMiModification.TabIndex = 12;
            this.labelMiModification.Text = "Модификация СИ";
            // 
            // checkBoxMitNotation
            // 
            this.checkBoxMitNotation.AutoSize = true;
            this.checkBoxMitNotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMitNotation.Location = new System.Drawing.Point(474, 155);
            this.checkBoxMitNotation.Name = "checkBoxMitNotation";
            this.checkBoxMitNotation.Size = new System.Drawing.Size(67, 20);
            this.checkBoxMitNotation.TabIndex = 11;
            this.checkBoxMitNotation.Text = "Точно";
            this.checkBoxMitNotation.UseVisualStyleBackColor = true;
            this.checkBoxMitNotation.CheckedChanged += new System.EventHandler(this.checkBoxMitNotation_CheckedChanged);
            // 
            // textBoxMitNotation
            // 
            this.textBoxMitNotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMitNotation.Location = new System.Drawing.Point(233, 151);
            this.textBoxMitNotation.Name = "textBoxMitNotation";
            this.textBoxMitNotation.Size = new System.Drawing.Size(235, 22);
            this.textBoxMitNotation.TabIndex = 10;
            this.textBoxMitNotation.TextChanged += new System.EventHandler(this.textBoxMitNotation_TextChanged);
            // 
            // labelMitNotation
            // 
            this.labelMitNotation.AutoSize = true;
            this.labelMitNotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMitNotation.Location = new System.Drawing.Point(16, 154);
            this.labelMitNotation.Name = "labelMitNotation";
            this.labelMitNotation.Size = new System.Drawing.Size(54, 16);
            this.labelMitNotation.TabIndex = 9;
            this.labelMitNotation.Text = "Тип СИ";
            // 
            // checkBoxMitTitle
            // 
            this.checkBoxMitTitle.AutoSize = true;
            this.checkBoxMitTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMitTitle.Location = new System.Drawing.Point(474, 127);
            this.checkBoxMitTitle.Name = "checkBoxMitTitle";
            this.checkBoxMitTitle.Size = new System.Drawing.Size(67, 20);
            this.checkBoxMitTitle.TabIndex = 8;
            this.checkBoxMitTitle.Text = "Точно";
            this.checkBoxMitTitle.UseVisualStyleBackColor = true;
            this.checkBoxMitTitle.CheckedChanged += new System.EventHandler(this.checkBoxMitTitle_CheckedChanged);
            // 
            // textBoxMitTitle
            // 
            this.textBoxMitTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMitTitle.Location = new System.Drawing.Point(233, 123);
            this.textBoxMitTitle.Name = "textBoxMitTitle";
            this.textBoxMitTitle.Size = new System.Drawing.Size(235, 22);
            this.textBoxMitTitle.TabIndex = 7;
            this.textBoxMitTitle.TextChanged += new System.EventHandler(this.textBoxMitTitle_TextChanged);
            // 
            // labelMitTitle
            // 
            this.labelMitTitle.AutoSize = true;
            this.labelMitTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMitTitle.Location = new System.Drawing.Point(16, 126);
            this.labelMitTitle.Name = "labelMitTitle";
            this.labelMitTitle.Size = new System.Drawing.Size(162, 16);
            this.labelMitTitle.TabIndex = 6;
            this.labelMitTitle.Text = "Наименование типа СИ";
            // 
            // checkBoxMitNumber
            // 
            this.checkBoxMitNumber.AutoSize = true;
            this.checkBoxMitNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMitNumber.Location = new System.Drawing.Point(474, 99);
            this.checkBoxMitNumber.Name = "checkBoxMitNumber";
            this.checkBoxMitNumber.Size = new System.Drawing.Size(67, 20);
            this.checkBoxMitNumber.TabIndex = 5;
            this.checkBoxMitNumber.Text = "Точно";
            this.checkBoxMitNumber.UseVisualStyleBackColor = true;
            this.checkBoxMitNumber.CheckedChanged += new System.EventHandler(this.checkBoxMitNumber_CheckedChanged);
            // 
            // textBoxMitNumber
            // 
            this.textBoxMitNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMitNumber.Location = new System.Drawing.Point(233, 95);
            this.textBoxMitNumber.Name = "textBoxMitNumber";
            this.textBoxMitNumber.Size = new System.Drawing.Size(235, 22);
            this.textBoxMitNumber.TabIndex = 4;
            this.textBoxMitNumber.TextChanged += new System.EventHandler(this.textBoxMitNumber_TextChanged);
            // 
            // labelMitNumber
            // 
            this.labelMitNumber.AutoSize = true;
            this.labelMitNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMitNumber.Location = new System.Drawing.Point(16, 98);
            this.labelMitNumber.Name = "labelMitNumber";
            this.labelMitNumber.Size = new System.Drawing.Size(133, 16);
            this.labelMitNumber.TabIndex = 3;
            this.labelMitNumber.Text = "Рег. номер типа СИ";
            // 
            // checkBoxOrgTitle
            // 
            this.checkBoxOrgTitle.AutoSize = true;
            this.checkBoxOrgTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxOrgTitle.Location = new System.Drawing.Point(474, 71);
            this.checkBoxOrgTitle.Name = "checkBoxOrgTitle";
            this.checkBoxOrgTitle.Size = new System.Drawing.Size(67, 20);
            this.checkBoxOrgTitle.TabIndex = 2;
            this.checkBoxOrgTitle.Text = "Точно";
            this.checkBoxOrgTitle.UseVisualStyleBackColor = true;
            this.checkBoxOrgTitle.CheckedChanged += new System.EventHandler(this.checkBoxOrgTitle_CheckedChanged);
            // 
            // textBoxOrgTitle
            // 
            this.textBoxOrgTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOrgTitle.Location = new System.Drawing.Point(233, 67);
            this.textBoxOrgTitle.Name = "textBoxOrgTitle";
            this.textBoxOrgTitle.Size = new System.Drawing.Size(235, 22);
            this.textBoxOrgTitle.TabIndex = 1;
            this.textBoxOrgTitle.TextChanged += new System.EventHandler(this.textBoxOrgTitle_TextChanged);
            // 
            // labelOrgTitle
            // 
            this.labelOrgTitle.AutoSize = true;
            this.labelOrgTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrgTitle.Location = new System.Drawing.Point(16, 70);
            this.labelOrgTitle.Name = "labelOrgTitle";
            this.labelOrgTitle.Size = new System.Drawing.Size(176, 16);
            this.labelOrgTitle.TabIndex = 0;
            this.labelOrgTitle.Text = "Организация-поверитель";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.buttonUnload);
            this.tabPageSettings.Controls.Add(this.textBoxUnload);
            this.tabPageSettings.Controls.Add(this.labelUnload);
            this.tabPageSettings.Controls.Add(this.labelTries);
            this.tabPageSettings.Controls.Add(this.numericUpDownTries);
            this.tabPageSettings.Controls.Add(this.labelRepeat);
            this.tabPageSettings.Controls.Add(this.groupBoxFields);
            this.tabPageSettings.Controls.Add(this.labelItems);
            this.tabPageSettings.Controls.Add(this.labelSort);
            this.tabPageSettings.Controls.Add(this.labelMs);
            this.tabPageSettings.Controls.Add(this.comboBoxSortBy);
            this.tabPageSettings.Controls.Add(this.numericUpDownPause);
            this.tabPageSettings.Controls.Add(this.checkBoxSorted);
            this.tabPageSettings.Controls.Add(this.labelPause);
            this.tabPageSettings.Controls.Add(this.labelRows);
            this.tabPageSettings.Controls.Add(this.numericUpDownRows);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 25);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(558, 410);
            this.tabPageSettings.TabIndex = 0;
            this.tabPageSettings.Text = "Параметры";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // buttonUnload
            // 
            this.buttonUnload.Location = new System.Drawing.Point(462, 360);
            this.buttonUnload.Name = "buttonUnload";
            this.buttonUnload.Size = new System.Drawing.Size(75, 23);
            this.buttonUnload.TabIndex = 27;
            this.buttonUnload.Text = "Обзор...";
            this.buttonUnload.UseVisualStyleBackColor = true;
            this.buttonUnload.Click += new System.EventHandler(this.buttonUnload_Click);
            // 
            // textBoxUnload
            // 
            this.textBoxUnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUnload.Location = new System.Drawing.Point(188, 360);
            this.textBoxUnload.Name = "textBoxUnload";
            this.textBoxUnload.ReadOnly = true;
            this.textBoxUnload.Size = new System.Drawing.Size(268, 22);
            this.textBoxUnload.TabIndex = 26;
            this.textBoxUnload.TextChanged += new System.EventHandler(this.textBoxUnload_TextChanged);
            // 
            // labelUnload
            // 
            this.labelUnload.AutoSize = true;
            this.labelUnload.Location = new System.Drawing.Point(24, 363);
            this.labelUnload.Name = "labelUnload";
            this.labelUnload.Size = new System.Drawing.Size(150, 16);
            this.labelUnload.TabIndex = 25;
            this.labelUnload.Text = "Директория выгрузки";
            // 
            // labelTries
            // 
            this.labelTries.AutoSize = true;
            this.labelTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTries.Location = new System.Drawing.Point(221, 111);
            this.labelTries.Name = "labelTries";
            this.labelTries.Size = new System.Drawing.Size(125, 16);
            this.labelTries.TabIndex = 24;
            this.labelTries.Text = "раз(а) при ошибке";
            // 
            // numericUpDownTries
            // 
            this.numericUpDownTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownTries.Location = new System.Drawing.Point(157, 109);
            this.numericUpDownTries.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTries.Name = "numericUpDownTries";
            this.numericUpDownTries.Size = new System.Drawing.Size(59, 22);
            this.numericUpDownTries.TabIndex = 23;
            this.numericUpDownTries.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTries.ValueChanged += new System.EventHandler(this.numericUpDownTries_ValueChanged);
            // 
            // labelRepeat
            // 
            this.labelRepeat.AutoSize = true;
            this.labelRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRepeat.Location = new System.Drawing.Point(23, 111);
            this.labelRepeat.Name = "labelRepeat";
            this.labelRepeat.Size = new System.Drawing.Size(127, 16);
            this.labelRepeat.TabIndex = 22;
            this.labelRepeat.Text = "Повторять запрос";
            // 
            // groupBoxFields
            // 
            this.groupBoxFields.Controls.Add(this.checkBoxField11);
            this.groupBoxFields.Controls.Add(this.checkBoxField10);
            this.groupBoxFields.Controls.Add(this.checkBoxField9);
            this.groupBoxFields.Controls.Add(this.checkBoxField8);
            this.groupBoxFields.Controls.Add(this.checkBoxField7);
            this.groupBoxFields.Controls.Add(this.checkBoxField6);
            this.groupBoxFields.Controls.Add(this.checkBoxField5);
            this.groupBoxFields.Controls.Add(this.checkBoxField4);
            this.groupBoxFields.Controls.Add(this.checkBoxField3);
            this.groupBoxFields.Controls.Add(this.checkBoxField2);
            this.groupBoxFields.Controls.Add(this.checkBoxField1);
            this.groupBoxFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFields.Location = new System.Drawing.Point(24, 152);
            this.groupBoxFields.Name = "groupBoxFields";
            this.groupBoxFields.Size = new System.Drawing.Size(512, 182);
            this.groupBoxFields.TabIndex = 21;
            this.groupBoxFields.TabStop = false;
            this.groupBoxFields.Text = "Выгружаемые поля";
            // 
            // checkBoxField11
            // 
            this.checkBoxField11.AutoSize = true;
            this.checkBoxField11.Checked = true;
            this.checkBoxField11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxField11.Location = new System.Drawing.Point(16, 134);
            this.checkBoxField11.Name = "checkBoxField11";
            this.checkBoxField11.Size = new System.Drawing.Size(111, 20);
            this.checkBoxField11.TabIndex = 10;
            this.checkBoxField11.Text = "Пригодность";
            this.checkBoxField11.UseVisualStyleBackColor = true;
            this.checkBoxField11.CheckedChanged += new System.EventHandler(this.checkBoxField11_CheckedChanged);
            // 
            // checkBoxField10
            // 
            this.checkBoxField10.AutoSize = true;
            this.checkBoxField10.Checked = true;
            this.checkBoxField10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxField10.Location = new System.Drawing.Point(277, 115);
            this.checkBoxField10.Name = "checkBoxField10";
            this.checkBoxField10.Size = new System.Drawing.Size(228, 20);
            this.checkBoxField10.TabIndex = 9;
            this.checkBoxField10.Text = "Номер свидет./извещ./выписки";
            this.checkBoxField10.UseVisualStyleBackColor = true;
            this.checkBoxField10.CheckedChanged += new System.EventHandler(this.checkBoxField10_CheckedChanged);
            // 
            // checkBoxField9
            // 
            this.checkBoxField9.AutoSize = true;
            this.checkBoxField9.Checked = true;
            this.checkBoxField9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxField9.Location = new System.Drawing.Point(16, 115);
            this.checkBoxField9.Name = "checkBoxField9";
            this.checkBoxField9.Size = new System.Drawing.Size(146, 20);
            this.checkBoxField9.TabIndex = 8;
            this.checkBoxField9.Text = "Действительна до";
            this.checkBoxField9.UseVisualStyleBackColor = true;
            this.checkBoxField9.CheckedChanged += new System.EventHandler(this.checkBoxField9_CheckedChanged);
            // 
            // checkBoxField8
            // 
            this.checkBoxField8.AutoSize = true;
            this.checkBoxField8.Checked = true;
            this.checkBoxField8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxField8.Location = new System.Drawing.Point(277, 96);
            this.checkBoxField8.Name = "checkBoxField8";
            this.checkBoxField8.Size = new System.Drawing.Size(116, 20);
            this.checkBoxField8.TabIndex = 7;
            this.checkBoxField8.Text = "Дата поверки";
            this.checkBoxField8.UseVisualStyleBackColor = true;
            this.checkBoxField8.CheckedChanged += new System.EventHandler(this.checkBoxField8_CheckedChanged);
            // 
            // checkBoxField7
            // 
            this.checkBoxField7.AutoSize = true;
            this.checkBoxField7.Checked = true;
            this.checkBoxField7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxField7.Location = new System.Drawing.Point(16, 96);
            this.checkBoxField7.Name = "checkBoxField7";
            this.checkBoxField7.Size = new System.Drawing.Size(254, 20);
            this.checkBoxField7.TabIndex = 6;
            this.checkBoxField7.Text = "Зав./сер. номер/бук.-циф. обознач.";
            this.checkBoxField7.UseVisualStyleBackColor = true;
            this.checkBoxField7.CheckedChanged += new System.EventHandler(this.checkBoxField7_CheckedChanged);
            // 
            // checkBoxField6
            // 
            this.checkBoxField6.AutoSize = true;
            this.checkBoxField6.Checked = true;
            this.checkBoxField6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxField6.Location = new System.Drawing.Point(277, 77);
            this.checkBoxField6.Name = "checkBoxField6";
            this.checkBoxField6.Size = new System.Drawing.Size(140, 20);
            this.checkBoxField6.TabIndex = 5;
            this.checkBoxField6.Text = "Модификация СИ";
            this.checkBoxField6.UseVisualStyleBackColor = true;
            this.checkBoxField6.CheckedChanged += new System.EventHandler(this.checkBoxField6_CheckedChanged);
            // 
            // checkBoxField5
            // 
            this.checkBoxField5.AutoSize = true;
            this.checkBoxField5.Checked = true;
            this.checkBoxField5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxField5.Location = new System.Drawing.Point(16, 77);
            this.checkBoxField5.Name = "checkBoxField5";
            this.checkBoxField5.Size = new System.Drawing.Size(172, 20);
            this.checkBoxField5.TabIndex = 4;
            this.checkBoxField5.Text = "Обозначение типа СИ";
            this.checkBoxField5.UseVisualStyleBackColor = true;
            this.checkBoxField5.CheckedChanged += new System.EventHandler(this.checkBoxField5_CheckedChanged);
            // 
            // checkBoxField4
            // 
            this.checkBoxField4.AutoSize = true;
            this.checkBoxField4.Checked = true;
            this.checkBoxField4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxField4.Location = new System.Drawing.Point(277, 58);
            this.checkBoxField4.Name = "checkBoxField4";
            this.checkBoxField4.Size = new System.Drawing.Size(181, 20);
            this.checkBoxField4.TabIndex = 3;
            this.checkBoxField4.Text = "Наименование типа СИ";
            this.checkBoxField4.UseVisualStyleBackColor = true;
            this.checkBoxField4.CheckedChanged += new System.EventHandler(this.checkBoxField4_CheckedChanged);
            // 
            // checkBoxField3
            // 
            this.checkBoxField3.AutoSize = true;
            this.checkBoxField3.Checked = true;
            this.checkBoxField3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxField3.Location = new System.Drawing.Point(16, 58);
            this.checkBoxField3.Name = "checkBoxField3";
            this.checkBoxField3.Size = new System.Drawing.Size(152, 20);
            this.checkBoxField3.TabIndex = 2;
            this.checkBoxField3.Text = "Рег. номер типа СИ";
            this.checkBoxField3.UseVisualStyleBackColor = true;
            this.checkBoxField3.CheckedChanged += new System.EventHandler(this.checkBoxField3_CheckedChanged);
            // 
            // checkBoxField2
            // 
            this.checkBoxField2.AutoSize = true;
            this.checkBoxField2.Checked = true;
            this.checkBoxField2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxField2.Location = new System.Drawing.Point(277, 39);
            this.checkBoxField2.Name = "checkBoxField2";
            this.checkBoxField2.Size = new System.Drawing.Size(206, 20);
            this.checkBoxField2.TabIndex = 1;
            this.checkBoxField2.Text = "Наименование поверителя";
            this.checkBoxField2.UseVisualStyleBackColor = true;
            this.checkBoxField2.CheckedChanged += new System.EventHandler(this.checkBoxField2_CheckedChanged);
            // 
            // checkBoxField1
            // 
            this.checkBoxField1.AutoSize = true;
            this.checkBoxField1.Checked = true;
            this.checkBoxField1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxField1.Location = new System.Drawing.Point(16, 39);
            this.checkBoxField1.Name = "checkBoxField1";
            this.checkBoxField1.Size = new System.Drawing.Size(206, 20);
            this.checkBoxField1.TabIndex = 0;
            this.checkBoxField1.Text = "Идентиф. версии элемента";
            this.checkBoxField1.UseVisualStyleBackColor = true;
            this.checkBoxField1.CheckedChanged += new System.EventHandler(this.checkBoxField1_CheckedChanged);
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItems.Location = new System.Drawing.Point(219, 79);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(62, 16);
            this.labelItems.TabIndex = 14;
            this.labelItems.Text = "записей";
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSort.Location = new System.Drawing.Point(23, 26);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(86, 16);
            this.labelSort.TabIndex = 9;
            this.labelSort.Text = "Сортировка";
            // 
            // labelMs
            // 
            this.labelMs.AutoSize = true;
            this.labelMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMs.Location = new System.Drawing.Point(481, 79);
            this.labelMs.Name = "labelMs";
            this.labelMs.Size = new System.Drawing.Size(23, 16);
            this.labelMs.TabIndex = 17;
            this.labelMs.Text = "мс";
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "Идентиф. версии элемента",
            "Наименование поверителя",
            "Рег. номер типа СИ",
            "Наименование типа СИ",
            "Обозначение типа СИ",
            "Модификация СИ",
            "Зав./сер. номер/бук.-циф. обознач.",
            "Дата поверки",
            "Действительна до",
            "Номер свидет./извещ./выписки",
            "Пригодность"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(157, 19);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(379, 24);
            this.comboBoxSortBy.TabIndex = 10;
            this.comboBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortBy_SelectedIndexChanged);
            // 
            // numericUpDownPause
            // 
            this.numericUpDownPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPause.Location = new System.Drawing.Point(419, 77);
            this.numericUpDownPause.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownPause.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownPause.Name = "numericUpDownPause";
            this.numericUpDownPause.Size = new System.Drawing.Size(59, 22);
            this.numericUpDownPause.TabIndex = 16;
            this.numericUpDownPause.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownPause.ValueChanged += new System.EventHandler(this.numericUpDownPause_ValueChanged);
            // 
            // checkBoxSorted
            // 
            this.checkBoxSorted.AutoSize = true;
            this.checkBoxSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSorted.Location = new System.Drawing.Point(157, 49);
            this.checkBoxSorted.Name = "checkBoxSorted";
            this.checkBoxSorted.Size = new System.Drawing.Size(159, 20);
            this.checkBoxSorted.TabIndex = 11;
            this.checkBoxSorted.Text = "В обратном порядке";
            this.checkBoxSorted.UseVisualStyleBackColor = true;
            this.checkBoxSorted.CheckedChanged += new System.EventHandler(this.checkBoxSorted_CheckedChanged);
            // 
            // labelPause
            // 
            this.labelPause.AutoSize = true;
            this.labelPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPause.Location = new System.Drawing.Point(301, 79);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(107, 16);
            this.labelPause.TabIndex = 15;
            this.labelPause.Text = "Пауза запроса";
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRows.Location = new System.Drawing.Point(23, 79);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(111, 16);
            this.labelRows.TabIndex = 12;
            this.labelRows.Text = "Кол-во в ответе";
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownRows.Location = new System.Drawing.Point(157, 77);
            this.numericUpDownRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(59, 22);
            this.numericUpDownRows.TabIndex = 13;
            this.numericUpDownRows.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownRows.ValueChanged += new System.EventHandler(this.numericUpDownRows_ValueChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(199, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(192, 19);
            this.labelTitle.TabIndex = 27;
            this.labelTitle.Text = "Клиент ФГИС \"Аршин\"";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(12, 492);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(566, 39);
            this.buttonStart.TabIndex = 28;
            this.buttonStart.Text = "Запустить";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // progressBarProcess
            // 
            this.progressBarProcess.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.progressBarProcess.Location = new System.Drawing.Point(12, 537);
            this.progressBarProcess.MarqueeAnimationSpeed = 0;
            this.progressBarProcess.Name = "progressBarProcess";
            this.progressBarProcess.Size = new System.Drawing.Size(566, 23);
            this.progressBarProcess.TabIndex = 29;
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(285, 564);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(21, 13);
            this.labelPercent.TabIndex = 30;
            this.labelPercent.Text = "0%";
            this.labelPercent.Visible = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 588);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBarProcess);
            this.Controls.Add(this.labelPercent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент ФГИС \"Аршин\"";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFilter.ResumeLayout(false);
            this.tabPageFilter.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTries)).EndInit();
            this.groupBoxFields.ResumeLayout(false);
            this.groupBoxFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFilter;
        private System.Windows.Forms.ComboBox comboBoxApplicability;
        private System.Windows.Forms.Label labelApplicability;
        private System.Windows.Forms.CheckBox checkBoxSticker;
        private System.Windows.Forms.TextBox textBoxSticker;
        private System.Windows.Forms.Label labelSticker;
        private System.Windows.Forms.CheckBox checkBoxDocnum;
        private System.Windows.Forms.TextBox textBoxDocnum;
        private System.Windows.Forms.Label labelDocnum;
        private System.Windows.Forms.Label labelValid;
        private System.Windows.Forms.DateTimePicker dateTimePickerValidStart;
        private System.Windows.Forms.Label labelValidTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerValidEnd;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.DateTimePicker dateTimePickerYear;
        private System.Windows.Forms.Label labelVerification;
        private System.Windows.Forms.DateTimePicker dateTimePickerVerificationStart;
        private System.Windows.Forms.Label labelVerificationTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerVerificationEnd;
        private System.Windows.Forms.CheckBox checkBoxMiNumber;
        private System.Windows.Forms.TextBox textBoxMiNumber;
        private System.Windows.Forms.Label labelMiNumber;
        private System.Windows.Forms.CheckBox checkBoxMiModification;
        private System.Windows.Forms.TextBox textBoxMiModification;
        private System.Windows.Forms.Label labelMiModification;
        private System.Windows.Forms.CheckBox checkBoxMitNotation;
        private System.Windows.Forms.TextBox textBoxMitNotation;
        private System.Windows.Forms.Label labelMitNotation;
        private System.Windows.Forms.CheckBox checkBoxMitTitle;
        private System.Windows.Forms.TextBox textBoxMitTitle;
        private System.Windows.Forms.Label labelMitTitle;
        private System.Windows.Forms.CheckBox checkBoxMitNumber;
        private System.Windows.Forms.TextBox textBoxMitNumber;
        private System.Windows.Forms.Label labelMitNumber;
        private System.Windows.Forms.CheckBox checkBoxOrgTitle;
        private System.Windows.Forms.TextBox textBoxOrgTitle;
        private System.Windows.Forms.Label labelOrgTitle;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Button buttonUnload;
        private System.Windows.Forms.TextBox textBoxUnload;
        private System.Windows.Forms.Label labelUnload;
        private System.Windows.Forms.Label labelTries;
        private System.Windows.Forms.NumericUpDown numericUpDownTries;
        private System.Windows.Forms.Label labelRepeat;
        private System.Windows.Forms.GroupBox groupBoxFields;
        private System.Windows.Forms.CheckBox checkBoxField11;
        private System.Windows.Forms.CheckBox checkBoxField10;
        private System.Windows.Forms.CheckBox checkBoxField9;
        private System.Windows.Forms.CheckBox checkBoxField8;
        private System.Windows.Forms.CheckBox checkBoxField7;
        private System.Windows.Forms.CheckBox checkBoxField6;
        private System.Windows.Forms.CheckBox checkBoxField5;
        private System.Windows.Forms.CheckBox checkBoxField4;
        private System.Windows.Forms.CheckBox checkBoxField3;
        private System.Windows.Forms.CheckBox checkBoxField2;
        private System.Windows.Forms.CheckBox checkBoxField1;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.Label labelMs;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.NumericUpDown numericUpDownPause;
        private System.Windows.Forms.CheckBox checkBoxSorted;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ProgressBar progressBarProcess;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

