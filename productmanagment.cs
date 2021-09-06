using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReviewManagement
{
    public class ProductManagement
    {
        public static void TopRecords(List<ProductReview> reviews)
        {
            var record = (from productReviews in reviews
                          orderby productReviews.Rating descending
                          select productReviews).Take(3);
            foreach (var list in record)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " +
                        "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);
            }
        }
        public static void SelectedRecord(List<ProductReview> review)
        {
            var record = from productReviews in review
                         where (productReviews.ProductID == 1 && productReviews.Rating > 3) || (productReviews.ProductID == 4 && productReviews.Rating > 3) ||
                         (productReviews.ProductID == 9 && productReviews.Rating > 3)
                         select productReviews;
            foreach (var list in record)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " +
                        "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);
            }
        }
    }
}