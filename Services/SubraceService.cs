using Contracts;
using Data;
using Data.Entities;
using Models.SubraceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SubraceService : ISubraceService
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();
        public void CreateSubrace(SubraceCreateModel subraceToCreate)
        {
            Subrace entity = new Subrace()
            {
                SubraceName = subraceToCreate.SubraceName,
                SubraceDescription = subraceToCreate.SubraceDescription,
                AbilityScoreIncrease = subraceToCreate.AbilityScoreIncrease,
                Source = subraceToCreate.SubraceSource,
                Origin = subraceToCreate.SubraceOrigin
            };
            _ctx.Subraces.Add(entity);
            _ctx.SaveChanges();
        }

        public void DeleteSubrace(SubraceDeleteModel subraceToDelete)
        {
            Subrace entity = _ctx.Subraces.Single(e => e.SubraceId == subraceToDelete.SubraceId);
            _ctx.Subraces.Remove(entity);
        }

        public SubraceDetailModel GetSubraceDetailById(int subraceId)
        {
            Subrace subrace = _ctx.Subraces.Single(e => e.SubraceId == subraceId);
            SubraceDetailModel entity = new SubraceDetailModel()
            {
                SubraceId = subrace.SubraceId,
                SubraceName = subrace.SubraceName,
                SubraceDescription = subrace.SubraceDescription,
                AbilityScoreIncrease = subrace.AbilityScoreIncrease,
                Source = subrace.Source,
                Origin = subrace.Origin,
                ParentRaceName = subrace.ParentRace.RaceName
            };
            return entity;
        }

        public IEnumerable<SubraceListItem> GetSubracesByParentRace(int parentRaceId)
        {
            IEnumerable<SubraceListItem> returnList = _ctx.Subraces.Where(e => e.RaceId == parentRaceId).Select(i => new SubraceListItem()
            {
                SubraceId = i.SubraceId,
                SubraceName = i.SubraceName,
                SubraceDescription = i.SubraceDescription
            }).ToList();
            return returnList;
        }

        public void UpdateSubrace(SubraceUpdateModel subraceToUpdate)
        {
            Subrace entity = _ctx.Subraces.Single(e => e.SubraceId == subraceToUpdate.SubraceId);
            if (entity != null)
            {
                if (subraceToUpdate.UpdatedSubraceName != null)
                    entity.SubraceName = subraceToUpdate.UpdatedSubraceName;
                if (subraceToUpdate.UpdatedSubraceDescription != null)
                    entity.SubraceDescription = subraceToUpdate.UpdatedSubraceDescription;
                if (subraceToUpdate.UpdatedAbilityScoreIncrease != null)
                    entity.AbilityScoreIncrease = subraceToUpdate.UpdatedAbilityScoreIncrease;
                if (subraceToUpdate.UpdatedSource != null)
                    entity.Source = subraceToUpdate.UpdatedSource;
                if (subraceToUpdate.UpdatedOrigin != null)
                    entity.Origin = subraceToUpdate.UpdatedOrigin;
                if (subraceToUpdate.UpdatedRaceId != null)
                    entity.RaceId = (int)subraceToUpdate.UpdatedRaceId;
                _ctx.SaveChanges();
            }
        }
    }
}
