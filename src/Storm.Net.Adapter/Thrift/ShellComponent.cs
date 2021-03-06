#if !NETSTANDARD13
/**
 * Autogenerated by Thrift Compiler (0.9.2)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;



public partial class ShellComponent : TBase
{
  private string _execution_command;
  private string _script;

  public string Execution_command
  {
    get
    {
      return _execution_command;
    }
    set
    {
      __isset.execution_command = true;
      this._execution_command = value;
    }
  }

  public string Script
  {
    get
    {
      return _script;
    }
    set
    {
      __isset.script = true;
      this._script = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool execution_command;
    public bool script;
  }

  public ShellComponent() {
  }

  public void Read (TProtocol iprot)
  {
    TField field;
    iprot.ReadStructBegin();
    while (true)
    {
      field = iprot.ReadFieldBegin();
      if (field.Type == TType.Stop) { 
        break;
      }
      switch (field.ID)
      {
        case 1:
          if (field.Type == TType.String) {
            Execution_command = iprot.ReadString();
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.String) {
            Script = iprot.ReadString();
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        default: 
          TProtocolUtil.Skip(iprot, field.Type);
          break;
      }
      iprot.ReadFieldEnd();
    }
    iprot.ReadStructEnd();
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("ShellComponent");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    if (Execution_command != null && __isset.execution_command) {
      field.Name = "execution_command";
      field.Type = TType.String;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Execution_command);
      oprot.WriteFieldEnd();
    }
    if (Script != null && __isset.script) {
      field.Name = "script";
      field.Type = TType.String;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Script);
      oprot.WriteFieldEnd();
    }
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("ShellComponent(");
    bool __first = true;
    if (Execution_command != null && __isset.execution_command) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Execution_command: ");
      __sb.Append(Execution_command);
    }
    if (Script != null && __isset.script) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Script: ");
      __sb.Append(Script);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}
#endif