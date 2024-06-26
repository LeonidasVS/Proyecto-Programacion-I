﻿using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class AgregarCategoria : Form
    {
        CategoriaLOG _categoriaLOG;
        int _id;
        public AgregarCategoria(int id = 0)
        {
            InitializeComponent();

            _id = id;

            if (_id > 0)
            {
                this.Text = "Tienda AS | Editar categoria";
                btnGuardar.Text = "Actualizar";
                lblTitulo.Text = "Editar Categoria";

                CargarDatos(_id);

            }
            else
            {
                categoriaBindingSource.MoveLast();
            categoriaBindingSource.AddNew();
            }

            
        }

        private void CargarDatos(int id)
        {
            _categoriaLOG = new CategoriaLOG();
            categoriaBindingSource.DataSource = _categoriaLOG.LeerPorID(id);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCategoria();
        }

        private void GuardarCategoria()
        {
            try
            {
                _categoriaLOG = new CategoriaLOG();
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Por favor ingrese el nombre de la categoria", "Tienda AS | Agregar Categoria",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                    txtNombre.BackColor = Color.LightYellow;
                }
                else if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor ingrese la descripción de la categoria", "Tienda AS | Agregar Categoria",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescripcion.Focus();
                    txtDescripcion.BackColor = Color.LightYellow;
                }
                else if (!chbActivo.Checked)
                {
                    var dialogo = MessageBox.Show("Estas seguro que desea guardar la categoria inactiva?", "Tienda AS | Registro Categoria",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Seleccione el cuadro estado como activo", "Tienda AS | Registro Categoria",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (_id > 0)
                {
                    Categoria categoria;
                    categoria = (Categoria)categoriaBindingSource.Current;
                    int resultado = _categoriaLOG.EditarCategoria(categoria, _id, true);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Categoria editada con exito", "Tienda AS | Editar categoria",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro editar la Categoria", "Tienda AS | Editar categoria",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Categoria categoria;
                    categoria = (Categoria)categoriaBindingSource.Current;
                    int resultado = _categoriaLOG.GuardarCategoria(categoria);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Categoria Agregada con Exito", "Tienda AS | Registro Categoria",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro agregagr la Categoria", "Tienda AS | Registro Categoria",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }  
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error, complete la acción necesaria.", "Tienda AS | Agregar Categoria",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
