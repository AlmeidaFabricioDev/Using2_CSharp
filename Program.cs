namespace Utilizando_using2_em_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*aqui abaixo deve ser colocado o caminho do arquivo, porém nesse caso temos um  texto que o StringReader irá ler*/
            string linhas = @"Esta é a primeira linha 
                            Esta é a segunda linha
                            Está é a penultima linha
                            Esta é a última linha";

            using (var leitor = new StringReader(linhas)) //Aqui utilizamos o using pois está instrução fornece uma abordagem melhor para destruição de arquivos
                         //criamos a variável leitor do tipo var que recebe a Classe StringReader derivada da classe TextReader que fará a leitura do arquivo linhas.


                try //Aqui utilizamos o try para testar pontos críticos do código, ou seja, lugares que onde há grande possibilidade de erros
                {
                    string item; //Criamos uma variável do tipo string com o nome de item 

                    do //Dentro do bloco try utilizamos a Estrutura de repetição Do while (Faça enquanto), que irá executar se o arquivo dentro de item se for direfente de nulo.
                    {
                        item = leitor.ReadLine(); //Item recebe o leitor que é o tipo var(maneira implícita ou indireta de definir os dados) se for diferente de nulo,
                                                  //que dentro do leitor tem o arquivo linhas

                        Console.WriteLine(item); //Se tudo estiver correto será printado na tela.
                    } while (item != null); //O que está dentro do do while só irá executar se o arquivo for dirente de nulo.

                }
                finally //Após, se tudo der certo o leitor é fechado!
                {
                    leitor.Dispose(); //Aqui utilizamos o método Dispose que é um meio de liberar a memória usada sem ter que esperar o Garbage Collector fazer isso
                }



        }
    }
}