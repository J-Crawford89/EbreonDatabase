using Contracts;
using Data;
using Data.Entities;
using Models.SubclassModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SubclassService : ISubclassService
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();

        public void CreateSubclass(SubclassCreateModel subclassToCreate)
        {
            Subclass entity = new Subclass()
            {
                SubclassName = subclassToCreate.SubclassName,
                SubclassDescription = subclassToCreate.SubclassDescription,
                Source = subclassToCreate.Source,
                ClassId = subclassToCreate.ClassId
            };
            _ctx.Subclasses.Add(entity);
            _ctx.SaveChanges();
        }

        public void DeleteSubclass(SubclassDeleteModel subclassToDelete)
        {
            Subclass entity = _ctx.Subclasses.Single(e => e.SubclassId == subclassToDelete.SubclassId);
            _ctx.Subclasses.Remove(entity);
            _ctx.SaveChanges();
        }

        public SubclassDetailModel GetSubclassDetailById(int subclassId)
        {
            Subclass subclass = _ctx.Subclasses.Single(e => e.SubclassId == subclassId);
            SubclassDetailModel entity = new SubclassDetailModel()
            {
                SubclassId = subclass.SubclassId,
                SubclassName = subclass.SubclassName,
                SubclassDescription = subclass.SubclassDescription,
                Source = subclass.Source,
                ParentClassName = subclass.ParentClass.ClassName
            };
            return entity;
        }

        public IEnumerable<SubclassListItem> GetSubclassesByParentClass(int classId)
        {
            IEnumerable<SubclassListItem> returnList = _ctx.Subclasses.Where(i => i.ClassId == classId).Select(e => new SubclassListItem()
            {
                SubclassId = e.SubclassId,
                SubclassName = e.SubclassName,
                SubclassDescription = e.SubclassDescription
            }).ToList();
            return returnList;
        }

        public void UpdateSubclass(SubclassUpdateModel subclassToUpdate)
        {
            Subclass entity = _ctx.Subclasses.Single(e => e.SubclassId == subclassToUpdate.SubclassId);
            if (entity != null)
            {
                if (subclassToUpdate.UpdatedSubclassName != null)
                    entity.SubclassName = subclassToUpdate.UpdatedSubclassName;
                if (subclassToUpdate.UpdatedSubclassDescription != null)
                    entity.SubclassDescription = subclassToUpdate.UpdatedSubclassDescription;
                if (subclassToUpdate.UpdatedSource != null)
                    entity.Source = subclassToUpdate.UpdatedSource;
                if (subclassToUpdate.UpdatedClassId != null)
                    entity.ClassId = (int)subclassToUpdate.UpdatedClassId;
                _ctx.SaveChanges();
            }
        }
    }
}
