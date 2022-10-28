using Calculadora_PSP01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculadora_PSP01.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: Calculadora
        public ActionResult Index()
        {
            ViewBag.Ms = "Ingrese 2 números";
            return View();
        }

        public ActionResult Sumar()
        {
            ViewBag.Ms = "Ingrese 2 números";
            if (double.TryParse(Request.Form["numero1"], out _) && double.TryParse(Request.Form["numero2"], out _))
            {
                Calculadora calculadora = new Calculadora();
                calculadora.SetNumero1(Convert.ToDouble(Request.Form["numero1"]));
                calculadora.SetNumero2(Convert.ToDouble(Request.Form["numero2"]));
                double resultadoDouble = calculadora.Suma();
                if (resultadoDouble < 1)
                {
                    ViewBag.Ms = "Esta operación es invalida";
                }
                else
                {
                    ViewData["respuesta"] = resultadoDouble;
                }
            }
            else
            {
                if (!double.TryParse(Request.Form["numero1"], out _))
                {
                    ViewBag.numero1 = "Este campo en requerido";
                }

                if (!double.TryParse(Request.Form["numero2"], out _))
                {
                    ViewBag.numero2 = "Este campo en requerido";
                }
            }
            return View();
        }

        public ActionResult Restar()
        {
            ViewBag.Ms = "Ingrese 2 números";
            if (double.TryParse(Request.Form["numero1"], out _) && double.TryParse(Request.Form["numero2"], out _))
            {
                Calculadora calculadora = new Calculadora();
                calculadora.SetNumero1(Convert.ToDouble(Request.Form["numero1"]));
                calculadora.SetNumero2(Convert.ToDouble(Request.Form["numero2"]));
                double resultadoDouble = calculadora.Resta();
                if (resultadoDouble < 1)
                {
                    ViewBag.Ms = "Esta operación es invalida";
                }
                else
                {
                    ViewData["respuesta"] = resultadoDouble;
                }
            }
            else
            {
                if (!double.TryParse(Request.Form["numero1"], out _))
                {
                    ViewBag.numero1 = "Este campo en requerido";
                }

                if (!double.TryParse(Request.Form["numero2"], out _))
                {
                    ViewBag.numero2 = "Este campo en requerido";
                }
            }
            return View();
        }

        public ActionResult Multiplicar()
        {
            ViewBag.Ms = "Ingrese 2 números";
            if (double.TryParse(Request.Form["numero1"], out _) && double.TryParse(Request.Form["numero2"], out _))
            {
                Calculadora calculadora = new Calculadora();
                calculadora.SetNumero1(Convert.ToDouble(Request.Form["numero1"]));
                calculadora.SetNumero2(Convert.ToDouble(Request.Form["numero2"]));
                double resultadoDouble = calculadora.Multiplicacion();
                if (resultadoDouble < 1)
                {
                    ViewBag.Ms = "Esta operación es invalida";
                }
                else
                {
                    ViewData["respuesta"] = resultadoDouble;
                }
            }
            else
            {
                if (!double.TryParse(Request.Form["numero1"], out _))
                {
                    ViewBag.numero1 = "Este campo en requerido";
                }

                if (!double.TryParse(Request.Form["numero2"], out _))
                {
                    ViewBag.numero2 = "Este campo en requerido";
                }
            }
            return View();
        }

        public ActionResult Dividir()
        {
            ViewBag.Ms = "Ingrese 2 números";
            if (double.TryParse(Request.Form["numero1"], out _) && double.TryParse(Request.Form["numero2"], out _))
            {
                Calculadora calculadora = new Calculadora();
                calculadora.SetNumero1(Convert.ToDouble(Request.Form["numero1"]));
                calculadora.SetNumero2(Convert.ToDouble(Request.Form["numero2"]));
                decimal resultadoDouble = calculadora.Division();
                if (resultadoDouble < 1)
                {
                    ViewBag.Ms = "Esta operación es invalida";
                }
                else
                {
                    ViewData["respuesta"] = Convert.ToString(resultadoDouble);
                }
            }
            else
            {
                if (!double.TryParse(Request.Form["numero1"], out _))
                {
                    ViewBag.numero1 = "Este campo en requerido";
                }

                if (!double.TryParse(Request.Form["numero2"], out _))
                {
                    ViewBag.numero2 = "Este campo en requerido";
                }
            }
            return View();
        }
    }
}