using Pontos;
using System;

public static class PontoExtensions
{
    public static Ponto InverterX_Y(this Ponto p)
    {
        int aux= p.X;
        p.X = p.Y;
        p.Y = aux;
        return p;
    }
}
