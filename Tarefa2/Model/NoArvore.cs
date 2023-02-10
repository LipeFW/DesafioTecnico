namespace Tarefa2.Model
{
    public class NoArvore
    {
        public int Info;
        public NoArvore Esquerda;
        public NoArvore Direita;

        public NoArvore(int info)
        {
            Info = info;
        }

        public NoArvore InserirEsquerda(int[] array, int inicio, int fim)
        {
            if (inicio >= fim)
            {
                return null;
            }

            var index = inicio;

            var noArvore = new NoArvore(array[index]);

            noArvore.Esquerda = noArvore.InserirEsquerda(array, inicio + 1, fim);

            return noArvore;
        }

        public NoArvore InserirDireita(int[] array, int inicio, int fim)
        {

            if (inicio >= fim)
            {
                return null;
            }

            var index = inicio;

            var noArvore = new NoArvore(array[index]);

            noArvore.Direita = noArvore.InserirDireita(array, inicio + 1, fim);

            return noArvore;
        }
    }
}
