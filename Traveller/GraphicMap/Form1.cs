using Coordinates_One;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicMap
{
    public partial class Form1 : Form
    {
        private int IniCellSize = 665000 / 762;
        //Primer parametro Utm_x es Easting segundo Northing
        UTM IniVertexNW = new UTM(500000 - 332500, 880000);
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point GraphicPoint = new Point(0, 0);

            //47   N   
            //662416.12   
            //1521021.83 Bangkok



            //Latitude: 3°08′28″ N
            //Longitude: 101°41′11″ E

            GeographicCoordinate GeoKUL = new GeographicCoordinate(3, 8, 28, 101, 41, 11);
            var UTMKUL = GeoKUL.ConvertToUTM();

            //Easting: 798606.88485575
            //Northing: 347584.29953333


            //Pukhet
            //UTM Easting     433,682.70
            //UTM Northing    870,966.45

            ShowOnePoint();
            pictureBox1.Invalidate();
        }


        public void ShowOnePoint()
        {

            Graphics Display = Graphics.FromImage(pictureBox1.Image);
            //En este punto aun no estan asignadas las coordenadas UTM




            //Esto es necesario porque el codigo que calcula X e Y solo esta presente en constructor
            //con grados,minutos y segundos

            GeographicCoordinate Geo = new GeographicCoordinate(0, 53, 9, 97, 20, 04);
            GeographicCoordinate PreConvertUTM = new GeographicCoordinate(Geo.LatitudeGrades, Geo.LatitudeMinutes, Geo.LatitudeSeconds, Geo.LongitudeGrades, Geo.LongitudeMinutes, Geo.LongitudeSeconds);



            UTM UTM = Geo.ConvertToUTM();

            Point Graphic = UTM.ConvertUTMCoordinatesToGraphicPoint(new Point(0, 0), IniCellSize);


            int Width = 5;

            Pen Peny = new Pen(Color.Red, Width);
            Point Point1 = new Point(Graphic.X - Width, Graphic.Y - Width);
            Point Point2 = new Point(Graphic.X + Width, Graphic.Y + Width);
            Point Point3 = new Point(Graphic.X - Width, Graphic.Y + Width);
            Point Point4 = new Point(Graphic.X + Width, Graphic.Y - Width);
            Display.DrawLine(Peny, Point1, Point2);
            Display.DrawLine(Peny, Point3, Point4);

            Font Fonty = new Font(FontFamily.GenericSerif, 10, FontStyle.Italic); //Añadir Numero de WayPoint a la marca


            Brush Brushy = new SolidBrush(Color.Black);
            Display.DrawString("Test", Fonty, Brushy, Graphic.X, Graphic.Y);

            pictureBox1.Refresh();

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;

            Point MousePointDown = new Point(x, y);

            ScreenCoordinates screenCoordinates = new ScreenCoordinates();
            //
            UTM UTM = screenCoordinates.ConvertToUTM(MousePointDown,new  Point(0,0) ,IniCellSize );


            //Point ProcessMousePositionTest = ScreenCoordinates.ConvertUTMCoordinatesToGraphicPoint(UTM, CenterImageBackUp.Vertex, CenterImageBackUp.CellSize);

            if (true)
            {
                



                        //WayPoint ToAdd = new WayPoint(UTM, Altitude, Speed, Transition, Type, NewName, Identifier);





               

            }
        }

        //private void CenterImage_MouseDown(object sender, MouseEventArgs e)
        //{
        //    int x = e.Location.X;
        //    int y = e.Location.Y;

        //    MousePointDown = new Point(x, y);
        //    try
        //    {   //WayPoint ToAdd;
        //        UTMCoordinate UTM = ConvertClickToUTMCoordinates(MousePointDown, CenterImageBackUp.Vertex, CenterImageBackUp.CellSize);
        //        Point ProcessMousePositionTest = ConvertUTMCoordinatesToGraphicPoint(UTM, CenterImageBackUp.Vertex, CenterImageBackUp.CellSize);
        //        int[,] CurrentElevationFromFile = GISSeek.ExtractAltitudesFromFile(UTM.ConvertUTMToVertexCoordinates(), 1, 1);
        //        int Elevation = CurrentElevationFromFile[0, 0];
        //        if (Elevation != -9999)
        //        {
        //            textBoxElevation.Text = Convert.ToString(Elevation);
        //        }
        //        else
        //        {
        //            textBoxElevation.Text = "0";
        //        }


        //        if (AddClickAsWayPoint)
        //        {
        //            //Mismo Para Speed
        //            if (textBoxAltitude.Text != "")
        //            {

        //                try
        //                {
        //                    int Altitude = Convert.ToInt32(textBoxAltitude.Text);
        //                    int Speed = Convert.ToInt32(DefaultSpeedTextBox.Text);


        //                    //string Transition = combotransition.SelectedText;
        //                    string Transition = combotransition.SelectedItem.ToString();

        //                    string Type = combotype.SelectedItem.ToString();
        //                    string NewName = textBoxWayPointName.Text;
        //                    string Identifier = NewName + "[" + Convert.ToString(FlightPlan.WayPoints.Count) + "]";



        //                    WayPoint ToAdd = new WayPoint(UTM, Altitude, Speed, Transition, Type, NewName, Identifier);


        //                    textBoxWayPointName.Focus();
        //                    textBoxWayPointName.SelectAll();


        //                    //tabControl.SelectTab(tabPageCoordinates);
        //                    //Verificar aqui que punto incluido este por encima de altura en posicion actual
        //                    if (Altitude <= Elevation)
        //                    {
        //                        DialogResult Answer = MessageBox.Show("The Altitude of the WayPoint you want to include is less elevated than the current selected point", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //                        textBoxAltitude.Focus();
        //                    }
        //                    else
        //                    {
        //                        //DialogResult Answer = MessageBox.Show("Are you sure you want to include this WayPoint to the current Flight Plan?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        //                        //if (Answer == DialogResult.Yes)
        //                        //{
        //                        FlightPlan.AddWayPoint(ToAdd); //Se añade WayPoint a Array


        //                        FillFlightPlanfromArray();
        //                        tabControl.SelectTab(tabPageWayPointTool);
        //                        //}

        //                    }
        //                }

        //                catch
        //                {

        //                    MessageBox.Show("WayPoint you want to include has some invalid parameters");
        //                }

        //            }
        //            else
        //            {
        //                tabControl.SelectTab(tabPageCoordinates);
        //                textBoxAltitude.Focus(); //Veamos
        //                MessageBox.Show("First, select which altitude do you want to assign to the new WayPoint?");
        //            }

        //        }

        //        UTMToForm(UTM, true); //Con True activado tb lo convierte a Geo
        //    }//Fin Try 
        //    catch { MessageBox.Show("Just wait a few seconds more ... "); }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
