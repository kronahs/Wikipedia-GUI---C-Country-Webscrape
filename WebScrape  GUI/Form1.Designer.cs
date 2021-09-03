
namespace WebScrape__GUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCovid = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnTheme = new System.Windows.Forms.Button();
            this.pnlCustom = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.pnlCustom.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 24);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGo.Location = new System.Drawing.Point(308, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(59, 31);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WebScrape__GUI.Properties.Resources.Wikipedia_logo_v2_svg;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.openWiki);
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(13, 127);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(163, 117);
            this.pbxImage.TabIndex = 6;
            this.pbxImage.TabStop = false;
            // 
            // lblCovid
            // 
            this.lblCovid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCovid.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCovid.Location = new System.Drawing.Point(13, 284);
            this.lblCovid.Multiline = true;
            this.lblCovid.Name = "lblCovid";
            this.lblCovid.ReadOnly = true;
            this.lblCovid.Size = new System.Drawing.Size(163, 107);
            this.lblCovid.TabIndex = 8;
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(206, 107);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.ReadOnly = true;
            this.lblOutput.Size = new System.Drawing.Size(372, 284);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.Text = "";
            // 
            // btnTheme
            // 
            this.btnTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTheme.Location = new System.Drawing.Point(599, 360);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(38, 31);
            this.btnTheme.TabIndex = 10;
            this.btnTheme.Text = "B";
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // pnlCustom
            // 
            this.pnlCustom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustom.Controls.Add(this.panel2);
            this.pnlCustom.Controls.Add(this.txtSearch);
            this.pnlCustom.Controls.Add(this.btnGo);
            this.pnlCustom.Location = new System.Drawing.Point(206, 25);
            this.pnlCustom.Name = "pnlCustom";
            this.pnlCustom.Size = new System.Drawing.Size(372, 39);
            this.pnlCustom.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(12, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 3);
            this.panel2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(649, 413);
            this.Controls.Add(this.pnlCustom);
            this.Controls.Add(this.btnTheme);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblCovid);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Wikipedia ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.pnlCustom.ResumeLayout(false);
            this.pnlCustom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox lblCovid;
        private System.Windows.Forms.RichTextBox lblOutput;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.Panel pnlCustom;
        private System.Windows.Forms.Panel panel2;
    }
}

