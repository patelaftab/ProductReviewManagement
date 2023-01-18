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
        public void SelectedRecord(List<ProductReview> reviews) 
        {
            var recordData = from ProductReview in reviews
                             where (ProductReview.ProductId == 1 && ProductReview.Rating > 3) ||
                             (ProductReview.ProductId == 4 && ProductReview.Rating > 3) ||
                             (ProductReview.ProductId == 9 && ProductReview.Rating > 3)
                             select ProductReview;
                            
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId: " + list.ProductId + " UserId: " + list.userId + " Rating: " + list.Rating + " Review: " + list.Review + " isLike: " + list.isLike);
            }
        }
        public void RetrivingCountOfRecors(List<ProductReview> reviews)
        {
            var records=reviews.GroupBy(x=> x.ProductId).Select(x => new {ProductId =x.Key, count=x.Count()});
            foreach (var record in records) 
            {
                Console.WriteLine(record.ProductId + "=" + record.count);
            }
        }
    }
}
