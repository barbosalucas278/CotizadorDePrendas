using ExamenQuarkCSharp.Models;
using ExamenQuarkCSharp.Presenters;
using ExamenQuarkCSharp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenQuarkCSharp
{
    public partial class Form1 : Form, IView
    {
        TiendaPresenter _tiendaPresenter;
        public Form1()
        {
            InitializeComponent();
        }
        #region Eventos

        private void Form1_Load(object sender, EventArgs e)
        {
            _tiendaPresenter = new TiendaPresenter(this);

        }

        private void LabelLinkHistorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _tiendaPresenter.ListarCotizaciones();
        }

        private void ButtomCotizar_Click(object sender, EventArgs e)
        {
            try
            {
                _tiendaPresenter.RealizarCotizacion();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ah ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RadioCamisa_CheckedChanged(object sender, EventArgs e)
        {
            CheckChupin.Enabled = false;
            CheckChupin.Checked = false;
            CheckMangaCorta.Enabled = true;
            CheckCuelloMao.Enabled = true;
            GetCamisas();
        }

        private void RadioPantalon_CheckedChanged(object sender, EventArgs e)
        {
            CheckChupin.Enabled = true;
            CheckMangaCorta.Enabled = false;
            CheckCuelloMao.Enabled = false;
            CheckMangaCorta.Checked = false;
            CheckCuelloMao.Checked = false;
            GetPantalones();
        }
        private void CheckMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            GetCamisas();
        }
        private void CheckCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            GetCamisas();
        }
        private void CheckChupin_CheckedChanged(object sender, EventArgs e)
        {
            GetPantalones();
        }
        #endregion
        #region Metodos publicos
        public void InicializarControles(TiendaViewModel tienda)
        {
            LabelNombreEmpresa.Text = tienda.Nombre;
            LabelDireccionEmpresa.Text = tienda.Direccion;
            LabelDatosVendedor.Text = tienda.Vendedor;
        }


        private void RadioCalidadStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioCamisa.Checked)
            {
                GetCamisas();
            }
            else
            {
                GetPantalones();
            }
        }
        private void GetPantalones()
        {
            if (RadioCalidadStandard.Checked)
            {
                _tiendaPresenter.MostrarPantalonesStandard();
            }
            else
            {
                _tiendaPresenter.MostrarPantalonesPremium();
            }
        }
        private void GetCamisas()
        {
            if (RadioCalidadStandard.Checked)
            {
                _tiendaPresenter.MostrarCamisasStandard();
            }
            else
            {
                _tiendaPresenter.MostrarCamisasPremium();
            }
        }

        public void ActualizarFormulario(PrendaViewModel prenda)
        {
            LabelStockDisponible.Text = prenda.StockDisponible;
            TextBoxPrecioUnitario.Text = prenda.PrecioUnitario;
        }


        public bool IsMangaCorta()
        {
            return CheckMangaCorta.Checked;
        }

        public bool IsCuelloMao()
        {
            return CheckCuelloMao.Checked;
        }

        public bool IsChupin()
        {
            return CheckChupin.Checked;
        }

        public FormDataViewModel GetFormData()
        {
            ValidarCampos();
            var test = RadioCalidadStandard.Checked;
            FormDataViewModel formDataViewModel = new FormDataViewModel()
            {
                PrecioCotizado = int.Parse(TextBoxPrecioUnitario.Text),
                CantidadCotizada = int.Parse(TextBoxCantidad.Text),
                IsCamisa = RadioCamisa.Checked,
                IsMangaCorta = CheckMangaCorta.Checked,
                IsCuelloMao = CheckCuelloMao.Checked,
                IsChupin = CheckChupin.Checked,
                IsStandard = RadioCalidadStandard.Checked,
                StockDisponible = int.Parse(LabelStockDisponible.Text)
            };
            return formDataViewModel;
        }

        private void ValidarCampos()
        {
            if (!RadioCamisa.Checked && !RadioPantalon.Checked)
                throw new Exception("Debe elegir una tipo de prenda a cotizar");
            if (string.IsNullOrEmpty(TextBoxCantidad.Text))
                throw new Exception("La cantidad es requerida");
            if (!int.TryParse(TextBoxCantidad.Text, out int bufferCantidad))
                throw new Exception("Debe ingresar un numero como cantidad");
            if (!int.TryParse(TextBoxPrecioUnitario.Text, out int bufferPrecio))
                throw new Exception("Debe ingresar un numero como precio");
        }
        public void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Ah ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ActualizarLabelMontoCotizado(string montoCotizado)
        {
            LabelMonto.Text = montoCotizado;
        }

        public void ActualizarFormHistorial(string historial)
        {
            var historialForm = new Historial(historial);
            historialForm.ShowDialog();
        }
        #endregion

    }
}
