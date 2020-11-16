using System.Threading.Tasks;
using Post.Domain;

namespace Post.Application.Repositories
{
    public interface IExampleRepository
    {
        Task Add(Template airline);
    }
}