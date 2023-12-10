namespace Task_2
{
    public partial class Form1 : Form
    {
        public string TextBoxText
        {
            set
            {
                textBox1.Text = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
            EditButton.Enabled = false;
        }



        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files (*.txt) | *.txt || ";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                textBox1.Text = reader.ReadToEnd();
                reader.Close();
                EditButton.Enabled=true;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(textBox1.Text);
            form.Owner = this;
            form.Show();
        }
    }
}
