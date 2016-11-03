using IQ.Platform.TestUtilities;
using Newtonsoft.Json;
using Ploeh.AutoFixture;
using Xunit;

namespace JsonDotNetTest
{
	public class JsonDotNetTest
	{
		[Theory, AutoFakeItEasyData]
		public void OldStyleImmutableTest(MutableClass initial)
		{
			var serialized = JsonConvert.SerializeObject(initial);

			var result = JsonConvert.DeserializeObject<OldStyleImmutableClass>(serialized);

			Assert.Equal(initial.Property1, result.Property1);
			Assert.Equal(initial.Guid1, result.Guid1);
			Assert.Equal(initial.Int1, result.Int1);
		}

		[Theory, AutoFakeItEasyData]
		public void NewStyleImmutableTest(MutableClass initial)
		{
			var serialized = JsonConvert.SerializeObject(initial);

			var result = JsonConvert.DeserializeObject<NewStyleImmutableClass>(serialized);

			Assert.Equal(initial.Property1, result.Property1);
			Assert.Equal(initial.Guid1, result.Guid1);
			Assert.Equal(initial.Int1, result.Int1);
		}

		[Theory, AutoFakeItEasyData]
		public void MissingConstructorPropertyTest(MutableClass initial)
		{
			var serialized = JsonConvert.SerializeObject(initial);

			var result = JsonConvert.DeserializeObject<MissingConstructorProperty>(serialized);

			Assert.Equal(initial.Property1, result.Property1);
			Assert.NotEqual(initial.Guid1, result.Guid1);
			Assert.Equal(initial.Int1, result.Int1);
		}

		[Theory, AutoFakeItEasyData]
		public void NewStyleImmutableWithDefautlConstructorTest(MutableClass initial)
		{
			var serialized = JsonConvert.SerializeObject(initial);

			var result = JsonConvert.DeserializeObject<NewStyleImmutableClassWithDefaultConstructor>(serialized);

			Assert.NotEqual(initial.Property1, result.Property1);
			Assert.NotEqual(initial.Guid1, result.Guid1);
			Assert.NotEqual(initial.Int1, result.Int1);
		}

		[Theory, AutoFakeItEasyData]
		public void OldStyleImmutableWithDefautlConstructorTest(MutableClass initial)
		{
			var serialized = JsonConvert.SerializeObject(initial);

			var result = JsonConvert.DeserializeObject<OldStyleImmutableClassWithDefaultConstructor>(serialized);

			Assert.NotEqual(initial.Property1, result.Property1);
			Assert.NotEqual(initial.Guid1, result.Guid1);
			Assert.NotEqual(initial.Int1, result.Int1);
		}

		[Theory, AutoFakeItEasyData]
		public void NewStyleImmutableWithDefautlConstructorAndAttributeTest(MutableClass initial)
		{
			var serialized = JsonConvert.SerializeObject(initial);

			var result = JsonConvert.DeserializeObject<NewStyleImmutableClassWithDefaultConstructorAndAttribute>(serialized);

			Assert.Equal(initial.Property1, result.Property1);
			Assert.Equal(initial.Guid1, result.Guid1);
			Assert.Equal(initial.Int1, result.Int1);
		}

		[Theory, AutoFakeItEasyData]
		public void OldStyleImmutableWithDefautlConstructorAndAttributeTest(MutableClass initial)
		{
			var serialized = JsonConvert.SerializeObject(initial);

			var result = JsonConvert.DeserializeObject<NewStyleImmutableClassWithDefaultConstructorAndAttribute>(serialized);

			Assert.Equal(initial.Property1, result.Property1);
			Assert.Equal(initial.Guid1, result.Guid1);
			Assert.Equal(initial.Int1, result.Int1);
		}


	}
}