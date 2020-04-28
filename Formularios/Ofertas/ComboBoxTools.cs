﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using ERP_ventas.Modelo;
namespace ERP_ventas.Formularios.Ofertas
{
    public static class ComboBoxTools
    {
        //Esta clase se encarga de mostrar correctamente los items con sus respectivas imagenes
        // Margins around owner drawn ComboBoxes.
        private const int MarginWidth = 4;
        private const int MarginHeight = 4;

        #region Display Images

        // Set up the ComboBox to display images.
        public static void DisplayImages(this ComboBox cbo, Image[] images)
        {
            // Make the ComboBox owner-drawn.
            cbo.DrawMode = DrawMode.OwnerDrawVariable;

            // Add the images to the ComboBox's items.
            cbo.Items.Clear();
            foreach (Image image in images) cbo.Items.Add(image);

            // Subscribe to the DrawItem event.
            cbo.MeasureItem += cboDrawImage_MeasureItem;
            cbo.DrawItem += cboDrawImage_DrawItem;
        }

        // Measure a ComboBox item that is displaying an image.
        private static void cboDrawImage_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Get this item's image.
            ComboBox cbo = sender as ComboBox;
            Image img = (Image)cbo.Items[e.Index];
            e.ItemHeight = img.Height + 2 * MarginHeight;
            e.ItemWidth = img.Width + 2 * MarginWidth;
        }

        // Draw a ComboBox item that is displaying an image.
        private static void cboDrawImage_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Clear the background appropriately.
            e.DrawBackground();

            // Draw the image.
            ComboBox cbo = sender as ComboBox;
            Image img = (Image)cbo.Items[e.Index];
            float hgt = e.Bounds.Height - 2 * MarginHeight;
            float scale = hgt / img.Height;
            float wid = img.Width * scale;
            RectangleF rect = new RectangleF(
                e.Bounds.X + MarginWidth,
                e.Bounds.Y + MarginHeight,
                wid, hgt);
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.DrawImage(img, rect);

            // Draw the focus rectangle if appropriate.
            e.DrawFocusRectangle();
        }

        #endregion Display Images

        #region Mostrar Productos

        // Set up the ComboBox to display images with text.
        public static void MostrarProductos(this ComboBox cbo, Producto[] values)
        {
            // Make the ComboBox owner-drawn.
            //Propiedad para que aparezcan los productos con las imagenes
            cbo.DrawMode = DrawMode.OwnerDrawVariable;

            // Agrega los productos a los items del combobox.
            cbo.Items.Clear();
            cbo.Items.AddRange(values);

            // Adjuntar eventos para dibujar los items
            cbo.MeasureItem += MeasureItem; 
            cbo.DrawItem += DrawItem;
        }
                                                                                
        // Measure a ComboBox item that is displaying an image.
        private static void MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0) return;
            // Get the item.
            ComboBox cbo = sender as ComboBox;
            Producto item = (Producto)cbo.Items[e.Index];

            // Make the item measure itself.
            item.MeasureItem(e);
        }

        // Draw a ComboBox item that is displaying an image.
        private static void DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Get the item.
            ComboBox cbo = sender as ComboBox;
            Producto item = (Producto)cbo.Items[e.Index];

            // Make the item draw itself.
            item.DrawItem(e);
        }

        #endregion Images and Text
    }
}
