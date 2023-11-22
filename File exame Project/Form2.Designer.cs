namespace File_exame_Project
{
    partial class frmChoose
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
            this.btnFootball = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnVolley = new System.Windows.Forms.Button();
            this.btnTenneis = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFootball
            // 
            this.btnFootball.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFootball.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFootball.Location = new System.Drawing.Point(1, 101);
            this.btnFootball.Name = "btnFootball";
            this.btnFootball.Size = new System.Drawing.Size(120, 42);
            this.btnFootball.TabIndex = 0;
            this.btnFootball.Text = "Foot Ball";
            this.btnFootball.UseVisualStyleBackColor = false;
            this.btnFootball.Click += new System.EventHandler(this.btnFootball_Click);
            // 
            // btnVolley
            // 
            this.btnVolley.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolley.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolley.Location = new System.Drawing.Point(1, 335);
            this.btnVolley.Name = "btnVolley";
            this.btnVolley.Size = new System.Drawing.Size(120, 42);
            this.btnVolley.TabIndex = 1;
            this.btnVolley.Text = "Creation page";
            this.btnVolley.UseVisualStyleBackColor = false;
            this.btnVolley.Click += new System.EventHandler(this.btnVolley_Click);
            // 
            // btnTenneis
            // 
            this.btnTenneis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTenneis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenneis.Location = new System.Drawing.Point(653, 101);
            this.btnTenneis.Name = "btnTenneis";
            this.btnTenneis.Size = new System.Drawing.Size(120, 42);
            this.btnTenneis.TabIndex = 2;
            this.btnTenneis.Text = "Updat Page";
            this.btnTenneis.UseVisualStyleBackColor = false;
            this.btnTenneis.Click += new System.EventHandler(this.btnTenneis_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.Location = new System.Drawing.Point(653, 325);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(120, 42);
            this.btnMember.TabIndex = 3;
            this.btnMember.Text = "Go Delete";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // frmChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::File_exame_Project.Properties.Resources.choose_page;
            this.ClientSize = new System.Drawing.Size(774, 457);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnTenneis);
            this.Controls.Add(this.btnVolley);
            this.Controls.Add(this.btnFootball);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFootball;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnVolley;
        private System.Windows.Forms.Button btnTenneis;
        private System.Windows.Forms.Button btnMember;
    }
}