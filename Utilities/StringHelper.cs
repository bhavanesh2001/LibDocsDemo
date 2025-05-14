

namespace LibDocsDemo.Utilities;

/// <summary>
/// Provides helper methods for common string operations.
/// </summary>
public static class StringHelper
{
    /// <summary>
    /// Determines whether the specified string is null or an empty string.
    /// </summary>
    public static bool IsNullOrEmpty(string? value) => string.IsNullOrEmpty(value);

    /// <summary>
    /// Reverses the characters in a string.
    /// </summary>
    /// <param name="value">The string to reverse.</param>
    /// <returns>The reversed string.</returns>
    public static string Reverse(string value) => new(value.Reverse().ToArray());
}