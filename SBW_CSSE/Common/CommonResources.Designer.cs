﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SBW.UI.Common {
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
    internal class CommonResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CommonResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SBW.UI.Common.CommonResources", typeof(CommonResources).Assembly);
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
        ///   Looks up a localized string similar to Are you sure you need to add this new employee?.
        /// </summary>
        internal static string AddEmployeeConfirmation {
            get {
                return ResourceManager.GetString("AddEmployeeConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New recruits should be intthe age of between 18 to 55 to be recuited !.
        /// </summary>
        internal static string AgeError {
            get {
                return ResourceManager.GetString("AgeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The E-mail entered is incorrect. Please correct it and try again...!.
        /// </summary>
        internal static string EmailError {
            get {
                return ResourceManager.GetString("EmailError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please fill all required the fields....
        /// </summary>
        internal static string EmptyFieldsError {
            get {
                return ResourceManager.GetString("EmptyFieldsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter the basic salary of the employee !.
        /// </summary>
        internal static string EmptySalaryError {
            get {
                return ResourceManager.GetString("EmptySalaryError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The NIC or E-mail entered is incorrect. Please check and try again...!.
        /// </summary>
        internal static string NicEmailError {
            get {
                return ResourceManager.GetString("NicEmailError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current position and the new position cannot be the same in a promotion !.
        /// </summary>
        internal static string PromotionPositionSameError {
            get {
                return ResourceManager.GetString("PromotionPositionSameError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you need to update this employee details?.
        /// </summary>
        internal static string UpdateEmployeeeConfirmation {
            get {
                return ResourceManager.GetString("UpdateEmployeeeConfirmation", resourceCulture);
            }
        }
    }
}
