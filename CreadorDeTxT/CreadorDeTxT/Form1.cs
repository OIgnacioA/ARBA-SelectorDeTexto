namespace CreadorDeTxT
{
    public partial class Form1 : Form
    {
        private string txtOrigen = string.Empty;
        private string txtDestino = string.Empty;
        private int HastaN = 0;
        private int DesdeN = 0;
        private String primeraLetra = "";
        private String segundaLetra = "";
        private int issue = 1;
        private int cant = 0;
        private int contBarra = 0;
        private string MensajePlus = "";



        public Form1()
        {
            InitializeComponent();

            Generar.Enabled = false;
            Desde.Enabled = false;
            Hasta.Enabled = false;
            desdeLetra.Enabled = false;
            hastaLetra.Enabled = false;
            AlfaCheck.Enabled = false;
            PorCantidadCheck.Enabled = false;
            LabelDobleClick.Enabled = false;




            Abrir.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Origen.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult dr = this.Origen.ShowDialog();
            txtOrigen = this.Origen.FileName;

            TB_Dir.Text = txtOrigen;

            if (TB_Dir.Text != null) {

                AlfaCheck.Enabled = true;
                PorCantidadCheck.Enabled = true;
                PorCantidadCheck.Checked = true;
                LabelDobleClick.Enabled = true;

                Desde.Enabled = true;
                Desde.Focus();
            }



            txtDestino = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //"C:\\Users\\oscar.avendano\\Desktop\\DB Campaña\\Archivos de Prueba\\sehent";//

        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool flag1 = false;

            while ((AlfaCheck.Checked == false) && (PorCantidadCheck.Checked == false))
            {

                string mensaje = string.Format("Debe seleccionar un tipo de Busqueda ¿Desea hacer un Conteo Numerico?");
                if (MessageBox.Show(mensaje, "¿Reveer Parametros?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PorCantidadCheck.Checked = true;
                }
                else {

                    AlfaCheck.Checked = true;

                }

            }

            if (AlfaCheck.Checked == false)
            {

                try
                {
                    HastaN = Convert.ToInt32(Hasta.Text);
                    DesdeN = Convert.ToInt32(Desde.Text);
                }
                catch (Exception ex) {

                    HastaN = 2;
                    DesdeN = 1;

                    MensajePlus = "LOS DATOS INGRESADOS NO FUERON CORRECTOS-(Se ingresaron Letras en vez de Numeros)- sin embargo, Default-Ñ): ";

                }

                flag1 = CheckearDiferencia(DesdeN, HastaN);

                if (flag1 == true)
                {
                    ProcesoPrincipal();
                }
                else if (flag1 == false)
                {

                    string mensaje = string.Format("Los parametros de busqueda no son correctos");
                    if (MessageBox.Show(mensaje, "¿Reveer Parametros?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Hasta.Text = "";
                        Generar.Enabled = false;
                        Desde.Focus();
                    }
                }

            } else if (AlfaCheck.Checked == true)
            {

                ProcesoPrincipal();

            }

           
        }

        public void ProcesoPrincipal() {

            string mensaje = string.Empty;

            string line;
            int cont = 0;


            string nombreArchivoGenerado = string.Format("{0}\\TXTRecortado-{1}-.txt", txtDestino, issue);
            StreamWriter sw = new System.IO.StreamWriter(nombreArchivoGenerado);

            issue++;

            string nombre = txtOrigen.Replace(this.Origen.InitialDirectory, "");

            System.IO.StreamReader file = new System.IO.StreamReader(txtOrigen);
            BackColor = System.Drawing.Color.DarkOrange;



            primeraLetra = Desde.Text;
            segundaLetra = Hasta.Text;

            


            if (AlfaCheck.Checked == true)
            {
                Comprobacion(primeraLetra, segundaLetra);

                EstablecerValorBarra();

                Barra.Maximum = contBarra;

                while ((line = file.ReadLine()) != null)
                {

                    string linea = line.Substring(0, 1);

                    if (primeraLetra == linea)
                    {
                        cont++;

                        while ((line = file.ReadLine()) != null) {

                            linea = line.Substring(0, 1);
                            if (linea == segundaLetra) { break; }

                            sw.Write(line);
                            sw.WriteLine();

                            cant++;

                            Barra.Value = cant;

                            cont++;
                        }

                        break;

                    }


                    // LabelLeidos();

                    //Leidos.Text = cant.ToString();


                }

                sw.Flush();
                sw.Close();
                mensaje = string.Format("{0}Se leyeron {1} suscripciones; el archivo creado posee {2}:  desde La Letra {3} hasta la Letra {4} -exclusive- , del archivo : {4}", MensajePlus, cont, cant, primeraLetra, segundaLetra, nombre);
                if (MessageBox.Show(mensaje, " se termino la lecturta, ¿cerrar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }


            }
            else
            {


                Barra.Maximum = ((HastaN - DesdeN) + 1);

                while ((line = file.ReadLine()) != null)
                {

                    string linea = line;

                    if (DesdeN <= cont)
                    {

                        sw.Write(linea);
                        sw.WriteLine();

                        cant++;
                    }

                    Barra.Value = cant;

                    Leidos.Text = cant.ToString();
                    cont++;
                    if (cont == (HastaN + 1))
                    {
                        break;
                    }
                }

                sw.Flush();
                sw.Close();
                mensaje = string.Format("{0} Se leyeron {1} suscripciones; el archivo creado posee {2}:  desde La linea {3} hasta la Linea {4} -inclusive- , del archivo : {5}", MensajePlus, cont, cant, DesdeN, HastaN, nombre);
                if (MessageBox.Show(mensaje, " se termino la lecturta, ¿cerrar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            cant = 0;


            this.Close();
        }

        public void EstablecerValorBarra()
        {
            string line = "";
            System.IO.StreamReader file2 = new System.IO.StreamReader(txtOrigen);
            while ((line = file2.ReadLine()) != null)
            {
                string linea = line.Substring(0, 1);


                if (primeraLetra == linea)
                {

                    while ((line = file2.ReadLine()) != null)
                    {

                        linea = line.Substring(0, 1);

                        if (linea == segundaLetra) { break; }

                        contBarra++;


                    }


                    file2.Close();
                    break;
                }


            }
        }

        private void Desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                Hasta.Enabled = true;
                Hasta.Focus();
            }
        }

        private void Hasta_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Generar.Enabled = true;
                Generar.Focus();
            }
        }



        private void Desde_TextChanged(object sender, EventArgs e) {
            if (Desde.Text == "")
            {
                Generar.Enabled = false;
            }
        }

        private void Hasta_TextChanged(object sender, EventArgs e)
        {

            if (Hasta.Text == "")
            {
                Generar.Enabled = false;
            }
        }

        private void AlfaCheck_CheckedChanged(object sender, EventArgs e)
        {

            if (AlfaCheck.Checked == true)
            {

                desdeLetra.Enabled = true;
                hastaLetra.Enabled = true;

                hastaLinea.Enabled = false;
                desdeLinea.Enabled = false;

                PorCantidadCheck.Checked = false;


            }
            else if (AlfaCheck.Checked == false) {

                hastaLinea.Enabled = true;
                desdeLinea.Enabled = true;

                desdeLetra.Enabled = false;
                hastaLetra.Enabled = false;


            }

        }

        public void LabelLeidos()
        {
            Leidos.Text = cant.ToString();
        }

        public bool CheckearDiferencia(int val1, int val2)
        {


            if (val1 >= val2)
            {

                return false;
            }
            else {

                return true;

            }

        }


        public void Comprobacion(string primer, string segund){

            int a = TryParse(primer, Int32);
            int b = Convert.ToInt32(segund, int);

            if ((a - a  == 0) || (b - b == 0)) {

                primeraLetra = "a";
                segundaLetra = "b";

                MensajePlus = "INCORRECTO: SE INGRESARON NUMEROS EN VEZ DE LETRAS PARA LA BUSQUEDA: DE TODOS MODOS: ";
            }


        }

        private void PorCantidadCheck_CheckedChanged(object sender, EventArgs e)
        {
            AlfaCheck.Checked = false;

        }
    }


 

}