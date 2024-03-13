namespace Cursach.LoadData
{
    partial class Load
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Label label1;
            Label label2;
            Label label3;
            xDataType = new ComboBox();
            yDataType = new ComboBox();
            readMode = new CheckBox();
            fileURL = new TextBox();
            browseBT = new Button();
            previewList = new ListView();
            altBrowseBT = new Button();
            submitBT = new Button();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            fileType = new ComboBox();
            legendsNames = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 21);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 6;
            label1.Text = "Preview:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 7;
            label2.Text = "X axis Data type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 8;
            label3.Text = "Y axis Data type";
            // 
            // xDataType
            // 
            xDataType.DropDownStyle = ComboBoxStyle.DropDownList;
            xDataType.FlatStyle = FlatStyle.Flat;
            xDataType.FormattingEnabled = true;
            xDataType.Items.AddRange(new object[] { "Integer", "Real Number", "Date", "String" });
            xDataType.Location = new Point(12, 32);
            xDataType.Name = "xDataType";
            xDataType.Size = new Size(151, 28);
            xDataType.TabIndex = 0;
            // 
            // yDataType
            // 
            yDataType.DropDownStyle = ComboBoxStyle.DropDownList;
            yDataType.FlatStyle = FlatStyle.Flat;
            yDataType.FormattingEnabled = true;
            yDataType.Items.AddRange(new object[] { "Integer", "Real Number", "Date", "String" });
            yDataType.Location = new Point(12, 95);
            yDataType.Name = "yDataType";
            yDataType.Size = new Size(151, 28);
            yDataType.TabIndex = 1;
            // 
            // readMode
            // 
            readMode.AutoSize = true;
            readMode.Location = new Point(12, 129);
            readMode.Name = "readMode";
            readMode.Size = new Size(163, 24);
            readMode.TabIndex = 2;
            readMode.Text = "Allow MultiCharting";
            readMode.UseVisualStyleBackColor = true;
            // 
            // fileURL
            // 
            fileURL.ForeColor = Color.Gray;
            fileURL.Location = new Point(12, 224);
            fileURL.Name = "fileURL";
            fileURL.Size = new Size(277, 27);
            fileURL.TabIndex = 4;
            fileURL.Text = "File path";
            fileURL.Enter += fileURL_Enter;
            fileURL.Leave += fileURL_Leave;
            fileURL.Validating += fileURL_Validating;
            // 
            // browseBT
            // 
            browseBT.Location = new Point(12, 257);
            browseBT.Name = "browseBT";
            browseBT.Size = new Size(94, 29);
            browseBT.TabIndex = 3;
            browseBT.Text = "Browse";
            browseBT.UseVisualStyleBackColor = true;
            browseBT.Click += browseBT_Click;
            // 
            // previewList
            // 
            previewList.Location = new Point(295, 12);
            previewList.Name = "previewList";
            previewList.Size = new Size(295, 309);
            previewList.TabIndex = 7;
            previewList.UseCompatibleStateImageBehavior = false;
            previewList.VirtualMode = true;
            // 
            // altBrowseBT
            // 
            altBrowseBT.Location = new Point(112, 257);
            altBrowseBT.Name = "altBrowseBT";
            altBrowseBT.Size = new Size(177, 29);
            altBrowseBT.TabIndex = 5;
            altBrowseBT.Text = "Alternative Browsing";
            altBrowseBT.UseVisualStyleBackColor = true;
            altBrowseBT.Click += altBrowseBT_Click;
            // 
            // submitBT
            // 
            submitBT.Location = new Point(12, 292);
            submitBT.Name = "submitBT";
            submitBT.Size = new Size(277, 29);
            submitBT.TabIndex = 6;
            submitBT.Text = "Submit";
            submitBT.UseVisualStyleBackColor = true;
            submitBT.Click += submitBT_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // fileType
            // 
            fileType.DropDownStyle = ComboBoxStyle.DropDownList;
            fileType.FlatStyle = FlatStyle.Flat;
            fileType.FormattingEnabled = true;
            fileType.Items.AddRange(new object[] { ".dcs (.csv)", ".xls" });
            fileType.Location = new Point(12, 190);
            fileType.Name = "fileType";
            fileType.Size = new Size(151, 28);
            fileType.TabIndex = 9;
            // 
            // legendsNames
            // 
            legendsNames.AutoSize = true;
            legendsNames.Location = new Point(12, 159);
            legendsNames.Name = "legendsNames";
            legendsNames.Size = new Size(167, 24);
            legendsNames.TabIndex = 10;
            legendsNames.Text = "Load legends names";
            legendsNames.UseVisualStyleBackColor = true;
            // 
            // Load
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 333);
            Controls.Add(legendsNames);
            Controls.Add(fileType);
            Controls.Add(submitBT);
            Controls.Add(altBrowseBT);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(previewList);
            Controls.Add(browseBT);
            Controls.Add(fileURL);
            Controls.Add(readMode);
            Controls.Add(yDataType);
            Controls.Add(xDataType);
            MaximumSize = new Size(620, 380);
            MinimumSize = new Size(620, 380);
            Name = "Load";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Load";
            Load += Load_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox xDataType;
        private ComboBox yDataType;
        private CheckBox readMode;
        private TextBox fileURL;
        private Button browseBT;
        private ListView previewList;
        private Button altBrowseBT;
        private Button submitBT;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
        private ComboBox fileType;
        private CheckBox legendsNames;
    }
}