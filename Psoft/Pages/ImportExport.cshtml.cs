using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Psoft.Application.Manage_BOQ;
using Psoft.Domain;

namespace Psoft.Pages
{
    public class ImportExportModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IWebHostEnvironment _hostingEnvironment;
        private readonly IManageBOQ IManageBOQ;

        [BindProperty]
        public List<double> Total { get; set; }

        public BOQDTO _BOQDTO { get; set; }
        public List<BOQ> _BOQ { get; set; } = new List<BOQ>();
        public BOQDTOList _BOQDTOList { get; set; }
        [BindProperty]
        public IFormFile formFile { get; set; }
        public ImportExportModel(ILogger<IndexModel> logger, IWebHostEnvironment hostingEnvironment, IManageBOQ IManageBOQ)

        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
            this.IManageBOQ = IManageBOQ;
        }


        public async Task<ActionResult> OnPostImportExcelAsync()

        {

            _BOQDTOList = Import(formFile);

            if (_BOQDTOList != null)
            {
                foreach (var item in _BOQDTOList.BOQs)
                {
                    IManageBOQ.AddItem(item);
                }


            }
            return Page();

        }

        public BOQDTOList Import(IFormFile file)
        {

            var stdts = new BOQDTOList();


            string folderName = "UploadExcel";
            string webRootPath = _hostingEnvironment.WebRootPath;
            string newPath = Path.Combine(webRootPath, folderName);

            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }
            if (file.Length > 0)
            {
                string sFileExtension = Path.GetExtension(file.FileName).ToLower();
                ISheet sheet;
                string fullPath = Path.Combine(newPath, file.FileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                    stream.Position = 0;
                    if (sFileExtension == ".xls")
                    {
                        HSSFWorkbook hssfwb = new HSSFWorkbook(stream); //This will read the Excel 97-2000 formats  
                        sheet = hssfwb.GetSheetAt(0); //get first sheet from workbook  
                    }
                    else
                    {
                        XSSFWorkbook hssfwb = new XSSFWorkbook(stream); //This will read 2007 Excel format  
                        sheet = hssfwb.GetSheetAt(0); //get first sheet from workbook   
                    }




                    IRow headerRow = sheet.GetRow(0); //Get Header Row
                    int cellCount = headerRow.LastCellNum;

                    stdts.BOQs = new List<BOQDTO>();


                    for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++) //Read Excel File
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue;
                        if (row.Cells.All(d => d.CellType == CellType.Blank)) continue;


                        var BO = new BOQDTO
                        {

                            Item_Description = row.GetCell(0).ToString(),
                            Unit = row.GetCell(1).ToString(),
                            Unit_Price = row.GetCell(2).ToString(),
                            Quantity = row.GetCell(3).NumericCellValue
                        };

                        Total.Add(row.GetCell(4).NumericCellValue);


                        stdts.BOQs.Add(BO);

                    }
                }
            }
            return stdts;
        }
        public void OnGet()
        {

            _BOQDTOList = IManageBOQ.GetITemsList();
        }
    }
}
