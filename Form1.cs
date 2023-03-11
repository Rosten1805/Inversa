namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string numeros = textBox1.Text; // Obtener la entrada de texto del usuario
            string[] numerosLista = numeros.Split(','); // Convertir la entrada en una lista de números
            Array.Reverse(numerosLista); // Invertir la lista de números
            label1.Text = String.Join(", ", numerosLista); // Mostrar la lista invertida en el label
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}