using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Psoft.Application.Manage_BOQ;

namespace Psoft.Pages
{
    public class DeleteItemBOQModel : PageModel
    {
       
       
    
        public BOQDTO _BOQDTO { get; set; }

        private readonly IManageBOQ IManageBOQ;

        public DeleteItemBOQModel (IManageBOQ IManageBOQ)
        {
            this.IManageBOQ = IManageBOQ;
        }
        public void OnGet(int ItemId)
        {
            _BOQDTO = IManageBOQ.GetItemsById(ItemId);
        }
        public IActionResult OnPost(int ItemId)
        {
            IManageBOQ.DeleteItem(ItemId);
            return RedirectToPage("./BOQ");
        }

     
    }
}
