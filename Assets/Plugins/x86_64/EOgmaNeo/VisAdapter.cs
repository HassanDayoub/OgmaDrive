//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace eogmaneo {

public class VisAdapter : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VisAdapter(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VisAdapter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VisAdapter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          eogmaneoPINVOKE.delete_VisAdapter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public VisAdapter() : this(eogmaneoPINVOKE.new_VisAdapter(), true) {
  }

  public void create(Hierarchy pHierarchy, int port) {
    eogmaneoPINVOKE.VisAdapter_create(swigCPtr, Hierarchy.getCPtr(pHierarchy), port);
  }

  public void update(float waitSeconds) {
    eogmaneoPINVOKE.VisAdapter_update__SWIG_0(swigCPtr, waitSeconds);
  }

  public void update() {
    eogmaneoPINVOKE.VisAdapter_update__SWIG_1(swigCPtr);
  }

}

}
