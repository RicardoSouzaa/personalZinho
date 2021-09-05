using SQLite;

namespace personalZinho.Models
{
    public class Aluno
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nome { get; set; }

        public string Exercicio { get; set; }

        public int Series { get; set; }
        public int Rep01 { get; set; }
        public int Rep02 { get; set; }
        public int Rep03 { get; set; }
        public int Rep04 { get; set; }
        public int Rep05 { get; set; }
        public int Rep06 { get; set; }
        public int Rep07 { get; set; }
        public int Rep08 { get; set; }
        public int Rep09 { get; set; }
        public int Rep10 { get; set; }
        public int Rep11 { get; set; }
        public int Rep12 { get; set; }
        public int Carga01 { get; set; }
        public int Carga02 { get; set; }
        public int Carga03 { get; set; }
        public int Carga04 { get; set; }
        public int Carga05 { get; set; }
        public int Carga06 { get; set; }
        public int Carga07 { get; set; }
        public int Carga08 { get; set; }
        public int Carga09 { get; set; }
        public int Carga10 { get; set; }
        public int Carga11 { get; set; }
        public int Carga12 { get; set; }
        public int Intervalo { get; set; }

    }
}
