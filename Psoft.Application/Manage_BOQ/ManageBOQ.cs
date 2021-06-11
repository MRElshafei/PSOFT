using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Psoft.Data;
using Psoft.Domain;

namespace Psoft.Application.Manage_BOQ
{
    public class ManageBOQ : IManageBOQ
    {
        private readonly PsoftDBContext Dbcontext;

        public ManageBOQ(PsoftDBContext Dbcontext)
        {
            this.Dbcontext = Dbcontext;
        }

        

        public void AddItem(BOQDTO newItem)
        {
            Dbcontext.Add(
              new BOQ ()
              {

                  Item =newItem.Item_Description,
                  unit =newItem.Unit,
                  unit_price=newItem.Unit_Price,
                  Quantity=newItem.Quantity

              }
              );
            Dbcontext.SaveChanges(); 
        }

        public void DeleteItem(int ItemId)
        {

            var DeletedEntity = Dbcontext.BOQS.Where(Item => Item.ID == ItemId).SingleOrDefault();

            Dbcontext.Remove(DeletedEntity);

            Dbcontext.SaveChanges();
        }

        public void EditItem(BOQDTO Item)
        {
            var _object = Dbcontext.BOQS.SingleOrDefault(F=>F.ID==Item.ID);
            if (_object != null)
            {
                _object.Item = Item.Item_Description;
                _object.unit = Item.Unit;
                _object.unit_price = Item.Unit_Price;
                _object.Quantity = Item.Quantity;
                Dbcontext.SaveChanges();
            }
        }

        public BOQDTO GetItemsById(int ItemId)
        {
            var item = Dbcontext.BOQS.FirstOrDefault(e => e.ID ==ItemId);
            return new BOQDTO()
            {
                ID=item.ID,
                Item_Description=item.Item,
                Unit=item.unit,
                Unit_Price=item.unit_price,
                Quantity=item.Quantity
                
            };
        }

        public BOQDTOList GetITemsList()
        {
            var Items = Dbcontext.BOQS.ToList();
            return new BOQDTOList ()
            {
                BOQs = Items.Select(c => new BOQDTO                
                {
                    ID=c.ID,
                    Item_Description= c.Item,
                    Unit = c.unit,
                    Unit_Price = c.unit_price,
                    Quantity=c.Quantity

                }).ToList()
                ,
                ItemsCount= Items.Count
            };
        } 
    }

}
