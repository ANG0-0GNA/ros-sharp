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
    public class ListRobotStatesInWarehouseRequest : Message
    {
        public override string RosMessageName => "moveit_msgs/ListRobotStatesInWarehouse";

        public string regex { get; set; }
        public string robot { get; set; }

        public ListRobotStatesInWarehouseRequest()
        {
            this.regex = "";
            this.robot = "";
        }

        public ListRobotStatesInWarehouseRequest(string regex, string robot)
        {
            this.regex = regex;
            this.robot = robot;
        }
    }
}
