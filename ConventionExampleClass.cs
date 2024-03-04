/**
 * Class to determine convention
 *
 *
 * DO's
 * - DO choose easily readable identifier names.
 * - DO favor readability over brevity.
 * - DO use semantically interesting names rather than language-specific keywords for type names. (For example, GetLength is a better name than GetInt)
 * - DO use a generic CLR type name, rather than a language-specific name, in the rare cases when an identifier has no semantic meaning beyond its type. (For example, a method converting to Int64 should be named ToInt64, not ToLong)
 * - DO use a common name, such as value or item, rather than repeating the type name, in the rare cases when an identifier has no semantic meaning and the type of the parameter is not important.
 * - DO use a name similar to the old API when creating new versions of an existing API.
 * - DO prefer adding a suffix rather than a prefix to indicate a new version of an existing API.
 * - CONSIDER using a brand new, but meaningful identifier, instead of adding a suffix or a prefix.
 *
 *
 * DONT'S
 * ! DO NOT use underscores, hyphens, or any other non-alphanumeric characters.
 * ! DO NOT use Hungarian notation.
 * ! AVOID using identifiers that conflict with keywords of widely used programming languages.
 * ! DO NOT use abbreviations or contractions as part of identifier names.
 * ! DO NOT use any acronyms that are not widely accepted, and even if they are, only when necessary.
 * ! DO NOT use the "Ex" (or a similar) suffix for an identifier to distinguish it from an earlier version of the same API.
 *
 * GENERAL:
 * - General ordering of same type: Most public above private(Most accessible above lesser accessible). 
 * 
 */
public class ConventionExampleClass : ConventionInformationClassBase
{
    /// <summary>
    /// Delegation and events. <see cref="SomethingChanged"/>
    /// </summary>
    public delegate void SomethingChangedEventHandler(ConventionExampleClass parent, string eventValue);

    /// <summary>
    /// Events directly after delegates
    /// </summary>
    public event SomethingChangedEventHandler? SomethingChanged;
    
    /// <summary>
    /// use singular names for enums.
    /// </summary>
    public enum Enumerations
    {
        FirstCase = 1,
        SecondCase = 2
    }
    
    /// <summary>
    /// Exception: bit field enums
    /// </summary>
    [Flags]
    public enum BitFields
    {
        None = 0,    
        First = 1, 
        FirstAndSecond = 2, 
        FirstSecondThird = 4,
        AllFourBits = 8
    }
    
    
    /// <summary>
    /// Pascal case for constants and not SCREAMING
    /// </summary>
    public const string PascalCase = "not LIKE_THIS";
    
    /// <summary>
    /// Private fields are underscored camelcase
    /// This is the only exception to use an underscore.
    /// </summary>
    private string _privateField = "Underscored camelCase";

    private readonly string _privateReadOnlyField = "Underscored camelCase";
    
    #region Properties
    
    /// <summary>
    /// Declare all member variables at the top of a class with static variables at the very top.
    /// </summary>
    public static string StaticOnTop = "";
    
    public virtual string? YouMayOverrideMe { get; set; }
    
    public override string? InheritFromBase { get; set; }

    public string PublicProperty { get; set; }
    
    protected string ProtectedProperty { get; set; }
    
    private string PrivateProperty { get; set; }

    #endregion
    
    
    /// <summary>
    /// Constructor is pascal case
    /// </summary>
    public ConventionExampleClass(string camelCaseParameter) : base(camelCaseParameter)
    {
        // Use 'var' when possible
        var localVariable = "camelCase";

        // Use string for type, not String. 
        // Use clear name NOT Hungarian(strList etc.)
        // Use collection expression []
        List<string> options = [];

        // DO NOT EVER USE THIS... Use clear naming. EVERYWHERE!
        var x = "Death penalty...";
        var usrGrp = "should be 'userGroup'";

        // Use PascalCasing for abbreviations 3 characters or more (2 chars are both uppercase)
        var htmlHelper = "HtmlHelper  | dont do HTMLHelper";
        var uiControl = "UIControl";
    }
    
}

/// <summary>
/// Use this parameter initialization if possible
/// </summary>
/// <param name="parameter"></param>
public abstract class ConventionInformationClassBase(string parameter)
{
    public abstract string? InheritFromBase { get; set; }
}
