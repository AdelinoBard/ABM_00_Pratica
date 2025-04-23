public class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    /*
    ### 1. Verifique quais foram as contagens da semana passada

    Para fins de comparação, você sempre mantém uma cópia das contagens da semana passada por perto, que foram: 0, 2, 5, 3, 7, 8 e 4. Implemente o método ( _estático_ ) `BirdCount.LastWeek()`que retorna as contagens da semana passada:

    ```c#
        BirdCount.LastWeek();
        // => [0, 2, 5, 3, 7, 8, 4]
    ``` 
    */

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    /*
    ### 2. Verifique quantos pássaros visitaram hoje

    Implemente o `BirdCount.Today()`método para retornar quantos pássaros visitaram seu jardim hoje. As contagens de pássaros são ordenadas por dia, com o primeiro elemento sendo a contagem do dia mais antigo e o último elemento sendo a contagem de hoje.

    ```c#
        int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
        var birdCount = new BirdCount(birdsPerDay);
        birdCount.Today();
        // => 1
    ```    
    */

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    /*
    ### 3. Aumente a contagem de hoje

    Implemente o `BirdCount.IncrementTodaysCount()`método para incrementar a contagem de hoje:

    ```c#
        int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
        var birdCount = new BirdCount(birdsPerDay);
        birdCount.IncrementTodaysCount();
        birdCount.Today();
        // => 2
    ```    
    */

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    /*
    ### 4. Verifique se houve algum dia sem pássaros visitantes

    Implemente o `BirdCount.HasDayWithoutBirds()`método que retorna `true`se houve um dia em que zero pássaros visitaram o jardim; caso contrário, retorne `false`:

    ```c#
        int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
        var birdCount = new BirdCount(birdsPerDay);
        birdCount.HasDayWithoutBirds();
        // => true
    ```    
    */

    // Tarefa 4: Verificar se houve dia sem pássaros
    public bool HasDayWithoutBirds()
    {
        foreach (int count in birdsPerDay)
        {
            if (count == 0)
            {
                return true;
            }
        }
        return false;
    }

    /*
    ### 5. Calcule o número de pássaros visitantes para o primeiro número de dias

    Implemente o `BirdCount.CountForFirstDays()`método que retorna o número de pássaros que visitaram seu jardim desde o início da semana, mas limite a contagem ao número especificado de dias a partir do início da semana.

    ```c#
        int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
        var birdCount = new BirdCount(birdsPerDay);
        birdCount.CountForFirstDays(4);
        // => 14
    ```    
    */

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;
        for (int i = 0; i < numberOfDays && i < birdsPerDay.Length; i++)
        {
            total += birdsPerDay[i];
        }
        return total;
    }

    /*
    ### 6. Calcule o número de dias movimentados

    Alguns dias são mais movimentados que outros. Um dia movimentado é aquele em que cinco ou mais pássaros visitaram seu jardim. Implemente o `BirdCount.BusyDays()`método para retornar o número de dias movimentados:

    ```c#
        int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
        var birdCount = new BirdCount(birdsPerDay);
        birdCount.BusyDays();
        // => 2
    ```    
    */

    public int BusyDays()
    {
        int busyDayCount = 0;
        foreach (int count in birdsPerDay)
        {
            if (count >= 5)
            {
                busyDayCount++;
            }
        }
        return busyDayCount;
    }
}
