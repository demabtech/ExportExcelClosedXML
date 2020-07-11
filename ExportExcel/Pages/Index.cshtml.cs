using ClosedXML.Excel;
using ExportExcel.Models;
using ExportExcel.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExportExcel.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public IEnumerable<Product> _products;

        public IndexModel(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public void OnGet()
        {
            _products = ProductService.Get();
        }

        public IActionResult OnPostDownload()
        {
            string fileName = $"Products-{DateTime.Now.ToString("dd-MM-yyyy-hh-ss")}.xlsx";

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Listado de Productos");
                worksheet.Cell(1, 1).Value = "Id";
                worksheet.Cell(1, 2).Value = "Nombre";
                worksheet.Cell(1, 3).Value = "Descripción";
                worksheet.Cell(1, 4).Value = "Stock";
                worksheet.Cell(1, 5).Value = "Precio";
                worksheet.Row(1).Style.Fill.BackgroundColor = XLColor.BlueGray;
                worksheet.Row(1).Style.Font.Bold = true;

                var products = ProductService.Get();
                int row = 2;
                foreach (var product in products)
                {
                    worksheet.Cell(row, 1).Value = product.Id;
                    worksheet.Cell(row, 2).Value = product.Name;
                    worksheet.Cell(row, 3).Value = product.Description;
                    worksheet.Cell(row, 4).Value = product.Stock;
                    worksheet.Cell(row, 5).Value = product.Price.ToString("C");
                    row++;
                }

                worksheet.Columns().AdjustToContents();
                workbook.SaveAs(fileName);
            }

            var contentRoot = _webHostEnvironment.ContentRootPath;
            string path = Path.Combine(contentRoot, fileName);
            var fileStream = System.IO.File.OpenRead(path);
            return File(fileStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }
    }
}
