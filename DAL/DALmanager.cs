using Entities.buildinfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALmanager
    {
        BuildingContext bc = new BuildingContext();
        /// <summary>
        /// Method for adding buildings to the Database
        /// </summary>
        /// <param name="build"></param>
        public void add(Building build)
        {
            bc.Buildings.Add(build);
            bc.SaveChanges();
        }
        /// <summary>
        /// Method for getting all the buildings from the database through BuildingCotext
        /// </summary>
        /// <returns></returns>
        public List<Building> GetAll()
        {
            return bc.Buildings.ToList();
        }
        /// <summary>
        /// Method for deleting Building with matching int to the parameter
        /// </summary>
        /// <param name="ID"></param>
        public void DeleteListing(int ID)
        {
            Building buildtoremove = bc.Buildings.FirstOrDefault(x => x.BuildingID == ID);
            bc.Buildings.Remove(buildtoremove);
            bc.SaveChanges();
        }
        /// <summary>
        /// MEthod for getting Building with matching int to the parameter
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Building GetListing(int ID)
        {
            Building buildtoget = bc.Buildings.FirstOrDefault(x => x.BuildingID == ID);
            return buildtoget;
        }
    }
}
