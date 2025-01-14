using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetGadget))]
    public static partial class RulesetGadgetExtensions
    {
        public static T SetGadgetDefinition<T>(this T entity, GadgetDefinition value)
            where T : RulesetGadget
        {
            entity.SetField("gadgetDefinition", value);
            return entity;
        }
    }
}