﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4984
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace EsuApiLib {
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("policy", Namespace="", IsNullable=false)]
    public partial class PolicyType {
        
        private System.DateTimeOffset expirationField;
        
        private int maxuploadsField;
        
        private int maxdownloadsField;
        
        private SourceType sourceField;
        
        private ContentLengthRangeType contentlengthrangeField;
        
        private FormFieldType[] formfieldField;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public System.DateTimeOffset Expiration
        {
            get {
                return this.expirationField;
            }
            set {
                this.expirationField = value.AddTicks(-(value.Ticks % System.TimeSpan.TicksPerSecond));
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expiration", Order = 0)]
        public string ExpirationStr
        {
            get {
                return this.Expiration.ToUniversalTime().ToString("s") + "Z";
            }
            set {
                this.Expiration = System.DateTimeOffset.Parse(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("max-uploads", Order=1)]
        public int MaxUploads {
            get {
                return this.maxuploadsField;
            }
            set {
                this.maxuploadsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("max-downloads", Order=2)]
        public int MaxDownloads {
            get {
                return this.maxdownloadsField;
            }
            set {
                this.maxdownloadsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("source", Order=3)]
        public SourceType Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("content-length-range", Order=4)]
        public ContentLengthRangeType ContentLengthRange {
            get {
                return this.contentlengthrangeField;
            }
            set {
                this.contentlengthrangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("form-field", Order=5)]
        public FormFieldType[] FormField {
            get {
                return this.formfieldField;
            }
            set {
                this.formfieldField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SourceType {
        
        private string[] allowField;
        
        private string[] disallowField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("allow", Order=0)]
        public string[] Allow {
            get {
                return this.allowField;
            }
            set {
                this.allowField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("disallow", Order=1)]
        public string[] Disallow {
            get {
                return this.disallowField;
            }
            set {
                this.disallowField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FormFieldType {
        
        private string[] matchesField;
        
        private string[] eqField;
        
        private string[] startswithField;
        
        private string[] endswithField;
        
        private string[] containsField;
        
        private string nameField;
        
        private bool optionalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("matches", Order=0)]
        public string[] Matches {
            get {
                return this.matchesField;
            }
            set {
                this.matchesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("eq", Order=1)]
        public string[] Eq {
            get {
                return this.eqField;
            }
            set {
                this.eqField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("starts-with", Order=2)]
        public string[] StartsWith {
            get {
                return this.startswithField;
            }
            set {
                this.startswithField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ends-with", Order=3)]
        public string[] EndsWith {
            get {
                return this.endswithField;
            }
            set {
                this.endswithField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contains", Order=4)]
        public string[] Contains {
            get {
                return this.containsField;
            }
            set {
                this.containsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("optional")]
        public bool Optional {
            get {
                return this.optionalField;
            }
            set {
                this.optionalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ContentLengthRangeType {
        
        private int fromField;
        
        private int toField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("from")]
        public int From {
            get {
                return this.fromField;
            }
            set {
                this.fromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("to")]
        public int To {
            get {
                return this.toField;
            }
            set {
                this.toField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("list-access-tokens-result", Namespace="", IsNullable=false)]
    public partial class ListAccessTokenResultType {
        
        private AccessTokenType[] accesstokenslistField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute("access-tokens-list", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("access-token", IsNullable=false)]
        public AccessTokenType[] AccessTokensList {
            get {
                return this.accesstokenslistField;
            }
            set {
                this.accesstokenslistField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("access-token", Namespace="", IsNullable=false)]
    public partial class AccessTokenType {
        
        private string accesstokenidField;
        
        private System.DateTimeOffset expirationField;
        
        private int maxuploadsField;
        
        private int maxdownloadsField;
        
        private SourceType sourceField;
        
        private ContentLengthRangeType contentlengthrangeField;

        private FormFieldType[] formfieldField;

        private string uidField;
        
        private string objectidField;
        
        private string pathField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("access-token-id", Order=0)]
        public string AccessTokenId {
            get {
                return this.accesstokenidField;
            }
            set {
                this.accesstokenidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public System.DateTimeOffset Expiration
        {
            get {
                return this.expirationField;
            }
            set {
                this.expirationField = value.AddTicks( - (value.Ticks % System.TimeSpan.TicksPerSecond));
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expiration", Order = 1)]
        public string ExpirationStr
        {
            get {
                return this.Expiration.ToUniversalTime().ToString("s") + "Z";
            }
            set {
                this.Expiration = System.DateTimeOffset.Parse(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("max-uploads", Order=2)]
        public int MaxUploads {
            get {
                return this.maxuploadsField;
            }
            set {
                this.maxuploadsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("max-downloads", Order=3)]
        public int MaxDownloads {
            get {
                return this.maxdownloadsField;
            }
            set {
                this.maxdownloadsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("source", Order=4)]
        public SourceType Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("content-length-range", Order=5)]
        public ContentLengthRangeType ContentLengthRange {
            get {
                return this.contentlengthrangeField;
            }
            set {
                this.contentlengthrangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("form-field", Order = 6)]
        public FormFieldType[] FormField
        {
            get
            {
                return this.formfieldField;
            }
            set
            {
                this.formfieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("uid", Order=7)]
        public string Uid {
            get {
                return this.uidField;
            }
            set {
                this.uidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("object-id", Order=8)]
        public string ObjectId {
            get {
                return this.objectidField;
            }
            set {
                this.objectidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("path", Order=9)]
        public string Path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
    }
}
