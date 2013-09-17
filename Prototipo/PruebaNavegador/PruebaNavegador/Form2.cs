using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;

namespace PruebaNavegador
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            navegador.click_nuevo_button += click_nuevo;
            navegador.click_guardar_button += click_guardar;
            navegador.click_editar_button += click_editar;
            navegador.click_buscar_button += click_buscar;
            navegador.click_eliminar_button += click_eliminar;
            navegador.click_verificar_button += click_verificar;
        }

        private void click_nuevo()
        {
            MessageBox.Show("Botón nuevo desde Form2");
        }

        private void click_guardar()
        {
            MessageBox.Show("Botón guardar desde Form2");
        }

        private void click_editar()
        {
            MessageBox.Show("Botón editar desde Form2");
        }

        private void click_buscar()
        {
            //MessageBox.Show("Botón buscar desde Form2");
            dataGridView1.DataSource = new DBConnect("prueba").consulta_DataGridView("select * from producto");
        }

        private void click_eliminar()
        {
            MessageBox.Show("Botón eliminar desde Form2");
        }

        private void click_verificar()
        {
            MessageBox.Show("Botón verificar desde Form2");
        }
    }
}
