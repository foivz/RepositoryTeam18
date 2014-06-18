﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace App2
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::Velpro.Velpro_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::Velpro.Velpro_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.String fullName)
        {
            if(_provider == null)
            {
                _provider = new global::Velpro.Velpro_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace Velpro.Velpro_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            string standardName;
            global::Windows.UI.Xaml.Markup.IXamlType xamlType = null;
            if(_xamlTypeToStandardName.TryGetValue(type, out standardName))
            {
                xamlType = GetXamlTypeByName(standardName);
            }
            else
            {
                xamlType = GetXamlTypeByName(type.FullName);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (global::System.String.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypes.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            xamlType = CreateXamlType(typeName);
            if (xamlType != null)
            {
                _xamlTypes.Add(typeName, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (global::System.String.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType> _xamlTypes = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();
        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember> _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();
        global::System.Collections.Generic.Dictionary<global::System.Type, string> _xamlTypeToStandardName = new global::System.Collections.Generic.Dictionary<global::System.Type, string>();

        private void AddToMapOfTypeToStandardName(global::System.Type t, global::System.String str)
        {
            if(!_xamlTypeToStandardName.ContainsKey(t))
            {
                _xamlTypeToStandardName.Add(t, str);
            }
        }

        private object Activate_3_LayoutAwarePage() { return new global::App2.Common.LayoutAwarePage(); }

        private object Activate_4_Azuriraj() { return new global::App2.Azuriraj(); }

        private object Activate_5_GlavnaForma() { return new global::App2.GlavnaForma(); }

        private object Activate_6_Lista_zelje() { return new global::App2.Lista_zelje(); }

        private object Activate_7_MainPage() { return new global::App2.MainPage(); }

        private object Activate_8_Naruciti_dobavljac() { return new global::App2.Naruciti_dobavljac(); }

        private object Activate_9_Pregled_aktivne() { return new global::App2.Pregled_aktivne(); }

        private object Activate_10_Pregled_arhiva() { return new global::App2.Pregled_arhiva(); }

        private object Activate_11_Pregled_skladiste() { return new global::App2.Pregled_skladiste(); }

        private object Activate_12_Statistike() { return new global::App2.Statistike(); }


        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(string typeName)
        {
            global::Velpro.Velpro_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::Velpro.Velpro_XamlTypeInfo.XamlUserType userType;

            switch (typeName)
            {
            case "Object":
                xamlType = new global::Velpro.Velpro_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::System.Object));
                break;

            case "Windows.UI.Xaml.Controls.Page":
                xamlType = new global::Velpro.Velpro_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.Page));
                break;

            case "Windows.UI.Xaml.Controls.UserControl":
                xamlType = new global::Velpro.Velpro_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.UserControl));
                break;

            case "Windows.UI.Color":
                userType = new global::Velpro.Velpro_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::Windows.UI.Color), GetXamlTypeByName("System.ValueType"));
                userType.AddMemberName("A");
                AddToMapOfTypeToStandardName(typeof(global::System.Byte),
                                                   "Byte");
                userType.AddMemberName("B");
                AddToMapOfTypeToStandardName(typeof(global::System.Byte),
                                                   "Byte");
                userType.AddMemberName("G");
                AddToMapOfTypeToStandardName(typeof(global::System.Byte),
                                                   "Byte");
                userType.AddMemberName("R");
                AddToMapOfTypeToStandardName(typeof(global::System.Byte),
                                                   "Byte");
                xamlType = userType;
                break;

            case "System.ValueType":
                userType = new global::Velpro.Velpro_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::System.ValueType), GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case "Byte":
                userType = new global::Velpro.Velpro_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::System.Byte), GetXamlTypeByName("System.ValueType"));
                AddToMapOfTypeToStandardName(typeof(global::System.Byte),
                                                   "Byte");
                xamlType = userType;
                break;

            case "App2.Common.LayoutAwarePage":
                userType = new global::Velpro.Velpro_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.Common.LayoutAwarePage), GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_3_LayoutAwarePage;
                xamlType = userType;
                break;

            case "App2.Azuriraj":
                userType = new global::Velpro.Velpro_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.Azuriraj), GetXamlTypeByName("App2.Common.LayoutAwarePage"));
                userType.Activator = Activate_4_Azuriraj;
                xamlType = userType;
                break;

            case "App2.GlavnaForma":
                userType = new global::Velpro.Velpro_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.GlavnaForma), GetXamlTypeByName("App2.Common.LayoutAwarePage"));
                userType.Activator = Activate_5_GlavnaForma;
                xamlType = userType;
                break;

            case "App2.Lista_zelje":
                userType = new global::Velpro.Velpro_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.Lista_zelje), GetXamlTypeByName("App2.Common.LayoutAwarePage"));
                userType.Activator = Activate_6_Lista_zelje;
                xamlType = userType;
                break;

            case "App2.MainPage":
                userType = new global::Velpro.Velpro_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.MainPage), GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_MainPage;
                xamlType = userType;
                break;

            case "App2.Naruciti_dobavljac":
                userType = new global::Velpro.Velpro_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.Naruciti_dobavljac), GetXamlTypeByName("App2.Common.LayoutAwarePage"));
                userType.Activator = Activate_8_Naruciti_dobavljac;
                xamlType = userType;
                break;

            case "App2.Pregled_aktivne":
                userType = new global::Velpro.Velpro_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.Pregled_aktivne), GetXamlTypeByName("App2.Common.LayoutAwarePage"));
                userType.Activator = Activate_9_Pregled_aktivne;
                xamlType = userType;
                break;

            case "App2.Pregled_arhiva":
                userType = new global::Velpro.Velpro_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.Pregled_arhiva), GetXamlTypeByName("App2.Common.LayoutAwarePage"));
                userType.Activator = Activate_10_Pregled_arhiva;
                xamlType = userType;
                break;

            case "App2.Pregled_skladiste":
                userType = new global::Velpro.Velpro_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.Pregled_skladiste), GetXamlTypeByName("App2.Common.LayoutAwarePage"));
                userType.Activator = Activate_11_Pregled_skladiste;
                xamlType = userType;
                break;

            case "App2.Statistike":
                userType = new global::Velpro.Velpro_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.Statistike), GetXamlTypeByName("App2.Common.LayoutAwarePage"));
                userType.Activator = Activate_12_Statistike;
                xamlType = userType;
                break;

            }
            return xamlType;
        }


        private object get_0_Color_A(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.A;
        }
        private void set_0_Color_A(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.A = (global::System.Byte)Value;
        }
        private object get_1_Color_B(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.B;
        }
        private void set_1_Color_B(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.B = (global::System.Byte)Value;
        }
        private object get_2_Color_G(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.G;
        }
        private void set_2_Color_G(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.G = (global::System.Byte)Value;
        }
        private object get_3_Color_R(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.R;
        }
        private void set_3_Color_R(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.R = (global::System.Byte)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::Velpro.Velpro_XamlTypeInfo.XamlMember xamlMember = null;
            global::Velpro.Velpro_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "Windows.UI.Color.A":
                userType = (global::Velpro.Velpro_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::Velpro.Velpro_XamlTypeInfo.XamlMember(this, "A", "Byte");
                xamlMember.Getter = get_0_Color_A;
                xamlMember.Setter = set_0_Color_A;
                break;
            case "Windows.UI.Color.B":
                userType = (global::Velpro.Velpro_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::Velpro.Velpro_XamlTypeInfo.XamlMember(this, "B", "Byte");
                xamlMember.Getter = get_1_Color_B;
                xamlMember.Setter = set_1_Color_B;
                break;
            case "Windows.UI.Color.G":
                userType = (global::Velpro.Velpro_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::Velpro.Velpro_XamlTypeInfo.XamlMember(this, "G", "Byte");
                xamlMember.Getter = get_2_Color_G;
                xamlMember.Setter = set_2_Color_G;
                break;
            case "Windows.UI.Color.R":
                userType = (global::Velpro.Velpro_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::Velpro.Velpro_XamlTypeInfo.XamlMember(this, "R", "Byte");
                xamlMember.Getter = get_3_Color_R;
                xamlMember.Setter = set_3_Color_R;
                break;
            }
            return xamlMember;
        }

    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(global::System.String input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::Velpro.Velpro_XamlTypeInfo.XamlSystemBaseType
    {
        global::Velpro.Velpro_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::Velpro.Velpro_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public global::System.Object CreateFromString(global::System.String input)
        {
            if (_enumValues != null)
            {
                global::System.Int32 value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    global::System.Int32 enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( global::System.String.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::Velpro.Velpro_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::Velpro.Velpro_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(global::System.String targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


