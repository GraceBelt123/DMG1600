using UnityEngine: 

public class changeColor : MonoBehaviour {
	void update() {
		if (Input.GitKeyDown(KeyCod.R))
			GetComponent<Renderer>().material.color = Color.red;

	}

}
