using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Dto;

public record ResultadoEnsayoHumedadDto(
    EnsayoHumedad EnsayoHumedad,
    ResultadoHumedad ResultadosHumedad,
    Muestra Muestra,
    Proyecto Proyecto,
    Cliente cl,
    string EnsayadoPor,
    string RevisadoPor,
    string VerificadoPor,
    string AutorizadoPor);