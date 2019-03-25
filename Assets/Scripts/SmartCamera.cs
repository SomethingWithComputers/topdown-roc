using UnityEngine;

public class SmartCamera : MonoBehaviour
{
    [SerializeField] private Player _player = null;

    private Camera _camera = null;

    private int _currentGridX = 0;
    private int _currentGridY = 0;
    private float _halfScreenHeight = 0.0f;
    private float _halfScreenWidth = 0.0f;
    private float _screenHeight = 0.0f;
    private float _screenWidth = 0.0f;

    private Vector3 _target = new Vector3();

    protected void Start()
    {
        _camera = GetComponent<Camera>();

        _halfScreenHeight = _camera.orthographicSize;
        _halfScreenWidth = _halfScreenHeight * _camera.aspect;

        _screenHeight = _halfScreenHeight * 2.0f;
        _screenWidth = _halfScreenWidth * 2.0f;

        Debug.Log(_halfScreenWidth + " " + _halfScreenHeight);

        _target = transform.position;
    }

    // Update is called once per frame
    protected void Update()
    {
        Vector3 playerPosition = _player.transform.position;

        // Start at (0, 0)
        int gridX = 0;
        int gridY = 0;

        // Horizontal movement
        if (playerPosition.x < 0)
        {
            gridX = (int) ((playerPosition.x - _halfScreenWidth) / _screenWidth);
        }
        else if (playerPosition.x > 0)
        {
            gridX = (int) ((playerPosition.x + _halfScreenWidth) / _screenWidth);
        }

        // Vertical movement
        if (playerPosition.y < 0)
        {
            gridY = (int) ((playerPosition.y - _halfScreenHeight) / _screenHeight);
        }
        else if (playerPosition.y > 0)
        {
            gridY = (int) ((playerPosition.y + _halfScreenHeight) / _screenHeight);
        }

        // Check if we're somewhere else now
        if (gridX != _currentGridX || gridY != _currentGridY)
        {
            _currentGridX = gridX;
            _currentGridY = gridY;

            // So we keep the z value
            Vector3 newTarget = transform.position;
            newTarget.x = _currentGridX * _screenWidth;
            newTarget.y = _currentGridY * _screenHeight;
            _target = newTarget;
        }
        
        transform.position -= (transform.position - _target) / 8.0f;
    }
}