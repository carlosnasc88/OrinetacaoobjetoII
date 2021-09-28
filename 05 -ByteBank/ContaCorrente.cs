//using _05__ByteBank;




namespace _05__ByteBank
{
    
    public class ContaCorrete
{
    public Cliente titular;
    public int agencia;
    public int numero;
    public double saldo = 100;



    public bool Sacar(double valor)
    {

        if (this.saldo < valor)
        {
            return false;


        }
        else
        {
            this.saldo -= valor;
            return true;

        }



    }
    public void Depositar(double valor)
    {

        this.saldo += valor;









    }
    public bool Transferir(double valor, ContaCorrete contaDestino)
    {
        if (this.saldo < valor)
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
