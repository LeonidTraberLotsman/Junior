using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class train : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		Vector3 A = transform.position;
		Vector3 B = new Vector3(0, 3, 7);
		StartCoroutine(Move(A, B, 60));
	}

	public IEnumerator Move(Vector3 startPoint, Vector3 endPoint, int frames)
	{
		Vector3 S = endPoint - startPoint; //находим путь, как условное расстояние между сёлами
		Vector3 v = S / frames;//находим скорость деля всё на время

		for (int i = 0; i < frames; i++)
		{
			transform.position = startPoint + i * v;
			yield return null;
		}
		transform.position = endPoint;
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}
