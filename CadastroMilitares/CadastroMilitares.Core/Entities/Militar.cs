using CadastroMilitares.Core.Enums;

namespace CadastroMilitares.Core.Entities
{
    public class Militar
    {
        public Militar(Guid idMilitar, string nomeDeGuerra, SexoEnum sexo, string divisao)
        {
            IdMilitar = idMilitar;
            NomeDeGuerra = nomeDeGuerra;
            Sexo = sexo;
            Divisao = divisao;
        }

        public Guid IdMilitar { get; set; }
        public string NomeDeGuerra { get; set; }
        public SexoEnum Sexo { get; set; }
        public string Divisao { get; set; }
    }
}
