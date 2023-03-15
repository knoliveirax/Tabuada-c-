namespace ConsoleApp1
{
    class Program
       
    {
        static void Main(string[] args)
        {
            int num;
            int formula, contador, numero;

            
            Console.WriteLine("BEM VINDO");
            
            String nome, sobrenome, mes, nomeMae;
        
            Console.WriteLine("digite seu nome:");
            nome = Console.ReadLine();
            
            Console.WriteLine("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();
            
            Console.WriteLine("digite seu mes");
            mes = Console.ReadLine();
            Console.WriteLine("seu nome: {0} :: seu sobrenome: {1} :: seu mes de nascimento: {2}", nome, sobrenome, mes);

            Console.WriteLine("digite o nome da sua mae");
            nomeMae = Console.ReadLine();
            Console.WriteLine("seus dados sao:\n nome: {0}\n sobrenome: {1}\n mes de nascimento: {2}\n nome da mãe: {3}\n", nome, sobrenome, mes, nomeMae);
           
            Console.WriteLine($"olá, {nome}. eh um prazer te conhecer");

            Console.WriteLine($" {nome}, digite um numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if( num % 2 == 0 ) {
                Console.WriteLine("o numero escolhido eh par");
            }
            else { Console.WriteLine("o numero escolhido eh impar");
            }
            

            Console.Write($"{nome}, digite o mesmo numero para Obter sua tabuada:\n ");
            numero = Int32.Parse(Console.ReadLine());

            for (contador = 1; contador <= 10;  ++contador)
            {
                formula = numero * contador;
                Console.WriteLine( numero + " X " + contador + " = " + formula);
            }
            Console.ReadLine();

        }
    }
}