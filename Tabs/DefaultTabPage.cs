

namespace Cursach.Tabs
{
    public partial class DefaultTabPage : UserControl
    {
        public DefaultTabPage()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            LoadData.Load form = new LoadData.Load();
            form.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
