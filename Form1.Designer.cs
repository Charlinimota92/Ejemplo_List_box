namespace Ejemplo_List_box
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
            this.label1 = new System.Windows.Forms.Label();
            this.lst_Series = new System.Windows.Forms.ListBox();
            this.txt_Series = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lbl_Indice_Seleccionado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Series";
            // 
            // lst_Series
            // 
            this.lst_Series.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Series.FormattingEnabled = true;
            this.lst_Series.ItemHeight = 18;
            this.lst_Series.Location = new System.Drawing.Point(156, 61);
            this.lst_Series.Margin = new System.Windows.Forms.Padding(4);
            this.lst_Series.Name = "lst_Series";
            this.lst_Series.Size = new System.Drawing.Size(197, 184);
            this.lst_Series.TabIndex = 1;
            this.lst_Series.SelectedIndexChanged += new System.EventHandler(this.lst_Series_SelectedIndexChanged);
            // 
            // txt_Series
            // 
            this.txt_Series.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Series.Location = new System.Drawing.Point(404, 61);
            this.txt_Series.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Series.Name = "txt_Series";
            this.txt_Series.Size = new System.Drawing.Size(161, 29);
            this.txt_Series.TabIndex = 2;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_agregar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.Blue;
            this.btn_agregar.Location = new System.Drawing.Point(444, 153);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(90, 50);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_salir.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.Blue;
            this.btn_salir.Location = new System.Drawing.Point(327, 362);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(90, 49);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_eliminar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.Blue;
            this.btn_eliminar.Location = new System.Drawing.Point(444, 277);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(90, 51);
            this.btn_eliminar.TabIndex = 5;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_limpiar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.Blue;
            this.btn_limpiar.Location = new System.Drawing.Point(175, 362);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(90, 51);
            this.btn_limpiar.TabIndex = 6;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // lbl_Indice_Seleccionado
            // 
            this.lbl_Indice_Seleccionado.AutoSize = true;
            this.lbl_Indice_Seleccionado.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Indice_Seleccionado.Location = new System.Drawing.Point(44, 296);
            this.lbl_Indice_Seleccionado.Name = "lbl_Indice_Seleccionado";
            this.lbl_Indice_Seleccionado.Size = new System.Drawing.Size(52, 18);
            this.lbl_Indice_Seleccionado.TabIndex = 7;
            this.lbl_Indice_Seleccionado.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(613, 496);
            this.Controls.Add(this.lbl_Indice_Seleccionado);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_Series);
            this.Controls.Add(this.lst_Series);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Series";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_Series;
        private System.Windows.Forms.TextBox txt_Series;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label lbl_Indice_Seleccionado;
    }
}

