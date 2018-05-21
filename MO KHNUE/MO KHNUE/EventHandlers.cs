using MO_KHNUE.Entities;

namespace MO_KHNUE
{
    public delegate void EmptyHandler();
    public delegate void BlockValueChangedHandler<T>(T currentValue);
    public delegate void StringChangeHandler(string text);
}