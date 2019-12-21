using WindowsFormsApp1.Presenter;

namespace WindowsFormsApp1
{
    partial class CustomerManager
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(506, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 67);
            this.button3.TabIndex = 10;
            this.button3.Text = "Принять заказ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(104, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 67);
            this.button1.TabIndex = 8;
            this.button1.Text = "Проверить состояние";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // checkedListBox1
            // 
            if (new CustomerManagerPresenter(this).GetDataOfOrders() != null)
            {
                this.checkedListBox1.BackColor = System.Drawing.SystemColors.Menu;
                this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.checkedListBox1.CheckOnClick = true;
                this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.checkedListBox1.FormattingEnabled = true;
                this.checkedListBox1.Items.AddRange(new CustomerManagerPresenter(this).GetDataOfOrders());
                this.checkedListBox1.Location = new System.Drawing.Point(0, 1);
                this.checkedListBox1.Name = "checkedListBox1";
                this.checkedListBox1.Size = new System.Drawing.Size(500, 234);
                this.checkedListBox1.TabIndex = 7;
                this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            }
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(506, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 95);
            this.button4.TabIndex = 11;
            this.button4.Text = "Ответить на вопросы по заказу";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // CustomerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 388);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "CustomerManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер по работе с клиентами";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button4;
    }
}