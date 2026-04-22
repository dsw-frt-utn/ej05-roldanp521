using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej5.Domain;

public abstract class Vehiculo
{
    private string patente;
    private string marca;
    private string modelo;
    protected int anio;
    protected double capacidadCarga;
    private Sucursal sucursal;
    private VehiculoTipo tipo;

    protected Vehiculo(VehiculoTipo tipo, string patente, string marca, string modelo, int anio, double capacidadCarga, Sucursal sucursal)
    {
        this.patente = patente;
        this.marca = marca;
        this.modelo = modelo;
        this.anio = anio;
        this.capacidadCarga = capacidadCarga;
        this.sucursal = sucursal;
        this.tipo = tipo;
    }

    public string GetPatente()
    {
        return patente;
    }

    public string GetMarca()
    {
        return marca;
    }

    public string GetModelo()
    {
        return modelo;
    }

    public int GetAnio()
    {
        return anio;
    }

    public double GetCapacidadCarga()
    {
        return capacidadCarga;
    }

    public Sucursal GetSucursal()
    {
        return sucursal;
    }

    public VehiculoTipo GetTipo()
    {
        return tipo;
    }

    public abstract double CalcularConsumo(double kilometros);

    public bool EsDe(VehiculoTipo tipo)
    {
        return this.tipo == tipo;
    }

    public override string ToString()
    {
        return $"{marca} {modelo}";
    }
}
