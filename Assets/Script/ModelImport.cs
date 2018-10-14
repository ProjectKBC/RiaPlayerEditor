using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelImport : MonoBehaviour {

	[SerializeField]
    public GameObject model;
	private GameObject insModel;
    public Vector3 speed = Vector3.one;
    public Vector3 Speed { get { return speed * Time.deltaTime * 60; } }

    private void Start()
    {
        insModel = Instantiate(model);
    }

	private void Update () 
	{
        insModel.transform.Rotate(Speed.x, Speed.y, Speed.z, Space.World);
	}
}
