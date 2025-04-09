namespace Enrollmenttest01
{
    partial class Formlefthand
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
            groupBoxfplefthand = new GroupBox();
            buttonbackL = new Button();
            groupBoxleftlittle = new GroupBox();
            groupBoxleftring = new GroupBox();
            groupBoxleftmiddle = new GroupBox();
            groupBoxleftindex = new GroupBox();
            groupBoxleftthumb = new GroupBox();
            buttonimgleftthumb = new Button();
            textBoxrighthandL = new TextBox();
            textBoxlefthandL = new TextBox();
            groupBoxfplefthand.SuspendLayout();
            groupBoxleftthumb.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxfplefthand
            // 
            groupBoxfplefthand.Controls.Add(buttonbackL);
            groupBoxfplefthand.Controls.Add(groupBoxleftlittle);
            groupBoxfplefthand.Controls.Add(groupBoxleftring);
            groupBoxfplefthand.Controls.Add(groupBoxleftmiddle);
            groupBoxfplefthand.Controls.Add(groupBoxleftindex);
            groupBoxfplefthand.Controls.Add(groupBoxleftthumb);
            groupBoxfplefthand.Controls.Add(textBoxrighthandL);
            groupBoxfplefthand.Controls.Add(textBoxlefthandL);
            groupBoxfplefthand.Location = new Point(12, 12);
            groupBoxfplefthand.Name = "groupBoxfplefthand";
            groupBoxfplefthand.Size = new Size(776, 426);
            groupBoxfplefthand.TabIndex = 1;
            groupBoxfplefthand.TabStop = false;
            groupBoxfplefthand.Text = "Fingerprints";
            // 
            // buttonbackL
            // 
            buttonbackL.Location = new Point(351, 372);
            buttonbackL.Name = "buttonbackL";
            buttonbackL.Size = new Size(75, 23);
            buttonbackL.TabIndex = 6;
            buttonbackL.Text = "ย้อนกลับ";
            buttonbackL.UseVisualStyleBackColor = true;
            // 
            // groupBoxleftlittle
            // 
            groupBoxleftlittle.Location = new Point(439, 225);
            groupBoxleftlittle.Name = "groupBoxleftlittle";
            groupBoxleftlittle.Size = new Size(137, 108);
            groupBoxleftlittle.TabIndex = 3;
            groupBoxleftlittle.TabStop = false;
            groupBoxleftlittle.Text = "นิ้วก้อย";
            // 
            // groupBoxleftring
            // 
            groupBoxleftring.Location = new Point(202, 225);
            groupBoxleftring.Name = "groupBoxleftring";
            groupBoxleftring.Size = new Size(137, 108);
            groupBoxleftring.TabIndex = 5;
            groupBoxleftring.TabStop = false;
            groupBoxleftring.Text = "นิ้วนาง";
            // 
            // groupBoxleftmiddle
            // 
            groupBoxleftmiddle.Location = new Point(559, 60);
            groupBoxleftmiddle.Name = "groupBoxleftmiddle";
            groupBoxleftmiddle.Size = new Size(137, 108);
            groupBoxleftmiddle.TabIndex = 4;
            groupBoxleftmiddle.TabStop = false;
            groupBoxleftmiddle.Text = "นิ้วกลาง";
            // 
            // groupBoxleftindex
            // 
            groupBoxleftindex.Location = new Point(323, 60);
            groupBoxleftindex.Name = "groupBoxleftindex";
            groupBoxleftindex.Size = new Size(137, 108);
            groupBoxleftindex.TabIndex = 3;
            groupBoxleftindex.TabStop = false;
            groupBoxleftindex.Text = "นิ้วชี้";
            // 
            // groupBoxleftthumb
            // 
            groupBoxleftthumb.Controls.Add(buttonimgleftthumb);
            groupBoxleftthumb.Location = new Point(75, 60);
            groupBoxleftthumb.Name = "groupBoxleftthumb";
            groupBoxleftthumb.Size = new Size(137, 108);
            groupBoxleftthumb.TabIndex = 2;
            groupBoxleftthumb.TabStop = false;
            groupBoxleftthumb.Text = "นิ้วโป้ง";
            // 
            // buttonimgleftthumb
            // 
            buttonimgleftthumb.ImageAlign = ContentAlignment.BottomCenter;
            buttonimgleftthumb.Location = new Point(27, 44);
            buttonimgleftthumb.Name = "buttonimgleftthumb";
            buttonimgleftthumb.Size = new Size(75, 23);
            buttonimgleftthumb.TabIndex = 0;
            buttonimgleftthumb.UseVisualStyleBackColor = true;
            // 
            // textBoxrighthandL
            // 
            textBoxrighthandL.Location = new Point(392, 22);
            textBoxrighthandL.Name = "textBoxrighthandL";
            textBoxrighthandL.Size = new Size(193, 23);
            textBoxrighthandL.TabIndex = 1;
            textBoxrighthandL.Text = "มือขวา";
            textBoxrighthandL.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxlefthandL
            // 
            textBoxlefthandL.BackColor = SystemColors.InactiveCaption;
            textBoxlefthandL.Location = new Point(202, 22);
            textBoxlefthandL.Name = "textBoxlefthandL";
            textBoxlefthandL.Size = new Size(193, 23);
            textBoxlefthandL.TabIndex = 0;
            textBoxlefthandL.Text = "มือซ้าย";
            textBoxlefthandL.TextAlign = HorizontalAlignment.Center;
            // 
            // Formlefthand
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxfplefthand);
            Name = "Formlefthand";
            Text = "Left Hand";
            groupBoxfplefthand.ResumeLayout(false);
            groupBoxfplefthand.PerformLayout();
            groupBoxleftthumb.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxfplefthand;
        private Button buttonbackL;
        private GroupBox groupBoxleftlittle;
        private GroupBox groupBoxleftring;
        private GroupBox groupBoxleftmiddle;
        private GroupBox groupBoxleftindex;
        private GroupBox groupBoxleftthumb;
        private Button buttonimgleftthumb;
        private TextBox textBoxrighthandL;
        private TextBox textBoxlefthandL;
    }
}