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
    public class SetPlannerParamsRequest : Message
    {
        public override string RosMessageName => "moveit_msgs/SetPlannerParams";

        //  Name of planning config
        public string planner_config { get; set; }
        //  Optional name of planning group (set global defaults if empty)
        public string group { get; set; }
        //  parameters as key-value pairs
        public PlannerParams @params { get; set; }
        //  replace params or augment existing ones?
        public bool replace { get; set; }

        public SetPlannerParamsRequest()
        {
            this.planner_config = "";
            this.group = "";
            this.@params = new PlannerParams();
            this.replace = false;
        }

        public SetPlannerParamsRequest(string planner_config, string group, PlannerParams @params, bool replace)
        {
            this.planner_config = planner_config;
            this.group = group;
            this.@params = @params;
            this.replace = replace;
        }
    }
}
