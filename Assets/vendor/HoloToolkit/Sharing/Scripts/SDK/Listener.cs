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

public class Listener : System.IDisposable {
  private System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Listener(System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static System.Runtime.InteropServices.HandleRef getCPtr(Listener obj) {
    return (obj == null) ? new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Listener() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_Listener(swigCPtr);
        }
        swigCPtr = new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero);
      }
      System.GC.SuppressFinalize(this);
    }
  }

  public void UnregisterAll() {
    SharingClientPINVOKE.Listener_UnregisterAll(swigCPtr);
  }

  public bool IsRegistered() {
    bool ret = SharingClientPINVOKE.Listener_IsRegistered(swigCPtr);
    return ret;
  }

  public Listener() : this(SharingClientPINVOKE.new_Listener(), true) {
  }

}

}