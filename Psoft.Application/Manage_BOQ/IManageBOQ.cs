using System;
using System.Collections.Generic;
using System.Text;

namespace Psoft.Application.Manage_BOQ
{
    public interface IManageBOQ
    {

        void AddItem( BOQDTO newItem);
        BOQDTOList GetITemsList();
        BOQDTO GetItemsById(int ItemId);
        void DeleteItem(int ItemId);
        void EditItem(BOQDTO Item);

    }
}
