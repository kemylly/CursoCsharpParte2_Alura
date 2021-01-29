namespace ByteBank3
{
    public class Cliente
    {
        public string Nome { get; set; }
        private string _cpf {get; set;}
        public string CPF { 
            get
            {
                return _cpf;
            } 
            set
            {
                _cpf = value; //onde coloco a logiv=ca para validar um cpf
            } 
        }
        public string Profissao { get; set; }
        
    }
}