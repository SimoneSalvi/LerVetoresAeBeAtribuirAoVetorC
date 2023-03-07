NewMethod();

static void NewMethod()
{
    int[] A = new int[5];
    int[] B = new int[5];
    int[] C = new int[10];
    int cont = 0;

//vetor a
    for ( cont = 0; cont < A.Length; cont++)
    {
        Console.WriteLine("Informe o numero:");
        A[cont] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Vetor a");
    for (cont = 0; cont < A.Length; cont++)
    {
        Console.WriteLine(A[cont]);
       
    }

//vetor b
    for (cont = 0; cont < B.Length; cont++)
    {
        Console.WriteLine("Informe o numero:");
        B[cont] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Vetor b");
    for (cont = 0; cont < B.Length; cont++)
    {
        Console.WriteLine(B[cont]);

    }

//vetor c

    for (cont = 0 ; cont < C.Length-5; cont++)
    {
        C[cont] = A[cont];
    }
    for (cont = 5 ; cont < C.Length; cont++)
    {
        C[cont] = B[cont-5];
    }   



    Console.WriteLine("Vetor c");
    for (cont = 0; cont < C.Length; cont++)
    {
        Console.WriteLine(C[cont]);

    }

}
