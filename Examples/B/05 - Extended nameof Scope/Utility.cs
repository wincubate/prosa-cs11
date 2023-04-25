using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

static class Utility
{
    //[return: NotNullIfNotNull(nameof(condition))]
    public static void Validate(
        bool condition,
        [CallerArgumentExpression("condition")] string? message = null)
    {
        if (!condition)
        {
            throw new InvalidOperationException(
                $"Argument failed validation: {message}"
            );
        }
    }
}
