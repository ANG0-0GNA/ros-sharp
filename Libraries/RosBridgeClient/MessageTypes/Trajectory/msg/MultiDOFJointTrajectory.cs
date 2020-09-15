/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using RosSharp.RosBridgeClient.MessageTypes.Std;

namespace RosSharp.RosBridgeClient.MessageTypes.Trajectory
{
    public class MultiDOFJointTrajectory : Message
    {
        public override string RosMessageName => "trajectory_msgs/MultiDOFJointTrajectory";

        //  The header is used to specify the coordinate frame and the reference time for the trajectory durations
        public Header header { get; set; }
        //  A representation of a multi-dof joint trajectory (each point is a transformation)
        //  Each point along the trajectory will include an array of positions/velocities/accelerations
        //  that has the same length as the array of joint names, and has the same order of joints as 
        //  the joint names array.
        public string[] joint_names { get; set; }
        public MultiDOFJointTrajectoryPoint[] points { get; set; }

        public MultiDOFJointTrajectory()
        {
            this.header = new Header();
            this.joint_names = new string[0];
            this.points = new MultiDOFJointTrajectoryPoint[0];
        }

        public MultiDOFJointTrajectory(Header header, string[] joint_names, MultiDOFJointTrajectoryPoint[] points)
        {
            this.header = header;
            this.joint_names = joint_names;
            this.points = points;
        }
    }
}
