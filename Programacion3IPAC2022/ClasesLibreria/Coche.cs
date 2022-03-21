namespace ClasesLibreria
{
    public class Coche
    {
        //Atributos
        private int id;
        //private string marca;
        //private string modelo;
        //private string precio;
        //private string km;

        //Propiedades
        public int Id { get => id; set => id = value; }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string precio { get; set; }  
        public int km { get; set; }

        //constructores
        public Coche()
        {
        
        }
        public Coche(int id, string modelo)
        {
            Id= id;
            Modelo= modelo;
        }

        //metodos 
        public string DevolverDaos()
        {
            return "Id: " + Id + " Marca "+ Marca +" MOdelo "+ Modelo ;

        }

    }
}