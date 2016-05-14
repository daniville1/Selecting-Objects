namespace Seleccion_OpenGL
{
    partial class Seleccion_OpenGL
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seleccion_OpenGL));
            this.gl = new OpenTK.GLControl();
            this.btn_xDer = new System.Windows.Forms.Button();
            this.btn_xIzq = new System.Windows.Forms.Button();
            this.btn_yIzq = new System.Windows.Forms.Button();
            this.btn_yDer = new System.Windows.Forms.Button();
            this.btn_zIzq = new System.Windows.Forms.Button();
            this.btn_zDer = new System.Windows.Forms.Button();
            this.lbl_acercaDe = new System.Windows.Forms.Label();
            this.btn_aumentar = new System.Windows.Forms.Button();
            this.btn_disminuir = new System.Windows.Forms.Button();
            this.tmrRedraw = new System.Windows.Forms.Timer(this.components);
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.lbl_z = new System.Windows.Forms.Label();
            this.lbl_valorX = new System.Windows.Forms.Label();
            this.lbl_valorY = new System.Windows.Forms.Label();
            this.lbl_valorZ = new System.Windows.Forms.Label();
            this.gbox_coordenadas = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbox_esfera = new System.Windows.Forms.GroupBox();
            this.txt_esferaRadio = new System.Windows.Forms.TextBox();
            this.btn_esferaGraficar = new System.Windows.Forms.Button();
            this.lbl_esferaRadio = new System.Windows.Forms.Label();
            this.gbox_cilindro = new System.Windows.Forms.GroupBox();
            this.txt_cilindroAltura = new System.Windows.Forms.TextBox();
            this.txt_cilindroRadio = new System.Windows.Forms.TextBox();
            this.btn_cilindroGraficar = new System.Windows.Forms.Button();
            this.lbl_cilindroAltura = new System.Windows.Forms.Label();
            this.lbl_cilindroRadio = new System.Windows.Forms.Label();
            this.gbox_cono = new System.Windows.Forms.GroupBox();
            this.txt_conoAltura = new System.Windows.Forms.TextBox();
            this.txt_conoRadio = new System.Windows.Forms.TextBox();
            this.btn_conoGraficar = new System.Windows.Forms.Button();
            this.lbl_conoAltura = new System.Windows.Forms.Label();
            this.lbl_conoRadio = new System.Windows.Forms.Label();
            this.gbox_lineasLuz = new System.Windows.Forms.GroupBox();
            this.cbn_lineasGuia = new System.Windows.Forms.CheckBox();
            this.cbn_luz = new System.Windows.Forms.CheckBox();
            this.gbox_color = new System.Windows.Forms.GroupBox();
            this.rbn_colorAzul = new System.Windows.Forms.RadioButton();
            this.rbn_colorVerde = new System.Windows.Forms.RadioButton();
            this.rbn_colorRojo = new System.Windows.Forms.RadioButton();
            this.gbox_resolucion = new System.Windows.Forms.GroupBox();
            this.rbn_resolucionAlta = new System.Windows.Forms.RadioButton();
            this.rbn_resolucionMedia = new System.Windows.Forms.RadioButton();
            this.rbn_resolucionBaja = new System.Windows.Forms.RadioButton();
            this.btn_ocultar = new System.Windows.Forms.Button();
            this.btn_visualizarTodo = new System.Windows.Forms.Button();
            this.gbox_opciones = new System.Windows.Forms.GroupBox();
            this.gbox_movimientoOjo = new System.Windows.Forms.GroupBox();
            this.gbox_coordenadasLuz = new System.Windows.Forms.GroupBox();
            this.lbl_valorZluz = new System.Windows.Forms.Label();
            this.lbl_valorYluz = new System.Windows.Forms.Label();
            this.lbl_valorXluz = new System.Windows.Forms.Label();
            this.lbl_zLuz = new System.Windows.Forms.Label();
            this.lbl_yLuz = new System.Windows.Forms.Label();
            this.lbl_xLuz = new System.Windows.Forms.Label();
            this.btn_restaurarLuz = new System.Windows.Forms.Button();
            this.gbox_movimientoLuz = new System.Windows.Forms.GroupBox();
            this.btn_izqXluz = new System.Windows.Forms.Button();
            this.btn_derXluz = new System.Windows.Forms.Button();
            this.btn_izqYluz = new System.Windows.Forms.Button();
            this.btn_derYluz = new System.Windows.Forms.Button();
            this.btn_izqZluz = new System.Windows.Forms.Button();
            this.btn_derZluz = new System.Windows.Forms.Button();
            this.gbox_coordenadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbox_esfera.SuspendLayout();
            this.gbox_cilindro.SuspendLayout();
            this.gbox_cono.SuspendLayout();
            this.gbox_lineasLuz.SuspendLayout();
            this.gbox_color.SuspendLayout();
            this.gbox_resolucion.SuspendLayout();
            this.gbox_opciones.SuspendLayout();
            this.gbox_movimientoOjo.SuspendLayout();
            this.gbox_coordenadasLuz.SuspendLayout();
            this.gbox_movimientoLuz.SuspendLayout();
            this.SuspendLayout();
            // 
            // gl
            // 
            this.gl.BackColor = System.Drawing.Color.Black;
            this.gl.Location = new System.Drawing.Point(12, 38);
            this.gl.Name = "gl";
            this.gl.Size = new System.Drawing.Size(512, 512);
            this.gl.TabIndex = 0;
            this.gl.VSync = false;
            this.gl.Load += new System.EventHandler(this.gl_Load);
            this.gl.Paint += new System.Windows.Forms.PaintEventHandler(this.gl_Paint);
            this.gl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gl_MouseMove);
            this.gl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gl_KeyUp);
            this.gl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gl_MouseDown);
            this.gl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gl_MouseUp);
            this.gl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gl_KeyDown);
            // 
            // btn_xDer
            // 
            this.btn_xDer.BackColor = System.Drawing.Color.Transparent;
            this.btn_xDer.Location = new System.Drawing.Point(52, 19);
            this.btn_xDer.Name = "btn_xDer";
            this.btn_xDer.Size = new System.Drawing.Size(40, 23);
            this.btn_xDer.TabIndex = 4;
            this.btn_xDer.Text = "X =>";
            this.btn_xDer.UseVisualStyleBackColor = false;
            this.btn_xDer.Click += new System.EventHandler(this.btn_xDer_Click);
            // 
            // btn_xIzq
            // 
            this.btn_xIzq.BackColor = System.Drawing.Color.Transparent;
            this.btn_xIzq.Location = new System.Drawing.Point(6, 19);
            this.btn_xIzq.Name = "btn_xIzq";
            this.btn_xIzq.Size = new System.Drawing.Size(40, 23);
            this.btn_xIzq.TabIndex = 3;
            this.btn_xIzq.Text = "<= X";
            this.btn_xIzq.UseVisualStyleBackColor = false;
            this.btn_xIzq.Click += new System.EventHandler(this.btn_xIzq_Click);
            // 
            // btn_yIzq
            // 
            this.btn_yIzq.BackColor = System.Drawing.Color.Transparent;
            this.btn_yIzq.Location = new System.Drawing.Point(214, 19);
            this.btn_yIzq.Name = "btn_yIzq";
            this.btn_yIzq.Size = new System.Drawing.Size(40, 23);
            this.btn_yIzq.TabIndex = 5;
            this.btn_yIzq.Text = "<= Y";
            this.btn_yIzq.UseVisualStyleBackColor = false;
            this.btn_yIzq.Click += new System.EventHandler(this.btn_yIzq_Click);
            // 
            // btn_yDer
            // 
            this.btn_yDer.BackColor = System.Drawing.Color.Transparent;
            this.btn_yDer.Location = new System.Drawing.Point(260, 19);
            this.btn_yDer.Name = "btn_yDer";
            this.btn_yDer.Size = new System.Drawing.Size(40, 23);
            this.btn_yDer.TabIndex = 6;
            this.btn_yDer.Text = "Y =>";
            this.btn_yDer.UseVisualStyleBackColor = false;
            this.btn_yDer.Click += new System.EventHandler(this.btn_yDer_Click);
            // 
            // btn_zIzq
            // 
            this.btn_zIzq.BackColor = System.Drawing.Color.Transparent;
            this.btn_zIzq.Location = new System.Drawing.Point(420, 19);
            this.btn_zIzq.Name = "btn_zIzq";
            this.btn_zIzq.Size = new System.Drawing.Size(40, 23);
            this.btn_zIzq.TabIndex = 7;
            this.btn_zIzq.Text = "<= Z";
            this.btn_zIzq.UseVisualStyleBackColor = false;
            this.btn_zIzq.Click += new System.EventHandler(this.btn_zIzq_Click);
            // 
            // btn_zDer
            // 
            this.btn_zDer.BackColor = System.Drawing.Color.Transparent;
            this.btn_zDer.Location = new System.Drawing.Point(466, 19);
            this.btn_zDer.Name = "btn_zDer";
            this.btn_zDer.Size = new System.Drawing.Size(40, 23);
            this.btn_zDer.TabIndex = 8;
            this.btn_zDer.Text = "Z =>";
            this.btn_zDer.UseVisualStyleBackColor = false;
            this.btn_zDer.Click += new System.EventHandler(this.btn_zDer_Click);
            // 
            // lbl_acercaDe
            // 
            this.lbl_acercaDe.AutoSize = true;
            this.lbl_acercaDe.BackColor = System.Drawing.Color.Transparent;
            this.lbl_acercaDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_acercaDe.Location = new System.Drawing.Point(520, 727);
            this.lbl_acercaDe.Name = "lbl_acercaDe";
            this.lbl_acercaDe.Size = new System.Drawing.Size(148, 13);
            this.lbl_acercaDe.TabIndex = 0;
            this.lbl_acercaDe.Text = "por Iván Daniel Villegas Rojas";
            // 
            // btn_aumentar
            // 
            this.btn_aumentar.BackColor = System.Drawing.Color.Transparent;
            this.btn_aumentar.Location = new System.Drawing.Point(88, 9);
            this.btn_aumentar.Name = "btn_aumentar";
            this.btn_aumentar.Size = new System.Drawing.Size(70, 23);
            this.btn_aumentar.TabIndex = 2;
            this.btn_aumentar.Text = "Aumentar";
            this.btn_aumentar.UseVisualStyleBackColor = false;
            this.btn_aumentar.Click += new System.EventHandler(this.btn_aumentar_Click);
            // 
            // btn_disminuir
            // 
            this.btn_disminuir.BackColor = System.Drawing.Color.Transparent;
            this.btn_disminuir.Location = new System.Drawing.Point(12, 9);
            this.btn_disminuir.Name = "btn_disminuir";
            this.btn_disminuir.Size = new System.Drawing.Size(70, 23);
            this.btn_disminuir.TabIndex = 1;
            this.btn_disminuir.Text = "Disminuir";
            this.btn_disminuir.UseVisualStyleBackColor = false;
            this.btn_disminuir.Click += new System.EventHandler(this.btn_disminuir_Click);
            // 
            // tmrRedraw
            // 
            this.tmrRedraw.Enabled = true;
            this.tmrRedraw.Interval = 5;
            this.tmrRedraw.Tick += new System.EventHandler(this.tmrRedraw_Tick);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.BackColor = System.Drawing.Color.Transparent;
            this.btn_restaurar.Location = new System.Drawing.Point(27, 79);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(75, 23);
            this.btn_restaurar.TabIndex = 9;
            this.btn_restaurar.Text = "Restaurar";
            this.btn_restaurar.UseVisualStyleBackColor = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.ForeColor = System.Drawing.Color.Orange;
            this.lbl_x.Location = new System.Drawing.Point(7, 20);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(17, 13);
            this.lbl_x.TabIndex = 0;
            this.lbl_x.Text = "X:";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.ForeColor = System.Drawing.Color.Red;
            this.lbl_y.Location = new System.Drawing.Point(7, 38);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(17, 13);
            this.lbl_y.TabIndex = 0;
            this.lbl_y.Text = "Y:";
            // 
            // lbl_z
            // 
            this.lbl_z.AutoSize = true;
            this.lbl_z.ForeColor = System.Drawing.Color.Blue;
            this.lbl_z.Location = new System.Drawing.Point(7, 57);
            this.lbl_z.Name = "lbl_z";
            this.lbl_z.Size = new System.Drawing.Size(17, 13);
            this.lbl_z.TabIndex = 0;
            this.lbl_z.Text = "Z:";
            // 
            // lbl_valorX
            // 
            this.lbl_valorX.AutoSize = true;
            this.lbl_valorX.ForeColor = System.Drawing.Color.Orange;
            this.lbl_valorX.Location = new System.Drawing.Point(31, 19);
            this.lbl_valorX.Name = "lbl_valorX";
            this.lbl_valorX.Size = new System.Drawing.Size(10, 13);
            this.lbl_valorX.TabIndex = 0;
            this.lbl_valorX.Text = "-";
            // 
            // lbl_valorY
            // 
            this.lbl_valorY.AutoSize = true;
            this.lbl_valorY.ForeColor = System.Drawing.Color.Red;
            this.lbl_valorY.Location = new System.Drawing.Point(31, 38);
            this.lbl_valorY.Name = "lbl_valorY";
            this.lbl_valorY.Size = new System.Drawing.Size(10, 13);
            this.lbl_valorY.TabIndex = 0;
            this.lbl_valorY.Text = "-";
            // 
            // lbl_valorZ
            // 
            this.lbl_valorZ.AutoSize = true;
            this.lbl_valorZ.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valorZ.Location = new System.Drawing.Point(31, 57);
            this.lbl_valorZ.Name = "lbl_valorZ";
            this.lbl_valorZ.Size = new System.Drawing.Size(10, 13);
            this.lbl_valorZ.TabIndex = 0;
            this.lbl_valorZ.Text = "-";
            // 
            // gbox_coordenadas
            // 
            this.gbox_coordenadas.BackColor = System.Drawing.Color.Transparent;
            this.gbox_coordenadas.Controls.Add(this.lbl_valorZ);
            this.gbox_coordenadas.Controls.Add(this.lbl_valorY);
            this.gbox_coordenadas.Controls.Add(this.lbl_valorX);
            this.gbox_coordenadas.Controls.Add(this.lbl_z);
            this.gbox_coordenadas.Controls.Add(this.lbl_y);
            this.gbox_coordenadas.Controls.Add(this.lbl_x);
            this.gbox_coordenadas.Controls.Add(this.btn_restaurar);
            this.gbox_coordenadas.Location = new System.Drawing.Point(534, 616);
            this.gbox_coordenadas.Name = "gbox_coordenadas";
            this.gbox_coordenadas.Size = new System.Drawing.Size(132, 108);
            this.gbox_coordenadas.TabIndex = 10;
            this.gbox_coordenadas.TabStop = false;
            this.gbox_coordenadas.Text = "Coordenadas del ojo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Seleccion_OpenGL.Properties.Resources.Boton;
            this.pictureBox1.Location = new System.Drawing.Point(561, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 33);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gbox_esfera
            // 
            this.gbox_esfera.Controls.Add(this.txt_esferaRadio);
            this.gbox_esfera.Controls.Add(this.btn_esferaGraficar);
            this.gbox_esfera.Controls.Add(this.lbl_esferaRadio);
            this.gbox_esfera.Location = new System.Drawing.Point(534, 38);
            this.gbox_esfera.Name = "gbox_esfera";
            this.gbox_esfera.Size = new System.Drawing.Size(132, 88);
            this.gbox_esfera.TabIndex = 12;
            this.gbox_esfera.TabStop = false;
            this.gbox_esfera.Text = "Esfera";
            // 
            // txt_esferaRadio
            // 
            this.txt_esferaRadio.Location = new System.Drawing.Point(50, 23);
            this.txt_esferaRadio.Name = "txt_esferaRadio";
            this.txt_esferaRadio.Size = new System.Drawing.Size(69, 20);
            this.txt_esferaRadio.TabIndex = 2;
            // 
            // btn_esferaGraficar
            // 
            this.btn_esferaGraficar.Location = new System.Drawing.Point(28, 59);
            this.btn_esferaGraficar.Name = "btn_esferaGraficar";
            this.btn_esferaGraficar.Size = new System.Drawing.Size(75, 23);
            this.btn_esferaGraficar.TabIndex = 1;
            this.btn_esferaGraficar.Text = "Graficar";
            this.btn_esferaGraficar.UseVisualStyleBackColor = true;
            this.btn_esferaGraficar.Click += new System.EventHandler(this.btn_esferaGraficar_Click);
            // 
            // lbl_esferaRadio
            // 
            this.lbl_esferaRadio.AutoSize = true;
            this.lbl_esferaRadio.Location = new System.Drawing.Point(7, 26);
            this.lbl_esferaRadio.Name = "lbl_esferaRadio";
            this.lbl_esferaRadio.Size = new System.Drawing.Size(35, 13);
            this.lbl_esferaRadio.TabIndex = 0;
            this.lbl_esferaRadio.Text = "Radio";
            // 
            // gbox_cilindro
            // 
            this.gbox_cilindro.Controls.Add(this.txt_cilindroAltura);
            this.gbox_cilindro.Controls.Add(this.txt_cilindroRadio);
            this.gbox_cilindro.Controls.Add(this.btn_cilindroGraficar);
            this.gbox_cilindro.Controls.Add(this.lbl_cilindroAltura);
            this.gbox_cilindro.Controls.Add(this.lbl_cilindroRadio);
            this.gbox_cilindro.Location = new System.Drawing.Point(534, 132);
            this.gbox_cilindro.Name = "gbox_cilindro";
            this.gbox_cilindro.Size = new System.Drawing.Size(132, 116);
            this.gbox_cilindro.TabIndex = 12;
            this.gbox_cilindro.TabStop = false;
            this.gbox_cilindro.Text = "Cilindro";
            // 
            // txt_cilindroAltura
            // 
            this.txt_cilindroAltura.Location = new System.Drawing.Point(50, 49);
            this.txt_cilindroAltura.Name = "txt_cilindroAltura";
            this.txt_cilindroAltura.Size = new System.Drawing.Size(69, 20);
            this.txt_cilindroAltura.TabIndex = 2;
            // 
            // txt_cilindroRadio
            // 
            this.txt_cilindroRadio.Location = new System.Drawing.Point(50, 23);
            this.txt_cilindroRadio.Name = "txt_cilindroRadio";
            this.txt_cilindroRadio.Size = new System.Drawing.Size(69, 20);
            this.txt_cilindroRadio.TabIndex = 2;
            // 
            // btn_cilindroGraficar
            // 
            this.btn_cilindroGraficar.Location = new System.Drawing.Point(29, 87);
            this.btn_cilindroGraficar.Name = "btn_cilindroGraficar";
            this.btn_cilindroGraficar.Size = new System.Drawing.Size(75, 23);
            this.btn_cilindroGraficar.TabIndex = 1;
            this.btn_cilindroGraficar.Text = "Graficar";
            this.btn_cilindroGraficar.UseVisualStyleBackColor = true;
            this.btn_cilindroGraficar.Click += new System.EventHandler(this.btn_cilindroGraficar_Click);
            // 
            // lbl_cilindroAltura
            // 
            this.lbl_cilindroAltura.AutoSize = true;
            this.lbl_cilindroAltura.Location = new System.Drawing.Point(7, 52);
            this.lbl_cilindroAltura.Name = "lbl_cilindroAltura";
            this.lbl_cilindroAltura.Size = new System.Drawing.Size(34, 13);
            this.lbl_cilindroAltura.TabIndex = 0;
            this.lbl_cilindroAltura.Text = "Altura";
            // 
            // lbl_cilindroRadio
            // 
            this.lbl_cilindroRadio.AutoSize = true;
            this.lbl_cilindroRadio.Location = new System.Drawing.Point(7, 26);
            this.lbl_cilindroRadio.Name = "lbl_cilindroRadio";
            this.lbl_cilindroRadio.Size = new System.Drawing.Size(35, 13);
            this.lbl_cilindroRadio.TabIndex = 0;
            this.lbl_cilindroRadio.Text = "Radio";
            // 
            // gbox_cono
            // 
            this.gbox_cono.Controls.Add(this.txt_conoAltura);
            this.gbox_cono.Controls.Add(this.txt_conoRadio);
            this.gbox_cono.Controls.Add(this.btn_conoGraficar);
            this.gbox_cono.Controls.Add(this.lbl_conoAltura);
            this.gbox_cono.Controls.Add(this.lbl_conoRadio);
            this.gbox_cono.Location = new System.Drawing.Point(534, 254);
            this.gbox_cono.Name = "gbox_cono";
            this.gbox_cono.Size = new System.Drawing.Size(132, 116);
            this.gbox_cono.TabIndex = 12;
            this.gbox_cono.TabStop = false;
            this.gbox_cono.Text = "Cono";
            // 
            // txt_conoAltura
            // 
            this.txt_conoAltura.Location = new System.Drawing.Point(50, 49);
            this.txt_conoAltura.Name = "txt_conoAltura";
            this.txt_conoAltura.Size = new System.Drawing.Size(69, 20);
            this.txt_conoAltura.TabIndex = 2;
            // 
            // txt_conoRadio
            // 
            this.txt_conoRadio.Location = new System.Drawing.Point(50, 23);
            this.txt_conoRadio.Name = "txt_conoRadio";
            this.txt_conoRadio.Size = new System.Drawing.Size(69, 20);
            this.txt_conoRadio.TabIndex = 2;
            // 
            // btn_conoGraficar
            // 
            this.btn_conoGraficar.Location = new System.Drawing.Point(29, 87);
            this.btn_conoGraficar.Name = "btn_conoGraficar";
            this.btn_conoGraficar.Size = new System.Drawing.Size(75, 23);
            this.btn_conoGraficar.TabIndex = 1;
            this.btn_conoGraficar.Text = "Graficar";
            this.btn_conoGraficar.UseVisualStyleBackColor = true;
            this.btn_conoGraficar.Click += new System.EventHandler(this.btn_conoGraficar_Click);
            // 
            // lbl_conoAltura
            // 
            this.lbl_conoAltura.AutoSize = true;
            this.lbl_conoAltura.Location = new System.Drawing.Point(7, 52);
            this.lbl_conoAltura.Name = "lbl_conoAltura";
            this.lbl_conoAltura.Size = new System.Drawing.Size(34, 13);
            this.lbl_conoAltura.TabIndex = 0;
            this.lbl_conoAltura.Text = "Altura";
            // 
            // lbl_conoRadio
            // 
            this.lbl_conoRadio.AutoSize = true;
            this.lbl_conoRadio.Location = new System.Drawing.Point(7, 26);
            this.lbl_conoRadio.Name = "lbl_conoRadio";
            this.lbl_conoRadio.Size = new System.Drawing.Size(35, 13);
            this.lbl_conoRadio.TabIndex = 0;
            this.lbl_conoRadio.Text = "Radio";
            // 
            // gbox_lineasLuz
            // 
            this.gbox_lineasLuz.Controls.Add(this.cbn_lineasGuia);
            this.gbox_lineasLuz.Controls.Add(this.cbn_luz);
            this.gbox_lineasLuz.Location = new System.Drawing.Point(352, 672);
            this.gbox_lineasLuz.Name = "gbox_lineasLuz";
            this.gbox_lineasLuz.Size = new System.Drawing.Size(172, 52);
            this.gbox_lineasLuz.TabIndex = 13;
            this.gbox_lineasLuz.TabStop = false;
            this.gbox_lineasLuz.Text = "Lineas y luz";
            // 
            // cbn_lineasGuia
            // 
            this.cbn_lineasGuia.AutoSize = true;
            this.cbn_lineasGuia.Checked = true;
            this.cbn_lineasGuia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbn_lineasGuia.Location = new System.Drawing.Point(6, 21);
            this.cbn_lineasGuia.Name = "cbn_lineasGuia";
            this.cbn_lineasGuia.Size = new System.Drawing.Size(116, 17);
            this.cbn_lineasGuia.TabIndex = 14;
            this.cbn_lineasGuia.Text = "Ver Lineas de Guia";
            this.cbn_lineasGuia.UseVisualStyleBackColor = true;
            this.cbn_lineasGuia.CheckedChanged += new System.EventHandler(this.cbn_lineasGuia_CheckedChanged);
            // 
            // cbn_luz
            // 
            this.cbn_luz.AutoSize = true;
            this.cbn_luz.Checked = true;
            this.cbn_luz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbn_luz.Location = new System.Drawing.Point(124, 21);
            this.cbn_luz.Name = "cbn_luz";
            this.cbn_luz.Size = new System.Drawing.Size(43, 17);
            this.cbn_luz.TabIndex = 14;
            this.cbn_luz.Text = "Luz";
            this.cbn_luz.UseVisualStyleBackColor = true;
            this.cbn_luz.CheckedChanged += new System.EventHandler(this.cbn_luz_CheckedChanged);
            // 
            // gbox_color
            // 
            this.gbox_color.Controls.Add(this.rbn_colorAzul);
            this.gbox_color.Controls.Add(this.rbn_colorVerde);
            this.gbox_color.Controls.Add(this.rbn_colorRojo);
            this.gbox_color.Location = new System.Drawing.Point(181, 672);
            this.gbox_color.Name = "gbox_color";
            this.gbox_color.Size = new System.Drawing.Size(163, 52);
            this.gbox_color.TabIndex = 0;
            this.gbox_color.TabStop = false;
            this.gbox_color.Text = "Color";
            // 
            // rbn_colorAzul
            // 
            this.rbn_colorAzul.AutoSize = true;
            this.rbn_colorAzul.Location = new System.Drawing.Point(113, 20);
            this.rbn_colorAzul.Name = "rbn_colorAzul";
            this.rbn_colorAzul.Size = new System.Drawing.Size(45, 17);
            this.rbn_colorAzul.TabIndex = 0;
            this.rbn_colorAzul.TabStop = true;
            this.rbn_colorAzul.Text = "Azul";
            this.rbn_colorAzul.UseVisualStyleBackColor = true;
            this.rbn_colorAzul.CheckedChanged += new System.EventHandler(this.rbn_colorAzul_CheckedChanged);
            // 
            // rbn_colorVerde
            // 
            this.rbn_colorVerde.AutoSize = true;
            this.rbn_colorVerde.Location = new System.Drawing.Point(60, 20);
            this.rbn_colorVerde.Name = "rbn_colorVerde";
            this.rbn_colorVerde.Size = new System.Drawing.Size(53, 17);
            this.rbn_colorVerde.TabIndex = 0;
            this.rbn_colorVerde.TabStop = true;
            this.rbn_colorVerde.Text = "Verde";
            this.rbn_colorVerde.UseVisualStyleBackColor = true;
            this.rbn_colorVerde.CheckedChanged += new System.EventHandler(this.rbn_colorVerde_CheckedChanged);
            // 
            // rbn_colorRojo
            // 
            this.rbn_colorRojo.AutoSize = true;
            this.rbn_colorRojo.Checked = true;
            this.rbn_colorRojo.Location = new System.Drawing.Point(7, 20);
            this.rbn_colorRojo.Name = "rbn_colorRojo";
            this.rbn_colorRojo.Size = new System.Drawing.Size(47, 17);
            this.rbn_colorRojo.TabIndex = 0;
            this.rbn_colorRojo.TabStop = true;
            this.rbn_colorRojo.Text = "Rojo";
            this.rbn_colorRojo.UseVisualStyleBackColor = true;
            this.rbn_colorRojo.CheckedChanged += new System.EventHandler(this.rbn_colorRojo_CheckedChanged);
            // 
            // gbox_resolucion
            // 
            this.gbox_resolucion.Controls.Add(this.rbn_resolucionAlta);
            this.gbox_resolucion.Controls.Add(this.rbn_resolucionMedia);
            this.gbox_resolucion.Controls.Add(this.rbn_resolucionBaja);
            this.gbox_resolucion.Location = new System.Drawing.Point(12, 672);
            this.gbox_resolucion.Name = "gbox_resolucion";
            this.gbox_resolucion.Size = new System.Drawing.Size(163, 52);
            this.gbox_resolucion.TabIndex = 0;
            this.gbox_resolucion.TabStop = false;
            this.gbox_resolucion.Text = "Resolucion";
            // 
            // rbn_resolucionAlta
            // 
            this.rbn_resolucionAlta.AutoSize = true;
            this.rbn_resolucionAlta.Location = new System.Drawing.Point(113, 20);
            this.rbn_resolucionAlta.Name = "rbn_resolucionAlta";
            this.rbn_resolucionAlta.Size = new System.Drawing.Size(43, 17);
            this.rbn_resolucionAlta.TabIndex = 0;
            this.rbn_resolucionAlta.TabStop = true;
            this.rbn_resolucionAlta.Text = "Alta";
            this.rbn_resolucionAlta.UseVisualStyleBackColor = true;
            this.rbn_resolucionAlta.CheckedChanged += new System.EventHandler(this.rbn_resolucionAlta_CheckedChanged);
            // 
            // rbn_resolucionMedia
            // 
            this.rbn_resolucionMedia.AutoSize = true;
            this.rbn_resolucionMedia.Checked = true;
            this.rbn_resolucionMedia.Location = new System.Drawing.Point(59, 20);
            this.rbn_resolucionMedia.Name = "rbn_resolucionMedia";
            this.rbn_resolucionMedia.Size = new System.Drawing.Size(54, 17);
            this.rbn_resolucionMedia.TabIndex = 0;
            this.rbn_resolucionMedia.TabStop = true;
            this.rbn_resolucionMedia.Text = "Media";
            this.rbn_resolucionMedia.UseVisualStyleBackColor = true;
            this.rbn_resolucionMedia.CheckedChanged += new System.EventHandler(this.rbn_resolucionMedia_CheckedChanged);
            // 
            // rbn_resolucionBaja
            // 
            this.rbn_resolucionBaja.AutoSize = true;
            this.rbn_resolucionBaja.Location = new System.Drawing.Point(7, 20);
            this.rbn_resolucionBaja.Name = "rbn_resolucionBaja";
            this.rbn_resolucionBaja.Size = new System.Drawing.Size(46, 17);
            this.rbn_resolucionBaja.TabIndex = 0;
            this.rbn_resolucionBaja.TabStop = true;
            this.rbn_resolucionBaja.Text = "Baja";
            this.rbn_resolucionBaja.UseVisualStyleBackColor = true;
            this.rbn_resolucionBaja.CheckedChanged += new System.EventHandler(this.rbn_resolucionBaja_CheckedChanged);
            // 
            // btn_ocultar
            // 
            this.btn_ocultar.Enabled = false;
            this.btn_ocultar.Location = new System.Drawing.Point(29, 19);
            this.btn_ocultar.Name = "btn_ocultar";
            this.btn_ocultar.Size = new System.Drawing.Size(69, 23);
            this.btn_ocultar.TabIndex = 14;
            this.btn_ocultar.Text = "Ocultar";
            this.btn_ocultar.UseVisualStyleBackColor = true;
            this.btn_ocultar.Click += new System.EventHandler(this.btn_ocultar_Click);
            // 
            // btn_visualizarTodo
            // 
            this.btn_visualizarTodo.Location = new System.Drawing.Point(6, 57);
            this.btn_visualizarTodo.Name = "btn_visualizarTodo";
            this.btn_visualizarTodo.Size = new System.Drawing.Size(119, 23);
            this.btn_visualizarTodo.TabIndex = 15;
            this.btn_visualizarTodo.Text = "Visualizar Todos";
            this.btn_visualizarTodo.UseVisualStyleBackColor = true;
            this.btn_visualizarTodo.Click += new System.EventHandler(this.btn_visualizarTodo_Click);
            // 
            // gbox_opciones
            // 
            this.gbox_opciones.Controls.Add(this.btn_ocultar);
            this.gbox_opciones.Controls.Add(this.btn_visualizarTodo);
            this.gbox_opciones.Location = new System.Drawing.Point(534, 385);
            this.gbox_opciones.Name = "gbox_opciones";
            this.gbox_opciones.Size = new System.Drawing.Size(132, 104);
            this.gbox_opciones.TabIndex = 16;
            this.gbox_opciones.TabStop = false;
            this.gbox_opciones.Text = "Opciones";
            // 
            // gbox_movimientoOjo
            // 
            this.gbox_movimientoOjo.Controls.Add(this.btn_xIzq);
            this.gbox_movimientoOjo.Controls.Add(this.btn_xDer);
            this.gbox_movimientoOjo.Controls.Add(this.btn_yIzq);
            this.gbox_movimientoOjo.Controls.Add(this.btn_yDer);
            this.gbox_movimientoOjo.Controls.Add(this.btn_zIzq);
            this.gbox_movimientoOjo.Controls.Add(this.btn_zDer);
            this.gbox_movimientoOjo.Location = new System.Drawing.Point(12, 556);
            this.gbox_movimientoOjo.Name = "gbox_movimientoOjo";
            this.gbox_movimientoOjo.Size = new System.Drawing.Size(512, 52);
            this.gbox_movimientoOjo.TabIndex = 20;
            this.gbox_movimientoOjo.TabStop = false;
            this.gbox_movimientoOjo.Text = "Movimiento de ojo";
            // 
            // gbox_coordenadasLuz
            // 
            this.gbox_coordenadasLuz.BackColor = System.Drawing.Color.Transparent;
            this.gbox_coordenadasLuz.Controls.Add(this.lbl_valorZluz);
            this.gbox_coordenadasLuz.Controls.Add(this.lbl_valorYluz);
            this.gbox_coordenadasLuz.Controls.Add(this.lbl_valorXluz);
            this.gbox_coordenadasLuz.Controls.Add(this.lbl_zLuz);
            this.gbox_coordenadasLuz.Controls.Add(this.lbl_yLuz);
            this.gbox_coordenadasLuz.Controls.Add(this.lbl_xLuz);
            this.gbox_coordenadasLuz.Controls.Add(this.btn_restaurarLuz);
            this.gbox_coordenadasLuz.Location = new System.Drawing.Point(534, 502);
            this.gbox_coordenadasLuz.Name = "gbox_coordenadasLuz";
            this.gbox_coordenadasLuz.Size = new System.Drawing.Size(132, 108);
            this.gbox_coordenadasLuz.TabIndex = 11;
            this.gbox_coordenadasLuz.TabStop = false;
            this.gbox_coordenadasLuz.Text = "Coordenadas del luz";
            // 
            // lbl_valorZluz
            // 
            this.lbl_valorZluz.AutoSize = true;
            this.lbl_valorZluz.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valorZluz.Location = new System.Drawing.Point(31, 57);
            this.lbl_valorZluz.Name = "lbl_valorZluz";
            this.lbl_valorZluz.Size = new System.Drawing.Size(10, 13);
            this.lbl_valorZluz.TabIndex = 0;
            this.lbl_valorZluz.Text = "-";
            // 
            // lbl_valorYluz
            // 
            this.lbl_valorYluz.AutoSize = true;
            this.lbl_valorYluz.ForeColor = System.Drawing.Color.Red;
            this.lbl_valorYluz.Location = new System.Drawing.Point(31, 38);
            this.lbl_valorYluz.Name = "lbl_valorYluz";
            this.lbl_valorYluz.Size = new System.Drawing.Size(10, 13);
            this.lbl_valorYluz.TabIndex = 0;
            this.lbl_valorYluz.Text = "-";
            // 
            // lbl_valorXluz
            // 
            this.lbl_valorXluz.AutoSize = true;
            this.lbl_valorXluz.ForeColor = System.Drawing.Color.Orange;
            this.lbl_valorXluz.Location = new System.Drawing.Point(31, 19);
            this.lbl_valorXluz.Name = "lbl_valorXluz";
            this.lbl_valorXluz.Size = new System.Drawing.Size(10, 13);
            this.lbl_valorXluz.TabIndex = 0;
            this.lbl_valorXluz.Text = "-";
            // 
            // lbl_zLuz
            // 
            this.lbl_zLuz.AutoSize = true;
            this.lbl_zLuz.ForeColor = System.Drawing.Color.Blue;
            this.lbl_zLuz.Location = new System.Drawing.Point(7, 57);
            this.lbl_zLuz.Name = "lbl_zLuz";
            this.lbl_zLuz.Size = new System.Drawing.Size(17, 13);
            this.lbl_zLuz.TabIndex = 0;
            this.lbl_zLuz.Text = "Z:";
            // 
            // lbl_yLuz
            // 
            this.lbl_yLuz.AutoSize = true;
            this.lbl_yLuz.ForeColor = System.Drawing.Color.Red;
            this.lbl_yLuz.Location = new System.Drawing.Point(7, 38);
            this.lbl_yLuz.Name = "lbl_yLuz";
            this.lbl_yLuz.Size = new System.Drawing.Size(17, 13);
            this.lbl_yLuz.TabIndex = 0;
            this.lbl_yLuz.Text = "Y:";
            // 
            // lbl_xLuz
            // 
            this.lbl_xLuz.AutoSize = true;
            this.lbl_xLuz.ForeColor = System.Drawing.Color.Orange;
            this.lbl_xLuz.Location = new System.Drawing.Point(7, 20);
            this.lbl_xLuz.Name = "lbl_xLuz";
            this.lbl_xLuz.Size = new System.Drawing.Size(17, 13);
            this.lbl_xLuz.TabIndex = 0;
            this.lbl_xLuz.Text = "X:";
            // 
            // btn_restaurarLuz
            // 
            this.btn_restaurarLuz.BackColor = System.Drawing.Color.Transparent;
            this.btn_restaurarLuz.Location = new System.Drawing.Point(27, 79);
            this.btn_restaurarLuz.Name = "btn_restaurarLuz";
            this.btn_restaurarLuz.Size = new System.Drawing.Size(75, 23);
            this.btn_restaurarLuz.TabIndex = 9;
            this.btn_restaurarLuz.Text = "Restaurar";
            this.btn_restaurarLuz.UseVisualStyleBackColor = false;
            this.btn_restaurarLuz.Click += new System.EventHandler(this.btn_restaurarLuz_Click);
            // 
            // gbox_movimientoLuz
            // 
            this.gbox_movimientoLuz.Controls.Add(this.btn_izqXluz);
            this.gbox_movimientoLuz.Controls.Add(this.btn_derXluz);
            this.gbox_movimientoLuz.Controls.Add(this.btn_izqYluz);
            this.gbox_movimientoLuz.Controls.Add(this.btn_derYluz);
            this.gbox_movimientoLuz.Controls.Add(this.btn_izqZluz);
            this.gbox_movimientoLuz.Controls.Add(this.btn_derZluz);
            this.gbox_movimientoLuz.Location = new System.Drawing.Point(12, 614);
            this.gbox_movimientoLuz.Name = "gbox_movimientoLuz";
            this.gbox_movimientoLuz.Size = new System.Drawing.Size(512, 52);
            this.gbox_movimientoLuz.TabIndex = 21;
            this.gbox_movimientoLuz.TabStop = false;
            this.gbox_movimientoLuz.Text = "Movimiento de luz";
            // 
            // btn_izqXluz
            // 
            this.btn_izqXluz.BackColor = System.Drawing.Color.Transparent;
            this.btn_izqXluz.Location = new System.Drawing.Point(6, 19);
            this.btn_izqXluz.Name = "btn_izqXluz";
            this.btn_izqXluz.Size = new System.Drawing.Size(40, 23);
            this.btn_izqXluz.TabIndex = 3;
            this.btn_izqXluz.Text = "<= X";
            this.btn_izqXluz.UseVisualStyleBackColor = false;
            this.btn_izqXluz.Click += new System.EventHandler(this.btn_izqXluz_Click);
            // 
            // btn_derXluz
            // 
            this.btn_derXluz.BackColor = System.Drawing.Color.Transparent;
            this.btn_derXluz.Location = new System.Drawing.Point(52, 19);
            this.btn_derXluz.Name = "btn_derXluz";
            this.btn_derXluz.Size = new System.Drawing.Size(40, 23);
            this.btn_derXluz.TabIndex = 4;
            this.btn_derXluz.Text = "X =>";
            this.btn_derXluz.UseVisualStyleBackColor = false;
            this.btn_derXluz.Click += new System.EventHandler(this.btn_derXluz_Click);
            // 
            // btn_izqYluz
            // 
            this.btn_izqYluz.BackColor = System.Drawing.Color.Transparent;
            this.btn_izqYluz.Location = new System.Drawing.Point(214, 19);
            this.btn_izqYluz.Name = "btn_izqYluz";
            this.btn_izqYluz.Size = new System.Drawing.Size(40, 23);
            this.btn_izqYluz.TabIndex = 5;
            this.btn_izqYluz.Text = "<= Y";
            this.btn_izqYluz.UseVisualStyleBackColor = false;
            this.btn_izqYluz.Click += new System.EventHandler(this.btn_izqYluz_Click);
            // 
            // btn_derYluz
            // 
            this.btn_derYluz.BackColor = System.Drawing.Color.Transparent;
            this.btn_derYluz.Location = new System.Drawing.Point(260, 19);
            this.btn_derYluz.Name = "btn_derYluz";
            this.btn_derYluz.Size = new System.Drawing.Size(40, 23);
            this.btn_derYluz.TabIndex = 6;
            this.btn_derYluz.Text = "Y =>";
            this.btn_derYluz.UseVisualStyleBackColor = false;
            this.btn_derYluz.Click += new System.EventHandler(this.btn_derYluz_Click);
            // 
            // btn_izqZluz
            // 
            this.btn_izqZluz.BackColor = System.Drawing.Color.Transparent;
            this.btn_izqZluz.Location = new System.Drawing.Point(420, 19);
            this.btn_izqZluz.Name = "btn_izqZluz";
            this.btn_izqZluz.Size = new System.Drawing.Size(40, 23);
            this.btn_izqZluz.TabIndex = 7;
            this.btn_izqZluz.Text = "<= Z";
            this.btn_izqZluz.UseVisualStyleBackColor = false;
            this.btn_izqZluz.Click += new System.EventHandler(this.btn_izqZluz_Click);
            // 
            // btn_derZluz
            // 
            this.btn_derZluz.BackColor = System.Drawing.Color.Transparent;
            this.btn_derZluz.Location = new System.Drawing.Point(466, 19);
            this.btn_derZluz.Name = "btn_derZluz";
            this.btn_derZluz.Size = new System.Drawing.Size(40, 23);
            this.btn_derZluz.TabIndex = 8;
            this.btn_derZluz.Text = "Z =>";
            this.btn_derZluz.UseVisualStyleBackColor = false;
            this.btn_derZluz.Click += new System.EventHandler(this.btn_derZluz_Click);
            // 
            // Seleccion_OpenGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 743);
            this.Controls.Add(this.gbox_movimientoLuz);
            this.Controls.Add(this.gbox_coordenadasLuz);
            this.Controls.Add(this.gbox_movimientoOjo);
            this.Controls.Add(this.gbox_opciones);
            this.Controls.Add(this.gbox_coordenadas);
            this.Controls.Add(this.gbox_color);
            this.Controls.Add(this.gbox_resolucion);
            this.Controls.Add(this.gbox_lineasLuz);
            this.Controls.Add(this.gbox_cono);
            this.Controls.Add(this.gbox_cilindro);
            this.Controls.Add(this.gbox_esfera);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_acercaDe);
            this.Controls.Add(this.btn_disminuir);
            this.Controls.Add(this.btn_aumentar);
            this.Controls.Add(this.gl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Seleccion_OpenGL";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección en OpenGL";
            this.gbox_coordenadas.ResumeLayout(false);
            this.gbox_coordenadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbox_esfera.ResumeLayout(false);
            this.gbox_esfera.PerformLayout();
            this.gbox_cilindro.ResumeLayout(false);
            this.gbox_cilindro.PerformLayout();
            this.gbox_cono.ResumeLayout(false);
            this.gbox_cono.PerformLayout();
            this.gbox_lineasLuz.ResumeLayout(false);
            this.gbox_lineasLuz.PerformLayout();
            this.gbox_color.ResumeLayout(false);
            this.gbox_color.PerformLayout();
            this.gbox_resolucion.ResumeLayout(false);
            this.gbox_resolucion.PerformLayout();
            this.gbox_opciones.ResumeLayout(false);
            this.gbox_movimientoOjo.ResumeLayout(false);
            this.gbox_coordenadasLuz.ResumeLayout(false);
            this.gbox_coordenadasLuz.PerformLayout();
            this.gbox_movimientoLuz.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl gl;
        private System.Windows.Forms.Button btn_xDer;
        private System.Windows.Forms.Button btn_xIzq;
        private System.Windows.Forms.Button btn_yIzq;
        private System.Windows.Forms.Button btn_yDer;
        private System.Windows.Forms.Button btn_zIzq;
        private System.Windows.Forms.Button btn_zDer;
        private System.Windows.Forms.Label lbl_acercaDe;
        private System.Windows.Forms.Button btn_disminuir;
        private System.Windows.Forms.Button btn_aumentar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrRedraw;
        private System.Windows.Forms.Button btn_restaurar;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Label lbl_z;
        private System.Windows.Forms.Label lbl_valorX;
        private System.Windows.Forms.Label lbl_valorY;
        private System.Windows.Forms.Label lbl_valorZ;
        private System.Windows.Forms.GroupBox gbox_coordenadas;
        private System.Windows.Forms.GroupBox gbox_esfera;
        private System.Windows.Forms.TextBox txt_esferaRadio;
        private System.Windows.Forms.Button btn_esferaGraficar;
        private System.Windows.Forms.Label lbl_esferaRadio;
        private System.Windows.Forms.GroupBox gbox_cilindro;
        private System.Windows.Forms.TextBox txt_cilindroAltura;
        private System.Windows.Forms.TextBox txt_cilindroRadio;
        private System.Windows.Forms.Button btn_cilindroGraficar;
        private System.Windows.Forms.Label lbl_cilindroAltura;
        private System.Windows.Forms.Label lbl_cilindroRadio;
        private System.Windows.Forms.GroupBox gbox_cono;
        private System.Windows.Forms.TextBox txt_conoAltura;
        private System.Windows.Forms.TextBox txt_conoRadio;
        private System.Windows.Forms.Button btn_conoGraficar;
        private System.Windows.Forms.Label lbl_conoAltura;
        private System.Windows.Forms.Label lbl_conoRadio;
        private System.Windows.Forms.GroupBox gbox_lineasLuz;
        private System.Windows.Forms.GroupBox gbox_color;
        private System.Windows.Forms.GroupBox gbox_resolucion;
        private System.Windows.Forms.RadioButton rbn_colorAzul;
        private System.Windows.Forms.RadioButton rbn_colorVerde;
        private System.Windows.Forms.RadioButton rbn_colorRojo;
        private System.Windows.Forms.RadioButton rbn_resolucionAlta;
        private System.Windows.Forms.RadioButton rbn_resolucionMedia;
        private System.Windows.Forms.RadioButton rbn_resolucionBaja;
        private System.Windows.Forms.CheckBox cbn_lineasGuia;
        private System.Windows.Forms.CheckBox cbn_luz;
        private System.Windows.Forms.Button btn_ocultar;
        private System.Windows.Forms.Button btn_visualizarTodo;
        private System.Windows.Forms.GroupBox gbox_opciones;
        private System.Windows.Forms.GroupBox gbox_movimientoOjo;
        private System.Windows.Forms.GroupBox gbox_coordenadasLuz;
        private System.Windows.Forms.Label lbl_valorZluz;
        private System.Windows.Forms.Label lbl_valorYluz;
        private System.Windows.Forms.Label lbl_valorXluz;
        private System.Windows.Forms.Label lbl_zLuz;
        private System.Windows.Forms.Label lbl_yLuz;
        private System.Windows.Forms.Label lbl_xLuz;
        private System.Windows.Forms.Button btn_restaurarLuz;
        private System.Windows.Forms.GroupBox gbox_movimientoLuz;
        private System.Windows.Forms.Button btn_izqXluz;
        private System.Windows.Forms.Button btn_derXluz;
        private System.Windows.Forms.Button btn_izqYluz;
        private System.Windows.Forms.Button btn_derYluz;
        private System.Windows.Forms.Button btn_izqZluz;
        private System.Windows.Forms.Button btn_derZluz;
    }
}

