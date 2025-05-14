
namespace LibDocsDemo.Geometry;

/// <summary>
/// Represents a 2D rectangle with width and height.
/// </summary>
public class Rectangle
{
    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>
    public double Width { get; set; }

    /// <summary>
    /// Gets or sets the height of the rectangle.
    /// </summary>
    public double Height { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Rectangle"/> class with given width and height.
    /// </summary>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    /// <summary>
    /// Calculates the area of the rectangle.
    /// </summary>
    /// <returns>The area of the rectangle.</returns>
    public double Area() => Width * Height;

    /// <summary>
    /// Calculates the perimeter of the rectangle.
    /// </summary>
    /// <returns>The perimeter of the rectangle.</returns>
    public double Perimeter() => 2 * (Width + Height);
}
