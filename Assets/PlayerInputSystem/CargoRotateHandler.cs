using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargoRotateHandler : MonoBehaviour
{
    [SerializeField] GameObject cargo;
    private Quaternion rotatonBase;
    private void Start()
    {
        rotatonBase = cargo.transform.rotation;
    }
    public void RotationControl()
    {
       cargo.transform.rotation = rotatonBase;
     
    }
}
