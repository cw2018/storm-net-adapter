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



public partial class SpoutSpec : TBase
{

  public ComponentObject Spout_object { get; set; }

  public ComponentCommon Common { get; set; }

  public SpoutSpec() {
  }

  public SpoutSpec(ComponentObject spout_object, ComponentCommon common) : this() {
    this.Spout_object = spout_object;
    this.Common = common;
  }

  public void Read (TProtocol iprot)
  {
    bool isset_spout_object = false;
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
            Spout_object = new ComponentObject();
            Spout_object.Read(iprot);
            isset_spout_object = true;
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
    if (!isset_spout_object)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_common)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("SpoutSpec");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    field.Name = "spout_object";
    field.Type = TType.Struct;
    field.ID = 1;
    oprot.WriteFieldBegin(field);
    Spout_object.Write(oprot);
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
    StringBuilder __sb = new StringBuilder("SpoutSpec(");
    __sb.Append(", Spout_object: ");
    __sb.Append(Spout_object== null ? "<null>" : Spout_object.ToString());
    __sb.Append(", Common: ");
    __sb.Append(Common== null ? "<null>" : Common.ToString());
    __sb.Append(")");
    return __sb.ToString();
  }

}
#endif