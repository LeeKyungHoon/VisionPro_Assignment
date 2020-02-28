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
            this.pImageGrabBtn = new System.Windows.Forms.Button();
            this.pSearchRegionShapeComboBox = new System.Windows.Forms.ComboBox();
            this.pAdjustRegionShapeComboBox = new System.Windows.Forms.ComboBox();
            this.pSearchRegionBtn = new System.Windows.Forms.Button();
            this.pRegisterBtn = new System.Windows.Forms.Button();
            this.pAdjustRegionBtn = new System.Windows.Forms.Button();
            this.pEnableChkBox = new System.Windows.Forms.CheckBox();
            this.BlobTab = new System.Windows.Forms.TabPage();
            this.CaliperTab = new System.Windows.Forms.TabPage();
            this.HistogramTab = new System.Windows.Forms.TabPage();
            this.HistoEnableChkBox = new System.Windows.Forms.CheckBox();
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
            this.PMAlignPatternTab.Controls.Add(this.pImageGrabBtn);
            this.PMAlignPatternTab.Controls.Add(this.pSearchRegionShapeComboBox);
            this.PMAlignPatternTab.Controls.Add(this.pAdjustRegionShapeComboBox);
            this.PMAlignPatternTab.Controls.Add(this.pSearchRegionBtn);
            this.PMAlignPatternTab.Controls.Add(this.pRegisterBtn);
            this.PMAlignPatternTab.Controls.Add(this.pAdjustRegionBtn);
            this.PMAlignPatternTab.Controls.Add(this.pEnableChkBox);
            this.PMAlignPatternTab.Location = new System.Drawing.Point(4, 22);
            this.PMAlignPatternTab.Name = "PMAlignPatternTab";
            this.PMAlignPatternTab.Padding = new System.Windows.Forms.Padding(3);
            this.PMAlignPatternTab.Size = new System.Drawing.Size(910, 423);
            this.PMAlignPatternTab.TabIndex = 0;
            this.PMAlignPatternTab.Text = "PMAlignPattern";
            this.PMAlignPatternTab.UseVisualStyleBackColor = true;
            // 
            // pImageGrabBtn
            // 
            this.pImageGrabBtn.Location = new System.Drawing.Point(8, 28);
            this.pImageGrabBtn.Name = "pImageGrabBtn";
            this.pImageGrabBtn.Size = new System.Drawing.Size(75, 23);
            this.pImageGrabBtn.TabIndex = 4;
            this.pImageGrabBtn.Text = "이미지그랩";
            this.pImageGrabBtn.UseVisualStyleBackColor = true;
            this.pImageGrabBtn.Click += new System.EventHandler(this.pImageGrabBtn_Click);
            // 
            // pSearchRegionShapeComboBox
            // 
            this.pSearchRegionShapeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pSearchRegionShapeComboBox.FormattingEnabled = true;
            this.pSearchRegionShapeComboBox.Items.AddRange(new object[] {
            "None - Full",
            "Circle",
            "Ellipse",
            "Polygon",
            "Rectangle",
            "RectangleAffine",
            "CircularAnnulusSection",
            "EllipticalAnnulusSection"});
            this.pSearchRegionShapeComboBox.Location = new System.Drawing.Point(89, 117);
            this.pSearchRegionShapeComboBox.Name = "pSearchRegionShapeComboBox";
            this.pSearchRegionShapeComboBox.Size = new System.Drawing.Size(121, 20);
            this.pSearchRegionShapeComboBox.TabIndex = 3;
            this.pSearchRegionShapeComboBox.SelectedIndexChanged += new System.EventHandler(this.pSearchRegionShapeComboBox_SelectedIndexChanged);
            // 
            // pAdjustRegionShapeComboBox
            // 
            this.pAdjustRegionShapeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pAdjustRegionShapeComboBox.FormattingEnabled = true;
            this.pAdjustRegionShapeComboBox.Items.AddRange(new object[] {
            "None - Full",
            "Circle",
            "Ellipse",
            "Polygon",
            "Rectangle",
            "RectangleAffine",
            "CircularAnnulusSection",
            "EllipticalAnnulusSection"});
            this.pAdjustRegionShapeComboBox.Location = new System.Drawing.Point(89, 56);
            this.pAdjustRegionShapeComboBox.Name = "pAdjustRegionShapeComboBox";
            this.pAdjustRegionShapeComboBox.Size = new System.Drawing.Size(121, 20);
            this.pAdjustRegionShapeComboBox.TabIndex = 3;
            this.pAdjustRegionShapeComboBox.SelectedIndexChanged += new System.EventHandler(this.pAdjustRegionShapeComboBox_SelectedIndexChanged);
            // 
            // pSearchRegionBtn
            // 
            this.pSearchRegionBtn.Location = new System.Drawing.Point(8, 115);
            this.pSearchRegionBtn.Name = "pSearchRegionBtn";
            this.pSearchRegionBtn.Size = new System.Drawing.Size(75, 23);
            this.pSearchRegionBtn.TabIndex = 2;
            this.pSearchRegionBtn.Text = "검색 영역";
            this.pSearchRegionBtn.UseVisualStyleBackColor = true;
            // 
            // pRegisterBtn
            // 
            this.pRegisterBtn.Location = new System.Drawing.Point(8, 86);
            this.pRegisterBtn.Name = "pRegisterBtn";
            this.pRegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.pRegisterBtn.TabIndex = 1;
            this.pRegisterBtn.Text = "모델 등록";
            this.pRegisterBtn.UseVisualStyleBackColor = true;
            this.pRegisterBtn.Click += new System.EventHandler(this.pRegisterBtn_Click);
            // 
            // pAdjustRegionBtn
            // 
            this.pAdjustRegionBtn.Location = new System.Drawing.Point(8, 57);
            this.pAdjustRegionBtn.Name = "pAdjustRegionBtn";
            this.pAdjustRegionBtn.Size = new System.Drawing.Size(75, 23);
            this.pAdjustRegionBtn.TabIndex = 1;
            this.pAdjustRegionBtn.Text = "등록 영역";
            this.pAdjustRegionBtn.UseVisualStyleBackColor = true;
            this.pAdjustRegionBtn.Click += new System.EventHandler(this.pAdjustRegionBtn_Click);
            // 
            // pEnableChkBox
            // 
            this.pEnableChkBox.AutoSize = true;
            this.pEnableChkBox.Location = new System.Drawing.Point(8, 6);
            this.pEnableChkBox.Name = "pEnableChkBox";
            this.pEnableChkBox.Size = new System.Drawing.Size(63, 16);
            this.pEnableChkBox.TabIndex = 0;
            this.pEnableChkBox.Text = "Enable";
            this.pEnableChkBox.UseVisualStyleBackColor = true;
            this.pEnableChkBox.CheckedChanged += new System.EventHandler(this.pEanbleChkBox_CheckedChanged);
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
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 449);
            this.Controls.Add(this.toolTabControl);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
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
        private System.Windows.Forms.CheckBox pEnableChkBox;
        private System.Windows.Forms.Button pAdjustRegionBtn;
        private System.Windows.Forms.Button pSearchRegionBtn;
        private System.Windows.Forms.ComboBox pAdjustRegionShapeComboBox;
        private System.Windows.Forms.Button pRegisterBtn;
        private System.Windows.Forms.Button pImageGrabBtn;
        private System.Windows.Forms.ComboBox pSearchRegionShapeComboBox;
    }
}