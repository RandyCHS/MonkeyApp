namespace MyMonkeyApp;

/// <summary>
/// Represents a monkey species with details from the MonkeyMCP server.
/// </summary>
public class Monkey
{
    /// <summary>
    /// Gets or sets the name of the monkey.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the location where the monkey is found.
    /// </summary>
    public string Location { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the estimated population of the monkey.
    /// </summary>
    public int Population { get; set; }

    /// <summary>
    /// Gets or sets the details or description of the monkey.
    /// </summary>
    public string Details { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the image URL for the monkey.
    /// </summary>
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the latitude of the monkey's location.
    /// </summary>
    public double Latitude { get; set; }

    /// <summary>
    /// Gets or sets the longitude of the monkey's location.
    /// </summary>
    public double Longitude { get; set; }
}
