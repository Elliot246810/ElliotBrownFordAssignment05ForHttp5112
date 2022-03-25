using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ElliotBrownFordAssignment03ForHttp5112.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}