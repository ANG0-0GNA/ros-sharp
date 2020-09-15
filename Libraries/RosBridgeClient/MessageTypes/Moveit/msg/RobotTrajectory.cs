/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



using RosSharp.RosBridgeClient.MessageTypes.Trajectory;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class RobotTrajectory : Message
    {
        public override string RosMessageName => "moveit_msgs/RobotTrajectory";

        public JointTrajectory joint_trajectory { get; set; }
        public MultiDOFJointTrajectory multi_dof_joint_trajectory { get; set; }

        public RobotTrajectory()
        {
            this.joint_trajectory = new JointTrajectory();
            this.multi_dof_joint_trajectory = new MultiDOFJointTrajectory();
        }

        public RobotTrajectory(JointTrajectory joint_trajectory, MultiDOFJointTrajectory multi_dof_joint_trajectory)
        {
            this.joint_trajectory = joint_trajectory;
            this.multi_dof_joint_trajectory = multi_dof_joint_trajectory;
        }
    }
}
