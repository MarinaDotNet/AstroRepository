namespace ClientApplication
{
    partial class Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rdoNightMode = new System.Windows.Forms.RadioButton();
            this.dataGridDisplay = new System.Windows.Forms.DataGridView();
            this.clmStarVelocity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStarDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKelvin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEventHorizont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbStarVelocity = new System.Windows.Forms.GroupBox();
            this.lblSTUnitsRest = new System.Windows.Forms.Label();
            this.lblSTUnitsObserved = new System.Windows.Forms.Label();
            this.lblSVRest = new System.Windows.Forms.Label();
            this.lblSVObserved = new System.Windows.Forms.Label();
            this.txtSVRest = new System.Windows.Forms.TextBox();
            this.txtSVObserved = new System.Windows.Forms.TextBox();
            this.grbStarDistance = new System.Windows.Forms.GroupBox();
            this.lblSDUnits = new System.Windows.Forms.Label();
            this.lblSDAngle = new System.Windows.Forms.Label();
            this.txtSDParallaxAngle = new System.Windows.Forms.TextBox();
            this.grbTempretureInKelvin = new System.Windows.Forms.GroupBox();
            this.lblTKUnits = new System.Windows.Forms.Label();
            this.lblTKTempreture = new System.Windows.Forms.Label();
            this.txtTKDegrees = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbEventHorizon = new System.Windows.Forms.GroupBox();
            this.cmbEHpows = new System.Windows.Forms.ComboBox();
            this.lblEHUnits2 = new System.Windows.Forms.Label();
            this.lblEHUnits1 = new System.Windows.Forms.Label();
            this.lblEHKilometers = new System.Windows.Forms.Label();
            this.txtKilometers = new System.Windows.Forms.TextBox();
            this.btnLngEnglish = new System.Windows.Forms.Button();
            this.brnLngGerman = new System.Windows.Forms.Button();
            this.btnLngFrench = new System.Windows.Forms.Button();
            this.lblLngUK = new System.Windows.Forms.Label();
            this.btnColorDialog = new System.Windows.Forms.Button();
            this.clrDialog = new System.Windows.Forms.ColorDialog();
            this.lblLngFR = new System.Windows.Forms.Label();
            this.lblLngDE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplay)).BeginInit();
            this.grbStarVelocity.SuspendLayout();
            this.grbStarDistance.SuspendLayout();
            this.grbTempretureInKelvin.SuspendLayout();
            this.grbEventHorizon.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoNightMode
            // 
            this.rdoNightMode.AutoCheck = false;
            resources.ApplyResources(this.rdoNightMode, "rdoNightMode");
            this.rdoNightMode.Checked = true;
            this.rdoNightMode.Name = "rdoNightMode";
            this.rdoNightMode.TabStop = true;
            this.rdoNightMode.UseVisualStyleBackColor = true;
            this.rdoNightMode.CheckedChanged += new System.EventHandler(this.rdoNightMode_CheckedChanged);
            this.rdoNightMode.Click += new System.EventHandler(this.rdoNightMode_Click);
            // 
            // dataGridDisplay
            // 
            this.dataGridDisplay.AllowUserToAddRows = false;
            this.dataGridDisplay.AllowUserToDeleteRows = false;
            this.dataGridDisplay.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStarVelocity,
            this.clmStarDistance,
            this.clmKelvin,
            this.clmEventHorizont});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = "n/a";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDisplay.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDisplay.EnableHeadersVisualStyles = false;
            this.dataGridDisplay.GridColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.dataGridDisplay, "dataGridDisplay");
            this.dataGridDisplay.Name = "dataGridDisplay";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "n/a";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.NullValue = "n/a";
            this.dataGridDisplay.RowsDefaultCellStyle = dataGridViewCellStyle3;
            // 
            // clmStarVelocity
            // 
            resources.ApplyResources(this.clmStarVelocity, "clmStarVelocity");
            this.clmStarVelocity.Name = "clmStarVelocity";
            this.clmStarVelocity.ReadOnly = true;
            this.clmStarVelocity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmStarDistance
            // 
            resources.ApplyResources(this.clmStarDistance, "clmStarDistance");
            this.clmStarDistance.Name = "clmStarDistance";
            this.clmStarDistance.ReadOnly = true;
            this.clmStarDistance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmKelvin
            // 
            resources.ApplyResources(this.clmKelvin, "clmKelvin");
            this.clmKelvin.Name = "clmKelvin";
            this.clmKelvin.ReadOnly = true;
            this.clmKelvin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmEventHorizont
            // 
            resources.ApplyResources(this.clmEventHorizont, "clmEventHorizont");
            this.clmEventHorizont.Name = "clmEventHorizont";
            this.clmEventHorizont.ReadOnly = true;
            this.clmEventHorizont.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grbStarVelocity
            // 
            this.grbStarVelocity.Controls.Add(this.lblSTUnitsRest);
            this.grbStarVelocity.Controls.Add(this.lblSTUnitsObserved);
            this.grbStarVelocity.Controls.Add(this.lblSVRest);
            this.grbStarVelocity.Controls.Add(this.lblSVObserved);
            this.grbStarVelocity.Controls.Add(this.txtSVRest);
            this.grbStarVelocity.Controls.Add(this.txtSVObserved);
            resources.ApplyResources(this.grbStarVelocity, "grbStarVelocity");
            this.grbStarVelocity.Name = "grbStarVelocity";
            this.grbStarVelocity.TabStop = false;
            // 
            // lblSTUnitsRest
            // 
            resources.ApplyResources(this.lblSTUnitsRest, "lblSTUnitsRest");
            this.lblSTUnitsRest.Name = "lblSTUnitsRest";
            // 
            // lblSTUnitsObserved
            // 
            resources.ApplyResources(this.lblSTUnitsObserved, "lblSTUnitsObserved");
            this.lblSTUnitsObserved.Name = "lblSTUnitsObserved";
            // 
            // lblSVRest
            // 
            resources.ApplyResources(this.lblSVRest, "lblSVRest");
            this.lblSVRest.Name = "lblSVRest";
            // 
            // lblSVObserved
            // 
            resources.ApplyResources(this.lblSVObserved, "lblSVObserved");
            this.lblSVObserved.Name = "lblSVObserved";
            // 
            // txtSVRest
            // 
            resources.ApplyResources(this.txtSVRest, "txtSVRest");
            this.txtSVRest.Name = "txtSVRest";
            this.txtSVRest.Tag = "";
            this.txtSVRest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPress);
            // 
            // txtSVObserved
            // 
            resources.ApplyResources(this.txtSVObserved, "txtSVObserved");
            this.txtSVObserved.Name = "txtSVObserved";
            this.txtSVObserved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPress);
            // 
            // grbStarDistance
            // 
            this.grbStarDistance.Controls.Add(this.lblSDUnits);
            this.grbStarDistance.Controls.Add(this.lblSDAngle);
            this.grbStarDistance.Controls.Add(this.txtSDParallaxAngle);
            resources.ApplyResources(this.grbStarDistance, "grbStarDistance");
            this.grbStarDistance.Name = "grbStarDistance";
            this.grbStarDistance.TabStop = false;
            // 
            // lblSDUnits
            // 
            resources.ApplyResources(this.lblSDUnits, "lblSDUnits");
            this.lblSDUnits.Name = "lblSDUnits";
            // 
            // lblSDAngle
            // 
            resources.ApplyResources(this.lblSDAngle, "lblSDAngle");
            this.lblSDAngle.Name = "lblSDAngle";
            // 
            // txtSDParallaxAngle
            // 
            resources.ApplyResources(this.txtSDParallaxAngle, "txtSDParallaxAngle");
            this.txtSDParallaxAngle.Name = "txtSDParallaxAngle";
            this.txtSDParallaxAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPress);
            // 
            // grbTempretureInKelvin
            // 
            this.grbTempretureInKelvin.Controls.Add(this.lblTKUnits);
            this.grbTempretureInKelvin.Controls.Add(this.lblTKTempreture);
            this.grbTempretureInKelvin.Controls.Add(this.txtTKDegrees);
            resources.ApplyResources(this.grbTempretureInKelvin, "grbTempretureInKelvin");
            this.grbTempretureInKelvin.Name = "grbTempretureInKelvin";
            this.grbTempretureInKelvin.TabStop = false;
            // 
            // lblTKUnits
            // 
            resources.ApplyResources(this.lblTKUnits, "lblTKUnits");
            this.lblTKUnits.Name = "lblTKUnits";
            // 
            // lblTKTempreture
            // 
            resources.ApplyResources(this.lblTKTempreture, "lblTKTempreture");
            this.lblTKTempreture.Name = "lblTKTempreture";
            // 
            // txtTKDegrees
            // 
            resources.ApplyResources(this.txtTKDegrees, "txtTKDegrees");
            this.txtTKDegrees.Name = "txtTKDegrees";
            this.txtTKDegrees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPress);
            this.txtTKDegrees.Leave += new System.EventHandler(this.txtTKDegrees_Leave);
            // 
            // btnCalculate
            // 
            resources.ApplyResources(this.btnCalculate, "btnCalculate");
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbEventHorizon
            // 
            this.grbEventHorizon.Controls.Add(this.cmbEHpows);
            this.grbEventHorizon.Controls.Add(this.lblEHUnits2);
            this.grbEventHorizon.Controls.Add(this.lblEHUnits1);
            this.grbEventHorizon.Controls.Add(this.lblEHKilometers);
            this.grbEventHorizon.Controls.Add(this.txtKilometers);
            resources.ApplyResources(this.grbEventHorizon, "grbEventHorizon");
            this.grbEventHorizon.Name = "grbEventHorizon";
            this.grbEventHorizon.TabStop = false;
            // 
            // cmbEHpows
            // 
            this.cmbEHpows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbEHpows, "cmbEHpows");
            this.cmbEHpows.FormattingEnabled = true;
            this.cmbEHpows.Name = "cmbEHpows";
            // 
            // lblEHUnits2
            // 
            resources.ApplyResources(this.lblEHUnits2, "lblEHUnits2");
            this.lblEHUnits2.Name = "lblEHUnits2";
            // 
            // lblEHUnits1
            // 
            resources.ApplyResources(this.lblEHUnits1, "lblEHUnits1");
            this.lblEHUnits1.Name = "lblEHUnits1";
            // 
            // lblEHKilometers
            // 
            resources.ApplyResources(this.lblEHKilometers, "lblEHKilometers");
            this.lblEHKilometers.Name = "lblEHKilometers";
            // 
            // txtKilometers
            // 
            resources.ApplyResources(this.txtKilometers, "txtKilometers");
            this.txtKilometers.Name = "txtKilometers";
            this.txtKilometers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPress);
            // 
            // btnLngEnglish
            // 
            resources.ApplyResources(this.btnLngEnglish, "btnLngEnglish");
            this.btnLngEnglish.Name = "btnLngEnglish";
            this.btnLngEnglish.UseVisualStyleBackColor = true;
            this.btnLngEnglish.Click += new System.EventHandler(this.btnLngEnglish_Click);
            // 
            // brnLngGerman
            // 
            resources.ApplyResources(this.brnLngGerman, "brnLngGerman");
            this.brnLngGerman.Name = "brnLngGerman";
            this.brnLngGerman.UseVisualStyleBackColor = true;
            this.brnLngGerman.Click += new System.EventHandler(this.brnLngGerman_Click);
            // 
            // btnLngFrench
            // 
            resources.ApplyResources(this.btnLngFrench, "btnLngFrench");
            this.btnLngFrench.Name = "btnLngFrench";
            this.btnLngFrench.TabStop = false;
            this.btnLngFrench.UseVisualStyleBackColor = true;
            this.btnLngFrench.Click += new System.EventHandler(this.btnLngFrench_Click);
            // 
            // lblLngUK
            // 
            resources.ApplyResources(this.lblLngUK, "lblLngUK");
            this.lblLngUK.Name = "lblLngUK";
            // 
            // btnColorDialog
            // 
            resources.ApplyResources(this.btnColorDialog, "btnColorDialog");
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.UseVisualStyleBackColor = true;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // clrDialog
            // 
            this.clrDialog.AnyColor = true;
            this.clrDialog.Color = System.Drawing.Color.Transparent;
            this.clrDialog.HelpRequest += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // lblLngFR
            // 
            resources.ApplyResources(this.lblLngFR, "lblLngFR");
            this.lblLngFR.Name = "lblLngFR";
            // 
            // lblLngDE
            // 
            resources.ApplyResources(this.lblLngDE, "lblLngDE");
            this.lblLngDE.Name = "lblLngDE";
            // 
            // Application
            // 
            this.AcceptButton = this.brnLngGerman;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLngDE);
            this.Controls.Add(this.lblLngFR);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnColorDialog);
            this.Controls.Add(this.lblLngUK);
            this.Controls.Add(this.btnLngFrench);
            this.Controls.Add(this.brnLngGerman);
            this.Controls.Add(this.btnLngEnglish);
            this.Controls.Add(this.grbEventHorizon);
            this.Controls.Add(this.grbTempretureInKelvin);
            this.Controls.Add(this.grbStarDistance);
            this.Controls.Add(this.grbStarVelocity);
            this.Controls.Add(this.dataGridDisplay);
            this.Controls.Add(this.rdoNightMode);
            this.KeyPreview = true;
            this.Name = "Application";
            this.Load += new System.EventHandler(this.Application_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Application_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplay)).EndInit();
            this.grbStarVelocity.ResumeLayout(false);
            this.grbStarVelocity.PerformLayout();
            this.grbStarDistance.ResumeLayout(false);
            this.grbStarDistance.PerformLayout();
            this.grbTempretureInKelvin.ResumeLayout(false);
            this.grbTempretureInKelvin.PerformLayout();
            this.grbEventHorizon.ResumeLayout(false);
            this.grbEventHorizon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoNightMode;
        private System.Windows.Forms.DataGridView dataGridDisplay;
        private System.Windows.Forms.GroupBox grbStarVelocity;
        private System.Windows.Forms.TextBox txtSVRest;
        private System.Windows.Forms.TextBox txtSVObserved;
        private System.Windows.Forms.GroupBox grbStarDistance;
        private System.Windows.Forms.TextBox txtSDParallaxAngle;
        private System.Windows.Forms.GroupBox grbTempretureInKelvin;
        private System.Windows.Forms.TextBox txtTKDegrees;
        private System.Windows.Forms.GroupBox grbEventHorizon;
        private System.Windows.Forms.TextBox txtKilometers;
        private System.Windows.Forms.Label lblSVObserved;
        private System.Windows.Forms.Label lblSTUnitsRest;
        private System.Windows.Forms.Label lblSTUnitsObserved;
        private System.Windows.Forms.Label lblSVRest;
        private System.Windows.Forms.Label lblSDUnits;
        private System.Windows.Forms.Label lblSDAngle;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTKUnits;
        private System.Windows.Forms.Label lblTKTempreture;
        private System.Windows.Forms.Label lblEHKilometers;
        private System.Windows.Forms.Label lblEHUnits1;
        private System.Windows.Forms.Button btnLngEnglish;
        private System.Windows.Forms.Button brnLngGerman;
        private System.Windows.Forms.Button btnLngFrench;
        private System.Windows.Forms.Label lblLngUK;
        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.ColorDialog clrDialog;
        private System.Windows.Forms.Label lblEHUnits2;
        private System.Windows.Forms.ComboBox cmbEHpows;
        private System.Windows.Forms.Label lblLngFR;
        private System.Windows.Forms.Label lblLngDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStarVelocity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStarDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKelvin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEventHorizont;
    }
}

