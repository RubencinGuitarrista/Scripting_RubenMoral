using System.Collections;
using System.Collections.Generic;  
using UnityEngine;

public class player : MonoBehaviour
{
  public GameObject fireballPrefab
  public Transform attackPoint

  if (Input.GetMouseButtonDown(0))
  {
      Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
  }
}
