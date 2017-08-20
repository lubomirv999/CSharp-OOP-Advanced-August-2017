﻿using System;
using System.Collections;
using System.Collections.Generic;

public class ListyIterator<T> : IEnumerable<T>
{
    public ListyIterator()
    {
        this.Data = new List<T>();
        this.CurrentIndex = 0;
    }

    public ListyIterator(List<T> data)
    {
        this.Data = data;
        this.CurrentIndex = 0;
    }

    public List<T> Data { get; set; }

    public int CurrentIndex { get; set; }

    public bool Move()
    {
        if (this.Data.Count - 1 > this.CurrentIndex)
        {
            this.CurrentIndex++;
            return true;
        }

        return false;
    }

    public bool HasNext()
    {
        return this.CurrentIndex + 1 != this.Data.Count;
    }

    public void Print()
    {
        if (this.Data.Count == 0 || this.Data == null)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }

        Console.WriteLine(this.Data[this.CurrentIndex]);
    }

    public IEnumerator<T> GetEnumerator()
    {
        if (this.Data.Count == 0 || this.Data == null)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }

        for (int i = 0; i < this.Data.Count; i++)
        {
            yield return this.Data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}