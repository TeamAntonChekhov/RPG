using AntonChekhovRPG.Enumerations;
using System;

namespace AntonChekhovRPG.Interfaces
{
    interface IItem : IWorldEntity
    {
        ItemType Type { get; }
    }
}
