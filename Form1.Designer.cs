namespace task1_gui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtPenny = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPenny
            // 
            this.txtPenny.Location = new System.Drawing.Point(12, 12);
            this.txtPenny.Name = "txtPenny";
            this.txtPenny.Size = new System.Drawing.Size(173, 27);
            this.txtPenny.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите количество копеек";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 78);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPenny);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Валютный калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox txtPenny;
        private Label label1;
    }
}