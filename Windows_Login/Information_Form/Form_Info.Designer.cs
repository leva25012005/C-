namespace Information_Form
{
    partial class Form_Info
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Day = new System.Windows.Forms.TextBox();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_SInfo = new System.Windows.Forms.Button();
            this.txt_Month = new System.Windows.Forms.TextBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.btn_GotoShop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(251, 65);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(215, 39);
            this.txt_Name.TabIndex = 0;
            // 
            // txt_Day
            // 
            this.txt_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Day.Location = new System.Drawing.Point(251, 142);
            this.txt_Day.Name = "txt_Day";
            this.txt_Day.Size = new System.Drawing.Size(100, 39);
            this.txt_Day.TabIndex = 1;
            // 
            // txt_Rate
            // 
            this.txt_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Rate.Location = new System.Drawing.Point(251, 239);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(100, 39);
            this.txt_Rate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date of Birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rate:";
            // 
            // bt_SInfo
            // 
            this.bt_SInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SInfo.Location = new System.Drawing.Point(150, 346);
            this.bt_SInfo.Name = "bt_SInfo";
            this.bt_SInfo.Size = new System.Drawing.Size(182, 58);
            this.bt_SInfo.TabIndex = 7;
            this.bt_SInfo.Text = "Information";
            this.bt_SInfo.UseVisualStyleBackColor = true;
            this.bt_SInfo.Click += new System.EventHandler(this.bt_SInfo_Click);
            // 
            // txt_Month
            // 
            this.txt_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Month.Location = new System.Drawing.Point(388, 142);
            this.txt_Month.Name = "txt_Month";
            this.txt_Month.Size = new System.Drawing.Size(100, 39);
            this.txt_Month.TabIndex = 9;
            // 
            // txt_Year
            // 
            this.txt_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Year.Location = new System.Drawing.Point(520, 142);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(100, 39);
            this.txt_Year.TabIndex = 10;
            // 
            // btn_GotoShop
            // 
            this.btn_GotoShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GotoShop.Location = new System.Drawing.Point(388, 346);
            this.btn_GotoShop.Name = "btn_GotoShop";
            this.btn_GotoShop.Size = new System.Drawing.Size(182, 58);
            this.btn_GotoShop.TabIndex = 11;
            this.btn_GotoShop.Text = "Goto Shop";
            this.btn_GotoShop.UseVisualStyleBackColor = true;
            this.btn_GotoShop.Click += new System.EventHandler(this.btn_GotoShop_Click);
            // 
            // Form_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_GotoShop);
            this.Controls.Add(this.txt_Year);
            this.Controls.Add(this.txt_Month);
            this.Controls.Add(this.bt_SInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Rate);
            this.Controls.Add(this.txt_Day);
            this.Controls.Add(this.txt_Name);
            this.Name = "Form_Info";
            this.Text = "INFORMATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Day;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_SInfo;
        private System.Windows.Forms.TextBox txt_Month;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.Button btn_GotoShop;
    }
}

