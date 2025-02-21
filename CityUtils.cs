using System.Collections.Generic;
using System.Linq;

public static class CityUtils
{
    public static List<KeyValuePair<string, int>> GetTopCities(List<string> cities, int topN)
    {
        return cities.GroupBy(city => city)
                     .OrderByDescending(group => group.Count())
                     .Take(topN)
                     .Select(group => new KeyValuePair<string, int>(group.Key, group.Count()))
                     .ToList();
    }
}