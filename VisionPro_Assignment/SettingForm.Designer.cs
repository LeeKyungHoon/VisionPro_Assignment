namespace VisionPro_Assignment
{
    partial class SettingForm
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
            this.toolTabControl = new System.Windows.Forms.TabControl();
            this.PMAlignPatternTab = new System.Windows.Forms.TabPage();
            this.PMAlignEnableChkBox = new System.Windows.Forms.CheckBox();
            this.BlobTab = new System.Windows.Forms.TabPage();
            this.CaliperTab = new System.Windows.Forms.TabPage();
            this.HistogramTab = new System.Windows.Forms.TabPage();
            this.HistoEnableChkBox = new System.Windows.Forms.CheckBox();
            this.patternTrainRegionBtn = new System.Windows.Forms.Button();
            this.patternSearchRegionBtn = new System.Windows.Forms.Button();
            this.pRegionShapeComboBox = new System.Windows.Forms.ComboBox();
            this.toolTabControl.SuspendLayout();
            this.PMAlignPatternTab.SuspendLayout();
            this.HistogramTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTabControl
            // 
            this.toolTabControl.Controls.Add(this.PMAlignPatternTab);
            this.toolTabControl.Controls.Add(this.BlobTab);
            this.toolTabControl.Controls.Add(this.CaliperTab);
            this.toolTabControl.Controls.Add(this.HistogramTab);
            this.toolTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolTabControl.Location = new System.Drawing.Point(0, 0);
            this.toolTabControl.Name = "toolTabControl";
            this.toolTabControl.SelectedIndex = 0;
            this.toolTabControl.Size = new System.Drawing.Size(918, 449);
            this.toolTabControl.TabIndex = 0;
            // 
            // PMAlignPatternTab
            // 
            this.PMAlignPatternTab.Controls.Add(this.pRegionShapeComboBox);
            this.PMAlignPatternTab.Controls.Add(this.patternSearchRegionBtn);
            this.PMAlignPatternTab.Controls.Add(this.patternTrainRegionBtn);
            this.PMAlignPatternTab.Controls.Add(this.PMAlignEnableChkBox);
            this.PMAlignPatternTab.Location = new System.Drawing.Point(4, 22);
            this.PMAlignPatternTab.Name = "PMAlignPatternTab";
            this.PMAlignPatternTab.Padding = new System.Windows.Forms.Padding(3);
            this.PMAlignPatternTab.Size = new System.Drawing.Size(910, 423);
            this.PMAlignPatternTab.TabIndex = 0;
            this.PMAlignPatternTab.Text = "PMAlignPattern";
            this.PMAlignPatternTab.UseVisualStyleBackColor = true;
            // 
            // PMAlignEnableChkBox
            // 
            this.PMAlignEnableChkBox.AutoSize = true;
            this.PMAlignEnableChkBox.Location = new System.Drawing.Point(8, 8);
            this.PMAlignEnableChkBox.Name = "PMAlignEnableChkBox";
            this.PMAlignEnableChkBox.Size = new System.Drawing.Size(63, 16);
            this.PMAlignEnableChkBox.TabIndex = 0;
            this.PMAlignEnableChkBox.Text = "Enable";
            this.PMAlignEnableChkBox.UseVisualStyleBackColor = true;
            this.PMAlignEnableChkBox.CheckedChanged += new System.EventHandler(this.PMAlignEnableChkBox_CheckedChanged);
            // 
            // BlobTab
            // 
            this.BlobTab.Location = new System.Drawing.Point(4, 22);
            this.BlobTab.Name = "BlobTab";
            this.BlobTab.Padding = new System.Windows.Forms.Padding(3);
            this.BlobTab.Size = new System.Drawing.Size(910, 423);
            this.BlobTab.TabIndex = 1;
            this.BlobTab.Text = "Blob";
            this.BlobTab.UseVisualStyleBackColor = true;
            // 
            // CaliperTab
            // 
            this.CaliperTab.Location = new System.Drawing.Point(4, 22);
            this.CaliperTab.Name = "CaliperTab";
            this.CaliperTab.Padding = new System.Windows.Forms.Padding(3);
            this.CaliperTab.Size = new System.Drawing.Size(910, 423);
            this.CaliperTab.TabIndex = 2;
            this.CaliperTab.Text = "Caliper";
            this.CaliperTab.UseVisualStyleBackColor = true;
            // 
            // HistogramTab
            // 
            this.HistogramTab.Controls.Add(this.HistoEnableChkBox);
            this.HistogramTab.Location = new System.Drawing.Point(4, 22);
            this.HistogramTab.Name = "HistogramTab";
            this.HistogramTab.Padding = new System.Windows.Forms.Padding(3);
            this.HistogramTab.Size = new System.Drawing.Size(910, 423);
            this.HistogramTab.TabIndex = 3;
            this.HistogramTab.Text = "Histogram";
            this.HistogramTab.UseVisualStyleBackColor = true;
            // 
            // HistoEnableChkBox
            // 
            this.HistoEnableChkBox.AutoSize = true;
            this.HistoEnableChkBox.Location = new System.Drawing.Point(8, 6);
            this.HistoEnableChkBox.Name = "HistoEnableChkBox";
            this.HistoEnableChkBox.Size = new System.Drawing.Size(63, 16);
            this.HistoEnableChkBox.TabIndex = 0;
            this.HistoEnableChkBox.Text = "Enable";
            this.HistoEnableChkBox.UseVisualStyleBackColor = true;
            // 
            // patternTrainRegionBtn
            // 
            this.patternTrainRegionBtn.Location = new System.Drawing.Point(6, 30);
            this.patternTrainRegionBtn.Name = "patternTrainRegionBtn";
            this.patternTrainRegionBtn.Size = new System.Drawing.Size(75, 23);
            this.patternTrainRegionBtn.TabIndex = 1;
            this.patternTrainRegionBtn.Text = "등록 영역";
            this.patternTrainRegionBtn.UseVisualStyleBackColor = true;
            this.patternTrainRegionBtn.Click += new System.EventHandler(this.patternTrainRegionBtn_Click);
            // 
            // patternSearchRegionBtn
            // 
            this.patternSearchRegionBtn.Location = new System.Drawing.Point(6, 59);
            this.patternSearchRegionBtn.Name = "patternSearchRegionBtn";
            this.patternSearchRegionBtn.Size = new System.Drawing.Size(75, 23);
            this.patternSearchRegionBtn.TabIndex = 2;
            this.patternSearchRegionBtn.Text = "검색 영역";
            this.patternSearchRegionBtn.UseVisualStyleBackColor = true;
            this.patternSearchRegionBtn.Click += new System.EventHandler(this.patternSearchRegionBtn_Click);
            // 
            // pRegionShapeComboBox
            // 
            this.pRegionShapeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pRegionShapeComboBox.FormattingEnabled = true;
            this.pRegionShapeComboBox.Items.AddRange(new object[] {
            "None",
            "Circle",
            "Ellipse",
            "Polygon",
            "Rectangle",
            "RectangleAffine",
            "CircularAnnulusSection",
            "EllipticalAnnulusSection"});
            this.pRegionShapeComboBox.Location = new System.Drawing.Point(87, 32);
            this.pRegionShapeComboBox.Name = "pRegionShapeComboBox";
            this.pRegionShapeComboBox.Size = new System.Drawing.Size(121, 20);
            this.pRegionShapeComboBox.TabIndex = 3;
            this.pRegionShapeComboBox.SelectedIndexChanged += new System.EventHandler(this.pRegionShapeComboBox_SelectedIndexChanged);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 449);
            this.Controls.Add(this.toolTabControl);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.toolTabControl.ResumeLayout(false);
            this.PMAlignPatternTab.ResumeLayout(false);
            this.PMAlignPatternTab.PerformLayout();
            this.HistogramTab.ResumeLayout(false);
            this.HistogramTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl toolTabControl;
        private System.Windows.Forms.TabPage PMAlignPatternTab;
        private System.Windows.Forms.TabPage BlobTab;
        private System.Windows.Forms.TabPage CaliperTab;
        private System.Windows.Forms.TabPage HistogramTab;
        private System.Windows.Forms.CheckBox HistoEnableChkBox;
        private System.Windows.Forms.CheckBox PMAlignEnableChkBox;
        private System.Windows.Forms.Button patternTrainRegionBtn;
        private System.Windows.Forms.Button patternSearchRegionBtn;
        private System.Windows.Forms.ComboBox pRegionShapeComboBox;
    }
}