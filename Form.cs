using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using System.Net;

namespace FGIS_Arshin
{
    public partial class Form : System.Windows.Forms.Form
    {
        int start, pass = 0;
        string xslxFilePath = "";

        public Form()
        {
            InitializeComponent();
            notifyIcon.Text = Text;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            notifyIcon.Visible = true;

            dateTimePickerYear.Value = Properties.Settings.Default.year != "" ? DateTime.Parse(Properties.Settings.Default.year) : DateTime.Today;
            dateTimePickerYear.MaxDate = DateTime.Today;
            dateTimePickerYear.Checked = false;

            textBoxOrgTitle.Text = Properties.Settings.Default.orgtitle_val != "" ? Properties.Settings.Default.orgtitle_val : "";
            checkBoxOrgTitle.Checked = Properties.Settings.Default.orgtitle_on ? true : false;

            textBoxMitNumber.Text = Properties.Settings.Default.mitnumber_val != "" ? Properties.Settings.Default.mitnumber_val : "";
            checkBoxMitNumber.Checked = Properties.Settings.Default.mitnumber_on ? true : false;

            textBoxMitTitle.Text = Properties.Settings.Default.mittitle_val != "" ? Properties.Settings.Default.mittitle_val : "";
            checkBoxMitTitle.Checked = Properties.Settings.Default.mittitle_on ? true : false;

            textBoxMitNotation.Text = Properties.Settings.Default.mitnotation_val != "" ? Properties.Settings.Default.mitnotation_val : "";
            checkBoxMitNotation.Checked = Properties.Settings.Default.mitnotation_on ? true : false;

            textBoxMiModification.Text = Properties.Settings.Default.mimodification_val != "" ? Properties.Settings.Default.mimodification_val : "";
            checkBoxMiModification.Checked = Properties.Settings.Default.mimodification_on ? true : false;

            textBoxMiNumber.Text = Properties.Settings.Default.minumber_val != "" ? Properties.Settings.Default.minumber_val : "";
            checkBoxMiNumber.Checked = Properties.Settings.Default.minumber_on ? true : false;

            dateTimePickerVerificationStart.Value = Properties.Settings.Default.verificationstart != "" ? DateTime.Parse(Properties.Settings.Default.verificationstart) : DateTime.Today.AddDays(-1);
            dateTimePickerVerificationStart.MaxDate = DateTime.Today;
            dateTimePickerVerificationStart.Checked = false;

            dateTimePickerVerificationEnd.Value = Properties.Settings.Default.verificationend != "" ? DateTime.Parse(Properties.Settings.Default.verificationend) : DateTime.Today;
            dateTimePickerVerificationEnd.MaxDate = DateTime.Today;
            dateTimePickerVerificationEnd.Checked = false;

            dateTimePickerValidStart.Value = Properties.Settings.Default.validstart != "" ? DateTime.Parse(Properties.Settings.Default.validstart) : DateTime.Today.AddDays(-1);
            dateTimePickerValidStart.MaxDate = DateTime.Today;
            dateTimePickerValidStart.Checked = false;

            dateTimePickerValidEnd.Value = Properties.Settings.Default.validend != "" ? DateTime.Parse(Properties.Settings.Default.validend) : DateTime.Today;
            dateTimePickerValidEnd.MaxDate = DateTime.Today;
            dateTimePickerValidEnd.Checked = false;

            textBoxDocnum.Text = Properties.Settings.Default.docnum_val != "" ? Properties.Settings.Default.docnum_val : "";
            checkBoxDocnum.Checked = Properties.Settings.Default.docnum_on ? true : false;

            textBoxSticker.Text = Properties.Settings.Default.sticker_val != "" ? Properties.Settings.Default.sticker_val : "";
            checkBoxSticker.Checked = Properties.Settings.Default.sticker_on ? true : false;

            comboBoxApplicability.SelectedIndex = Properties.Settings.Default.applicability != 2 ? Properties.Settings.Default.applicability : 2;

            comboBoxSortBy.SelectedIndex = Properties.Settings.Default.sortby != 0 ? Properties.Settings.Default.sortby : 0;
            checkBoxSorted.Checked = Properties.Settings.Default.sorted ? true : false;

            numericUpDownRows.Value = Properties.Settings.Default.rows != numericUpDownRows.Maximum ? Properties.Settings.Default.rows : numericUpDownRows.Maximum;

            numericUpDownPause.Value = Properties.Settings.Default.pause != 500 ? Properties.Settings.Default.pause : 500;

            numericUpDownTries.Value = Properties.Settings.Default.tries != 10 ? Properties.Settings.Default.tries : 10;

            checkBoxField1.Checked = Properties.Settings.Default.field1 ? true : false;
            checkBoxField2.Checked = Properties.Settings.Default.field2 ? true : false;
            checkBoxField3.Checked = Properties.Settings.Default.field3 ? true : false;
            checkBoxField4.Checked = Properties.Settings.Default.field4 ? true : false;
            checkBoxField5.Checked = Properties.Settings.Default.field5 ? true : false;
            checkBoxField6.Checked = Properties.Settings.Default.field6 ? true : false;
            checkBoxField7.Checked = Properties.Settings.Default.field7 ? true : false;
            checkBoxField8.Checked = Properties.Settings.Default.field8 ? true : false;
            checkBoxField9.Checked = Properties.Settings.Default.field9 ? true : false;
            checkBoxField10.Checked = Properties.Settings.Default.field10 ? true : false;
            checkBoxField11.Checked = Properties.Settings.Default.field11 ? true : false;

            textBoxUnload.Text = Properties.Settings.Default.unload != "" && Directory.Exists(Properties.Settings.Default.unload) ? Properties.Settings.Default.unload : Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            checkValidate();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;

            var request = postRequest();
            Thread.Sleep((int)numericUpDownPause.Value);

            if (request != null)
            {
                var obj = JToken.Parse(request);
                int count = (int)obj["result"]["count"];

                if (count > 99999 + (int)numericUpDownRows.Maximum)
                {
                    DialogResult dialogResult = MessageBox.Show(
                        "В выгрузке слишком много записей. Выгрузить максимально возможное кол-во записей?",
                        Text,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        count = 99999 + (int)numericUpDownRows.Maximum;
                    }
                    else
                    {
                        start = progressBarProcess.Value = 0;
                        labelPercent.Visible = false;
                        buttonStart.Enabled = true;

                        return;
                    }
                }

                int iterations = count / (int)numericUpDownRows.Value;
                if (count % (int)numericUpDownRows.Value != 0) iterations++;

                labelPercent.Visible = true;

                int totalIteration = 0;
                int fileCount = Directory.GetFiles(textBoxUnload.Text, "*_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx").Length + 1;
                xslxFilePath = textBoxUnload.Text + "\\" + fileCount + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";

                DataTable dataTable = new DataTable();

                for (int i = 1; i <= 11; i++)
                {
                    CheckBox checkBox = (CheckBox)this.Controls.Find("checkBoxField" + i, true)[0];
                    if (checkBox != null && checkBox.Checked)
                    {
                        dataTable.Columns.Add(checkBox.Text, typeof(string));
                    }

                }

                for (int i = 0; i < iterations; i++)
                {
                    request = postRequest();
                    Thread.Sleep((int)numericUpDownPause.Value);

                    if (request != null)
                    {
                        obj = JToken.Parse(request);
                        var items = obj["result"]["items"];

                        foreach (var item in items)
                        {
                            if (pass != 0)
                            {
                                pass--;
                                continue;
                            }

                            string[] result = {
                                item["vri_id"] != null && checkBoxField1.Checked ? item["vri_id"].ToString() : null,
                                item["org_title"] != null && checkBoxField2.Checked ? item["org_title"].ToString() : null,
                                item["mit_number"] != null && checkBoxField3.Checked ? item["mit_number"].ToString() : null,
                                item["mit_title"] != null && checkBoxField4.Checked ? item["mit_title"].ToString() : null,
                                item["mit_notation"] != null && checkBoxField5.Checked ? item["mit_notation"].ToString() : null,
                                item["mi_modification"] != null && checkBoxField6.Checked ? item["mi_modification"].ToString() : null,
                                item["mi_number"] != null && checkBoxField7.Checked ? item["mi_number"].ToString() : null,
                                item["verification_date"] != null && checkBoxField8.Checked ? item["verification_date"].ToString() : null,
                                item["valid_date"] != null && checkBoxField9.Checked ? item["valid_date"].ToString() : null,
                                item["result_docnum"] != null && checkBoxField10.Checked ? item["result_docnum"].ToString() : null,
                                item["applicability"] != null && checkBoxField11.Checked ? (item["applicability"].ToString()) == "True" ? "Да" : "Нет" : null
                            };

                            AddRow(dataTable, result);

                            progressBarProcess.Value = (int)Math.Round((double)totalIteration / count * 100);
                            labelPercent.Text = progressBarProcess.Value.ToString() + "%";
                            Application.DoEvents();
                            totalIteration++;
                        }
                    }
                    else
                    {
                        break;
                    }

                    if (start + (int)numericUpDownRows.Value <= 99999)
                    {
                        start = start + (int)numericUpDownRows.Value;
                    }
                    else
                    {
                        pass = (start + (int)numericUpDownRows.Value) - 99999;
                        start = 99999;
                    }
                }

                WriteToExcel(xslxFilePath, dataTable);

                string msg = "Обаботано и выгружено " + totalIteration + " записей в файл " + xslxFilePath;
                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon.BalloonTipText = msg;
                notifyIcon.BalloonTipTitle = Text;
                notifyIcon.ShowBalloonTip(3);

                start = pass = progressBarProcess.Value = 0;
                labelPercent.Visible = false;
            }

            buttonStart.Enabled = true;
        }

