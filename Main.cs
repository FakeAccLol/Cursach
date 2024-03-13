using Cursach.Tabs;

namespace Cursach
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _ = new TabBars(tabControl1);
        }
    }
}
