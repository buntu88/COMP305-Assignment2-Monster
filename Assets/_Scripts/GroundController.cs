using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour {

    private GameController _gameController;
    private Vector3 _playerSpawnPoint;
    // Use this for initialization
    void Start () {
        this._gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent("GameController") as GameController;
        this._playerSpawnPoint = new Vector3(482f, 67.5f, 2434f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter (Collision other)
    {
        Transform playerTransform = other.gameObject.GetComponent<Transform>();
        playerTransform.position = this._playerSpawnPoint;

        this._gameController.LivesValue--;
        //Destroy(other.gameObject);
        
    }
}
