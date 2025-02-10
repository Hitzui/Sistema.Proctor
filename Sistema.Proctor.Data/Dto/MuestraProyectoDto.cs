namespace Sistema.Proctor.Data.Dto;

public record MuestraProyectoDto(
    int Id,
    int ParentId,
    string CodigoProyecto,
    string CodigoIngreso,
    string NumeroMuestra);
