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

public class UserPresenceManagerListener : Listener {
  private System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UserPresenceManagerListener(System.IntPtr cPtr, bool cMemoryOwn) : base(SharingClientPINVOKE.UserPresenceManagerListener_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static System.Runtime.InteropServices.HandleRef getCPtr(UserPresenceManagerListener obj) {
    return (obj == null) ? new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UserPresenceManagerListener() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_UserPresenceManagerListener(swigCPtr);
        }
        swigCPtr = new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero);
      }
      System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual void OnUserPresenceChanged(User user) {
    if (SwigDerivedClassHasMethod("OnUserPresenceChanged", swigMethodTypes0)) SharingClientPINVOKE.UserPresenceManagerListener_OnUserPresenceChangedSwigExplicitUserPresenceManagerListener(swigCPtr, User.getCPtr(user)); else SharingClientPINVOKE.UserPresenceManagerListener_OnUserPresenceChanged(swigCPtr, User.getCPtr(user));
  }

  public UserPresenceManagerListener() : this(SharingClientPINVOKE.new_UserPresenceManagerListener(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnUserPresenceChanged", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateUserPresenceManagerListener_0(SwigDirectorOnUserPresenceChanged);
    SharingClientPINVOKE.UserPresenceManagerListener_director_connect(swigCPtr, swigDelegate0);
  }

  private bool SwigDerivedClassHasMethod(string methodName, System.Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(UserPresenceManagerListener));
    return hasDerivedMethod;
  }

  private void SwigDirectorOnUserPresenceChanged(System.IntPtr user) {
    OnUserPresenceChanged((user == System.IntPtr.Zero) ? null : new User(user, true));
  }

  public delegate void SwigDelegateUserPresenceManagerListener_0(System.IntPtr user);

  private SwigDelegateUserPresenceManagerListener_0 swigDelegate0;

  private static System.Type[] swigMethodTypes0 = new System.Type[] { typeof(User) };
}

}
