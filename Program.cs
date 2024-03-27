Random rnd = new Random();
int hpHero = 10;
int hpMonster = 10;
int hitAtk;

do
{   
    hitAtk = rnd.Next(1,10);
    System.Console.WriteLine($"Monster lost {hitAtk} points of hp");
    hpMonster -= hitAtk;
    System.Console.WriteLine($"Monster have {hpMonster} hp");
    if (hpMonster > 0)
    {
        hitAtk = rnd.Next(1,10);
        System.Console.WriteLine($"Human lost {hitAtk} point of hp");
        hpHero -= hitAtk;
        System.Console.WriteLine($"Human have {hpHero} hp");
    }

} while (hpMonster > 0 && hpHero > 0);

System.Console.WriteLine(hpHero > hpMonster ? "Hero wins!" : "Monster wins");

// int i = 0;
// do
// {
//     i++;

//     // Se i for divisível por 2, pule esta iteração do loop
//     if (i % 2 == 0)
//     {
//         continue; // Isso fará com que o controle volte para a condição do loop
//     }

//     Console.WriteLine("Número ímpar: " + i);

//     // O código abaixo não será executado se o continue for acionado
//     Console.WriteLine("Este texto não será impresso se o número for par.");

// } while (i < 5);