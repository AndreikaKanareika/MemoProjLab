using System.Threading.Tasks;

namespace Lab.SeedData
{
    public interface IDbSeeder
    {
        Task SeedData();
    }
}
