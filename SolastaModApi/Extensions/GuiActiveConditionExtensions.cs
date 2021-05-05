using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class GuiActiveConditionExtensions
    {
        public static T SetActiveCondition<T>(this T entity, RulesetCondition value)
            where T : GuiActiveCondition
        {
            entity.SetField("activeCondition", value);
            return entity;
        }

        public static T SetConditionDefinition<T>(this T entity, ConditionDefinition value)
            where T : GuiActiveCondition
        {
            entity.SetField("conditionDefinition", value);
            return entity;
        }
    }
}