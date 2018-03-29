using System;

namespace ErmTest.Models
{
    [Flags]
    public enum DaysOfWeek
    {
        // We need each option (except None) to be valued at a power of
        // 2 to ensure multiple options can be combined efficiently
        None = 0,

        Sunday = 1,     // 2 ^ 0
        Monday = 2,     // 2 ^ 1
        Tuesday = 4,    // 2 ^ 2
        Wednesday = 8,  // 2 ^ 3
        Thursday = 16,  // 2 ^ 4
        Friday = 32,    // 2 ^ 5
        Saturday = 64   // 2 ^ 6
    }
}