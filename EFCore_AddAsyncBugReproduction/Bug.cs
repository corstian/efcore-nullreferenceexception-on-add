using GeoAPI.Geometries;
using System;

namespace EFCore_AddAsyncBugReproduction
{
    public class Bug
    {
        public Guid Id { get; set; }
        public DateTime Smashed { get; set; }
        public IPoint Point { get; set; }
    }
}
