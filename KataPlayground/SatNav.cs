using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace kata_playground
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return ((Point)obj).x == this.x && ((Point)obj).y == this.y;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"({this.x}, {this.y})";
        }
    }

    public partial class Kata
    {
        private static readonly List<string> compass = new List<string> { "NORTH", "EAST", "SOUTH", "WEST" };

        private static void MoveHeading(string heading, ref int x, ref int y, int distance)
        {
            switch (heading)
            {
                case "NORTH":
                    y += distance;
                    break;
                case "SOUTH":
                    y -= distance;
                    break;
                case "EAST":
                    x += distance;
                    break;
                case "WEST":
                    x -= distance;
                    break;
                default:
                    throw new InvalidOperationException("Cannot move a heading outside of NORTH/EAST/SOUTH/WEST");
            }
        }

        private static string NewHeading(string heading, string direction)
        {
            switch (direction)
            {
                case "LEFT":
                    var idx = compass.FindIndex(h => h == heading) - 1;
                    return compass.ElementAt(idx < 0 ? idx + 4 : idx);
                case "RIGHT":
                    return compass.ElementAt((compass.FindIndex(h => h == heading) + 1) % 4);
                case "AROUND":
                    return compass.ElementAt((compass.FindIndex(h => h == heading) + 2) % 4);
                default:
                    throw new InvalidOperationException("Cannot take direction outside of LEFT/RIGHT/AROUND");
            }
        }

        private static int GetDistance(int x, int y, string direction)
        {
            var distanceStr = Regex.Match(direction, "\\d+.?\\d+").ToString();
            return distanceStr.Contains('.') ? (int)(double.Parse(distanceStr) * 1000) : int.Parse(distanceStr);
        }

        private static void MoveToIntersection(ref int x, ref int y, string heading, string directions)
        {
            MoveHeading(heading, ref x, ref y, 100);

            var numberOfBlocks = Regex.Match(directions, "\\d+");
            if (numberOfBlocks.Success)
                MoveHeading(heading, ref x, ref y, (int.Parse(numberOfBlocks.ToString()) - 1) * 1000);

            if (heading == "NORTH" || heading == "SOUTH")
                while (y % 1000 != 0)
                    MoveHeading(heading, ref x, ref y, 100);
            else
                while (x % 1000 != 0)
                    MoveHeading(heading, ref x, ref y, 100);
        }

        public static Point SatNav(string[] directions)
        {
            var heading = "NORTH";
            int x = 0, y = 0;

            for (var i = 0; i < directions.Length; i++)
            {
                int distance = 0;
                switch (directions[i][0])
                {
                    case 'H':
                        heading = directions[i].Substring(5);
                        break;
                    case 'G':
                        distance = GetDistance(x, y, directions[i]);
                        MoveHeading(heading, ref x, ref y, distance);
                        break;
                    case 'T':
                        if (directions[i] == "Turn around!")
                            heading = NewHeading(heading, "AROUND");
                        else if (directions[i].EndsWith("LEFT"))
                        {
                            MoveToIntersection(ref x, ref y, heading, directions[i]);
                            heading = NewHeading(heading, "LEFT");
                        }
                        else if (directions[i].EndsWith("RIGHT"))
                        {
                            MoveToIntersection(ref x, ref y, heading, directions[i]);
                            heading = NewHeading(heading, "RIGHT");
                        }
                        break;
                    case 'Y':
                        Console.WriteLine($"Arrived at final destination ({x / 100}, {y / 100})");
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"Heading {heading} at ({x}, {y})");
            }

            return new Point(x / 100, y / 100);
        }
    }
}
