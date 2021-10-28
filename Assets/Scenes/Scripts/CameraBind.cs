using UnityEngine;

public class CameraBind : MonoBehaviour
{
    private GameObject _player;
    private Transform _trans;
    // Start is called before the first frame update
    //void Start()
    //{
    //    _player = GameObject.FindGameObjectWithTag("Player");
    //    if (_player != null)
    //        _trans = _player.transform;
    //}

    // Update is called once per frame
    void Update()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        //Debug.Log(_player);
        if (_player == null)
            return;
        _trans = _player.transform;
        Vector3 temp = transform.position;
        temp.x = _trans.position.x;
        temp.y = _trans.position.y + 2;
        transform.position = temp;
    }
}
