using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Cars_Class> c_list = new List<Cars_Class>();

        private void Save_button_Click(object sender, EventArgs e)
        {
            Cars_Class carrrr;
            Cars_listBox.Items.Clear();

            if (Black_radioButton.Checked)
            {
                carrrr = new Cars_Class(FName_textBox.Text, LNametextBox.Text, CarNumber_textBox.Text, Model_textBox.Text, Black_radioButton.Text);
            }
            else if (White_radioButton.Checked)
            {
                carrrr = new Cars_Class(FName_textBox.Text, LNametextBox.Text, CarNumber_textBox.Text, Model_textBox.Text, White_radioButton.Text);
            }
            else
            {
                carrrr = new Cars_Class(FName_textBox.Text, LNametextBox.Text, CarNumber_textBox.Text, Model_textBox.Text, Green_radioButton.Text);
            }

            c_list.Add(carrrr);

            Cars_listBox.Items.AddRange(c_list.Select(c => c.Number).ToArray());

            CarNumber_textBox.Clear();
            FName_textBox.Clear();
            LNametextBox.Clear();
            Phone_maskedTextBox.Clear();
            Model_textBox.Clear();
            Black_radioButton.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            c_list.RemoveAll(c => c.Number == Cars_listBox.SelectedItem);

            Cars_listBox.Items.Clear();

            for (int i = 0; i < c_list.Count; i++)
                Cars_listBox.Items.Add(c_list[i].Number);
        }

        

        private void Cars_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
