using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Record> records = new List<Record>();
        private DateTime EndTime = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
            records.Sort();
            listBox1.Items.Clear();
            foreach (Record recordObject in records)
            {
                listBox1.Items.Add(recordObject.ToString());
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string name = addName.Text;
            DateTime date = startDateTime.Value;
            bool check = Int32.TryParse(HowLongTime.Text, out int howLongTime);
            if (check)
            {
                if (addName.Text == null || addName.Text.Trim() == "")
                {
                    MessageBox.Show("you didn't enter a name.");
                }
                else
                {
                    records.Add(new Record(date, name, howLongTime));
                    addName.Clear();

                    foreach (Record record in records)
                    {
                        if (record.EndTime > EndTime)
                        {
                            EndTime = record.EndTime;
                        }
                    }

                    UpdateList();
                    startDateTime.Value = EndTime;
                }
            }
            else
            {
                MessageBox.Show("you entered the wrong number.");
            }

        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string name = deleteName.Text;
            if (deleteName.Text == null || deleteName.Text.Trim() == "") 
            { 
                MessageBox.Show("you didn't enter a name."); 
            }
            else
            {
                for (int i = 0; i < records.Count; i++)
                {
                    if (records[i].Name == name)
                    {
                        records.RemoveAt(i);
                    }
                }
            }
            deleteName.Clear();
            UpdateList();
        }

        private void ButtonDeleteAll_Click(object sender, EventArgs e)
        {
            records.Clear();
            UpdateList();
        }
    }
}