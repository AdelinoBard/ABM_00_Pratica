# Matrizes_ObservadorPassaros

[exercism.org/](https://exercism.org/tracks/csharp/exercises/bird-watcher)

## Instruções

Você é um observador de pássaros ávido que registra quantos pássaros visitaram seu jardim nos últimos sete dias.

Você tem seis tarefas, todas relacionadas ao número de pássaros que visitaram seu jardim.

### 1. Verifique quais foram as contagens da semana passada

Para fins de comparação, você sempre mantém uma cópia das contagens da semana passada por perto, que foram: 0, 2, 5, 3, 7, 8 e 4. Implemente o método ( _estático_ ) `BirdCount.LastWeek()`que retorna as contagens da semana passada:

```c#
    BirdCount.LastWeek();
    // => [0, 2, 5, 3, 7, 8, 4]
```    

### 2. Verifique quantos pássaros visitaram hoje

Implemente o `BirdCount.Today()`método para retornar quantos pássaros visitaram seu jardim hoje. As contagens de pássaros são ordenadas por dia, com o primeiro elemento sendo a contagem do dia mais antigo e o último elemento sendo a contagem de hoje.

```c#
    int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
    var birdCount = new BirdCount(birdsPerDay);
    birdCount.Today();
    // => 1
```    

### 3. Aumente a contagem de hoje

Implemente o `BirdCount.IncrementTodaysCount()`método para incrementar a contagem de hoje:

```c#
    int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
    var birdCount = new BirdCount(birdsPerDay);
    birdCount.IncrementTodaysCount();
    birdCount.Today();
    // => 2
```    

### 4. Verifique se houve algum dia sem pássaros visitantes

Implemente o `BirdCount.HasDayWithoutBirds()`método que retorna `true`se houve um dia em que zero pássaros visitaram o jardim; caso contrário, retorne `false`:

```c#
    int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
    var birdCount = new BirdCount(birdsPerDay);
    birdCount.HasDayWithoutBirds();
    // => true
```    

### 5. Calcule o número de pássaros visitantes para o primeiro número de dias

Implemente o `BirdCount.CountForFirstDays()`método que retorna o número de pássaros que visitaram seu jardim desde o início da semana, mas limite a contagem ao número especificado de dias a partir do início da semana.

```c#
    int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
    var birdCount = new BirdCount(birdsPerDay);
    birdCount.CountForFirstDays(4);
    // => 14
```    

### 6. Calcule o número de dias movimentados

Alguns dias são mais movimentados que outros. Um dia movimentado é aquele em que cinco ou mais pássaros visitaram seu jardim. Implemente o `BirdCount.BusyDays()`método para retornar o número de dias movimentados:

```c#
    int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
    var birdCount = new BirdCount(birdsPerDay);
    birdCount.BusyDays();
    // => 2
```    

---