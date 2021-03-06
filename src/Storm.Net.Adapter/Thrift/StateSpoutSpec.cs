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



public partial class StateSpoutSpec : TBase
{

  public ComponentObject State_spout_object { get; set; }

  public ComponentCommon Common { get; set; }

  public StateSpoutSpec() {
  }

  public StateSpoutSpec(ComponentObject state_spout_object, ComponentCommon common) : this() {
    this.State_spout_object = state_spout_object;
    this.Common = common;
  }

  public void Read (TProtocol iprot)
  {
    bool isset_state_spout_object = false;
    bool isset_common = false;
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
          if (field.Type == TType.Struct) {
            State_spout_object = new ComponentObject();
            State_spout_object.Read(iprot);
            isset_state_spout_object = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.Struct) {
            Common = new ComponentCommon();
            Common.Read(iprot);
            isset_common = true;
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
    if (!isset_state_spout_object)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_common)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("StateSpoutSpec");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    field.Name = "state_spout_object";
    field.Type = TType.Struct;
    field.ID = 1;
    oprot.WriteFieldBegin(field);
    State_spout_object.Write(oprot);
    oprot.WriteFieldEnd();
    field.Name = "common";
    field.Type = TType.Struct;
    field.ID = 2;
    oprot.WriteFieldBegin(field);
    Common.Write(oprot);
    oprot.WriteFieldEnd();
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("StateSpoutSpec(");
    __sb.Append(", State_spout_object: ");
    __sb.Append(State_spout_object== null ? "<null>" : State_spout_object.ToString());
    __sb.Append(", Common: ");
    __sb.Append(Common== null ? "<null>" : Common.ToString());
    __sb.Append(")");
    return __sb.ToString();
  }

}
#endif