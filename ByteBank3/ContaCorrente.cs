namespace ByteBank3
{
    public class ContaCorrente
    {
        public static int TotalDeContas { get; private set; } 
        //usar o static torna essa propriedade comum a todos os objetos

        private Cliente _titular { get; set; }
        public Cliente Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        private int _agencia { get; set; }
        public int Agencia { 
            get
            {
                return _agencia;
            } 
            set
            {
                if(value <= 0)
                {
                    return;
                }

                _agencia = value;
            } 
        }

        public int Numero { get; set; }
        private double _saldo { get; set; }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                
                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)  //construtor
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContas++;
        }

        public void DefinirSaldo(double saldo)  //SetSaldo
        {
            if (saldo < 0)
            {
                return;
            }
            
            this._saldo = saldo;
        }

        public double ObterSaldo() //GetSaldo
        {
            return _saldo;
        }

        public bool Sacar(double valor)
        {
            if(this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        public void Depositar (double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);

                return true;
            }
        }
    }
}