using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private bool _isRotated;
    private bool _spacePressed;

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);

        _isRotated = false;
        _spacePressed = false;
    }
    
    void Update()
    {
        if (transform.rotation.x > 0.70f)
        {
            _isRotated = true;
        }
        if (!_isRotated)
        {
            transform.Rotate(200.0f * Time.deltaTime, 0.0f, 0.0f);
        }
        if(_isRotated)
        {
            if(_spacePressed)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 100);
            }
            else
            {
                transform.Rotate(0.0f, 0.0f, 1000.0f * Time.deltaTime);
            }

            if(Input.GetKeyDown(KeyCode.Space))
            {
                _spacePressed = true;
            }
        }
        //transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
