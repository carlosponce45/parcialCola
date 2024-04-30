namespace Estructura_Cola
{
    public partial class Form1 : Form
    {
        Cola cola = new Cola();
        int orden = 1;
        public Form1()
        {
            InitializeComponent();
            txtOrden.Text = orden.ToString();
            cola.listar(lstCola);
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            cola.insertar(orden);
            orden++;
            txtOrden.Text = orden.ToString();
            cola.listar(lstCola);
        }
       
    }
}