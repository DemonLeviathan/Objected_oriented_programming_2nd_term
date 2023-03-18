using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lr_02
{
    public partial class Bank : Form
    {
        private Owner owner;
        private Binder binder;


        public Bank()
        {
            InitializeComponent();

            //owner = new Owner();
            writeSurname.Validating += writeSurname_Validating;
            writeName.Validating += writeName_Validating;
            passportNum.Validating += passportNum_Validating;
            writePhoneNum.Validating += writePhoneNum_Validating;
            enterScoreNum.Validating += enterScoreNum_Validating;
            SaveInfo.Click += SaveInfo_Click;
        }

        private void Surname_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void writeSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;
            if (!Char.IsLetter(keyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Surname can't contains symbols instead letters");
            }
        }

        private void writeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;
            if (!Char.IsLetter(keyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Name can't contains symbols instead letters");
            }
        }

        private void writeLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;
            if (!Char.IsLetter(keyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Patronimic can't contains symbols instead letters");
            }

        }

        private void passportNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;
            if (!Char.IsLetterOrDigit(keyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Passport number must be in XX0000000 format");
            }

            string text = passportNum.Text;
            text = text.Replace(" ", "");

            if (text.Length == 0 || text.Length == 1)
            {
                if (!Char.IsLetter(keyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    return;
                }

            }

            else if (text.Length > 1 && text.Length < 7)
            {
                if (!Char.IsDigit(keyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    return;
                }
            }
            else if (text.Length > 8)
            {
                if (keyChar != ' ' && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    return;
                }
            }

        }

        private void writePhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            if (!Regex.IsMatch(keyChar.ToString(), @"[0-9]") && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Phone number must be in XXXXXXXXXXXX format");
            }

            string text = writePhoneNum.Text;

            if (text.Length > 11 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Phone number can't be out range");
            }
        }

        private void enterScoreNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            if (!Char.IsDigit(keyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            string text = enterScoreNum.Text;
            //text = text.Replace(" ", "");

            if (text.Length > 6 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Score number can't be out range");
            }
        }

        private void writeSurname_Validating(object? sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(writeSurname.Text))
            {
                errorData.SetError(writeSurname, "Surname must be inputted");
            }
            else
            {
                errorData.Clear();
            }
        }

        private void writeName_Validating(object? sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(writeName.Text))
            {
                errorData.SetError(writeName, "Name must be inputted");
            }
            else
            {
                errorData.Clear();
            }
        }

        private void passportNum_Validating(object? sender, EventArgs e)
        {
            string text = passportNum.Text;
            if (String.IsNullOrEmpty(passportNum.Text))
            {
                errorNumber.SetError(passportNum, "Passport number must be inputted");
            }

            else if (text.Length != 9)
            {
                errorNumber.SetError(passportNum, "Passport number must be is LLXXXXXXX format");
            }
            else
            {
                errorNumber.Clear();
            }
        }

        private void writePhoneNum_Validating(object? sender, EventArgs e)
        {
            string text = writePhoneNum.Text;
            if (String.IsNullOrEmpty(writePhoneNum.Text))
            {
                errorNumber.SetError(writePhoneNum, "Phone number must be inputted");
            }
            else if (text.Length != 12)
            {
                errorNumber.SetError(writePhoneNum, "Phone number must contains 12 digits");
            }
            else
            {
                errorNumber.Clear();
            }
        }

        private void enterScoreNum_Validating(object? sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(enterScoreNum.Text))
            {
                errorNumber.SetError(enterScoreNum, "Score number must be inputted");
            }
            else if (enterScoreNum.ToString().Length != 7)
            {
                errorNumber.SetError(enterScoreNum, "Score number must contains 7 digits");
            }
            else
            {
                errorNumber.Clear();
            }
        }

        private void SaveInfo_Click(object sender, EventArgs e)
        {

            try
            {
                Score score = new Score(Int32.Parse(enterScoreNum.Text), comboBox1.SelectedItem.ToString(), monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"), checkBox1.Checked, checkBox2.Checked);
                Owner owner = new Owner(writeSurname.Text, writeName.Text, writeLastName.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), passportNum.Text, score);

                string json = JsonConvert.SerializeObject(owner);
                var jsonPath = "D:\\Univer\\4-th term\\Labs C#\\Lr2\\lr_02\\lr_02\\Owner.json";
                File.WriteAllText(jsonPath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Readfrom_Click(object sender, EventArgs e)
        {
            try
            {
                var jsonPath = "D:\\Univer\\4-th term\\Labs C#\\Lr2\\lr_02\\lr_02\\Owner.json";
                string json = File.ReadAllText(jsonPath);
                richTextBox1.Clear();

                Owner owner = JsonConvert.DeserializeObject<Owner>(json);

                richTextBox1.AppendText($"Surname: {owner.surname}\n");
                richTextBox1.AppendText($"Name: {owner.name}\n");
                richTextBox1.AppendText($"Patronimic: {owner.lastName} \n");
                richTextBox1.AppendText($"Birthday: {owner.birthday}\n");
                richTextBox1.AppendText($"Passport number: {owner.passportNumber} \n");
                richTextBox1.AppendText($"Score number: {owner.score.number} \n");
                richTextBox1.AppendText($"Contrubution type: {owner.score.contributionType} \n");
                richTextBox1.AppendText($"Open date: {owner.score.openDate} \n");
                richTextBox1.AppendText($"Need to get SMS: {owner.score.getSMS} \n");
                richTextBox1.AppendText($"Need to connect IB: {owner.score.connectIB} \n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bank_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Low termin");
            comboBox1.Items.Add("Long termin");
        }
    }
}