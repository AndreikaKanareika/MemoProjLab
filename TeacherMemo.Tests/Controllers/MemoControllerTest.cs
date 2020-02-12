using AutoFixture.NUnit3;
using AutoMapper;
using Lab.Controllers;
using Lab.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TeacherMemo.Domain;
using TeacherMemo.Services.Abstract;
using FluentAssertions;
using Lab.Validators;
using AutoFixture;

namespace TeacherMemo.Tests.Controllers
{
    class MemoControllerTest : BaseTest<MemoController>
    {
        private readonly CreateMemoValidator _createMemoValidator;
        private readonly UpdateMemoValidator _updateMemoValidator;
        private readonly Fixture _fixture;
        private readonly Random _random;
        

        public MemoControllerTest() : base()
        {
            _createMemoValidator = new CreateMemoValidator();
            _updateMemoValidator = new UpdateMemoValidator();
            _fixture = new Fixture();
            _random = new Random();
        }

        [Test]
        public void AddMethodWithValidModelShouldReturnCorrectResult()
        {
            var model = GenerateValidCreateMemoModel();

            var expectedValue = Mapper.Map<Memo>(model);
            expectedValue.Id = 1;

            _createMemoValidator.Validate(model);

            Mocked<IMemoService>()
                .Setup(x => x.Add(It.IsAny<Memo>()))
                .Returns(expectedValue);

            var actionResult = Subject.Post(model) as OkObjectResult;
            var result = actionResult.Value as MemoViewModel;

            result.Should().BeEquivalentTo(Mapper.Map<MemoViewModel>(expectedValue));
        }

        [Test]
        public void AddMethodWithInvalidModelShouldReturnError()
        {
            var model = GenerateInValidCreateMemoModel();

            var expectedValue = Mapper.Map<Memo>(model);
            expectedValue.Id = 1;

            var validationResult = _createMemoValidator.Validate(model);
            validationResult.IsValid.Should().BeFalse();
        }

        private CreateMemoViewModel GenerateValidCreateMemoModel()
        {
            return _fixture.Build<CreateMemoViewModel>()
                .With(x => x.SubjectName, Guid.NewGuid().ToString())
                .With(x => x.LabHours, _random.Next(100))
                .With(x => x.LectureHours, _random.Next(100))
                .With(x => x.LectureHours, _random.Next(100))
                .Create();
        }

        private CreateMemoViewModel GenerateInValidCreateMemoModel()
        {
            return _fixture.Build<CreateMemoViewModel>()
                .With(x => x.SubjectName, $"{Guid.NewGuid()}{Guid.NewGuid()}")
                .With(x => x.LabHours, -1)
                .With(x => x.LectureHours, -1)
                .With(x => x.LectureHours, -1)
                .Create();
        }

    }
}
