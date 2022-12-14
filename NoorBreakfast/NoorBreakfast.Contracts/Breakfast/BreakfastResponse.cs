using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoorBreakfast.Contracts.Breakfast
{
    public record BreakfastResponse
    {
        Guid Id;
        string Name;
        string Description;
        DateTime StartDateTime;
        DateTime EndDateTime;
        List<string> Savory;
        List<string> Sweet;
    }
}
