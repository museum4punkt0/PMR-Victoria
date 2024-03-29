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

public class ObjectElementListener : Listener {
  private System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ObjectElementListener(System.IntPtr cPtr, bool cMemoryOwn) : base(SharingClientPINVOKE.ObjectElementListener_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static System.Runtime.InteropServices.HandleRef getCPtr(ObjectElementListener obj) {
    return (obj == null) ? new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ObjectElementListener() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_ObjectElementListener(swigCPtr);
        }
        swigCPtr = new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero);
      }
      System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual void OnBoolElementChanged(long elementID, bool newValue) {
    if (SwigDerivedClassHasMethod("OnBoolElementChanged", swigMethodTypes0)) SharingClientPINVOKE.ObjectElementListener_OnBoolElementChangedSwigExplicitObjectElementListener(swigCPtr, elementID, newValue); else SharingClientPINVOKE.ObjectElementListener_OnBoolElementChanged(swigCPtr, elementID, newValue);
  }

  public virtual void OnIntElementChanged(long elementID, int newValue) {
    if (SwigDerivedClassHasMethod("OnIntElementChanged", swigMethodTypes1)) SharingClientPINVOKE.ObjectElementListener_OnIntElementChangedSwigExplicitObjectElementListener(swigCPtr, elementID, newValue); else SharingClientPINVOKE.ObjectElementListener_OnIntElementChanged(swigCPtr, elementID, newValue);
  }

  public virtual void OnLongElementChanged(long elementID, long newValue) {
    if (SwigDerivedClassHasMethod("OnLongElementChanged", swigMethodTypes2)) SharingClientPINVOKE.ObjectElementListener_OnLongElementChangedSwigExplicitObjectElementListener(swigCPtr, elementID, newValue); else SharingClientPINVOKE.ObjectElementListener_OnLongElementChanged(swigCPtr, elementID, newValue);
  }

  public virtual void OnFloatElementChanged(long elementID, float newValue) {
    if (SwigDerivedClassHasMethod("OnFloatElementChanged", swigMethodTypes3)) SharingClientPINVOKE.ObjectElementListener_OnFloatElementChangedSwigExplicitObjectElementListener(swigCPtr, elementID, newValue); else SharingClientPINVOKE.ObjectElementListener_OnFloatElementChanged(swigCPtr, elementID, newValue);
  }

  public virtual void OnDoubleElementChanged(long elementID, double newValue) {
    if (SwigDerivedClassHasMethod("OnDoubleElementChanged", swigMethodTypes4)) SharingClientPINVOKE.ObjectElementListener_OnDoubleElementChangedSwigExplicitObjectElementListener(swigCPtr, elementID, newValue); else SharingClientPINVOKE.ObjectElementListener_OnDoubleElementChanged(swigCPtr, elementID, newValue);
  }

  public virtual void OnStringElementChanged(long elementID, XString newValue) {
    if (SwigDerivedClassHasMethod("OnStringElementChanged", swigMethodTypes5)) SharingClientPINVOKE.ObjectElementListener_OnStringElementChangedSwigExplicitObjectElementListener(swigCPtr, elementID, XString.getCPtr(newValue)); else SharingClientPINVOKE.ObjectElementListener_OnStringElementChanged(swigCPtr, elementID, XString.getCPtr(newValue));
  }

  public virtual void OnElementAdded(Element element) {
    if (SwigDerivedClassHasMethod("OnElementAdded", swigMethodTypes6)) SharingClientPINVOKE.ObjectElementListener_OnElementAddedSwigExplicitObjectElementListener(swigCPtr, Element.getCPtr(element)); else SharingClientPINVOKE.ObjectElementListener_OnElementAdded(swigCPtr, Element.getCPtr(element));
  }

  public virtual void OnElementDeleted(Element element) {
    if (SwigDerivedClassHasMethod("OnElementDeleted", swigMethodTypes7)) SharingClientPINVOKE.ObjectElementListener_OnElementDeletedSwigExplicitObjectElementListener(swigCPtr, Element.getCPtr(element)); else SharingClientPINVOKE.ObjectElementListener_OnElementDeleted(swigCPtr, Element.getCPtr(element));
  }

  public ObjectElementListener() : this(SharingClientPINVOKE.new_ObjectElementListener(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnBoolElementChanged", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateObjectElementListener_0(SwigDirectorOnBoolElementChanged);
    if (SwigDerivedClassHasMethod("OnIntElementChanged", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateObjectElementListener_1(SwigDirectorOnIntElementChanged);
    if (SwigDerivedClassHasMethod("OnLongElementChanged", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateObjectElementListener_2(SwigDirectorOnLongElementChanged);
    if (SwigDerivedClassHasMethod("OnFloatElementChanged", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateObjectElementListener_3(SwigDirectorOnFloatElementChanged);
    if (SwigDerivedClassHasMethod("OnDoubleElementChanged", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateObjectElementListener_4(SwigDirectorOnDoubleElementChanged);
    if (SwigDerivedClassHasMethod("OnStringElementChanged", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateObjectElementListener_5(SwigDirectorOnStringElementChanged);
    if (SwigDerivedClassHasMethod("OnElementAdded", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateObjectElementListener_6(SwigDirectorOnElementAdded);
    if (SwigDerivedClassHasMethod("OnElementDeleted", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateObjectElementListener_7(SwigDirectorOnElementDeleted);
    SharingClientPINVOKE.ObjectElementListener_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7);
  }

  private bool SwigDerivedClassHasMethod(string methodName, System.Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ObjectElementListener));
    return hasDerivedMethod;
  }

  private void SwigDirectorOnBoolElementChanged(long elementID, bool newValue) {
    OnBoolElementChanged(elementID, newValue);
  }

  private void SwigDirectorOnIntElementChanged(long elementID, int newValue) {
    OnIntElementChanged(elementID, newValue);
  }

  private void SwigDirectorOnLongElementChanged(long elementID, long newValue) {
    OnLongElementChanged(elementID, newValue);
  }

  private void SwigDirectorOnFloatElementChanged(long elementID, float newValue) {
    OnFloatElementChanged(elementID, newValue);
  }

  private void SwigDirectorOnDoubleElementChanged(long elementID, double newValue) {
    OnDoubleElementChanged(elementID, newValue);
  }

  private void SwigDirectorOnStringElementChanged(long elementID, System.IntPtr newValue) {
    OnStringElementChanged(elementID, (newValue == System.IntPtr.Zero) ? null : new XString(newValue, true));
  }

  private void SwigDirectorOnElementAdded(System.IntPtr element) {
    OnElementAdded((element == System.IntPtr.Zero) ? null : new Element(element, true));
  }

  private void SwigDirectorOnElementDeleted(System.IntPtr element) {
    OnElementDeleted((element == System.IntPtr.Zero) ? null : new Element(element, true));
  }

  public delegate void SwigDelegateObjectElementListener_0(long elementID, bool newValue);
  public delegate void SwigDelegateObjectElementListener_1(long elementID, int newValue);
  public delegate void SwigDelegateObjectElementListener_2(long elementID, long newValue);
  public delegate void SwigDelegateObjectElementListener_3(long elementID, float newValue);
  public delegate void SwigDelegateObjectElementListener_4(long elementID, double newValue);
  public delegate void SwigDelegateObjectElementListener_5(long elementID, System.IntPtr newValue);
  public delegate void SwigDelegateObjectElementListener_6(System.IntPtr element);
  public delegate void SwigDelegateObjectElementListener_7(System.IntPtr element);

  private SwigDelegateObjectElementListener_0 swigDelegate0;
  private SwigDelegateObjectElementListener_1 swigDelegate1;
  private SwigDelegateObjectElementListener_2 swigDelegate2;
  private SwigDelegateObjectElementListener_3 swigDelegate3;
  private SwigDelegateObjectElementListener_4 swigDelegate4;
  private SwigDelegateObjectElementListener_5 swigDelegate5;
  private SwigDelegateObjectElementListener_6 swigDelegate6;
  private SwigDelegateObjectElementListener_7 swigDelegate7;

  private static System.Type[] swigMethodTypes0 = new System.Type[] { typeof(long), typeof(bool) };
  private static System.Type[] swigMethodTypes1 = new System.Type[] { typeof(long), typeof(int) };
  private static System.Type[] swigMethodTypes2 = new System.Type[] { typeof(long), typeof(long) };
  private static System.Type[] swigMethodTypes3 = new System.Type[] { typeof(long), typeof(float) };
  private static System.Type[] swigMethodTypes4 = new System.Type[] { typeof(long), typeof(double) };
  private static System.Type[] swigMethodTypes5 = new System.Type[] { typeof(long), typeof(XString) };
  private static System.Type[] swigMethodTypes6 = new System.Type[] { typeof(Element) };
  private static System.Type[] swigMethodTypes7 = new System.Type[] { typeof(Element) };
}

}
