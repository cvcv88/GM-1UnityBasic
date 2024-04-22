using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{
    [SerializeField] float rotateSpeed;

	private void Update()
	{
		transform.Rotate(Vector3.up * rotateSpeed, Space.World);
	}
}
