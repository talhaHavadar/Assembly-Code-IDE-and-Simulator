using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjeWithForm
{
    class MenuStripColorTable : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return Color.FromArgb(29, 29, 29);
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Color.Transparent;//Color.FromArgb(29, 29, 29);
            }
        }

        public override Color ImageMarginRevealedGradientBegin
        {
            get
            {
                return Color.Transparent;
            }
        }
        public override Color ImageMarginRevealedGradientEnd
        {
            get
            {
                return Color.Transparent;
            }
        }
        
        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Color.Transparent; //Color.FromArgb(29, 29, 29);
            }
        }
        
        public override Color MenuStripGradientBegin
        {
            get
            {
                return Color.FromArgb(29, 29, 29);
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return Color.FromArgb(29, 29, 29);
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Color.Transparent;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return Color.DimGray;
            }
        }


        public override Color ToolStripBorder
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.FromArgb(29, 29, 29);
            }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.FromArgb(29, 29, 29);
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.DimGray; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.DimGray; }
        }

    }
}
