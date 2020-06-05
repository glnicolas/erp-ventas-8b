using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using System.IO;

namespace ERP_ventas.Modelo
{
    public class Producto
    {
        // Margins around owner drawn ComboBoxes.
        private const int MarginWidth = 4;
        private const int MarginHeight = 4;
        public Image Imagen { get; set; }
        public Font Font = new Font("Times New Roman", 14);
        public int ID { get; set; }
        public string NombreProducto { get { return Marca + " " + Nombre; } }
        public string Marca { get; set; }
        public string Estilo { get; set; }
        public string Categoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public char Genero { get; set; }
        internal Oferta  Oferta { get; set; }
        internal int IDVentaDetalle { get; set; }
        public int Cantidad;
        public DetalleProducto detalleSeleccionado;
        public string GeneroString
        {
            get
            {
                if (Genero == 'F')
                {
                    return "Femenino";
                }
                else
                {
                    return "Masculino";
                }
            }
        }
        public double Precio_venta { get; set; }
        public double Precio_real { get; set; }
        public char Estatus { get; set; }
        public bool Agregado { get; set; }
        public byte[] Imagen_bytes { get; set; }
        public List<DetalleProducto> Detalles { get; set; }

        internal decimal Suma { get { return (decimal)(Cantidad * Precio_venta); } }
        public Producto(int id, string marca, string estilo, string categoria, string nombre, string descripcion, char genero, double precio, byte[] imagen)
        {
            ID = id;
            Marca = marca;
            Estilo = estilo;
            Categoria = categoria;
            Nombre = nombre;
            Descripcion = descripcion;
            Genero = genero;
            Precio_venta = precio;

            if (imagen == null)
            {
                Imagen = new Bitmap(Properties.Resources.image_not_available, new Size(100, 65));
                ImageConverter _imageConverter = new ImageConverter();
                Imagen_bytes = (byte[])_imageConverter.ConvertTo(Properties.Resources.image_not_available, typeof(byte[]));
            }
            else
            {
                Imagen = new Bitmap(new Bitmap(new MemoryStream(imagen)), new Size(100, 65));
                Imagen_bytes = imagen;
            }
        }

        public Producto()
        {
        }

        // Set the size needed to display the image and text.
        private int Width, Height;
        private bool SizeCalculated = false;
        public void MeasureItem(MeasureItemEventArgs e)
        {
            // See if we've already calculated this.
            if (!SizeCalculated)
            {
                SizeCalculated = true;

                // See how much room the text needs.
                SizeF text_size = e.Graphics.MeasureString(NombreProducto, Font);

                // The height is the maximum of the image height and text height.
                Height = 2 * MarginHeight +
                    (int)Math.Max(Imagen.Height, text_size.Height);

                // The width is the sum of the image and text widths.
                Width = (int)(4 * MarginWidth + Imagen.Width + text_size.Width);
            }

            e.ItemWidth = Width;
            e.ItemHeight = Height;
        }

        // Draw the item.
        public void DrawItem(DrawItemEventArgs e)
        {
            // Clear the background appropriately.
            e.DrawBackground();

            // Draw the image.
            float hgt = e.Bounds.Height - 2 * MarginHeight;
            float scale = hgt / Imagen.Height;
            float wid = Imagen.Width * scale;
            RectangleF rect = new RectangleF(
                e.Bounds.X + MarginWidth,
                e.Bounds.Y + MarginHeight,
                wid, hgt);
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.DrawImage(Imagen, rect);

            // Draw the text.
            // If we're drawing on the control,
            // draw only the first line of text.
            string visible_text = NombreProducto;

            // Make a rectangle to hold the text.
            wid = e.Bounds.Width - rect.Right - 3 * MarginWidth;
            rect = new RectangleF(
                rect.Right + 2 * MarginWidth, rect.Y,
                wid, hgt);
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Center;
                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                e.Graphics.DrawString(visible_text, Font, Brushes.Black, rect, sf);
            }
            //e.Graphics.DrawRectangle(Pens.Blue, Rectangle.Round(rect));

            // Draw the focus rectangle if appropriate.
            e.DrawFocusRectangle();
        }
    }
}
