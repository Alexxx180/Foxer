using UnityEngine;
using UnityEngine.UI;

public class LoadLevels : MonoBehaviour
{
    public Animator animator;
    public GameObject model;
    public Slider slider;
    public Button play;
    public Sprite isAvailable;

    // Start is called before the first frame update
    public float runSpeed = 40f;

    float horizontalMove = 0f;
    private float _loadLevel = 0f;
    private const float _distance = 4.725f;
    private const float _loadPlus = 0.005f;
    
    void FixedUpdate()
    {
        if (_loadLevel >= 0.9f)
            return;
        horizontalMove = _loadPlus * runSpeed;
        if (_loadLevel + _loadPlus >= 0.9f)
        {
            horizontalMove = 0;
            play.interactable = true;
            play.image.sprite = isAvailable;
        }
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        Vector3 vect = model.transform.position;
        model.transform.position = new Vector3(vect.x + _distance * _loadPlus, vect.y, vect.z);
        _loadLevel += _loadPlus;
        slider.value = _loadLevel;
    }
}
