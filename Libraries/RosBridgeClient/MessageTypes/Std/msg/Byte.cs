/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

namespace RosSharp.RosBridgeClient.MessageTypes.Std
{
    public class Byte : Message
    {
        public override string RosMessageName => "std_msgs/Byte";

        public sbyte data { get; set; }

        public Byte()
        {
            this.data = 0;
        }

        public Byte(sbyte data)
        {
            this.data = data;
        }
    }
}