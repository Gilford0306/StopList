namespace StopList
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.button1 = new MaterialSkin.Controls.MaterialButton();
            this.button2 = new MaterialSkin.Controls.MaterialButton();
            this.button5 = new MaterialSkin.Controls.MaterialButton();
            this.bdel = new MaterialSkin.Controls.MaterialButton();
            this.button7 = new MaterialSkin.Controls.MaterialButton();
            this.button8 = new MaterialSkin.Controls.MaterialButton();
            this.textBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.button3 = new MaterialSkin.Controls.MaterialButton();
            this.button4 = new MaterialSkin.Controls.MaterialButton();
            this.button6 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(172, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Stop List";
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(423, 115);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(375, 403);
            this.listBox2.TabIndex = 18;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(28, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(375, 403);
            this.listBox1.TabIndex = 23;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(595, 76);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(28, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "Log";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(57, 575);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(32, 19);
            this.materialLabel3.TabIndex = 25;
            this.materialLabel3.Text = "New";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(28, 634);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(61, 19);
            this.materialLabel4.TabIndex = 26;
            this.materialLabel4.Text = "Selected";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button1.Depth = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(412, 565);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button1.Size = new System.Drawing.Size(64, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "ADD";
            this.button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button1.UseAccentColor = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button2.Depth = 0;
            this.button2.HighEmphasis = true;
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(412, 633);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button2.Size = new System.Drawing.Size(64, 36);
            this.button2.TabIndex = 28;
            this.button2.Text = "Save";
            this.button2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button2.UseAccentColor = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button5.Depth = 0;
            this.button5.HighEmphasis = true;
            this.button5.Icon = null;
            this.button5.Location = new System.Drawing.Point(498, 565);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button5.MouseState = MaterialSkin.MouseState.HOVER;
            this.button5.Name = "button5";
            this.button5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button5.Size = new System.Drawing.Size(119, 36);
            this.button5.TabIndex = 29;
            this.button5.Text = "ADD File pick";
            this.button5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button5.UseAccentColor = false;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // bdel
            // 
            this.bdel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bdel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bdel.Depth = 0;
            this.bdel.HighEmphasis = true;
            this.bdel.Icon = null;
            this.bdel.Location = new System.Drawing.Point(498, 633);
            this.bdel.Margin = new System.Windows.Forms.Padding(0);
            this.bdel.MouseState = MaterialSkin.MouseState.HOVER;
            this.bdel.Name = "bdel";
            this.bdel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bdel.Size = new System.Drawing.Size(118, 36);
            this.bdel.TabIndex = 30;
            this.bdel.Text = "        Deleting      ";
            this.bdel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bdel.UseAccentColor = false;
            this.bdel.UseVisualStyleBackColor = true;
            this.bdel.Click += new System.EventHandler(this.bdel_Click_1);
            // 
            // button7
            // 
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button7.Depth = 0;
            this.button7.HighEmphasis = true;
            this.button7.Icon = null;
            this.button7.Location = new System.Drawing.Point(663, 565);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button7.MouseState = MaterialSkin.MouseState.HOVER;
            this.button7.Name = "button7";
            this.button7.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button7.Size = new System.Drawing.Size(107, 36);
            this.button7.TabIndex = 31;
            this.button7.Text = "  Track App  ";
            this.button7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button7.UseAccentColor = false;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button8.Depth = 0;
            this.button8.HighEmphasis = true;
            this.button8.Icon = null;
            this.button8.Location = new System.Drawing.Point(663, 633);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button8.MouseState = MaterialSkin.MouseState.HOVER;
            this.button8.Name = "button8";
            this.button8.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button8.Size = new System.Drawing.Size(109, 36);
            this.button8.TabIndex = 32;
            this.button8.Text = "Stop Track ";
            this.button8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button8.UseAccentColor = false;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.AnimateReadOnly = false;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Depth = 0;
            this.textBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.LeadingIcon = null;
            this.textBox1.Location = new System.Drawing.Point(105, 551);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.MaxLength = 50;
            this.textBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 50);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "";
            this.textBox1.TrailingIcon = null;
            // 
            // textBox3
            // 
            this.textBox3.AnimateReadOnly = false;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Depth = 0;
            this.textBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox3.LeadingIcon = null;
            this.textBox3.Location = new System.Drawing.Point(271, 551);
            this.textBox3.MaxLength = 50;
            this.textBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox3.Multiline = false;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 50);
            this.textBox3.TabIndex = 34;
            this.textBox3.Text = "";
            this.textBox3.TrailingIcon = null;
            // 
            // textBox4
            // 
            this.textBox4.AnimateReadOnly = false;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Depth = 0;
            this.textBox4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox4.LeadingIcon = null;
            this.textBox4.Location = new System.Drawing.Point(271, 619);
            this.textBox4.MaxLength = 50;
            this.textBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox4.Multiline = false;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(89, 50);
            this.textBox4.TabIndex = 36;
            this.textBox4.Text = "";
            this.textBox4.TrailingIcon = null;
            // 
            // textBox2
            // 
            this.textBox2.AnimateReadOnly = false;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Depth = 0;
            this.textBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox2.LeadingIcon = null;
            this.textBox2.Location = new System.Drawing.Point(105, 619);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.MaxLength = 50;
            this.textBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox2.Multiline = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 50);
            this.textBox2.TabIndex = 35;
            this.textBox2.Text = "";
            this.textBox2.TrailingIcon = null;
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button3.Depth = 0;
            this.button3.HighEmphasis = true;
            this.button3.Icon = null;
            this.button3.Location = new System.Drawing.Point(293, 719);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button3.MouseState = MaterialSkin.MouseState.HOVER;
            this.button3.Name = "button3";
            this.button3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button3.Size = new System.Drawing.Size(67, 36);
            this.button3.TabIndex = 37;
            this.button3.Text = "START";
            this.button3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button3.UseAccentColor = false;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button4.Depth = 0;
            this.button4.HighEmphasis = true;
            this.button4.Icon = null;
            this.button4.Location = new System.Drawing.Point(483, 719);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button4.MouseState = MaterialSkin.MouseState.HOVER;
            this.button4.Name = "button4";
            this.button4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button4.Size = new System.Drawing.Size(64, 36);
            this.button4.TabIndex = 38;
            this.button4.Text = "Stop";
            this.button4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button4.UseAccentColor = false;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button6
            // 
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button6.Depth = 0;
            this.button6.HighEmphasis = true;
            this.button6.Icon = null;
            this.button6.Location = new System.Drawing.Point(678, 746);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button6.MouseState = MaterialSkin.MouseState.HOVER;
            this.button6.Name = "button6";
            this.button6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button6.Size = new System.Drawing.Size(120, 36);
            this.button6.TabIndex = 39;
            this.button6.Text = "Full version";
            this.button6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button6.UseAccentColor = false;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 791);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.bdel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.listBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parent control ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton button1;
        private MaterialSkin.Controls.MaterialButton button2;
        private MaterialSkin.Controls.MaterialButton button5;
        private MaterialSkin.Controls.MaterialButton bdel;
        private MaterialSkin.Controls.MaterialButton button7;
        private MaterialSkin.Controls.MaterialButton button8;
        private MaterialSkin.Controls.MaterialTextBox textBox1;
        private MaterialSkin.Controls.MaterialTextBox textBox3;
        private MaterialSkin.Controls.MaterialTextBox textBox4;
        private MaterialSkin.Controls.MaterialTextBox textBox2;
        private MaterialSkin.Controls.MaterialButton button3;
        private MaterialSkin.Controls.MaterialButton button4;
        private MaterialSkin.Controls.MaterialButton button6;
    }
}

