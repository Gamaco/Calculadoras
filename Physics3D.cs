﻿using System;

public class Physics3D
{
	public Physics3D()
	{


	}

    // Alfa
    public float calcularAngulo(float rX,float rY,float R, float rZ)
    {
        float sum = (float) (Math.Pow(rX, 2) + Math.Pow(rY, 2));
        float sqrt = (float) Math.Sqrt(sum);
        float angulo = (float) ( Math.Asin(sqrt / R) );
        float grado = (float) angulo * (180 / (float) Math.PI);
        if (rZ < 0)
        {
            grado += 90;
        }
        return grado;
    }

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

    // Calcular el valor de Z
    public float calcularComponenteZ(double magnitud, double angulo)
    {
        double distanciaEnGrados = angulo * (Math.PI / 180);
        return (float)(magnitud * Math.Cos(distanciaEnGrados));
    }


    // La magnitud es A
    public float calcularMagitud(double x, double y, double z)
    {
        return MathF.Sqrt((float)(x * x + y * y + z * z));
    }

    // La dirección es θ
    public float calcularDireccion(float x, float y)
    {
        double angulo3 = 0;

        double angulo = Math.Atan(y / x);
        double anguloEnGrados = angulo * (180 / Math.PI);

        if (x == 0 && y > 0)
        {
            angulo3 = 90;
        }
        else if (x == 0 && y < 0)
        {
            angulo3 = 270;
        }
        else if (x > 0 && y >= 0)
        {
            angulo3 = anguloEnGrados + valorDeCuadrante(x, y);
        }
        else if (x < 0 && y >= 0 || x < 0 && y < 0)
        {
            angulo3 = anguloEnGrados + 180;
        }
        else if (x > 0 && y < 0)
        {
            angulo3 = anguloEnGrados + 360;
        }
        return (float)angulo3;
    }

    // Devuelve el valor a sumar según el cuadrante que corresponden las coordenadas XY.
    public float valorDeCuadrante(float x, float y)
    {
        switch (x, y)
        {
            case ( > 0, > 0): return 0;       // Cuadrante 1
            case ( < 0, > 0): return 180;     // Cuadrante 2
            case ( < 0, < 0): return 180;     // Cuadrante 3
            case ( > 0, < 0): return 360;     // Cuadrante 4
            default: return 0;
        }
  
    }
}

