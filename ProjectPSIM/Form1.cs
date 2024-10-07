using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPSIM
{
    public partial class Form1 : Form
    {

        FormDashboard Fdashboard;
        FormTransaksi Ftransaksi;
        FormStok Fstok;
        FormVip Fvip;
        FormLaporan Flaporan;
        FormLogout Flogout;
        public Form1()
        {
            InitializeComponent();
            mdiProp();
        }

        bool sidebarExpand = true;
        private void mdiProp()
        {
            this.SetBavel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232,234,237);
        }
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if(sidebar.Width <= 60) 
                { 
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnDasboard.Width = sidebar.Width;
                    pnTransaksi.Width = sidebar.Width;
                    pnStok.Width = sidebar.Width;
                    pnVip.Width = sidebar.Width;
                    pnLaporan.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 230)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnDasboard.Width = sidebar.Width;
                    pnTransaksi.Width = sidebar.Width;
                    pnStok.Width = sidebar.Width;
                    pnVip.Width = sidebar.Width;
                    pnLaporan.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (Fdashboard == null)
            {
                Fdashboard = new FormDashboard();
                Fdashboard.FormClosed += Dashboard_FormClosed;
                Fdashboard.MdiParent = this;
                Fdashboard.Dock = DockStyle.Fill;
                Fdashboard.Show();
            }
            else
            {
                Fdashboard.Activate();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fdashboard = null;
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            if(Flaporan == null)
            {
                Flaporan = new FormLaporan();
                Flaporan.FormClosed += Laporan_FormClosed;
                Flaporan.MdiParent = this;
                Flaporan.Dock = DockStyle.Fill;
                Flaporan.Show();
            }
            else
            {
                Flaporan.Activate();
            }
        }
        private void Laporan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Flaporan = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Ftransaksi == null)
            {
                Ftransaksi = new FormTransaksi();
                Ftransaksi.FormClosed += Transaksi_FormClosed;
                Ftransaksi.MdiParent= this;
                Ftransaksi.Dock = DockStyle.Fill;
                Ftransaksi.Show();
            }
            else
            {
                Ftransaksi.Activate();
            }
        }
        private void Transaksi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Ftransaksi = null;
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (Fstok == null)
            {
                Fstok = new FormStok();
                Fstok.FormClosed += Stok_FormClosed;
                Fstok.MdiParent = this;
                Fstok.Dock = DockStyle.Fill;
                Fstok.Show();
            }
            else
            {
                Fstok.Activate();
            }
        }
        private void Stok_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fstok = null;
        }

        private void btnVip_Click(object sender, EventArgs e)
=======

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)

>>>>>>> 4fcf1a4a2cb690edf68caf8f7e4be38c8d299c7d
        {
            if (Fvip == null)
            {
                Fvip = new FormVip();
                Fvip.FormClosed += Vip_FormClosed;
                Fvip.MdiParent = this;
                Fvip.Dock = DockStyle.Fill;
                Fvip.Show();
            }
            else
            {
                Fvip.Activate();
            }
        }
        private void Vip_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fvip = null;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (Flogout == null)
            {
                Flogout = new FormLogout();
                Flogout.FormClosed += Logout_FormClosed;
                Flogout.MdiParent = this;
                Flogout.Dock = DockStyle.Fill;
                Flogout.Show();
            }
            else
            {
                Flogout.Activate();
            }
        }
        private void Logout_FormClosed(object sender, FormClosedEventArgs e)
        {
            Flogout = null;
        }
    }
}
