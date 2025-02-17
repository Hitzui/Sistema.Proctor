using MathNet.Numerics.Differentiation;

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

    public static (double, double) EncontrarMaximo(double[] coef, double xMin, double xMax)
    {
        // Coeficientes de la derivada f'(x) = a1 + 2*a2*x + 3*a3*x^2
        double a1 = coef[1];
        double a2 = 2 * coef[2];
        double a3 = 3 * coef[3];

        // Resolver la ecuación cuadrática a3*x^2 + a2*x + a1 = 0
        double discriminante = a2 * a2 - 4 * a3 * a1;

        if (discriminante < 0)
            return (xMin, EvaluatePolynomial(coef, xMin)); // No hay raíces reales

        // Calcular las raíces (posibles puntos críticos)
        double x1 = (-a2 + Math.Sqrt(discriminante)) / (2 * a3);
        double x2 = (-a2 - Math.Sqrt(discriminante)) / (2 * a3);

        // Seleccionar el punto máximo dentro del rango
        double mejorX = xMin;
        double mejorY = EvaluatePolynomial(coef, xMin);

        if (x1 >= xMin && x1 <= xMax)
        {
            double y1 = EvaluatePolynomial(coef, x1);
            if (y1 > mejorY)
            {
                mejorX = x1;
                mejorY = y1;
            }
        }

        if (x2 >= xMin && x2 <= xMax)
        {
            double y2 = EvaluatePolynomial(coef, x2);
            if (y2 > mejorY)
            {
                mejorX = x2;
                mejorY = y2;
            }
        }

        return (mejorX, mejorY);
    }

    public static double EvaluatePolynomial(double[] coef, double x)
    {
        double y = 0;
        for (int i = 0; i < coef.Length; i++)
            y += coef[i] * Math.Pow(x, i);
        return y;
    }
}