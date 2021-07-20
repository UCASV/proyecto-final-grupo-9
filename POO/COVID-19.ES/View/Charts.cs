using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using COVID_19.ES.CovidContext;

namespace COVID_19.ES
{
    public partial class Charts : Form
    {
        public Charts()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e){}
        

        private void Charts_Load(object sender, EventArgs e)
        {
            chart1.Palette = ChartColorPalette.Pastel;
            
            var db = new Vaccination_ManagementContext(); 
            var Ctz = db.Citizens.ToList(); //Todos los registrados
            
            var allVac = db.Dose1s.ToList(); //Todos los vacunados
            
            var ds2 = db.Dose2s.ToList(); //Todos los de 2 dosis

            int number = 0; 
            
            for (int i = 0; i < allVac.Count; i++)
            {
                for (int j = 0; j < ds2.Count; j++)
                {
                    if (allVac[i].DuiCitizen == ds2[j].DuiCitizen)
                    {
                        number++;
                    }
                }
            }

            int x = allVac.Count - number; //Todos los de 1 dosis

            var sdef = db.SideEffects.ToList(); //Todos los efectos secundarios
            var sdef1 = db.Dose1xsideEffects.ToList(); //Todos los efectos por dosis1
            var sdef2 = db.Dose2xsideEffects.ToList(); //Todos los efectos por dosis2
            
            var wRow1 = db.WaitRow1s.ToList(); //Todos los datos de cuando se espero en la dosis 1
            var wRow2 = db.WaitRow2s.ToList(); //Todos los datos de cuando se espero en la dosis 2
            
            
            
            ///////////////////////////////////////////////////////////////////////////////
            // Grafico 1
            ///////////////////////////////////////////////////////////////////////////////
            chart1.Titles.Add("Porcentaje de dosis implementadas");
            // titulos
            Series serie = chart1.Series.Add("Personas registradas");
            serie.Label = Ctz.Count.ToString();
            serie.Points.Add(Ctz.Count);
            
            serie = chart1.Series.Add("Personas vacunadas"); 
            serie.Label = allVac.Count.ToString();
            serie.Points.Add(allVac.Count);
            
            serie = chart1.Series.Add("Personas con 1 dosis");
            serie.Label = x.ToString();
            serie.Points.Add(x);
            
            serie = chart1.Series.Add("Personas con 2 dosis");
            serie.Label = ds2.Count.ToString();
            serie.Points.Add(ds2.Count);

            this.chart1.Series.RemoveAt(0);
            ///////////////////////////////////////////////////////////////////////////////
            // Grafico 2
            ///////////////////////////////////////////////////////////////////////////////
            chart2.Titles.Add("Porcentaje de efectos secundarios");
            
            serie = chart2.Series.Add("Personas vacunadas");
            serie.Label = allVac.Count.ToString();
            serie.Points.Add(allVac.Count);
            
            serie = chart2.Series.Add("Efectos secundarios totales"); 
            serie.Label = sdef.Count.ToString();
            serie.Points.Add(sdef.Count);
            this.chart2.Series.RemoveAt(0);
            
            
            ///////////////////////////////////////////////////////////////////////////////
            // Grafico 3
            ///////////////////////////////////////////////////////////////////////////////
            chart3.Titles.Add("Eficiencia en el tiempo de espera");

            
            List<int> RowHour = new List<int>();
            List<int> DoseHour = new List<int>();
            
            List<int> RowHour2 = new List<int>();
            List<int> DoseHour2 = new List<int>();
            
            int trans = 0;
            int cantMenos15 = 0;
            int cantEntre1530 = 0;
            int cantEntre3060 = 0;
            int cantMas60 = 0;

            for (int i = 0; i < wRow1.Count; i++)
            {
                trans = wRow1[i].DateTime.Value.Hour * 60;
                int a = trans + wRow1[i].DateTime.Value.Minute;
                
                trans = allVac[i].DateTime.Value.Hour * 60;
                int b = trans + allVac[i].DateTime.Value.Minute;

                trans = b - a;
                
                if (trans > 15)
                {
                    if (trans <= 30)
                    {
                        cantEntre1530++;
                    } 
                    else if (trans <= 60)
                    {
                        cantEntre3060++;
                    } 
                    else if (trans > 60)
                    {
                        cantMas60++;
                    }
                    
                }
                else if (trans <= 15)
                {
                    cantMenos15++;
                }

            }
            
            for (int i = 0; i < wRow2.Count; i++)
            {
                trans = wRow2[i].DateTime.Value.Hour * 60;
                int a = trans + wRow2[i].DateTime.Value.Minute;
                
                trans = ds2[i].DateTime.Value.Hour * 60;
                int b = trans + ds2[i].DateTime.Value.Minute;

                trans = b - a;
                
                if (trans > 15)
                {
                    if (trans <= 30)
                    {
                        cantEntre1530++;
                    } 
                    else if (trans <= 60)
                    {
                        cantEntre3060++;
                    } 
                    else if (trans > 60)
                    {
                        cantMas60++;
                    }
                    
                }
                else if (trans <= 15)
                {
                    cantMenos15++;
                }

            }
            
            serie = chart3.Series.Add("Menor o igual a 15 min");
            serie.Label = cantMenos15.ToString();
            serie.Points.Add(cantMenos15);
            
            serie = chart3.Series.Add("Entre 15 min y 30 min");
            serie.Label = cantEntre1530.ToString();
            serie.Points.Add(cantEntre1530);
            
            serie = chart3.Series.Add("Entre 30 min y 1 hora");
            serie.Label = cantEntre3060.ToString();
            serie.Points.Add(cantEntre3060);
            
            serie = chart3.Series.Add("Mayor a 1 hora");
            serie.Label = cantMas60.ToString();
            serie.Points.Add(cantMas60);
            
            this.chart3.Series.RemoveAt(0);
            




        }
        
         
    }
}