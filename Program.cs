// See https://aka.ms/new-console-template for more information
Auto miaAuto;
miaAuto = new Auto();
miaAuto.stampaDescrizione();

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
    public void stampaDescrizione()
    {
        //stampo le caratteristiche dell auto
       Console.WriteLine(descrizione());



    }

    public string descrizione()
    {
        string result;

        result = $"marca: {this.marca}";//modo diverso per scrivere
        result +=" modello: " + this.modello;
        result+=" motore: " + this.tipoMotore;
        result+=" colore: " + this.colore;
        return result;

    }
}



