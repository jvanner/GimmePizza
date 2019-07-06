namespace GimmePizza
{
    partial class MainForm
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
            this.listBoxFoodItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxFoodItems
            // 
            this.listBoxFoodItems.FormattingEnabled = true;
            this.listBoxFoodItems.Location = new System.Drawing.Point(12, 12);
            this.listBoxFoodItems.Name = "listBoxFoodItems";
            this.listBoxFoodItems.Size = new System.Drawing.Size(120, 95);
            this.listBoxFoodItems.TabIndex = 0;
            this.listBoxFoodItems.SelectedIndexChanged += new System.EventHandler(this.listBoxFoodItems_SelectedIndexChanged);
            this.listBoxFoodItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFoodItems_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxFoodItems);
            this.Name = "MainForm";
            this.Text = "GimmePizza";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFoodItems;
    }
}