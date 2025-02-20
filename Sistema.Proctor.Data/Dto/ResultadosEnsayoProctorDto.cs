using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Dto;

public record ResultadosEnsayoProctorDto(
    decimal AguaAgregada,
    decimal PesoMoldeMaterialHumedo,
    decimal PesoMolde,
    decimal PesoMaterialHumedo,
    decimal VolumenMolde,
    decimal DensidadHumeda,
    string TaraNumero,
    decimal TaraMaterialHumedo,
    decimal TaraMaterialSeco,
    decimal PesoAgua,
    decimal PesoTara,
    decimal PesoSueloSeco,
    decimal ContenidoHumedad,
    decimal DensidadSeca,
    EnsayoProctor EnsayoProctor,
    Muestra Muestra,
    string DescripcionProyecto,
    string NombreCliente,
    string NombresEmpleado
);