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

public class Room : System.IDisposable {
  private System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Room(System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static System.Runtime.InteropServices.HandleRef getCPtr(Room obj) {
    return (obj == null) ? new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Room() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_Room(swigCPtr);
        }
        swigCPtr = new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero);
      }
      System.GC.SuppressFinalize(this);
    }
  }

  public virtual XString GetName() {
    System.IntPtr cPtr = SharingClientPINVOKE.Room_GetName(swigCPtr);
    XString ret = (cPtr == System.IntPtr.Zero) ? null : new XString(cPtr, true);
    return ret; 
  }

  public virtual long GetID() {
    long ret = SharingClientPINVOKE.Room_GetID(swigCPtr);
    return ret;
  }

  public virtual int GetUserCount() {
    int ret = SharingClientPINVOKE.Room_GetUserCount(swigCPtr);
    return ret;
  }

  public virtual int GetUserID(int userIndex) {
    int ret = SharingClientPINVOKE.Room_GetUserID(swigCPtr, userIndex);
    return ret;
  }

  public virtual bool GetKeepOpen() {
    bool ret = SharingClientPINVOKE.Room_GetKeepOpen(swigCPtr);
    return ret;
  }

  public virtual void SetKeepOpen(bool keepOpen) {
    SharingClientPINVOKE.Room_SetKeepOpen(swigCPtr, keepOpen);
  }

  public virtual int GetAnchorCount() {
    int ret = SharingClientPINVOKE.Room_GetAnchorCount(swigCPtr);
    return ret;
  }

  public virtual XString GetAnchorName(int index) {
    System.IntPtr cPtr = SharingClientPINVOKE.Room_GetAnchorName(swigCPtr, index);
    XString ret = (cPtr == System.IntPtr.Zero) ? null : new XString(cPtr, true);
    return ret; 
  }

  public const long kInvalidRoomID = -1L;
}

}
