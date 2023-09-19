using heranca_m.classes;

public class Programa
{
    static void Main(string[] args)
    {
        Gato gato = new Gato();
        gato.barulho();
        gato.raca = "alguma ";
        gato.cordeolho = "azul";
        


        Cachorro cachorro = new Cachorro();
        cachorro.barulho();
        cachorro.raca = "vira-lata";
        cachorro.peso = 54;
        


    }
}
