namespace QuizMilionaire
{
    partial class Milionaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Milionaire));
            this.question_box = new System.Windows.Forms.Label();
            this.btn_option_C = new System.Windows.Forms.Button();
            this.btn_option_D = new System.Windows.Forms.Button();
            this.btn_option_B = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_option_A = new System.Windows.Forms.Button();
            this.btn_validate = new System.Windows.Forms.Button();
            this.right_banner = new System.Windows.Forms.PictureBox();
            this.bottom_banner = new System.Windows.Forms.PictureBox();
            this.marker = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.right_banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom_banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marker)).BeginInit();
            this.SuspendLayout();
            // 
            // question_box
            // 
            this.question_box.AutoSize = true;
            this.question_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(111)))));
            this.question_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_box.ForeColor = System.Drawing.Color.Yellow;
            this.question_box.Location = new System.Drawing.Point(131, 295);
            this.question_box.Name = "question_box";
            this.question_box.Size = new System.Drawing.Size(0, 25);
            this.question_box.TabIndex = 12;
            // 
            // btn_option_C
            // 
            this.btn_option_C.BackColor = System.Drawing.Color.Transparent;
            this.btn_option_C.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_option_C.BackgroundImage")));
            this.btn_option_C.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_option_C.FlatAppearance.BorderSize = 0;
            this.btn_option_C.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_option_C.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_option_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_option_C.ForeColor = System.Drawing.Color.White;
            this.btn_option_C.Location = new System.Drawing.Point(71, 428);
            this.btn_option_C.Name = "btn_option_C";
            this.btn_option_C.Size = new System.Drawing.Size(348, 51);
            this.btn_option_C.TabIndex = 11;
            this.btn_option_C.TabStop = false;
            this.btn_option_C.UseVisualStyleBackColor = false;
            this.btn_option_C.Click += new System.EventHandler(this.btn_option_C_Click);
            // 
            // btn_option_D
            // 
            this.btn_option_D.BackColor = System.Drawing.Color.Transparent;
            this.btn_option_D.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_option_D.BackgroundImage")));
            this.btn_option_D.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_option_D.FlatAppearance.BorderSize = 0;
            this.btn_option_D.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_option_D.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_option_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_option_D.ForeColor = System.Drawing.Color.White;
            this.btn_option_D.Location = new System.Drawing.Point(420, 428);
            this.btn_option_D.Name = "btn_option_D";
            this.btn_option_D.Size = new System.Drawing.Size(348, 51);
            this.btn_option_D.TabIndex = 10;
            this.btn_option_D.TabStop = false;
            this.btn_option_D.UseVisualStyleBackColor = false;
            this.btn_option_D.Click += new System.EventHandler(this.btn_option_D_Click);
            // 
            // btn_option_B
            // 
            this.btn_option_B.BackColor = System.Drawing.Color.Transparent;
            this.btn_option_B.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_option_B.BackgroundImage")));
            this.btn_option_B.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_option_B.FlatAppearance.BorderSize = 0;
            this.btn_option_B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_option_B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_option_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_option_B.ForeColor = System.Drawing.Color.White;
            this.btn_option_B.Location = new System.Drawing.Point(420, 376);
            this.btn_option_B.Name = "btn_option_B";
            this.btn_option_B.Size = new System.Drawing.Size(348, 51);
            this.btn_option_B.TabIndex = 9;
            this.btn_option_B.TabStop = false;
            this.btn_option_B.UseVisualStyleBackColor = false;
            this.btn_option_B.Click += new System.EventHandler(this.btn_option_B_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackgroundImage = global::QuizMilionaire.Properties.Resources.button;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(721, 526);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(100, 50);
            this.btn_start.TabIndex = 7;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_option_A
            // 
            this.btn_option_A.BackColor = System.Drawing.Color.Transparent;
            this.btn_option_A.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_option_A.BackgroundImage")));
            this.btn_option_A.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_option_A.FlatAppearance.BorderSize = 0;
            this.btn_option_A.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_option_A.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_option_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_option_A.ForeColor = System.Drawing.Color.White;
            this.btn_option_A.Location = new System.Drawing.Point(71, 376);
            this.btn_option_A.Name = "btn_option_A";
            this.btn_option_A.Size = new System.Drawing.Size(348, 51);
            this.btn_option_A.TabIndex = 8;
            this.btn_option_A.TabStop = false;
            this.btn_option_A.UseVisualStyleBackColor = false;
            this.btn_option_A.Click += new System.EventHandler(this.btn_option_A_Click);
            // 
            // btn_validate
            // 
            this.btn_validate.BackgroundImage = global::QuizMilionaire.Properties.Resources.button_back;
            this.btn_validate.FlatAppearance.BorderSize = 0;
            this.btn_validate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_validate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_validate.ForeColor = System.Drawing.Color.White;
            this.btn_validate.Location = new System.Drawing.Point(615, 526);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(100, 50);
            this.btn_validate.TabIndex = 2;
            this.btn_validate.Text = "VALIDATE";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // right_banner
            // 
            this.right_banner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("right_banner.BackgroundImage")));
            this.right_banner.Location = new System.Drawing.Point(849, 0);
            this.right_banner.Name = "right_banner";
            this.right_banner.Size = new System.Drawing.Size(300, 600);
            this.right_banner.TabIndex = 1;
            this.right_banner.TabStop = false;
            // 
            // bottom_banner
            // 
            this.bottom_banner.BackColor = System.Drawing.Color.Transparent;
            this.bottom_banner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottom_banner.BackgroundImage")));
            this.bottom_banner.Location = new System.Drawing.Point(1, 190);
            this.bottom_banner.Name = "bottom_banner";
            this.bottom_banner.Size = new System.Drawing.Size(850, 300);
            this.bottom_banner.TabIndex = 0;
            this.bottom_banner.TabStop = false;
            // 
            // marker
            // 
            this.marker.Image = global::QuizMilionaire.Properties.Resources.mark;
            this.marker.Location = new System.Drawing.Point(861, 548);
            this.marker.Name = "marker";
            this.marker.Size = new System.Drawing.Size(38, 38);
            this.marker.TabIndex = 0;
            this.marker.TabStop = false;
            // 
            // Milionaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1147, 598);
            this.Controls.Add(this.marker);
            this.Controls.Add(this.question_box);
            this.Controls.Add(this.btn_option_C);
            this.Controls.Add(this.btn_option_D);
            this.Controls.Add(this.btn_option_B);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_option_A);
            this.Controls.Add(this.btn_validate);
            this.Controls.Add(this.right_banner);
            this.Controls.Add(this.bottom_banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Milionaire";
            this.Text = "Milionaire";
            ((System.ComponentModel.ISupportInitialize)(this.right_banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom_banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.PictureBox bottom_banner;
        private System.Windows.Forms.PictureBox right_banner;
        private System.Windows.Forms.Button btn_validate;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_option_A;
        private System.Windows.Forms.Button btn_option_B;
        private System.Windows.Forms.Button btn_option_C;
        private System.Windows.Forms.Button btn_option_D;
        private System.Windows.Forms.Label question_box;
        private System.Windows.Forms.PictureBox marker;
    }
}