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



public partial class LSApprovedWorkers : TBase
{

  public Dictionary<string, int> Approved_workers { get; set; }

  public LSApprovedWorkers() {
  }

  public LSApprovedWorkers(Dictionary<string, int> approved_workers) : this() {
    this.Approved_workers = approved_workers;
  }

  public void Read (TProtocol iprot)
  {
    bool isset_approved_workers = false;
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
          if (field.Type == TType.Map) {
            {
              Approved_workers = new Dictionary<string, int>();
              TMap _map227 = iprot.ReadMapBegin();
              for( int _i228 = 0; _i228 < _map227.Count; ++_i228)
              {
                string _key229;
                int _val230;
                _key229 = iprot.ReadString();
                _val230 = iprot.ReadI32();
                Approved_workers[_key229] = _val230;
              }
              iprot.ReadMapEnd();
            }
            isset_approved_workers = true;
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
    if (!isset_approved_workers)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("LSApprovedWorkers");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    field.Name = "approved_workers";
    field.Type = TType.Map;
    field.ID = 1;
    oprot.WriteFieldBegin(field);
    {
      oprot.WriteMapBegin(new TMap(TType.String, TType.I32, Approved_workers.Count));
      foreach (string _iter231 in Approved_workers.Keys)
      {
        oprot.WriteString(_iter231);
        oprot.WriteI32(Approved_workers[_iter231]);
      }
      oprot.WriteMapEnd();
    }
    oprot.WriteFieldEnd();
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("LSApprovedWorkers(");
    __sb.Append(", Approved_workers: ");
    __sb.Append(Approved_workers);
    __sb.Append(")");
    return __sb.ToString();
  }

}
#endif