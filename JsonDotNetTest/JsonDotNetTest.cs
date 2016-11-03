using Newtonsoft.Json;
using Ploeh.AutoFixture;
using Xunit;

namespace JsonDotNetTest
{
	public class JsonDotNetTest
	{
		[Fact]
		public void DeserializtionTest()
		{
			var fixture = new Fixture();

			var initial = fixture.Create<MutableClass>();

			var serialized = JsonConvert.SerializeObject(initial);

			var oldImmutable = JsonConvert.DeserializeObject<OldStyleImmutableClass>(serialized);
			var newImmutable = JsonConvert.DeserializeObject<NewStyleImmutableClass>(serialized);
			var missingConstructorProperty = JsonConvert.DeserializeObject<MissingConstructorProperty>(serialized);
			var oldWithDefaultConstructor = JsonConvert.DeserializeObject<OldStyleImmutableClassWithDefaultConstructor>(serialized);
			var newWithDefaultConstructor = JsonConvert.DeserializeObject<NewStyleImmutableClassWithDefaultConstructor>(serialized);


			Assert.Equal(initial.Property1, oldImmutable.Property1);
			Assert.Equal(initial.Guid1, oldImmutable.Guid1);
			Assert.Equal(initial.Int1, oldImmutable.Int1);

			Assert.Equal(initial.Property1, newImmutable.Property1);
			Assert.Equal(initial.Guid1, newImmutable.Guid1);
			Assert.Equal(initial.Int1, newImmutable.Int1);

			Assert.Equal(initial.Property1, missingConstructorProperty.Property1);
			Assert.NotEqual(initial.Guid1, missingConstructorProperty.Guid1);  // This property was not included in the constructor
			Assert.Equal(initial.Int1, missingConstructorProperty.Int1);

			Assert.NotEqual(initial.Property1, oldWithDefaultConstructor.Property1);
			Assert.NotEqual(initial.Guid1, oldWithDefaultConstructor.Guid1);
			Assert.NotEqual(initial.Int1, oldWithDefaultConstructor.Int1);

			Assert.NotEqual(initial.Property1, newWithDefaultConstructor.Property1);
			Assert.NotEqual(initial.Guid1, newWithDefaultConstructor.Guid1);
			Assert.NotEqual(initial.Int1, newWithDefaultConstructor.Int1);
		}
	}
}