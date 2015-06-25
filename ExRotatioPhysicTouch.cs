using UnityEngine;
using System.Collections;

public class ExRotatioPhysicTouch : TouchAbstract {

	public float speedRotation = 2;
	public Vector2 clampX = Vector2.zero;
	public Vector2 clampY = Vector2.zero;
	public bool invert = false;
	private Vector2 swipXYFactor;
	private GameObject toto;
	public static Rigidbody rigid;
	public float drag = 20;
	
	void Start()
	{
		rigid = gameObject.GetComponent<Rigidbody>();
		rigid.angularDrag = drag;
	}
	void OnTouchMoved()
	{
		swipXYFactor = RotateTouchObject(transform.eulerAngles, speedRotation, clampX, clampY, invert);
		rigid.AddTorque(Vector3.up * swipXYFactor[1], ForceMode.VelocityChange);
		rigid.AddTorque(Vector3.forward * swipXYFactor[0], ForceMode.VelocityChange);
	}
	void OnTouchBegan()
	{
		rigid.angularVelocity=Vector3.zero;
	}
}
