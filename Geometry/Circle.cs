namespace LibDocsDemo.Geometry;

/// <summary>
/// Represents a 2D circle with a radius.
/// </summary>
public class Circle
{
    /// <summary>
    /// Gets or sets the radius of the circle.
    /// </summary>
    public double Radius { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Circle"/> class with a given radius.
    /// </summary>
    /// <param name="radius">The radius of the circle.</param>
    public Circle(double radius)
    {
        Radius = radius;
    }

    /// <summary>
    /// Calculates the area of the circle.
    /// </summary>
    /// <returns>The area of the circle.</returns>
    public double Area() => Math.PI * Radius * Radius;

    /// <summary>
    /// Calculates the perimeter (circumference) of the circle.
    /// </summary>
    /// <returns>The perimeter of the circle.</returns>
    public double Perimeter() => 2 * Math.PI * Radius;
}
