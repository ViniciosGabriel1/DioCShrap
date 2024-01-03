using System;

class Program
{
    static void Main()
    {
        Celular iphone = new IPhone("iPhone 12");
        Celular samsung = new SamsungGalaxy("Galaxy S21");

        RealizarAcoesDoCelular(iphone);
        RealizarAcoesDoCelular(samsung);
    }

    static void RealizarAcoesDoCelular(Celular celular)
    {
        Console.WriteLine($"Ações para o celular {celular.Modelo}:");
        celular.Ligar();
        celular.EnviarMensagem("Olá, mundo!");
        celular.FazerChamada("123456789");
        celular.Desligar();

        // Se o celular for um smartphone, realizar ação específica
        if (celular is Smartphone)
        {
            Smartphone smartphone = (Smartphone)celular;
            smartphone.NavegarInternet();
        }

        Console.WriteLine();
    }
}

class Celular
{
    public string Modelo { get; set; } // Propriedade para o modelo do celular

    public Celular(string modelo)
    {
        Modelo = modelo;
    }

    public virtual void Ligar()
    {
        Console.WriteLine($"{Modelo} ligando...");
    }

    public virtual void Desligar()
    {
        Console.WriteLine($"{Modelo} desligando...");
    }

    public virtual void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"{Modelo} enviando mensagem: {mensagem}");
    }

    public virtual void FazerChamada(string numero)
    {
        Console.WriteLine($"{Modelo} fazendo chamada para o número: {numero}");
    }
}

class IPhone : Celular
{
    public IPhone(string modelo) : base(modelo) { }
}

class SamsungGalaxy : Celular, Smartphone
{
    public SamsungGalaxy(string modelo) : base(modelo) { }

    public void NavegarInternet()
    {
        Console.WriteLine($"{Modelo} navegando na internet...");
    }
}

interface Smartphone
{
    void NavegarInternet();
}