        static void AddRow(DataTable dataTable, params object[] values)
        {
            dataTable.Rows.Add(values);
        }

        static void WriteToExcel(string filePath, DataTable dataTable)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");
                var dataRange = worksheet.Cells.LoadFromDataTable(dataTable, true);
                var headerRange = worksheet.Cells[dataRange.Start.Row, dataRange.Start.Column, dataRange.Start.Row, dataRange.End.Column];
                headerRange.Style.Font.Bold = true;
                headerRange.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                headerRange.Style.Fill.BackgroundColor.SetColor(Color.LightGray);

                var allCellsRange = worksheet.Cells[dataRange.Start.Row, dataRange.Start.Column, dataRange.End.Row, dataRange.End.Column];
                allCellsRange.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                allCellsRange.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                allCellsRange.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                allCellsRange.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                worksheet.View.FreezePanes(2, 1);
                worksheet.Cells.AutoFitColumns();

                package.SaveAs(new FileInfo(filePath));
            }
        }

        public string postRequest()
        {
            string search =
                (dateTimePickerYear.Checked ? "year=" + dateTimePickerYear.Value.ToString("yyyy") + "&" : "") +
                (textBoxOrgTitle.Text.Length > 0 ? "org_title=" + Uri.EscapeDataString(SearchConstruct(textBoxOrgTitle.Text, checkBoxOrgTitle.Checked)) + "&" : "") +
                (textBoxMitNumber.Text.Length > 0 ? "mit_number=" + SearchConstruct(textBoxMitNumber.Text, checkBoxMitNumber.Checked) + "&" : "") +
                (textBoxMitTitle.Text.Length > 0 ? "mit_title=" + SearchConstruct(textBoxMitTitle.Text, checkBoxMitTitle.Checked) + "&" : "") +
                (textBoxMitNotation.Text.Length > 0 ? "mit_notation=" + SearchConstruct(textBoxMitNotation.Text, checkBoxMitNotation.Checked) + "&" : "") +
                (textBoxMiModification.Text.Length > 0 ? "mi_modification=" + SearchConstruct(textBoxMiModification.Text, checkBoxMiModification.Checked) + "&" : "") +
                (textBoxMiNumber.Text.Length > 0 ? "mi_number=" + SearchConstruct(textBoxMiNumber.Text, checkBoxMiNumber.Checked) + "&" : "") +
                (dateTimePickerVerificationStart.Checked ? "verification_date_start=" + dateTimePickerVerificationStart.Value.ToString("yyyy-MM-dd") + "&" : "") +
                (dateTimePickerVerificationEnd.Checked ? "verification_date_end=" + dateTimePickerVerificationEnd.Value.ToString("yyyy-MM-dd") + "&" : "") +
                (dateTimePickerValidStart.Checked ? "valid_date_start=" + dateTimePickerValidStart.Value.ToString("yyyy-MM-dd") + "&" : "") +
                (dateTimePickerValidEnd.Checked ? "valid_date_end=" + dateTimePickerValidEnd.Value.ToString("yyyy-MM-dd") + "&" : "") +
                (textBoxDocnum.Text.Length > 0 ? "result_docnum=" + SearchConstruct(textBoxDocnum.Text, checkBoxDocnum.Checked) + "&" : "") +
                (textBoxSticker.Text.Length > 0 ? "sticker_num=" + SearchConstruct(textBoxSticker.Text, checkBoxSticker.Checked) + "&" : "") +
                (comboBoxApplicability.SelectedIndex == 0 | comboBoxApplicability.SelectedIndex == 1 ? "applicability=" + Convert.ToBoolean(comboBoxApplicability.SelectedIndex) + "&" : "");

            string[] attr = { "vri_id", "org_title", "mit_number", "mit_title", "mit_notation", "mi_modification", "mi_number", "verification_date", "valid_date", "result_docnum", "applicability" };
            string sort = attr[comboBoxSortBy.SelectedIndex] += !checkBoxSorted.Checked ? "+asc" : "+desc";

            string host = "https://fgis.gost.ru/fundmetrology/eapi/vri";
            string parameters = search + "start=" + start + "&" + "rows=" + (int)numericUpDownRows.Value + "&" + "sort=" + sort;
            string requestUri = $"{host}?{parameters}";


            int tries = (int)numericUpDownTries.Value;
            string err_msg = "";
            while (tries-- != 0)
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        IWebProxy defaultProxy = WebRequest.GetSystemWebProxy();
                        defaultProxy.Credentials = CredentialCache.DefaultCredentials;
                        client.Proxy = defaultProxy;
                        client.Encoding = Encoding.UTF8;
                        string result = client.DownloadString(requestUri);

                        if (IsValidJson(result))
                        {
                            var obj = JToken.Parse(result);
                            if (obj["result"]["count"] != null && obj["result"]["items"] != null)
                            {
                                return result;
                            }
                            else if (obj["status"] != null && obj["message"] != null)
                            {
                                MessageBox.Show(obj["message"].ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }
                            else
                            {
                                MessageBox.Show("Неизвестная ошибка в ответе.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Не удается разобрать JSON-ответ.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при получении данных: " + ex.Message);
                }
            }
            MessageBox.Show(err_msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        public static bool IsNullOrWhiteSpace(string value)
        {
            if (value == null)
            {
                return true;
            }

            foreach (char c in value)
            {
                if (!char.IsWhiteSpace(c))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsValidJson(string strInput)
        {
            if (IsNullOrWhiteSpace(strInput)) { return false; }
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) ||
                (strInput.StartsWith("[") && strInput.EndsWith("]")))
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    return false;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        static string SearchConstruct(string field, bool exact)
        {
            return !exact ? "*" + field.Replace(" ", "?") + "*" : field.Replace(" ", "?");
        }

        private void checkValidate()
        {
            if (dateTimePickerYear.Value < dateTimePickerYear.MinDate | dateTimePickerYear.Value > dateTimePickerYear.MaxDate |
                dateTimePickerVerificationStart.Value < dateTimePickerVerificationStart.MinDate |
                dateTimePickerVerificationStart.Value > dateTimePickerVerificationStart.MaxDate |
                dateTimePickerVerificationEnd.Value < dateTimePickerVerificationEnd.MinDate |
                dateTimePickerVerificationEnd.Value > dateTimePickerVerificationEnd.MaxDate |
                dateTimePickerValidStart.Value < dateTimePickerValidStart.MinDate | dateTimePickerValidStart.Value > dateTimePickerValidStart.MaxDate |
                dateTimePickerValidEnd.Value < dateTimePickerValidEnd.MinDate | dateTimePickerValidEnd.Value > dateTimePickerValidEnd.MaxDate |
                numericUpDownRows.Value < numericUpDownRows.Minimum | numericUpDownRows.Value > numericUpDownRows.Maximum |
                numericUpDownPause.Value < numericUpDownPause.Minimum | numericUpDownPause.Value > numericUpDownPause.Maximum |
                numericUpDownTries.Value < numericUpDownTries.Minimum | numericUpDownTries.Value > numericUpDownTries.Maximum |
                (!checkBoxField1.Checked && !checkBoxField2.Checked && !checkBoxField3.Checked && !checkBoxField4.Checked &&
                !checkBoxField5.Checked && !checkBoxField6.Checked && !checkBoxField7.Checked && !checkBoxField8.Checked &&
                !checkBoxField9.Checked && !checkBoxField10.Checked && !checkBoxField11.Checked))
            {
                buttonStart.Enabled = false;
            }
            else
            {
                buttonStart.Enabled = true;
            }
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            try
            {
                Process.Start(xslxFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла: " + ex.Message);
            }
        }

        private void dateTimePickerYear_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerYear.Value >= dateTimePickerYear.MinDate && dateTimePickerYear.Value <= dateTimePickerYear.MaxDate)
            {
                Properties.Settings.Default.year = dateTimePickerYear.Value.ToString("yyyy-MM-dd");
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Год выгрузки должен быть не ранее " + dateTimePickerYear.MinDate.ToString("yyyy") + "г. и не позднее " + dateTimePickerYear.MaxDate.ToString("yyyy") + "г.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            checkValidate();
        }

        private void textBoxOrgTitle_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.orgtitle_val = textBoxOrgTitle.Text;
            Properties.Settings.Default.Save();
        }

        private void checkBoxOrgTitle_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.orgtitle_on = checkBoxOrgTitle.Checked;
            Properties.Settings.Default.Save();
        }

        private void textBoxMitNumber_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.mitnumber_val = textBoxMitNumber.Text;
            Properties.Settings.Default.Save();
        }

        private void checkBoxMitNumber_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.mitnumber_on = checkBoxMitNumber.Checked;
            Properties.Settings.Default.Save();
        }

        private void textBoxMitTitle_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.mittitle_val = textBoxMitTitle.Text;
            Properties.Settings.Default.Save();
        }

        private void checkBoxMitTitle_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.mittitle_on = checkBoxMitTitle.Checked;
            Properties.Settings.Default.Save();
        }

        private void textBoxMitNotation_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.mitnotation_val = textBoxMitNotation.Text;
            Properties.Settings.Default.Save();
        }

        private void checkBoxMitNotation_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.mitnotation_on = checkBoxMitNotation.Checked;
            Properties.Settings.Default.Save();
        }

        private void textBoxMiModification_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.mimodification_val = textBoxMiModification.Text;
            Properties.Settings.Default.Save();
        }

        private void checkBoxMiModification_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.mimodification_on = checkBoxMiModification.Checked;
            Properties.Settings.Default.Save();
        }

        private void textBoxMiNumber_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.minumber_val = textBoxMiNumber.Text;
            Properties.Settings.Default.Save();
        }

        private void checkBoxMiNumber_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.minumber_on = checkBoxMiNumber.Checked;
            Properties.Settings.Default.Save();
        }

        private void dateTimePickerVerificationStart_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerVerificationStart.Value >= dateTimePickerVerificationStart.MinDate && dateTimePickerVerificationStart.Value <= dateTimePickerVerificationStart.MaxDate)
            {
                Properties.Settings.Default.verificationstart = dateTimePickerVerificationStart.Value.ToString("yyyy-MM-dd");
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Начальная дата поверки должна быть не ранее " + dateTimePickerVerificationStart.MinDate.ToString("yyyy") + "г. и не позднее " + dateTimePickerVerificationStart.MaxDate.ToString("yyyy") + "г.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            checkValidate();
        }

        private void dateTimePickerVerificationEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerVerificationEnd.Value >= dateTimePickerVerificationEnd.MinDate && dateTimePickerVerificationEnd.Value <= dateTimePickerVerificationEnd.MaxDate)
            {
                Properties.Settings.Default.verificationend = dateTimePickerVerificationEnd.Value.ToString("yyyy-MM-dd");
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Конечная дата поверки должна быть не ранее " + dateTimePickerVerificationEnd.MinDate.ToString("yyyy") + "г. и не позднее " + dateTimePickerVerificationEnd.MaxDate.ToString("yyyy") + "г.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            checkValidate();
        }

        private void dateTimePickerValidStart_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerValidStart.Value >= dateTimePickerValidStart.MinDate && dateTimePickerValidStart.Value <= dateTimePickerValidStart.MaxDate)
            {
                Properties.Settings.Default.validstart = dateTimePickerValidStart.Value.ToString("yyyy-MM-dd");
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Начальная дата пригодности должна быть не ранее " + dateTimePickerValidStart.MinDate.ToString("yyyy") + "г. и не позднее " + dateTimePickerValidStart.MaxDate.ToString("yyyy") + "г.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            checkValidate();
        }

        private void dateTimePickerValidEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerValidEnd.Value >= dateTimePickerValidEnd.MinDate && dateTimePickerValidEnd.Value <= dateTimePickerValidEnd.MaxDate)
            {
                Properties.Settings.Default.validend = dateTimePickerValidEnd.Value.ToString("yyyy-MM-dd");
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Конечная дата пригодности должна быть не ранее " + dateTimePickerValidEnd.MinDate.ToString("yyyy") + "г. и не позднее " + dateTimePickerValidEnd.MaxDate.ToString("yyyy") + "г.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            checkValidate();
        }

        private void textBoxDocnum_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.docnum_val = textBoxDocnum.Text;
            Properties.Settings.Default.Save();
        }

        private void checkBoxDocnum_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.docnum_on = checkBoxDocnum.Checked;
            Properties.Settings.Default.Save();
        }

        private void textBoxSticker_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.sticker_val = textBoxSticker.Text;
            Properties.Settings.Default.Save();
        }

        private void checkBoxSticker_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.sticker_on = checkBoxSticker.Checked;
            Properties.Settings.Default.Save();
        }

        private void comboBoxApplicability_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.applicability = comboBoxApplicability.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.sortby = comboBoxSortBy.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void checkBoxSorted_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.sorted = checkBoxSorted.Checked;
            Properties.Settings.Default.Save();
        }

        private void numericUpDownRows_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownRows.Value >= numericUpDownRows.Minimum && numericUpDownRows.Value <= numericUpDownRows.Maximum)
            {
                Properties.Settings.Default.rows = (int)numericUpDownRows.Value;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Кол-во записей в ответе должно быть не менее " + numericUpDownRows.Minimum + "шт. и не более " + numericUpDownRows.Maximum + "шт.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            checkValidate();
        }

        private void numericUpDownPause_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownPause.Value >= numericUpDownPause.Minimum && numericUpDownPause.Value <= numericUpDownPause.Maximum)
            {
                Properties.Settings.Default.pause = (int)numericUpDownPause.Value;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Пауза запроса должна быть не менее " + numericUpDownPause.Minimum + "мс. и не более " + numericUpDownPause.Maximum + "мс.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            checkValidate();
        }

        private void numericUpDownTries_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownTries.Value >= numericUpDownTries.Minimum && numericUpDownTries.Value <= numericUpDownTries.Maximum)
            {
                Properties.Settings.Default.tries = (int)numericUpDownTries.Value;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Кол-во повторных запросов при ошибке должно быть не менее " + numericUpDownTries.Minimum + "шт. и не более " + numericUpDownTries.Maximum + "шт.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            checkValidate();
        }

        private void checkBoxField1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.field1 = checkBoxField1.Checked ? true : false;
            Properties.Settings.Default.Save();

            checkValidate();
        }

        private void checkBoxField2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.field2 = checkBoxField2.Checked ? true : false;
            Properties.Settings.Default.Save();

            checkValidate();
        }

        private void checkBoxField3_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.field3 = checkBoxField3.Checked ? true : false;
            Properties.Settings.Default.Save();

            checkValidate();
        }

        private void checkBoxField4_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.field4 = checkBoxField4.Checked ? true : false;
            Properties.Settings.Default.Save();

            checkValidate();
        }

        private void checkBoxField5_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.field5 = checkBoxField5.Checked ? true : false;
            Properties.Settings.Default.Save();

            checkValidate();
        }

        private void checkBoxField6_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.field6 = checkBoxField6.Checked ? true : false;
            Properties.Settings.Default.Save();

            checkValidate();
        }

        private void checkBoxField7_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.field7 = checkBoxField7.Checked ? true : false;
            Properties.Settings.Default.Save();

            checkValidate();
        }

        private void checkBoxField8_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.field8 = checkBoxField8.Checked ? true : false;
            Properties.Settings.Default.Save();

            checkValidate();
        }

        private void checkBoxField9_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.field9 = checkBoxField9.Checked ? true : false;
            Properties.Settings.Default.Save();

            checkValidate();
        }

        private void checkBoxField10_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.field10 = checkBoxField10.Checked ? true : false;
            Properties.Settings.Default.Save();

            checkValidate();
        }

        private void checkBoxField11_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.field11 = checkBoxField11.Checked ? true : false;
            Properties.Settings.Default.Save();

            checkValidate();
        }

        private void buttonUnload_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DirProject = new FolderBrowserDialog();
            DirProject.Description = "Выберите директорию сохранения выгрузки:";
            if (Directory.Exists(textBoxUnload.Text))
                DirProject.SelectedPath = @"" + textBoxUnload.Text;

            if (DirProject.ShowDialog() == DialogResult.OK)
            {
                textBoxUnload.Text = DirProject.SelectedPath;
            }
        }

        private void textBoxUnload_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.unload = textBoxUnload.Text;
            Properties.Settings.Default.Save();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            if (File.Exists("Help.pdf"))
            {
                Process.Start(@"Help.pdf");
            }
            else
            {
                MessageBox.Show("Файл справки недоступен или поврежден.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
