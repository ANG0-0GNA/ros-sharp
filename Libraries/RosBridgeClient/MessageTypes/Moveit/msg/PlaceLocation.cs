/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



using RosSharp.RosBridgeClient.MessageTypes.Trajectory;
using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class PlaceLocation : Message
    {
        public override string RosMessageName => "moveit_msgs/PlaceLocation";

        //  A name for this grasp
        public string id { get; set; }
        //  The internal posture of the hand for the grasp
        //  positions and efforts are used
        public JointTrajectory post_place_posture { get; set; }
        //  The position of the end-effector for the grasp relative to a reference frame 
        //  (that is always specified elsewhere, not in this message)
        public PoseStamped place_pose { get; set; }
        //  The estimated probability of success for this place, or some other
        //  measure of how "good" it is.
        public double quality { get; set; }
        //  The approach motion
        public GripperTranslation pre_place_approach { get; set; }
        //  The retreat motion
        public GripperTranslation post_place_retreat { get; set; }
        //  an optional list of obstacles that we have semantic information about
        //  and that can be touched/pushed/moved in the course of grasping
        public string[] allowed_touch_objects { get; set; }

        public PlaceLocation()
        {
            this.id = "";
            this.post_place_posture = new JointTrajectory();
            this.place_pose = new PoseStamped();
            this.quality = 0.0;
            this.pre_place_approach = new GripperTranslation();
            this.post_place_retreat = new GripperTranslation();
            this.allowed_touch_objects = new string[0];
        }

        public PlaceLocation(string id, JointTrajectory post_place_posture, PoseStamped place_pose, double quality, GripperTranslation pre_place_approach, GripperTranslation post_place_retreat, string[] allowed_touch_objects)
        {
            this.id = id;
            this.post_place_posture = post_place_posture;
            this.place_pose = place_pose;
            this.quality = quality;
            this.pre_place_approach = pre_place_approach;
            this.post_place_retreat = post_place_retreat;
            this.allowed_touch_objects = allowed_touch_objects;
        }
    }
}
