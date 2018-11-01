using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities.buildinfiles;

namespace Uppgift3BLL
{
    /// <summary>
    /// Controller methods that calls the methods in DAL
    /// </summary>
    public class Controller
    {
        DALmanager dm = new DAL.DALmanager();
      
        public void AddListing(Building build)
        {
            dm.add(build);
        }

        public List<Building> GetAll()
        {
            return dm.GetAll();
        }

        public void Delete(int ID)
        {
            dm.DeleteListing(ID);
        }

        public Building GetListing(int ID)
        {
            return dm.GetListing(ID);
        }
    }
}
