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

public partial class DistributedRPCInvocations {
  public interface Iface {
    void result(string id, string result);
    #if SILVERLIGHT
    IAsyncResult Begin_result(AsyncCallback callback, object state, string id, string result);
    void End_result(IAsyncResult asyncResult);
    #endif
    DRPCRequest fetchRequest(string functionName);
    #if SILVERLIGHT
    IAsyncResult Begin_fetchRequest(AsyncCallback callback, object state, string functionName);
    DRPCRequest End_fetchRequest(IAsyncResult asyncResult);
    #endif
    void failRequest(string id);
    #if SILVERLIGHT
    IAsyncResult Begin_failRequest(AsyncCallback callback, object state, string id);
    void End_failRequest(IAsyncResult asyncResult);
    #endif
  }

  public class Client : IDisposable, Iface {
    public Client(TProtocol prot) : this(prot, prot)
    {
    }

    public Client(TProtocol iprot, TProtocol oprot)
    {
      iprot_ = iprot;
      oprot_ = oprot;
    }

    protected TProtocol iprot_;
    protected TProtocol oprot_;
    protected int seqid_;

    public TProtocol InputProtocol
    {
      get { return iprot_; }
    }
    public TProtocol OutputProtocol
    {
      get { return oprot_; }
    }


    #region " IDisposable Support "
    private bool _IsDisposed;

    // IDisposable
    public void Dispose()
    {
      Dispose(true);
    }
    

    protected virtual void Dispose(bool disposing)
    {
      if (!_IsDisposed)
      {
        if (disposing)
        {
          if (iprot_ != null)
          {
            ((IDisposable)iprot_).Dispose();
          }
          if (oprot_ != null)
          {
            ((IDisposable)oprot_).Dispose();
          }
        }
      }
      _IsDisposed = true;
    }
    #endregion


    
    #if SILVERLIGHT
    public IAsyncResult Begin_result(AsyncCallback callback, object state, string id, string result)
    {
      return send_result(callback, state, id, result);
    }

    public void End_result(IAsyncResult asyncResult)
    {
      oprot_.Transport.EndFlush(asyncResult);
      recv_result();
    }

    #endif

    public void result(string id, string result)
    {
      #if !SILVERLIGHT
      send_result(id, result);
      recv_result();

      #else
      var asyncResult = Begin_result(null, null, id, result);
      End_result(asyncResult);

      #endif
    }
    #if SILVERLIGHT
    public IAsyncResult send_result(AsyncCallback callback, object state, string id, string result)
    #else
    public void send_result(string id, string result)
    #endif
    {
      oprot_.WriteMessageBegin(new TMessage("result", TMessageType.Call, seqid_));
      result_args args = new result_args();
      args.Id = id;
      args.Result = result;
      args.Write(oprot_);
      oprot_.WriteMessageEnd();
      #if SILVERLIGHT
      return oprot_.Transport.BeginFlush(callback, state);
      #else
      oprot_.Transport.Flush();
      #endif
    }

    public void recv_result()
    {
      TMessage msg = iprot_.ReadMessageBegin();
      if (msg.Type == TMessageType.Exception) {
        TApplicationException x = TApplicationException.Read(iprot_);
        iprot_.ReadMessageEnd();
        throw x;
      }
      result_result result = new result_result();
      result.Read(iprot_);
      iprot_.ReadMessageEnd();
      if (result.__isset.aze) {
        throw result.Aze;
      }
      return;
    }

    
    #if SILVERLIGHT
    public IAsyncResult Begin_fetchRequest(AsyncCallback callback, object state, string functionName)
    {
      return send_fetchRequest(callback, state, functionName);
    }

    public DRPCRequest End_fetchRequest(IAsyncResult asyncResult)
    {
      oprot_.Transport.EndFlush(asyncResult);
      return recv_fetchRequest();
    }

    #endif

    public DRPCRequest fetchRequest(string functionName)
    {
      #if !SILVERLIGHT
      send_fetchRequest(functionName);
      return recv_fetchRequest();

      #else
      var asyncResult = Begin_fetchRequest(null, null, functionName);
      return End_fetchRequest(asyncResult);

      #endif
    }
    #if SILVERLIGHT
    public IAsyncResult send_fetchRequest(AsyncCallback callback, object state, string functionName)
    #else
    public void send_fetchRequest(string functionName)
    #endif
    {
      oprot_.WriteMessageBegin(new TMessage("fetchRequest", TMessageType.Call, seqid_));
      fetchRequest_args args = new fetchRequest_args();
      args.FunctionName = functionName;
      args.Write(oprot_);
      oprot_.WriteMessageEnd();
      #if SILVERLIGHT
      return oprot_.Transport.BeginFlush(callback, state);
      #else
      oprot_.Transport.Flush();
      #endif
    }

