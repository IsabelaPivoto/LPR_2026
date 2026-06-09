int[,] matriz = new int[3, 3];


for(int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($"Digite os valores para [{i}, {j}]:");
        matriz[i,j]= int.Parse(Console.ReadLine() ?? "0");
    }
}
System.Console.WriteLine("Matriz digitada!"); int aux= 0;
for(int i = 0; i<3; i++) {
    for (int j = 0; j < 3; j++)
    {
        System.Console.WriteLine(matriz[i,j]);
        aux += matriz[i,j];
    }

}