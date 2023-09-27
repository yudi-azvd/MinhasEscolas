using MinhasEscolas.Modelos;

namespace MinhasEscolas.Repositorios;

public static class EscolasRepositorio
{
    private static int NextId = 1;
    private static List<Escola> Escolas { get; set; }

    static EscolasRepositorio() {
        Escolas = new List<Escola>
            {
                new () {Id = NextId++, Name = "Centro Educaional Adventista", Latitude = 1.0f, Longitude = 2.0f, QtdProfessores = 3},
                new () {Id = NextId++, Name = "SIGMA", Latitude = 1.0f, Longitude = 2.0f, QtdProfessores = 7},
            };
    }

    static public List<Escola> ObterTodas() {
        return Escolas;
    }

    static public Escola? Obter(int id) {
        return Escolas.FirstOrDefault(e => e.Id == id);;
    }
    
    static public void Adicionar(Escola escola) {
        Escolas.Add(escola);
    }
}