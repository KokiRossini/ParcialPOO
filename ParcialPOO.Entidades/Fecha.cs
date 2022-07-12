using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPOO.Entidades
{
    public class Fecha
    {
        private int Dia, Mes, Anio;

        public Fecha()
        {
            Dia = DateTime.Now.Day;
            Mes = DateTime.Now.Month;
            Anio = DateTime.Now.Year;
        }
        public Fecha(int dia, int mes, int anio)
        {
            Dia = dia;
            Mes = mes;
            Anio = anio;
        }

        public string MostrarFecha()
        {
            return $"{Dia}/{Mes}/{Anio}";
        }

        public string MostrarFechaConMes()
        {
            return $"{Dia}/{(Meses)Mes}/{Anio}";
        }

        public bool Validar()
        {
            bool esValido = true;
            if (Anio>0)
            {
                if (Mes==1 || Mes==3 || Mes == 5 || Mes == 7 || Mes == 8 || Mes == 10 || Mes == 12)
                {
                    if (Dia >= 0 || Dia <= 31)
                    {
                        esValido=true;
                    }

                }
                else if (Mes==4 || Mes == 6 || Mes == 9 || Mes == 11 )
                {
                    if (Dia >= 0 || Dia <= 30)
                    {
                        esValido=true;
                    }

                }
                else if (Mes==2)
                {
                    if (Dia >= 0 || Dia <= 29)
                    {
                        esValido=true;
                    }

                }
                else
                {
                    esValido = false;
                }
            }
            else
            {
                esValido = false;
            }
            return esValido;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Fecha))
            {
                return false;
            }
            return this.Dia == ((Fecha)obj).Dia &&
            this.Mes == ((Fecha)obj).Mes &&
            this.Anio == ((Fecha)obj).Anio;
        }

        public static bool operator==(Fecha f1, Fecha f2)
        {
            return f1.Equals(f2);
        }
        public static bool operator !=(Fecha f1, Fecha f2)
        {
            return !(f1.Equals(f2));
        }

        public static implicit operator Fecha(string f)
        {
            var array = f.Split('/');
            var dia = int.Parse(array[0]);
            var mes = int.Parse(array[1]);
            var anio = int.Parse(array[2]);
            return new Fecha(dia, mes, anio);
        }


    }
}
