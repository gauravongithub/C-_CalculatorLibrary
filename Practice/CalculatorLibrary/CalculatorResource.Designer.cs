﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorLibrary {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CalculatorResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CalculatorResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CalculatorLibrary.CalculatorResource", typeof(CalculatorResource).Assembly);
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
        ///   Looks up a localized string similar to You are dividing by Zero which is not allowed. Function-{0}, Class-{1}.
        /// </summary>
        internal static string DivideByZero {
            get {
                return ResourceManager.GetString("DivideByZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have entered invalid number of inputs.
        /// </summary>
        internal static string InvalidNumberOfOperands {
            get {
                return ResourceManager.GetString("InvalidNumberOfOperands", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have entered invalid type of operators.
        /// </summary>
        internal static string InvalidTypesOfOperator {
            get {
                return ResourceManager.GetString("InvalidTypesOfOperator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Answer is too large.
        /// </summary>
        internal static string MemoryLimitExceeded {
            get {
                return ResourceManager.GetString("MemoryLimitExceeded", resourceCulture);
            }
        }
    }
}
