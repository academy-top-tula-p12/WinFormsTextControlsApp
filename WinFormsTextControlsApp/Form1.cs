namespace WinFormsTextControlsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox3.AutoCompleteCustomSource.AddRange(new string[] { "Тула", "Новосибирск", "Москва", "Туапсе", "Николаев", "Мурманск", "Тайшет", "Новгород", "Моршанск" });
            textBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;

            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;

            if (sender is TextBox txt)
                label1.Text = txt.Text.ToUpper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUTTON OK");
        }
    }
}
