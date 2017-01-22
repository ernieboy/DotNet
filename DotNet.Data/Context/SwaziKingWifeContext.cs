using System;
using DotNet.Data.EntityFramework.Interfaces;
using DotNet.Data.EntityFramework.Models;

namespace DotNet.Data.Context
{
    public class SwaziKingWifeContext : BaseObjectWithState, IObjectWithState
    {

        public string Name { get; set; }

        public string KnownAs { get; set; }

        public DateTime DateOfBirth { get; set; }

        public virtual SwaziKingContext King { get; set; }
    }
}
