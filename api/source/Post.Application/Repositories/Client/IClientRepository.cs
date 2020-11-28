namespace Post.Application.Repositories.Client
{
    using System.Threading.Tasks;
    using Post.Domain.Client;
    public interface IClientRepository 
    {
        Task Register(Client client);
    }
}