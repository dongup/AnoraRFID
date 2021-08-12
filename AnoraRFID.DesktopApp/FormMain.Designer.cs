
namespace AnoraRFID.DesktopApp
{
    partial class FormMain
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
            this.tabHome = new System.Windows.Forms.TabControl();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.tabProductIn = new System.Windows.Forms.TabPage();
            this.tabHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.tabProductIn);
            this.tabHome.Controls.Add(this.tabConfig);
            this.tabHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHome.ItemSize = new System.Drawing.Size(136, 36);
            this.tabHome.Location = new System.Drawing.Point(0, 0);
            this.tabHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabHome.Name = "tabHome";
            this.tabHome.SelectedIndex = 0;
            this.tabHome.Size = new System.Drawing.Size(1037, 644);
            this.tabHome.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabHome.TabIndex = 0;
            // 
            // tabConfig
            // 
            this.tabConfig.Location = new System.Drawing.Point(4, 40);
            this.tabConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabConfig.Size = new System.Drawing.Size(1029, 600);
            this.tabConfig.TabIndex = 0;
            this.tabConfig.Text = "CONFIG";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // tabProductIn
            // 
            this.tabProductIn.Location = new System.Drawing.Point(4, 40);
            this.tabProductIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabProductIn.Name = "tabProductIn";
            this.tabProductIn.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabProductIn.Size = new System.Drawing.Size(1029, 600);
            this.tabProductIn.TabIndex = 1;
            this.tabProductIn.Text = "PRODUCT IN";
            this.tabProductIn.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 644);
            this.Controls.Add(this.tabHome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabHome;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.TabPage tabProductIn;
    }
}