//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace PSMoveService {

public class PSMVector3i : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PSMVector3i(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PSMVector3i obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PSMVector3i() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PSMoveClientPINVOKE.delete_PSMVector3i(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int x {
    set {
      PSMoveClientPINVOKE.PSMVector3i_x_set(swigCPtr, value);
    } 
    get {
      int ret = PSMoveClientPINVOKE.PSMVector3i_x_get(swigCPtr);
      return ret;
    } 
  }

  public int y {
    set {
      PSMoveClientPINVOKE.PSMVector3i_y_set(swigCPtr, value);
    } 
    get {
      int ret = PSMoveClientPINVOKE.PSMVector3i_y_get(swigCPtr);
      return ret;
    } 
  }

  public int z {
    set {
      PSMoveClientPINVOKE.PSMVector3i_z_set(swigCPtr, value);
    } 
    get {
      int ret = PSMoveClientPINVOKE.PSMVector3i_z_get(swigCPtr);
      return ret;
    } 
  }

  public PSMVector3i() : this(PSMoveClientPINVOKE.new_PSMVector3i(), true) {
  }

}

}
