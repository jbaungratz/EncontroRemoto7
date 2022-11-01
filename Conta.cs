namespace UC12_SA2_ER5
{
    public abstract class Conta
    {
        public string? agencia {get; private set;}

        public string? numero {get; private set;}

        public double saldo { get; private set;}

        
        public Conta(string argNumero, string argAgencia){
            setNumero(argNumero);
            setAgencia(argAgencia);
            setSaldo(0);

        }


        public void setNumero(string argNumero){
            if (argNumero.Length > 4){
                this.numero = argNumero;
            }
        }

        public void setAgencia(string argAgencia){
            if (argAgencia.Length > 2){
                this.agencia = argAgencia;
            }
        }

    public void setSaldo(double argSaldo){
            this.saldo = argSaldo;
        }

      //  public virtual string /*Imprimir*/toString(){

/*                string texto;
                texto = "Agência: " + this.Agencia;
                texto += "\nNúmero: " + this.Numero;
                texto += "\nSaldo: " + this.Saldo;
                return texto;
        } */
            
/*
        public virtual void Imprimir(string age, string num, double sal){
            Console.WriteLine("Agência: " + age + "\nConta: " + num + "\nSaldo: " + sal );
            
        } */

        public abstract bool Sacar(double argValor);

        public bool Depositar(double argValor){
            if (argValor > 0){
            this.saldo = this.saldo + argValor;
            return true;
            }
            else{
                return false;
            }
        }

        public string ToString(){
            string texto = "Agencia: " + this.agencia +
                           "\nNro. Conta: " + this.numero +
                           "\nSaldo: " + this.saldo;
            return texto;
        }

        /*
        Métodos:
        -possuem o modificador de visibilidade (public, provate, protected...)
        retorno (bool, string, int, double, float, objeto de uma classe, lista, void...)
        nome do método (padrão não é regra, mas não é bom seguir... iniciais maiúsculas e denotam ação...
        exemplo de verbos no infinitivo.... Depositar, Sacar, Imprimir, Verificar, Calcular...etc)
        argumentos (são os valores, que podem existir ou não, para que um método funcione. Chamamos de assinatura do método)


        */
    } 
}