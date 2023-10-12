// See https://aka.ms/new-console-template for more information
Auto miaAuto;

miaAuto = new Auto("fiat", "multipla", Auto.motore.benzina, "grigio");
miaAuto.stampaDescrizione();

class Auto
{
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
    public int carburante;
    public bool accesa;
    


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

        result = $"marca: {this.marca}" + "\n";//modo diverso per scrivere
        result += " modello: " + this.modello + "\n";
        result += " motore: " + this.tipoMotore + "\n";
        result += " colore: " + this.colore+"\n";
        
       
        return result;

    }
    public Auto(string marca, string modello, motore tipoMotore, string colore)
    {
        this.marca = marca;
        this.modello = modello;
        this.tipoMotore = tipoMotore;
        this.colore = colore;
        //this.accesa = accesa;
        //this.carburante = carburante;
    }
   public void accendi()
    {
        //verifico il livello del carburante 
        if (this.carburante > 0)
        {
            //se maggiore di zero si accende
            this.accesa= true;
        }
        else
        {
            //se minore o uguale di zero spenta
            this.accesa = false;
        }

    }
    public void spegni()
    {
        this.accesa = false;
    }


}




