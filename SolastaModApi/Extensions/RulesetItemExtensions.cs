using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetItem))]
    public static partial class RulesetItemExtensions
    {
        public static T SetGains<T>(this T entity, int[] value)
            where T : RulesetItem
        {
            entity.SetField("gains", value);
            return entity;
        }

        public static T SetItemDurationRefreshed<T>(this T entity, RulesetItem.ItemDurationRefreshedHandler value)
            where T : RulesetItem
        {
            entity.SetField("<ItemDurationRefreshed>k__BackingField", value);
            return entity;
        }

        public static T SetItemPropertyRemoved<T>(this T entity, RulesetItem.ItemPropertyRemovedHandler value)
            where T : RulesetItem
        {
            entity.SetField("<ItemPropertyRemoved>k__BackingField", value);
            return entity;
        }
    }
}