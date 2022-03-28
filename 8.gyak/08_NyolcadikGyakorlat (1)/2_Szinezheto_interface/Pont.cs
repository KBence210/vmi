namespace pontok
{
    class Pont
    {
        //- legyen x, y koordináta adata
        int x;
        int y;

        //Konstruktor: két megkapott paraméterrel inicializálja az adattagokat
        public Pont(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //Definiálja felül a T oString() metódust, amely sz tringben össze fűzve adja vissza a pont adatait.
        public override string ToString()
        {
            return $"x: {x}, y: {y}";
        }
    }
}
