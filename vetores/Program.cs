//TIPOS DE VETORES

/// int
//// char
//  float
//  bool
// string tem 256 caractres ultimo ele poem /0 por isso ela sabe o espaço que ela tem

char[] palavra = new char[10];

for (int i = 0; i < 10; i++)
{
    palavra[i] = char.Parse(Console.ReadLine()); //vou fazer a variavel numero receber o valor de i (0-5) e colocar o valor na variavel numero
    // numeros[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i< 10; i++)
{
    Console.Write(palavra[i]);
}
// vetor vem de tras para frente
Console.WriteLine(); // pular uma linha
int x = 9;
while (x >= 0)
{
    Console.Write(palavra[x]);
    x--;
}

Console.WriteLine();
for (int y = 1;  y< 10;  y+= 2) // aumentar de dois em dois nos vetores
{
    Console.Write(palavra[y]);
} 