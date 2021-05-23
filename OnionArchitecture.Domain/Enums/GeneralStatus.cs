using System.ComponentModel;

namespace OnionArchitecture.Domain.Enums
{
    public enum GeneralStatus
    {
        [Description("Pasif")] Passive = 0,
        [Description("Aktif")] Active = 1,
        [Description("Silindi")] Deleted = 2
    }
}