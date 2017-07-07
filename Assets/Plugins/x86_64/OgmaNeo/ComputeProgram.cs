//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace ogmaneo {

public class ComputeProgram : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ComputeProgram(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ComputeProgram obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ComputeProgram() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          csogmaneoPINVOKE.delete_ComputeProgram(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public bool loadFromFile(string name, ComputeSystem cs) {
    bool ret = csogmaneoPINVOKE.ComputeProgram_loadFromFile(swigCPtr, name, ComputeSystem.getCPtr(cs));
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool loadHierarchyKernel(ComputeSystem cs) {
    bool ret = csogmaneoPINVOKE.ComputeProgram_loadHierarchyKernel(swigCPtr, ComputeSystem.getCPtr(cs));
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool loadPredictorKernel(ComputeSystem cs) {
    bool ret = csogmaneoPINVOKE.ComputeProgram_loadPredictorKernel(swigCPtr, ComputeSystem.getCPtr(cs));
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool loadSparseFeaturesKernel(ComputeSystem cs, SparseFeaturesType type) {
    bool ret = csogmaneoPINVOKE.ComputeProgram_loadSparseFeaturesKernel(swigCPtr, ComputeSystem.getCPtr(cs), (int)type);
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_cl__Program getProgram() {
    SWIGTYPE_p_cl__Program ret = new SWIGTYPE_p_cl__Program(csogmaneoPINVOKE.ComputeProgram_getProgram(swigCPtr), false);
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ComputeProgram() : this(csogmaneoPINVOKE.new_ComputeProgram(), true) {
  }

}

}
