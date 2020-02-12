using AutoMapper;
using AutoMoq.Helpers;
using NUnit.Framework;
using TeacherMemo.Services.Implementation;

namespace TeacherMemo.Tests
{
    public class BaseTest<T> : AutoMoqTestFixture<T> where T : class
    {
        public BaseTest()
        {
            Mapper.Initialize(cfg => cfg.AddProfiles(
                typeof(MemoProfile).Assembly,
                typeof(Lab.Profiles.MemoProfile).Assembly
            ));
        }

        [SetUp]
        public void Setup()
        {
            ResetSubject();
        }

    }
}
