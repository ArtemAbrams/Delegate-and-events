using System.Collections;
using System.Collections.ObjectModel;

namespace ConsoleApp;
public class OwnCollection<T>: IEnumerable,  IEnumerator
{ 
    private T[] array;
    private int position = -1;

    public T this[int index]
    {
        get => array[index];
        set => array[index] = value;
    }
    public OwnCollection(params T[] array) => this.array = array;
    
    public OwnCollection()
    {
        array = Array.Empty<T>();
    }

    public void Reset() => position = -1;

    public object Current
    {
        get
        {
            if (position == -1 || position >= array.Length)
                throw new ArgumentException();
            return array[position];
        }
    }
    public  IEnumerator GetEnumerator()
    {
        return array.GetEnumerator();
    }

    public bool MoveNext()
    {
        if (position < array.Length - 1)
        {
            position++;
            return true;
        }
        else
            return false;
    }
    public void Append(T item)
    {
        int n = array.Length + 1;
        T[] arrayCopy = new T [n];
        for (int i = 0; i < n - 1; i++)
        {
            arrayCopy[i] = array[i];
        }
        arrayCopy[n - 1] = item;
        array = arrayCopy;
    }

    public int Length() => array.Length;
    public void NewCopy(ref OwnCollection<T> ownCollection)
    {
        array = new T[ownCollection.Length()];
        T item;
        for (int i = 0; i < array.Length; i++)
        {
            /*ownCollection.MoveNext();
            item = (T)ownCollection.Current;*/
            array[i] = ownCollection[i];

        }
    }

    public bool SearchItem(T item)
    {
        foreach (T i in array)
        {
            if (i.Equals(item))
            {
                return true;
            }
        }
        return false;
    }
    public void Pop()
    {
        int n = this.array.Length - 1;
        T[] array = new T[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = this.array[i];
        }
        this.array = array;
    }

    public void DeleteItem(T item)
    {
        int count = 0;
        foreach (var i in this.array)
        {
            if (i.Equals(item))
            {
                count++;
            }
        }
        T[] array = new T[this.array.Length-count];
        int index = 0;
        for (int i = 0; i < this.array.Length; i++)
        {
            if (!item.Equals(this.array[i]))
            {
                array[index] = this.array[i];
                index++;
            }
        }

        this.array = array;
    }
}