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
			var nonFullImmutable = JsonConvert.DeserializeObject<MissingConstructorProperty>(serialized);

			
			Assert.Equal(initial.Property1, oldImmutable.Property1);
			Assert.Equal(initial.Guid1, oldImmutable.Guid1);
			Assert.Equal(initial.Int1, oldImmutable.Int1);

			Assert.Equal(initial.Property1, newImmutable.Property1);
			Assert.Equal(initial.Guid1, newImmutable.Guid1);
			Assert.Equal(initial.Int1, newImmutable.Int1);

			Assert.Equal(initial.Property1, nonFullImmutable.Property1);
			Assert.NotEqual(initial.Guid1, nonFullImmutable.Guid1);
			Assert.Equal(initial.Int1, nonFullImmutable.Int1);
		}
	}
}