using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FunctionPlotter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeChart();

            comboBoxFunctions.SelectedIndexChanged += ComboBoxFunctions_SelectedIndexChanged;
        }

        private void InitializeChart()
        {
            chart.ChartAreas.Clear();
            ChartArea area = new ChartArea("MainArea");
            chart.ChartAreas.Add(area);

            area.AxisX.MajorGrid.LineColor = Color.LightGray;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            area.AxisX.Crossing = 0;
            area.AxisY.Crossing = 0;
            area.AxisX.ArrowStyle = AxisArrowStyle.Triangle;
            area.AxisY.ArrowStyle = AxisArrowStyle.Triangle;
            area.AxisX.LabelStyle.Format = "0.##";
            area.AxisY.LabelStyle.Format = "0.##";
        }

        private void ComboBoxFunctions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string func = comboBoxFunctions.SelectedItem?.ToString();
            switch (func)
            {
                case "linear":
                    textBoxParameters.Text = "k b";
                    break;
                case "quadratic":
                    textBoxParameters.Text = "a b c";
                    break;
                case "cubic":
                    textBoxParameters.Text = "a b c d";
                    break;
                case "sinus":
                case "cosinus":
                case "tangent":
                case "cotangent":
                    textBoxParameters.Text = "A B C";
                    break;
                case "exp":
                case "log":
                    textBoxParameters.Text = "a";
                    break;
                default:
                    textBoxParameters.Text = "";
                    break;
            }
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            string func = comboBoxFunctions.SelectedItem?.ToString();
            if (func == null)
            {
                MessageBox.Show("Выберите функцию.");
                return;
            }

            string[] parts = textBoxParameters.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (!double.TryParse(textBoxXStart.Text, out double xStart) ||
                !double.TryParse(textBoxXEnd.Text, out double xEnd) ||
                !double.TryParse(textBoxYStart.Text, out double yStart) ||
                !double.TryParse(textBoxYEnd.Text, out double yEnd) ||
                xStart >= xEnd || yStart >= yEnd)
            {
                MessageBox.Show("Введите корректные значения X и Y границ.");
                return;
            }

            double step = (xEnd - xStart) / 200.0;
            chart.Series.Clear();
            chart.Annotations.Clear();

            Series series = new Series("Function")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };
            chart.Series.Add(series);

            try
            {
                for (double x = xStart; x <= xEnd; x += step)
                {
                    double y = double.NaN;

                    switch (func)
                    {
                        case "linear":
                            if (parts.Length >= 2)
                                y = double.Parse(parts[0]) * x + double.Parse(parts[1]);
                            break;
                        case "quadratic":
                            if (parts.Length >= 3)
                                y = double.Parse(parts[0]) * x * x + double.Parse(parts[1]) * x + double.Parse(parts[2]);
                            break;
                        case "cubic":
                            if (parts.Length >= 4)
                                y = double.Parse(parts[0]) * x * x * x +
                                    double.Parse(parts[1]) * x * x +
                                    double.Parse(parts[2]) * x +
                                    double.Parse(parts[3]);
                            break;
                        case "sinus":
                            if (parts.Length >= 3)
                                y = double.Parse(parts[0]) * Math.Sin(double.Parse(parts[1]) * x + double.Parse(parts[2]));
                            break;
                        case "cosinus":
                            if (parts.Length >= 3)
                                y = double.Parse(parts[0]) * Math.Cos(double.Parse(parts[1]) * x + double.Parse(parts[2]));
                            break;
                        case "tangent":
                            if (parts.Length >= 2)
                                y = double.Parse(parts[0]) * Math.Tan(double.Parse(parts[1]) * x);
                            break;
                        case "cotangent":
                            if (parts.Length >= 2)
                            {
                                double angle = double.Parse(parts[1]) * x;
                                double tan = Math.Tan(angle);
                                if (Math.Abs(tan) > 1e-10)
                                    y = double.Parse(parts[0]) / tan;
                            }
                            break;
                        case "exp":
                            if (parts.Length >= 1)
                                y = Math.Pow(double.Parse(parts[0]), x);
                            break;
                        case "log":
                            if (parts.Length >= 1 && x > 0)
                                y = Math.Log(x, double.Parse(parts[0]));
                            break;
                    }

                    if (!double.IsNaN(y) && !double.IsInfinity(y))
                        series.Points.AddXY(x, y);
                }

                ChartArea area = chart.ChartAreas[0];
                area.AxisX.Minimum = xStart;
                area.AxisX.Maximum = xEnd;
                area.AxisY.Minimum = yStart;
                area.AxisY.Maximum = yEnd;

                string formula = GetFunctionFormula(func, parts);
                if (!string.IsNullOrWhiteSpace(formula))
                {
                    TextAnnotation annotation = new TextAnnotation
                    {
                        Text = formula,
                        X = 5,
                        Y = 95,
                        AnchorX = xStart + 1,
                        AnchorY = yEnd - 1,
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        ForeColor = Color.DarkRed,
                        AnchorAlignment = ContentAlignment.TopLeft
                    };
                    chart.Annotations.Add(annotation);
                }

                chart.Invalidate();
            }
            catch
            {
                MessageBox.Show("Ошибка при вычислении. Проверьте параметры.");
            }
        }

        private string GetFunctionFormula(string func, string[] parts)
        {
            try
            {
                switch (func)
                {
                    case "linear":
                        return $"y = {parts[0]}x + {parts[1]}";
                    case "quadratic":
                        return $"y = {parts[0]}x² + {parts[1]}x + {parts[2]}";
                    case "cubic":
                        return $"y = {parts[0]}x³ + {parts[1]}x² + {parts[2]}x + {parts[3]}";
                    case "sinus":
                        return $"y = {parts[0]}·sin({parts[1]}x + {parts[2]})";
                    case "cosinus":
                        return $"y = {parts[0]}·cos({parts[1]}x + {parts[2]})";
                    case "tangent":
                        return $"y = {parts[0]}·tan({parts[1]}x)";
                    case "cotangent":
                        return $"y = {parts[0]}·cot({parts[1]}x)";
                    case "exp":
                        return $"y = {parts[0]}^x";
                    case "log":
                        return $"y = log base {parts[0]}(x)";
                    default:
                        return "";
                }
            }
            catch
            {
                return "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "PNG Image|*.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    chart.SaveImage(dlg.FileName, ChartImageFormat.Png);
                    MessageBox.Show("График сохранён!");
                }
            }
        }
    }
}
