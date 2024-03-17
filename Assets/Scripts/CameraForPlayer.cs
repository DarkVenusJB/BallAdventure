using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraForPlayer : MonoBehaviour
{
    [SerializeField] private float smooth;
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 dampOffset;

    private Vector3 _vel = Vector3.zero;
    private Transform _camera;

    private void Start()
    {
        _camera = GetComponent<Transform>();
        _camera.position = target.position + dampOffset;
    }

    private void LateUpdate()
    {
        _camera.position = Vector3.SmoothDamp(_camera.position, target.position + dampOffset, ref _vel, smooth);
    }
}
