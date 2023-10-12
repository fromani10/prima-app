// See https://aka.ms/new-console-template for more information
Auto miaAuto;
miaAuto = new Auto();
miaAuto.stampa();

class Auto{
    //tipo
    public enum motore
    {
        benzina,
        disel,
        elettrico
    }
    //proprietà
    public string marca;
    public string modello;
    public motore tipoMotore;
    public string colore;

    //costruttore
    public Auto()
    {
        this.marca = "Fiat";
        this.modello = "punto";
        this.tipoMotore = motore.disel;
        this.colore = "verde";
    }
    public void stampa()
    {
        //stampo le caratteristiche dell auto
        Console.WriteLine("marca: "+ this.marca);
        Console.WriteLine("modello: "+ this.modello);
        Console.WriteLine("motore: "+ this.tipoMotore);
        Console.WriteLine("colore: "+ this.colore);

    }




}



