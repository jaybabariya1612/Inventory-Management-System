//namespace Inventory_Management_System
//{
//    partial class MainForm
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

using System.Drawing;

namespace System.Windows.Forms
{
    internal class Font
    {
        private string v1;
        private float v2;
        private Drawing.FontStyle bold;
        private GraphicsUnit point;
        private byte v3;

        public Font(string v1, float v2, Drawing.FontStyle bold, GraphicsUnit point, byte v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.bold = bold;
            this.point = point;
            this.v3 = v3;
        }
    }
}