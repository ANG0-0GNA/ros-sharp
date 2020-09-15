/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using RosSharp.RosBridgeClient.MessageTypes.Std;

namespace RosSharp.RosBridgeClient.MessageTypes.Geometry
{
    public class PoseWithCovarianceStamped : Message
    {
        public override string RosMessageName => "geometry_msgs/PoseWithCovarianceStamped";

        //  This expresses an estimated pose with a reference coordinate frame and timestamp
        public Header header { get; set; }
        public PoseWithCovariance pose { get; set; }

        public PoseWithCovarianceStamped()
        {
            this.header = new Header();
            this.pose = new PoseWithCovariance();
        }

        public PoseWithCovarianceStamped(Header header, PoseWithCovariance pose)
        {
            this.header = header;
            this.pose = pose;
        }
    }
}
