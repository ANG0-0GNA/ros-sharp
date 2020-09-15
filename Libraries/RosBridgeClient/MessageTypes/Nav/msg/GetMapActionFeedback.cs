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

namespace RosSharp.RosBridgeClient.MessageTypes.Nav
{
    public class GetMapActionFeedback : Message
    {
        public override string RosMessageName => "nav_msgs/GetMapActionFeedback";

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        public Header header { get; set; }
        public GoalStatus status { get; set; }
        public GetMapFeedback feedback { get; set; }

        public GetMapActionFeedback()
        {
            this.header = new Header();
            this.status = new GoalStatus();
            this.feedback = new GetMapFeedback();
        }

        public GetMapActionFeedback(Header header, GoalStatus status, GetMapFeedback feedback)
        {
            this.header = header;
            this.status = status;
            this.feedback = feedback;
        }
    }
}
