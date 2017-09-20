﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaunchDarkly.EventSource {
    using System;
    using System.Reflection;
    
    
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LaunchDarkly.EventSource.Resources", typeof(Resources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to The maximum retry duration is {0}..
        /// </summary>
        internal static string Configuration_RetryDuration_Exceeded {
            get {
                return ResourceManager.GetString("Configuration_RetryDuration_Exceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value must be greater than zero..
        /// </summary>
        internal static string Configuration_Value_Greater_Than_Zero {
            get {
                return ResourceManager.GetString("Configuration_Value_Greater_Than_Zero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remote EventSource API returned Http Status Code 204..
        /// </summary>
        internal static string EventSource_204_Response {
            get {
                return ResourceManager.GetString("EventSource_204_Response", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid attempt to call Start() while the connection is {0}..
        /// </summary>
        internal static string EventSource_Already_Started {
            get {
                return ResourceManager.GetString("EventSource_Already_Started", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Http Status Code &apos;{0}&apos; indicates an unsuccessful response returned from the remote EventSource API..
        /// </summary>
        internal static string EventSource_HttpResponse_Not_Successful {
            get {
                return ResourceManager.GetString("EventSource_HttpResponse_Not_Successful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HTTP Content-Type returned from the remote EventSource API does not match &apos;text/event-stream&apos;..
        /// </summary>
        internal static string EventSource_Invalid_MediaType {
            get {
                return ResourceManager.GetString("EventSource_Invalid_MediaType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EventSource.Close called.
        /// </summary>
        internal static string EventSource_Logger_Closed {
            get {
                return ResourceManager.GetString("EventSource_Logger_Closed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encountered exception in LaunchDarkly EventSource.Start method. Exception Message: {0} {1} {2}.
        /// </summary>
        internal static string EventSource_Logger_Connection_Error {
            get {
                return ResourceManager.GetString("EventSource_Logger_Connection_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EventSource Disconnected. Automatically delaying {0}ms before reconnecting. Exception: {1}..
        /// </summary>
        internal static string EventSource_Logger_Disconnected {
            get {
                return ResourceManager.GetString("EventSource_Logger_Disconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Http Response contained no content..
        /// </summary>
        internal static string EventSource_Response_Content_Empty {
            get {
                return ResourceManager.GetString("EventSource_Response_Content_Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A timeout occurred while reading the request from the remote EventSource API.
        /// </summary>
        internal static string EventSourceService_Read_Timeout {
            get {
                return ResourceManager.GetString("EventSourceService_Read_Timeout", resourceCulture);
            }
        }
    }
}
