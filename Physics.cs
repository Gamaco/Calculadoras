using System;
using System.Reflection.Metadata;
using System.Xml.Schema;

namespace Calculadoras
{
    internal class Physics
    {
        public Physics() { }


        // Calcular el valor de X
        public float calcularComponenteX(double magnitud, double distancia)
        {
            double distanciaEnGrados = distancia * (Math.PI / 180);
            return (float)(magnitud * Math.Cos(distanciaEnGrados));
        }

        // Calcular el valor de Y
        public float calcularComponenteY(double magnitud, double distancia)
        {
            double distanciaEnGrados = distancia * (Math.PI / 180);
            return (float)(magnitud * Math.Sin(distanciaEnGrados));
        }

        // La magnitud es A
        public float calcularMagitud(double x, double y)
        {
            return MathF.Sqrt((float)(x * x + y * y));
        }

        // La dirección es θ
        public float calcularDireccion(float x, float y)
        {
            double angulo = Math.Atan(y / x);
            double anguloEnGrados = angulo * (180 / Math.PI);

            return (float) anguloEnGrados + valorDeCuadrante(x, y);
        }

        // Devuelve el valor a sumar según el cuadrante que corresponden las coordenadas XY.
        public float valorDeCuadrante(float x, float y)
        {
            switch (x, y)
            {
                case  ( > 0, > 0 ):  return 0;       // Cuadrante 1
                case  ( < 0, > 0 ):  return 180;     // Cuadrante 2
                case  ( < 0, < 0 ):  return 180;     // Cuadrante 3
                case  ( > 0, < 0 ):  return 360;     // Cuadrante 4
                default: return -1;                  // Error
            }
        }
    }
  
}
