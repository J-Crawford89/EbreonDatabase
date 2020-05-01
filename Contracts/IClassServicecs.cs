using Models.ClassModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IClassServicecs
    {
        void CreateClass(ClassCreateModel classToCreate);
        ClassDetailModel GetClassDetailById(int classId);
        IEnumerable<ClassListItem> GetClasses();
        void UpdateClass(ClassUpdateModel classToUpdate);
        void DeleteClass(ClassDeleteModel classToDelete);
    }
}
