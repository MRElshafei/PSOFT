using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Psoft.Application.Manage_BOQ;
using Psoft.Domain;

namespace Psoft.Pages
{
    public class AddEditBOQItemsModel : PageModel
    {
        private readonly IManageBOQ IManageBOQ;
        [BindProperty]
        public BOQDTO _BOQDTO { get; set; }
        public BOQ _BOQ { get; set; }

        public AddEditBOQItemsModel(IManageBOQ IManageBOQ)
        {
            this.IManageBOQ = IManageBOQ;
        }
        public void OnGet(int? ItemId)
        {
            if (!ItemId.HasValue)
            {
               
                _BOQDTO = new BOQDTO();
              


            }
            else
            {
                _BOQDTO = IManageBOQ.GetItemsById(ItemId.Value);
            }


        }

        public IActionResult OnPost()
        {
            if (_BOQDTO.ID > 0)
            {
                IManageBOQ.EditItem(_BOQDTO);
            }
            else
            {
                IManageBOQ.AddItem(_BOQDTO);
            }
            return RedirectToPage("./BOQ");
        }
    }
}
