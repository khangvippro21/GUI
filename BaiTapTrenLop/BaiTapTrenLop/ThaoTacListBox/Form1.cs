namespace ThaoTacListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(String.Format("{0}", listView1.Items.Count + 1));
            item.SubItems.Add(txtHoten.Text);
            item.SubItems.Add(cbTrinhdo.Text);
            item.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy"));
            if (rdNam.Checked)
            {
                item.ImageIndex = 0;
                item.SubItems.Add("Nam");
            }
            else
            {
                item.ImageIndex = 1;
                item.SubItems.Add("Nữ");
            }
            listView1.Items.Add(item);



        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }

        private void rdLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rdLarge.Checked)
            {

            }
        }
    }
}
