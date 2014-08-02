namespace fPlayer_2
{
    partial class pluginUI
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pluginUI));
            this.appTitle = new System.Windows.Forms.Label();
            this.clicktoreturnlbl = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.keytip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appTitle
            // 
            resources.ApplyResources(this.appTitle, "appTitle");
            this.appTitle.Name = "appTitle";
            this.appTitle.Click += new System.EventHandler(this.appTitle_Click);
            // 
            // clicktoreturnlbl
            // 
            resources.ApplyResources(this.clicktoreturnlbl, "clicktoreturnlbl");
            this.clicktoreturnlbl.Name = "clicktoreturnlbl";
            this.clicktoreturnlbl.Click += new System.EventHandler(this.clicktoreturnlbl_Click);
            // 
            // aboutButton
            // 
            resources.ApplyResources(this.aboutButton, "aboutButton");
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // keytip
            // 
            resources.ApplyResources(this.keytip, "keytip");
            this.keytip.Name = "keytip";
            this.keytip.Click += new System.EventHandler(this.keytip_Click);
            // 
            // pluginUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.keytip);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.clicktoreturnlbl);
            this.Controls.Add(this.appTitle);
            this.Name = "pluginUI";
            this.Load += new System.EventHandler(this.pluginUI_Load);
            this.Click += new System.EventHandler(this.pluginUI_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label appTitle;
        public System.Windows.Forms.Label clicktoreturnlbl;
        private System.Windows.Forms.Button aboutButton;
        public System.Windows.Forms.Label keytip;
    }
}
