namespace Gest_EtatCivil
{
    partial class Form_printActeET
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // btn_copy
            // 
            this.btn_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy.ForeColor = System.Drawing.Color.Black;
            this.btn_copy.Location = new System.Drawing.Point(80, 18);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(93, 32);
            this.btn_copy.TabIndex = 88;
            this.btn_copy.Text = "طباعة عقد";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Année";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(983, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "رقم العقد";
            // 
            // txt_act
            // 
            this.txt_act.Location = new System.Drawing.Point(689, 28);
            this.txt_act.Name = "txt_act";
            this.txt_act.Size = new System.Drawing.Size(270, 20);
            this.txt_act.TabIndex = 85;
            // 
            // txt_annee
            // 
            this.txt_annee.Location = new System.Drawing.Point(261, 28);
            this.txt_annee.Name = "txt_annee";
            this.txt_annee.Size = new System.Drawing.Size(270, 20);
            this.txt_annee.TabIndex = 84;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(13, 56);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1315, 646);
            this.crystalReportViewer1.TabIndex = 89;
            // 
            // Form_printActeET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 705);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_act);
            this.Controls.Add(this.txt_annee);
            this.Name = "Form_printActeET";
            this.Text = "Form_printActeET";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_act;
        private System.Windows.Forms.TextBox txt_annee;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}