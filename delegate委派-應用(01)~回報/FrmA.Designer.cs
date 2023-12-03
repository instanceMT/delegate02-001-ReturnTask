namespace delegate委派_應用_01__回報
{
    partial class FrmA
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
            BtnAskBForHelp = new Button();
            SuspendLayout();
            // 
            // BtnAskBForHelp
            // 
            BtnAskBForHelp.Location = new Point(346, 199);
            BtnAskBForHelp.Name = "BtnAskBForHelp";
            BtnAskBForHelp.Size = new Size(75, 23);
            BtnAskBForHelp.TabIndex = 0;
            BtnAskBForHelp.Text = "請B幫忙";
            BtnAskBForHelp.Click += BtnAskBForHelp_Click;
            // 
            // FrmA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAskBForHelp);
            Name = "FrmA";
            Text = "FrmA";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAskBForHelp;
    }
}
