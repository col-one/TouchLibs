using UnityEngine;
using System.Collections;

public class ExDragDropTouch : TouchAbstract {
	private Vector3 initPos;
	private Vector3 off=Vector3.zero;
	void OnTouchBegan()
	{
		initPos = touchedObject.transform.position;

		off = InitOffsetVector();
		InitLength();
	}
	void OnTouchMoved()
	{
		DragObject( 0.0f, 0.0f);
	}
	void OnTouchEnded()
	{
	}
}
