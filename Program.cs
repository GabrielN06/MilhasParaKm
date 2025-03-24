double distancia;

Console.Write("Entre com a medida (em milhas): ");
distancia = Convert.ToDouble(Console.ReadLine());

distancia *= 1609;

Console.WriteLine($"Em Kms seria: {distancia}");
