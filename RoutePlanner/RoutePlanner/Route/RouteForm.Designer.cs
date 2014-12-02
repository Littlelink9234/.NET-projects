namespace RoutePlanner.Route
{
    partial class RouteForm
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
            this.cmb_box_start = new System.Windows.Forms.ComboBox();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_destination = new System.Windows.Forms.Label();
            this.cmb_box_destination = new System.Windows.Forms.ComboBox();
            this.btn_findRoutes = new System.Windows.Forms.Button();
            this.txt_box_journeys = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmb_box_start
            // 
            this.cmb_box_start.FormattingEnabled = true;
            this.cmb_box_start.Location = new System.Drawing.Point(102, 30);
            this.cmb_box_start.Name = "cmb_box_start";
            this.cmb_box_start.Size = new System.Drawing.Size(121, 21);
            this.cmb_box_start.TabIndex = 0;
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(54, 33);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(32, 13);
            this.lbl_start.TabIndex = 1;
            this.lbl_start.Text = "Start:";
            // 
            // lbl_destination
            // 
            this.lbl_destination.AutoSize = true;
            this.lbl_destination.Location = new System.Drawing.Point(430, 33);
            this.lbl_destination.Name = "lbl_destination";
            this.lbl_destination.Size = new System.Drawing.Size(63, 13);
            this.lbl_destination.TabIndex = 2;
            this.lbl_destination.Text = "Destination:";
            // 
            // cmb_box_destination
            // 
            this.cmb_box_destination.FormattingEnabled = true;
            this.cmb_box_destination.Location = new System.Drawing.Point(512, 30);
            this.cmb_box_destination.Name = "cmb_box_destination";
            this.cmb_box_destination.Size = new System.Drawing.Size(133, 21);
            this.cmb_box_destination.TabIndex = 3;
            // 
            // btn_findRoutes
            // 
            this.btn_findRoutes.Location = new System.Drawing.Point(298, 77);
            this.btn_findRoutes.Name = "btn_findRoutes";
            this.btn_findRoutes.Size = new System.Drawing.Size(107, 31);
            this.btn_findRoutes.TabIndex = 5;
            this.btn_findRoutes.Text = "Find Routes!";
            this.btn_findRoutes.UseVisualStyleBackColor = true;
            this.btn_findRoutes.Click += new System.EventHandler(this.btn_findRoutes_Click);
            // 
            // txt_box_journeys
            // 
            this.txt_box_journeys.Location = new System.Drawing.Point(48, 143);
            this.txt_box_journeys.Multiline = true;
            this.txt_box_journeys.Name = "txt_box_journeys";
            this.txt_box_journeys.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_box_journeys.Size = new System.Drawing.Size(596, 210);
            this.txt_box_journeys.TabIndex = 6;
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 374);
            this.Controls.Add(this.txt_box_journeys);
            this.Controls.Add(this.btn_findRoutes);
            this.Controls.Add(this.cmb_box_destination);
            this.Controls.Add(this.lbl_destination);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.cmb_box_start);
            this.Name = "RouteForm";
            this.Text = "RouteForm";
            this.Load += new System.EventHandler(this.RouteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_box_start;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_destination;
        private System.Windows.Forms.ComboBox cmb_box_destination;
        private System.Windows.Forms.Button btn_findRoutes;
        private System.Windows.Forms.TextBox txt_box_journeys;
    }
}

