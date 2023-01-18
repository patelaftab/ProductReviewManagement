using Day_35_Linque;

namespace ProductReviewManagement
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Problem");
            List<ProductReview> productReviews = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, userId = 1, Rating = 5, Review ="Good", isLike=true},
                new ProductReview() { ProductId = 4, userId = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 2, userId = 1, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 2, userId = 1, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 2, userId = 1, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 3, userId = 1, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 9, userId = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 4, userId = 1, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 5, userId = 1, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 5, userId = 1, Rating = 5, Review = "Bad", isLike = false }
            };
            //foreach(var list in productReviews)
            //{
            //    Console.WriteLine("Product Id:"+list.ProductId+  "UserId:"+list.userId + "Rating:"+ list.Rating +"Review: "+ list.Rating + "isLike: " + list.isLike);
            //}
            Management management=new Management();
            // management.TopRecords(productReviews);
            management.SelectedRecord(productReviews);
        }
    }
}