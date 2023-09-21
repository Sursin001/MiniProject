namespace MiniProject
{
    partial class SampleView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleView));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            label2 = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            SuspendLayout();
            // 
            // tbSearch
            // 
            tbSearch.BorderRadius = 10;
            tbSearch.CustomizableEdges = customizableEdges1;
            tbSearch.DefaultText = "Search Here";
            tbSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearch.IconLeft = (Image)resources.GetObject("tbSearch.IconLeft");
            tbSearch.IconLeftOffset = new Point(10, 0);
            tbSearch.Location = new Point(1091, 102);
            tbSearch.Name = "tbSearch";
            tbSearch.PasswordChar = '\0';
            tbSearch.PlaceholderText = "";
            tbSearch.SelectedText = "";
            tbSearch.SelectionStart = 11;
            tbSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbSearch.Size = new Size(268, 39);
            tbSearch.TabIndex = 0;
            tbSearch.TextOffset = new Point(15, 0);
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1000, 102);
            label1.Name = "label1";
            label1.Size = new Size(85, 31);
            label1.TabIndex = 1;
            label1.Text = "Search";
            // 
            // btnAdd
            // 
            btnAdd.CheckedState.ImageSize = new Size(64, 64);
            btnAdd.HoverState.ImageSize = new Size(64, 64);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageOffset = new Point(0, 0);
            btnAdd.ImageRotate = 0F;
            btnAdd.ImageSize = new Size(40, 40);
            btnAdd.Location = new Point(60, 102);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedState.ImageSize = new Size(64, 64);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnAdd.Size = new Size(65, 54);
            btnAdd.TabIndex = 2;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 68);
            label2.Name = "label2";
            label2.Size = new Size(137, 31);
            label2.TabIndex = 3;
            label2.Text = "Header Text";
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(31, 167);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1359, 10);
            guna2Separator1.TabIndex = 4;
            // 
            // SampleView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1398, 764);
            Controls.Add(guna2Separator1);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(tbSearch);
            Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "SampleView";
            Text = "SampleView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}