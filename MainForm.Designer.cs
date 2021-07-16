
namespace PackagesCompare
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SourceControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.TargetControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.CompareButton = new DataJuggler.Win.Controls.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SourceControl
            // 
            this.SourceControl.BackColor = System.Drawing.Color.Transparent;
            this.SourceControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.SourceControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("SourceControl.ButtonImage")));
            this.SourceControl.ButtonWidth = 48;
            this.SourceControl.DarkMode = false;
            this.SourceControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.SourceControl.Editable = false;
            this.SourceControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.SourceControl.Filter = null;
            this.SourceControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceControl.HideBrowseButton = false;
            this.SourceControl.LabelBottomMargin = 0;
            this.SourceControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SourceControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SourceControl.LabelText = "Source (older):";
            this.SourceControl.LabelTopMargin = 0;
            this.SourceControl.LabelWidth = 156;
            this.SourceControl.Location = new System.Drawing.Point(54, 80);
            this.SourceControl.Margin = new System.Windows.Forms.Padding(4);
            this.SourceControl.Name = "SourceControl";
            this.SourceControl.OnTextChangedListener = null;
            this.SourceControl.OpenCallback = null;
            this.SourceControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SourceControl.SelectedPath = null;
            this.SourceControl.Size = new System.Drawing.Size(699, 34);
            this.SourceControl.StartPath = null;
            this.SourceControl.TabIndex = 0;
            this.SourceControl.TextBoxBottomMargin = 0;
            this.SourceControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.SourceControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.SourceControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceControl.TextBoxTopMargin = 0;
            this.SourceControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // TargetControl
            // 
            this.TargetControl.BackColor = System.Drawing.Color.Transparent;
            this.TargetControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.TargetControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("TargetControl.ButtonImage")));
            this.TargetControl.ButtonWidth = 48;
            this.TargetControl.DarkMode = false;
            this.TargetControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.TargetControl.Editable = false;
            this.TargetControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.TargetControl.Filter = null;
            this.TargetControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TargetControl.HideBrowseButton = false;
            this.TargetControl.LabelBottomMargin = 0;
            this.TargetControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.TargetControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TargetControl.LabelText = "Target (newer):";
            this.TargetControl.LabelTopMargin = 0;
            this.TargetControl.LabelWidth = 156;
            this.TargetControl.Location = new System.Drawing.Point(54, 140);
            this.TargetControl.Margin = new System.Windows.Forms.Padding(4);
            this.TargetControl.Name = "TargetControl";
            this.TargetControl.OnTextChangedListener = null;
            this.TargetControl.OpenCallback = null;
            this.TargetControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TargetControl.SelectedPath = null;
            this.TargetControl.Size = new System.Drawing.Size(699, 34);
            this.TargetControl.StartPath = null;
            this.TargetControl.TabIndex = 1;
            this.TargetControl.TextBoxBottomMargin = 0;
            this.TargetControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.TargetControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.TargetControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TargetControl.TextBoxTopMargin = 0;
            this.TargetControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // CompareButton
            // 
            this.CompareButton.BackColor = System.Drawing.Color.Transparent;
            this.CompareButton.ButtonText = "Compare";
            this.CompareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompareButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CompareButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CompareButton.Location = new System.Drawing.Point(617, 240);
            this.CompareButton.Margin = new System.Windows.Forms.Padding(4);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(135, 44);
            this.CompareButton.TabIndex = 2;
            this.CompareButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.TitleLabel.Location = new System.Drawing.Point(57, 30);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(690, 18);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Select Packages.config Files To Compare";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::PackagesCompare.Properties.Resources.AsphaultSmooth_Small;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 312);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CompareButton);
            this.Controls.Add(this.TargetControl);
            this.Controls.Add(this.SourceControl);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packages Compare 1.0.2";
            this.ResumeLayout(false);

        }

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl SourceControl;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl TargetControl;
        private DataJuggler.Win.Controls.Button CompareButton;
        private System.Windows.Forms.Label TitleLabel;
    }
}

