using Models.RaceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRaceService
    {
        void CreateRace(RaceCreateModel raceToCreate);
        IEnumerable<RaceListItem> GetRaces();
        RaceDetailModel GetRaceDetailById(int raceId);
        void UpdateRace(RaceUpdateModel raceToUpdate);
        void DeleteRace(RaceDeleteModel raceToDelete);
    }
}
