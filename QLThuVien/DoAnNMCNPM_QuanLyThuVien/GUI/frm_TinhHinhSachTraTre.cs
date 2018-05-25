﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNMCNPM_QuanLyThuVien.BUS;
using DoAnNMCNPM_QuanLyThuVien.DTO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace DoAnNMCNPM_QuanLyThuVien.GUI
{
    public partial class frm_TinhHinhSachTraTre : UserControl
    {
        public frm_TinhHinhSachTraTre()
        {
            InitializeComponent();
           
        }  
       
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToShortDateString();
            this.tKSachTraTreTableAdapter.Fill(this.qLTVDataSet1.TKSachTraTre);
            SetParamters(dtTu.Value, dtDen.Value);
            rpvBaoCao.RefreshReport();

        }

        private void frm_TinhHinhMuonSach_Load(object sender, EventArgs e)
        {
            //this.tKTinhHinhMuonSachTableAdapter.Fill(this.bCTinhHinhMuon.TKTinhHinhMuonSach);
            //this.rpvBaoCao.RefreshReport();
            //SetParamters(dtTu.Value, dtDen.Value);

        }

        private void SetParamters(DateTime tgTu, DateTime tgDen)
        {
            ReportParameter[] p = new ReportParameter[2];
            p[0] = new ReportParameter("TGTu");
            p[1] = new ReportParameter("TGDen");
            p[0].Values.Add(tgTu.ToString());
            p[1].Values.Add(tgDen.ToString());
            rpvBaoCao.LocalReport.SetParameters(p);
        }
    }
}