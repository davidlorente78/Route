using GraphicMap.Coordinates;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Traveller;
using Traveller.Domain;
using Traveller.RouteService;
using Traveller.RouteService.DataContainer;
using Traveller.RouteService.Evaluator;
using Traveller.RouteService.Helpers;
using Traveller.RuleService;

namespace GraphicMap
{
    public partial class SouthEastAsiaMap : Form
    {
        CountriesScreenCoordinates countriesScreenCoordinates = new CountriesScreenCoordinates();
        private List<Tuple<List<char>, List<List<Tuple<char, string>>>, List<double>>> finalReports = new List<Tuple<List<char>, List<List<Tuple<char, string>>>, List<double>>>();
        public SouthEastAsiaMap()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;

            Point MousePointDown = new Point(x, y);

            this.textBox1.Text = x.ToString() + "," + y.ToString();

        }

        private void SouthEastAsiaMap_Load(object sender, EventArgs e)
        {


            RouteCombinationsGenerator routeGenerator = new RouteCombinationsGenerator(new XXXMalasyaTailandiaLongStayRuleContainer());


            //RoutePermutationsGenerator routeGenerator = new RoutePermutationsGenerator(new AllDestinationsRuleContainer());

            //List<List<char>> routes = routeGenerator.Generate();

            var routes = new List<List<char>>();

            routes.Add(new List<char> { 'T', 'L', 'V', 'C', 'M', 'M', 'M', 'T', 'T', 'V', 'L', 'T' });

         

            //12 botones icono con explicacion del icono detallada en el ToolTip es lo mas basico

            //Organizar Reports //Unos devuelven informacion mensual y son listas de string y otros son resultado de valoracion numerica (Double)

            //Los double se pueden ordenar y mostrar en el Datagrid





            ToDatagrid(new List<string> { "Routes", "Season Evaluation" }, routes, finalReports);

            //Para cada propiedad de la clase 
            foreach (var coordinate in countriesScreenCoordinates.Coordinates)
            {

                string label = CodeDictionary.GetCountryByCode(coordinate.Item1);
                ShowPoint(coordinate.Item3, label, coordinate.Item2);

            }


            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;


        }

        public enum Meses { Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre }


        public void ToSerialButtons(List<Tuple<List<char>, List<List<Tuple<char, string>>>, List<double>>> finalReports, int index)
        {

            panel1.Controls.Clear();
            int x = 0;

            Array valores = Enum.GetValues(typeof(Meses));

            var report = finalReports[index].Item2[0]; //Reporte [Index]

            foreach (var monthDescription in report)
            {


                Button button = new Button();

                button.Width = panel1.Width;
                int Height = panel1.Height / 12;
                button.Height = Height;

                //button.Location = new Point(panel1.Location.X, panel1.Location.Y + x* Height);
                button.Location = new Point(0, x * Height);
                button.Text = valores.GetValue(x).ToString() + " : " + monthDescription.Item1.ToString();
                //button.Image
                x++;


                // Set up the ToolTip text for the Button and Checkbox.
                toolTip1.SetToolTip(button, monthDescription.Item2);


                panel1.Controls.Add(button);

            }


            panel1.Refresh();


        }

        public void ToDatagrid(List<string> headers, List<List<char>> routes, List<Tuple<List<char>, List<List<Tuple<char, string>>>, List<double>>> finalReports)
        {
            var dt = new DataTable();

            // create columns and headers
            int columnCount = headers.Count;
            for (int i = 0; i < columnCount; i++)
                dt.Columns.Add(headers[i]);

            // copy rows data
            for (int i = 0; i < routes.Count; i++)
            {
                //string readableRoute = string.Join("", routes[i]);

                string readableRoute = Helper.ConvertCodesToCountries(routes[i]);
                double evaluation = finalReports[i].Item3[0];

                dt.Rows.Add(readableRoute, evaluation);

            }
            // display in a DataGrid
            dataGridView1.DataSource = dt;

            textBox1.Text = routes.Count.ToString();
        }


        public void ShowPoint(Point point, string name, char type)
        {

            Graphics Display = Graphics.FromImage(pictureBox1.Image);



            int crossWidth = 5;

            Pen pen = new Pen(Color.Red, crossWidth);
            Point Point1 = new Point(point.X - crossWidth, point.Y - crossWidth);
            Point Point2 = new Point(point.X + crossWidth, point.Y + crossWidth);
            Point Point3 = new Point(point.X - crossWidth, point.Y + crossWidth);
            Point Point4 = new Point(point.X + crossWidth, point.Y - crossWidth);

            Display.DrawLine(pen, Point1, Point2);
            Display.DrawLine(pen, Point3, Point4);

            Font font = new Font(FontFamily.GenericMonospace, 20, FontStyle.Regular);
            if (type == 'R')
            {

                font = new Font(FontFamily.GenericMonospace, 20, FontStyle.Italic);
            }

            else if (type == 'C')
            {
                font = new Font(FontFamily.GenericMonospace, 25, FontStyle.Bold);
            }
            else if (type == 'T')
            {
                font = new Font(FontFamily.GenericSerif, 12, FontStyle.Regular);
            }


            Brush Brushy = new SolidBrush(Color.Black);
            Display.DrawString(name, font, Brushy, Point4.X, Point4.Y - crossWidth * 3);



        }


        private void ShowLeg(Point A, Point B, Color color, string label, Graphics graphics)
        {
            Pen pen = new Pen(color, 5);
            pen.EndCap = LineCap.ArrowAnchor;
            pen.StartCap = LineCap.RoundAnchor;
            graphics.DrawLine(pen, A, B);

            Rectangle LegRectangle = new Rectangle(A.X, A.Y, B.X - A.X, B.Y - A.Y);
            Point medium = new Point((A.X + B.X) / 2, (A.Y + B.Y) / 2);
            Font font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

            Brush brush = new SolidBrush(Color.Black);
            graphics.DrawString(label, font, brush, medium.X, medium.Y);




        }



        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            Tuple<List<char>, List<List<Tuple<char, string>>>, List<double>> show = finalReports[index];

            List<Tuple<char, int>> decomposed = Helper.DetectRepeatedChars(show.Item1);

            Graphics Display = Graphics.FromImage(pictureBox1.Image);

            for (int x = 0; x < decomposed.Count; x++)
            {

                var Origin = countriesScreenCoordinates.Coordinates.Find(y => y.Item1 == decomposed[x].Item1);
                int next = x + 1;
                if (next == decomposed.Count)
                {
                    next = 0;
                }
                var Destination = countriesScreenCoordinates.Coordinates.Find(y => y.Item1 == decomposed[next].Item1);

                ShowLeg(Origin.Item3, Destination.Item3, Color.Orange, x.ToString(), Display);



            }

            ToSerialButtons(finalReports, index);

            pictureBox1.Invalidate();

        }
    }
}
