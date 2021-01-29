namespace ByteBank2
{
    public class ContaCorrente
    {
        public Cliente titular { get; set; }
        public int agencia { get; set; }
        public int numero { get; set; }
        public double saldo { get; set; }

        public bool Sacar(double valor)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar (double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);

                return true;
            }
        }
    }
}