using System;
using BakeryShoppingCart.MyClasses;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main()
        {
            CommentDTOS comment = new CommentDTOS();
            comment.TheComment = "This is a comment";

            Console.WriteLine("The value of my first property is: " + comment.TheComment);
        }
    }
}