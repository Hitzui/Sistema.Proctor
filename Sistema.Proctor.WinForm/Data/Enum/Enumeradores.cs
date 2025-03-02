namespace Sistema.Proctor.WinForm.Data.Enum;

public class Enumeradores
{
    public List<string> PesoMartillo;
    public List<string> TemperaturaSecado;
    public List<string> GolpesPorCapa;
    public List<string> NumeroCapas;
    public List<string> TipoProctor;
    public List<string> Norma;
    public List<string> MetodoUtilizado;

    public Enumeradores()
    {
        PesoMartillo=new List<string>{"5.5","10"};
        TemperaturaSecado=new List<string>{"60","110"};
        GolpesPorCapa=new List<string>{"25","56"};
        NumeroCapas=new List<string>{"3","5"};
        TipoProctor=new List<string>{"Proctor modificado","Proctor estándar"};
        Norma=new List<string>{"ASTM D1557-12(2021)","ASTM D 698-12(2021)"};
        MetodoUtilizado=new List<string>{"A","B","C"};
    }
}