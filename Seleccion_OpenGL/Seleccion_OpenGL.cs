using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenTK.Graphics;
using OpenTK;
using System.IO;
using Glu = OpenTK.Graphics.Glu;

namespace Seleccion_OpenGL
{
    public partial class Seleccion_OpenGL : Form
    {
        int eyeX = 800, eyeY = 400, eyeZ = 2300;
        int somX = 100, somY = 100, somZ = 100;
        List<Int32> GList;
        List<Dot> dots = new List<Dot>();
        List<Line> lines = new List<Line>();
        List<Rectangle> rectangles = new List<Rectangle>();
        List<Sphere> spheres = new List<Sphere>();
        List<Cylinder> cylinders = new List<Cylinder>();
        List<Cone> cones = new List<Cone>();
        int calidadCapas = 50, calidadCuadrados = 50;
        bool luz = true;
        Color color = Color.Red;
        Int32 seleccionado = 0, ocultar = 0;
        double posX, posY, posZ, auxPosZ;
        decimal barX = 0, barY = 0, barZ = 0;
        bool activarZ = false;
        bool isOcultar = false;
        bool loaded = false;

        public Seleccion_OpenGL()
        {
            InitializeComponent();
        }

        private void gl_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded) 
                return;

            if (GList == null)
                return;

            loaded = false;
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Glu.Perspective(MathHelper.PiOver2, 1F, 0.1F, 20000F);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            Glu.LookAt(eyeX, eyeY, eyeZ, 0, 0, 0, 0, 1, 0);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.PushMatrix();

            float[] mat_diffuse = { 1f, 1f, 1f };
            GL.Material(MaterialFace.Front, MaterialParameter.Diffuse, mat_diffuse);

            //light loading
            float[] light_position1 = { somX, somY, somZ, 1f };
            GL.Light(LightName.Light0, LightParameter.Position, light_position1);
            GL.Light(LightName.Light0, LightParameter.SpotDirection, 1);
            GL.Light(LightName.Light0, LightParameter.SpotExponent, 2);

