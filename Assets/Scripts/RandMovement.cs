using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandMovement : MonoBehaviour
{
  [SerializeField] float rayDistance;
  [SerializeField] private float moveSpeed;
  [SerializeField] private LayerMask _layerMask;

  private void FixedUpdate()
  {
      SetRay();
  }


  private RaycastHit SetRay()
  {
      
      RaycastHit hit = new RaycastHit();
      float angleCos;
      Vector3 dir = transform.TransformDirection(new Vector3(0, 0, 1));
      //Debug.Log(transform.TransformDirection(new Vector3(0, 0, 1)));
      if (Physics.Raycast(transform.position, dir, out hit, rayDistance, _layerMask))
      {
          Debug.DrawLine(transform.position, hit.point, Color.green);
          angleCos = Vector3.Dot(dir, hit.normal) / Vector3.Magnitude(dir) * Vector3.Magnitude(hit.normal); // косинус угла между нормалью и падающим вектором, теперь надо пределить куда вращать чела.
      }
      else
      {
          Debug.DrawRay(transform.position, transform.TransformDirection(new Vector3(0, 0, 1)) * rayDistance, Color.red);
      }
      
      return hit;
  }
  
}
