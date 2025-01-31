using SolastaModApi.Infrastructure;
using UnityEngine;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GadgetBlueprint))]
    public static partial class GadgetBlueprintExtensions
    {
        public static T SetCustomizableDimensions<T>(this T entity, bool value)
            where T : GadgetBlueprint
        {
            entity.SetField("customizableDimensions", value);
            return entity;
        }

        public static T SetMaxCustomizableDimensions<T>(this T entity, Vector2Int value)
            where T : GadgetBlueprint
        {
            entity.SetField("maxCustomizableDimensions", value);
            return entity;
        }

        public static T SetMinCustomizableDimensions<T>(this T entity, Vector2Int value)
            where T : GadgetBlueprint
        {
            entity.SetField("minCustomizableDimensions", value);
            return entity;
        }
    }
}