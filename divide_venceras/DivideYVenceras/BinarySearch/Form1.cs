using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearch
{
    public partial class Form1 : Form
    {

        int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        public Form1()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            cmbNumeros.Items.Clear();
            foreach (var  item in arr)
            {
                cmbNumeros.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lbResultado.Items.Clear();

            if (cmbNumeros.SelectedIndex != -1)
            {
                int box=(int)cmbNumeros.SelectedItem;
                int resultado = BinarySearch(arr,box);
                if (resultado >= 0)
                {
                    lbResultado.Items.Add($"Numero encontrado en la posicion: {resultado}");
                }
                else
                {
                    lbResultado.Items.Add("Numero no encontrado.");
                }

            }
            else
            {
                lbResultado.Items.Add("Por favor, selecciona un número: ");
            }
        }

        private int BinarySearch(int[] arr,int box)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == box)
                {
                    return mid;
                }
                else if (arr[mid] < box)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
          
          
            }
            return -1;
        }

        private void UpdateComboBox()
        {
            cmbNumeros.Items.Clear();
            cmbNumeros.Items.AddRange(arr.Cast<object>().ToArray());
        }

        private void UpdateListBox()
        {
            lbResultado.Items.Clear();
            foreach (var item in arr)
            {
                lbResultado.Items.Add(item);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Array.Sort(arr);
            UpdateComboBox();
            UpdateListBox();
            
        }
    }
}
