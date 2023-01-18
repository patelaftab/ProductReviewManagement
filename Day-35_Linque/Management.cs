using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_35_Linque
{
    public class Management
    {
        public void TopRecords(List<ProductReview> reviews)
        {
            var recordData=(from productReview in reviews
                            orderby productReview.Rating descending
                            select productReview).Take(3);
            foreach(var list in recordData)
            {
                Console.WriteLine("ProductId: " + list.ProductId  + " UserId: " + list.userId + " Rating: " + list.Rating + " Review: " + list.Review + " isLike: " + list.isLike);
            }
        }
    }
}
