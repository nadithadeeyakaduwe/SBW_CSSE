﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SBW.BusinessService {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CommonResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CommonResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SBW.BusinessService.CommonResource", typeof(CommonResource).Assembly);
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
        ///   Looks up a localized string similar to Error occured while deleting...!.
        /// </summary>
        internal static string DBDeleteError {
            get {
                return ResourceManager.GetString("DBDeleteError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully deleted..
        /// </summary>
        internal static string DBDeleteSuccess {
            get {
                return ResourceManager.GetString("DBDeleteSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occured while trying to save data...!.
        /// </summary>
        internal static string DBInsertError {
            get {
                return ResourceManager.GetString("DBInsertError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully inserted the data..
        /// </summary>
        internal static string DBInsertSuccess {
            get {
                return ResourceManager.GetString("DBInsertSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occured while getting the data...!.
        /// </summary>
        internal static string DBRetrieveError {
            get {
                return ResourceManager.GetString("DBRetrieveError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occured while updating..!.
        /// </summary>
        internal static string DBUpdateError {
            get {
                return ResourceManager.GetString("DBUpdateError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully updated..
        /// </summary>
        internal static string DBUpdateSuccess {
            get {
                return ResourceManager.GetString("DBUpdateSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Employee successfully added..
        /// </summary>
        internal static string EmployeeAddedSuccess {
            get {
                return ResourceManager.GetString("EmployeeAddedSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occured while giving the increment to the employee...!.
        /// </summary>
        internal static string IncrementError {
            get {
                return ResourceManager.GetString("IncrementError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Employee has been given an increment..
        /// </summary>
        internal static string IncrementSuccess {
            get {
                return ResourceManager.GetString("IncrementSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occured while promoting the employee...!.
        /// </summary>
        internal static string PromotionError {
            get {
                return ResourceManager.GetString("PromotionError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Employee is now promoted..
        /// </summary>
        internal static string PromotionSuccess {
            get {
                return ResourceManager.GetString("PromotionSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occured while punching in...!.
        /// </summary>
        internal static string PunchInError {
            get {
                return ResourceManager.GetString("PunchInError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occured while punching out...!.
        /// </summary>
        internal static string PunchOutError {
            get {
                return ResourceManager.GetString("PunchOutError", resourceCulture);
            }
        }
    }
}
