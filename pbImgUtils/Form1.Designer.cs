namespace pbImgUtils
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ofdImg = new System.Windows.Forms.OpenFileDialog();
            this.sfdImg = new System.Windows.Forms.SaveFileDialog();
            this.cbFontUsed = new System.Windows.Forms.ComboBox();
            this.nudImageWidth = new System.Windows.Forms.NumericUpDown();
            this.nudImageHeight = new System.Windows.Forms.NumericUpDown();
            this.tbTextToAdd = new System.Windows.Forms.TextBox();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbOneFilePerLine = new System.Windows.Forms.CheckBox();
            this.cbStrike = new System.Windows.Forms.CheckBox();
            this.cbUnderline = new System.Windows.Forms.CheckBox();
            this.cbItalic = new System.Windows.Forms.CheckBox();
            this.cbBold = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbYCenter = new System.Windows.Forms.CheckBox();
            this.cbXCenter = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFontColor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudXText = new System.Windows.Forms.NumericUpDown();
            this.nudYText = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btLoad = new System.Windows.Forms.Button();
            this.pbImgStart = new System.Windows.Forms.PictureBox();
            this.btPreview = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.pbImgResult = new System.Windows.Forms.PictureBox();
            this.cbKeepOriginalRatio = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYText)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgResult)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdImg
            // 
            this.ofdImg.DefaultExt = "png";
            this.ofdImg.FileName = "test.png";
            this.ofdImg.Filter = "image files|*.png;*.jpg;*.jpeg;*.bmp";
            this.ofdImg.RestoreDirectory = true;
            this.ofdImg.ShowHelp = true;
            this.ofdImg.Title = "Load file";
            // 
            // sfdImg
            // 
            this.sfdImg.DefaultExt = "png";
            this.sfdImg.FileName = "test.png";
            this.sfdImg.Filter = "png files|*.png";
            this.sfdImg.RestoreDirectory = true;
            this.sfdImg.ShowHelp = true;
            this.sfdImg.Title = "Save file";
            // 
            // cbFontUsed
            // 
            this.cbFontUsed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFontUsed.FormattingEnabled = true;
            this.cbFontUsed.Location = new System.Drawing.Point(156, 13);
            this.cbFontUsed.Name = "cbFontUsed";
            this.cbFontUsed.Size = new System.Drawing.Size(121, 21);
            this.cbFontUsed.TabIndex = 2;
            // 
            // nudImageWidth
            // 
            this.nudImageWidth.Location = new System.Drawing.Point(99, 19);
            this.nudImageWidth.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudImageWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudImageWidth.Name = "nudImageWidth";
            this.nudImageWidth.Size = new System.Drawing.Size(61, 20);
            this.nudImageWidth.TabIndex = 3;
            this.nudImageWidth.Value = new decimal(new int[] {
            226,
            0,
            0,
            0});
            // 
            // nudImageHeight
            // 
            this.nudImageHeight.Location = new System.Drawing.Point(216, 19);
            this.nudImageHeight.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudImageHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudImageHeight.Name = "nudImageHeight";
            this.nudImageHeight.Size = new System.Drawing.Size(61, 20);
            this.nudImageHeight.TabIndex = 4;
            this.nudImageHeight.Value = new decimal(new int[] {
            226,
            0,
            0,
            0});
            // 
            // tbTextToAdd
            // 
            this.tbTextToAdd.Location = new System.Drawing.Point(10, 157);
            this.tbTextToAdd.Multiline = true;
            this.tbTextToAdd.Name = "tbTextToAdd";
            this.tbTextToAdd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTextToAdd.Size = new System.Drawing.Size(182, 76);
            this.tbTextToAdd.TabIndex = 5;
            // 
            // nudFontSize
            // 
            this.nudFontSize.Location = new System.Drawing.Point(216, 36);
            this.nudFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(61, 20);
            this.nudFontSize.TabIndex = 6;
            this.nudFontSize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.groupBox3);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBox2);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerMain.Panel1.Controls.Add(this.btPreview);
            this.splitContainerMain.Panel1.Controls.Add(this.btSave);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.pbImgResult);
            this.splitContainerMain.Size = new System.Drawing.Size(724, 541);
            this.splitContainerMain.SplitterDistance = 300;
            this.splitContainerMain.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbOneFilePerLine);
            this.groupBox3.Controls.Add(this.cbStrike);
            this.groupBox3.Controls.Add(this.cbUnderline);
            this.groupBox3.Controls.Add(this.cbItalic);
            this.groupBox3.Controls.Add(this.cbBold);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.nudFontSize);
            this.groupBox3.Controls.Add(this.tbTextToAdd);
            this.groupBox3.Controls.Add(this.cbYCenter);
            this.groupBox3.Controls.Add(this.cbFontUsed);
            this.groupBox3.Controls.Add(this.cbXCenter);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbFontColor);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.nudXText);
            this.groupBox3.Controls.Add(this.nudYText);
            this.groupBox3.Location = new System.Drawing.Point(5, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 239);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Text";
            // 
            // cbOneFilePerLine
            // 
            this.cbOneFilePerLine.AutoSize = true;
            this.cbOneFilePerLine.Location = new System.Drawing.Point(207, 216);
            this.cbOneFilePerLine.Name = "cbOneFilePerLine";
            this.cbOneFilePerLine.Size = new System.Drawing.Size(85, 17);
            this.cbOneFilePerLine.TabIndex = 25;
            this.cbOneFilePerLine.Text = "1 file per line";
            this.cbOneFilePerLine.UseVisualStyleBackColor = true;
            // 
            // cbStrike
            // 
            this.cbStrike.AutoSize = true;
            this.cbStrike.Location = new System.Drawing.Point(244, 85);
            this.cbStrike.Name = "cbStrike";
            this.cbStrike.Size = new System.Drawing.Size(33, 17);
            this.cbStrike.TabIndex = 24;
            this.cbStrike.Text = "S";
            this.cbStrike.UseVisualStyleBackColor = true;
            // 
            // cbUnderline
            // 
            this.cbUnderline.AutoSize = true;
            this.cbUnderline.Location = new System.Drawing.Point(204, 85);
            this.cbUnderline.Name = "cbUnderline";
            this.cbUnderline.Size = new System.Drawing.Size(34, 17);
            this.cbUnderline.TabIndex = 23;
            this.cbUnderline.Text = "U";
            this.cbUnderline.UseVisualStyleBackColor = true;
            // 
            // cbItalic
            // 
            this.cbItalic.AutoSize = true;
            this.cbItalic.Location = new System.Drawing.Point(169, 85);
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.Size = new System.Drawing.Size(29, 17);
            this.cbItalic.TabIndex = 22;
            this.cbItalic.Text = "I";
            this.cbItalic.UseVisualStyleBackColor = true;
            // 
            // cbBold
            // 
            this.cbBold.AutoSize = true;
            this.cbBold.Location = new System.Drawing.Point(127, 85);
            this.cbBold.Name = "cbBold";
            this.cbBold.Size = new System.Drawing.Size(33, 17);
            this.cbBold.TabIndex = 21;
            this.cbBold.Text = "B";
            this.cbBold.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Font family:";
            // 
            // cbYCenter
            // 
            this.cbYCenter.AutoSize = true;
            this.cbYCenter.Location = new System.Drawing.Point(124, 134);
            this.cbYCenter.Name = "cbYCenter";
            this.cbYCenter.Size = new System.Drawing.Size(68, 17);
            this.cbYCenter.TabIndex = 20;
            this.cbYCenter.Text = "centered";
            this.cbYCenter.UseVisualStyleBackColor = true;
            // 
            // cbXCenter
            // 
            this.cbXCenter.AutoSize = true;
            this.cbXCenter.Location = new System.Drawing.Point(124, 106);
            this.cbXCenter.Name = "cbXCenter";
            this.cbXCenter.Size = new System.Drawing.Size(68, 17);
            this.cbXCenter.TabIndex = 19;
            this.cbXCenter.Text = "centered";
            this.cbXCenter.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Font size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Y position:";
            // 
            // cbFontColor
            // 
            this.cbFontColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFontColor.FormattingEnabled = true;
            this.cbFontColor.Location = new System.Drawing.Point(156, 58);
            this.cbFontColor.Name = "cbFontColor";
            this.cbFontColor.Size = new System.Drawing.Size(121, 21);
            this.cbFontColor.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "X position:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Font color:";
            // 
            // nudXText
            // 
            this.nudXText.Location = new System.Drawing.Point(216, 105);
            this.nudXText.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudXText.Name = "nudXText";
            this.nudXText.Size = new System.Drawing.Size(61, 20);
            this.nudXText.TabIndex = 15;
            // 
            // nudYText
            // 
            this.nudYText.Location = new System.Drawing.Point(216, 133);
            this.nudYText.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudYText.Name = "nudYText";
            this.nudYText.Size = new System.Drawing.Size(61, 20);
            this.nudYText.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbKeepOriginalRatio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudImageHeight);
            this.groupBox2.Controls.Add(this.nudImageWidth);
            this.groupBox2.Location = new System.Drawing.Point(5, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 76);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Picture Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Size:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLoad);
            this.groupBox1.Controls.Add(this.pbImgStart);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 179);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load picture";
            // 
            // btLoad
            // 
            this.btLoad.Image = global::pbImgUtils.Properties.Resources.folder_yellow_open;
            this.btLoad.Location = new System.Drawing.Point(177, 19);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(100, 23);
            this.btLoad.TabIndex = 0;
            this.btLoad.Text = "Load";
            this.btLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // pbImgStart
            // 
            this.pbImgStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImgStart.Location = new System.Drawing.Point(10, 19);
            this.pbImgStart.Name = "pbImgStart";
            this.pbImgStart.Size = new System.Drawing.Size(150, 150);
            this.pbImgStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImgStart.TabIndex = 7;
            this.pbImgStart.TabStop = false;
            this.pbImgStart.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbImgStart_DragDrop);
            this.pbImgStart.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbImgStart_DragEnter);
            // 
            // btPreview
            // 
            this.btPreview.Enabled = false;
            this.btPreview.Image = global::pbImgUtils.Properties.Resources.view_preview;
            this.btPreview.Location = new System.Drawing.Point(197, 515);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(100, 23);
            this.btPreview.TabIndex = 14;
            this.btPreview.Text = "Preview";
            this.btPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPreview.UseVisualStyleBackColor = true;
            this.btPreview.Click += new System.EventHandler(this.btPreview_Click);
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.Image = global::pbImgUtils.Properties.Resources.document_save_5;
            this.btSave.Location = new System.Drawing.Point(5, 515);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 23);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // pbImgResult
            // 
            this.pbImgResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImgResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImgResult.Location = new System.Drawing.Point(0, 0);
            this.pbImgResult.Name = "pbImgResult";
            this.pbImgResult.Size = new System.Drawing.Size(420, 541);
            this.pbImgResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImgResult.TabIndex = 8;
            this.pbImgResult.TabStop = false;
            // 
            // cbKeepOriginalRatio
            // 
            this.cbKeepOriginalRatio.AutoSize = true;
            this.cbKeepOriginalRatio.Location = new System.Drawing.Point(10, 53);
            this.cbKeepOriginalRatio.Name = "cbKeepOriginalRatio";
            this.cbKeepOriginalRatio.Size = new System.Drawing.Size(145, 17);
            this.cbKeepOriginalRatio.TabIndex = 10;
            this.cbKeepOriginalRatio.Text = "Keep original aspect ratio";
            this.cbKeepOriginalRatio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 541);
            this.Controls.Add(this.splitContainerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 580);
            this.MinimumSize = new System.Drawing.Size(580, 580);
            this.Name = "Form1";
            this.Text = "pbImgUtils";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudImageWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYText)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImgStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdImg;
        private System.Windows.Forms.SaveFileDialog sfdImg;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ComboBox cbFontUsed;
        private System.Windows.Forms.NumericUpDown nudImageWidth;
        private System.Windows.Forms.NumericUpDown nudImageHeight;
        private System.Windows.Forms.TextBox tbTextToAdd;
        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.PictureBox pbImgStart;
        private System.Windows.Forms.PictureBox pbImgResult;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudXText;
        private System.Windows.Forms.NumericUpDown nudYText;
        private System.Windows.Forms.Button btPreview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFontColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbYCenter;
        private System.Windows.Forms.CheckBox cbXCenter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbOneFilePerLine;
        private System.Windows.Forms.CheckBox cbStrike;
        private System.Windows.Forms.CheckBox cbUnderline;
        private System.Windows.Forms.CheckBox cbItalic;
        private System.Windows.Forms.CheckBox cbBold;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbKeepOriginalRatio;
    }
}

