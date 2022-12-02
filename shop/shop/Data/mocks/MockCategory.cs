using shop.Data.interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                List<Category> mlist = new List<Category>
                {
                    new Category{categoryName="электромобили", desc="современные электромобили" },
                    new Category{categoryName="классические автомобили", desc="машины с двигателем внутреннего сгорания" }

                };
                return mlist;
            }
        }
    }
}
