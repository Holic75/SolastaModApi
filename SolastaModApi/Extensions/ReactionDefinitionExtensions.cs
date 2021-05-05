using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class ReactionDefinitionExtensions
    {
        public static T SetReactDescription<T>(this T entity, string value)
            where T : ReactionDefinition
        {
            entity.SetField("reactDescription", value);
            return entity;
        }

        public static T SetReactTitle<T>(this T entity, string value)
            where T : ReactionDefinition
        {
            entity.SetField("reactTitle", value);
            return entity;
        }
    }
}