namespace Cursach.Tabs
{
    partial class DefaultTabPage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultTabPage));
            panelForChart = new Panel();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            toolStrip1 = new ToolStrip();
            loadBT = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            seriesBT = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            saveBT = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            chartTitleBT = new ToolStripMenuItem();
            legendStatusBT = new ToolStripMenuItem();
            axisStateBT = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            panelForChart.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelForChart
            // 
            panelForChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelForChart.BorderStyle = BorderStyle.FixedSingle;
            panelForChart.Controls.Add(plotView1);
            panelForChart.Location = new Point(0, 30);
            panelForChart.Name = "panelForChart";
            panelForChart.Size = new Size(803, 519);
            panelForChart.TabIndex = 1;
            // 
            // plotView1
            // 
            plotView1.Dock = DockStyle.Fill;
            plotView1.Location = new Point(0, 0);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(801, 517);
            plotView1.TabIndex = 0;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { loadBT, toolStripSeparator1, seriesBT, toolStripSeparator2, toolStripDropDownButton1, toolStripSeparator3, toolStripDropDownButton2, toolStripSeparator4, saveBT });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(803, 27);
            toolStrip1.TabIndex = 12;
            toolStrip1.Text = "toolStrip1";
            // 
            // loadBT
            // 
            loadBT.DisplayStyle = ToolStripItemDisplayStyle.Text;
            loadBT.Image = (Image)resources.GetObject("loadBT.Image");
            loadBT.ImageTransparentColor = Color.Magenta;
            loadBT.Name = "loadBT";
            loadBT.Size = new Size(82, 24);
            loadBT.Text = "Load Data";
            loadBT.Click += loadBtn_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // seriesBT
            // 
            seriesBT.DisplayStyle = ToolStripItemDisplayStyle.Text;
            seriesBT.Image = (Image)resources.GetObject("seriesBT.Image");
            seriesBT.ImageTransparentColor = Color.Magenta;
            seriesBT.Name = "seriesBT";
            seriesBT.Size = new Size(109, 24);
            seriesBT.Text = "Series Settings";
            seriesBT.Click += toolStripButton2_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { chartTitleBT, legendStatusBT, axisStateBT });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(115, 24);
            toolStripDropDownButton1.Text = "Chart Settings";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { themeToolStripMenuItem });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(164, 24);
            toolStripDropDownButton2.Text = "Enviropment Settings";
            // 
            // saveBT
            // 
            saveBT.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveBT.Image = (Image)resources.GetObject("saveBT.Image");
            saveBT.ImageTransparentColor = Color.Magenta;
            saveBT.Name = "saveBT";
            saveBT.Size = new Size(44, 24);
            saveBT.Text = "Save";
            saveBT.Click += toolStripButton3_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // chartTitleBT
            // 
            chartTitleBT.Name = "chartTitleBT";
            chartTitleBT.Size = new Size(224, 26);
            chartTitleBT.Text = "Name";
            // 
            // legendStatusBT
            // 
            legendStatusBT.Name = "legendStatusBT";
            legendStatusBT.Size = new Size(224, 26);
            legendStatusBT.Text = "Legend";
            // 
            // axisStateBT
            // 
            axisStateBT.Name = "axisStateBT";
            axisStateBT.Size = new Size(224, 26);
            axisStateBT.Text = "Axis";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(224, 26);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // DefaultTabPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolStrip1);
            Controls.Add(panelForChart);
            Name = "DefaultTabPage";
            Size = new Size(803, 549);
            panelForChart.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelForChart;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripButton loadBT;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton seriesBT;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton saveBT;
        private ToolStripMenuItem chartTitleBT;
        private ToolStripMenuItem legendStatusBT;
        private ToolStripMenuItem axisStateBT;
        private ToolStripMenuItem themeToolStripMenuItem;
    }
}
