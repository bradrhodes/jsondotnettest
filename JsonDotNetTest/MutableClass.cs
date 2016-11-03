using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonDotNetTest
{
    public class MutableClass
    {
	    public string Property1 { get; set; }
	    public Guid Guid1 { get; set; }

	    public int Int1 { get; set; }
    }

	public class MissingConstructorProperty
	{
	    private readonly string _property1;
	    private readonly Guid _guid1;
	    private readonly int _int1;

	    public MissingConstructorProperty(string property1, int int1)
	    {
		    _property1 = property1;
		    _int1 = int1;
	    }

	    public string Property1 { get { return _property1; }  }
	    public Guid Guid1 { get { return _guid1; } }

	    public int Int1 { get { return _int1; } }
	}

	public class OldStyleImmutableClassWithDefaultConstructor
	{
	    private readonly string _property1;
	    private readonly Guid _guid1;
	    private readonly int _int1;

		public OldStyleImmutableClassWithDefaultConstructor()
		{
			
		}

	    public OldStyleImmutableClassWithDefaultConstructor(string property1, Guid guid1, int int1)
	    {
		    _property1 = property1;
		    _guid1 = guid1;
		    _int1 = int1;
	    }

	    public string Property1 { get { return _property1; }  }
	    public Guid Guid1 { get { return _guid1; } }

	    public int Int1 { get { return _int1; } }
	}

	public class OldStyleImmutableClassWithDefaultConstructorWithAttribute
	{
	    private readonly string _property1;
	    private readonly Guid _guid1;
	    private readonly int _int1;

		public OldStyleImmutableClassWithDefaultConstructorWithAttribute()
		{
			
		}

		[JsonConstructor]
	    public OldStyleImmutableClassWithDefaultConstructorWithAttribute(string property1, Guid guid1, int int1)
	    {
		    _property1 = property1;
		    _guid1 = guid1;
		    _int1 = int1;
	    }

	    public string Property1 { get { return _property1; }  }
	    public Guid Guid1 { get { return _guid1; } }

	    public int Int1 { get { return _int1; } }
	}

    public class OldStyleImmutableClass
    {
	    private readonly string _property1;
	    private readonly Guid _guid1;
	    private readonly int _int1;

	    public OldStyleImmutableClass(string property1, Guid guid1, int int1)
	    {
		    _property1 = property1;
		    _guid1 = guid1;
		    _int1 = int1;
	    }

	    public string Property1 { get { return _property1; }  }
	    public Guid Guid1 { get { return _guid1; } }

	    public int Int1 { get { return _int1; } }
    }

    public class NewStyleImmutableClass
    {
	    public NewStyleImmutableClass(string property1, Guid guid1, int int1)
	    {
		    Property1 = property1;
		    Guid1 = guid1;
		    Int1 = int1;
	    }

	    public string Property1 { get; }
	    public Guid Guid1 { get; }

	    public int Int1 { get; }
    }
    public class NewStyleImmutableClassWithDefaultConstructor
    {
	    public NewStyleImmutableClassWithDefaultConstructor()
	    {
		    
	    }
	    public NewStyleImmutableClassWithDefaultConstructor(string property1, Guid guid1, int int1)
	    {
		    Property1 = property1;
		    Guid1 = guid1;
		    Int1 = int1;
	    }

	    public string Property1 { get; }
	    public Guid Guid1 { get; }

	    public int Int1 { get; }
    }
    public class NewStyleImmutableClassWithDefaultConstructorAndAttribute
    {
	    public NewStyleImmutableClassWithDefaultConstructorAndAttribute()
	    {
		    
	    }

		[JsonConstructor]
	    public NewStyleImmutableClassWithDefaultConstructorAndAttribute(string property1, Guid guid1, int int1)
	    {
		    Property1 = property1;
		    Guid1 = guid1;
		    Int1 = int1;
	    }

	    public string Property1 { get; }
	    public Guid Guid1 { get; }

	    public int Int1 { get; }
    }
}
