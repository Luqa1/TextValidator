using System.Collections.Generic;

namespace TextValidator.Model
{
    public enum ConditionType
    {
        EQUALS,
        STARTS,
        ENDS,
        CONTAINS
    }

    static class ConditionTypeHelper
    {
        public static IEnumerable<string> GetAllConditions()
        {
            yield return ConditionType.EQUALS.ToString();
            yield return ConditionType.STARTS.ToString();
            yield return ConditionType.ENDS.ToString();
            yield return ConditionType.CONTAINS.ToString();
        }
    }
}
