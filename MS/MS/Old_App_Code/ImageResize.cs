using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ImageResize
/// </summary>
namespace multishopbd.Resize
{
    public class ImageResize
    {
        public ImageResize()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public Bitmap GetScaledPicture(Bitmap source, int maxWidth, int maxHeight)
        {
            int width, height;
            float aspectRatio = (float)source.Width / (float)source.Height;

            if ((maxHeight > 0) && (maxWidth > 0))
            {
                if ((source.Width < maxWidth) && (source.Height < maxHeight))
                {
                    //Return unchanged image
                    return source;
                }
                //else if (aspectRatio > 1)
                //{
                //    // Calculated width and height,
                //    // and recalcuate if the height exceeds maxHeight
                //    width = maxWidth;
                //    height = (int)(width / aspectRatio);
                //    if (height > maxHeight)
                //    {
                //        height = maxHeight;
                //        width = (int)(height * aspectRatio);
                //    }
                //}
                //else
                //{
                //    // Calculated width and height,
                //    // and recalcuate if the width exceeds maxWidth
                //    height = maxHeight;
                //    width = (int)(height * aspectRatio);
                //    if (width > maxWidth)
                //    {
                //        width = maxWidth;
                //        height = (int)(width / aspectRatio);
                //    }
                //}
            }
            //else if ((maxHeight == 0) && (source.Width > maxWidth))
            //{
            //    // If MaxHeight is not provided (unlimited), and
            //    // the source width exceeds maxWidth,
            //    // then recalculate height
            //    width = maxWidth;
            //    height = (int)(width / aspectRatio);
            //}
            //else if ((maxWidth == 0) && (source.Height > maxHeight))
            //{
            //    // If MaxWidth is not provided (unlimited), and the
            //    // source height exceeds maxHeight, then
            //    // recalculate width
            //    height = maxHeight;
            //    width = (int)(height * aspectRatio);
            //}
            //else
            //{
            //    //Return unchanged image
            //    return source;
            //}

            Bitmap newImage = GetResizedImage(source, maxWidth, maxHeight);
            return newImage;
        }
        protected Bitmap GetResizedImage(Bitmap source, int width, int height)
        {
            //This function creates the thumbnail image.
            //The logic is to create a blank image and to
            // draw the source image onto it

            Bitmap thumb = new Bitmap(width, height);
            Graphics gr = Graphics.FromImage(thumb);

            gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gr.SmoothingMode = SmoothingMode.HighQuality;
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
            gr.CompositingQuality = CompositingQuality.HighQuality;

            gr.DrawImage(source, 0, 0, width, height);
            return thumb;
        }

    }
}