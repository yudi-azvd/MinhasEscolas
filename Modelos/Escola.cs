
using System.ComponentModel.DataAnnotations;

namespace MinhasEscolas.Modelos;

public class Escola {
    public int Id { get; set; }

    [Required, MinLength(4)]
    public string Name { get; set; }

    public int QtdProfessores { get; set; }

    [Required]
    public float Longitude { get; set; }

    public float Latitude { get; set; }
}
