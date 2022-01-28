namespace CreadorDeTxT
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
            this.Abrir = new System.Windows.Forms.Button();
            this.Generar = new System.Windows.Forms.Button();
            this.Origen = new System.Windows.Forms.OpenFileDialog();
            this.TB_Dir = new System.Windows.Forms.TextBox();
            this.Hasta = new System.Windows.Forms.TextBox();
            this.Desde = new System.Windows.Forms.TextBox();
            this.Barra = new System.Windows.Forms.ProgressBar();
            this.Leidos = new System.Windows.Forms.TextBox();
            this.desdeLinea = new System.Windows.Forms.Label();
            this.hastaLinea = new System.Windows.Forms.Label();
            this.hastaLetra = new System.Windows.Forms.Label();
            this.desdeLetra = new System.Windows.Forms.Label();
            this.AlfaCheck = new System.Windows.Forms.CheckBox();
            this.archivo = new System.Windows.Forms.Label();
            this.PorCantidadCheck = new System.Windows.Forms.CheckBox();
            this.LabelDobleClick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Abrir
            // 
            this.Abrir.Location = new System.Drawing.Point(126, 40);
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(108, 37);
            this.Abrir.TabIndex = 0;
            this.Abrir.Text = "Abrir";
            this.Abrir.UseVisualStyleBackColor = true;
            this.Abrir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Generar
            // 
            this.Generar.Location = new System.Drawing.Point(126, 303);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(108, 37);
            this.Generar.TabIndex = 1;
            this.Generar.Text = "Generar";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Origen
            // 
            this.Origen.InitialDirectory = "C:\\Users\\oscar.avendano\\Desktop";
            // 
            // TB_Dir
            // 
            this.TB_Dir.Location = new System.Drawing.Point(21, 97);
            this.TB_Dir.Multiline = true;
            this.TB_Dir.Name = "TB_Dir";
            this.TB_Dir.Size = new System.Drawing.Size(314, 53);
            this.TB_Dir.TabIndex = 2;
            // 
            // Hasta
            // 
            this.Hasta.Location = new System.Drawing.Point(236, 255);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(108, 23);
            this.Hasta.TabIndex = 3;
            this.Hasta.TextChanged += new System.EventHandler(this.Hasta_TextChanged);
            this.Hasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hasta_KeyPress);
            // 
            // Desde
            // 
            this.Desde.Location = new System.Drawing.Point(16, 255);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(108, 23);
            this.Desde.TabIndex = 4;
            this.Desde.TextChanged += new System.EventHandler(this.Desde_TextChanged);
            this.Desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desde_KeyPress);
            // 
            // Barra
            // 
            this.Barra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Barra.Location = new System.Drawing.Point(12, 363);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(243, 23);
            this.Barra.TabIndex = 5;
            // 
            // Leidos
            // 
            this.Leidos.Location = new System.Drawing.Point(279, 363);
            this.Leidos.Name = "Leidos";
            this.Leidos.Size = new System.Drawing.Size(65, 23);
            this.Leidos.TabIndex = 6;
            // 
            // desdeLinea
            // 
            this.desdeLinea.AutoSize = true;
            this.desdeLinea.Location = new System.Drawing.Point(18, 222);
            this.desdeLinea.Name = "desdeLinea";
            this.desdeLinea.Size = new System.Drawing.Size(112, 15);
            this.desdeLinea.TabIndex = 7;
            this.desdeLinea.Text = "Cortar Desde Linea: ";
            // 
            // hastaLinea
            // 
            this.hastaLinea.AutoSize = true;
            this.hastaLinea.Location = new System.Drawing.Point(236, 222);
            this.hastaLinea.Name = "hastaLinea";
            this.hastaLinea.Size = new System.Drawing.Size(77, 15);
            this.hastaLinea.TabIndex = 8;
            this.hastaLinea.Text = "Hasta Linea:  ";
            // 
            // hastaLetra
            // 
            this.hastaLetra.AutoSize = true;
            this.hastaLetra.Location = new System.Drawing.Point(236, 237);
            this.hastaLetra.Name = "hastaLetra";
            this.hastaLetra.Size = new System.Drawing.Size(75, 15);
            this.hastaLetra.TabIndex = 11;
            this.hastaLetra.Text = "Hasta Letra:  ";
            // 
            // desdeLetra
            // 
            this.desdeLetra.AutoSize = true;
            this.desdeLetra.Location = new System.Drawing.Point(5, 237);
            this.desdeLetra.Name = "desdeLetra";
            this.desdeLetra.Size = new System.Drawing.Size(125, 15);
            this.desdeLetra.TabIndex = 10;
            this.desdeLetra.Text = "Cortar a partir de letra:";
            // 
            // AlfaCheck
            // 
            this.AlfaCheck.AutoSize = true;
            this.AlfaCheck.Location = new System.Drawing.Point(118, 165);
            this.AlfaCheck.Name = "AlfaCheck";
            this.AlfaCheck.Size = new System.Drawing.Size(116, 19);
            this.AlfaCheck.TabIndex = 9;
            this.AlfaCheck.Text = "Orden Alfabetico";
            this.AlfaCheck.UseVisualStyleBackColor = true;
            this.AlfaCheck.CheckedChanged += new System.EventHandler(this.AlfaCheck_CheckedChanged);
            // 
            // archivo
            // 
            this.archivo.AutoSize = true;
            this.archivo.Location = new System.Drawing.Point(141, 22);
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(80, 15);
            this.archivo.TabIndex = 12;
            this.archivo.Text = "Elegir Archivo";
            // 
            // PorCantidadCheck
            // 
            this.PorCantidadCheck.AutoSize = true;
            this.PorCantidadCheck.Location = new System.Drawing.Point(118, 190);
            this.PorCantidadCheck.Name = "PorCantidadCheck";
            this.PorCantidadCheck.Size = new System.Drawing.Size(145, 19);
            this.PorCantidadCheck.TabIndex = 13;
            this.PorCantidadCheck.Text = "Por cantidad de Lineas";
            this.PorCantidadCheck.UseVisualStyleBackColor = true;
            this.PorCantidadCheck.CheckedChanged += new System.EventHandler(this.PorCantidadCheck_CheckedChanged);
            // 
            // LabelDobleClick
            // 
            this.LabelDobleClick.AutoSize = true;
            this.LabelDobleClick.Location = new System.Drawing.Point(260, 165);
            this.LabelDobleClick.Name = "LabelDobleClick";
            this.LabelDobleClick.Size = new System.Drawing.Size(75, 15);
            this.LabelDobleClick.TabIndex = 14;
            this.LabelDobleClick.Text = "(Doble Click)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 398);
            this.Controls.Add(this.LabelDobleClick);
            this.Controls.Add(this.PorCantidadCheck);
            this.Controls.Add(this.archivo);
            this.Controls.Add(this.hastaLetra);
            this.Controls.Add(this.desdeLetra);
            this.Controls.Add(this.AlfaCheck);
            this.Controls.Add(this.hastaLinea);
            this.Controls.Add(this.desdeLinea);
            this.Controls.Add(this.Leidos);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.Desde);
            this.Controls.Add(this.Hasta);
            this.Controls.Add(this.TB_Dir);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.Abrir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de TXT .Ñ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Abrir;
        private Button Generar;
        private System.Windows.Forms.OpenFileDialog Origen;
        private TextBox TB_Dir;
        private TextBox Hasta;
        private TextBox Desde;
        private ProgressBar Barra;
        private TextBox Leidos;
        private Label archivo;
        private CheckBox AlfaCheck;
        private Label hastaLetra;
        private Label desdeLetra;
        private Label desdeLinea;
        private Label hastaLinea;
        private CheckBox PorCantidadCheck;
        private Label LabelDobleClick;
    }
}