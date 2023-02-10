using Tarefa2.Model;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[] { 7, 5, 13, 9, 1, 6, 4 };

        var arvore = new Arvore(vetor);

        Console.WriteLine("Array de entrada: [" + string.Join(", ", vetor) + "]");
        Console.WriteLine("Raíz: " + arvore.Raiz.Info);
        Console.WriteLine("Galhos da esquerda: [" + string.Join(", ", arvore.ArrayEsquerda) + "]");
        Console.WriteLine("Galhos da direita: [" + string.Join(", ", arvore.ArrayDireita) + "]\n");

        arvore.ImprimirArvore(arvore.Raiz);
    }
}