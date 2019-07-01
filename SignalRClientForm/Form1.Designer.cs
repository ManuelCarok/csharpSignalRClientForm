namespace SignalRClientForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(12, 35);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(196, 45);
            this.btnOn.TabIndex = 0;
            this.btnOn.Text = "ON";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.BtnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(214, 35);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(194, 45);
            this.btnOff.TabIndex = 1;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.BtnOff_Click);
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(13, 115);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(395, 301);
            this.txtChat.TabIndex = 2;
            // 
            // txtUsers
            // 
            this.txtUsers.Location = new System.Drawing.Point(414, 35);
            this.txtUsers.Multiline = true;
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.ReadOnly = true;
            this.txtUsers.Size = new System.Drawing.Size(202, 381);
            this.txtUsers.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estado :";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(79, 13);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(99, 17);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Desconectado";
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(13, 86);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(314, 22);
            this.txtEnviar.TabIndex = 6;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(333, 86);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 434);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsers);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.Button btnEnviar;
    }
}

