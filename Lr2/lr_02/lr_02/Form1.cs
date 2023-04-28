using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lr_02
{
    public partial class Bank : Form
    {
        private Owner owner;
        private Binder binder;
        List<Owner> list = new List<Owner>();


        public Bank()
        {
            InitializeComponent();

            //owner = new Owner();
            writeSurname.Validating += writeSurname_Validating;
            writeName.Validating += writeName_Validating;
            passportNum.Validating += passportNum_Validating;
            writePhoneNum.Validating += writePhoneNum_Validating;
            enterScoreNum.Validating += enterScoreNum_Validating;
            string jsonPath = "Owner.json";
            string json = File.ReadAllText(jsonPath);

            if (JsonConvert.DeserializeObject<List<Owner>>(json) != null)
                list = JsonConvert.DeserializeObject<List<Owner>>(json);

            /* SaveInfo.Click += SaveInfo_Click;*/
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
            if (!Char.IsLetter(keyChar) && e.KeyChar != (char)Keys.Back && keyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Surname can't contains symbols instead letters and -");
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
            string text = enterScoreNum.Text;
            if (String.IsNullOrEmpty(enterScoreNum.Text))
            {
                errorNumber.SetError(enterScoreNum, "Score number must be inputted");
            }
            else if (text.Length != 7)
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
                var jsonPath = "Owner.json";
                list.Add(owner);
                var json = JsonConvert.SerializeObject(list, Formatting.Indented);
                byte[] bytes = Encoding.UTF8.GetBytes(json);

                using (FileStream stream = new FileStream(jsonPath, FileMode.OpenOrCreate))
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
                /*var txt = File.ReadAllText(jsonPath);
                
                owners.Add(owner);
                */
                /*File.WriteAllText(jsonPath, json);
                List<Owner> owners = JsonConvert.SerializeObject<List<Owner>>();
                ;*/
                //var json = JsonConvert.SerializeObject(owner, Formatting.Indented);



                //string json = File.ReadAllText(jsonPath);
                //JObject jsonObject = JObject.Parse(json);

                //jsonObject.Add(owner.ToString(), owner);
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
                string jsonPath = "Owner.json";
                string json = File.ReadAllText(jsonPath);

                List<Owner> ownerList = JsonConvert.DeserializeObject<List<Owner>>(json);
                richTextBox1.Clear();
                if (ownerList != null)
                {
                    foreach (var owner in ownerList)
                    {
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
                        richTextBox1.AppendText("\n");
                    }
                }
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
            listSearch.Items.Add("by passport number");
            listSearch.Items.Add("by full name");
            listSearch.Items.Add("by score number");
            listSearch.Items.Add("by contridution type");
            listSort.Items.Add("by contribution type");
            listSort.Items.Add("by open date");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Score score = new Score(Int32.Parse(enterScoreNum.Text), comboBox1.SelectedItem.ToString(), monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"), checkBox1.Checked, checkBox2.Checked);
                Owner owner = new Owner(writeSurname.Text, writeName.Text, writeLastName.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), passportNum.Text, score);
                var jsonPath = "Owner.json";
                list.Add(owner);
                var json = JsonConvert.SerializeObject(list, Formatting.Indented);
                byte[] bytes = Encoding.UTF8.GetBytes(json);

                using (FileStream stream = new FileStream(jsonPath, FileMode.OpenOrCreate))
                {
                    stream.Write(bytes, 0, bytes.Length);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Clear();
                if (searchTextBox.Text == "")
                {
                    throw new Exception("Empty textbox.");
                }
                else if (listSearch.Text == "by passport number")
                {
                    Regex regex = new Regex(searchTextBox.Text, RegexOptions.IgnoreCase);
                    richTextBox2.AppendText("Result of searching by passport number: \n\n");
                    foreach (Owner owner in list)
                    {
                        if (regex.IsMatch(owner.passportNumber))
                        {
                            richTextBox2.AppendText($"Surname: {owner.surname}\n");
                            richTextBox2.AppendText($"Name: {owner.name}\n");
                            richTextBox2.AppendText($"Patronimic: {owner.lastName} \n");
                            richTextBox2.AppendText($"Birthday: {owner.birthday}\n");
                            richTextBox2.AppendText($"Passport number: {owner.passportNumber} \n");
                            richTextBox2.AppendText($"Score number: {owner.score.number} \n");
                            richTextBox2.AppendText($"Contrubution type: {owner.score.contributionType} \n");
                            richTextBox2.AppendText($"Open date: {owner.score.openDate} \n");
                            richTextBox2.AppendText($"Need to get SMS: {owner.score.getSMS} \n");
                            richTextBox2.AppendText($"Need to connect IB: {owner.score.connectIB} \n");
                            richTextBox2.AppendText("\n");
                        }
                    }
                    richTextBox2.AppendText("-------------------------------------\n");
                }
                else if (listSearch.Text == "by full name")
                {
                    Regex regex = new Regex(searchTextBox.Text, RegexOptions.IgnoreCase);
                    richTextBox2.AppendText("Result of searching by full name: \n\n");
                    foreach (Owner owner in list)
                    {
                        if (regex.IsMatch(owner.surname) || regex.IsMatch(owner.name) || regex.IsMatch(owner.lastName))
                        {
                            richTextBox2.AppendText($"Surname: {owner.surname}\n");
                            richTextBox2.AppendText($"Name: {owner.name}\n");
                            richTextBox2.AppendText($"Patronimic: {owner.lastName} \n");
                            richTextBox2.AppendText($"Birthday: {owner.birthday}\n");
                            richTextBox2.AppendText($"Passport number: {owner.passportNumber} \n");
                            richTextBox2.AppendText($"Score number: {owner.score.number} \n");
                            richTextBox2.AppendText($"Contrubution type: {owner.score.contributionType} \n");
                            richTextBox2.AppendText($"Open date: {owner.score.openDate} \n");
                            richTextBox2.AppendText($"Need to get SMS: {owner.score.getSMS} \n");
                            richTextBox2.AppendText($"Need to connect IB: {owner.score.connectIB} \n");
                            richTextBox2.AppendText("\n");
                        }
                    }
                    richTextBox2.AppendText("-------------------------------------\n");
                }
                else if (listSearch.Text == "by score number")
                {
                    Regex regex = new Regex(searchTextBox.Text, RegexOptions.IgnoreCase);
                    richTextBox2.AppendText("Result of searching by score number: \n\n");
                    foreach (Owner owner in list)
                    {
                        if (regex.IsMatch(owner.score.number.ToString()))
                        {
                            richTextBox2.AppendText($"Surname: {owner.surname}\n");
                            richTextBox2.AppendText($"Name: {owner.name}\n");
                            richTextBox2.AppendText($"Patronimic: {owner.lastName} \n");
                            richTextBox2.AppendText($"Birthday: {owner.birthday}\n");
                            richTextBox2.AppendText($"Passport number: {owner.passportNumber} \n");
                            richTextBox2.AppendText($"Score number: {owner.score.number} \n");
                            richTextBox2.AppendText($"Contrubution type: {owner.score.contributionType} \n");
                            richTextBox2.AppendText($"Open date: {owner.score.openDate} \n");
                            richTextBox2.AppendText($"Need to get SMS: {owner.score.getSMS} \n");
                            richTextBox2.AppendText($"Need to connect IB: {owner.score.connectIB} \n");
                            richTextBox2.AppendText("\n");
                        }
                        else
                        {
                            richTextBox2.AppendText("No matches\n");
                            break;
                        }
                    }

                    richTextBox2.AppendText("-------------------------------------\n");

                }
                else if (listSearch.Text == "by contridution type")
                {
                    Regex regex = new Regex(searchTextBox.Text, RegexOptions.IgnoreCase);
                    richTextBox2.AppendText("Result of searching by contribution type: \n\n");
                    foreach (Owner owner in list)
                    {
                        if (regex.IsMatch(owner.score.contributionType.ToString()))
                        {
                            richTextBox2.AppendText($"Surname: {owner.surname}\n");
                            richTextBox2.AppendText($"Name: {owner.name}\n");
                            richTextBox2.AppendText($"Patronimic: {owner.lastName} \n");
                            richTextBox2.AppendText($"Birthday: {owner.birthday}\n");
                            richTextBox2.AppendText($"Passport number: {owner.passportNumber} \n");
                            richTextBox2.AppendText($"Score number: {owner.score.number} \n");
                            richTextBox2.AppendText($"Contrubution type: {owner.score.contributionType} \n");
                            richTextBox2.AppendText($"Open date: {owner.score.openDate} \n");
                            richTextBox2.AppendText($"Need to get SMS: {owner.score.getSMS} \n");
                            richTextBox2.AppendText($"Need to connect IB: {owner.score.connectIB} \n");
                            richTextBox2.AppendText("\n");
                        }
                    }
                    if (!regex.IsMatch(owner.score.contributionType.ToString()))
                    {
                        richTextBox2.AppendText("No matches");
                    }
                    richTextBox2.AppendText("-------------------------------------\n");
                }

                else
                {
                    throw new Exception("No search parameter.");
                }
                searchTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You can't search without parameters");
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (listSearch.Text == "by passport number")
            {
                char keyChar = e.KeyChar;

                if (!Char.IsLetterOrDigit(keyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    return;
                }
            }
            // searchTextBox
            else if (listSearch.Text == "by full name")
            {
                char keyChar = e.KeyChar;
                if (!Char.IsLetter(keyChar) && e.KeyChar != (char)Keys.Back && keyChar != '-')
                {
                    e.Handled = true;
                    return;
                }
            }
            else if (listSearch.Text == "by score number")
            {
                char keyChar = e.KeyChar;

                if (!Char.IsDigit(keyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    return;
                }
            }
            else if (listSearch.Text == "by contridution type")
            {
                char keyChar = e.KeyChar;

                if (!Char.IsLetter(keyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void Sortby_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Clear();
                if (listSort.Text == "by contribution type")
                {
                    var sortbytype = list.OrderBy(s => s.score.contributionType.ToString());
                    foreach (Owner owner in list)
                    {
                        richTextBox2.AppendText($"Surname: {owner.surname}\n");
                        richTextBox2.AppendText($"Name: {owner.name}\n");
                        richTextBox2.AppendText($"Patronimic: {owner.lastName} \n");
                        richTextBox2.AppendText($"Birthday: {owner.birthday}\n");
                        richTextBox2.AppendText($"Passport number: {owner.passportNumber} \n");
                        richTextBox2.AppendText($"Score number: {owner.score.number} \n");
                        richTextBox2.AppendText($"Contrubution type: {owner.score.contributionType} \n");
                        richTextBox2.AppendText($"Open date: {owner.score.openDate} \n");
                        richTextBox2.AppendText($"Need to get SMS: {owner.score.getSMS} \n");
                        richTextBox2.AppendText($"Need to connect IB: {owner.score.connectIB} \n");
                        richTextBox2.AppendText("\n");

                    }
                }
                else if (listSort.Text == "by open date")
                {
                    var sortbydate = list.OrderBy(s => s.score.openDate.ToString());
                    foreach (Owner owner in list)
                    {
                        richTextBox2.AppendText($"Surname: {owner.surname}\n");
                        richTextBox2.AppendText($"Name: {owner.name}\n");
                        richTextBox2.AppendText($"Patronimic: {owner.lastName} \n");
                        richTextBox2.AppendText($"Birthday: {owner.birthday}\n");
                        richTextBox2.AppendText($"Passport number: {owner.passportNumber} \n");
                        richTextBox2.AppendText($"Score number: {owner.score.number} \n");
                        richTextBox2.AppendText($"Contrubution type: {owner.score.contributionType} \n");
                        richTextBox2.AppendText($"Open date: {owner.score.openDate} \n");
                        richTextBox2.AppendText($"Need to get SMS: {owner.score.getSMS} \n");
                        richTextBox2.AppendText($"Need to connect IB: {owner.score.connectIB} \n");
                        richTextBox2.AppendText("\n");

                    }
                }
                else
                {
                    throw new Exception("You can't sort without parameters");
                }
            }
            catch (Exception ex) 
            {

            }
        }
    }
}