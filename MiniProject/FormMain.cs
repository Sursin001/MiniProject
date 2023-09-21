namespace MiniProject
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)
        {
            ConterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ConterPanel.Controls.Add(f);
            f.Show();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }
    }
}