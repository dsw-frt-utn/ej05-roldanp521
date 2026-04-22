using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Dsw2026Ej5.Domain;

public class VehiculoCombustible: Vehiculo
{
    private double kilometrosPorLitro;
    private double litrosExtra;
    private double extras;
    private int antiguedad;

    public VehiculoCombustible(string patente, string marca, string modelo, int anio, double capacidadCarga, 
        Sucursal sucursal, double kilometrosPorLitro, double litrosExtra) : base(VehiculoTipo.Combustible, patente, marca, modelo, anio, capacidadCarga, sucursal)
    {
        this.kilometrosPorLitro = kilometrosPorLitro;
        this.litrosExtra = litrosExtra;
    }

    public double GetKilometrosPorLitro()
    {
        return kilometrosPorLitro;
    }

    public double GetLitrosExtra()
    {
        return litrosExtra;
    }

    public override double CalcularConsumo(double kilometros)
    {
        antiguedad = DateTime.Now.Year - anio;

        if (antiguedad >5)
        {
            extras = (kilometros/15) * litrosExtra ;
        }
        else
        {
            extras = 0;
        }

        double total = (kilometros/ kilometrosPorLitro) + extras ; 

        return total;
    }
}
