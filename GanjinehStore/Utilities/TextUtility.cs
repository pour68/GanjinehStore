using System;

namespace GanjinehStore.Utilities
{
    public static class TextUtility
    {
       public static string CodeGenerator() => Guid.NewGuid().ToString().Replace("-", "");
    }
}
