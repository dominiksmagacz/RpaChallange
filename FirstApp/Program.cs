namespace RpaChallange
{
    class RpaChallange
    {
        static void Main(string[] args)
        {
            var personsList = new List<Person>();
            var excel = new ExcelReader();
            excel.ExtractData(personsList);
            var webWorker = new WebsiteWorker(personsList);
        }
    }
}