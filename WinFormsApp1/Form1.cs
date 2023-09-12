using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Record> records = new List<Record>();

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
                if (string.IsNullOrWhiteSpace(addName.Text))
                {
                    MessageBox.Show("You didn't enter a name.");
                }
                else
                {
                    records.Add(new Record(date, name, howLongTime));
                    addName.Clear();
                    HowLongTime.Clear();
                    UpdateList();

                    foreach (Record record in records)
                    {
                        if (record.EndTime > startDateTime.Value)
                        {
                            startDateTime.Value = record.EndTime;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You entered the wrong number.");
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
            if (string.IsNullOrWhiteSpace(deleteName.Text)) 
            { 
                MessageBox.Show("You didn't enter a name."); 
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