namespace Tarefa2.Model
{
    public class Arvore
    {
        public NoArvore Raiz { get; set; }

        public int[] ArrayEsquerda = Array.Empty<int>();
        public int[] ArrayDireita = Array.Empty<int>();

        public Arvore(int[] array)
        {
            Raiz = ConstruirArvore(array);
        }

        public NoArvore ConstruirArvore(int[] vetor)
        {
            var raiz = new NoArvore(vetor.Max());

            var indexRaiz = Array.IndexOf(vetor, raiz.Info);

            int[] esquerda = DefineEsquerda(vetor, indexRaiz);
            int[] direita = defineDireita(vetor, indexRaiz);

            raiz.Esquerda = raiz.InserirEsquerda(esquerda, 0, esquerda.Length);

            raiz.Direita = raiz.InserirDireita(direita, 0, direita.Length);

            return raiz;
        }

        private int[] defineDireita(int[] vetor, int indexRaiz)
        {
            var direita = vetor[(indexRaiz + 1)..(vetor.Length)];
            Array.Sort(direita);
            Array.Reverse(direita);

            ArrayDireita = direita;
            return direita;
        }

        private int[] DefineEsquerda(int[] vetor, int indexRaiz)
        {
            var esquerda = vetor[(0)..(indexRaiz)];
            Array.Sort(esquerda);
            Array.Reverse(esquerda);

            ArrayEsquerda = esquerda;
            return esquerda;
        }

        public void ImprimirArvore(NoArvore noArvore, int level = 0)
        {
            if (noArvore == null)
                return;

            ImprimirArvore(noArvore.Direita, level + 1);

            for (int i = 0; i < level; i++)
            {
                Console.Write("    ");
            }

            Console.WriteLine(noArvore.Info);

            ImprimirArvore(noArvore.Esquerda, level + 1);
        }
    }
}
