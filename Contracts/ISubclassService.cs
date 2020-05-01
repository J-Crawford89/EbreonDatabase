using Models.SubclassModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ISubclassService
    {
        void CreateSubclass(SubclassCreateModel subclassToCreate);
        SubclassDetailModel GetSubclassDetailById(int subclassId);
        IEnumerable<SubclassListItem> GetSubclassesByParentClass(int classId);
        void UpdateSubclass(SubclassUpdateModel subclassToUpdate);
        void DeleteSubclass(SubclassDeleteModel subclassToDelete);
    }
}