    public DRPCRequest recv_fetchRequest()
    {
      TMessage msg = iprot_.ReadMessageBegin();
      if (msg.Type == TMessageType.Exception) {
        TApplicationException x = TApplicationException.Read(iprot_);
        iprot_.ReadMessageEnd();
        throw x;
      }
      fetchRequest_result result = new fetchRequest_result();
      result.Read(iprot_);
      iprot_.ReadMessageEnd();
      if (result.__isset.success) {
        return result.Success;
      }
      if (result.__isset.aze) {
        throw result.Aze;
      }
      throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "fetchRequest failed: unknown result");
    }

    
    #if SILVERLIGHT
    public IAsyncResult Begin_failRequest(AsyncCallback callback, object state, string id)
    {
      return send_failRequest(callback, state, id);
    }

    public void End_failRequest(IAsyncResult asyncResult)
    {
      oprot_.Transport.EndFlush(asyncResult);
      recv_failRequest();
    }

    #endif

    public void failRequest(string id)
    {
      #if !SILVERLIGHT
      send_failRequest(id);
      recv_failRequest();

      #else
      var asyncResult = Begin_failRequest(null, null, id);
      End_failRequest(asyncResult);

      #endif
    }
    #if SILVERLIGHT
    public IAsyncResult send_failRequest(AsyncCallback callback, object state, string id)
    #else
    public void send_failRequest(string id)
    #endif
    {
      oprot_.WriteMessageBegin(new TMessage("failRequest", TMessageType.Call, seqid_));
      failRequest_args args = new failRequest_args();
      args.Id = id;
      args.Write(oprot_);
      oprot_.WriteMessageEnd();
      #if SILVERLIGHT
      return oprot_.Transport.BeginFlush(callback, state);
      #else
      oprot_.Transport.Flush();
      #endif
    }