            //enabling GL-options
            GL.Enable(EnableCap.Light0);
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.ColorMaterial);
            GL.Enable(EnableCap.CullFace);

            if (luz)
                GL.Enable(EnableCap.Lighting);
            else
                GL.Disable(EnableCap.Lighting);

            for (int i = 0; i < GList.Count; i++)
                GL.CallList(GList[i]);

            GL.PopMatrix();
            GL.Finish();
            gl.SwapBuffers();

            loaded = true;
        }

        private void gl_Load(object sender, EventArgs e)
        {
            loaded = true;
            GL.ClearColor(Color.Black);

            generarFlechas();
            actualizarValor();
            actualizarValorLuz();

            rectanguloLinear();
        }

        private void tmrRedraw_Tick(object sender, EventArgs e)
        {
            GList = new List<Int32>();
            GList.Add(0);
            foreach (Dot dot in dots)
            {
                if (dot.visible)
                {
                    GL.NewList(GList.Count, ListMode.Compile);
                    GL.PointSize(5);
                    GL.Begin(BeginMode.Points);
                    GL.Color3(dot.color);

                    decimal[] aux_dot = FactoryMatrix.xVxM(dot.matrix, dot.dot);
                    GL.Vertex3(Decimal.ToDouble(aux_dot[0]), Decimal.ToDouble(aux_dot[1]), Decimal.ToDouble(aux_dot[2]));

                    GL.End();
                    GL.EndList();
                    GList.Add(GList.Count);
                }
            }

            foreach (Line line in lines)
            {
                if (line.visible)
                {
                    decimal[] from = FactoryMatrix.xVxM(line.matrix, line.from);
                    decimal[] to = FactoryMatrix.xVxM(line.matrix, line.to);

                    GL.NewList(GList.Count, ListMode.Compile);
                    GL.Begin(BeginMode.Lines);

                    GL.LineWidth(line.width);
                    GL.Color3(line.color);
                    GL.Vertex3(Decimal.ToDouble(from[0]), Decimal.ToDouble(from[1]), Decimal.ToDouble(from[2]));
                    GL.Vertex3(Decimal.ToDouble(to[0]), Decimal.ToDouble(to[1]), Decimal.ToDouble(to[2]));

                    GL.End();
                    GL.EndList();
                    GList.Add(GList.Count);
                }
            }

            foreach (Rectangle rectangle in rectangles)
            {
                if (rectangle.visible)
                {
                    GL.NewList(GList.Count, ListMode.Compile);
                    GL.PointSize(5);
                    GL.Begin(BeginMode.Lines);
                    GL.Color3(rectangle.color);
                    for (int i = 0; i < rectangle.points.Count; i++)
                    {
                        decimal[] aux_dot = FactoryMatrix.xVxM(rectangle.matrix, rectangle.points[i]);
                        GL.Vertex3(Decimal.ToDouble(aux_dot[0]), Decimal.ToDouble(aux_dot[1]), Decimal.ToDouble(aux_dot[2]));
                    }
                    GL.End();
                    GL.EndList();
                    GList.Add(GList.Count);
                }
                else//Para mantener los rectangulos en GList
                {
                    GL.NewList(GList.Count, ListMode.Compile);
                    GL.Begin(BeginMode.Lines);
                    GL.End();
                    GL.EndList();
                    GList.Add(GList.Count);
                }
            }

            foreach (Sphere sphere in spheres)
            {
                if (sphere.visible)
                {
                    if (GList.Count == seleccionado)
                    {
                        if (posX != 0 && posY != 0)
                        {
                            sphere.posX = posX / 7;
                            sphere.posY = posY / 7;
                            if (activarZ)
                                sphere.posZ = posZ;
                        }
                        for (int item = 0; item < 6; item++)
                        {
                            Rectangle r = rectangles[item];

                            r.matrix = FactoryMatrix.getIdentity();
                            r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(-barX, -barY, -barZ), r.matrix);
                            r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getScale(Convert.ToDecimal(sphere.radio * 2), Convert.ToDecimal(sphere.radio * 2), Convert.ToDecimal(sphere.radio * 2)), r.matrix);
                            r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(Convert.ToDecimal(-sphere.posX), Convert.ToDecimal(-sphere.posY), Convert.ToDecimal(-sphere.posZ)), r.matrix);
                            r.visible = true;
                        }
                    }

                    GL.NewList(GList.Count, ListMode.Compile);
                    GL.PushMatrix();
                    GL.LoadName(GList.Count);
                    GL.Color3(color);
                    IntPtr q = Glu.NewQuadric();
                    
                    GL.Translate(-sphere.posX, -sphere.posY, -sphere.posZ);
                    Glu.Sphere(q, sphere.radio, calidadCapas, calidadCuadrados);
                    GL.Translate(sphere.posX, sphere.posY, sphere.posZ);

                    GL.PopMatrix();
                    GL.EndList();
                    GList.Add(GList.Count);
                }
                if (isOcultar == true && GList.Count - 1 == ocultar)
                {
                    sphere.visible = false;
                    for (int item = 0; item < 6; item++)
                    {
                        Rectangle r = rectangles[item];
                        r.visible = false;
                    }
                    isOcultar = false;
                    ocultar = 0;
                    btn_ocultar.Enabled = false;
                }
            }
            
            foreach (Cone cone in cones)
            {
                if (cone.visible)
                {
                    if (GList.Count == seleccionado)
                    {
                        if (posX != 0 && posY != 0)
                        {
                            cone.posX = posX / 7;
                            cone.posY = posY / 7;
                            if (activarZ)
                                cone.posZ = posZ;
                        }
                        for (int item = 0; item < 6; item++)
                        {
                            Rectangle r = rectangles[item];

                            r.matrix = FactoryMatrix.getIdentity();
                            r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(-barX, -barY, -barZ), r.matrix);
                            r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getScale(Convert.ToDecimal(cone.radio * 2), Convert.ToDecimal(cone.radio * 2), Convert.ToDecimal(cone.altura)), r.matrix);
                            r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(Convert.ToDecimal(-cone.posX), Convert.ToDecimal(-cone.posY), Convert.ToDecimal(-cone.posZ)), r.matrix);
                            r.visible = true;
                        }
                    }

                    GL.NewList(GList.Count, ListMode.Compile);
                    GL.PushMatrix();
                    GL.LoadName(GList.Count);
                    GL.Color3(color);
                    IntPtr q = Glu.NewQuadric();

                    GL.Translate(-cone.posX, -cone.posY, -cone.posZ - (cone.altura / 2));
                    Glu.Cylinder(q, cone.radio, 0, cone.altura, calidadCapas, calidadCuadrados);
                    GL.Translate(cone.posX, cone.posY, cone.posZ + (cone.altura / 2));

                    GL.PopMatrix();
                    GL.EndList();
                    GList.Add(GList.Count);
                }
                if (isOcultar && GList.Count - 1 == ocultar)
                {
                    cone.visible = false;
                    for (int item = 0; item < 6; item++)
                    {
                        Rectangle r = rectangles[item];
                        r.visible = false;
                    }
                    isOcultar = false;
                    ocultar = 0;
                    btn_ocultar.Enabled = false;
                }
            }
            
            foreach (Cylinder cylinder in cylinders)
            {
                if (cylinder.visible)
                {
                    if (GList.Count == seleccionado)
                    {
                        if (posX != 0 && posY != 0)
                        {
                            cylinder.posX = posX / 7;
                            cylinder.posY = posY / 7;
                            if (activarZ)
                                cylinder.posZ = posZ;
                        }
                        for (int item = 0; item < 6; item++)
                        {
                            Rectangle r = rectangles[item];

                            r.matrix = FactoryMatrix.getIdentity();
                            r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(-barX, -barY, -barZ), r.matrix);
                            r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getScale(Convert.ToDecimal(cylinder.radio * 2), Convert.ToDecimal(cylinder.radio * 2), Convert.ToDecimal(cylinder.altura)), r.matrix);
                            r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(Convert.ToDecimal(-cylinder.posX), Convert.ToDecimal(-cylinder.posY), Convert.ToDecimal(-cylinder.posZ)), r.matrix);
                            r.visible = true;
                        }
                    }

                    GL.NewList(GList.Count, ListMode.Compile);
                    GL.PushMatrix();
                    GL.LoadName(GList.Count);
                    GL.Color3(color);
                    IntPtr q = Glu.NewQuadric();

                    GL.Translate(-cylinder.posX, -cylinder.posY, -cylinder.posZ - (cylinder.altura / 2));
                    Glu.Cylinder(q, cylinder.radio, cylinder.radio, cylinder.altura, calidadCapas, calidadCuadrados);
                    GL.Translate(cylinder.posX, cylinder.posY, cylinder.posZ + (cylinder.altura / 2));

                    GL.PopMatrix();
                    GL.EndList();
                    GList.Add(GList.Count);
                }
                if (isOcultar && GList.Count - 1 == ocultar)
                {
                    cylinder.visible = false;
                    for (int item = 0; item < 6; item++)
                    {
                        Rectangle r = rectangles[item];
                        r.visible = false;
                    }
                    isOcultar = false;
                    ocultar = 0;
                    btn_ocultar.Enabled = false;
                }
            }

            gl_Paint(gl, null);
        }

        #region Trabajo practico 3 (flechas y sus botones)
        private void generarFlechas()
        {
            lineGenerator(1, Color.Yellow, -100, 0, 0, 100, 0, 0);
            lineGenerator(1, Color.Yellow, -100, 0, 0, -90, 0, 5);
            lineGenerator(1, Color.Yellow, -100, 0, 0, -90, 0, -5);
            lineGenerator(1, Color.Yellow, 100, 0, 0, 90, 0, 5);
            lineGenerator(1, Color.Yellow, 100, 0, 0, 90, 0, -5);

            lineGenerator(1, Color.Red, 0, -100, 0, 0, 100, 0);
            lineGenerator(1, Color.Red, 0, -100, 0, 5, -90, 0);
            lineGenerator(1, Color.Red, 0, -100, 0, -5, -90, 0);
            lineGenerator(1, Color.Red, 0, 100, 0, 5, 90, 0);
            lineGenerator(1, Color.Red, 0, 100, 0, -5, 90, 0);

            lineGenerator(1, Color.Blue, 0, 0, -100, 0, 0, 100);
            lineGenerator(1, Color.Blue, 0, 0, -100, 0, 5, -90);
            lineGenerator(1, Color.Blue, 0, 0, -100, 0, -5, -90);
            lineGenerator(1, Color.Blue, 0, 0, 100, 0, 5, 90);
            lineGenerator(1, Color.Blue, 0, 0, 100, 0, -5, 90);
        }

        private void lineGenerator(float width, Color color, int x1, int y1, int z1, int x2, int y2, int z2)
        {
            Line temp = new Line();

            temp.from[0] = x1;
            temp.from[1] = y1;
            temp.from[2] = z1;
            temp.to[0] = x2;
            temp.to[1] = y2;
            temp.to[2] = z2;
            temp.color = color;
            temp.width = width;
            lines.Add(temp);
        }

        private void btn_xIzq_Click(object sender, EventArgs e)
        {
            eyeX += 50;
            actualizarValor();
        }

        private void btn_xDer_Click(object sender, EventArgs e)
        {
            eyeX -= 50;
            actualizarValor();
        }

        private void btn_yIzq_Click(object sender, EventArgs e)
        {
            eyeY += 50;
            actualizarValor();
        }

        private void btn_yDer_Click(object sender, EventArgs e)
        {
            eyeY -= 50;
            actualizarValor();
        }

        private void btn_zIzq_Click(object sender, EventArgs e)
        {
            eyeZ += 50;
            actualizarValor();
        }

        private void btn_zDer_Click(object sender, EventArgs e)
        {
            eyeZ -= 50;
            actualizarValor();
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            eyeX = 800;
            eyeY = 400;
            eyeZ = 2300;
            actualizarValor();
        }

        private void actualizarValor()
        {
            lbl_valorX.Text = eyeX.ToString();
            lbl_valorY.Text = eyeY.ToString();
            lbl_valorZ.Text = eyeZ.ToString();
        }

        private void btn_izqXluz_Click(object sender, EventArgs e)
        {
            somX += 50;
            actualizarValorLuz();
        }

        private void btn_derXluz_Click(object sender, EventArgs e)
        {
            somX -= 50;
            actualizarValorLuz();
        }

        private void btn_izqYluz_Click(object sender, EventArgs e)
        {
            somY += 50;
            actualizarValorLuz();
        }

        private void btn_derYluz_Click(object sender, EventArgs e)
        {
            somY -= 50;
            actualizarValorLuz();
        }

        private void btn_izqZluz_Click(object sender, EventArgs e)
        {
            somZ += 50;
            actualizarValorLuz();
        }

        private void btn_derZluz_Click(object sender, EventArgs e)
        {
            somZ -= 50;
            actualizarValorLuz();
        }

        private void btn_restaurarLuz_Click(object sender, EventArgs e)
        {
            somX = 100;
            somY = 100;
            somZ = 100;
            actualizarValorLuz();
        }

        private void actualizarValorLuz()
        {
            lbl_valorXluz.Text = somX.ToString();
            lbl_valorYluz.Text = somY.ToString();
            lbl_valorZluz.Text = somZ.ToString();
        }

        private void btn_aumentar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (eyeX > 0)
                    eyeX -= 25;
                else
                    eyeX += 25;

                if (eyeY > 0)
                    eyeY -= 25;
                else
                    eyeY += 25;

                if (eyeZ > 0)
                    eyeZ -= 25;
                else
                    eyeZ += 25;
                actualizarValor();
                System.Threading.Thread.Sleep(10);
                Application.DoEvents();
            }
        }

        private void btn_disminuir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (eyeX > 0)
                    eyeX += 25;
                else
                    eyeX -= 25;

                if (eyeY > 0)
                    eyeY += 25;
                else
                    eyeY -= 25;

                if (eyeZ > 0)
                    eyeZ += 25;
                else
                    eyeZ -= 25;
                actualizarValor();
                System.Threading.Thread.Sleep(10);
                Application.DoEvents();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_AcercaDe from = new Form_AcercaDe();
            from.ShowDialog();
        }
        #endregion

        private void rectanguloLinear()
        {
            Rectangle r;
            decimal ancho = 1, alto = 1;

            /* Cara 1 */
            r = new Rectangle();
            r.points[1][1] = ancho;
            r.points[2][0] = ancho;
            r.points[2][1] = ancho;
            r.points[3][0] = ancho;
            r.color = Color.GreenYellow;
            r.visible = false;
            rectangles.Add(r);

            /* Cara 2 */
            r = new Rectangle();
            r.points[0][1] = ancho;
            r.points[1][0] = ancho;
            r.points[1][1] = ancho;
            r.points[2][0] = ancho;
            r.points[2][1] = ancho;
            r.points[2][2] = alto;
            r.points[3][1] = ancho;
            r.points[3][2] = alto;
            r.color = Color.GreenYellow;
            r.visible = false;
            rectangles.Add(r);

            /* Cara 3 */
            r = new Rectangle();
            r.points[0][2] = alto;
            r.points[1][1] = ancho;
            r.points[1][2] = alto;
            r.points[2][0] = ancho;
            r.points[2][1] = ancho;
            r.points[2][2] = alto;
            r.points[3][0] = ancho;
            r.points[3][2] = alto;
            r.color = Color.GreenYellow;
            r.visible = false;
            rectangles.Add(r);

            /* Cara 4 */
            r = new Rectangle();
            r.points[1][0] = ancho;
            r.points[2][0] = ancho;
            r.points[2][2] = alto;
            r.points[3][2] = alto;
            r.color = Color.GreenYellow;
            r.visible = false;
            rectangles.Add(r);

            /* Cara 5 */
            r = new Rectangle();
            r.points[0][0] = ancho;
            r.points[1][0] = ancho;
            r.points[1][2] = alto;
            r.points[2][0] = ancho;
            r.points[2][1] = ancho;
            r.points[2][2] = alto;
            r.points[3][0] = ancho;
            r.points[3][1] = ancho;
            r.color = Color.GreenYellow;
            r.visible = false;
            rectangles.Add(r);

            /* Cara 6 */
            r = new Rectangle();
            r.points[1][2] = alto;
            r.points[2][1] = ancho;
            r.points[2][2] = alto;
            r.points[3][1] = ancho;
            r.color = Color.GreenYellow;
            r.visible = false;
            rectangles.Add(r);

            for (int item = 0; item < 6; item++)
            {
                r = rectangles[item];
                barX += r.points[0][0] + r.points[1][0] + r.points[2][0] + r.points[3][0];
                barY += r.points[0][1] + r.points[1][1] + r.points[2][1] + r.points[3][1];
                barZ += r.points[0][2] + r.points[1][2] + r.points[2][2] + r.points[3][2];
            }
            barX /= 24;
            barY /= 24;
            barZ /= 24;
        }

        private void cbn_lineasGuia_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                lines[i].visible = cbn_lineasGuia.Checked;
            }
        }

        private void cbn_luz_CheckedChanged(object sender, EventArgs e)
        {
            luz = cbn_luz.Checked;
        }

        private void rbn_resolucionBaja_CheckedChanged(object sender, EventArgs e)
        {
            calidadCapas = 10;
            calidadCuadrados = 10;
        }

        private void rbn_resolucionMedia_CheckedChanged(object sender, EventArgs e)
        {
            calidadCapas = 50;
            calidadCuadrados = 50;
        }

        private void rbn_resolucionAlta_CheckedChanged(object sender, EventArgs e)
        {
            calidadCapas = 100;
            calidadCuadrados = 100;
        }

        private void rbn_colorRojo_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Red;
        }

        private void rbn_colorVerde_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Green;
        }

        private void rbn_colorAzul_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Blue;
        }

        private void btn_esferaGraficar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_esferaRadio.Text) <= 0)
                {
                    mensajeErrorValoresNegativos();
                    return;
                }
                Sphere sphere = new Sphere(Convert.ToDouble(txt_esferaRadio.Text), true);
                spheres.Add(sphere);
            }
            catch (FormatException)
            {
                mensajeErrorValoresNumericos();
            }
        }

        private void btn_cilindroGraficar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_cilindroRadio.Text) <= 0 || Convert.ToDouble(txt_cilindroAltura.Text) <= 0)
                {
                    mensajeErrorValoresNegativos();
                    return;
                }
                Cylinder cylinder = new Cylinder(Convert.ToDouble(txt_cilindroRadio.Text), Convert.ToDouble(txt_cilindroAltura.Text), true);
                cylinders.Add(cylinder);
            }
            catch (FormatException)
            {
                mensajeErrorValoresNumericos();
            }
        }

        private void btn_conoGraficar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_conoRadio.Text) <= 0 || Convert.ToDouble(txt_conoAltura.Text) <= 0)
                {
                    mensajeErrorValoresNegativos();
                    return;
                }
                Cone Cone = new Cone(Convert.ToDouble(txt_conoRadio.Text), Convert.ToDouble(txt_conoAltura.Text), true);
                cones.Add(Cone);
            }
            catch (FormatException)
            {
                mensajeErrorValoresNumericos();
            }
        }

        private void gl_MouseDown(object sender, MouseEventArgs e)
        {
            double minZ = 0;
            int idx = 0;
            int[] selectBuff = new int[512];
            int[] Viewports = new int[4];

            loaded = false;
            GL.SelectBuffer(512, selectBuff);
            GL.GetInteger(GetPName.Viewport, Viewports);
            GL.RenderMode(RenderingMode.Select);
            GL.InitNames();
            GL.PushName(-1);

            //camara aplicar
            int[] Viewports2 = new int[4];
            GL.GetInteger(GetPName.Viewport, Viewports2);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Glu.PickMatrix(e.X, (Viewports2[3] - e.Y), 1, 1, Viewports2);
            Glu.Perspective(MathHelper.PiOver2, 1F, 0.1F, 20000F);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            Glu.LookAt(eyeX, eyeY, eyeZ, 0, 0, 0, 0, 1, 0);
            //camara aplicar

            GL.PushMatrix();
            for (int i = 1; i < GList.Count; i++)
                GL.CallList(GList[i]);
            GL.PopMatrix();
            GL.Flush();
            long hits = GL.RenderMode(RenderingMode.Render);

            if (!(hits == 0))
            {
                minZ = 2147483647;
                idx = 0;
                seleccionado = 0;

                int NameNos;
                for (int i = 0; i < hits; i++)
                {
                    NameNos = selectBuff[idx];

                    if ((selectBuff[idx + 1] < minZ) && (NameNos > 0))
                    {
                        minZ = selectBuff[idx + 1];
                        seleccionado = selectBuff[idx + 3];
                        btn_ocultar.Enabled = true;
                    }
                    idx = idx + 3 + NameNos;
                }

            }
            else
            {
                seleccionado = 0;
            }
            ocultar = seleccionado;
            loaded = true;
        }

        private void gl_MouseMove(object sender, MouseEventArgs e)
        {
            if (seleccionado != 0)
            {
                if (posX == 0)
                    btn_restaurar_Click(sender, e);

                if (activarZ)
                {
                    if (e.Y < auxPosZ)
                        posZ += 2;
                    else if (e.Y > auxPosZ)
                        posZ -= 2;

                    auxPosZ = e.Y;
                }
                else
                {
                    posX = 255 - e.X;
                    auxPosZ = posY = e.Y - 255;
                }
            }
            else
            {
                posX = posY = posZ = auxPosZ = 0;
            }
        }

        private void gl_MouseUp(object sender, MouseEventArgs e)
        {
            seleccionado = 0;
            activarZ = false;
        }

        private void gl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.ControlKey | Keys.Control))
            {
                activarZ = true;
            }
            else
            {
                activarZ = false;
            }
        }

        private void gl_KeyUp(object sender, KeyEventArgs e)
        {
            activarZ = false;
        }

        private void btn_ocultar_Click(object sender, EventArgs e)
        {
            isOcultar = true;
        }

        private void btn_visualizarTodo_Click(object sender, EventArgs e)
        {
            foreach (Sphere sphere in spheres)
            {
                sphere.visible = true;
            }
            foreach (Cylinder cylinde in cylinders)
            {
                cylinde.visible = true;
            }
            foreach (Cone cone in cones)
            {
                cone.visible = true;
            }
        }

        public void mensajeErrorValoresNumericos()
        {
            MessageBox.Show("Ingresa valores correctos.", "Valores incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void mensajeErrorValoresNegativos()
        {
            MessageBox.Show("Ingresa valores positivos.", "Valores incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}