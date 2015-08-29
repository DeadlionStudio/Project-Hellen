using UnityEngine;
using System.Collections;

public class DragNDrop : MonoBehaviour {
	Vector3 dist;
	float posX;
	float posY;

	private bool isMouseTriger = false;

	public bool IsMouseTriger {
		set {isMouseTriger = value;}
	}
	
	void OnMouseDown(){
		dist = Camera.main.WorldToScreenPoint(transform.position);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;
		
	}

	void OnMouseUp(){
	}
	
	void OnMouseDrag(){
		if (!isMouseTriger) {
			Vector3 curPos = 
				new Vector3 (Input.mousePosition.x - posX, 
				            Input.mousePosition.y - posY, dist.z);  
			
			Vector3 worldPos = Camera.main.ScreenToWorldPoint (curPos);
			transform.position = worldPos;
		}
	}
}
