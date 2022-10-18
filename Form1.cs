using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        int num1;
        int num2;
        int num3;

        public Form1()
        {
            InitializeComponent();
        }
        private void identificar1_Click(object sender, EventArgs e)
        {

            int elMayor;
            int elMenor;
            try
            {
                num1 = int.Parse(numero1.Text);
                num2 = int.Parse(numero2.Text);


                //aca no vi necesidad de extraer a un metodo ya que es un solo condicional;

                if (num1 > num2)
                {
                    elMayor = num1;
                    elMenor = num2;
                }
                else
                {
                    elMayor = num2;
                    elMenor = num1;
                }

                MostrarMayorYMenor(elMayor, elMenor);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un numero valido");
            }

        }

        private void identificar2_Click(object sender, EventArgs e)
        {

            try
            {
                num1 = int.Parse(numero1.Text);
                num2 = int.Parse(numero2.Text);
                num3 = int.Parse(numero3.Text);

                MostrarMayorYMenor(ElMayorDeTres(num1, num2, num3), ElMenorDeTres(num1, num2, num3));
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un numero valido");
            }

        }

        private void MostrarMayorYMenor(int numMayor, int numMenor)
        {
            if (numMayor == numMenor)
            {
                MessageBox.Show($"Los numeros son iguales! ({ numMenor })");
            }
            else
            {
                MessageBox.Show($"El numero mayor es: { numMayor } y el numero menor es: { numMenor }");
            }
        }

        /*
         * Lo inicialice a n1 como el mayor (y el menor en el otro metodo) para ahorrar condicionales y solo preguntar 2 veces en cada metodo como maximo.
         * Si no hubiera extraido a un metodo los que tienen que actuar en base a tres numeros la cadena de if else-if se hubiese hecho muy larga.
         * Por eso extraje a un metodo que seleccione al mayor de tres y otro al menor de 3 preguntando como maximo 2 veces en cada metodo.
         */

        private int ElMayorDeTres(int n1, int n2, int n3)
        {

            int elMayor = n1;

            if (n2 > elMayor)
            {
                elMayor = n2;

                if (n3 > elMayor)
                {
                    elMayor = n3;
                }
            }
            else if (n3 > elMayor)
            {
                elMayor = n3;
            }

            return elMayor;
        }

        private int ElMenorDeTres(int n1, int n2, int n3)
        {
            int elMenor = n1;

            if (n2 < elMenor)
            {
                elMenor = n2;
                if (n3 > elMenor)
                {
                    elMenor = n3;
                }
            }
            else if (n3 < elMenor)
            {
                elMenor = n3;
            }
            return elMenor;
        }
    }
}
