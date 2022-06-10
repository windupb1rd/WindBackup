namespace WindBackup
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void selectSourceBtn_Click(object sender, EventArgs e)
        {
            var dialogResult = selectSourceDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string sourcePath = selectSourceDialog.SelectedPath;
            }
        }
    }
}