namespace Presentación
{
    partial class FormPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.pictureBoxCatalogo = new System.Windows.Forms.PictureBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.txtbox_Filtro = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.comboBox_Campo = new System.Windows.Forms.ComboBox();
            this.comboBox_Criterio = new System.Windows.Forms.ComboBox();
            this.txtbox_Filtro_2 = new System.Windows.Forms.TextBox();
            this.labelCampo = new System.Windows.Forms.Label();
            this.labelCriterio = new System.Windows.Forms.Label();
            this.labelFiltroDB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalogo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCatalogo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCatalogo.EnableHeadersVisualStyles = false;
            this.dgvCatalogo.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCatalogo.Location = new System.Drawing.Point(37, 138);
            this.dgvCatalogo.MultiSelect = false;
            this.dgvCatalogo.Name = "dgvCatalogo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalogo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCatalogo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(714, 375);
            this.dgvCatalogo.TabIndex = 0;

            this.dgvCatalogo.SelectionChanged += new System.EventHandler(this.dgvCatalogo_SelectionChanged);
            // 
            // pictureBoxCatalogo
            // 
            this.pictureBoxCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCatalogo.Location = new System.Drawing.Point(799, 138);
            this.pictureBoxCatalogo.Name = "pictureBoxCatalogo";
            this.pictureBoxCatalogo.Size = new System.Drawing.Size(367, 375);
            this.pictureBoxCatalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCatalogo.TabIndex = 1;
            this.pictureBoxCatalogo.TabStop = false;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(49, 534);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(151, 70);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(206, 534);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(151, 70);
            this.buttonModificar.TabIndex = 3;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(363, 534);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(152, 70);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(423, 42);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Aplicación de Catálogo";
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.Location = new System.Drawing.Point(15, 77);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(127, 20);
            this.labelBuscar.TabIndex = 6;
            this.labelBuscar.Text = "Buscar Nombre: ";
            // 
            // txtbox_Filtro
            // 
            this.txtbox_Filtro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtbox_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Filtro.Location = new System.Drawing.Point(170, 75);
            this.txtbox_Filtro.Name = "txtbox_Filtro";
            this.txtbox_Filtro.Size = new System.Drawing.Size(247, 22);
            this.txtbox_Filtro.TabIndex = 7;
            this.txtbox_Filtro.TextChanged += new System.EventHandler(this.txtbox_Filtro_TextChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(1084, 74);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelDescripcion.Location = new System.Drawing.Point(799, 535);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(367, 69);
            this.labelDescripcion.TabIndex = 9;
            this.labelDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.Location = new System.Drawing.Point(702, 559);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(91, 18);
            this.labelDesc.TabIndex = 10;
            this.labelDesc.Text = "Descripción:";
            // 
            // comboBox_Campo
            // 
            this.comboBox_Campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Campo.FormattingEnabled = true;
            this.comboBox_Campo.Location = new System.Drawing.Point(516, 76);
            this.comboBox_Campo.Name = "comboBox_Campo";
            this.comboBox_Campo.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Campo.TabIndex = 11;
            this.comboBox_Campo.SelectedIndexChanged += new System.EventHandler(this.comboBox_Campo_SelectedIndexChanged);
            // 
            // comboBox_Criterio
            // 
            this.comboBox_Criterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Criterio.FormattingEnabled = true;
            this.comboBox_Criterio.Location = new System.Drawing.Point(732, 76);
            this.comboBox_Criterio.Name = "comboBox_Criterio";
            this.comboBox_Criterio.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Criterio.TabIndex = 12;
            // 
            // txtbox_Filtro_2
            // 
            this.txtbox_Filtro_2.Location = new System.Drawing.Point(956, 77);
            this.txtbox_Filtro_2.MaxLength = 150;
            this.txtbox_Filtro_2.Name = "txtbox_Filtro_2";
            this.txtbox_Filtro_2.ShortcutsEnabled = false;
            this.txtbox_Filtro_2.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Filtro_2.TabIndex = 13;
            this.txtbox_Filtro_2.TabStop = false;
            this.txtbox_Filtro_2.Tag = "";
            this.txtbox_Filtro_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Filtro_2_KeyPress);
            // 
            // labelCampo
            // 
            this.labelCampo.AutoSize = true;
            this.labelCampo.Location = new System.Drawing.Point(445, 84);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(43, 13);
            this.labelCampo.TabIndex = 14;
            this.labelCampo.Text = "Campo:";
            // 
            // labelCriterio
            // 
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Location = new System.Drawing.Point(665, 84);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(39, 13);
            this.labelCriterio.TabIndex = 15;
            this.labelCriterio.Text = "Criterio";
            // 
            // labelFiltroDB
            // 
            this.labelFiltroDB.AutoSize = true;
            this.labelFiltroDB.Location = new System.Drawing.Point(881, 84);
            this.labelFiltroDB.Name = "labelFiltroDB";
            this.labelFiltroDB.Size = new System.Drawing.Size(47, 13);
            this.labelFiltroDB.TabIndex = 16;
            this.labelFiltroDB.Text = "Filtro DB";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1202, 624);
            this.Controls.Add(this.labelFiltroDB);
            this.Controls.Add(this.labelCriterio);
            this.Controls.Add(this.labelCampo);
            this.Controls.Add(this.txtbox_Filtro_2);
            this.Controls.Add(this.comboBox_Criterio);
            this.Controls.Add(this.comboBox_Campo);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.txtbox_Filtro);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.pictureBoxCatalogo);
            this.Controls.Add(this.dgvCatalogo);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.PictureBox pictureBoxCatalogo;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox txtbox_Filtro;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.ComboBox comboBox_Campo;
        private System.Windows.Forms.ComboBox comboBox_Criterio;
        private System.Windows.Forms.TextBox txtbox_Filtro_2;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.Label labelFiltroDB;
    }
}

