using System.Drawing.Imaging;

namespace Guide12Examples.Models;

/// <summary>
/// Guide 12, Section 6: Reports what kind of image a PictureBox is showing.
/// A PictureBox can display bitmap, icon, JPEG, GIF, PNG, and other image types.
/// </summary>
public static class ImageDescriber
{
    public static string GetFormatName(Image image)
    {
        ImageFormat format = image.RawFormat;

        if (format.Equals(ImageFormat.Jpeg)) return "JPEG";
        if (format.Equals(ImageFormat.Gif)) return "GIF";
        if (format.Equals(ImageFormat.Png)) return "PNG";
        if (format.Equals(ImageFormat.Bmp)) return "Bitmap (BMP)";
        if (format.Equals(ImageFormat.Icon)) return "Icon (ICO)";
        if (format.Equals(ImageFormat.Tiff)) return "TIFF";

        return "Other";
    }

    public static string Describe(Image image, string filePath)
    {
        return $"File   : {Path.GetFileName(filePath)}\r\n" +
               $"Format : {GetFormatName(image)}\r\n" +
               $"Size   : {image.Width} x {image.Height} pixels\r\n" +
               $"Frames : {GetFrameCount(image)}  (animated GIFs have more than 1)";
    }

    private static int GetFrameCount(Image image)
    {
        try
        {
            return image.GetFrameCount(FrameDimension.Time);
        }
        catch (Exception)
        {
            return 1;   // Formats without time frames (JPEG, PNG, ...) throw here.
        }
    }
}
