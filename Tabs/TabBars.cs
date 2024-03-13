using System.Runtime.InteropServices;

namespace Cursach.Tabs
{
    internal class TabBars
    {
        public TabBars(TabControl Parent) 
        { 
            tabControl1 = Parent;
            tabControl1.TabPages[tabControl1.TabCount - 1].Text = "";
            tabControl1.Padding = new Point(12, 4);
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += tabControl1_DrawItem;
            tabControl1.MouseDown += tabControl1_MouseDown;
            tabControl1.Selecting += tabControl1_Selecting;
            tabControl1.HandleCreated += tabControl1_HandleCreated;
        }

        private ushort session = 0;
        private TabControl tabControl1 = null;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int TCM_SETMINTABWIDTH = 0x1300 + 49;

        private void tabControl1_HandleCreated(object sender, EventArgs e)
        { SendMessage(tabControl1.Handle, TCM_SETMINTABWIDTH, IntPtr.Zero, (IntPtr)16); }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        { if (e.TabPageIndex == tabControl1.TabCount - 1) e.Cancel = true; }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = tabControl1.TabCount - 1;
            if (tabControl1.GetTabRect(lastIndex).Contains(e.Location))
            {
                TabPage tp = new TabPage("Session" + ++session);
                tp.Controls.Add(new DefaultTabPage() { Dock = DockStyle.Fill });
                tabControl1.TabPages.Insert(lastIndex, tp);
                tabControl1.SelectedIndex = lastIndex;
                tabControl1.TabPages[lastIndex].UseVisualStyleBackColor = true;
            }
            else
            {
                for (var i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    var tabRect = tabControl1.GetTabRect(i);
                    tabRect.Inflate(-2, -2);

                    Bitmap closeImage = Resources.Close;
                    var imageRect = new Rectangle((tabRect.Right - closeImage.Width), tabRect.Top + (tabRect.Height - closeImage.Height) / 2, closeImage.Width, closeImage.Height);
                    if (imageRect.Contains(e.Location))
                    {
                        tabControl1.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabPage = tabControl1.TabPages[e.Index];
            var tabRect = tabControl1.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);
            if (e.Index == tabControl1.TabCount - 1)
            {
                var addImage = Resources.Add;
                e.Graphics.DrawImage(addImage, tabRect.Left + (tabRect.Width - addImage.Width) / 2, tabRect.Top + (tabRect.Height - addImage.Height) / 2);
            }
            else
            {
                var closeImage = Resources.Close;
                e.Graphics.DrawImage(closeImage, (tabRect.Right - closeImage.Width), tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tabRect, tabPage.ForeColor, TextFormatFlags.Left);
            }
        }
    }
}