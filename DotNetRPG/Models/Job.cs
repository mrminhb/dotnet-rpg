using System.Text.Json.Serialization;

namespace DotNetRPG.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Job
{
    Warrior = 1,
    Monk = 2,
    BlackMage = 3,
    Bard = 4,
    WhiteMage = 5
}