namespace Rent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.txtFloors = new System.Windows.Forms.TextBox();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.btnCalculateRooms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Floor Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Rooms";
            // 
            // lblRent
            // 
            this.lblRent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRent.Location = new System.Drawing.Point(59, 166);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(250, 94);
            this.lblRent.TabIndex = 2;
            // 
            // txtFloors
            // 
            this.txtFloors.Location = new System.Drawing.Point(124, 26);
            this.txtFloors.Name = "txtFloors";
            this.txtFloors.Size = new System.Drawing.Size(100, 20);
            this.txtFloors.TabIndex = 3;
            // 
            // txtRooms
            // 
            this.txtRooms.Location = new System.Drawing.Point(130, 73);
            this.txtRooms.Name = "txtRooms";
            this.txtRooms.Size = new System.Drawing.Size(100, 20);
            this.txtRooms.TabIndex = 4;
            // 
            // btnCalculateRooms
            // 
            this.btnCalculateRooms.Location = new System.Drawing.Point(155, 120);
            this.btnCalculateRooms.Name = "btnCalculateRooms";
            this.btnCalculateRooms.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateRooms.TabIndex = 5;
            this.btnCalculateRooms.Text = "Calculate";
            this.btnCalculateRooms.UseVisualStyleBackColor = true;
            this.btnCalculateRooms.Click += new System.EventHandler(this.btnCalculateRooms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 377);
            this.Controls.Add(this.btnCalculateRooms);
            this.Controls.Add(this.txtRooms);
            this.Controls.Add(this.txtFloors);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RentPrices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.TextBox txtFloors;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.Button btnCalculateRooms;
    }
}

