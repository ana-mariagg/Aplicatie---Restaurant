using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Restaurant.Model.BusinessLogicLayer
{
    internal class BaseBLL
    {
        //baza de date
        protected restaurantEntities context;
        public BaseBLL()
        {
            context = new restaurantEntities();
        }
    }
}
