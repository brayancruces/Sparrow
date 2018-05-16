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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido usuario";
            // 
            // buttonInventory
            // 
            this.buttonInventory.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonInventory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonInventory.Location = new System.Drawing.Point(88, 92);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(100, 77);
            this.buttonInventory.TabIndex = 1;
            this.buttonInventory.Text = "Inventario y Stocks";
            this.buttonInventory.UseVisualStyleBackColor = false;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonLog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLog.Location = new System.Drawing.Point(301, 92);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(100, 77);
            this.buttonLog.TabIndex = 2;
            this.buttonLog.Text = "Registro de actividades";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(197, 269);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(90, 23);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Cerrar Sesión";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rol: Administrador";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 304);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonInventory);
            this.Controls.Add(this.label1);
            this.Name = "FormDashboard";
            this.Text = "Sparrow ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label label2;
    }
}