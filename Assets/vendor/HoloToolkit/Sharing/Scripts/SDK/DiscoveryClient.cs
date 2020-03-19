//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace HoloToolkit.Sharing {

public class DiscoveryClient : System.IDisposable {
  private System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DiscoveryClient(System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static System.Runtime.InteropServices.HandleRef getCPtr(DiscoveryClient obj) {
    return (obj == null) ? new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DiscoveryClient() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_DiscoveryClient(swigCPtr);
        }
        swigCPtr = new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero);
      }
      System.GC.SuppressFinalize(this);
    }
  }

  public static DiscoveryClient Create() {
    System.IntPtr cPtr = SharingClientPINVOKE.DiscoveryClient_Create();
    DiscoveryClient ret = (cPtr == System.IntPtr.Zero) ? null : new DiscoveryClient(cPtr, true);
    return ret; 
  }

  public virtual void Ping() {
    SharingClientPINVOKE.DiscoveryClient_Ping(swigCPtr);
  }

  public virtual uint GetDiscoveredCount() {
    uint ret = SharingClientPINVOKE.DiscoveryClient_GetDiscoveredCount(swigCPtr);
    return ret;
  }

  public virtual DiscoveredSystem GetDiscoveredSystem(uint index) {
    System.IntPtr cPtr = SharingClientPINVOKE.DiscoveryClient_GetDiscoveredSystem(swigCPtr, index);
    DiscoveredSystem ret = (cPtr == System.IntPtr.Zero) ? null : new DiscoveredSystem(cPtr, true);
    return ret; 
  }

  public virtual void Update() {
    SharingClientPINVOKE.DiscoveryClient_Update(swigCPtr);
  }

  public virtual void AddListener(DiscoveryClientListener newListener) {
    SharingClientPINVOKE.DiscoveryClient_AddListener(swigCPtr, DiscoveryClientListener.getCPtr(newListener));
  }

  public virtual void RemoveListener(DiscoveryClientListener oldListener) {
    SharingClientPINVOKE.DiscoveryClient_RemoveListener(swigCPtr, DiscoveryClientListener.getCPtr(oldListener));
  }

}

}
