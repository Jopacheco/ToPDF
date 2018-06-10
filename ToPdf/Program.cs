namespace Controllers
{
    class Program
    {
        static void Main(string[] args)
        {
            Models Model= new Models();
            Views ViewInput = new Views();
            Views ViewIntfr = new Views();

            Controllers controller = new Controllers(Model,ViewInput,ViewIntfr);



           
        }
    }
}
