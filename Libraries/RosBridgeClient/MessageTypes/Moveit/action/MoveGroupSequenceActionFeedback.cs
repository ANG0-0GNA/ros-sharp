/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Actionlib;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class MoveGroupSequenceActionFeedback : ActionFeedback<MoveGroupSequenceFeedback>
    {
        public override string RosMessageName => "moveit_msgs/MoveGroupSequenceActionFeedback";

        public MoveGroupSequenceActionFeedback() : base()
        {
            this.feedback = new MoveGroupSequenceFeedback();
        }

        public MoveGroupSequenceActionFeedback(Header header, GoalStatus status, MoveGroupSequenceFeedback feedback) : base(header, status)
        {
            this.feedback = feedback;
        }
    }
}
