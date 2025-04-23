public class Lasagna
{
    /*
    ### 1. Defina o tempo de forno esperado em minutos

    Defina o método `Lasagna.ExpectedMinutesInOven()` que não recebe nenhum parâmetro e retorna quantos minutos a lasanha deve ficar no forno. De acordo com o livro de receitas, o tempo de forno esperado em minutos é 40:

    ```c#
        var lasagna = new Lasagna();
        lasagna.ExpectedMinutesInOven();
        // => 40
    ```
    */

    public int ExpectedMinutesInOven()
    {
        return 40; // Tempo esperado no forno em minutos
    }

    /*
    ### 2. Calcule o tempo restante do forno em minutos

    Defina o método `Lasagna.RemainingMinutesInOven()` que toma como parâmetro os minutos reais que a lasanha ficou no forno e retorna quantos minutos a lasanha ainda tem que permanecer no forno, com base no tempo de forno esperado em minutos da tarefa anterior.

    ```c#
        var lasagna = new Lasagna();
        lasagna.RemainingMinutesInOven(30);
        // => 10
    ```
    */

    public int RemainingMinutesInOven(int minutesInOven)
    {
        return ExpectedMinutesInOven() - minutesInOven; // Calcula o tempo restante
    }

    /*
    ### 3. Calcule o tempo de preparação em minutos

    Defina o método `Lasagna.PreparationTimeInMinutes()` que usa o número de camadas que você adicionou à lasanha como parâmetro e retorna quantos minutos você gastou preparando a lasanha, supondo que cada camada leve 2 minutos para ser preparada.

    ```c#
        var lasagna = new Lasagna();
        lasagna.PreparationTimeInMinutes(2);
        // => 4
    ```
    */

    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2; // Cada camada leva 2 minutos para ser preparada
    }

    /*
    ### 4. Calcule o tempo decorrido em minutos

    Defina o método `Lasagna.ElapsedTimeInMinutes()` que recebe dois parâmetros: o primeiro parâmetro é o número de camadas que você adicionou à lasanha, e o segundo parâmetro é o número de minutos que a lasanha ficou no forno. A função deve retornar quantos minutos você levou para assar a lasanha, que é a soma do tempo de preparo em minutos e o tempo em minutos que a lasanha ficou no forno até o momento.

    ```c#
        var lasagna = new Lasagna();
        lasagna.ElapsedTimeInMinutes(3, 20);
        // => 26
    ```
    */

    public int ElapsedTimeInMinutes(int layers, int minutesInOven)
    {
        return PreparationTimeInMinutes(layers) + minutesInOven; // Soma o tempo de preparo e o tempo no forno
    }
}
