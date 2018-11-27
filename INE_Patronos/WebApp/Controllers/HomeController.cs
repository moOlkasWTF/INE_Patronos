using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using Highsoft.Web.Mvc.Charts;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<PieSeriesData> pieData = new List<PieSeriesData>();

            pieData.Add(new PieSeriesData { Name = "Candidato1", Y = 45.0, });
            pieData.Add(new PieSeriesData { Name = "Candidato2", Y = 26.8 });
            pieData.Add(new PieSeriesData { Name = "Candidato3", Y = 12.8, });
            pieData.Add(new PieSeriesData { Name = "Candidato4", Y = 8.5 });
            pieData.Add(new PieSeriesData { Name = "Candidato5", Y = 6.2 });
            pieData.Add(new PieSeriesData { Name = "Candidato6", Y = 0.7 });

            ViewData["Grafica_presidente"] = pieData;



            List<ColumnSeriesData> columnData = new List<ColumnSeriesData>()
            {
                new ColumnSeriesData { Name = "Partido1", Y = 56.3},
                new ColumnSeriesData { Name = "Partido2", Y = 24.03 },
                new ColumnSeriesData { Name = "Partido3", Y = 10.3 },
                new ColumnSeriesData { Name = "Partido4", Y = 4.77},
                new ColumnSeriesData { Name = "Partidos Independientes", Y = 3.0},
                

            };

            ViewData["Grafica_partido"] = columnData;



            List<PieSeriesData> pieHalfData = new List<PieSeriesData>();

            pieHalfData.Add(new PieSeriesData { Name = "Candidato1", Y = 45.0 });
            pieHalfData.Add(new PieSeriesData { Name = "candidato2", Y = 26.8 });
            pieHalfData.Add(new PieSeriesData { Name = "Candidato3", Y = 12.8, });
            pieHalfData.Add(new PieSeriesData { Name = "Candidato4", Y = 8.5 });

            ViewData["Grafica_gobernador"] = pieHalfData;



            List<PieSeriesData> pieHalfData1 = new List<PieSeriesData>();

            pieHalfData1.Add(new PieSeriesData { Name = "Candidato1", Y = 34.0 });
            pieHalfData1.Add(new PieSeriesData { Name = "candidato2", Y = 50.8 });
            pieHalfData1.Add(new PieSeriesData { Name = "Candidato3", Y = 16.8, });
            pieHalfData1.Add(new PieSeriesData { Name = "Candidato4", Y = 16.5 });

            ViewData["Grafica_alcalde"] = pieHalfData1;



            List<ColumnSeriesData> columnVotingData = new List<ColumnSeriesData>()
            {
                new ColumnSeriesData { Name = "Personas que Ya votaron", Y = 56.3},
                new ColumnSeriesData { Name = "Personas que no votaron", Y = 24.03 },
            };
            ViewData["Grafica_votaciones"] = columnVotingData;

            return View();

            
        }

        public ActionResult Login()
        {
            return View();
        }




    }
}