using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class ClsIMC
    {
        private float Estatura;
        private float peso;
        private float zancada;
        private float pasos;
        private float IMC;
        private float DistanciaR;

        public ClsIMC()
        {
            Estatura = 0;
            peso = 0;
            zancada = 0;
            pasos = 0;
            IMC = 0;
            DistanciaR = 0;
        }
        public float C_Estatura
        {
            set { Estatura = value; }
            get { return Estatura; }
        }
        public float C_peso
        {
            set { peso= value; }
            get { return peso; }
        }
        public float C_zancada
        {
            set { zancada=value; }
            get { return zancada; }
        }
        public float C_Pasos
        {
            set { pasos = value; }
            get { return pasos; }
        }

        public float CalcularIMC()
        {
            IMC = peso / (Estatura * Estatura);

            return IMC;
        }
        public (string,float ) Estado()
        {
            if (IMC<18){
                return ("Tu IMC es bajo",0);
            }
            else if(IMC>=18 && IMC<25){
                return ("Tu IMC es ideal, debes de recorrer almenos 3km de distancia",3);
            }
            else if(IMC>=25 && IMC < 30)
            {
                return ("Padeces Sobrepeso, debes de recorrer al menos 5km",5);
            }
            else
            {
                return ("Padeces Obesidad, debes recorrer almenos 10 km",10);
            }
        }
        public float CalcularDistancia()
        {
            DistanciaR = zancada * pasos/100000;
            return DistanciaR;
        }
        public string C_Faltante(float Faltante)
        {
            if (Faltante==0) {
                return "Tu IMC es bajo por lo que no es necesario que recorras una cierta distancia";
            }
            else
            {
                if (DistanciaR < Faltante){
                    float total;
                    total = Faltante - DistanciaR;
                    return "La distancia que falta por recorrer es de " + total;
                }
                else
                {
                    return "Haz recorrido la distancia suficiente";
                }
            }

            
        }

    }
}
