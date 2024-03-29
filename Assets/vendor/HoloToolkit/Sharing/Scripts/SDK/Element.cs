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

public class Element : System.IDisposable {
  private System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Element(System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static System.Runtime.InteropServices.HandleRef getCPtr(Element obj) {
    return (obj == null) ? new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Element() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_Element(swigCPtr);
        }
        swigCPtr = new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero);
      }
      System.GC.SuppressFinalize(this);
    }
  }

  public virtual ElementType GetElementType() {
    ElementType ret = (ElementType)SharingClientPINVOKE.Element_GetElementType(swigCPtr);
    return ret;
  }

  public virtual long GetGUID() {
    long ret = SharingClientPINVOKE.Element_GetGUID(swigCPtr);
    return ret;
  }

  public virtual XString GetName() {
    System.IntPtr cPtr = SharingClientPINVOKE.Element_GetName(swigCPtr);
    XString ret = (cPtr == System.IntPtr.Zero) ? null : new XString(cPtr, true);
    return ret; 
  }

  public virtual Element GetParent() {
    System.IntPtr cPtr = SharingClientPINVOKE.Element_GetParent(swigCPtr);
    Element ret = (cPtr == System.IntPtr.Zero) ? null : new Element(cPtr, true);
    return ret; 
  }

  public virtual bool IsValid() {
    bool ret = SharingClientPINVOKE.Element_IsValid(swigCPtr);
    return ret;
  }

}

}
