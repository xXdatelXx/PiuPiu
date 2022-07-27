using UnityEngine;
using System;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerAnimationView))]
public class Player : MonoBehaviour
{
    [SerializeField] private PlayerRotateView _horizontalRotate;
    [SerializeField] private VerticalRotateView _verticalRotate;
    private IInput _input;
    private PlayerMovement _movement;
    private PlayerAnimationView _view;

    public void Init(PlayerMovement movement, IInput input)
    {
        if (movement == null)
            throw new ArgumentNullException(movement.ToString());
        if (input == null)
            throw new ArgumentNullException(input.ToString());

        _movement = movement;
        _input = input;
    }

    private void Awake()
    {
        if (_horizontalRotate == null)
            throw new NullReferenceException(_horizontalRotate.ToString());
        if (_verticalRotate == null)
            throw new NullReferenceException(_verticalRotate.ToString());

        _view = GetComponent<PlayerAnimationView>();
    }

    private void Update()
    {
        _movement.Move(_input.GetAxis());
        _view.Move();
        Rotate();
    }

    private void Rotate()
    {
        _horizontalRotate.Rotate(_input.GetHorizontalMouse());
        _verticalRotate.Rotate(_input.GetVerticalMouse());
    }
}