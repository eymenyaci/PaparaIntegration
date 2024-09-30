using System.Text.Json;
using PaparaIntegration.Interfaces;
using PaparaIntegration.Models.Endpoints;
using PaparaIntegration.Models.Response.CorporateCard;
using OfficeOpenXml; 
using System.IO;

namespace PaparaIntegration.Services
{
    public class CorporateCardService : ICorporateCardService
    {
        private readonly IHttpRequestService _requestService;

        public CorporateCardService(IHttpRequestService httpRequestService)
        {
            _requestService = httpRequestService;
        }

        public async Task<bool> GetCardDetail()
        {
            // Dosya yolu
            string filePath = "/Users/eymenyaci/Desktop/PaparaIntegration/CardIds.txt";
            string excelPath = "/Users/eymenyaci/Desktop/PaparaIntegration/CardNumber.xlsx"; // Excel dosyası yolu

            try
            {
                List<string> lines = new List<string>(File.ReadAllLines(filePath));

                Console.WriteLine("Dosya içeriği:");

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Card Details");

                    worksheet.Cells[1, 1].Value = "CardId";
                    worksheet.Cells[1, 2].Value = "CardNumber";
                    worksheet.Cells[1, 3].Value = "ExpiryYear";
                    worksheet.Cells[1, 4].Value = "ExpiryMonth";
                    worksheet.Cells[1, 5].Value = "Cvv";

                    int row = 2; 
                    int count =0
                    foreach (string line in lines)
                    {
                        count++;
                        var response = await _requestService.SendGetRequestAsync<ApiResponse>("https://merchant-api.papara.com/corporatepaparacards/" + line);

                        if (response?.data?.virtualCardInfo != null)
                        {
                            string notReplaceCardNumber = response.data.virtualCardInfo.cardNumber;
                            string cardNumber = notReplaceCardNumber.Replace(" ", "");
                            Console.WriteLine(count + ". " + cardNumber +" numaralı kart excele eklendi.");
                            worksheet.Cells[row, 1].Value = response.data.cardId;
                            worksheet.Cells[row, 2].Value = cardNumber;
                            worksheet.Cells[row, 3].Value = response.data.virtualCardInfo.expiryYear;
                            worksheet.Cells[row, 4].Value = response.data.virtualCardInfo.expiryMonth;
                            worksheet.Cells[row, 5].Value = response.data.virtualCardInfo.cvv;

                            row++; 
                        }
                    }

                    FileInfo excelFile = new FileInfo(excelPath);
                    package.SaveAs(excelFile);
                    Console.WriteLine("Veriler Excel'e başarıyla kaydedildi.");
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Dosya bulunamadı: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Bir hata oluştu: " + e.Message);
            }

            return true;
        }
    }
}
