using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(AlterationForm))]
    public static partial class AlterationFormExtensions
    {
        public static T SetAbilityScore<T>(this T entity, string value)
            where T : AlterationForm
        {
            entity.SetField("abilityScore", value);
            return entity;
        }

        public static T SetAlterationType<T>(this T entity, AlterationForm.Type value)
            where T : AlterationForm
        {
            entity.SetField("alterationType", value);
            return entity;
        }

        public static T SetMaximumIncrease<T>(this T entity, int value)
            where T : AlterationForm
        {
            entity.SetField("maximumIncrease", value);
            return entity;
        }

        public static T SetValueIncrease<T>(this T entity, int value)
            where T : AlterationForm
        {
            entity.SetField("valueIncrease", value);
            return entity;
        }
    }
}