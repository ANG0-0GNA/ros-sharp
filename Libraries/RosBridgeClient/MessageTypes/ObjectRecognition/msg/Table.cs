/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.ObjectRecognition
{
    public class Table : Message
    {
        public override string RosMessageName => "object_recognition_msgs/Table";

        //  Informs that a planar table has been detected at a given location
        public Header header { get; set; }
        //  The pose gives you the transform that take you to the coordinate system
        //  of the table, with the origin somewhere in the table plane and the 
        //  z axis normal to the plane
        public Pose pose { get; set; }
        //  There is no guarantee that the table does NOT extend further than the
        //  convex hull; this is just as far as we've observed it.
        //  The origin of the table coordinate system is inside the convex hull
        //  Set of points forming the convex hull of the table
        public Point[] convex_hull { get; set; }

        public Table()
        {
            this.header = new Header();
            this.pose = new Pose();
            this.convex_hull = new Point[0];
        }

        public Table(Header header, Pose pose, Point[] convex_hull)
        {
            this.header = header;
            this.pose = pose;
            this.convex_hull = convex_hull;
        }
    }
}
