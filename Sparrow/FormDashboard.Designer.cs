namespace Sparrow
{
    partial class FormDashboard
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
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelRol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenido.Location = new System.Drawing.Point(201, 11);
            this.labelBienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(259, 40);
            this.labelBienvenido.TabIndex = 0;
            this.labelBienvenido.Text = "Bienvenido usuario";
            // 
            // buttonInventory
            // 
            this.buttonInventory.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonInventory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonInventory.Location = new System.Drawing.Point(117, 113);
            this.buttonInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(133, 95);
            this.buttonInventory.TabIndex = 1;
            this.buttonInventory.Text = "Inventario y Stocks";
            this.buttonInventory.UseVisualStyleBackColor = false;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonLog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLog.Location = new System.Drawing.Point(401, 113);
            this.buttonLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(133, 95);
            this.buttonLog.TabIndex = 2;
            this.buttonLog.Text = "Registro de actividades";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(263, 331);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(120, 28);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Cerrar Sesión";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Location = new System.Drawing.Point(17, 276);
            this.labelRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(118, 16);
            this.labelRol.TabIndex = 5;
            this.labelRol.Text = "Rol: Administrador";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 374);
            this.Controls.Add(this.labelRol);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonInventory);
            this.Controls.Add(this.labelBienvenido);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDashboard";
            this.Text = "Sparrow ";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenido;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelRol;
    }
}