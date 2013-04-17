using Kelasi.DAL.Contracts;
using Kelasi.DAL.Implementations;
using Kelasi.Model;
using System.Data.Entity;

namespace Kelasi.Repository
{
    public class VideoRepository : Repository<Video>, IVideoRepository
    {
        public VideoRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }

    }

    public interface IVideoRepository : IRepository<Video>
    { }
}
