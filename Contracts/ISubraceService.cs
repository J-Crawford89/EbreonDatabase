using Models.SubraceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ISubraceService
    {
        void CreateSubrace(SubraceCreateModel subraceToCreate);
        IEnumerable<SubraceListItem> GetSubracesByParentRace(int parentRaceId);
        SubraceDetailModel GetSubraceDetailById(int subraceId);
        void UpdateSubrace(SubraceUpdateModel subraceToUpdate);
        void DeleteSubrace(SubraceDeleteModel subraceToDelete);
    }
}
