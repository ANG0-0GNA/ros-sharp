﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UrdfTests.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("UrdfTests.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; ?&gt;
        ///&lt;!-- =================================================================================== --&gt;
        ///&lt;!-- |    This document was autogenerated by xacro from /opt/ros/kinetic/share/turtlebot_description/robots/kobuki_hexagons_asus_xtion_pro.urdf.xacro | --&gt;
        ///&lt;!-- |    EDITING THIS FILE BY HAND IS NOT RECOMMENDED                                 | --&gt;
        ///&lt;!-- =================================================================================== --&gt;
        ///&lt;!--
        ///    - Base      : kobuki
        ///    - Stacks    : [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string xmlResFullRobot {
            get {
                return ResourceManager.GetString("xmlResFullRobot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; ?&gt;
        ///
        ///&lt;robot name=&quot;turtlebot&quot; xmlns:xacro=&quot;http://ros.org/wiki/xacro&quot;&gt;
        ///
        ///  &lt;link name=&quot;base_footprint&quot;/&gt;
        ///  &lt;joint name=&quot;base_joint&quot; type=&quot;fixed&quot;&gt;
        ///    &lt;origin rpy=&quot;0 0 0&quot; xyz=&quot;0 0 0.0102&quot;/&gt;
        ///    &lt;parent link=&quot;base_footprint&quot;/&gt;
        ///    &lt;child link=&quot;base_link&quot;/&gt;
        ///  &lt;/joint&gt;
        ///  &lt;tooltip name=&quot;base_tooltip&quot; topic=&quot;/test/topic&quot;&gt;
        ///	&lt;parent link=&quot;base_footprint&quot;/&gt;
        ///    &lt;origin rpy=&quot;0 0 0&quot; xyz=&quot;0 0 0.0102&quot;/&gt;
        ///  &lt;/tooltip&gt;
        ///&lt;/robot&gt;.
        /// </summary>
        internal static string xmlResSingleNode {
            get {
                return ResourceManager.GetString("xmlResSingleNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; ?&gt;
        ///
        ///&lt;robot name=&quot;turtlebot&quot; xmlns:xacro=&quot;http://ros.org/wiki/xacro&quot;&gt;
        ///
        ///  &lt;link name=&quot;base_footprint&quot;/&gt;
        ///  &lt;joint name=&quot;base_joint&quot; type=&quot;fixed&quot;&gt;
        ///    &lt;origin rpy=&quot;0 0 0&quot; xyz=&quot;0 0 0.0102&quot;/&gt;
        ///    &lt;parent link=&quot;base_footprint&quot;/&gt;
        ///    &lt;child link=&quot;base_link&quot;/&gt;
        ///  &lt;/joint&gt;
        ///  &lt;tooltip name=&quot;base_tooltip&quot; topic=&quot;/test/topic&quot;&gt;
        ///	&lt;parent link=&quot;base_footprint&quot;/&gt;
        ///    &lt;origin rpy=&quot;0 0 0&quot; xyz=&quot;0 0 0.0102&quot;/&gt;
        ///  &lt;/tooltip&gt;
        ///  &lt;link name=&quot;base_link&quot;&gt;
        ///    &lt;visual&gt;
        ///      &lt;geometry&gt;
        ///        &lt;!-- ne [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string xmlResSingleNodeWithTooltip {
            get {
                return ResourceManager.GetString("xmlResSingleNodeWithTooltip", resourceCulture);
            }
        }
    }
}
