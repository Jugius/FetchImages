using System;

namespace FetchImages.Common;
public readonly struct OperationResult<TValue>
{
    public TValue Value { get; }
    public Exception Error { get; }
    public bool IsSuccess { get; }

    private OperationResult(TValue value)
    {
        Value = value;
        IsSuccess = true;
        Error = default;
    }
    private OperationResult(Exception error)
    {
        Error = error;
        IsSuccess = false;
        Value = default;
    }

    public static implicit operator OperationResult<TValue>(TValue value) => new OperationResult<TValue>(value);
    public static implicit operator OperationResult<TValue>(Exception error) => new OperationResult<TValue>(error);
}


