using Contracts;
using Data;
using Data.Entities;
using Models.RaceModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RaceService : IRaceService
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();
        public void CreateRace(RaceCreateModel raceToCreate)
        {
            Race entity = new Race()
            {
                RaceName = raceToCreate.RaceName,
                RaceDescription = raceToCreate.RaceDescription,
                HasSubraces = raceToCreate.HasSubraces,
                AbilityScoreIncrease = raceToCreate.AbilityScoreIncrease,
                Speed = raceToCreate.Speed,
                Language = raceToCreate.Language,
                HasDarkvision = raceToCreate.HasDarkvision,
                Source = raceToCreate.Source,
                Origin = raceToCreate.Origin
            };
            _ctx.Races.Add(entity);
            _ctx.SaveChanges();
        }

        public void DeleteRace(int raceId)
        {
            Race entity = _ctx.Races.Single(e => e.RaceId == raceId);
            _ctx.Races.Remove(entity);
            _ctx.SaveChanges();
        }

        public RaceDetailModel GetRaceDetailById(int raceId)
        {
            Race race = _ctx.Races.Single(e => e.RaceId == raceId);
            RaceDetailModel entity = new RaceDetailModel()
            {
                RaceId = race.RaceId,
                RaceName = race.RaceName,
                RaceDescription = race.RaceDescription,
                HasSubraces = race.HasSubraces,
                Speed = race.Speed,
                AbilityScoreIncrease = race.AbilityScoreIncrease,
                Language = race.Language,
                HasDarkvision = race.HasDarkvision,
                Source = race.Source,
                Origin = race.Origin
            };
            return entity;
        }

        public IEnumerable<RaceListItem> GetRaces()
        {
            IEnumerable<RaceListItem> returnList = _ctx.Races.Select(e => new RaceListItem()
            {
                RaceId = e.RaceId,
                RaceName = e.RaceName,
                RaceDescription = e.RaceDescription
            }).ToList();
            return returnList;
        }

        public void UpdateRace(RaceUpdateModel raceToUpdate, int raceId)
        {
            Race entity = _ctx.Races.Single(e => e.RaceId == raceId);
            if (entity != null)
            {
                if (raceToUpdate.UpdatedRaceName != null)
                    entity.RaceName = raceToUpdate.UpdatedRaceName;
                if (raceToUpdate.UpdatedRaceDescription != null)
                    entity.RaceDescription = raceToUpdate.UpdatedRaceDescription;
                if (raceToUpdate.UpdatedHasSubraces != null)
                    entity.HasSubraces = (bool)raceToUpdate.UpdatedHasSubraces;
                if (raceToUpdate.UpdatedSpeed != null)
                    entity.Speed = raceToUpdate.UpdatedSpeed;
                if (raceToUpdate.UpdatedLanguage != null)
                    entity.Language = raceToUpdate.UpdatedLanguage;
                if (raceToUpdate.UpdatedAbilityScoreIncrease != null)
                    entity.AbilityScoreIncrease = raceToUpdate.UpdatedAbilityScoreIncrease;
                if (raceToUpdate.UpdatedHasDarkvision != null)
                    entity.HasDarkvision = (bool)raceToUpdate.UpdatedHasDarkvision;
                if (raceToUpdate.UpdatedSource != null)
                    entity.Source = raceToUpdate.UpdatedSource;
                if (raceToUpdate.UpdatedOrigin != null)
                    entity.Origin = raceToUpdate.UpdatedOrigin;
                _ctx.SaveChanges();
            }
        }
    }
}
