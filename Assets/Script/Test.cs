using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private Vector3 speed = Vector3.one;

    public Vector3 Speed { get { return speed * Time.deltaTime * 60; } }

    private Transform trans;

    private void Awake()
    {
        this.trans = this.transform;
    }

    private void Update()
    {
        this.trans.Rotate(Speed.x, Speed.y, Speed.z, Space.World);
    }
}
