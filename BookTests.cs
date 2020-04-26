using System;
using Xunit;

namespace Fisher.Bookstore.Tests
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<BookAuthor> BookAuthor { get; set; }
        public double Price { get; set; }

        public void ApplyMemberDiscount()
        {
            Price = Price * .9;
        }
    }
    public class BookTests
    {
        [Fact]
        public void AddBookPrice()
        {
            var book = new Book()
            {
                Id = 1,
                Title = "My Test Book",
                Price = 9.99
            };

            book.Price = 7.99;
            Assert.Equal(7.99, book.Price);
        }
        
        [Fact]
        public void TestMemberDiscount()
        {
            var book = new Book()
            {
                Id = 1,
                Title = "My Test Book",
                Price = 9.99
            };

            object p = book.ApplyMemberDiscount();

            var discountPrice = 9.99* .9;
            Assert.Equal(discountPrice, AddBookPrice);
        }
    }
}

