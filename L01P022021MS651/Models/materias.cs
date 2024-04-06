using System.ComponentModel.DataAnnotations;

namespace L01P022021MS651.Models
{
    public class materias
    {


        [Key] //Ma

        public int id { get; set; }
        public string? materia { get; set; }
        public int? unidades_valorativas { get; set; }
        public string? estado { get; set; }

    }
}
