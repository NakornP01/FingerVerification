namespace Enrollmenttest01
{
    partial class Formrighthand
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
            groupBoxfprighthand = new GroupBox();
            buttonbackR = new Button();
            groupBoxrightlittle = new GroupBox();
            groupBoxrightring = new GroupBox();
            groupBoxrightmiddle = new GroupBox();
            groupBoxrightindex = new GroupBox();
            groupBoxrightthumb = new GroupBox();
            button1 = new Button();
            textBoxrighthandR = new TextBox();
            textBoxlefthandR = new TextBox();
            groupBoxfprighthand.SuspendLayout();
            groupBoxrightthumb.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxfprighthand
            // 
            groupBoxfprighthand.Controls.Add(buttonbackR);
            groupBoxfprighthand.Controls.Add(groupBoxrightlittle);
            groupBoxfprighthand.Controls.Add(groupBoxrightring);
            groupBoxfprighthand.Controls.Add(groupBoxrightmiddle);
            groupBoxfprighthand.Controls.Add(groupBoxrightindex);
            groupBoxfprighthand.Controls.Add(groupBoxrightthumb);
            groupBoxfprighthand.Controls.Add(textBoxrighthandR);
            groupBoxfprighthand.Controls.Add(textBoxlefthandR);
            groupBoxfprighthand.Location = new Point(12, 12);
            groupBoxfprighthand.Name = "groupBoxfprighthand";
            groupBoxfprighthand.Size = new Size(776, 426);
            groupBoxfprighthand.TabIndex = 1;
            groupBoxfprighthand.TabStop = false;
            groupBoxfprighthand.Text = "Fingerprints";
            // 
            // buttonbackR
            // 
            buttonbackR.Location = new Point(351, 372);
            buttonbackR.Name = "buttonbackR";
            buttonbackR.Size = new Size(75, 23);
            buttonbackR.TabIndex = 6;
            buttonbackR.Text = "ย้อนกลับ";
            buttonbackR.UseVisualStyleBackColor = true;
            // 
            // groupBoxrightlittle
            // 
            groupBoxrightlittle.Location = new Point(439, 225);
            groupBoxrightlittle.Name = "groupBoxrightlittle";
            groupBoxrightlittle.Size = new Size(137, 108);
            groupBoxrightlittle.TabIndex = 3;
            groupBoxrightlittle.TabStop = false;
            groupBoxrightlittle.Text = "นิ้วก้อย";
            // 
            // groupBoxrightring
            // 
            groupBoxrightring.Location = new Point(202, 225);
            groupBoxrightring.Name = "groupBoxrightring";
            groupBoxrightring.Size = new Size(137, 108);
            groupBoxrightring.TabIndex = 5;
            groupBoxrightring.TabStop = false;
            groupBoxrightring.Text = "นิ้วนาง";
            // 
            // groupBoxrightmiddle
            // 
            groupBoxrightmiddle.Location = new Point(559, 60);
            groupBoxrightmiddle.Name = "groupBoxrightmiddle";
            groupBoxrightmiddle.Size = new Size(137, 108);
            groupBoxrightmiddle.TabIndex = 4;
            groupBoxrightmiddle.TabStop = false;
            groupBoxrightmiddle.Text = "นิ้วกลาง";
            // 
            // groupBoxrightindex
            // 
            groupBoxrightindex.Location = new Point(323, 60);
            groupBoxrightindex.Name = "groupBoxrightindex";
            groupBoxrightindex.Size = new Size(137, 108);
            groupBoxrightindex.TabIndex = 3;
            groupBoxrightindex.TabStop = false;
            groupBoxrightindex.Text = "นิ้วชี้";
            // 
            // groupBoxrightthumb
            // 
            groupBoxrightthumb.Controls.Add(button1);
            groupBoxrightthumb.Location = new Point(75, 60);
            groupBoxrightthumb.Name = "groupBoxrightthumb";
            groupBoxrightthumb.Size = new Size(137, 108);
            groupBoxrightthumb.TabIndex = 2;
            groupBoxrightthumb.TabStop = false;
            groupBoxrightthumb.Text = "นิ้วโป้ง";
            // 
            // button1
            // 
            button1.Location = new Point(27, 44);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxrighthandR
            // 
            textBoxrighthandR.BackColor = SystemColors.ActiveCaption;
            textBoxrighthandR.Location = new Point(392, 22);
            textBoxrighthandR.Name = "textBoxrighthandR";
            textBoxrighthandR.Size = new Size(193, 23);
            textBoxrighthandR.TabIndex = 1;
            textBoxrighthandR.Text = "มือขวา";
            textBoxrighthandR.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxlefthandR
            // 
            textBoxlefthandR.Location = new Point(202, 22);
            textBoxlefthandR.Name = "textBoxlefthandR";
            textBoxlefthandR.Size = new Size(193, 23);
            textBoxlefthandR.TabIndex = 0;
            textBoxlefthandR.Text = "มือซ้าย";
            textBoxlefthandR.TextAlign = HorizontalAlignment.Center;
            // 
            // Formrighthand
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxfprighthand);
            Name = "Formrighthand";
            Text = "Right Hand";
            groupBoxfprighthand.ResumeLayout(false);
            groupBoxfprighthand.PerformLayout();
            groupBoxrightthumb.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxfprighthand;
        private Button buttonbackR;
        private GroupBox groupBoxrightlittle;
        private GroupBox groupBoxrightring;
        private GroupBox groupBoxrightmiddle;
        private GroupBox groupBoxrightindex;
        private GroupBox groupBoxrightthumb;
        private Button button1;
        private TextBox textBoxrighthandR;
        private TextBox textBoxlefthandR;
    }
}