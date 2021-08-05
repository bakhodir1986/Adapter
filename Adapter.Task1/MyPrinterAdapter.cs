namespace Adapter.Task1
{
    public class MyPrinterAdapter : IMyPrinter
    {
        private readonly Printer _printer;

        public MyPrinterAdapter(Printer printer)
        {
            _printer = printer;
        }

        public void Print<T>(IElements<T> elements)
        {
            var containerFromElements = new ContainerFromElements<T>(elements);

            _printer.Print(containerFromElements);
        }
    }
}
