namespace RandomizerTests;


        public enum FlagsType
        {
            None = 0,
            Flag1,
            Flag2,
            Flag3,
            Flag4,
            Flag5,
        }

        [Fact]
        public void EnumFlags()
        {
            var xx = _faker.Random.EnumFlags(_faker.Random.Int(1, 5), FlagsType.None);
            _outptuHelper.WriteLine(xx.ToString());

            xx.Should().NotBe(FlagsType.None);
        }
