namespace ProductosApp.Formularios
{
    partial class FrmProductos
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbFinderType = new System.Windows.Forms.ComboBox();
            this.cmbMeasureUnit = new System.Windows.Forms.ComboBox();
            this.rtbProductView = new System.Windows.Forms.RichTextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dtpFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.nudMenor = new System.Windows.Forms.NumericUpDown();
            this.nudMayor = new System.Windows.Forms.NumericUpDown();
            this.btnMetodos = new System.Windows.Forms.Button();
            this.btnEntraSalida = new System.Windows.Forms.Button();
            this.btnCalculoPromedio = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMenor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMayor)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(344, 354);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(248, 34);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(171, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(92, 2);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 24);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 2);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 24);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // cmbFinderType
            // 
            this.cmbFinderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinderType.FormattingEnabled = true;
            this.cmbFinderType.Items.AddRange(new object[] {
            "Id",
            "Rango Precio",
            "Fecha vencimiento",
            "Unidad Medida"});
            this.cmbFinderType.Location = new System.Drawing.Point(9, 10);
            this.cmbFinderType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFinderType.Name = "cmbFinderType";
            this.cmbFinderType.Size = new System.Drawing.Size(164, 21);
            this.cmbFinderType.TabIndex = 1;
            this.cmbFinderType.SelectedIndexChanged += new System.EventHandler(this.CmbFinderType_SelectedIndexChanged);
            // 
            // cmbMeasureUnit
            // 
            this.cmbMeasureUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeasureUnit.FormattingEnabled = true;
            this.cmbMeasureUnit.Location = new System.Drawing.Point(259, 10);
            this.cmbMeasureUnit.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMeasureUnit.Name = "cmbMeasureUnit";
            this.cmbMeasureUnit.Size = new System.Drawing.Size(172, 21);
            this.cmbMeasureUnit.TabIndex = 2;
            this.cmbMeasureUnit.Visible = false;
            // 
            // rtbProductView
            // 
            this.rtbProductView.Location = new System.Drawing.Point(9, 37);
            this.rtbProductView.Margin = new System.Windows.Forms.Padding(2);
            this.rtbProductView.Name = "rtbProductView";
            this.rtbProductView.ReadOnly = true;
            this.rtbProductView.Size = new System.Drawing.Size(583, 284);
            this.rtbProductView.TabIndex = 4;
            this.rtbProductView.Text = "";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(498, 10);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(91, 19);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Buscar";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(232, 10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(218, 20);
            this.txtId.TabIndex = 6;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // dtpFechaCaducidad
            // 
            this.dtpFechaCaducidad.Location = new System.Drawing.Point(250, 12);
            this.dtpFechaCaducidad.Name = "dtpFechaCaducidad";
            this.dtpFechaCaducidad.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCaducidad.TabIndex = 7;
            // 
            // nudMenor
            // 
            this.nudMenor.Location = new System.Drawing.Point(187, 11);
            this.nudMenor.Name = "nudMenor";
            this.nudMenor.Size = new System.Drawing.Size(150, 20);
            this.nudMenor.TabIndex = 8;
            // 
            // nudMayor
            // 
            this.nudMayor.Location = new System.Drawing.Point(343, 11);
            this.nudMayor.Name = "nudMayor";
            this.nudMayor.Size = new System.Drawing.Size(150, 20);
            this.nudMayor.TabIndex = 9;
            this.nudMayor.ValueChanged += new System.EventHandler(this.nudMayor_ValueChanged);
            // 
            // btnMetodos
            // 
            this.btnMetodos.Location = new System.Drawing.Point(107, 340);
            this.btnMetodos.Name = "btnMetodos";
            this.btnMetodos.Size = new System.Drawing.Size(145, 23);
            this.btnMetodos.TabIndex = 3;
            this.btnMetodos.Text = "Metodos de inventario";
            this.btnMetodos.UseVisualStyleBackColor = true;
            this.btnMetodos.Click += new System.EventHandler(this.btnMetodos_Click);
            // 
            // btnEntraSalida
            // 
            this.btnEntraSalida.Location = new System.Drawing.Point(12, 382);
            this.btnEntraSalida.Name = "btnEntraSalida";
            this.btnEntraSalida.Size = new System.Drawing.Size(171, 23);
            this.btnEntraSalida.TabIndex = 10;
            this.btnEntraSalida.Text = "Entrada/Salida de articulos";
            this.btnEntraSalida.UseVisualStyleBackColor = true;
            this.btnEntraSalida.Click += new System.EventHandler(this.btnEntraSalida_Click);
            // 
            // btnCalculoPromedio
            // 
            this.btnCalculoPromedio.Location = new System.Drawing.Point(209, 382);
            this.btnCalculoPromedio.Name = "btnCalculoPromedio";
            this.btnCalculoPromedio.Size = new System.Drawing.Size(110, 23);
            this.btnCalculoPromedio.TabIndex = 11;
            this.btnCalculoPromedio.Text = "Calcular promedio";
            this.btnCalculoPromedio.UseVisualStyleBackColor = true;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 435);
            this.Controls.Add(this.btnCalculoPromedio);
            this.Controls.Add(this.btnEntraSalida);
            this.Controls.Add(this.nudMayor);
            this.Controls.Add(this.nudMenor);
            this.Controls.Add(this.dtpFechaCaducidad);
            this.Controls.Add(this.btnMetodos);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.rtbProductView);
            this.Controls.Add(this.cmbMeasureUnit);
            this.Controls.Add(this.cmbFinderType);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProductos";
            this.Text = "Catalogo de productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMenor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMayor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbFinderType;
        private System.Windows.Forms.ComboBox cmbMeasureUnit;
        private System.Windows.Forms.RichTextBox rtbProductView;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker dtpFechaCaducidad;
        private System.Windows.Forms.NumericUpDown nudMenor;
        private System.Windows.Forms.NumericUpDown nudMayor;
        private System.Windows.Forms.Button btnMetodos;
        private System.Windows.Forms.Button btnEntraSalida;
        private System.Windows.Forms.Button btnCalculoPromedio;
    }
}