namespace UI.NumerosAleatorios
{
    public partial class frmDatosAleatorios : Form
    {
        private Random random = new Random();

        public frmDatosAleatorios()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado
            {
                Numero = random.Next(1000, 9999),
                Nombre = GenerarNombre(),
                FechaNacimiento = GenerarFechaNacimiento(),
                Sexo = random.Next(2) == 0 ? "Masculino" : "Femenino",
                Grupo = GenerarGrupo(),
                Sueldo = random.Next(5000, 20000),
                SeguroMedico = random.Next(2) == 0
            };

            txtNumero.Text = emp.Numero.ToString();
            txtNombre.Text = emp.Nombre;
            dtpFechaNacimiento.Value = emp.FechaNacimiento;
            if (emp.Sexo == "Masculino")
                rdbMasculino.Checked = true;
            else
                rdbFemenino.Checked = true;
            cmbGrupo.SelectedItem = emp.Grupo;
            txtSueldo.Text = emp.Sueldo.ToString("C");
            chkSeguro.Checked = emp.SeguroMedico;
        }

        private string GenerarNombre()
        {
            string[] nombres = { "Monse", "Karen", "Fernando", "Alex", "Juan", "Danna", "Yael", "Eric" };
            return nombres[random.Next(nombres.Length)];
        }

        private DateTime GenerarFechaNacimiento()
        {
            return new DateTime(random.Next(1970, 2005), random.Next(1, 13), random.Next(1, 28));
        }

        private string GenerarGrupo()
        {
            string[] grupos = { "A", "B", "C", "D" };
            return grupos[random.Next(grupos.Length)];
        }
    }
}
