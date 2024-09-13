using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter21_Linkquery
{
    public class ProductModel
    {
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public ICollection<Product> Products { get; set; }
        public ProductModel()
        {
            Products = new HashSet<Product>();
        
        }
        public ProductModel(int modelID, string modelName) : this()
        {
            ModelId = modelID;
            ModelName = modelName;
        }
    }
}
