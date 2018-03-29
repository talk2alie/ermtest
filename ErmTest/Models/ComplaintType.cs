using System;

namespace ErmTest.Models
{
    [Flags]
    public enum ComplaintType
    {
        // We need each option (except None) to be valued at a power of
        // 2 to ensure multiple options can be combined efficiently
        None = 0,

        Disturbance = 1,     // 2 ^ 0
        SexualMisconduct = 2,     // 2 ^ 1
        Insurbordination = 4,    // 2 ^ 2
        Rape = 8,  // 2 ^ 3
        QuidProQuo = 16,  // 2 ^ 4
    }
}