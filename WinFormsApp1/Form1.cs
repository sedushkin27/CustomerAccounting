using System.Windows.Forms;

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

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            string name = addName.Text;
            DateTime date = startDateTime.Value;
            int howLongTime = Convert.ToInt32(HowLongTime.Text);

            records.Add(new Record(date, name, howLongTime));
            records.Sort();
            addName.Clear();

            foreach (Record record in records)
            {
                if (record.EndTime > EndTime)
                {
                    EndTime = record.EndTime;
                }
            }

            startDateTime.Value = EndTime;

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
            deleteName.Clear();

            foreach(Record record in records.ToList())
            {
                if (record.Name == name)
                {
                    records.Remove(record);
                }
            }

            records.Sort();
        }

        private void ButtonUpdateList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(Record recordObject in records)
            {
                listBox1.Items.Add(recordObject.ToString());
            }
        }
        private void ButtonDeleteAll_Click(object sender, EventArgs e)
        {
            records.Clear();
        }
    }
}