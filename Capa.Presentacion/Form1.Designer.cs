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
            TxtRNC = new TextBox();
            TxtNOMBRE = new TextBox();
            TxtTELEFONO = new TextBox();
            btnBUSCAR = new Button();
            lnlPRODUCTO = new Label();
            TxtTIPO = new TextBox();
            TxtPRODUCTO = new TextBox();
            dataGridView1 = new DataGridView();
            btnAGREGAR = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblRNC
            // 
            lblRNC.AutoSize = true;
            lblRNC.Location = new Point(202, 152);
            lblRNC.Name = "lblRNC";
            lblRNC.Size = new Size(38, 20);
            lblRNC.TabIndex = 0;
            lblRNC.Text = "RNC";
            lblRNC.Click += label1_Click;
            // 
            // lblNOMBRE
            // 
            lblNOMBRE.AutoSize = true;
            lblNOMBRE.Location = new Point(176, 210);
            lblNOMBRE.Name = "lblNOMBRE";
            lblNOMBRE.Size = new Size(64, 20);
            lblNOMBRE.TabIndex = 1;
            lblNOMBRE.Text = "Nombre";
            // 
            // lblTELEFONO
            // 
            lblTELEFONO.AutoSize = true;
            lblTELEFONO.Location = new Point(173, 278);
            lblTELEFONO.Name = "lblTELEFONO";
            lblTELEFONO.Size = new Size(67, 20);
            lblTELEFONO.TabIndex = 2;
            lblTELEFONO.Text = "Telefono";
            // 
            // lblTIPO
            // 
            lblTIPO.AutoSize = true;
            lblTIPO.Location = new Point(201, 346);
            lblTIPO.Name = "lblTIPO";
            lblTIPO.Size = new Size(39, 20);
            lblTIPO.TabIndex = 3;
            lblTIPO.Text = "Tipo";
            // 
            // TxtRNC
            // 
            TxtRNC.Location = new Point(246, 145);
            TxtRNC.Name = "TxtRNC";
            TxtRNC.Size = new Size(253, 27);
            TxtRNC.TabIndex = 5;
            // 
            // TxtNOMBRE
            // 
            TxtNOMBRE.Location = new Point(246, 203);
            TxtNOMBRE.Name = "TxtNOMBRE";
            TxtNOMBRE.Size = new Size(253, 27);
            TxtNOMBRE.TabIndex = 6;
            // 
            // TxtTELEFONO
            // 
            TxtTELEFONO.Location = new Point(246, 271);
            TxtTELEFONO.Name = "TxtTELEFONO";
            TxtTELEFONO.Size = new Size(253, 27);
            TxtTELEFONO.TabIndex = 7;
            // 
            // btnBUSCAR
            // 
            btnBUSCAR.Location = new Point(405, 492);
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
            lnlPRODUCTO.Location = new Point(171, 422);
            lnlPRODUCTO.Name = "lnlPRODUCTO";
            lnlPRODUCTO.Size = new Size(69, 20);
            lnlPRODUCTO.TabIndex = 13;
            lnlPRODUCTO.Text = "Producto";
            // 
            // TxtTIPO
            // 
            TxtTIPO.Location = new Point(246, 339);
            TxtTIPO.Name = "TxtTIPO";
            TxtTIPO.Size = new Size(253, 27);
            TxtTIPO.TabIndex = 14;
            // 
            // TxtPRODUCTO
            // 
            TxtPRODUCTO.Location = new Point(246, 415);
            TxtPRODUCTO.Name = "TxtPRODUCTO";
            TxtPRODUCTO.Size = new Size(253, 27);
            TxtPRODUCTO.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(604, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(663, 325);
            dataGridView1.TabIndex = 16;
            // 
            // btnAGREGAR
            // 
            btnAGREGAR.Location = new Point(246, 492);
            btnAGREGAR.Name = "btnAGREGAR";
            btnAGREGAR.Size = new Size(94, 29);
            btnAGREGAR.TabIndex = 17;
            btnAGREGAR.Text = "Agregar";
            btnAGREGAR.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1386, 575);
            Controls.Add(label1);
            Controls.Add(btnAGREGAR);
            Controls.Add(dataGridView1);
            Controls.Add(TxtPRODUCTO);
            Controls.Add(TxtTIPO);
            Controls.Add(lnlPRODUCTO);
            Controls.Add(btnBUSCAR);
            Controls.Add(TxtTELEFONO);
            Controls.Add(TxtNOMBRE);
            Controls.Add(TxtRNC);
            Controls.Add(lblTIPO);
            Controls.Add(lblTELEFONO);
            Controls.Add(lblNOMBRE);
            Controls.Add(lblRNC);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRNC;
        private Label lblNOMBRE;
        private Label lblTELEFONO;
        private Label lblTIPO;
        private TextBox TxtRNC;
        private TextBox TxtNOMBRE;
        private TextBox TxtTELEFONO;
        private Button btnBUSCAR;
        private Label lnlPRODUCTO;
        private TextBox TxtTIPO;
        private TextBox TxtPRODUCTO;
        private DataGridView dataGridView1;
        private Button btnAGREGAR;
        private Label label1;
    }
}
