using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katapult : MonoBehaviour
{
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private GameObject _projectile;
    [SerializeField] private Rigidbody _topAnchorBody;
    [SerializeField] private Rigidbody _downAnchorBody;
    [SerializeField] private SpringJoint _spring;

    private bool _isLoaded;

    private void Start()
    {
        Pull();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Shoot();
        }    
    }

    public void Shoot()
    {
        if(_isLoaded)
            Release();
        else
            Reload();
    }

    public void Reload()
    {
        if (_isLoaded == false)
        {
            Pull();
            Instantiate(_projectile, _spawnPosition.position, Quaternion.identity);
            _isLoaded = true;
        }   
    }

    private void Pull()
    {
        _spring.connectedBody = _downAnchorBody;
    }

    private void Release()
    {
        _spring.connectedBody = _topAnchorBody;
        _isLoaded = false;
    }
}
