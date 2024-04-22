using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
	[SerializeField] Vector3 offset;

	private void Start()
	{
		offset = transform.position - playerTransform.position;
		// 카메라 위치 - 플레이어 위치
	}

	private void Update()
	{
		transform.position = offset + playerTransform.position;
	}
}
