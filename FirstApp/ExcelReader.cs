using ClosedXML.Excel;

namespace FirstApp
{
    class ExcelReader
    {
        public void ExtractData(List<Person> personsList)
        {

            string path = "/Users/dominiksmagacz/Downloads/challenge.xlsx";

            using (var workbook = new XLWorkbook(path))
            { 
                var ws = workbook.Worksheet(1); 
                int rowsQuantity = ws.LastRowUsed().RowNumber();
                int colQuantity = ws.LastColumnUsed().ColumnNumber();
                for(int i = 1; i < rowsQuantity; i++)
                {
                    var person = new Person();
                    person.FirstName = ws.Cell(i + 1, 1).GetString();
                    person.LastName = ws.Cell(i + 1, 2).GetString();
                    person.CompanyName = ws.Cell(i + 1, 3).GetString();
                    person.RoleInCompany = ws.Cell(i + 1, 4).GetString();
                    person.Address = ws.Cell(i + 1, 5).GetString();
                    person.Email = ws.Cell(i + 1, 6).GetString();
                    person.PhoneNumber = ws.Cell(i + 1, 7).GetString();
                    personsList.Add(person);
                }
            }
        }
    }
}