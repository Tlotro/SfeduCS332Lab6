﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        Camera camera;
        bool textchanging = true;
        List<PolyHedron> polyHedrons = new List<PolyHedron>();
        Dictionary<string,Point3d> ExtraPoints = new Dictionary<string, Point3d>();
        Dictionary<string, KeyValuePair<Point3d,Point3d>> ExtraLines = new Dictionary<string, KeyValuePair<Point3d, Point3d>>();
        public Form1()
        {
            InitializeComponent();
            camera = new Camera(new Point3d(0, 0, 0), new Point3d(45, 0, 0), 200, new PointF(panel1.Size.Width, panel1.Size.Height));
            polyHedrons.Add(PolyHedron.Tetrahedron(100, 0, 50,10));
            polyHedrons.Add(PolyHedron.Hexahedron(200, 0, 50,10));
            polyHedrons.Add(PolyHedron.Octahedron(300, 0, 50,10));
            polyHedrons.Add(PolyHedron.Icosahedron(400, 0, 50,10));
            polyHedrons.Add(PolyHedron.Dodecahedron(500, 0, 50,10));
            polyHedrons.Add(PolyHedron.Tetrahedron(-100, 0, 50, 10));
            polyHedrons.Add(PolyHedron.Hexahedron(-200, 0, 50, 10));
            polyHedrons.Add(PolyHedron.Octahedron(-300, 0, 50, 10));
            polyHedrons.Add(PolyHedron.Icosahedron(-400, 0, 50, 10));
            polyHedrons.Add(PolyHedron.Dodecahedron(-500, 0, 50, 10));
            polyHedrons.Add(PolyHedron.Tetrahedron(100, -0, -50, 10));
            polyHedrons.Add(PolyHedron.Hexahedron(200, -0, -50, 10));
            polyHedrons.Add(PolyHedron.Octahedron(300, -0, -50, 10));
            polyHedrons.Add(PolyHedron.Icosahedron(400, -0, -50, 10));
            polyHedrons.Add(PolyHedron.Dodecahedron(500, -0, -50, 10));
            polyHedrons.Add(PolyHedron.Tetrahedron(-100, -0, -50, 10));
            polyHedrons.Add(PolyHedron.Hexahedron(-200, -0, -50, 10));
            polyHedrons.Add(PolyHedron.Octahedron(-300, -0, -50, 10));
            polyHedrons.Add(PolyHedron.Icosahedron(-400, -0, -50, 10));
            polyHedrons.Add(PolyHedron.Dodecahedron(-500, -0, -50, 10));
            //==================Временные фигуры=======
            var square = new List<Point3d>();
            square.Add(new Point3d(-50, -25, 0)); square.Add(new Point3d(-50, 25, 0)); square.Add(new Point3d(0, 25, 0)); square.Add(new Point3d(0, -25, 0));
            //polyHedrons.Add(PolyHedron.SpinShape(square, 8, "Y"));
            //=========================================
            ExtraLines.Add("X", new KeyValuePair<Point3d, Point3d>(new Point3d(0,0,0),new Point3d(50,0,0)));
            ExtraLines.Add("Y", new KeyValuePair<Point3d, Point3d>(new Point3d(0,0,0), new Point3d(0,50,0)));
            ExtraLines.Add("Z", new KeyValuePair<Point3d, Point3d>(new Point3d(0,0,0), new Point3d(0,0,50)));
            this.SetStyle(ControlStyles.DoubleBuffer |
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint,
            true);
            this.UpdateStyles();
            camera.update();
            //Animate
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (50);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            camera.viewport = new PointF(panel1.Size.Width, panel1.Size.Height);
            foreach (var poly in polyHedrons)
            {
                poly.Rotation.X += 5;
                poly.Rotation.Y += 5;
                poly.Rotation.Z += 5;
            }
            camera.camRot.Y += 1f;
            camera.camDist += 0.5f;
            camera.update();
            draw();
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void draw()
        {
            BufferedGraphicsContext currentContext;
            BufferedGraphics myBuffer;
            currentContext = BufferedGraphicsManager.Current;
            myBuffer = currentContext.Allocate(panel1.CreateGraphics(),panel1.DisplayRectangle);
            myBuffer.Graphics.Clear(SystemColors.Control);
            foreach (PolyHedron poly in polyHedrons) 
            {
                poly.draw(myBuffer.Graphics, camera);
            }
            foreach (var point in ExtraPoints)
                drawPoint(myBuffer.Graphics, camera, Color.Green, point.Value);
            foreach (var line in ExtraLines)
                drawLine(myBuffer.Graphics, camera, Color.Green, line.Value.Key, line.Value.Value);
            myBuffer.Render(); 
            myBuffer.Dispose();
        }
        public void drawPoint(Graphics g, Camera camera, Color color, Point3d point1)
        {
            Point3d p1 = (Point3d)(point1 * camera.ViewMatrix * camera.ProjectionMatrix);
            g.FillEllipse(new Pen(color).Brush, p1.X-3 + camera.viewport.X / 2, -p1.Y-3 + camera.viewport.Y / 2, 7,7);
        }
        public void drawLine(Graphics g, Camera camera, Color color, Point3d point1, Point3d point2)
        {
            Point3d p1 = (Point3d)(point1 * camera.ViewMatrix * camera.ProjectionMatrix);
            Point3d p2 = (Point3d)(point2 * camera.ViewMatrix * camera.ProjectionMatrix);
            g.DrawLine(new Pen(color), p1.X + camera.viewport.X / 2, -p1.Y + camera.viewport.Y / 2, p2.X + camera.viewport.X / 2, -p2.Y + camera.viewport.Y / 2);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            draw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExtraPoints.Remove("PHDSelector");
            ExtraLines.Remove("RotationAxis");
            //У каждого задания своя панель. СМ вид->другие окна->структура документа
            SpawnPanel.Visible = false;
            TransformPanel.Visible = false;
            EditPanel.Visible = false;
            MirrorPanel.Visible = false;
            RotatePanel.Visible = false; 
            PerspectivePanel.Visible = false;
            DespawnPanel.Visible = false;
            SavePanel.Visible = false;
            LathePanel.Visible = false;
            draw();
            switch (Selector.SelectedIndex) 
            {
                case 0: SpawnPanel.Visible = true; break;
                case 1:
                    TransformPanel.Visible = true;
                    TransformSelector.Items.Clear();
                    foreach (PolyHedron p in polyHedrons)
                        TransformSelector.Items.Add($"{p.Position.X} {p.Position.Y} {p.Position.Z}");
                    break;
                case 2:
                    EditPanel.Visible = true;
                    EditPolySelector.Items.Clear();
                    foreach (PolyHedron p in polyHedrons)
                        EditPolySelector.Items.Add($"{p.Position.X} {p.Position.Y} {p.Position.Z}");
                    break;
                case 3:
                    MirrorPanel.Visible = true;
                    MirrorPolySelector.Items.Clear();
                    foreach (PolyHedron p in polyHedrons)
                        MirrorPolySelector.Items.Add($"{p.Position.X} {p.Position.Y} {p.Position.Z}");
                    break;
                case 4:
                    //Саш, ты можешь обратиться к выбранному многограннику через polyHedrons[RotateSelectDropdown.SelectedIndex]
                    RotatePanel.Visible = true; 
                    RotateSelectDropdown.Items.Clear(); 
                    foreach (PolyHedron p in polyHedrons) 
                        RotateSelectDropdown.Items.Add($"{p.Position.X} {p.Position.Y} {p.Position.Z}"); 
                break;
                case 5:
                    PerspectivePanel.Visible = true; 
                    MirrorPolySelector.Items.Clear();
                    foreach (PolyHedron p in polyHedrons)
                        MirrorPolySelector.Items.Add($"{p.Position.X} {p.Position.Y} {p.Position.Z}");
                    break;
                case 6:
                    SavePanel.Visible = true; 
                    SaveBox.Items.Clear();
                    foreach (PolyHedron p in polyHedrons)
                        SaveBox.Items.Add($"{p.Position.X} {p.Position.Y} {p.Position.Z}");
                    break;
                case 7:
                    LathePanel.Visible = true;
                    LatheSelectorBox.Items.Clear();
                    foreach (PolyHedron p in polyHedrons)
                        LatheSelectorBox.Items.Add($"{p.Position.X} {p.Position.Y} {p.Position.Z}");
                    break;
                case 8:
                    DespawnPanel.Visible = true;
                    DespawnSelector.Items.Clear();
                    foreach (PolyHedron p in polyHedrons)
                        DespawnSelector.Items.Add($"{p.Position.X} {p.Position.Y} {p.Position.Z}");
                    break;
            }
        }
        //Создание------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void SpawnButton_Click(object sender, EventArgs e)
        {
            float X, Y, Z, R;
            if (SpawnSelector.SelectedIndex < 5 && float.TryParse(SpawnXBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out X) && float.TryParse(SpawnYBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out Y) && float.TryParse(SpawnZBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out Z) && float.TryParse(SpawnSizeBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out R))
                switch (SpawnSelector.SelectedIndex)
                {
                    /*Тетраэдр
                    Гексаэдр
                    Октаэдр
                    Икосаэдр
                    Додекаэдр*/
                    case 0:
                        polyHedrons.Add(PolyHedron.Tetrahedron(X, Y, Z, R));
                        break;
                    case 1:
                        polyHedrons.Add(PolyHedron.Hexahedron(X, Y, Z, R));
                        break;
                    case 2:
                        polyHedrons.Add(PolyHedron.Octahedron(X, Y, Z, R));
                        break;
                    case 3:
                        polyHedrons.Add(PolyHedron.Icosahedron(X, Y, Z, R));
                        break;
                    case 4:
                        polyHedrons.Add(PolyHedron.Dodecahedron(X, Y, Z, R));
                        break;
                }
            if (SpawnSelector.SelectedIndex == 5 && float.TryParse(SpawnXBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out X) && float.TryParse(SpawnYBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out Y) && float.TryParse(SpawnZBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out Z))
            {
                if (openModel.ShowDialog() == DialogResult.OK)
                {
                    string filepath = openModel.FileName;
                    if (filepath != null)
                        polyHedrons.Add(new PolyHedron(filepath, new Point3d(X, Y, Z), new Point3d(0, 0, 0), new Point3d(1, 1, 1)));
                }
            }
            draw();
        }
        private void Spawn_TextChanged(object sender, EventArgs e)
        {
            float X, Y, Z;
            if (float.TryParse(SpawnXBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out X) && float.TryParse(SpawnYBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out Y) && float.TryParse(SpawnZBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out Z))
            {
                ExtraPoints["PHDSelector"] = new Point3d(X, Y, Z);
            }
            draw();
        }

        //Преобразование
        private void TransformSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            textchanging = false;
                PolyHedron P = polyHedrons[TransformSelector.SelectedIndex];
                ExtraPoints["PHDSelector"] = new Point3d(P.Position.X, P.Position.Y, P.Position.Z);
                PositionX.Text = P.Position.X.ToString();
                PositionY.Text = P.Position.Y.ToString();
                PositionZ.Text = P.Position.Z.ToString();
                RotationX.Text = P.Rotation.X.ToString();
                RotationY.Text = P.Rotation.Y.ToString();
                RotationZ.Text = P.Rotation.Z.ToString();
                ScaleX.Text = P.Scale.X.ToString();
                ScaleY.Text = P.Scale.Y.ToString();
                ScaleZ.Text = P.Scale.Z.ToString();
                draw();
            textchanging = true;
        }
        private void Transform_TextChanged(object sender, EventArgs e)
        {
            if (textchanging)
            {
                PolyHedron P = polyHedrons[TransformSelector.SelectedIndex];
                float.TryParse(PositionX.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out P.Position.X);
                float.TryParse(PositionY.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out P.Position.Y);
                float.TryParse(PositionZ.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out P.Position.Z);
                float.TryParse(RotationX.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out P.Rotation.X);
                float.TryParse(RotationY.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out P.Rotation.Y);
                float.TryParse(RotationZ.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out P.Rotation.Z);
                float.TryParse(ScaleX.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out P.Scale.X);
                float.TryParse(ScaleY.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out P.Scale.Y);
                float.TryParse(ScaleZ.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out P.Scale.Z);
                ExtraPoints["PHDSelector"] = new Point3d(P.Position.X, P.Position.Y, P.Position.Z);
                int index = TransformSelector.SelectedIndex;
                TransformSelector.Items.RemoveAt(index);
                TransformSelector.Items.Insert(index, $"{P.Position.X} {P.Position.Y} {P.Position.Z}");
                TransformSelector.SelectedIndex = index;
                draw();
            }
        }

        //Изменение ----------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void EditPolySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            PolyHedron P = polyHedrons[EditPolySelector.SelectedIndex];
            ExtraPoints["PHDSelector"] = new Point3d(P.Position.X, P.Position.Y, P.Position.Z);
            draw();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            float X, Y, Z;
            if (float.TryParse(EditX.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out X) && float.TryParse(EditY.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out Y) && float.TryParse(EditZ.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out Z))
            switch (EditOpSelector.SelectedIndex) 
            {
                case 0:

                    polyHedrons[EditPolySelector.SelectedIndex].Apply(new Matrix(4,4,1,0,0,0,0,1,0,0,0,0,1,0,X,Y,Z,1));
                    break;
                    case 1:

                        double RX = Math.PI * X / 180, RY = Math.PI * Y / 180, RZ = Math.PI * Z / 180;
                        polyHedrons[EditPolySelector.SelectedIndex].Apply(new Matrix(4, 4,
                            (float)(Math.Cos(RY) * Math.Cos(RZ)), (float)(Math.Cos(RY) * Math.Sin(RZ)), (float)(-Math.Sin(RY)), 0,
                            (float)((Math.Sin(RX) * Math.Sin(RY) * Math.Cos(RZ) - Math.Cos(RX) * Math.Sin(RZ))), (float)((Math.Sin(RX) * Math.Sin(RY) * Math.Sin(RZ) + Math.Cos(RX) * Math.Cos(RZ))), (float)(Math.Sin(RX) * Math.Cos(RY)), 0,
                            (float)((Math.Cos(RX) * Math.Sin(RY) * Math.Cos(RZ) + Math.Sin(RX) * Math.Sin(RZ))), (float)((Math.Cos(RX) * Math.Sin(RY) * Math.Sin(RZ) - Math.Sin(RX) * Math.Cos(RZ))), (float)(Math.Cos(RX) * Math.Cos(RY)), 0,
                            0, 0, 0, 1
                            ));
                        break;
                    case 2:

                        polyHedrons[EditPolySelector.SelectedIndex].Apply(new Matrix(4, 4, X, 0, 0, 0, 0, Y, 0, 0, 0, 0, Z, 0, 0, 0, 0, 1));
                        break;
                }
            draw();
        }


        private void MirrorPolySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            PolyHedron P = polyHedrons[MirrorPolySelector.SelectedIndex];
            ExtraPoints["PHDSelector"] = new Point3d(P.Position.X, P.Position.Y, P.Position.Z);
            draw();
        }

        //Поворот ------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void RotateSelectDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            PolyHedron P = polyHedrons[RotateSelectDropdown.SelectedIndex];
            ExtraPoints["PHDSelector"] = new Point3d(P.Position.X, P.Position.Y, P.Position.Z);
            draw();
        }
        private void RotateButton_Click(object sender, EventArgs e)
        {
            float X1,Y1,Z1,X2,Y2,Z2,Deg,DegX;
            if (float.TryParse(RotatePoint1XBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out X1) && float.TryParse(RotatePoint1YBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out Y1) && float.TryParse(RotatePoint1ZBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out Z1) &&
                float.TryParse(RotatePoint2XBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out X2) && float.TryParse(RotatePoint2YBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out Y2) && float.TryParse(RotatePoint2ZBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out Z2) &&
                float.TryParse(RotateDegBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out Deg)
                )
            {
                DegX = (float)(Deg * Math.PI / 180);

                // Точки оси поворота
                Point3d axisPoint1 = new Point3d(X1, Y1, Z1);
                Point3d axisPoint2 = new Point3d(X2, Y2, Z2);

                RotateAroundAxis(polyHedrons[RotateSelectDropdown.SelectedIndex], axisPoint1, axisPoint2, DegX);
                draw();
            }
        }

        private void RotateAroundAxis(PolyHedron poly, Point3d axisPoint1, Point3d axisPoint2, float angle)
        {
            // Вектор оси поворота
            Point3d axis = new Point3d(axisPoint2.X - axisPoint1.X, axisPoint2.Y - axisPoint1.Y, axisPoint2.Z - axisPoint1.Z);
            float conlen = axis.Length();
            axis.X /= conlen;
            axis.Y /= conlen;
            axis.Z /= conlen;

            float cosTheta = (float)Math.Cos(angle);
            float sinTheta = (float)Math.Sin(angle);

            Matrix rotationMatrix = new Matrix(4, 4,
            axis.X * axis.X * (1 - cosTheta) + cosTheta, axis.X * axis.Y * (1 - cosTheta) + axis.Z * sinTheta, axis.X * axis.Z * (1 - cosTheta) - axis.Y * sinTheta, 0,
             axis.X * axis.Y * (1 - cosTheta) - axis.Z * sinTheta, axis.Y * axis.Y * (1 - cosTheta) + cosTheta, axis.Y * axis.Z * (1 - cosTheta) + axis.X * sinTheta, 0,
            axis.X * axis.Z * (1 - cosTheta) + axis.Y * sinTheta, axis.Y * axis.Z * (1 - cosTheta) - axis.X * sinTheta, axis.Z * axis.Z * (1 - cosTheta) + cosTheta, 0,
            0, 0, 0, 1
            );

            poly.Apply(rotationMatrix);
        }


        //Удаление -----------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void DespawnSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            PolyHedron P = polyHedrons[DespawnSelector.SelectedIndex];
            ExtraPoints["PHDSelector"] = new Point3d(P.Position.X, P.Position.Y, P.Position.Z);
            draw();
        }

        private void DespawnButton_Click(object sender, EventArgs e)
        {
            if (DespawnSelector.SelectedIndex != -1)
            {
                ExtraPoints.Clear();
                polyHedrons.RemoveAt(DespawnSelector.SelectedIndex);
                DespawnSelector.Items.RemoveAt(DespawnSelector.SelectedIndex);
                draw();
            }
        }

        private void MirrorButton_Click(object sender, EventArgs e)
        {
            float shift;
            if (float.TryParse(MirrorPlaneBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out shift))
            switch (MirrorAxisSelector.SelectedIndex)
            {
                case 0:
                    polyHedrons[MirrorPolySelector.SelectedIndex].Scale.X *= -1;
                        polyHedrons[MirrorPolySelector.SelectedIndex].Position.X = shift * 2 - polyHedrons[MirrorPolySelector.SelectedIndex].Position.X;
                    break;
                case 1:
                    polyHedrons[MirrorPolySelector.SelectedIndex].Scale.Y *= -1;
                        polyHedrons[MirrorPolySelector.SelectedIndex].Position.Y = shift * 2 - polyHedrons[MirrorPolySelector.SelectedIndex].Position.Y;
                    break;
                case 2:
                    polyHedrons[MirrorPolySelector.SelectedIndex].Scale.Z *= -1;
                        polyHedrons[MirrorPolySelector.SelectedIndex].Position.Z = shift * 2 - polyHedrons[MirrorPolySelector.SelectedIndex].Position.Z;
                    break;
            }
            draw();
        }

        private void PerspectiveBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (PerspectiveBox.SelectedIndex) 
            {
                case 0:
                    camera.ProjectionMatrix = new Matrix(4, 4, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);
                    break;
                case 1:
                    camera.ProjectionMatrix = new Matrix(4, 4, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1f / 200, 0, 0, 0, 0);
                    break;
            }
            draw();
        }

        private void RotatePoint_TextChanged(object sender, EventArgs e)
        {
            Point3d a = new Point3d();
            Point3d b = new Point3d();
            if(
            float.TryParse(RotatePoint1XBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out a.X) &&
            float.TryParse(RotatePoint1YBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out a.Y) &&
            float.TryParse(RotatePoint1ZBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out a.Z) &&
            float.TryParse(RotatePoint2XBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out b.X) &&
            float.TryParse(RotatePoint2YBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out b.Y) &&
            float.TryParse(RotatePoint2ZBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out b.Z)
            )
            ExtraLines["RotationAxis"] = new KeyValuePair<Point3d, Point3d>(a, b);
            draw();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveBox.SelectedIndex != -1 && saveModel.ShowDialog() == DialogResult.OK)
            {
                string fname = saveModel.FileName;
                polyHedrons[SaveBox.SelectedIndex].Save(fname);
            }    
        }

        private void SaveBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PolyHedron P = polyHedrons[SaveBox.SelectedIndex];
            ExtraPoints["PHDSelector"] = new Point3d(P.Position.X, P.Position.Y, P.Position.Z);
            draw();
        }

        private void BevelSelectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PolyHedron P = polyHedrons[LatheSelectorBox.SelectedIndex];
            ExtraPoints["PHDSelector"] = new Point3d(P.Position.X, P.Position.Y, P.Position.Z);
            draw();
        }

        private void LatheButton_Click(object sender, EventArgs e)
        {
            int div;
            if (LatheAxisBox.SelectedIndex != -1 && LatheSelectorBox.SelectedIndex != -1 && int.TryParse(LatheDivisionsBox.Text,out div))
            {
                switch (LatheAxisBox.SelectedIndex)
                {
                    case 0:
                        polyHedrons.Add(PolyHedron.SpinShape(polyHedrons[LatheSelectorBox.SelectedIndex].points, div));
                        break;
                    case 1:
                        polyHedrons.Add(PolyHedron.SpinShape(polyHedrons[LatheSelectorBox.SelectedIndex].points, div, "Y"));
                        break;
                    case 2:
                        polyHedrons.Add(PolyHedron.SpinShape(polyHedrons[LatheSelectorBox.SelectedIndex].points, div, "Z"));
                        break;
                }
                LatheSelectorBox.Items.Add($"{polyHedrons.Last().Position.X} {polyHedrons.Last().Position.Y} {polyHedrons.Last().Position.Z}");
                draw();
            }
        }
    }

    public class Camera
    {
        public Point3d camPos = new Point3d(0, 0, 0);
        public Point3d camRot = new Point3d(0, 0, 0);
        public float camDist = 200;
        public Point3d lookvector;
        public Matrix ProjectionMatrix = new Matrix(4, 4, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);
        public Matrix ViewMatrix;
        public PointF viewport;
        //TODO
        public float projectionDistance;

        public Camera(Point3d camPos, Point3d camRot, float camDist, PointF viewport)
        {
            this.camPos = camPos;
            this.camRot = camRot;
            this.camDist = camDist;
            this.viewport = viewport;
        }

        public void update()
        {
            double RX = -Math.PI * camRot.X / 180, RY = -Math.PI * camRot.Y / 180;

            ViewMatrix = new Matrix(4, 4,
                (float)(Math.Cos(RY)), (float)(Math.Sin(RX) * Math.Sin(RY)), (float)(-Math.Cos(RX) * Math.Sin(RY)), 0,
                0, (float)((Math.Cos(RX))), (float)(Math.Sin(RX)), 0,
                (float)((Math.Sin(RY))), (float)((-Math.Sin(RX) * Math.Cos(RY))), (float)(Math.Cos(RX) * Math.Cos(RY)), 0,
                (float)(-camPos.X * Math.Cos(RY) - camPos.Z * Math.Sin(RY)), (float)(-camPos.X * (Math.Sin(RX) * Math.Sin(RY)) - camPos.Y * (Math.Cos(RX)) - camPos.Z * (-Math.Sin(RX) * Math.Cos(RY))), (float)(-camPos.X * (-Math.Cos(RX) * Math.Sin(RY)) - camPos.Y * (Math.Sin(RX)) - camPos.Z * (Math.Cos(RX) * Math.Cos(RY))) + camDist, 1);
            RX = Math.PI * camRot.X / 180; RY = Math.PI * camRot.Y / 180;
            lookvector = (Point3d)(new Point3d(0, 0, 1) * new Matrix(4, 4,
                (float)Math.Cos(RY), 0, (float)Math.Sin(RY), 0,
                (float)(Math.Sin(RX) * Math.Sin(RY)), (float)Math.Cos(RX), (float)(Math.Sin(RX) * Math.Cos(RY)), 0,
                (float)(Math.Cos(RX) * Math.Sin(RY)), (float)(-Math.Sin(RX)), (float)(Math.Cos(RX) * Math.Cos(RY)), 0,
                0, 0, 0, 1));
            lookvector.normalize();
        }
    }
    /// <summary>
    /// Матрица
    /// </summary>
    public struct Matrix
    {
        private float[,] _matrix;
        public int X => _matrix.GetLength(0);
        public int Y => _matrix.GetLength(1);
        public float this[int x, int y]
        {
            get { return _matrix[x, y]; }
            set { _matrix[x, y] = value; }
        }
        public Matrix(int x, int y)
        {
            _matrix = new float[x, y];
        }
        public Matrix(int x, int y, params float[] values)
        {
            _matrix = new float[x, y];
            for (int i = 0; i < Math.Min(values.Length,x*y);i++)
            {
                _matrix[i%x,i/x] = values[i];
            }
        }
        public Matrix(float[,] matrix)
        {
            _matrix = matrix;
        }
        public static implicit operator Matrix(float[,] matrix) => new Matrix(matrix);
        public static Matrix operator* (Matrix left, Matrix right)
        {
            if (left.X != right.Y)
                throw new ArgumentException("Cannot multiply matrices with different width and height");
            Matrix result = new Matrix(right.X,left.Y);
            for (int x = 0; x < right.X; x++)
                for (int y = 0; y < left.Y; y++)
                {
                    result[x, y] = 0;
                    for (int i = 0; i < right.Y; i++)
                        result[x, y] += left[i,y] * right[x,i];
                }
            return result;
        }

        public static explicit operator Point3d(Matrix matrix)
        {
            return new Point3d(matrix._matrix[0, 0] / matrix._matrix[3,0], matrix._matrix[1, 0] / matrix._matrix[3, 0], matrix._matrix[2, 0] / matrix._matrix[3,0]);
        }
    }
    /// <summary>
    /// Точка.
    /// </summary>
    public struct Point3d
    {
        public float X;
        public float Y;
        public float Z;
        public override bool Equals(object obj)
        {
            if (obj is Point3d)
            {
                var a = (Point3d)obj;
                return (X == a.X) && (Y == a.Y) && (Z == a.Z);
            }
            return false;
        }
        public override int GetHashCode() => base.GetHashCode();
        public static bool operator ==(Point3d left, Point3d right) => (left.X == right.X) && (left.Y == right.Y) && (left.Z == right.Z);
        public static bool operator !=(Point3d left, Point3d right) => !((left.X == right.X) && (left.Y == right.Y) && (left.Z == right.Z));

        public static Point3d operator +(Point3d left, Point3d right) => new Point3d(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        public static Point3d operator -(Point3d left, Point3d right) => new Point3d(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        public static Point3d operator *(Point3d left, float right) => new Point3d(left.X * right, left.Y * right, left.Z * right);
        public static Point3d operator /(Point3d left, float right) => new Point3d(left.X / right, left.Y / right, left.Z / right);
        
        public static float dot(Point3d left, Point3d right) => left.X*right.X + left.Y*right.Y + left.Z*right.Z;
        public static Point3d cross(Point3d left, Point3d right) => new Point3d(left.Y * right.Z - left.Z * right.Y, left.Z * right.X - left.X * right.Z, left.X * right.Y - left.Y * right.X);
        public static float cos(Point3d left, Point3d right) => dot(left, right)/(left.Length()*right.Length());
        public static float sin(Point3d left, Point3d right) => (float)Math.Sqrt(1-Math.Pow(cos(left,right),2));
        public Point3d(float x, float y, float z)
        {
            X = x; Y = y; Z = z;
        }
        public static implicit operator Matrix(Point3d point)
        {
            return new Matrix(4,1,point.X,point.Y,point.Z,1);
        }
        public static implicit operator PointF(Point3d point)
        {
            return new PointF(point.X, point.Y);
        }
        public float Length()
        {
            return (float)Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        public void normalize()
        {
            float len = Length();
            X /= len; Y /= len; Z /= len;
        }
    }   
    
    /// <summary>
    /// Многогранник
    /// </summary>
    public class PolyHedron
    {/// <summary>
     /// Многоугольник
     /// </summary>
        public class Polygon
        {
            /// <summary>
            /// positions of the points in the polyhedron. This is going to be "fun"
            /// </summary>
            public List<int> points;
            public List<int> pointnormals;
            public int normal;
            public Pen pen;

            public Polygon()
            {
                points = new List<int>();
                pointnormals = new List<int>();
                pen = new Pen(Color.Black);
            }
            public Polygon(params int[] points)
            {
                this.points = points.ToList();
                pointnormals = new List<int>();
                pen = new Pen(Color.Black);
            }

            public Polygon(Color color, params int[] points)
            {
                this.points = points.ToList();
                pointnormals = new List<int>();
                pen = new Pen(color);
            }
            /// <summary>
            /// Get the center of the polygon in relation to the center of the polyhedron
            /// </summary>
            /// <param name="polyhedronPoints"></param>
            /// <returns></returns>
            public Point3d Center(ref List<Point3d> polyhedronPoints)
            {
                Point3d res = new Point3d();
                foreach(int ind in points)
                {
                    res += polyhedronPoints[ind];
                }
                res /= points.Count();
                return res;
            }
            /// <summary>
            /// FUCK THIS. THIS WORKS ONLY FOR CONVEX POLYGONS.
            /// </summary>
            /// <param name="polyhedronPoints"></param>
            /// <returns></returns>
            public Point3d Normal(ref List<Point3d> polyhedronPoints)
            {
                Point3d vect = Point3d.cross(polyhedronPoints[points[1]] - polyhedronPoints[points[0]], polyhedronPoints[points[2]] - polyhedronPoints[points[0]]);
                vect.normalize();
                Point3d cent = Center(ref polyhedronPoints);
                return Point3d.dot(vect,cent) > 0 ? vect : vect * -1;
            }
        }
        public Point3d Position;
        public Point3d Rotation;
        public Point3d Scale;
        public List<Polygon> polygons;
        public List<Point3d> normals;
        public List<Point3d> points;
        public List<Point3d> verticenormals;
        public PolyHedron(string filePath, Point3d position, Point3d rotation, Point3d scale)
        {
            Position = position;
            Rotation = rotation;
            Scale = scale;
            points = new List<Point3d>();
            verticenormals = new List<Point3d>();
            normals = new List<Point3d>();
            polygons = new List<Polygon>();
            using (FileStream fstream = File.OpenRead(filePath))
            {
                using (StreamReader reader = new StreamReader(fstream))
                {
                    String line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        line = Regex.Replace(line, "\\s+", " ").Trim();
                        if (line.Length > 0 && line[0] != '#')
                        {
                            string[] split = line.Split(' ');
                            float x, y, z;
                            switch (split[0].ToLower())
                            {
                                case "v":
                                    x = float.Parse(split[1], NumberStyles.Any, CultureInfo.InvariantCulture);
                                    y = float.Parse(split[2], NumberStyles.Any, CultureInfo.InvariantCulture);
                                    z = float.Parse(split[3], NumberStyles.Any, CultureInfo.InvariantCulture);
                                    points.Add(new Point3d(x, y, z));
                                    break;
                                case "vt":
                                    //TODO ADD TEXTURES
                                    break;
                                case "vn":
                                    x = float.Parse(split[1], NumberStyles.Any, CultureInfo.InvariantCulture);
                                    y = float.Parse(split[2], NumberStyles.Any, CultureInfo.InvariantCulture);
                                    z = float.Parse(split[3], NumberStyles.Any, CultureInfo.InvariantCulture);
                                    verticenormals.Add(new Point3d(x, y, z));
                                    break;
                                case "vp":
                                    //TODO ADD PARAMETER VERTICIES
                                    break;
                                case "f":
                                    Polygon polygon = new Polygon();
                                    for (int i = 1; i < split.Length; i++)
                                    {
                                        string[] split2 = split[i].Split('/');
                                        polygon.points.Add(int.Parse(split2[0])-1);
                                        if (split2.Length >= 3)
                                            polygon.pointnormals.Add(int.Parse(split2[2]) - 1);
                                    }
                                    polygons.Add(polygon);
                                    break;
                            }
                        }
                    }
                }
            }
            foreach (Polygon polygon in polygons)
            {
                Point3d n = polygon.Normal(ref points);
                polygon.normal = normals.Count();
                if (Point3d.dot(n, verticenormals[polygon.pointnormals[0]]) > 0)
                    normals.Add(n);
                else
                    normals.Add(n * -1);
            }

            foreach (Point3d p in points)
            {

            }
        }
        public PolyHedron(Point3d[] points, params Polygon[] polygons)
        {
            Position = new Point3d();
            Rotation = new Point3d();
            Scale = new Point3d(1,1,1);
            this.points = points.ToList();
            this.polygons = polygons.ToList();
            calculateNormals();
        }
        public PolyHedron(Point3d position, Point3d rotation, Point3d scale, Point3d[] points, params Polygon[] polygons)
        {
            Position = position;
            Rotation = rotation;
            Scale = scale;
            this.points = points.ToList();
            this.polygons = polygons.ToList();
            calculateNormals();
        }
        public PolyHedron(Point3d position, Point3d[] points, params Polygon[] polygons)
        {
            Position = position;
            Rotation = new Point3d();
            Scale = new Point3d(1, 1, 1);
            this.points = points.ToList();
            this.polygons = polygons.ToList();
            calculateNormals();
        }
        public void Add(Polygon polygon)
        {
            polygons.Add(polygon);
            polygon.normal = normals.Count();
            normals.Add(polygon.Normal(ref this.points));
        }
        /// <summary>
        /// Применяет матрицу к полигону. Изменяет сам многогранник, НЕ ЕГО ОТОБРАЖЕНИЕ. Не проверял, но должно работать.
        /// </summary>
        /// <param name="m"></param>
        public void Apply(Matrix m)
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i] = (Point3d)(points[i] * m);
            }
        }
        public void Save(string filePath)
        {
            using (FileStream fstream = File.OpenWrite(filePath))
            {
                using (StreamWriter writer = new StreamWriter(fstream))
                {
                    foreach (Point3d point in this.points)
                    {
                        writer.WriteLine($"v {point.X.ToString(CultureInfo.InvariantCulture)} {point.Y.ToString(CultureInfo.InvariantCulture)} {point.Z.ToString(CultureInfo.InvariantCulture)}");
                    }

                    foreach (Polygon poly in this.polygons)
                    {
                        StringBuilder builder = new StringBuilder();
                        for (int i = 0; i < poly.points.Count(); i++)
                        {
                            builder.Append($" {(poly.points[i] + 1).ToString(CultureInfo.InvariantCulture)}//{(poly.pointnormals[i] + 1).ToString(CultureInfo.InvariantCulture)}");
                        }
                        writer.WriteLine($"f{builder.ToString()}");
                    } 
                    
                    foreach (Point3d point in this.verticenormals)
                    {
                        writer.WriteLine($"vn {point.X.ToString(CultureInfo.InvariantCulture)} {point.Y.ToString(CultureInfo.InvariantCulture)} {point.Z.ToString(CultureInfo.InvariantCulture)}");
                    }
                }
            }
        }
        /// <summary>
        /// Вывод
        /// </summary>
        /// <param name="g"></param>
        /// <param name="View"> Матрица камеры</param>
        /// <param name="Projection"> Матрица проекций</param>
        public void draw(Graphics g, Camera camera)
        {
            double RX = Math.PI * Rotation.X / 180, RY = Math.PI * Rotation.Y / 180, RZ = Math.PI * Rotation.Z / 180;
            Matrix RotationMatrix = new Matrix(4, 4,
                (float)(Scale.X*Math.Cos(RY)*Math.Cos(RZ)), (float)(Scale.X*Math.Cos(RY)*Math.Sin(RZ)), (float)(-Scale.X*Math.Sin(RY)), 0,
                (float)(Scale.Y * (Math.Sin(RX) * Math.Sin(RY) * Math.Cos(RZ) - Math.Cos(RX) * Math.Sin(RZ))), (float)(Scale.Y * (Math.Sin(RX) * Math.Sin(RY) * Math.Sin(RZ) + Math.Cos(RX) * Math.Cos(RZ))), (float)(Scale.Y * Math.Sin(RX) * Math.Cos(RY)), 0,
                (float)(Scale.Z * (Math.Cos(RX) * Math.Sin(RY) * Math.Cos(RZ) + Math.Sin(RX) * Math.Sin(RZ))), (float)(Scale.Z * (Math.Cos(RX) * Math.Sin(RY) * Math.Sin(RZ) - Math.Sin(RX) * Math.Cos(RZ))), (float)(Scale.Z * Math.Cos(RX) * Math.Cos(RY)), 0,
                0, 0, 0, 1);
            Matrix ShiftMatrix = new Matrix(4,4,
                1,0,0,0,
                0,1,0,0,
                0,0,1,0,
                Position.X, Position.Y, Position.Z, 1
                );
            foreach (var polygon in polygons) {
                Point3d temp = (Point3d)(normals[polygon.normal] * RotationMatrix);
                if (Point3d.dot(temp, camera.lookvector) < 0)
                {
                    Matrix oldpnt = (points[polygon.points.Last()] * RotationMatrix * ShiftMatrix * camera.ViewMatrix * camera.ProjectionMatrix);
                    for (int i = 0; i < polygon.points.Count; i++)
                    {
                        Matrix pnt = (points[polygon.points[i]] * RotationMatrix * ShiftMatrix * camera.ViewMatrix * camera.ProjectionMatrix);
                        if (oldpnt[3, 0] > 0 && pnt[3, 0] > 0)
                            g.DrawLine(polygon.pen, oldpnt[0, 0] / oldpnt[3, 0] + camera.viewport.X / 2, -oldpnt[1, 0] / oldpnt[3, 0] + camera.viewport.Y / 2, pnt[0, 0] / pnt[3, 0] + camera.viewport.X / 2, -pnt[1, 0] / pnt[3, 0] + camera.viewport.Y / 2);
                        oldpnt = pnt;
                    }
                }
            }
        }
        //use index for referencing points
        //mirror for in-world plane

        protected void calculateNormals()
        {
            normals = new List<Point3d>();
            verticenormals = new List<Point3d>();
            int[] pointcnt = new int[points.Count()];

            for (int i = 0; i < points.Count(); i++)
            {
                verticenormals.Add(new Point3d());
            }
            foreach (Polygon a in polygons)
            {
                a.normal = normals.Count();
                normals.Add(a.Normal(ref this.points));
                foreach (int i in a.points)
                {
                    a.pointnormals.Add(i);
                    verticenormals[i] += normals.Last();
                    pointcnt[i]++;
                }
            }
            for (int i = 0; i < points.Count(); i++)
            {
                verticenormals[i] /= pointcnt[i];
            }
        }

        /// <summary>
        /// Тетраэдр
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Z"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static PolyHedron Tetrahedron(float X, float Y, float Z, float n)
        {
            Point3d point1 = new Point3d(-n, -n, -n);
            Point3d point2 = new Point3d(n, n, -n);
            Point3d point3 = new Point3d(-n, n, n);
            Point3d point4 = new Point3d(n, -n, n);
            return new PolyHedron(new Point3d(X,Y,Z), new Point3d[]{point1,point2,point3,point4 }, new Polygon(0, 2, 3), new Polygon(1, 2, 3), new Polygon(0, 1, 2), new Polygon(0, 1, 3));
        }
        /// <summary>
        /// Гексаэдр
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Z"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static PolyHedron Hexahedron(float X, float Y, float Z, float n)
        {
            Point3d point1 = new Point3d(-n, -n, n);
            Point3d point2 = new Point3d(-n, n, n);
            Point3d point3 = new Point3d(n, n, n);
            Point3d point4 = new Point3d(n, -n, n);
            Point3d point5 = new Point3d(n, -n, -n);
            Point3d point6 = new Point3d(n, n, -n);
            Point3d point7 = new Point3d(-n, n, -n);
            Point3d point8 = new Point3d(-n, -n, -n);
            return new PolyHedron(new Point3d(X, Y, Z), new Point3d[] { point1, point2, point3, point4, point5, point6, point7, point8 }, new Polygon(0, 1, 2, 3), new Polygon(2, 3, 4, 5), new Polygon(4, 5, 6, 7), new Polygon(6, 7, 0, 1), new Polygon(0, 3, 4, 7), new Polygon(1, 2, 5, 6));
        }
        /// <summary>
        /// Октаэдр
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Z"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static PolyHedron Octahedron(float X, float Y, float Z, float n)
        {
            const float lenmult = 1.41421356237f;
            Point3d point1 = new Point3d(lenmult * n, 0, 0);
            Point3d point2 = new Point3d(-lenmult * n, 0, 0);
            Point3d point3 = new Point3d(0, lenmult * n, 0);
            Point3d point4 = new Point3d(0, -lenmult * n, 0);
            Point3d point5 = new Point3d(0, 0, lenmult * n);
            Point3d point6 = new Point3d(0, 0, -lenmult * n);
            return new PolyHedron(new Point3d(X, Y, Z), new Point3d[] { point1, point2, point3, point4, point5, point6}, new Polygon(0, 2, 4), new Polygon(0, 2, 5), new Polygon(0, 3, 4), new Polygon(0, 3, 5), new Polygon(1, 2, 4), new Polygon(1, 2, 5), new Polygon(1, 3, 4), new Polygon(1, 3, 5));
        }
        /// <summary>
        /// Икосаэдр
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Z"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static PolyHedron Icosahedron(float X, float Y, float Z, float n)
        {
            const float GR = 1.61803398875f;
            Point3d point1 = new Point3d(0, n, GR * n);
            Point3d point2 = new Point3d(0, n, -GR * n);
            Point3d point3 = new Point3d(0, -n, GR * n);
            Point3d point4 = new Point3d(0, -n, -GR * n);
            Point3d point5 = new Point3d(n, GR * n, 0);
            Point3d point6 = new Point3d(n, -GR * n, 0);
            Point3d point7 = new Point3d(-n, GR * n, 0);
            Point3d point8 = new Point3d(-n, -GR * n, 0);
            Point3d point9 = new Point3d(GR * n, 0, n);
            Point3d point10 = new Point3d(-GR * n, 0, n);
            Point3d point11 = new Point3d(GR * n, 0, -n);
            Point3d point12 = new Point3d(-GR * n, 0, -n);
            return new PolyHedron(new Point3d(X, Y, Z), 
                new Point3d[] { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10, point11, point12 },
                new Polygon(0, 2, 8), new Polygon(0, 2, 9), 
                new Polygon(1, 3, 10), new Polygon(1, 3, 11),
                new Polygon(4, 6, 0), new Polygon(4, 6, 1), 
                new Polygon(5, 7, 2), new Polygon(5, 7, 3),
                new Polygon(8, 10, 4), new Polygon(8, 10, 5),
                new Polygon(9, 11, 6), new Polygon(9, 11, 7),

                new Polygon(0, 8, 4), new Polygon(0, 9, 6),
                new Polygon(2, 8, 5), new Polygon(2, 9, 7),
                new Polygon(1, 10, 4), new Polygon(1, 11, 6),
                new Polygon(3, 10, 5), new Polygon(3, 11, 7)
                );
        }
        /// <summary>
        /// Додекаэдр
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Z"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static PolyHedron Dodecahedron(float X, float Y, float Z, float n)
        {
            float N = n/2.7f;
            const float GR = 1.61803398875f;
            Point3d point1 = new Point3d(GR * N, 0, (2 * GR + 1) * N);
            Point3d point2 = new Point3d(-GR * N, 0, (2 * GR + 1) * N);
            Point3d point3 = new Point3d(GR * N, 0, -(2 * GR + 1) * N);
            Point3d point4 = new Point3d(-GR * N, 0, -(2 * GR + 1) * N);
            Point3d point5 = new Point3d(0, (2 * GR + 1) * N, GR * N);
            Point3d point6 = new Point3d(0, (2 * GR + 1) * N, -GR * N);
            Point3d point7 = new Point3d(0, -(2 * GR + 1) * N, GR * N);
            Point3d point8 = new Point3d(0, -(2 * GR + 1) * N, -GR * N);
            Point3d point9 = new Point3d((2 * GR + 1) * N, GR * N, 0);
            Point3d point10 = new Point3d((2 * GR + 1) * N, -GR * N, 0);
            Point3d point11 = new Point3d(-(2 * GR + 1) * N, GR * N, 0);
            Point3d point12 = new Point3d(-(2 * GR + 1) * N, -GR * N, 0);

            Point3d point13 = new Point3d((GR+1) * N, (GR + 1) * N, (GR + 1) * N);
            Point3d point14 = new Point3d(-(GR + 1) * N, (GR + 1) * N, (GR + 1) * N);
            Point3d point15 = new Point3d((GR + 1) * N, -(GR + 1) * N, (GR + 1) * N);
            Point3d point16 = new Point3d(-(GR + 1) * N, -(GR + 1) * N, (GR + 1) * N);
            Point3d point17 = new Point3d((GR + 1) * N, (GR + 1) * N, -(GR + 1) * N);
            Point3d point18 = new Point3d(-(GR + 1) * N, (GR + 1) * N, -(GR + 1) * N);
            Point3d point19 = new Point3d((GR + 1) * N, -(GR + 1) * N, -(GR + 1) * N);
            Point3d point20 = new Point3d(-(GR + 1) * N, -(GR + 1) * N, -(GR + 1) * N);
            return new PolyHedron(new Point3d(X, Y, Z),
                new Point3d[] { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10, point11, point12, point13, point14, point15, point16, point17, point18, point19, point20 },
                new Polygon(12, 0, 1, 13,4),
                new Polygon(12, 0, 14, 9, 8),
                new Polygon(0, 14, 6, 15, 1),
                new Polygon(1,15, 11, 10, 13),
                new Polygon(14, 6, 7, 18, 9),
                new Polygon(12, 4, 5, 16, 8),
                new Polygon(13, 4, 5, 17, 10),
                new Polygon(9, 8, 16,2, 18),
                new Polygon(6, 15, 11, 19, 7),
                new Polygon(3,19, 11, 10, 17),
                new Polygon(3, 19, 7, 18, 2),
                new Polygon(3,2, 16, 5,  17)
                );
        }

        public static PolyHedron SpinShape(List<Point3d> shape, int divisions, string axis = "X")
        {
            PolyHedron result = new PolyHedron(shape.ToArray());
            float angle = (float)(2 * Math.PI / divisions);
            Matrix rotMatrix;
            switch (axis)
            {
                case "X":
                    rotMatrix = new Matrix(4, 4, 1, 0, 0, 0, 0, (float)Math.Cos(angle), (float)Math.Sin(angle), 0, 0, (float)Math.Sin(angle) * -1, (float)Math.Cos(angle), 0, 0, 0, 0, 1);
                    break;
                case "Y":
                    rotMatrix = new Matrix(4, 4, (float)Math.Cos(angle), 0, (float)Math.Sin(angle), 0, 0, 1, 0, 0, (float)Math.Sin(angle) * -1, 0, (float)Math.Cos(angle), 0, 0, 0, 0, 1);
                    break;
                case "Z":
                    rotMatrix = new Matrix(4, 4, (float)Math.Cos(angle), (float)Math.Sin(angle), 0, 0, (float)Math.Sin(angle) * -1, (float)Math.Cos(angle), 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);
                    break;
                default:
                    throw new ArgumentException("Invalid axis");
            }

            var PointsToAdd = shape;
            var PolygonsToAdd = new List<Polygon>();

            for (int i = 0; i < divisions+1; i++)
            {
                result.Apply(rotMatrix);
                int startIndex = PointsToAdd.Count;
                PointsToAdd = PointsToAdd.Concat(result.points).ToList();
                for (int j = 0; j < shape.Count-1; j++)
                {
                    PolygonsToAdd.Add(new Polygon(i*shape.Count+j, i * shape.Count + j + 1, (i+1) * shape.Count + j+1, (i+1) * shape.Count + j));
                }
                PolygonsToAdd.Add(new Polygon((i+1) * shape.Count-1, i * shape.Count, i * shape.Count+ shape.Count, (i+1) * shape.Count + shape.Count - 1));
            }
            result = new PolyHedron(PointsToAdd.ToArray(), PolygonsToAdd.ToArray());

            return result;
        }

        public static PolyHedron BuildSurfaceSegment(Func<float, float, float> f, float x0, float x1, float y0, float y1, int numSteps)
        {
            List<Point3d> Points = new List<Point3d>();

            float stepX = (x1 - x0) / numSteps;
            float stepY = (y1 - y0) / numSteps;


            for (int i = 0; i <= numSteps; i++)
            {
                float x = x0 + i * stepX;
                for (int j = 0; j <= numSteps; j++)
                {
                    float y = y0 + j * stepY;
                    float z = f(x, y);
                    Points.Add(new Point3d(x-(x0+x1)/2, y-(y0+y1)/2, z));
                }
            }


            PolyHedron polyHedron = new PolyHedron(Points.ToArray());


            for (int i = 0; i < numSteps; i++)
            {
                for (int j = 0; j < numSteps; j++)
                {
                    polyHedron.Add(new PolyHedron.Polygon(i + j * (numSteps + 1), i + 1 + j * (numSteps + 1), i + (1 + j) * (numSteps + 1)));
                    polyHedron.Add(new PolyHedron.Polygon(i + 1 + j * (numSteps + 1), i + 1 + (1 + j) * (numSteps + 1), i + (1 + j) * (numSteps + 1)));
                }
            }


            return polyHedron;
        }
    }
}
