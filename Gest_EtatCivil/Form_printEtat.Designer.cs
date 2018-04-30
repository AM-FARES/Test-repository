namespace Gest_EtatCivil
{
    partial class Form_printEtat
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
            this.btn_copy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_act = new System.Windows.Forms.TextBox();
            this.txt_annee = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_copy
            // 
            this.btn_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy.ForeColor = System.Drawing.Color.Black;
            this.btn_copy.Location = new System.Drawing.Point(93, 103);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(270, 50);
            this.btn_copy.TabIndex = 81;
            this.btn_copy.Text = "طباعة نسخة كاملة";
            this.btn_copy.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Année";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(815, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "رقم العقد";
            // 
            // txt_act
            // 
            this.txt_act.Location = new System.Drawing.Point(521, 63);
            this.txt_act.Name = "txt_act";
            this.txt_act.Size = new System.Drawing.Size(270, 20);
            this.txt_act.TabIndex = 78;
            // 
            // txt_annee
            // 
            this.txt_annee.Location = new System.Drawing.Point(93, 63);
            this.txt_annee.Name = "txt_annee";
            this.txt_annee.Size = new System.Drawing.Size(270, 20);
            this.txt_annee.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(521, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 50);
            this.button1.TabIndex = 82;
            this.button1.Text = "الرجوع الى القائمة ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_printEtat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 185);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_act);
            this.Controls.Add(this.txt_annee);
            this.Name = "Form_printEtat";
            this.Text = "Form_printEtat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_act;
        private System.Windows.Forms.TextBox txt_annee;
        private System.Windows.Forms.Button button1;
    }
}