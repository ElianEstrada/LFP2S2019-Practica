using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Practica_1
{
    public partial class Inicio : Form
    {



        public Inicio()
        {
            InitializeComponent();
            tvArbol.NodeMouseClick += new TreeNodeMouseClickEventHandler(nodo_Click);
            

        }

        LinkedList<Actividad> actividades = new LinkedList<Actividad>();

        private void archToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarPesatañas()
        {

        }

        private void nuevaPestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabNuevo = new TabPage();
            rtbNuevo = new RichTextBox();

            rtbNuevo.Name = "Nuevo ";

            tcPestañas.Controls.Add(tabNuevo);

            tabNuevo.Controls.Add(rtbNuevo);
            //tabNuevo.Controls.Add(btnRecuperar);

            tabNuevo.Name = "Planificacion";
            tabNuevo.Padding = new System.Windows.Forms.Padding(3);
            tabNuevo.Size = new System.Drawing.Size(293, 409);
            tabNuevo.TabIndex = 0;
            tabNuevo.Text = "Pestaña Nueva";
            tabNuevo.UseVisualStyleBackColor = true;

            //this.txtNuevo.Location = new System.Drawing.Point(0, 0);
            rtbNuevo.Size = new System.Drawing.Size(297, 535);
            rtbNuevo.TabIndex = 0;
            rtbNuevo.Text = "";

        }

        private TabPage tabNuevo;
        private RichTextBox rtbNuevo;
        private static int contador = 0;

        public RichTextBox getText()
        {
            RichTextBox texto = null;

            TabPage pagina = tcPestañas.SelectedTab;

            if (pagina != null)
            {
                texto = pagina.Controls[0] as RichTextBox;
            } else
            {
                MessageBox.Show("No hay pestañas activas");
            }

            return texto;
        }

        public TabPage getPestaña()
        {
            TabPage pestaña = null;

            tabNuevo = tcPestañas.SelectedTab;

            if(tabNuevo != null)
            {
                pestaña = tabNuevo.Controls[0] as TabPage;
            }else
            {
                MessageBox.Show("No hay pestañas activas");
            }

            return pestaña;
        }

        private void btnRecuperar_Clic(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        Analizador_Lexico lex = new Analizador_Lexico();
        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            rtbDescripcion.Text = "";
            pbImagen.Image = null;
            int contador = 0;
            String entrada;
            try
            {
                entrada = getText().Text;
                LinkedList<Token> lTokens = lex.escanear(entrada);
                lex.imprimir(lTokens);
                Console.WriteLine("");
                lex.imprimirErrores(lTokens);
                lex.setFila(1);
                foreach(Token item in lTokens)
                {
                    if(item.getTipoToken() != "DESCONOCIDO")
                    {
                        continue;
                    }else
                    {
                        contador++;
                    }
                }

                if(contador == 0)
                {
                    obtenerDatos();
                }
                else
                {
                    tvArbol.Nodes.Clear();
                    mcCalendario.RemoveAllBoldedDates();
                    actividades.Clear();
                }

                try
                {
                    Process proceso = new Process();
                    Process proceso1 = new Process();
                    proceso.StartInfo.FileName = "Archivos\\Tokens.html";
                    proceso1.StartInfo.FileName = "Archivos\\Errores.html";
                    proceso.Start();
                    proceso1.Start();
                }
                catch (Exception)
                {

                }
            }
            catch (Exception)
            {
                tvArbol.Nodes.Clear();
                mcCalendario.RemoveAllBoldedDates();
            }

            
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String contenido = String.Empty;
                String extencion = String.Empty;

                OpenFileDialog file = new OpenFileDialog();

                //file.InitialDirectory = "c:\\Imagenes";
                file.Filter = "ly Archivos (*.ly)|*.ly";
                file.FilterIndex = 2;
                file.RestoreDirectory = true;

                if (file.ShowDialog() == DialogResult.OK)
                {
                    extencion = file.SafeFileName;

                    var lectura = file.OpenFile();

                    StreamReader leer = new StreamReader(lectura);

                    contenido = leer.ReadToEnd();
                    //Console.WriteLine(contenido);

                    tabNuevo.Text = Path.GetFileNameWithoutExtension(extencion);

                    try
                    {
                        getText().Text = contenido;
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay ninguna pestaña activa");
            }
        }

        
        private void fechasImportantes(int dia, int mes, int año)
        {

            mcCalendario.AddBoldedDate(new DateTime(año, mes, dia));
            mcCalendario.UpdateBoldedDates();

        }

        public void obtenerDatos()
        {
            try
            {
                String tipoFecha = "";
                int año = 0;
                int mes = 0;
                int dia = 0;
                int nodoAño = -1;
                int nodomes = -1;
                int nodoPlani = -1;
                String planificador = "";
                String cadenas = "";
                String descripcion = "";
                String imagen = "";

                tvArbol.Nodes.Clear();
                mcCalendario.RemoveAllBoldedDates();
                actividades.Clear();
                
                foreach (Token item in lex.getLista())
                {
                    if (item.getLexema().Equals("anio", StringComparison.InvariantCultureIgnoreCase))
                    {
                        tipoFecha = "anio";
                    }
                    else if (item.getLexema().Equals("mes", StringComparison.InvariantCultureIgnoreCase))
                    {
                        tipoFecha = "mes";
                    }
                    else if (item.getLexema().Equals("dia", StringComparison.InvariantCultureIgnoreCase))
                    {
                        tipoFecha = "dia";
                    }
                    else if (item.getLexema().Equals("planificador", StringComparison.InvariantCultureIgnoreCase))
                    {
                        planificador = item.getLexema();
                    }else if (item.getLexema().Equals("descripcion", StringComparison.InvariantCultureIgnoreCase))
                    {
                        cadenas = "descripcion";
                    }else if(item.getLexema().Equals("imagen", StringComparison.InvariantCultureIgnoreCase))
                    {
                        cadenas = "imagen";
                    }

                    if (planificador.Equals("planificador", StringComparison.InvariantCultureIgnoreCase))
                    {
                        if (item.getTipoToken().Equals("CADENA_DE_TEXTO"))
                        {
                            tvArbol.Nodes.Add(item.getLexema());
                            planificador = "";
                            nodoPlani++;
                            nodoAño = -1;
                            nodomes = -1;
                        }
                    }

                    if (tipoFecha.Equals("anio"))
                    {
                        if (item.getTipoToken().Equals("NÚMERO"))
                        {
                            año = int.Parse(item.getLexema());
                            tvArbol.Nodes[nodoPlani].Nodes.Add(item.getLexema());
                            nodoAño++;
                            nodomes = -1;
                        }
                    }
                    else if (tipoFecha.Equals("mes"))
                    {
                        if (item.getTipoToken().Equals("NÚMERO"))
                        {
                            mes = int.Parse(item.getLexema());
                            tvArbol.Nodes[nodoPlani].Nodes[nodoAño].Nodes.Add(item.getLexema());
                            nodomes++;
                        }
                    }
                    else if (tipoFecha.Equals("dia"))
                    {
                        if (item.getTipoToken().Equals("NÚMERO"))
                        {
                            dia = int.Parse(item.getLexema());
                            tvArbol.Nodes[nodoPlani].Nodes[nodoAño].Nodes[nodomes].Nodes.Add(item.getLexema());

                            fechasImportantes(dia, mes, año);

                            tipoFecha = "";
                        }
                    }else if (cadenas.Equals("descripcion"))
                    {
                        if (item.getTipoToken().Equals("CADENA_DE_TEXTO"))
                        {

                            if(existeFecha(new DateTime(año, mes, dia)))
                            {
                                foreach(Actividad acti in actividades)
                                {
                                    if(acti.getFecha().Equals(new DateTime(año, mes, dia)))
                                    {
                                        descripcion = item.getLexema();
                                        acti.setDescripción(descripcion);
                                    }
                                }
                            }else
                            {
                                descripcion = item.getLexema();
                            }
                        }
                    }else if (cadenas.Equals("imagen"))
                    {
                        if (item.getTipoToken().Equals("CADENA_DE_TEXTO"))
                        {
                            if(existeFecha(new DateTime(año, mes, dia)))
                            {

                            }
                            else
                            {
                                imagen = item.getLexema();
                            }

                            actividades.AddLast(new Actividad(new DateTime(año, mes, dia), descripcion, imagen));
                        }
                    }
                }

                tvArbol.ExpandAll();
            }
            catch (Exception)
            {
                
            }

        }

        public Boolean existeFecha(DateTime fecha)
        {
            if(actividades.Count != 0)
            {
                foreach(Actividad item in actividades)
                {
                    if (item.getFecha().Equals(fecha))
                    {
                        return true;
                    }else
                    {
                        continue;
                    }
                }
            }
            return false;
        }

        public void nodo_Click(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                int año, mes, dia = 0;

                String[] atributos = e.Node.FullPath.Split('/');
                año = int.Parse(atributos[1]);
                mes = int.Parse(atributos[2]);
                dia = int.Parse(atributos[3]);

                mcCalendario.SetDate(new DateTime(año, mes, dia));
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor seleccionar un Día");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guardarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfdGuardar = new SaveFileDialog();

                sfdGuardar.Filter = "ly files (*.txt)|*.ly";

                if (sfdGuardar.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfdGuardar.FileName, getText().Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay ninguna pestaña abierta");
            }
        }

        private void mcCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            foreach(Actividad item in actividades)
            {
                try
                {
                    if (item.getFecha().Equals(e.Start))
                    {
                        
                        try
                        {
                            rtbDescripcion.Text = item.getDescripcion();
                            pbImagen.Image = Image.FromFile(item.getImagenPath());
                            
                        }
                        catch (Exception)
                        {
                            pbImagen.Image = Image.FromFile("Imagenes\\error.png");
                            //rtbDescripcion.Text = "";
                        }
                        break;
                    }else
                    {
                        pbImagen.Image = null;
                        rtbDescripcion.Text = "";
                    }
                }
                catch (Exception)
                {
                    
                }
            }
        }

        private void manualAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process proceso = new Process();
                proceso.StartInfo.FileName = "Archivos\\Manual de Usuario.pdf";
                proceso.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro el archivo");
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe op = new AcercaDe();
            op.Visible = true;
        }
    }
}
