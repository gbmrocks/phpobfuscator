﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PHP_Obfuscator.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string lastSourceDir {
            get {
                return ((string)(this["lastSourceDir"]));
            }
            set {
                this["lastSourceDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string lastTargetDir {
            get {
                return ((string)(this["lastTargetDir"]));
            }
            set {
                this["lastTargetDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection excludeFiles {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["excludeFiles"]));
            }
            set {
                this["excludeFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection excludedFunctions {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["excludedFunctions"]));
            }
            set {
                this["excludedFunctions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>$password:checked</string>
  <string>$database:checked</string>
  <string>$username:checked</string>
  <string>$server:checked</string>
  <string>$_SERVER:checked</string>
  <string>$HTTP_SERVER_VARS:checked</string>
  <string>$_ENV:checked</string>
  <string>$_COOKIE:checked</string>
  <string>$_GET:checked</string>
  <string>$_POST:checked</string>
  <string>$_FILES:checked</string>
  <string>$_REQUEST:checked</string>
  <string>$_SESSION:checked</string>
  <string>$GLOBALS:checked</string>
  <string>$this:checked</string>
  <string>$php_errormsg:checked</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection excludedVariables {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["excludedVariables"]));
            }
            set {
                this["excludedVariables"] = value;
            }
        }
    }
}