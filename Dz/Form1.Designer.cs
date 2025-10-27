namespace Dz
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
            this.labelStata = new System.Windows.Forms.Label();
            this.labelSlova = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStata
            // 
            this.labelStata.AutoSize = true;
            this.labelStata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStata.Location = new System.Drawing.Point(13, 13);
            this.labelStata.Name = "labelStata";
            this.labelStata.Size = new System.Drawing.Size(468, 24);
            this.labelStata.TabIndex = 0;
            this.labelStata.Text = "Правильных слов: 0                Неправильных слов: 0";
            // 
            // labelSlova
            // 
            this.labelSlova.AutoSize = true;
            this.labelSlova.Font = new System.Drawing.Font("Montserrat Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSlova.Location = new System.Drawing.Point(296, 214);
            this.labelSlova.Name = "labelSlova";
            this.labelSlova.Size = new System.Drawing.Size(88, 30);
            this.labelSlova.TabIndex = 1;
            this.labelSlova.Text = "Слово";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.Location = new System.Drawing.Point(262, 276);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(161, 32);
            this.textBoxInput.TabIndex = 2;
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(54, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(686, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите слово выше и нажмите Enter для проверки.Следите за правильностью набора!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelSlova);
            this.Controls.Add(this.labelStata);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStata;
        private System.Windows.Forms.Label labelSlova;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label3;
    }
}

