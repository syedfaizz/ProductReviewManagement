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
    }
}