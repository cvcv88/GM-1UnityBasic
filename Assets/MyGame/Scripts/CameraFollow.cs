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
		// ī�޶� ��ġ - �÷��̾� ��ġ
	}

	private void Update()
	{
		transform.position = offset + playerTransform.position;
	}
}
