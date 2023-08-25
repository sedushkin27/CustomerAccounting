namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Records records = new Records();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string name = addName.Text;
            DateTime date = startDateTime.Value;
            int howLongTime = Convert.ToInt32(HowLongTime.Text);
            records.AddClient(date, name, howLongTime);
            addName.Clear();
            startDateTime.Value = records.RecentTime;
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string name = deleteName.Text;
            deleteName.Clear();
            records.RemoveClient(name);
        }

        private void buttonUpdateList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < records.record.Length; i++)
            {
                if (records.record[i].Ñreated == true)
                {
                    listBox1.Items.Add(records.record[i].Print());
                }
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            records.Clear();
        }
    }
}