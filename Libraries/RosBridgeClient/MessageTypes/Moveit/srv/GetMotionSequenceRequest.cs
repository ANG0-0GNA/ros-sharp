/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class GetMotionSequenceRequest : Message
    {
        public override string RosMessageName => "moveit_msgs/GetMotionSequence";

        //  Planning request with a list of motion commands
        public MotionSequenceRequest request { get; set; }

        public GetMotionSequenceRequest()
        {
            this.request = new MotionSequenceRequest();
        }

        public GetMotionSequenceRequest(MotionSequenceRequest request)
        {
            this.request = request;
        }
    }
}
