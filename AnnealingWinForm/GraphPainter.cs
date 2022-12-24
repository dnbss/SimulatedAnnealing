using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnealingWinForm
{
    public class GraphPainter
    {
        private Graphics _graphics;

        private Bitmap _bitmap;

        private List<PointF> _vertexPoints;

        public GraphPainter(Graphics graphics, Bitmap bitmap)
        {
            _graphics = graphics;

            _bitmap = bitmap;

            _vertexPoints = new List<PointF>();
        }

        private void BuildVertexes(int countVertex, double radiusGraph)
        {
            _vertexPoints.Clear();

            double angle = 2 * Math.PI / countVertex;

            PointF center = new PointF(_bitmap.Width / 2, _bitmap.Height / 2);

            for (int i = 0; i < countVertex; i++)
            {
                _vertexPoints.Add(new PointF((float)(center.X + radiusGraph * Math.Sin(i * angle))
                    , (float)(center.Y + radiusGraph * Math.Cos(i * angle))));
            }
        }

        public void DrawCompleteGraph(int countVertex)
        {
            _graphics.Clear(Color.White);

            double radiusVertex = 13;

            double radiusGraph = 215;

            BuildVertexes(countVertex, radiusGraph);

            DrawEdges();

            DrawVertexes(countVertex, radiusVertex);
        }

        public void DrawVertexes(int countVertex, double radiusVertex)
        {
            for (int i = 0; i < countVertex; i++)
            {
                _graphics.FillEllipse(
                    new SolidBrush(Color.Gold),
                    (float)(_vertexPoints[i].X - radiusVertex),
                    (float)(_vertexPoints[i].Y - radiusVertex),
                    (float)(2 * radiusVertex),
                    (float)(2 * radiusVertex));

                _graphics.DrawString(
                    (i + 1).ToString(),
                    new Font("Arial", 10),
                    new SolidBrush(Color.Black),
                    new PointF(_vertexPoints[i].X - 7, _vertexPoints[i].Y - 7));
            }
        }

        public void DrawEdges()
        {
            Color color = Color.LightBlue;

            int width = 3;

            for (int i = 0; i < _vertexPoints.Count; i++)
            {
                for (int j = 0; j < _vertexPoints.Count; j++)
                {
                    
                    _graphics.DrawLine(
                        new Pen(new SolidBrush(color), width),
                        _vertexPoints[i], 
                        _vertexPoints[j]);
                }
            }
        }

        public void DrawCycle(List<int> vertexes)
        {
            Color color = Color.LightCoral;

            int width = 3;

            for (int i = 0; i < vertexes.Count; i++)
            {
                _graphics.DrawLine(
                        new Pen(new SolidBrush(color), width),
                        _vertexPoints[vertexes[i]],
                        _vertexPoints[vertexes[(i + 1) % vertexes.Count]]);
            }

            double radiusVertex = 13;

            DrawVertexes(vertexes.Count, radiusVertex);
        }
       
    }
}
