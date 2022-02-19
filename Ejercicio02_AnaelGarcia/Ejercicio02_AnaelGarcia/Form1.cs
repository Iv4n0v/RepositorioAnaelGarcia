using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02_AnaelGarcia
{
    public partial class Form1 : Form
    {
        private int[] edades = new int[10];             //Vector para las edades      
        private string[] nombres = new string[10];      //Vector para los nombres
        private int contador = 0;                       //Contador para los estudiantes
        
        public Form1()
        {
            InitializeComponent();
            nombreTextBox1.Text = " ";                  //Inicializamos para no guardar valores vacios
            edadTextBox2.Text = " ";                    //Inicializamos para no guardar valores vacios
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Procedimiento para añadir estuadiantes a los vectores
        private void añadirButton1_Click(object sender, EventArgs e)
        {
           //Condicion para no agregar mas alumnos de nuestra capacidad (limite 10)
            if (contador < 10)
            {
                //Condicion para determinar si los textbox estan vacios
                //En caso de que se cumpla la condicion le mostraremos un mensaje de advertencia al usuario
                if ((nombreTextBox1.Text == " ") || (edadTextBox2.Text == " "))
                {
                    MessageBox.Show("Rellene todos los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //Sino agregamos la informacion obtenidad a su respectiva posicion
                {
                    edades[contador] = Convert.ToInt32(edadTextBox2.Text);  //Agregando la edad en la posicion que nos indica el contador
                    nombres[contador] = nombreTextBox1.Text;                //Agregando el nombre en la posicion del contador
                    contador++;
                    nombreTextBox1.Clear();                                 //Limpiamos los textbox para agregrar mas datos
                    edadTextBox2.Clear();
                    MessageBox.Show("Estudiante Ingresado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);   //Mensaje para indicar que el estudiante fue ingresado

                }
            }
            else
            {
                MessageBox.Show("Usted ha ingresado la cantidad maxima de alumnos (10)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Inicializamos de nuevo, de esta forma determinaremos si el usuario lleno los campos
            nombreTextBox1.Text = " ";
            edadTextBox2.Text = " ";
        }

      
        private void mostrarButton1_Click(object sender, EventArgs e)
        {
            estudiantesListBox1.Items.Clear();      //Limpiamos para que los valores no se repitan
            mostrar(nombres, edades, contador);     //Ingresamos todos los valores a un listbox
        }
        
        //Procedimiento para ingresar toda la informacion de los vectores llenados anteriormente en un ListBox
        private void mostrar (string[] a, int [] b, int c)
        {
            //El ciclo ira hasta el valor de contador, agregando informacion de los vectores al listbox
            for(int i = 0; i<c;i++)
            {
                estudiantesListBox1.Items.Add(a[i] + "   " + b[i] + " años");
            }
        }
    }
}
