using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class InvalidRangeException<T> : ApplicationException
{
    private T start;
    private T end;

    // CONSTRUCTORS -------------------------------------------------------------
    public InvalidRangeException()
    {
    }

    public InvalidRangeException(T start, T end)
        : this(null, start, end)
    {
    }

    public InvalidRangeException(string msg, T start, T end)
        : base(msg)        
    {
        this.start = start;
        this.end = end;
    }

    public InvalidRangeException(string msg, Exception innerEx)
        : base(msg, innerEx)
    {
    }

    // PROPERTIES ----------------------------------------------------------------------
    public T Start
    {
        get
        {
            return this.start;
        }
    }

    public T End
    {
        get
        {
            return this.end;
        }
    }


    // METHODS ------------------------------------------------------------------------
    public override string Message
    {
        get
        {
           return string.Format("{0} Valid Range: {1} - {2}!",base.Message,  this.Start, this.End);
        }
    }
}

