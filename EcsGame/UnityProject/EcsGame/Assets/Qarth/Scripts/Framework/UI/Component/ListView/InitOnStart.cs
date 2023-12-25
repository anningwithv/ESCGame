





using UnityEngine;
using System.Collections;

[RequireComponent(typeof(GameFrame.LoopScrollRect))]
[DisallowMultipleComponent]
public class InitOnStart : MonoBehaviour {
	void Start () {
        GetComponent<GameFrame.LoopScrollRect>().RefillCells();
	}
}
