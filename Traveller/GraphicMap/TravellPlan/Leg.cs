using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicMap.TravellPlan
{
    [Serializable]
    public class Leg : ICloneable
    {

        public WayPoint A;
        public WayPoint B;       
        public string Type;  
        public string Identifier;  
        public string RefToNext; 
        public string RefToPrevious; 

        public Leg()
        {         

        }

        public Leg(WayPoint A, WayPoint B)
        {
            this.A = A;
            this.B = B;
            this.Identifier = A.Identifier + B.Identifier;
        }
       
        public virtual void ShowLeg(Point A, Point B, Color LegColor)
        {
            
           
               
               
                //Graphics Display = Graphics.FromImage(this.pi);
                //Pen Peny = new Pen(Color.WhiteSmoke, 5);
                //Peny.EndCap = LineCap.ArrowAnchor;
                //Peny.StartCap = LineCap.RoundAnchor;
                //Display.DrawLine(Peny, A, B);

                //Rectangle LegRectangle = new Rectangle(A.X, A.Y, B.X - A.X, B.Y - A.Y);              
                //Point MediaTrix = new Point((A.X + B.X) / 2, (A.Y + B.Y) / 2);
                //Font Fonty = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Italic);
               
           
                   
        }

        public object Clone()
        {
            Leg l;
            l = (Leg)this.MemberwiseClone();
            return l;

        }


    }
}
