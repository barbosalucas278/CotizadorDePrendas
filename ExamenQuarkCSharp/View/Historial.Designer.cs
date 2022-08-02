
namespace ExamenQuarkCSharp.View
{
    partial class Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.TextBoxList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxList
            // 
            this.TextBoxList.Location = new System.Drawing.Point(8, 12);
            this.TextBoxList.Multiline = true;
            this.TextBoxList.Name = "TextBoxList";
            this.TextBoxList.ReadOnly = true;
            this.TextBoxList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxList.Size = new System.Drawing.Size(391, 468);
            this.TextBoxList.TabIndex = 0;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 491);
            this.Controls.Add(this.TextBoxList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxList;
    }
}