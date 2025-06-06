namespace Capa.Presentacion
{
    partial class Form1
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
            lblRNC = new Label();
            lblNOMBRE = new Label();
            lblTELEFONO = new Label();
            lblTIPO = new Label();
            btnBUSCAR = new Button();
            lnlPRODUCTO = new Label();
            TxtTIPO = new TextBox();
            TxtPRODUCTO = new TextBox();
            dgvProveedores = new DataGridView();
            btnREGISTRAR = new Button();
            label1 = new Label();
            TxtTELEFONO = new MaskedTextBox();
            TxtRNC = new MaskedTextBox();
            btnLIMPIAR = new Button();
            btnELIMINAR = new Button();
            TxtNOMBRE = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // lblRNC
            // 
            lblRNC.AutoSize = true;
            lblRNC.Location = new Point(202, 130);
            lblRNC.Name = "lblRNC";
            lblRNC.Size = new Size(38, 20);
            lblRNC.TabIndex = 0;
            lblRNC.Text = "RNC";
            lblRNC.Click += label1_Click;
            // 
            // lblNOMBRE
            // 
            lblNOMBRE.AutoSize = true;
            lblNOMBRE.Location = new Point(176, 195);
            lblNOMBRE.Name = "lblNOMBRE";
            lblNOMBRE.Size = new Size(64, 20);
            lblNOMBRE.TabIndex = 1;
            lblNOMBRE.Text = "Nombre";
            // 
            // lblTELEFONO
            // 
            lblTELEFONO.AutoSize = true;
            lblTELEFONO.Location = new Point(173, 261);
            lblTELEFONO.Name = "lblTELEFONO";
            lblTELEFONO.Size = new Size(67, 20);
            lblTELEFONO.TabIndex = 2;
            lblTELEFONO.Text = "Telefono";
            // 
            // lblTIPO
            // 
            lblTIPO.AutoSize = true;
            lblTIPO.Location = new Point(201, 328);
            lblTIPO.Name = "lblTIPO";
            lblTIPO.Size = new Size(39, 20);
            lblTIPO.TabIndex = 3;
            lblTIPO.Text = "Tipo";
            // 
            // btnBUSCAR
            // 
            btnBUSCAR.Location = new Point(405, 459);
            btnBUSCAR.Name = "btnBUSCAR";
            btnBUSCAR.Size = new Size(94, 29);
            btnBUSCAR.TabIndex = 12;
            btnBUSCAR.Text = "Buscar";
            btnBUSCAR.UseVisualStyleBackColor = true;
            btnBUSCAR.Click += btnBUSCAR_Click;
            // 
            // lnlPRODUCTO
            // 
            lnlPRODUCTO.AutoSize = true;
            lnlPRODUCTO.Location = new Point(171, 395);
            lnlPRODUCTO.Name = "lnlPRODUCTO";
            lnlPRODUCTO.Size = new Size(69, 20);
            lnlPRODUCTO.TabIndex = 13;
            lnlPRODUCTO.Text = "Producto";
            // 
            // TxtTIPO
            // 
            TxtTIPO.Location = new Point(246, 321);
            TxtTIPO.Name = "TxtTIPO";
            TxtTIPO.Size = new Size(253, 27);
            TxtTIPO.TabIndex = 14;
            // 
            // TxtPRODUCTO
            // 
            TxtPRODUCTO.Location = new Point(246, 388);
            TxtPRODUCTO.Name = "TxtPRODUCTO";
            TxtPRODUCTO.Size = new Size(253, 27);
            TxtPRODUCTO.TabIndex = 15;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.AllowUserToResizeRows = false;
            dgvProveedores.BackgroundColor = SystemColors.ControlLightLight;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(561, 119);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(730, 296);
            dgvProveedores.TabIndex = 16;
            dgvProveedores.CellMouseClick += dgvProveedores_CellMouseClick;
            // 
            // btnREGISTRAR
            // 
            btnREGISTRAR.Location = new Point(246, 459);
            btnREGISTRAR.Name = "btnREGISTRAR";
            btnREGISTRAR.Size = new Size(94, 29);
            btnREGISTRAR.TabIndex = 17;
            btnREGISTRAR.Text = "Registrar";
            btnREGISTRAR.UseVisualStyleBackColor = true;
            btnREGISTRAR.Click += btnREGISTRAR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 45);
            label1.Name = "label1";
            label1.Size = new Size(267, 34);
            label1.TabIndex = 18;
            label1.Text = "PROVEEDORES";
            // 
            // TxtTELEFONO
            // 
            TxtTELEFONO.Location = new Point(246, 254);
            TxtTELEFONO.Mask = "(999)-000-0000";
            TxtTELEFONO.Name = "TxtTELEFONO";
            TxtTELEFONO.Size = new Size(253, 27);
            TxtTELEFONO.TabIndex = 19;
            TxtTELEFONO.MaskInputRejected += TxtTELEFONO_MaskInputRejected;
            // 
            // TxtRNC
            // 
            TxtRNC.Location = new Point(246, 123);
            TxtRNC.Mask = "999999999";
            TxtRNC.Name = "TxtRNC";
            TxtRNC.Size = new Size(253, 27);
            TxtRNC.TabIndex = 20;
            TxtRNC.MaskInputRejected += TxtRNC_MaskInputRejected;
            // 
            // btnLIMPIAR
            // 
            btnLIMPIAR.Location = new Point(405, 523);
            btnLIMPIAR.Name = "btnLIMPIAR";
            btnLIMPIAR.Size = new Size(94, 29);
            btnLIMPIAR.TabIndex = 21;
            btnLIMPIAR.Text = "Limpiar";
            btnLIMPIAR.UseVisualStyleBackColor = true;
            btnLIMPIAR.Click += btnLIMPIAR_Click;
            // 
            // btnELIMINAR
            // 
            btnELIMINAR.Location = new Point(246, 523);
            btnELIMINAR.Name = "btnELIMINAR";
            btnELIMINAR.Size = new Size(94, 29);
            btnELIMINAR.TabIndex = 23;
            btnELIMINAR.Text = "Eliminar";
            btnELIMINAR.UseVisualStyleBackColor = true;
            btnELIMINAR.Click += btnELIMINAR_Click;
            // 
            // TxtNOMBRE
            // 
            TxtNOMBRE.Location = new Point(246, 188);
            TxtNOMBRE.Name = "TxtNOMBRE";
            TxtNOMBRE.Size = new Size(253, 27);
            TxtNOMBRE.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1333, 575);
            Controls.Add(TxtNOMBRE);
            Controls.Add(btnELIMINAR);
            Controls.Add(btnLIMPIAR);
            Controls.Add(TxtRNC);
            Controls.Add(TxtTELEFONO);
            Controls.Add(label1);
            Controls.Add(btnREGISTRAR);
            Controls.Add(dgvProveedores);
            Controls.Add(TxtPRODUCTO);
            Controls.Add(TxtTIPO);
            Controls.Add(lnlPRODUCTO);
            Controls.Add(btnBUSCAR);
            Controls.Add(lblTIPO);
            Controls.Add(lblTELEFONO);
            Controls.Add(lblNOMBRE);
            Controls.Add(lblRNC);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRNC;
        private Label lblNOMBRE;
        private Label lblTELEFONO;
        private Label lblTIPO;
        private Button btnBUSCAR;
        private Label lnlPRODUCTO;
        private TextBox TxtTIPO;
        private TextBox TxtPRODUCTO;
        private DataGridView dgvProveedores;
        private Button btnREGISTRAR;
        private Label label1;
        private MaskedTextBox TxtTELEFONO;
        private MaskedTextBox TxtRNC;
        private Button btnLIMPIAR;
        private Button btnELIMINAR;
        private TextBox TxtNOMBRE;
    }
}
