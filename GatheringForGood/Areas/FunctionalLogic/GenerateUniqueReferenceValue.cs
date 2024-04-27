using System;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class GenerateUniqueReferenceValue
    {
        public string GetGUIDValue()
        {
            string generatedValue = Guid.NewGuid().ToString();
            return generatedValue;
        }

    }
}
