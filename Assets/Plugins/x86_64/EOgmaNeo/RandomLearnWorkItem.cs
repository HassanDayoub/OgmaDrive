//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace eogmaneo {

public class RandomLearnWorkItem : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RandomLearnWorkItem(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RandomLearnWorkItem obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RandomLearnWorkItem() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          eogmaneoPINVOKE.delete_RandomLearnWorkItem(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public RandomEncoder _pEncoder {
    set {
      eogmaneoPINVOKE.RandomLearnWorkItem__pEncoder_set(swigCPtr, RandomEncoder.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = eogmaneoPINVOKE.RandomLearnWorkItem__pEncoder_get(swigCPtr);
      RandomEncoder ret = (cPtr == global::System.IntPtr.Zero) ? null : new RandomEncoder(cPtr, false);
      return ret;
    } 
  }

  public int _cx {
    set {
      eogmaneoPINVOKE.RandomLearnWorkItem__cx_set(swigCPtr, value);
    } 
    get {
      int ret = eogmaneoPINVOKE.RandomLearnWorkItem__cx_get(swigCPtr);
      return ret;
    } 
  }

  public int _cy {
    set {
      eogmaneoPINVOKE.RandomLearnWorkItem__cy_set(swigCPtr, value);
    } 
    get {
      int ret = eogmaneoPINVOKE.RandomLearnWorkItem__cy_get(swigCPtr);
      return ret;
    } 
  }

  public float _alpha {
    set {
      eogmaneoPINVOKE.RandomLearnWorkItem__alpha_set(swigCPtr, value);
    } 
    get {
      float ret = eogmaneoPINVOKE.RandomLearnWorkItem__alpha_get(swigCPtr);
      return ret;
    } 
  }

  public float _gamma {
    set {
      eogmaneoPINVOKE.RandomLearnWorkItem__gamma_set(swigCPtr, value);
    } 
    get {
      float ret = eogmaneoPINVOKE.RandomLearnWorkItem__gamma_get(swigCPtr);
      return ret;
    } 
  }

  public RandomLearnWorkItem() : this(eogmaneoPINVOKE.new_RandomLearnWorkItem(), true) {
  }

  public void run(uint threadIndex) {
    eogmaneoPINVOKE.RandomLearnWorkItem_run(swigCPtr, threadIndex);
  }

}

}
