using AutoFixture.NUnit3;
using AutoMapper;
using AutoMoq.Helpers;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeacherMemo.Domain;
using TeacherMemo.Persistence.Abstact;
using TeacherMemo.Persistence.Abstact.Entities;
using TeacherMemo.Services.Abstract;
using TeacherMemo.Services.Implementation;
using TeacherMemo.Shared.Exceptions;

namespace TeacherMemo.Tests.Services
{
    [TestFixture]
    public class MemoServiceTest : BaseTest<MemoService>
    {
        // Autofixture library generate input parameters automatically
        [Test, AutoData]
        public void GetAllShouldReturnCollection(MemoEntity[] items)
        {
            Mocked<IMemoRepository>()
                .Setup(x => x.GetAll())
                .Returns(items);

            var result = Subject.GetAll();

            Assert.AreEqual(result.Count(), items.Length);
        }

        [Test, AutoData]
        public void UpdateShouldBeSuccess(MemoEntity item)
        {
            Mocked<IMemoRepository>()
                .Setup(x => x.Get(It.IsAny<int>()))
                .Returns(item);

            var obj = Mapper.Map<Memo>(item);

            Assert.DoesNotThrow(() => Subject.Update(obj));
        }

        [Test, AutoData]
        public void UpdateShouldThrowNotFoundException(MemoEntity item)
        {
            Mocked<IMemoRepository>()
                .Setup(x => x.Get(It.IsAny<int>()))
                .Returns(null as MemoEntity);

            var obj = Mapper.Map<Memo>(item);
            obj.Id = -1;    // set not exists id

            Assert.Throws<NotFoundException>(() => Subject.Update(obj));
        }
    }
}
