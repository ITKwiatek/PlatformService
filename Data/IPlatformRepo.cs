using System.Collections.Generic;
using PlatoformService;

namespace PlatformService.Data
{
    public interface IPlatofrmRepo
    {
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform plat);
    }
}