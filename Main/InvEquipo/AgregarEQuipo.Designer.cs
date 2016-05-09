namespace Main.InvEquipo
{
    partial class AgregarEQuipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEQuipo));
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEquipo.Image")));
            this.btnAgregarEquipo.Location = new System.Drawing.Point(22, 266);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(38, 39);
            this.btnAgregarEquipo.TabIndex = 0;
            this.btnAgregarEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarEquipo.UseVisualStyleBackColor = true;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBorrar.Image")));
            this.BtnBorrar.Location = new System.Drawing.Point(84, 266);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(38, 39);
            this.BtnBorrar.TabIndex = 1;
            this.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBorrar.UseVisualStyleBackColor = true;
            // 
            // AgregarEQuipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.btnAgregarEquipo);
            this.Name = "AgregarEQuipo";
            this.Text = "AgregarEQuipo";
            this.Load += new System.EventHandler(this.AgregarEQuipo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarEquipo;
        private System.Windows.Forms.Button BtnBorrar;
    }

}