using System.Threading.Tasks;
using MotherLoadDB.Data;
using MotherLoadDB.Models;
using ClosedXML;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2019.Excel.RichData;

namespace DBAdminTools;

class Program
{
    static async Task Main(string[] args)
    {
        var context = new AppDbContext();
        var dbService = new DbService(context);
        while (true)
        {
            Console.Clear();
            System.Console.WriteLine("--- DB Admin Tools ---");
            System.Console.WriteLine("1. Upload CSV");
            System.Console.WriteLine("2. Create a company");
            System.Console.WriteLine("3. View all companies");
            System.Console.WriteLine("4. Search company");
            System.Console.WriteLine("5. Delete company");
            System.Console.WriteLine("6. Export CSV");
            System.Console.WriteLine("7. Database statistics");
            System.Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    await UploadCSV(dbService);
                    break;

                case "2":
                    await CreateCompany(dbService);
                    break;

                case "3":
                    await ViewAllCompanies(dbService);
                    break;

                case "4":
                    await SearchCompany(dbService);
                    break;

                case "5":
                    await DeleteCompany(dbService);
                    break;

                case "6":
                    //ExportCSV.Run();
                    break;
                case "7":
                    await ShowStatistics(dbService);
                    break;
                case "0":
                    return;
                default:
                    System.Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    static async Task UploadCSV(DbService dbService)
    {
        System.Console.Write("Enter File Path: ");
        var filePath = Console.ReadLine();

        if (!File.Exists(filePath))
        {
            System.Console.WriteLine("File does not exist.");
            return;
        }

        var workbook = new XLWorkbook(filePath);
        var worksheet = workbook.Worksheet(1);
        var rows = worksheet.RangeUsed().RowsUsed().Skip(1);
        int count = 0;

        foreach (var row in rows)
        {
            var orgNumber = row.Cell(5).GetString();

            var company = new Company
            {
                Name = row.Cell(1).GetString(),
                City = row.Cell(2).GetString(),
                Industry = row.Cell(3).GetString(),
                OrgNumber = orgNumber,
                Website = row.Cell(8).GetString()

            };

            await dbService.CreateCompany(company);
            count++;
            if (count % 100 == 0) System.Console.WriteLine($"Processed {count} companies.");

        }
    }
    static async Task CreateCompany(DbService dbService)
    {
        System.Console.WriteLine("Create a company by filling out the following fields:");
        System.Console.Write("Name of the company: ");
        var name = Console.ReadLine();

        System.Console.WriteLine("OrgNumber: ");
        var number = Console.ReadLine();

        var company = new Company()
        {
            Name = name,
            OrgNumber = number
        };


        await dbService.CreateCompany(company);
    }





    static async Task ViewAllCompanies(DbService dbService)
    {
        var companies = await dbService.GetCompanies();
        foreach (var company in companies)
        {
            Console.WriteLine($"{company.Id} | {company.Name} | {company.OrgNumber}");

        }

    }




    static async Task SearchCompany(DbService dbService)
    {
        System.Console.WriteLine("Enter company id: ");

        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var company = await dbService.GetCompany(id);

            if (company != null)
            {
                Console.WriteLine($"{company.Name} | {company.OrgNumber}");
            }
            else
            {
                Console.WriteLine("Company not found");
            }
        }

    }


    static async Task DeleteCompany(DbService dbService)
    {
        System.Console.WriteLine("Enter company id to remove: ");

        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var success = await dbService.DeleteCompany(id);
            System.Console.WriteLine(success ? "Company removed" : "Company not found");
        }
    }

    static async Task ShowStatistics(DbService dbService)
    {
        var companies = await dbService.GetCompanies();
        System.Console.WriteLine($"Number of companies: {companies.Count}");
        System.Console.WriteLine($"Cities {companies.Select(c => c.City).Distinct().Count()}");
    }


}





