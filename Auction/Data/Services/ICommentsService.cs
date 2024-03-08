using Auction.Models;

namespace Auction.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
