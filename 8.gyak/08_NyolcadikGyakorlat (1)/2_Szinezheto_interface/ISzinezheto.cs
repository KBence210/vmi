namespace szinezheto
{
    //- legyen tulajdonsága beállítani/lekérdezni egy szín értékét
    //- legyen egy csak olvasható tulajdonsága, amely visszaadja az alpértelmezett színt
    interface ISzinezheto
    {
        pontok.SzinesPont.Szinek Szin { get; set; }
        pontok.SzinesPont.Szinek AlapertelmezettSzin { get; }
    }

}
