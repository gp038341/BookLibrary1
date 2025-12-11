using BookLibrary.Domain.Entities;

namespace BookLibrary.Components.Pages
{
    public partial class BookList
    {
        private List<Book>? books;

        protected override async Task OnInitializedAsync()
        {
            books = await Repository.GetAllAsync();
        }
    }
}
