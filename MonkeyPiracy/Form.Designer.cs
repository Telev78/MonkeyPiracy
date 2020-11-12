namespace MonkeyPiracy
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxDown = new System.Windows.Forms.PictureBox();
            this.hScrollBarUp = new System.Windows.Forms.HScrollBar();
            this.hScrollBarDown = new System.Windows.Forms.HScrollBar();
            this.listView = new System.Windows.Forms.ListView();
            this.Localisation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Année = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureMixUp = new System.Windows.Forms.PictureBox();
            this.hScrollBarMixUp = new System.Windows.Forms.HScrollBar();
            this.hScrollBarMixDown = new System.Windows.Forms.HScrollBar();
            this.pictureMixDown = new System.Windows.Forms.PictureBox();
            this.listViewMix = new System.Windows.Forms.ListView();
            this.recette = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comp1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comp2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMixUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMixDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dial-A-Pirate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackgroundImage = global::MonkeyPiracy.Properties.Resources.fond;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel2.CausesValidation = false;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxUp, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxDown, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.hScrollBarUp, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.hScrollBarDown, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.listView, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(640, 400);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBoxUp
            // 
            this.pictureBoxUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxUp.Image = global::MonkeyPiracy.Properties.Resources.face_b0;
            this.pictureBoxUp.Location = new System.Drawing.Point(288, 84);
            this.pictureBoxUp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pictureBoxUp.Name = "pictureBoxUp";
            this.pictureBoxUp.Size = new System.Drawing.Size(64, 32);
            this.pictureBoxUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUp.TabIndex = 0;
            this.pictureBoxUp.TabStop = false;
            // 
            // pictureBoxDown
            // 
            this.pictureBoxDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxDown.Image = global::MonkeyPiracy.Properties.Resources.face_a0;
            this.pictureBoxDown.Location = new System.Drawing.Point(296, 116);
            this.pictureBoxDown.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pictureBoxDown.Name = "pictureBoxDown";
            this.pictureBoxDown.Size = new System.Drawing.Size(48, 24);
            this.pictureBoxDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDown.TabIndex = 1;
            this.pictureBoxDown.TabStop = false;
            // 
            // hScrollBarUp
            // 
            this.hScrollBarUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hScrollBarUp.LargeChange = 1;
            this.hScrollBarUp.Location = new System.Drawing.Point(205, 4);
            this.hScrollBarUp.Maximum = 8;
            this.hScrollBarUp.Name = "hScrollBarUp";
            this.hScrollBarUp.Size = new System.Drawing.Size(230, 16);
            this.hScrollBarUp.TabIndex = 3;
            this.hScrollBarUp.ValueChanged += new System.EventHandler(this.hScrollBarDial_ValueChanged);
            // 
            // hScrollBarDown
            // 
            this.hScrollBarDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hScrollBarDown.LargeChange = 1;
            this.hScrollBarDown.Location = new System.Drawing.Point(205, 188);
            this.hScrollBarDown.Maximum = 8;
            this.hScrollBarDown.Name = "hScrollBarDown";
            this.hScrollBarDown.Size = new System.Drawing.Size(230, 16);
            this.hScrollBarDown.TabIndex = 2;
            this.hScrollBarDown.ValueChanged += new System.EventHandler(this.hScrollBarDial_ValueChanged);
            // 
            // listView
            // 
            this.listView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Localisation,
            this.Année});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView.HideSelection = false;
            this.listView.LabelWrap = false;
            this.listView.Location = new System.Drawing.Point(241, 242);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Scrollable = false;
            this.listView.Size = new System.Drawing.Size(158, 123);
            this.listView.TabIndex = 4;
            this.listView.TabStop = false;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_ItemSelectionChanged);
            // 
            // Localisation
            // 
            this.Localisation.Text = "Localisation";
            this.Localisation.Width = 90;
            // 
            // Année
            // 
            this.Année.Text = "Année";
            this.Année.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Année.Width = 63;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mix \'N\' Mojo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackgroundImage = global::MonkeyPiracy.Properties.Resources.fond1;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureMixUp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.hScrollBarMixUp, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hScrollBarMixDown, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureMixDown, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listViewMix, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureMixUp
            // 
            this.pictureMixUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureMixUp.Location = new System.Drawing.Point(264, 29);
            this.pictureMixUp.Name = "pictureMixUp";
            this.pictureMixUp.Size = new System.Drawing.Size(112, 90);
            this.pictureMixUp.TabIndex = 0;
            this.pictureMixUp.TabStop = false;
            // 
            // hScrollBarMixUp
            // 
            this.hScrollBarMixUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hScrollBarMixUp.LargeChange = 1;
            this.hScrollBarMixUp.Location = new System.Drawing.Point(205, 3);
            this.hScrollBarMixUp.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.hScrollBarMixUp.Maximum = 13;
            this.hScrollBarMixUp.Name = "hScrollBarMixUp";
            this.hScrollBarMixUp.Size = new System.Drawing.Size(230, 16);
            this.hScrollBarMixUp.TabIndex = 2;
            this.hScrollBarMixUp.ValueChanged += new System.EventHandler(this.hScrollBarMix_ValueChanged);
            // 
            // hScrollBarMixDown
            // 
            this.hScrollBarMixDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hScrollBarMixDown.LargeChange = 1;
            this.hScrollBarMixDown.Location = new System.Drawing.Point(205, 221);
            this.hScrollBarMixDown.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.hScrollBarMixDown.Maximum = 14;
            this.hScrollBarMixDown.Name = "hScrollBarMixDown";
            this.hScrollBarMixDown.Size = new System.Drawing.Size(230, 16);
            this.hScrollBarMixDown.TabIndex = 3;
            this.hScrollBarMixDown.ValueChanged += new System.EventHandler(this.hScrollBarMix_ValueChanged);
            // 
            // pictureMixDown
            // 
            this.pictureMixDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureMixDown.Location = new System.Drawing.Point(264, 125);
            this.pictureMixDown.Name = "pictureMixDown";
            this.pictureMixDown.Size = new System.Drawing.Size(112, 90);
            this.pictureMixDown.TabIndex = 1;
            this.pictureMixDown.TabStop = false;
            // 
            // listViewMix
            // 
            this.listViewMix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listViewMix.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.recette,
            this.comp1,
            this.comp2});
            this.listViewMix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMix.FullRowSelect = true;
            this.listViewMix.GridLines = true;
            this.listViewMix.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewMix.HideSelection = false;
            this.listViewMix.LabelWrap = false;
            this.listViewMix.Location = new System.Drawing.Point(224, 247);
            this.listViewMix.MultiSelect = false;
            this.listViewMix.Name = "listViewMix";
            this.listViewMix.Scrollable = false;
            this.listViewMix.Size = new System.Drawing.Size(192, 124);
            this.listViewMix.TabIndex = 4;
            this.listViewMix.TabStop = false;
            this.listViewMix.UseCompatibleStateImageBehavior = false;
            this.listViewMix.View = System.Windows.Forms.View.Details;
            this.listViewMix.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_ItemSelectionChanged);
            // 
            // recette
            // 
            this.recette.Text = "Recette";
            this.recette.Width = 110;
            // 
            // comp1
            // 
            this.comp1.Text = "composant 1";
            this.comp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comp1.Width = 41;
            // 
            // comp2
            // 
            this.comp2.Text = "Composant 2";
            this.comp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comp2.Width = 41;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 432);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Monkey Piracy™";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMixUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMixDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxUp;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxDown;
        private System.Windows.Forms.HScrollBar hScrollBarDown;
        private System.Windows.Forms.HScrollBar hScrollBarUp;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Localisation;
        private System.Windows.Forms.ColumnHeader Année;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureMixUp;
        private System.Windows.Forms.HScrollBar hScrollBarMixUp;
        private System.Windows.Forms.HScrollBar hScrollBarMixDown;
        private System.Windows.Forms.ListView listViewMix;
        private System.Windows.Forms.PictureBox pictureMixDown;
        private System.Windows.Forms.ColumnHeader recette;
        private System.Windows.Forms.ColumnHeader comp1;
        private System.Windows.Forms.ColumnHeader comp2;
    }
}

