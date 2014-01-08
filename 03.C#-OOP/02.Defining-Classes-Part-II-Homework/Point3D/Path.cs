using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
  public  class Path
    {
        public readonly List<_3DPoint> list3DPoint = new List<_3DPoint>();

        public List<_3DPoint> PathToPoint
        {
            get { return this.list3DPoint; }   
        }

        public List<_3DPoint> Add3DPoint(_3DPoint somePoint) 
        {
            list3DPoint.Add( somePoint );
            return list3DPoint;
        }

        public List<_3DPoint> Remove3DPoint()
        {
            list3DPoint.RemoveAt(0);
            return list3DPoint;
        }

        public List<_3DPoint> Clear3DPointList(_3DPoint somePoint)
        {
            list3DPoint.Clear();
            return list3DPoint;
        }

    }
}
