﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bitzen_LeninAguiar_InfraStructure {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class Infra : global::System.Configuration.ApplicationSettingsBase {
        
        private static Infra defaultInstance = ((Infra)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Infra())));
        
        public static Infra Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("server=localhost;database=library;user=user;password=password")]
        public string BitzenEntities {
            get {
                return ((string)(this["BitzenEntities"]));
            }
        }
    }
}
