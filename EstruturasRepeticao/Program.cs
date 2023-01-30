//While - Enquanto algo for verdadeira faça
/* While (testeLogico)
        {
            comandos
}
*/

int i = 6000;
Console.WriteLine("uso do while: ");
while (i <= 5000)
{
    Console.WriteLine(i);
    i = i + 1000;
}
Console.WriteLine(new String('-', 50));
/* do - while -
 */
do
{
    Console.WriteLine(i);

} while (i <= 5000);

Console.WriteLine(new String('-', 50));
Console.WriteLine("Comando For");
// for(inicia var; teste Logico; interação)

for (int a=0; a<=10; a++)
{
    Console.WriteLine(a);
}