using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using DotNet.Data.EntityFramework.Interfaces;
using DotNet.Data.EntityFramework.Models;

namespace DotNet.Data.Context
{
    public class SwaziKingContext :  BaseObjectWithState, IObjectWithState
    {
        public string Name { get; set; }

        public string KnownAs { get; set; } 

        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<SwaziKingWifeContext> Wives { get; set; }        

    }
}