    public void recv_failRequest()
    {
      TMessage msg = iprot_.ReadMessageBegin();
      if (msg.Type == TMessageType.Exception) {
        TApplicationException x = TApplicationException.Read(iprot_);
        iprot_.ReadMessageEnd();
        throw x;
      }
      failRequest_result result = new failRequest_result();
      result.Read(iprot_);
      iprot_.ReadMessageEnd();
      if (result.__isset.aze) {
        throw result.Aze;
      }
      return;
    }

  }
  public class Processor : TProcessor {
    public Processor(Iface iface)
    {
      iface_ = iface;
      processMap_["result"] = result_Process;
      processMap_["fetchRequest"] = fetchRequest_Process;
      processMap_["failRequest"] = failRequest_Process;
    }

    protected delegate void ProcessFunction(int seqid, TProtocol iprot, TProtocol oprot);
    private Iface iface_;
    protected Dictionary<string, ProcessFunction> processMap_ = new Dictionary<string, ProcessFunction>();

    public bool Process(TProtocol iprot, TProtocol oprot)
    {
      try
      {
        TMessage msg = iprot.ReadMessageBegin();
        ProcessFunction fn;
        processMap_.TryGetValue(msg.Name, out fn);
        if (fn == null) {
          TProtocolUtil.Skip(iprot, TType.Struct);
          iprot.ReadMessageEnd();
          TApplicationException x = new TApplicationException (TApplicationException.ExceptionType.UnknownMethod, "Invalid method name: '" + msg.Name + "'");
          oprot.WriteMessageBegin(new TMessage(msg.Name, TMessageType.Exception, msg.SeqID));
          x.Write(oprot);
          oprot.WriteMessageEnd();
          oprot.Transport.Flush();
          return true;
        }
        fn(msg.SeqID, iprot, oprot);
      }
      catch (IOException)
      {
        return false;
      }
      return true;
    }

    public void result_Process(int seqid, TProtocol iprot, TProtocol oprot)
    {
      result_args args = new result_args();
      args.Read(iprot);
      iprot.ReadMessageEnd();
      result_result result = new result_result();
      try {
        iface_.result(args.Id, args.Result);
      } catch (AuthorizationException aze) {
        result.Aze = aze;
      }
      oprot.WriteMessageBegin(new TMessage("result", TMessageType.Reply, seqid)); 
      result.Write(oprot);
      oprot.WriteMessageEnd();
      oprot.Transport.Flush();
    }

    public void fetchRequest_Process(int seqid, TProtocol iprot, TProtocol oprot)
    {
      fetchRequest_args args = new fetchRequest_args();
      args.Read(iprot);
      iprot.ReadMessageEnd();
      fetchRequest_result result = new fetchRequest_result();
      try {
        result.Success = iface_.fetchRequest(args.FunctionName);
      } catch (AuthorizationException aze) {
        result.Aze = aze;
      }
      oprot.WriteMessageBegin(new TMessage("fetchRequest", TMessageType.Reply, seqid)); 
      result.Write(oprot);
      oprot.WriteMessageEnd();
      oprot.Transport.Flush();
    }

    public void failRequest_Process(int seqid, TProtocol iprot, TProtocol oprot)
    {
      failRequest_args args = new failRequest_args();
      args.Read(iprot);
      iprot.ReadMessageEnd();
      failRequest_result result = new failRequest_result();
      try {
        iface_.failRequest(args.Id);
      } catch (AuthorizationException aze) {
        result.Aze = aze;
      }
      oprot.WriteMessageBegin(new TMessage("failRequest", TMessageType.Reply, seqid)); 
      result.Write(oprot);
      oprot.WriteMessageEnd();
      oprot.Transport.Flush();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class result_args : TBase
  {
    private string _id;
    private string _result;

    public string Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public string Result
    {
      get
      {
        return _result;
      }
      set
      {
        __isset.result = true;
        this._result = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool id;
      public bool result;
    }

    public result_args() {
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
              Id = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Result = iprot.ReadString();
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
      TStruct struc = new TStruct("result_args");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Id != null && __isset.id) {
        field.Name = "id";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Id);
        oprot.WriteFieldEnd();
      }
      if (Result != null && __isset.result) {
        field.Name = "result";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Result);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("result_args(");
      bool __first = true;
      if (Id != null && __isset.id) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Id: ");
        __sb.Append(Id);
      }
      if (Result != null && __isset.result) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Result: ");
        __sb.Append(Result);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class result_result : TBase
  {
    private AuthorizationException _aze;

    public AuthorizationException Aze
    {
      get
      {
        return _aze;
      }
      set
      {
        __isset.aze = true;
        this._aze = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool aze;
    }

    public result_result() {
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
            if (field.Type == TType.Struct) {
              Aze = new AuthorizationException();
              Aze.Read(iprot);
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
      TStruct struc = new TStruct("result_result");
      oprot.WriteStructBegin(struc);
      TField field = new TField();

      if (this.__isset.aze) {
        if (Aze != null) {
          field.Name = "Aze";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Aze.Write(oprot);
          oprot.WriteFieldEnd();
        }
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("result_result(");
      bool __first = true;
      if (Aze != null && __isset.aze) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Aze: ");
        __sb.Append(Aze== null ? "<null>" : Aze.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class fetchRequest_args : TBase
  {
    private string _functionName;

    public string FunctionName
    {
      get
      {
        return _functionName;
      }
      set
      {
        __isset.functionName = true;
        this._functionName = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool functionName;
    }

    public fetchRequest_args() {
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
              FunctionName = iprot.ReadString();
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
      TStruct struc = new TStruct("fetchRequest_args");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (FunctionName != null && __isset.functionName) {
        field.Name = "functionName";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(FunctionName);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("fetchRequest_args(");
      bool __first = true;
      if (FunctionName != null && __isset.functionName) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("FunctionName: ");
        __sb.Append(FunctionName);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class fetchRequest_result : TBase
  {
    private DRPCRequest _success;
    private AuthorizationException _aze;

    public DRPCRequest Success
    {
      get
      {
        return _success;
      }
      set
      {
        __isset.success = true;
        this._success = value;
      }
    }

    public AuthorizationException Aze
    {
      get
      {
        return _aze;
      }
      set
      {
        __isset.aze = true;
        this._aze = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool success;
      public bool aze;
    }

    public fetchRequest_result() {
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
          case 0:
            if (field.Type == TType.Struct) {
              Success = new DRPCRequest();
              Success.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 1:
            if (field.Type == TType.Struct) {
              Aze = new AuthorizationException();
              Aze.Read(iprot);
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
      TStruct struc = new TStruct("fetchRequest_result");
      oprot.WriteStructBegin(struc);
      TField field = new TField();

      if (this.__isset.success) {
        if (Success != null) {
          field.Name = "Success";
          field.Type = TType.Struct;
          field.ID = 0;
          oprot.WriteFieldBegin(field);
          Success.Write(oprot);
          oprot.WriteFieldEnd();
        }
      } else if (this.__isset.aze) {
        if (Aze != null) {
          field.Name = "Aze";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Aze.Write(oprot);
          oprot.WriteFieldEnd();
        }
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("fetchRequest_result(");
      bool __first = true;
      if (Success != null && __isset.success) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Success: ");
        __sb.Append(Success== null ? "<null>" : Success.ToString());
      }
      if (Aze != null && __isset.aze) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Aze: ");
        __sb.Append(Aze== null ? "<null>" : Aze.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class failRequest_args : TBase
  {
    private string _id;

    public string Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool id;
    }

    public failRequest_args() {
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
              Id = iprot.ReadString();
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
      TStruct struc = new TStruct("failRequest_args");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Id != null && __isset.id) {
        field.Name = "id";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Id);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("failRequest_args(");
      bool __first = true;
      if (Id != null && __isset.id) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Id: ");
        __sb.Append(Id);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class failRequest_result : TBase
  {
    private AuthorizationException _aze;

    public AuthorizationException Aze
    {
      get
      {
        return _aze;
      }
      set
      {
        __isset.aze = true;
        this._aze = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool aze;
    }

    public failRequest_result() {
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
            if (field.Type == TType.Struct) {
              Aze = new AuthorizationException();
              Aze.Read(iprot);
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
      TStruct struc = new TStruct("failRequest_result");
      oprot.WriteStructBegin(struc);
      TField field = new TField();

      if (this.__isset.aze) {
        if (Aze != null) {
          field.Name = "Aze";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Aze.Write(oprot);
          oprot.WriteFieldEnd();
        }
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("failRequest_result(");
      bool __first = true;
      if (Aze != null && __isset.aze) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Aze: ");
        __sb.Append(Aze== null ? "<null>" : Aze.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
#endif