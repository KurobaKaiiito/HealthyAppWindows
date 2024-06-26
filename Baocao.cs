﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.SqlServer.Server;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HealthyApp
{
    public partial class Baocao : Form
    {
        KetNoi conn = new KetNoi();
        public Baocao()
        {
            InitializeComponent();
            dateKhoa.Format = DateTimePickerFormat.Custom;
            dateKhoa.CustomFormat = "MM/yyyy";
        }
        private void dateKhoa_ValueChanged(object sender, EventArgs e)
        {
            int year = dateKhoa.Value.Year;
            int month = dateKhoa.Value.Month;

            string truyvan = string.Format("select Tenchiso, SUM(Luongchiso) as TongLuongchiso from Chisodinhduong join Thucdon on Chisodinhduong.Id = Thucdon.Id where MONTH(Thoigian) = {0} and YEAR(Thoigian) = {1} group by Tenchiso", month, year);
            DataTable db = conn.LayDuLieu(truyvan);
            dgvKhoa.DataSource = db;
            chartKhoa.Series.Clear();
            chartKhoa.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chartKhoa.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartKhoa.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            lbChuaco1.Visible = false;
            lbChuaco2.Visible = false;

            if (dgvKhoa.Rows.Count > 1)
            {
                int x = dgvKhoa.Rows.Count;
                string[] a = new string[x];
                int[] b = new int[x];
                for (int i = 0; i < dgvKhoa.Rows.Count; i++)
                {
                    a[i] = (String)dgvKhoa.Rows[i].Cells["Tenchiso"].Value;
                    b[i] = Convert.ToInt32(dgvKhoa.Rows[i].Cells["TongLuongchiso"].Value);
                }
                /*                string a = (String)dgvKhoa.Rows[0].Cells["Tenchiso"].Value;
                                int b = Convert.ToInt32(dgvKhoa.Rows[0].Cells["TongLuongchiso"].Value);

                                string c = (String)dgvKhoa.Rows[1].Cells["Tenchiso"].Value;
                                int d = Convert.ToInt32(dgvKhoa.Rows[1].Cells["Tongluongchiso"].Value);*/



                /*Series series1 = new Series(a);
                series1.Points.AddXY(a, b);

                Series series2 = new Series(c);
                series2.Points.AddXY(c, d);

                chartKhoa.Series.Add(series1);
                chartKhoa.Series.Add(series2);*/

                Series[] series = new Series[x];
                for (int i = 0; i < dgvKhoa.Rows.Count; i++)
                {
                    series[i] = new Series(a[i]);
                    series[i].Points.AddXY(a[i], b[i]);
                    chartKhoa.Series.Add(series[i]);

                    /*chartKhoa.Legends.Add(new Legend("Legend"));
                    chartKhoa.Legends["Legend"].DockedToChartArea = "ChartArea1";
                    chartKhoa.Legends["Legend"].Docking = Docking.Bottom;
                    chartKhoa.Legends["Legend"].IsDockedInsideChartArea = false;*/

                    /*series[i].Legend = a[i];*/
                    /*series[i] = new Series(a[i]);
                    series[i].Points.AddXY(a[i], b[i]);
                    chartKhoa.Series.Add(series[i]);*/
                }

            }
            else
            {
                lbChuaco1.Visible = true;
                lbChuaco2.Visible = true;
            }

        }

        private void Baocao_Load(object sender, EventArgs e)
        {
            dgvKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            int year = dateKhoa.Value.Year;
            int month = dateKhoa.Value.Month;

            string truyvan = string.Format("select Tenchiso, SUM(Luongchiso) as TongLuongchiso from Chisodinhduong join Thucdon on Chisodinhduong.Id = Thucdon.Id where MONTH(Thoigian) = {0} and YEAR(Thoigian) = {1} group by Tenchiso", month, year);
            DataTable db = conn.LayDuLieu(truyvan);
            dgvKhoa.DataSource = db;
            chartKhoa.Series.Clear();
            chartKhoa.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chartKhoa.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartKhoa.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            lbChuaco1.Visible = false;
            lbChuaco2.Visible = false;

            if (dgvKhoa.Rows.Count > 1)
            {
                int x = dgvKhoa.Rows.Count;
                string[] a = new string[x];
                int[] b = new int[x];
                for (int i = 0; i < dgvKhoa.Rows.Count; i++)
                {
                    a[i] = (String)dgvKhoa.Rows[i].Cells["Tenchiso"].Value;
                    b[i] = Convert.ToInt32(dgvKhoa.Rows[i].Cells["TongLuongchiso"].Value);
                }
                /*                string a = (String)dgvKhoa.Rows[0].Cells["Tenchiso"].Value;
                                int b = Convert.ToInt32(dgvKhoa.Rows[0].Cells["TongLuongchiso"].Value);

                                string c = (String)dgvKhoa.Rows[1].Cells["Tenchiso"].Value;
                                int d = Convert.ToInt32(dgvKhoa.Rows[1].Cells["Tongluongchiso"].Value);*/



                /*Series series1 = new Series(a);
                series1.Points.AddXY(a, b);

                Series series2 = new Series(c);
                series2.Points.AddXY(c, d);

                chartKhoa.Series.Add(series1);
                chartKhoa.Series.Add(series2);*/

                Series[] series = new Series[x];
                for (int i = 0; i < dgvKhoa.Rows.Count; i++)
                {
                    series[i] = new Series(a[i]);
                    series[i].Points.AddXY(a[i], b[i]);
                    chartKhoa.Series.Add(series[i]);

                    /*chartKhoa.Legends.Add(new Legend("Legend"));
                    chartKhoa.Legends["Legend"].DockedToChartArea = "ChartArea1";
                    chartKhoa.Legends["Legend"].Docking = Docking.Bottom;
                    chartKhoa.Legends["Legend"].IsDockedInsideChartArea = false;*/

                    /*series[i].Legend = a[i];*/
                    /*series[i] = new Series(a[i]);
                    series[i].Points.AddXY(a[i], b[i]);
                    chartKhoa.Series.Add(series[i]);*/
                }

            }
            else
            {
                lbChuaco1.Visible = true;
                lbChuaco2.Visible = true;
            }
        }
    }
}
