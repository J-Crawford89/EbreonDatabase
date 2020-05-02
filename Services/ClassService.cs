using Contracts;
using Data;
using Data.Entities;
using Models.ClassModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ClassService : IClassServicecs
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();
        public void CreateClass(ClassCreateModel classToCreate)
        {
            Class entity = new Class()
            {
                ClassName = classToCreate.ClassName,
                ClassDescription = classToCreate.ClassDescription,
                KeyAbilities = classToCreate.KeyAbilities,
                Source = classToCreate.Source
            };
            _ctx.Classes.Add(entity);
            _ctx.SaveChanges();
        }

        public void DeleteClass(int classId)
        {
            Class entity = _ctx.Classes.Single(e => e.ClassId == classId);
            if (entity != null)
            {
                _ctx.Classes.Remove(entity);
                _ctx.SaveChanges();
            }
        }

        public ClassDetailModel GetClassDetailById(int classId)
        {
            Class classToGet = _ctx.Classes.Single(e => e.ClassId == classId);
            ClassDetailModel entity = new ClassDetailModel()
            {
                ClassId = classToGet.ClassId,
                ClassName = classToGet.ClassName,
                ClassDescription = classToGet.ClassDescription,
                KeyAbilities = classToGet.KeyAbilities,
                Source = classToGet.Source
            };
            return entity;
        }

        public IEnumerable<ClassListItem> GetClasses()
        {
            IEnumerable<ClassListItem> returnList = _ctx.Classes.Select(e => new ClassListItem()
            {
                ClassId = e.ClassId,
                ClassName = e.ClassName,
                ClassDescription = e.ClassDescription
            }).ToList();
            return returnList;
        }

        public void UpdateClass(ClassUpdateModel classToUpdate, int classId)
        {
            Class entity = _ctx.Classes.Single(e => e.ClassId == classId);
            if (entity != null)
            {
                if (classToUpdate.UpdatedClassName != null)
                    entity.ClassName = classToUpdate.UpdatedClassName;
                if (classToUpdate.UpdatedClassDescription != null)
                    entity.ClassDescription = classToUpdate.UpdatedClassDescription;
                if (classToUpdate.UpdatedKeyAbilities != null)
                    entity.KeyAbilities = classToUpdate.UpdatedKeyAbilities;
                if (classToUpdate.UpdatedSource != null)
                    entity.Source = classToUpdate.UpdatedSource;
                _ctx.SaveChanges();
            }
        }
    }
}
