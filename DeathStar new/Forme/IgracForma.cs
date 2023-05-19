﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeathStar_new.Forme
{
    public partial class IgracForma : Form
    {
        public IgracForma()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void popuniTabeluIgraca()
        {
            listaIgraca.Items.Clear();
            List<IgracPregled> igraci = DTOManager.vratiSveIgrace();
            foreach(IgracPregled i in igraci)
            {
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                    i.username,
                    i.ime,
                    i.prezime,
                    i.pol,
                    i.drzava,
                    i.datumRodjenja.ToString(),
                    i.datumOtvaranjaNaloga.ToString(),
                    i.email,
                    i.urlAvatara,
                    i.opis
                }) ;
                listaIgraca.Items.Add(listViewItem);
            }
            listaIgraca.Refresh();
        }

    }
}
