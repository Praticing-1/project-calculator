namespace StoreCalculatorResult.Entities
{
    public class Data
    {
        private int Number;
        private DateTime Date;

        public Data(int number)
        {
            Number = number;
            Date = DateTime.Now;
        }
    }
}