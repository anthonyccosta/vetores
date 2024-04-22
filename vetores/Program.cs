//TIPOS DE VETORES

/// int
//// char
//  float
//  bool
// string tem 256 caractres ultimo ele poem /0 por isso ela sabe o espaço que ela tem

int numero;
int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    numero = int.Parse(Console.ReadLine()); // vai ler o valor inicial como int
    numeros[i] = numero; //vou fazer a variavel numero receber o valor de i (0-5) e colocar o valor na variavel numero
    // numeros[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i< 5; i++)
{
    Console.WriteLine("qq coisa " + numeros[i]);
}