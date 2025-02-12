namespace Sistema.Proctor.WinForm.Data;

public class Formulas
{
    public static decimal VolumenCilindro(decimal diametro, decimal altura)
    {
        var area =  (decimal)Math.PI * (decimal.Multiply(diametro, diametro) /4);
        return area * altura;
    }

    public static decimal PesoMaterialHumedo(decimal pesoMaterialMoldeHumedo, decimal pesoMolde) =>
        decimal.Subtract(pesoMaterialMoldeHumedo, pesoMolde);

    public static decimal DensidadHumeda(decimal peso, decimal volumen) => decimal.Divide(peso, volumen)*1000;

    public static decimal DensidadSeca(decimal densidadHumeda, decimal humedad) => densidadHumeda / (1 + decimal.Divide(humedad, 100m));
}