namespace L9_FAGA_1088322
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            if(int)
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void txt__TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string modelo, marca, disponible, cambio, descuento, precio;

            if(int. TryParse(txt_precio.Text, out int num))
            {
                MessageBox.Show("Ingresar un numero");
            }
            else
            {
                if(int.TryParse(txt_tipocambiodolar.Text, out int num1))
                {
                    MessageBox.Show("Ingresar un valor numerico");
                }
            }
        }
    }
}