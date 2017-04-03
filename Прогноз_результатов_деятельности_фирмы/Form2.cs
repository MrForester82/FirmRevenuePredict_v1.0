using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Прогноз_результатов_деятельности_фирмы
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(DataGridViewRowCollection sourceData)
        {
            InitializeComponent();

            DateTime tmp;
            string dd;
            int sourceCount = sourceData.Count - 1;
            int valueCount = 0;
            int i = 0;
            double Yavg = 0;
            double cos1x = 0;
            double sin1x = 0;
            double cos2x = 0;
            double sin2x = 0;
            double cos3x = 0;
            double sin3x = 0;
            double cos4x = 0;
            double sin4x = 0;
            double cos5x = 0;
            double sin5x = 0;
            double cos6x = 0;
            double sin6x = 0;

            while (sourceData[valueCount].Cells[1].Value.ToString() != ""){
                valueCount++;
            }
           
            //Добавление строк в таблицу
            while (i < sourceCount-1)
            {
                dataGridView1.Rows.Add();
                i++;
            }

            i = 0;
            while (i < sourceCount)
            {
                //Заполнение индексов
                dataGridView1[0, i].Value = i;
                dataGridView1[0, i].Style.BackColor = Color.LightGoldenrodYellow;

                //Даты
                tmp = DateTime.Parse(sourceData[i].Cells[0].Value.ToString()).Date;
                dd = tmp.ToString("d");
                dataGridView1[1, i].Value = dd;
                dataGridView1[1, i].Style.BackColor = Color.LightGoldenrodYellow;

                //Вычисление коэффициентов x
                dataGridView1[2, i].Value = Math.Round(2 * Math.PI * int.Parse(dataGridView1[0, i].Value.ToString())/valueCount, 4);
                dataGridView1[2, i].Style.BackColor = Color.LightGoldenrodYellow;

                i++;
            }

            i = 0;
            while (i < valueCount)
            {
                //Имеющиеся значения прибыли
                dataGridView1[3, i].Value = sourceData[i].Cells[1].Value;
                dataGridView1[3, i].Style.BackColor = Color.LightGoldenrodYellow;
                Yavg += double.Parse(dataGridView1[3, i].Value.ToString());

                //cos1x
                dataGridView1[4, i].Value = Math.Round(double.Parse(dataGridView1[3, i].Value.ToString()) * Math.Cos(double.Parse(dataGridView1[2, i].Value.ToString())), 4);
                dataGridView1[4, i].Style.BackColor = Color.LightGoldenrodYellow;
                cos1x += double.Parse(dataGridView1[4, i].Value.ToString());

                //sin1x
                dataGridView1[5, i].Value = Math.Round(double.Parse(dataGridView1[3, i].Value.ToString()) * Math.Sin(double.Parse(dataGridView1[2, i].Value.ToString())), 4);
                dataGridView1[5, i].Style.BackColor = Color.LightGoldenrodYellow;
                sin1x += double.Parse(dataGridView1[5, i].Value.ToString());

                //cos2x
                dataGridView1[6, i].Value = Math.Round(double.Parse(dataGridView1[3, i].Value.ToString()) * Math.Cos(2 * double.Parse(dataGridView1[2, i].Value.ToString())), 4);
                dataGridView1[6, i].Style.BackColor = Color.LightGoldenrodYellow;
                cos2x += double.Parse(dataGridView1[6, i].Value.ToString());

                //sin2x
                dataGridView1[7, i].Value = Math.Round(double.Parse(dataGridView1[3, i].Value.ToString()) * Math.Sin(2 * double.Parse(dataGridView1[2, i].Value.ToString())), 4);
                dataGridView1[7, i].Style.BackColor = Color.LightGoldenrodYellow;
                sin2x += double.Parse(dataGridView1[7, i].Value.ToString());

                //cos3x
                dataGridView1[8, i].Value = Math.Round(double.Parse(dataGridView1[3, i].Value.ToString()) * Math.Cos(3 * double.Parse(dataGridView1[2, i].Value.ToString())), 4);
                dataGridView1[8, i].Style.BackColor = Color.LightGoldenrodYellow;
                cos3x += double.Parse(dataGridView1[8, i].Value.ToString());

                //sin3x
                dataGridView1[9, i].Value = Math.Round(double.Parse(dataGridView1[3, i].Value.ToString()) * Math.Sin(3 * double.Parse(dataGridView1[2, i].Value.ToString())), 4);
                dataGridView1[9, i].Style.BackColor = Color.LightGoldenrodYellow;
                sin3x += double.Parse(dataGridView1[9, i].Value.ToString());

                //cos4x
                dataGridView1[10, i].Value = Math.Round(double.Parse(dataGridView1[3, i].Value.ToString()) * Math.Cos(4 * double.Parse(dataGridView1[2, i].Value.ToString())), 4);
                dataGridView1[10, i].Style.BackColor = Color.LightGoldenrodYellow;
                cos4x += double.Parse(dataGridView1[10, i].Value.ToString());

                //sin4x
                dataGridView1[11, i].Value = Math.Round(double.Parse(dataGridView1[3, i].Value.ToString()) * Math.Sin(4 * double.Parse(dataGridView1[2, i].Value.ToString())), 4);
                dataGridView1[11, i].Style.BackColor = Color.LightGoldenrodYellow;
                sin4x += double.Parse(dataGridView1[11, i].Value.ToString());

                //cos5x
                dataGridView1[12, i].Value = Math.Round(double.Parse(dataGridView1[3, i].Value.ToString()) * Math.Cos(5 * double.Parse(dataGridView1[2, i].Value.ToString())), 4);
                dataGridView1[12, i].Style.BackColor = Color.LightGoldenrodYellow;
                cos5x += double.Parse(dataGridView1[12, i].Value.ToString());

                //sin5x
                dataGridView1[13, i].Value = Math.Round(double.Parse(dataGridView1[3, i].Value.ToString()) * Math.Sin(5 * double.Parse(dataGridView1[2, i].Value.ToString())), 4);
                dataGridView1[13, i].Style.BackColor = Color.LightGoldenrodYellow;
                sin5x += double.Parse(dataGridView1[13, i].Value.ToString());

                //cos6x
                dataGridView1[14, i].Value = Math.Round(double.Parse(dataGridView1[3, i].Value.ToString()) * Math.Cos(6 * double.Parse(dataGridView1[2, i].Value.ToString())), 4);
                dataGridView1[14, i].Style.BackColor = Color.LightGoldenrodYellow;
                cos6x += double.Parse(dataGridView1[14, i].Value.ToString());

                //sin6x
                dataGridView1[15, i].Value = Math.Round(double.Parse(dataGridView1[3, i].Value.ToString()) * Math.Sin(6 * double.Parse(dataGridView1[2, i].Value.ToString())), 4);
                dataGridView1[15, i].Style.BackColor = Color.LightGoldenrodYellow;
                sin6x += double.Parse(dataGridView1[15, i].Value.ToString());

                i++;
            }
            Yavg = Yavg / (valueCount / 2);
            cos1x = cos1x / (valueCount / 2);
            sin1x = sin1x / (valueCount / 2);
            cos2x = cos2x / (valueCount / 2);
            sin2x = sin2x / (valueCount / 2);
            cos3x = cos3x / (valueCount / 2);
            sin3x = sin3x / (valueCount / 2);
            cos4x = cos4x / (valueCount / 2);
            sin4x = sin4x / (valueCount / 2);
            cos5x = cos5x / (valueCount / 2);
            sin5x = sin5x / (valueCount / 2);
            cos6x = cos6x / (valueCount / 2);
            sin6x = sin6x / (valueCount / 2);

            //Color.LemonChiffon;

            //Y avg
            dataGridView1[3, valueCount].Value = Math.Round(Yavg, 4);
            dataGridView1[3, valueCount].Style.BackColor = Color.LightGreen;
            //cos1x avg
            dataGridView1[4, valueCount].Value = Math.Round(cos1x, 4);
            dataGridView1[4, valueCount].Style.BackColor = Color.LightGreen;
            //sin1x avg
            dataGridView1[5, valueCount].Value = Math.Round(sin1x, 4);
            dataGridView1[5, valueCount].Style.BackColor = Color.LightGreen;
            //cos2x avg
            dataGridView1[6, valueCount].Value = Math.Round(cos2x, 4);
            dataGridView1[6, valueCount].Style.BackColor = Color.LightGreen;
            //sin2x avg
            dataGridView1[7, valueCount].Value = Math.Round(sin2x, 4);
            dataGridView1[7, valueCount].Style.BackColor = Color.LightGreen;
            //cos3x avg
            dataGridView1[8, valueCount].Value = Math.Round(cos3x, 4);
            dataGridView1[8, valueCount].Style.BackColor = Color.LightGreen;
            //sin3x avg
            dataGridView1[9, valueCount].Value = Math.Round(sin3x, 4);
            dataGridView1[9, valueCount].Style.BackColor = Color.LightGreen;
            //cos4x avg
            dataGridView1[10, valueCount].Value = Math.Round(cos4x, 4);
            dataGridView1[10, valueCount].Style.BackColor = Color.LightGreen;
            //sin4x avg
            dataGridView1[11, valueCount].Value = Math.Round(sin4x, 4);
            dataGridView1[11, valueCount].Style.BackColor = Color.LightGreen;
            //cos5x avg
            dataGridView1[12, valueCount].Value = Math.Round(cos5x, 4);
            dataGridView1[12, valueCount].Style.BackColor = Color.LightGreen;
            //sin5x avg
            dataGridView1[13, valueCount].Value = Math.Round(sin5x, 4);
            dataGridView1[13, valueCount].Style.BackColor = Color.LightGreen;
            //cos6x avg
            dataGridView1[14, valueCount].Value = Math.Round(cos6x, 4);
            dataGridView1[14, valueCount].Style.BackColor = Color.LightGreen;
            //sin6x avg
            dataGridView1[15, valueCount].Value = Math.Round(sin6x, 4);
            dataGridView1[15, valueCount].Style.BackColor = Color.LightGreen;

            i = 0;
            while (i < sourceCount)
            {
                dataGridView1[16, i].Value = Math.Round(Yavg / 2 + cos1x * Math.Cos(double.Parse(dataGridView1[2, i].Value.ToString())) + sin1x * Math.Sin(double.Parse(dataGridView1[2, i].Value.ToString())) + cos2x * Math.Cos(2 * double.Parse(dataGridView1[2, i].Value.ToString())) + sin2x * Math.Sin(2 * double.Parse(dataGridView1[2, i].Value.ToString())) + cos3x * Math.Cos(3 * double.Parse(dataGridView1[2, i].Value.ToString())) + sin3x * Math.Sin(3 * double.Parse(dataGridView1[2, i].Value.ToString())) + cos4x * Math.Cos(4 * double.Parse(dataGridView1[2, i].Value.ToString())) + sin4x * Math.Sin(4 * double.Parse(dataGridView1[2, i].Value.ToString())) + cos5x * Math.Cos(5 * double.Parse(dataGridView1[2, i].Value.ToString())) + sin5x * Math.Sin(5 * double.Parse(dataGridView1[2, i].Value.ToString())) + cos6x * Math.Cos(6 * double.Parse(dataGridView1[2, i].Value.ToString())) + sin6x * Math.Sin(6 * double.Parse(dataGridView1[2, i].Value.ToString())), 4);
                dataGridView1[16, i].Style.BackColor = Color.LightGreen;
                i++;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
