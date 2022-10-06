using System.ComponentModel;

namespace TestExcelImport.Models
{
    public class ExcelEntry
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; } = string.Empty;
        [DisplayName("Last Name")]
        public string LastName { get; set; } = string.Empty;
        [DisplayName("Age Test")]
        public string Age { get; set; } = string.Empty;
    }
}
