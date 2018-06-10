namespace Controllers
{
    class Program
    {
        static void Main(string[] args)
        {
            Models Model= new Model();
            Views ViewInput = new Views();
            Views ViewIntfr = new Views();

            Controllers controller = new Controllers(Model,ViewInput,ViewIntfr);



           
        }
    }
}
