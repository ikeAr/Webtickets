﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.nap7.com")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.nap7.com", IsNullable=false)]
public partial class RedisConfiguration {
    
    private RedisConfigurationRedis redisField;
    
    /// <remarks/>
    public RedisConfigurationRedis Redis {
        get {
            return this.redisField;
        }
        set {
            this.redisField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.nap7.com")]
public partial class RedisConfigurationRedis {
    
    private RedisConfigurationRedisRedisClient redisClientField;
    
    /// <remarks/>
    public RedisConfigurationRedisRedisClient RedisClient {
        get {
            return this.redisClientField;
        }
        set {
            this.redisClientField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.nap7.com")]
public partial class RedisConfigurationRedisRedisClient {
    
    private string connectionConfigurationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
    public string ConnectionConfiguration {
        get {
            return this.connectionConfigurationField;
        }
        set {
            this.connectionConfigurationField = value;
        }
    }
}
