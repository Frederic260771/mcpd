
namespace exercice1.classes
{
    internal class Chaise
    {
        private int _nombredepieds;
        private string _materiaux;
        private string _couleur;

        public int NombreDePieds { get => _nombredepieds; set => _nombredepieds = value; }
        public string Materiaux { get => _materiaux; set => _materiaux = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }

        public Chaise () { }
        public Chaise (int nbPied, string materiel, string couleur)
        {
            NombreDePieds = nbPied; 
            Materiaux = materiel; 
            Couleur = couleur;
        }


        public override string ToString()
        {
            
            return $"chaise : {NombreDePieds},  {Materiaux},  {Couleur}";
        }
    }
}
