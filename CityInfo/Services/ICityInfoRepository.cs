﻿using CityInfo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Services
{
    public interface ICityInfoRepository
    {
        IEnumerable<City> GetCities();
        City GetCity(int cityId, bool includePointsOfInterest);
        IEnumerable<PointOfInterest> GetPointOfInterestForCity(int cityId);
        PointOfInterest GetPointOfInterest(int cityId, int pointOfInterestId);
    }
}
