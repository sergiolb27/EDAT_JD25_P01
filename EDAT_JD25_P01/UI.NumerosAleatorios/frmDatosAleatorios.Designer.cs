
namespace UI.NumerosAleatorios
{
    partial class frmDatosAleatorios
    {
        private GroupBox grpDatos;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblFecha;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblSexo;
        private RadioButton rdbMasculino;
        private RadioButton rdbFemenino;
        private Label lblGrupo;
        private ComboBox cmbGrupo;
        private Label lblSueldo;
        private TextBox txtSueldo;
        private CheckBox chkSeguro;
        private Button btnGenerar;

        private void InitializeComponent()
        {
            this.grpDatos = new GroupBox();
            this.lblNumero = new Label();
            this.txtNumero = new TextBox();
            this.lblNombre = new Label();
            this.txtNombre = new TextBox();
            this.lblFecha = new Label();
            this.dtpFechaNacimiento = new DateTimePicker();
            this.lblSexo = new Label();
            this.rdbMasculino = new RadioButton();
            this.rdbFemenino = new RadioButton();
            this.lblGrupo = new Label();
            this.cmbGrupo = new ComboBox();
            this.lblSueldo = new Label();
            this.txtSueldo = new TextBox();
            this.chkSeguro = new CheckBox();
            this.btnGenerar = new Button();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.chkSeguro);
            this.grpDatos.Controls.Add(this.txtSueldo);
            this.grpDatos.Controls.Add(this.lblSueldo);
            this.grpDatos.Controls.Add(this.cmbGrupo);
            this.grpDatos.Controls.Add(this.lblGrupo);
            this.grpDatos.Controls.Add(this.rdbFemenino);
            this.grpDatos.Controls.Add(this.rdbMasculino);
            this.grpDatos.Controls.Add(this.lblSexo);
            this.grpDatos.Controls.Add(this.dtpFechaNacimiento);
            this.grpDatos.Controls.Add(this.lblFecha);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.txtNumero);
            this.grpDatos.Controls.Add(this.lblNumero);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(320, 280);
            this.grpDatos.Text = "Datos del empleado";
            // 
            // lblNumero
            this.lblNumero.Text = "Número:";
            this.lblNumero.Location = new System.Drawing.Point(10, 30);
            this.txtNumero.Location = new System.Drawing.Point(120, 27);
            // 
            // lblNombre
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new System.Drawing.Point(10, 65);
            this.txtNombre.Location = new System.Drawing.Point(120, 62);
            // 
            // lblFecha
            this.lblFecha.Text = "Fecha nacimiento:";
            this.lblFecha.Location = new System.Drawing.Point(10, 100);
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(120, 97);
            this.dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            // 
            // lblSexo
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.Location = new System.Drawing.Point(10, 135);
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.Location = new System.Drawing.Point(120, 133);
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.Location = new System.Drawing.Point(210, 133);
            // 
            // lblGrupo
            this.lblGrupo.Text = "Grupo:";
            this.lblGrupo.Location = new System.Drawing.Point(10, 170);
            this.cmbGrupo.Location = new System.Drawing.Point(120, 167);
            this.cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbGrupo.Items.AddRange(new object[] { "A", "B", "C", "D" });
            // 
            // lblSueldo
            this.lblSueldo.Text = "Sueldo:";
            this.lblSueldo.Location = new System.Drawing.Point(10, 205);
            this.txtSueldo.Location = new System.Drawing.Point(120, 202);
            // 
            // chkSeguro
            this.chkSeguro.Text = "Seguro médico";
            this.chkSeguro.Location = new System.Drawing.Point(120, 240);
            // 
            // btnGenerar
            this.btnGenerar.Text = "Generar datos aleatorios";
            this.btnGenerar.Location = new System.Drawing.Point(12, 310);
            this.btnGenerar.Size = new System.Drawing.Size(320, 35);
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmDatosAleatorios
            this.ClientSize = new System.Drawing.Size(350, 360);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.grpDatos);
            this.Text = "Datos Aleatorios";
            this.grpDatos.ResumeLayout(false);
            this.ResumeLayout(false);
        }
     }
    }
