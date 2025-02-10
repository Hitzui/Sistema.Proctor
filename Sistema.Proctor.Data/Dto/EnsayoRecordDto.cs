namespace Sistema.Proctor.Data.Dto;

public record EnsayoRecordDto(int IdMuestra,int IdTipoEnsayo, string Descripcion)
{
    public override string ToString()
    {
        return Descripcion;
    }
}