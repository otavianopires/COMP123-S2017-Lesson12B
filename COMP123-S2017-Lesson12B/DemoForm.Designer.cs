namespace COMP123_S2017_Lesson12B
{
    partial class DemoForm
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
            this.HelloButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.HelloLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelloButton
            // 
            this.HelloButton.Location = new System.Drawing.Point(3, 3);
            this.HelloButton.Name = "HelloButton";
            this.HelloButton.Size = new System.Drawing.Size(100, 40);
            this.HelloButton.TabIndex = 0;
            this.HelloButton.Text = "Say Hello";
            this.HelloButton.UseVisualStyleBackColor = true;
            this.HelloButton.Click += new System.EventHandler(this.HelloButton_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLabel.Location = new System.Drawing.Point(78, 76);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(168, 20);
            this.HelloLabel.TabIndex = 1;
            this.HelloLabel.Text = "Click the Button Below";
            this.HelloLabel.Click += new System.EventHandler(this.HelloLabel_Click);
            // 
            // NameTextbox
            // 
            this.NameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextbox.Location = new System.Drawing.Point(63, 145);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(183, 26);
            this.NameTextbox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(60, 127);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(63, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Enter Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.HelloButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 329);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 100);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Form";
            this.Load += new System.EventHandler(this.DemoForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HelloButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

