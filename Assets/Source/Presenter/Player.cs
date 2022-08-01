using UnityEngine;
using System;

[RequireComponent(typeof(PlayerAnimationView))]
[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(Armor))]
public class Player : MonoBehaviour
{
    [SerializeField] private PlayerRotateView _horizontalRotate;
    [SerializeField] private VerticalRotateView _verticalRotate;
    private IInput _input;
    private PlayerAnimationView _view;
    public PlayerMovement Movement { get; private set; }
    public Armor Armor { get; private set; }

    public void Init(IInput input)
    {
        if (input == null)
            throw new ArgumentNullException("input == null");

        _input = input;
        Subscribe();
    }

    private void Awake()
    {
        if (_horizontalRotate == null || _verticalRotate == null)
            throw new NullReferenceException("all SerializeFields must dont be null");

        _view = GetComponent<PlayerAnimationView>();
        Movement = GetComponent<PlayerMovement>();
        Armor = GetComponent<Armor>();
    }

    private void OnEnable()
    {
        if (_input != null)
            Subscribe();
    }

    private void OnDisable()
    {
        if (_input == null)
            return;

        _input.OnSeatDown -= SeatDown;
        _input.OnGetUp -= GetUp;
    }

    private void Subscribe()
    {
        _input.OnSeatDown += SeatDown;
        _input.OnGetUp += GetUp;
    }

    private void Update()
    {
        if (_input == null)
            return;

        Movement.Move(_input.GetAxis());
        _view.Move();
        Rotate();
    }

    private void Rotate()
    {
        _horizontalRotate.Rotate(_input.GetHorizontalMouse());
        _verticalRotate.Rotate(_input.GetVerticalMouse());
    }

    private void SeatDown()
    {
        Movement.SeatDown();
        _view.SeatDown();
    }

    private void GetUp()
    {
        Movement.GetUp();
        _view.GetUp();
    }
}